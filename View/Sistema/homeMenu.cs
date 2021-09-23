
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.View.compra;
using GM.View.contas;
using GM.View.estoque;
using GM.View.produto;
using GM.View.venda;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.Sistema {
	public partial class homeMenu : MaterialForm {
		
	
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		public homeMenu() {
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
    		materialSkinManager.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			atualizarVisual();
		}
		
		private void atualizarVisual() {
			this.Text = "GML - Olá, seja bem-vindo " + Ferramentas.sessao.nome;
			foreach (TabPage tb in TabControle.TabPages) {
				foreach (Control ct in tb.Controls.OfType<Button>()) {
					if(ct.Name.Contains("btnF")) {
						ct.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
						((Button) ct).FlatAppearance.BorderColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
					} 
				}
			}
		}
		
	// === Botões para abrir telas ================================================================
	
	// === Telas ==============================
		private selectSede vendaBalcao;	
		private CSVenda vendaConsulta;
		private CSCompra compraConsulta;
		private CSEstoque estoqueConsulta;
		private CSProduto produtoConsulta;
		private CSFamilia familiaConsulta;
		private CSPagar pagarConsulta;
		private CSPagar receberConsulta;
	// ========================================
		
		void cliqueVendaBalcao(object sender, EventArgs e) {
			try {
				vendaBalcao.WindowState = FormWindowState.Minimized;
				vendaBalcao.WindowState = FormWindowState.Normal;
				vendaBalcao.Show();
			} catch (Exception) {
				vendaBalcao = new selectSede();
				vendaBalcao.Show();
			}
		}
		
		void cliqueVendaConsulta(object sender, EventArgs e) {
			try {
				vendaConsulta.WindowState = FormWindowState.Minimized;
				vendaConsulta.WindowState = FormWindowState.Normal;
				vendaConsulta.Show();
			} catch (Exception) {
				vendaConsulta = new CSVenda();
				vendaConsulta.Show();
			}
		}
		
		void cliqueCompraConsulta(object sender, EventArgs e) {
			try {
				compraConsulta.WindowState = FormWindowState.Minimized;
				compraConsulta.WindowState = FormWindowState.Normal;
				compraConsulta.Show();
			} catch (Exception) {
				compraConsulta = new CSCompra();
				compraConsulta.Show();
			}
		}
		
		void cliqueEstoqueConsulta(object sender, EventArgs e) {
			try {
				estoqueConsulta.WindowState = FormWindowState.Minimized;
				estoqueConsulta.WindowState = FormWindowState.Normal;
				estoqueConsulta.Show();
			} catch (Exception) {
				estoqueConsulta = new CSEstoque();
				estoqueConsulta.Show();
			}
		}
	
		void cliqueProdutoConsulta(object sender, EventArgs e) {
			try {
				produtoConsulta.WindowState = FormWindowState.Minimized;
				produtoConsulta.WindowState = FormWindowState.Normal;
				produtoConsulta.Show();
			} catch (Exception) {
				produtoConsulta = new CSProduto();
				produtoConsulta.Show();
			}
		}
	
		void cliqueFamiliaConsulta(object sender, EventArgs e) {
			try {
				familiaConsulta.WindowState = FormWindowState.Minimized;
				familiaConsulta.WindowState = FormWindowState.Normal;
				familiaConsulta.Show();
			} catch (Exception) {
				familiaConsulta = new CSFamilia();
				familiaConsulta.Show();
			}
		}
	
		void cliquePagarConsulta(object sender, EventArgs e) {
			try {
				pagarConsulta.WindowState = FormWindowState.Minimized;
				pagarConsulta.WindowState = FormWindowState.Normal;
				pagarConsulta.Show();
			} catch (Exception) {
				pagarConsulta = new CSPagar(0);
				pagarConsulta.Show();
			}
		}
	
		void cliqueReceberConsulta(object sender, EventArgs e) {
			try {
				receberConsulta.WindowState = FormWindowState.Minimized;
				receberConsulta.WindowState = FormWindowState.Normal;
				receberConsulta.Show();
			} catch (Exception) {
				receberConsulta = new CSPagar(1);
				receberConsulta.Show();
			}
		}
	}
	
	
	
	
}
