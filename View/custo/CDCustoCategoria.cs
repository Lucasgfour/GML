
using System;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.custo {
	public partial class CDCustoCategoria : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private Custo_categoria categoria = new Custo_categoria();
		private ObjectDao<Custo_categoria> cDao = new ObjectDao<Custo_categoria>();
		
		public CDCustoCategoria() {
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		public CDCustoCategoria(Custo_categoria categoria) {
			this.categoria = categoria;
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(this.categoria.codigo > 0) {
				txtNome.Text = this.categoria.nome;
			}
		}
		
		private void salvar() {
			if(txtNome.Text.Equals("")) {
				MessageBox.Show("Favor informar o nome da categoria !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				// Setar dados
				this.categoria.nome = txtNome.Text;
				
				Resultado res = new Resultado(false, "Não realizado");
				if(this.categoria.codigo > 0) {
					res = cDao.alterar(this.categoria);
				} else {
					res = cDao.inserir(this.categoria);
				}
				
				if(res.condicao) {
					this.DialogResult = DialogResult.OK;
				} else {
					MessageBox.Show(res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
			}
		}
		
		void cliqueSalvar(object sender, EventArgs e) { salvar(); }
		
		void cliqueSair(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }
		
		void pressionarEnter(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				salvar();
			}
		}
	}
}
