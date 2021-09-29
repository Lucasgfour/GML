
using System;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;

namespace GM.View.relatorio {
	public partial class DGParametro : Form {
		
		private Relatorio_Parametro parametro;
		
		public DGParametro(Relatorio_Parametro parametro) {
			this.parametro = parametro;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			this.Show();
			labParametro.Text = parametro.tipoToString() + " :";
			labTitulo.Text = "INSIRA O PARÂMETRO " + parametro.parametro;
			txtParametro.Focus();
		}
		
		void maskParametro(object sender, EventArgs e) {
			if(parametro.tipo == 1) {
				Ferramentas.maskNumber(txtParametro);
			} else if(parametro.tipo == 2) {
				Ferramentas.maskMoney(txtParametro);
			} else if(parametro.tipo == 3) {
				Ferramentas.maskData(txtParametro);
			} 
		}
		
		void pressionar(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Escape) {
				this.DialogResult = DialogResult.Cancel;
			} else if(e.KeyCode == Keys.Enter) {
				btnOK.PerformClick();
			}
		}
		
		public String getValor() {
			return txtParametro.Text;
		}
		
		void cliqueOK(object sender, EventArgs e) {
			try {
				if(parametro.tipo == 0) {
					if(txtParametro.Text.Equals("")) {
						this.DialogResult = DialogResult.Cancel;
					} else {
						this.DialogResult = DialogResult.OK;
					}
				} else if(parametro.tipo == 1) {
					int.Parse(txtParametro.Text);
					this.DialogResult = DialogResult.OK;
				} else if(parametro.tipo == 2) {
					float.Parse(txtParametro.Text);
					this.DialogResult = DialogResult.OK;
				} else if(parametro.tipo == 3) {
					DateTime.Parse(txtParametro.Text);
					this.DialogResult = DialogResult.OK;
				}
			} catch (Exception) {
				this.DialogResult = DialogResult.Cancel;
			}
		}
	}
}
