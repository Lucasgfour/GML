
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;

namespace GM.View.relatorio {
	public partial class GRTela : Form {
		
		private DataTable dados;
		
		public GRTela(DataTable dados) {
			this.dados = dados;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				dgDados.DataSource = this.dados;
			}
		}
	}
}
