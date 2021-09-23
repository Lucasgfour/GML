
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.custo {
	public partial class CSCustoCategoria : Form {
		
		private ObjectDao<Custo_categoria> cDao = new ObjectDao<Custo_categoria>();
		private LinkedList<Custo_categoria> categorias;
		
		public CSCustoCategoria() {
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
			listaCategoria.Items.Clear();
			Resultado busca = cDao.listar();
			if(!busca.condicao) {
				MessageBox.Show(busca.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				this.categorias = (LinkedList<Custo_categoria>) busca.resultado;
				foreach (Custo_categoria cat in categorias) {
					ListViewItem lv = new ListViewItem();
					lv.Text = cat.codigo.ToString();
					lv.SubItems.Add(cat.nome);
					listaCategoria.Items.Add(lv);
				}
			}
		}
		
		void cliqueAdicionar(object sender, EventArgs e) {
			CDCustoCategoria cdcat = new CDCustoCategoria();
			if(cdcat.ShowDialog() == DialogResult.OK) {
				pesquisar();
			}
		}
		
		void cliqueEditar(object sender, EventArgs e) {
			try {
				Custo_categoria cat = categorias.ElementAt(listaCategoria.FocusedItem.Index);
				CDCustoCategoria cdcat = new CDCustoCategoria(cat);
				if(cdcat.ShowDialog() == DialogResult.OK) {
					pesquisar();
				}
			} catch (Exception) { }
		}
		
		void cliqueRemover(object sender, EventArgs e) {
			try {
				Custo_categoria cat = categorias.ElementAt(listaCategoria.FocusedItem.Index);
				if(MessageBox.Show("Tem certeza ? Essa ação não pode ser desfeita.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					MessageBox.Show(cDao.delete(cat).mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					pesquisar();
				}
			} catch (Exception) { }
		}
	}
}
