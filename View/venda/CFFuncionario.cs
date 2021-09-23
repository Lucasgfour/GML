
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;

namespace GM.View.venda {
	public partial class CFFuncionario : Form {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private Usuario user;
		private LinkedList<Venda_Produto> itens;
		private int sede;
				
		public CFFuncionario(LinkedList<Venda_Produto> itens, Usuario funcionario, int sede) {
			this.user = funcionario;
			this.sede = sede;
			this.itens = itens;
			InitializeComponent();
		}
		
		void maskNumber(object sender, EventArgs e) {
			Ferramentas.maskNumber(txtPin);
		}
		
		void pressionarEnter(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				if(txtPin.Text == this.user.pin) {
					this.Opacity = 0;
					if(new CDBalcao2(this.itens, this.user, this.sede).ShowDialog() == DialogResult.OK) {
						this.DialogResult = DialogResult.OK;
					} else {
						this.DialogResult = DialogResult.Cancel;
					}
				} else {
					MessageBox.Show("PIN incorreto.", "Pin", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPin.Text = "";
				}
			} else if(e.KeyCode == Keys.Escape) {
				this.DialogResult = DialogResult.Cancel;
			}
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			this.Show();
			txtPin.Focus();
		}
	}
}
