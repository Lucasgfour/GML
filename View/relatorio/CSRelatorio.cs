
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.relatorio {
	public partial class CSRelatorio : Form {
		
		private ObjectDao<Relatorio> rDao = new ObjectDao<Relatorio>();
		private LinkedList<Relatorio> relatorios;
		private Relatorio relato;
		
		public CSRelatorio() {
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
			}
		}
		
		private void pesquisar() {
			Resultado resuRela = rDao.listar("SELECT * FROM relatorio WHERE permissao <= " + Ferramentas.sessao.permissao.ToString() + " ORDER BY descricao ASC");
			listaRelatorios.Items.Clear();
			this.relato = null;
			txtDescricao.Text = "";
			txtObservacao.Text = "";
			if(!resuRela.condicao) {
				MessageBox.Show(resuRela.mensagem, "Resultado busca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				relatorios = resuRela.converter<LinkedList<Relatorio>>();
				foreach (Relatorio res in relatorios) {
					listaRelatorios.Items.Add(res.descricao);
				}
			}
		}

		
		void mudancaSelecionado(object sender, EventArgs e) {
			try {
				this.relato = relatorios.ElementAt(listaRelatorios.FocusedItem.Index);
				txtDescricao.Text = this.relato.descricao;
				txtObservacao.Text = this.relato.observacao;
			} catch (Exception) {
				this.relato = null;
				txtDescricao.Text = "";
				txtObservacao.Text = "";
			}
		}
		
		void cliqueNovo(object sender, EventArgs e) {
			CDRelatorio cd = new CDRelatorio();
			if(cd.ShowDialog() == DialogResult.OK) {
				pesquisar();
			}
		}

		void cliqueEditar(object sender, EventArgs e) {
			if(relato == null) {
				MessageBox.Show("Nenhum relatório selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				CDRelatorio cd = new CDRelatorio(relato.codigo);
				if(cd.ShowDialog() == DialogResult.OK) {
					pesquisar();
				}
			}
		}
		
		void cliqueRemover(object sender, EventArgs e) {
			MessageBox.Show("Ainda não implantado.");
		}
		
		
		void cliqueGerarTabela(object sender, EventArgs e) {
			if(relato == null) {
				MessageBox.Show("Nenhum relatório selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				Controller.relatorio.gerarTela(this.relato);
			}
			
		}
		
		void cliqueGerarWeb(object sender, EventArgs e) {
			if(relato == null) {
				MessageBox.Show("Nenhum relatório selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				Controller.relatorio.gerarWeb(this.relato);
			}
		}
		
		void cliqueGerarGrafico(object sender, EventArgs e) {
			if(relato == null) {
				MessageBox.Show("Nenhum relatório selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				Controller.relatorio.gerarGrafico(this.relato);
			}
		}
		
		void UiSymbolButton1Click(object sender, EventArgs e) {
			if(relato == null) {
				MessageBox.Show("Nenhum relatório selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				Controller.relatorio.gerarPDF(this.relato);
			}
		}
	}
}
