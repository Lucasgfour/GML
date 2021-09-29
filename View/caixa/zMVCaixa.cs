
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;

namespace GM.View.caixa {
	public partial class zMVCaixa : UserControl {
		
		public Caixa caixa;
		public float saldo;
		public bool sim;
			
		public zMVCaixa(Caixa caixa, float saldo, bool sim) {
			this.caixa = caixa;
			this.saldo = saldo;
			this.sim = sim;
			InitializeComponent();
		}
		
		
		
		void Arranque(object sender, EventArgs e) {
			if(sim) {
				this.BackColor = Color.White;
			} else {
				this.BackColor = Color.FromArgb(234, 234, 234);
			}
			
			txtDescricao.Text = caixa.descricao;
			txtOrigem.Text = caixa.refe_nome;
			if(caixa.tipo == 0) {
				txtValor.Text = "R$ -" + String.Format("{0:N}", caixa.valor);	
				txtValor.ForeColor = Color.DarkRed;
			} else {
				txtValor.Text = "R$ " + String.Format("{0:N}", caixa.valor);	
				txtValor.ForeColor = Color.Green;
			}
			
		}
	}
}
