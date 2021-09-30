
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.custo {
	public partial class PQCustoCategoria : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		public Custo_categoria saida;
		public LinkedList<Custo_categoria> categorias;
		
		public PQCustoCategoria() {
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			pesquisar("");
		}
		
		private void pesquisar(String nome) {
			Comando com = new Comando("SELECT * FROM custo_categoria WHERE nome LIKE @Nome");
			com.addParametro("@Nome", "%" + nome + "%");
			
			listaCategoria.Items.Clear();
			Resultado busca = com.listar<Custo_categoria>();
			if(busca.condicao) {
				categorias = busca.converter<LinkedList<Custo_categoria>>();
				foreach (Custo_categoria cat in categorias) {
					ListViewItem lv = new ListViewItem();
					lv.Text = cat.codigo.ToString();
					lv.SubItems.Add(cat.nome);
					listaCategoria.Items.Add(lv);
				}
			}
		}
		
		private void selecionar() {
			try {
				Custo_categoria cat = categorias.ElementAt(listaCategoria.FocusedItem.Index);
				saida = cat;
				this.DialogResult = DialogResult.OK;
			} catch (Exception) { }
		}
		
		void cliquePesquisar(object sender, EventArgs e) {
			pesquisar(txtPesquisa.Text);
		}
		
		void cliqueSair(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
		}
		
		void cliqueSelecionar(object sender, EventArgs e) {
			selecionar();
		}
		
		void duploCliqueLista(object sender, MouseEventArgs e) {
			selecionar();
		}
		
		void pressionarEnterPesquisa(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				pesquisar(txtPesquisa.Text);
			}
		}
	}
}
