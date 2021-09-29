
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using GM.View.contas;

namespace GM.View.custo {
	public partial class CSCusto : Form {
		
		private int codigo;
		private Custo custo;
		private DataTable contas;
		
		private ObjectDao<Custo> cDao = new ObjectDao<Custo>();
		
		public CSCusto(int codigo) {
			this.codigo = codigo;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else if(this.codigo > 0) {
				pesquisar(codigo);
			} else {
				primeiro();
			}
		}
		
		private void primeiro() {
			Resultado resCodigo = new Comando("SELECT codigo FROM custo ORDER BY codigo DESC LIMIT 1").consultarValor();
			if(resCodigo.condicao) {
				pesquisar(resCodigo.converter<int>());
			} else {
				MessageBox.Show("Não foi localizado nenhum Custo/Despesa ! Detalhes : " + resCodigo.mensagem, "Sem resultado", MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		private void pesquisar(int codigo) {
			Resultado resCusto = cDao.consultar(codigo);
			if(!resCusto.condicao) {
				MessageBox.Show("Não localizado, motivo : " + resCusto.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				primeiro();
			} else {
				this.custo = resCusto.converter<Custo>();
				txtCodigo.Text = custo.codigo.ToString();
				try { txtFornecedor.Text = new Comando("SELECT nome FROM pessoa WHERE codigo = " + custo.pessoa.ToString()).consultarValor().resultado.ToString(); } catch (Exception) { txtFornecedor.Text = "Não Localizado"; }
				try { txtLoja.Text = new Comando("SELECT nome FROM sede WHERE codigo = " + custo.sede.ToString()).consultarValor().resultado.ToString(); } catch (Exception) { txtLoja.Text = "Não Localizado"; }
				txtEmissao.Text = custo.emissao.ToString("dd/MM/yyyy");
				cbxTipo.SelectedIndex = custo.tipo;
				txtDescricao.Text = custo.descricao;
				txtValor.Text = "R$ " + String.Format("{0:N}", custo.valor);
				Resultado busCategoria = new ObjectDao<Custo_categoria>().consultar(custo.categoria);
				if(busCategoria.condicao) {
					txtCategoria.Text = busCategoria.converter<Custo_categoria>().nome;
				} else {
					txtCategoria.Text = custo.categoria.ToString();
				}
				txtObservacao.Text = custo.observacao;
				
				Comando busParcela = new Comando("SELECT codigo, sequencia, vencimento, valor, contas_saldo(codigo) AS saldo FROM contas WHERE refe_nome = @rnome AND refe_cod = @rcodigo ORDER BY sequencia ASC");
				busParcela.addParametro("@rnome", rNome());
				busParcela.addParametro("@rcodigo", custo.codigo);
				
				listaParcelas.Items.Clear();
				
				Resultado resParcela = busParcela.consultarToDataTable();
				if(resParcela.condicao) {
					contas = resParcela.converter<DataTable>();
					foreach (DataRow dt in contas.Rows) {
						ListViewItem itm = new ListViewItem();
						itm.Text = dt[0].ToString().PadLeft(6, '0');
						itm.SubItems.Add(dt[1].ToString());
						itm.SubItems.Add(DateTime.Parse(dt[2].ToString()).ToString("dd/MM/yyyy"));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", float.Parse(dt[3].ToString())));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", float.Parse(dt[4].ToString())));
						listaParcelas.Items.Add(itm);
					}
				}
			}
		}
		
		private String rNome() {
			if(custo.tipo == 0) {
				return "Custo";
			} else {
				return "Despesa";
			}
		}
		
		void cliqueIr(object sender, EventArgs e) {
			try {
				pesquisar(int.Parse(txtCodigo.Text));
			} catch (Exception) { }	
		}
		
		void pressionarEnterCodigo(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				btnAbrir.PerformClick();	
			}
		}
		
		void duploCliqueParcela(object sender, EventArgs e) {
			try {
				int codigoParcela = int.Parse(contas.Rows[listaParcelas.FocusedItem.Index][0].ToString());
				CSConta cscon = new CSConta(codigoParcela);
				cscon.ShowDialog();
			} catch (Exception) { }
		}
		
		void duploCliquePesquisa(object sender, MouseEventArgs e) {
			Resultado pq = Pesquisa.custo();
			if(pq.condicao) {
				txtCodigo.Text = pq.converter<Custo>().codigo.ToString();
				btnAbrir.PerformClick();
			}
		}
	}
}
