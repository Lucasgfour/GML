
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.contas {
	public partial class CSConta : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private int codigo;
		private Contas conta;
		private LinkedList<Movi_Contas> movimentacoes;
		private LinkedList<Contas> relacao;
		private float saldo;
		
		private ObjectDao<Contas> cDao = new ObjectDao<Contas>();
		private ObjectDao<Movi_Contas> mDao = new ObjectDao<Movi_Contas>();
		
		public CSConta(int codigo) {
			this.codigo = codigo;
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar(codigo);
			}
		}
		
		private void pesquisar(int codigo) {
			Resultado resConta = cDao.consultar(codigo);
			if(!resConta.condicao) {
				MessageBox.Show("Conta não localizada, detalhes : " + resConta.mensagem, "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				saldo = 0;
				this.conta = resConta.converter<Contas>();
				Resultado resMovi = mDao.listar("SELECT * FROM movi_contas WHERE conta = " + conta.codigo.ToString() + " ORDER BY dtmovimento ASC");
				if(!resMovi.condicao) {
					MessageBox.Show("Não foi possível localizar os movimentos financeiros da conta !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					// Lançar dados
					movimentacoes = resMovi.converter<LinkedList<Movi_Contas>>();
					txtCodigo.Text = conta.codigo.ToString();
					
					Resultado resFornecedor = new Comando("SELECT nome FROM pessoa WHERE codigo = " + conta.pessoa.ToString()).consultarValor();
					if(resFornecedor.condicao) {
						txtFornecedor.Text = resFornecedor.resultado.ToString();
					} else {
						txtFornecedor.Text = "ERRO AO LOCALIZAR FORNECEDOR : "  + resFornecedor.mensagem;
					}
					
					txtEmissao.Text = conta.emissao.ToString("dd/MM/yyyy");
					txtVencimento.Text = conta.vencimento.ToString("dd/MM/yyyy");
					txtReferencia.Text = conta.refe_nome + ": " + conta.refe_cod.ToString();
					
					listaMovimento.Items.Clear();
					listaRelacao.Items.Clear();
					
					// Lançar movimentos
					foreach (Movi_Contas mv in movimentacoes) {
						saldo += mv.valor;
						
						ListViewItem itm = new ListViewItem();
						itm.Text = mv.dtmovimento.ToString("dd/MM/yyyy");
						itm.SubItems.Add(mv.descricao.ToLower());
						itm.SubItems.Add("R$ " + String.Format("{0:N}", mv.valor));
						
						if(mv.valor < 0) {
							itm.BackColor = Color.LightGreen;
						} else if(mv.valor > 0) {
							itm.BackColor = Color.Salmon;
						}
						
						listaMovimento.Items.Add(itm);
					}
					
					txtSaldo.Text = "R$ " + String.Format("{0:N}", saldo);
					
					// Buscar Relações
					Resultado resuRel = cDao.listar("SELECT * FROM contas WHERE refe_nome = '" + conta.refe_nome + "' AND refe_cod = " + conta.refe_cod.ToString());
					if(resuRel.condicao) {
						relacao = resuRel.converter<LinkedList<Contas>>();
						foreach (Contas ct in relacao) {
							ListViewItem itm = new ListViewItem();
							itm.Text = ct.codigo.ToString().PadLeft(6, '0');
							itm.SubItems.Add(ct.vencimento.ToString("dd/MM/yyyy"));
							itm.SubItems.Add("R$ " + String.Format("{0:N}", ct.valor));
							listaRelacao.Items.Add(itm);
						}
					}
					
					
					// Verificar situação
					if(conta.tipo == 3) {
						txtVencimento.Text = "";
						if(saldo == 0) {
							txtSituação.Text = "CRÉDITO UTILIZADO";
						} else {
							txtSituação.Text = "CRÉDITO EM ABERTO";
						}
					} else {
						if(saldo == 0) {
							txtSituação.Text = "BAIXADO";
							txtSituação.BackColor = Color.LightGreen;
						} else if(conta.vencimento < DateTime.Today) {
							txtSituação.Text = "VENCIDA";
							txtSituação.BackColor = Color.Salmon;
						} else if(conta.vencimento == DateTime.Today) {
							txtSituação.Text = "VENCE HOJE";
							txtSituação.BackColor = Color.Yellow;
						} else {
							txtSituação.Text = "AG. PAGAMENTO";
							txtSituação.BackColor = Color.LightGray;
						}
					}
					
					
				}
				
			}
			
			
		}
		
		void cliquePesquisar(object sender, EventArgs e) {
			try {
				pesquisar(int.Parse(txtCodigo.Text));
			} catch(Exception) {
				MessageBox.Show("Código inválido !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void cliqueAbrirReferencia(object sender, EventArgs e) {
			Ferramentas.openReferencia(conta.refe_nome, conta.refe_cod);
		}
		
		void cliqueNovoMovimentacao(object sender, EventArgs e) {
			CDMovimento cdmov = new CDMovimento(this.conta);
			if(cdmov.ShowDialog() == DialogResult.OK) {
				pesquisar(this.conta.codigo);
			}
		}
		
	}
}
