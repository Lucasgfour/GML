
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.condicao {
	public partial class CSCondicao : Form {
		
		private ObjectDao<Condicao> cDao = new ObjectDao<Condicao>();
		private LinkedList<Condicao> condicoes = new LinkedList<Condicao>();
		
		
		public CSCondicao() {
			InitializeComponent();
		}
		
		private void pesquisar() {
			Resultado res = cDao.listar("SELECT * FROM condicao WHERE CONCAT(codigo, nome, condicao) LIKE '%" + txtPesquisa.Text.Replace("'", "") + "%' LIMIT 100");
			listaCondicao.Items.Clear();
			if(!res.condicao) {
				MessageBox.Show("Não foi encontrado resultado(s)." + res.mensagem, "Sem resultados",MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				condicoes = res.converter<LinkedList<Condicao>>();
				foreach (Condicao cond in condicoes) {
					ListViewItem itm = new ListViewItem();
					itm.Text = cond.codigo.ToString();
					itm.SubItems.Add(cond.nome);
					itm.SubItems.Add(cond.condicao);
					listaCondicao.Items.Add(itm);
				}
			}
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
			}
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			pesquisar();
		}
		
		void pressEnter(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				pesquisar();
			}
		}
		
		void cliqueAdicionar(object sender, EventArgs e) {
			CDCondicao cd = new CDCondicao();
			if(cd.ShowDialog() == DialogResult.OK) {
				pesquisar();
			}
		}
		
		void cliqueEditar(object sender, EventArgs e) {
			try {
				CDCondicao cd = new CDCondicao(condicoes.ElementAt(listaCondicao.FocusedItem.Index));
				if(cd.ShowDialog() == DialogResult.OK) {
					pesquisar();
				}	
			} catch (Exception) { }
		}
	}
}
