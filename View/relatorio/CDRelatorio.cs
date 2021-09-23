
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.relatorio {
	public partial class CDRelatorio : Form {
		
		private Relatorio relatorio = new Relatorio();
		private LinkedList<Relatorio_Parametro> parametros = new LinkedList<Relatorio_Parametro>();
		private int codigo = 0;
		
		private ObjectDao<Relatorio> rDao = new ObjectDao<Relatorio>();
		private ObjectDao<Relatorio_Parametro> pDao = new ObjectDao<Relatorio_Parametro>();
		
		public CDRelatorio() {
			InitializeComponent();
		}
		
		public CDRelatorio(int codigo) {
			this.codigo = codigo;
			InitializeComponent();
		}

		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				cbxNivel.SelectedIndex = 0;
				cbxTipo.SelectedIndex = 0;
				if(this.codigo > 0) {
					Resultado resuRel = rDao.consultar(codigo);
					Resultado resuPar = pDao.listar("SELECT * FROM relatorio_parametro WHERE relatorio = " + codigo.ToString());
					if(!resuRel.condicao) {
						MessageBox.Show("Relatório não localizado ! Detalhes : " + resuRel.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();
					} else {
						relatorio = resuRel.converter<Relatorio>();
						txtDescricao.Text = relatorio.descricao;
						txtComando.Text = relatorio.comando;
						txtObservação.Text = relatorio.observacao;
						cbxNivel.SelectedIndex = relatorio.permissao;
						
						if(resuPar.condicao) {
							parametros = resuPar.converter<LinkedList<Relatorio_Parametro>>();
							Atualizar();
						}
					}
				}
			}
		}
		
		private void Atualizar() {
			listaParametro.Items.Clear();
			foreach (Relatorio_Parametro p in parametros) {
				ListViewItem itm = new ListViewItem();
				itm.Text = p.parametro;
				itm.SubItems.Add(p.tipoToString());
				listaParametro.Items.Add(itm);
			}
		}
		
		void cliqueAdicionar(object sender, EventArgs e) {
			if(txtParametro.Text.Equals("")) {
				MessageBox.Show("Favor informar o parâmetro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtParametro.Focus();
			} else if(!txtParametro.Text.Substring(0, 1).Equals("@")) {
				MessageBox.Show("Parâmetro deve começar com @ (Ex.: @codigo)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtParametro.Focus();
			} else {
				Relatorio_Parametro par = new Relatorio_Parametro();
				par.parametro = txtParametro.Text;
				par.tipo = cbxTipo.SelectedIndex;
				
				bool adic = true;
				foreach (Relatorio_Parametro p in parametros) {
					if(p.parametro.Equals(par.parametro)) {
						MessageBox.Show("Já existe esse parâmetro !", "Parâmetro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
						adic = false;
						txtParametro.Focus();
					}
				}
				
				if(adic) {
					parametros.AddLast(par);
					Atualizar();
					txtParametro.Text = "";
					txtParametro.Focus();
				}
			}
		}
		
		void pressionarEnterParametro(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				btnAdicionar.PerformClick();
			}
		}
		
		void cliqueRemover(object sender, EventArgs e) {
			try {
				int posicao = listaParametro.FocusedItem.Index;
				LinkedList<Relatorio_Parametro> novo = new LinkedList<Relatorio_Parametro>();
				for (int i = 0; i < parametros.Count; i++) {
					if(i != posicao) {
						novo.AddLast(parametros.ElementAt(i));
					}
				}
				parametros = novo;
				Atualizar();
			} catch (Exception) { }
		}
		
		void cliqueSair(object sender, EventArgs e) {
			this.Close();
		}
		
		void cliqueSalvar(object sender, EventArgs e) {
			if(txtDescricao.Text.Equals("")) {
				MessageBox.Show("Descrição não informada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(txtComando.Text.Equals("")) {
				MessageBox.Show("Comando não informado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(validarComando()) {
				
				relatorio.descricao = txtDescricao.Text;
				relatorio.comando = txtComando.Text;
				relatorio.observacao = txtObservação.Text;
				relatorio.permissao = cbxNivel.SelectedIndex;
				
				Resultado resSalva = new Resultado(false, "Não executado.");
				if(relatorio.codigo > 0) {
					resSalva = rDao.alterar(relatorio);
					if(resSalva.condicao) {
						Comando com = new Comando("DELETE FROM relatorio_parametro WHERE relatorio = " + relatorio.codigo);
						com.executar();
					}
				} else {
					Comando sv = new Comando("SELECT NewRelatorio(@desc, @obse, @perm, @com)");
					sv.addParametro("@desc", relatorio.descricao);
					sv.addParametro("@obse", relatorio.observacao);
					sv.addParametro("@perm", relatorio.permissao);
					sv.addParametro("@com", relatorio.comando);
					
					resSalva = sv.consultarValor();
					if(resSalva.condicao) {
						relatorio.codigo = resSalva.converter<int>();
					}
				}
				
				String mensagem = "== INSERÇÃO/ALTERAÇÃO RELATÓRIO ==" + Environment.NewLine + resSalva.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + resSalva.mensagem + Environment.NewLine;
				
				if(resSalva.condicao) {
					mensagem = mensagem + Environment.NewLine + "== INSERÇÃO/ALTERAÇÃO DE PARÂMETROS ==" + Environment.NewLine;
					foreach (Relatorio_Parametro par in parametros) {
						par.relatorio = relatorio.codigo;
						Resultado resPar = pDao.inserir(par);
						mensagem = mensagem + resPar.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + resPar.mensagem + Environment.NewLine;
					}
				}
				
				MessageBox.Show(mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if(resSalva.condicao) {
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
		}
		
		private bool validarComando() {
			String[] chaves = new String[] { "UPDATE", "DELETE", "CREATE", "ALTER", "INSERT", "* FROM USUARIO", "FROM USUARIO", "SENHA" };
			String comando = txtComando.Text;
			bool saida = true;
			foreach (String chave in chaves) {
				if(comando.ToUpper().Contains(chave)) {
					saida = false;
					MessageBox.Show("Comando não permitido detectado :" + chave, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			return saida;
		}
	}
}
