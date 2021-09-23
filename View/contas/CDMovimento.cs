
using System;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.contas {
	public partial class CDMovimento : Form {
		
		private Contas conta;
		private Decimal saldo = 0;
		private ObjectDao<Movi_Contas> mvDao = new ObjectDao<Movi_Contas>();
		
		public CDMovimento(Contas conta) {
			this.conta = conta;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				Resultado resSaldo = new Comando("SELECT SUM(valor) FROM movi_contas WHERE conta = " + conta.codigo.ToString()).consultarValor();
				if(resSaldo.condicao) {
					saldo = decimal.Parse(resSaldo.resultado.ToString());
				}
				
				if(saldo == 0) {
					MessageBox.Show("Conta já baixada com saldo R$ 0,00.", "Baixada", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				
				labSaldo.Text = "Saldo: R$ " + String.Format("{0:N}", saldo);
				cbxTipo.SelectedIndex = 1;
				txtData.Text = DateTime.Today.ToString("dd/MM/yyyy");
			}
		}
		
		private void salvar() {
			try {
				if(txtData.Text.Equals("")) {
					MessageBox.Show("Favor informar a data da movimentação.", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else if(txtDescricao.Text.Equals("")) {
					MessageBox.Show("Favor informar a descrição da movimentação.", "Descrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else if(txtValor.Text.Equals("")) {
					MessageBox.Show("Favor informar o valor da movimentação.", "Valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else if(decimal.Parse(txtValor.Text) <= 0) {
					MessageBox.Show("Valor da movimentação deve ser susperior a R$ 0,00.", "Valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					
					Movi_Contas mv = new Movi_Contas();
					mv.conta = conta.codigo;
					mv.dtmovimento = DateTime.Parse(txtData.Text);
					mv.descricao = txtDescricao.Text;
					
					if(cbxTipo.SelectedIndex == 0) {
						mv.valor = decimal.Parse(txtValor.Text);
					} else {
						mv.valor = decimal.Parse(txtValor.Text) * -1;
					}
					
					if((mv.valor * -1) > saldo && cbxTipo.SelectedIndex == 1) {
						if(conta.tipo == 0) {
							if(MessageBox.Show("O valor da movimentação(R$" + String.Format("{0:N}", (mv.valor * -1)) + ") é superior ao saldo em aberto(R$" + String.Format("{0:N}", saldo) + ").\nDeseja adicionar o valor(R$" + String.Format("{0:N}", (mv.valor*-1) - saldo) +  ") como juros ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
								Movi_Contas juros = new Movi_Contas();
								juros.conta = mv.conta;
								juros.descricao = "juros";
								juros.dtmovimento = mv.dtmovimento;
								juros.valor = (mv.valor*-1) - saldo;
								mvDao.inserir(juros);
								inserir(mv);
							} else if(MessageBox.Show("Deseja adicionar este valor como Crédito para o cliente ?", "Crédito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
								Contas nv = new Contas();
								nv.emissao = mv.dtmovimento;
								nv.refe_nome = "Conta";
								nv.refe_cod = conta.codigo;
								nv.valor = (mv.valor*-1) - saldo;
								nv.pessoa = conta.pessoa;
								nv.sede = conta.sede;
								nv.sequencia = 1;
								nv.tipo = 3;
								nv.vencimento = DateTime.Today;
								mv.valor = mv.valor + nv.valor;
								
								
								ObjectDao<Contas> cDao = new ObjectDao<Contas>();
								Resultado contaRes = cDao.inserir(nv);
								if(contaRes.condicao) {
									inserir(mv);	
								} else {
									MessageBox.Show("Erro ao inserir crédito : " + contaRes.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
								
							}
						}
						
					} else {
						inserir(mv);
					}
					
				}
			} catch (Exception) { }
			
		}
		
		private void inserir(Movi_Contas mv) {
			Resultado res = mvDao.inserir(mv);
			MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if(res.condicao) {
				this.DialogResult = DialogResult.OK;
			}
		}
		

		
		void cliqueSalvar(object sender, EventArgs e) {
			salvar();
		}
		
		void maskData(object sender, EventArgs e) {
			Ferramentas.maskData(txtData);
		}
		
		void maskMoney(object sender, EventArgs e) {
			Ferramentas.maskMoney(txtValor);
		}
		
		void maskDataLeave(object sender, EventArgs e) {
			try {
				DateTime.Parse(txtData.Text);
			} catch (Exception) {
				txtData.Text = "";
			}
		}
		
		void mudarTipo(object sender, EventArgs e) {
			if(cbxTipo.SelectedIndex == 1) {
				if(txtDescricao.Text.Equals("")) {
					txtDescricao.Text = "liquidação";
				}
				
				if(txtValor.Text.Equals("")) {
					txtValor.Text = String.Format("{0:N}", saldo);
				}
			}
		}
		
		void cliqueSair(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
