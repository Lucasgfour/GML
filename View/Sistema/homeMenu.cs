
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;
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
using GM.View.relatorio.programado;
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
			bwkRelatorio.RunWorkerAsync();
		}
		
		private void atualizarVisual() {
			this.Text = "GML - " + Ferramentas.sessao.nome;
			foreach (TabPage tb in TabControle.TabPages) {
				foreach (Control ct in tb.Controls.OfType<Button>()) {
					if(ct.Name.Contains("btnF")) {
						ct.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
						((Button) ct).FlatAppearance.BorderColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
					} 
				}
			}
		}
		
		void ProcessoProgramado(object sender, System.ComponentModel.DoWorkEventArgs e) {
			String log = "= " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + Environment.NewLine;
			Resultado res = Controller.relatorio.getRelatorio();
			if(!res.condicao) {
				log = log + "Erro Externo : " + res.mensagem + Environment.NewLine;
			} else {
				DataTable dados = res.converter<DataTable>();
				
				foreach (DataRow lin in dados.Rows) {
					Comando com = new Comando(lin[3].ToString());
					Resultado resDados = com.consultarToDataTable();
					if(!resDados.condicao) {
						log = log + "erro Linha :" + lin[0].ToString() + " - " + resDados.mensagem + Environment.NewLine;
					} else {
						try {
							String gerarPDF = Controller.relatorio.gerarPDF(resDados.converter<DataTable>());
							if(!gerarPDF.Equals("")) {
								Email em = new Email(lin[1].ToString(), lin[2].ToString(), gerarPDF);
								Resultado resEmail = em.SendMail(em.email, em.assunto, em.anexo);
								log = log + "Linha :" + lin[0].ToString() + " - " + resEmail.mensagem + Environment.NewLine;
							}
							
							
						} catch (Exception erro) {
							log = log + "erro Linha :" + lin[0].ToString() + " - " + erro.Message + Environment.NewLine;
						}
					}
				}
			}
			
			File.WriteAllText(Application.StartupPath + "\\programados.log", log, System.Text.Encoding.UTF8);
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
		private CDCusto custoCadastro;
		private CSCusto custoConsulta;
		private CSCredito creditoConsulta;
		private CSCondicao condicaoConsulta;
		private CSRelatorio relatorioConsulta;
		private CDPessoa pessoaConsulta;
		private CTModulo permissaoUsuario;
		private CTUsuario usuarioControl;
		private CSProgramado programadoConsulta;
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
		
		void cliqueCustoCadastro(object sender, EventArgs e) {
			try {
				custoCadastro.WindowState = FormWindowState.Minimized;
				custoCadastro.WindowState = FormWindowState.Normal;
				custoCadastro.Show();
			} catch (Exception) {
				custoCadastro = new CDCusto();
				custoCadastro.Show();
			}
		}
	
		void cliqueCustoConsulta(object sender, EventArgs e) {
			try {
				custoConsulta.WindowState = FormWindowState.Minimized;
				custoConsulta.WindowState = FormWindowState.Normal;
				custoConsulta.Show();
			} catch (Exception) {
				Resultado resCusto = new ObjectDao<Custo>().consultar("SELECT * FROM custo LIMIT 1");
				if(resCusto.condicao) {
					custoConsulta = new CSCusto(resCusto.converter<Custo>().codigo);
					custoConsulta.Show();
				}
			}
		}
		
		void cliqueCreditoConsulta(object sender, EventArgs e) {
			try {
				creditoConsulta.WindowState = FormWindowState.Minimized;
				creditoConsulta.WindowState = FormWindowState.Normal;
				creditoConsulta.Show();
			} catch (Exception) {
				creditoConsulta = new CSCredito();
				creditoConsulta.Show();
			}
		}
		
		void cliqueCondicaoConsulta(object sender, EventArgs e) {
			try {
				condicaoConsulta.WindowState = FormWindowState.Minimized;
				condicaoConsulta.WindowState = FormWindowState.Normal;
				condicaoConsulta.Show();
			} catch (Exception) {
				condicaoConsulta = new CSCondicao();
				condicaoConsulta.Show();
			}
		}
		
		
		void cliquePessoaConsulta(object sender, EventArgs e) {
			try {
				pessoaConsulta.WindowState = FormWindowState.Minimized;
				pessoaConsulta.WindowState = FormWindowState.Normal;
				pessoaConsulta.Show();
			} catch (Exception) {
				pessoaConsulta = new CDPessoa();
				pessoaConsulta.Show();
			}
		}
		
		void cliqueUsuarioControle(object sender, EventArgs e) {
			try {
				usuarioControl.WindowState = FormWindowState.Minimized;
				usuarioControl.WindowState = FormWindowState.Normal;
				usuarioControl.Show();
			} catch (Exception) {
				usuarioControl = new CTUsuario();
				usuarioControl.Show();
			}
		}
		
		void cliquePermissaoControle(object sender, EventArgs e) {
			try {
				permissaoUsuario.WindowState = FormWindowState.Minimized;
				permissaoUsuario.WindowState = FormWindowState.Normal;
				permissaoUsuario.Show();
			} catch (Exception) {
				permissaoUsuario = new CTModulo();
				permissaoUsuario.Show();
			}
		}
		
		void cliqueRelatorioConsulta(object sender, EventArgs e) {
			try {
				relatorioConsulta.WindowState = FormWindowState.Minimized;
				relatorioConsulta.WindowState = FormWindowState.Normal;
				relatorioConsulta.Show();
			} catch (Exception) {
				relatorioConsulta = new CSRelatorio();
				relatorioConsulta.Show();
			}
		}
		
		void cliqueRelatorioProgramado(object sender, EventArgs e) {
			try {
				programadoConsulta.WindowState = FormWindowState.Minimized;
				programadoConsulta.WindowState = FormWindowState.Normal;
				programadoConsulta.Show();
			} catch (Exception) {
				programadoConsulta = new CSProgramado();
				programadoConsulta.Show();
			}	
		}
		
		
	}
		
}
