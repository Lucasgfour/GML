
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using GM.View.compra;
using GM.View.condicao;
using GM.View.contas;
using GM.View.custo;
using GM.View.estoque;
using GM.View.pessoa;
using GM.View.produto;
using GM.View.relatorio;
using GM.View.venda;

namespace GM.View.Sistema {
	public partial class novaHome : Form {
		
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,  int nWidthEllipse, int nHeightEllipse);
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x00020000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private CSVenda csvenda;
		private CDVenda cdvenda;
		private CDBalcao cdbalcao;
		private CSCredito cscred;
		
		private CSCompra cscompra;
		private CDCompra cdcompra;
		
		private CSProduto csproduto;
		private CSFamilia csfamilia;
		private CSEstoque csestoque;
		
		private CSPagar cspagar;
		private CSPagar csconta;
		
		private CDCusto cdcusto;
		private CSCusto cscusto;
		
		private CSCondicao cscondicao;
		private CDPessoa cdpessoa;
		private CTUsuario ctusuario;
		private CTModulo ctmodulo;
		private CSRelatorio csrelatorio;
		
		
		public novaHome() {
			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}

		
		void openConsultaVenda(object sender, EventArgs e) {
			try {
				csvenda.WindowState = FormWindowState.Minimized;
				csvenda.WindowState = FormWindowState.Normal;
				csvenda.Show();
			} catch (Exception) {
				csvenda = new CSVenda();
				csvenda.Show();
			}
		}
		
		void openCadastrarVenda(object sender, EventArgs e) {
			try {
				cdvenda.WindowState = FormWindowState.Minimized;
				cdvenda.WindowState = FormWindowState.Normal;
				cdvenda.Show();
			} catch (Exception) {
				cdvenda = new CDVenda();
				cdvenda.Show();
			}
		}
		
		void openBalcao(object sender, EventArgs e) {
//			try {
//				cdbalcao.WindowState = FormWindowState.Minimized;
//				cdbalcao.WindowState = FormWindowState.Normal;
//				cdbalcao.Show();
//			} catch (Exception) {
//				cdbalcao = new CDBalcao();
//				cdbalcao.Show();
//			}
		}
		
		void openConsultaCompra(object sender, EventArgs e) {
			try {
				cscompra.WindowState = FormWindowState.Minimized;
				cscompra.WindowState = FormWindowState.Normal;
				cscompra.Show();
			} catch (Exception) {
				cscompra = new CSCompra();
				cscompra.Show();
			}
		}
		
		void openCadastrarCompra(object sender, EventArgs e) {
			try {
				cdcompra.WindowState = FormWindowState.Minimized;
				cdcompra.WindowState = FormWindowState.Normal;
				cdcompra.Show();
			} catch (Exception) {
				cdcompra = new CDCompra();
				cdcompra.Show();
			}
		}
		
		void openConsultaProduto(object sender, EventArgs e) {
			try {
				csproduto.WindowState = FormWindowState.Minimized;
				csproduto.WindowState = FormWindowState.Normal;
				csproduto.Show();
			} catch (Exception) {
				csproduto = new CSProduto();
				csproduto.Show();
			}
		}
		
		void openConsultaFamilia(object sender, EventArgs e) {
			try {
				csfamilia.WindowState = FormWindowState.Minimized;
				csfamilia.WindowState = FormWindowState.Normal;
				csfamilia.Show();
			} catch (Exception) {
				csfamilia = new CSFamilia();
				csfamilia.Show();
			}
		}
		
		void openConsultaEstoque(object sender, EventArgs e) {
			try {
				csestoque.WindowState = FormWindowState.Minimized;
				csestoque.WindowState = FormWindowState.Normal;
				csestoque.Show();
			} catch (Exception) {
				csestoque = new CSEstoque();
				csestoque.Show();
			}
		}
		
		void openConsultaCPagar(object sender, EventArgs e) {
			try {
				cspagar.WindowState = FormWindowState.Minimized;
				cspagar.WindowState = FormWindowState.Normal;
				cspagar.Show();
			} catch (Exception) {
				cspagar = new CSPagar(0);
				cspagar.Show();
			}
		}
		
		void openConsultaCReceber(object sender, EventArgs e) {
			try {
				csconta.WindowState = FormWindowState.Minimized;
				csconta.WindowState = FormWindowState.Normal;
				csconta.Show();
			} catch (Exception) {
				csconta = new CSPagar(1);
				csconta.Show();
			}
		}
		
		void openCustoDespesa(object sender, EventArgs e) {
			try {
				cscusto.WindowState = FormWindowState.Minimized;
				cscusto.WindowState = FormWindowState.Normal;
				cscusto.Show();
			} catch (Exception) {
				Resultado resCusto = new ObjectDao<Custo>().consultar("SELECT * FROM custo LIMIT 1");
				if(resCusto.condicao) {
					cscusto = new CSCusto(resCusto.converter<Custo>().codigo);
					cscusto.Show();	
				}
				
			}
		}
		
		void openConsultaCustoDespesa(object sender, EventArgs e) {
			try {
				cdcusto.WindowState = FormWindowState.Minimized;
				cdcusto.WindowState = FormWindowState.Normal;
				cdcusto.Show();
			} catch (Exception) {
				cdcusto = new CDCusto();
				cdcusto.Show();
			}
		}
		
		void openCondicaoPagamento(object sender, EventArgs e) {
			try {
				cscondicao.WindowState = FormWindowState.Minimized;
				cscondicao.WindowState = FormWindowState.Normal;
				cscondicao.Show();
			} catch (Exception) {
				cscondicao = new CSCondicao();
				cscondicao.Show();
			}
		}
		
		void openCadastroPessoa(object sender, EventArgs e) {
			try {
				cdpessoa.WindowState = FormWindowState.Minimized;
				cdpessoa.WindowState = FormWindowState.Normal;
				cdpessoa.Show();
			} catch (Exception) {
				cdpessoa = new CDPessoa();
				cdpessoa.Show();
			}
		}
		
		void oepnControleUsuario(object sender, EventArgs e) {
			try {
				ctusuario.WindowState = FormWindowState.Minimized;
				ctusuario.WindowState = FormWindowState.Normal;
				ctusuario.Show();
			} catch (Exception) {
				ctusuario = new CTUsuario();
				ctusuario.Show();
			}
		}
		
		void openControleModulo(object sender, EventArgs e) {
			try {
				ctmodulo.WindowState = FormWindowState.Minimized;
				ctmodulo.WindowState = FormWindowState.Normal;
				ctmodulo.Show();
			} catch (Exception) {
				ctmodulo = new CTModulo();
				ctmodulo.Show();
			}
		}
		
		void openRelatorio(object sender, EventArgs e) {
			try {
				csrelatorio.WindowState = FormWindowState.Minimized;
				csrelatorio.WindowState = FormWindowState.Normal;
				csrelatorio.Show();
			} catch (Exception) {
				csrelatorio = new CSRelatorio();
				csrelatorio.Show();
			}
		}
		
		bool questionar = true;
		void confirmaSair(object sender, FormClosingEventArgs e) {
			if(questionar) {
				if(MessageBox.Show("Tem certeza que deseja sair ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					questionar = false;
					Application.Exit();
				} else {
					e.Cancel = true;
				}
			}
		}
		
		void cliqueSair(object sender, EventArgs e) {
			this.Close();
		}
		
		void cliqueMinimizar(object sender, EventArgs e) {
			this.WindowState = FormWindowState.Minimized;
		}
		
		void openCredito(object sender, EventArgs e) {
			try {
				cscred.WindowState = FormWindowState.Minimized;
				cscred.WindowState = FormWindowState.Normal;
				cscred.Show();
			} catch (Exception) {
				cscred = new CSCredito();
				cscred.Show();
			}
		}
		
		void teste(object sender, EventArgs e)
		{
			new CSCustoCategoria().Show();
		}
	}
}
