
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.venda {
	public partial class CDBalcao2 : Form {
		
		/// <summary>
		/// Tela para selecionar condição de pagamento e finalizar venda Balcão
		/// </summary>
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		float total = 0;
		
		private LinkedList<Venda_Produto> itens;
		private LinkedList<Contas> contas;
		private Usuario funcionario;
		private int sede;
		public Venda venda {get; set;}
		
		private LinkedList<Condicao> pagamentos;
		
		private ObjectDao<Venda_Produto> vDao = new ObjectDao<Venda_Produto>();
		
		public CDBalcao2(LinkedList<Venda_Produto> itens, Usuario funcionario, int sede) {
			this.itens = itens;
			this.funcionario = funcionario;
			this.sede = sede;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			Resultado resPagamento = new ObjectDao<Condicao>().listar("SELECT * FROM condicao where tipo != 1");
			if(!resPagamento.condicao) {
				MessageBox.Show("Não foi possível localizar as condições de pagamento, motivo : " + resPagamento.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			} else if(itens.Count == 0) {
				MessageBox.Show("Favor informar ao menos 1 item de venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			} else {
				pagamentos = resPagamento.converter<LinkedList<Condicao>>();
				foreach (Condicao pagto in pagamentos) {
					cbxPagamento.Items.Add(pagto.nome);
				}
				cbxPagamento.SelectedIndex = 0;
				
				foreach (Venda_Produto v in itens) {
					total += (v.quantidade * v.valor);
				}
				labTotal.Text = "R$ " + String.Format("{0:N}", total);
			}
		}
		
		void maskMoney(object sender, EventArgs e) {
			Ferramentas.maskMoney(txtTroco);
			if(!txtTroco.Text.Equals("")) {
				try {
					float troco = float.Parse(txtTroco.Text);
					troco = troco - total;
					if(troco < 0) {
						labTroco.Text = "R$ 0,00";
					} else {
						labTroco.Text = "R$ " + String.Format("{0:N}", troco);
					}
				} catch (Exception) {
					labTroco.Text = "R$ 0,00";
				}
			}
		}
		
		void pressionarTecla(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				finalizar();
			} else if(e.KeyCode == Keys.Escape) {
				this.DialogResult = DialogResult.Cancel;
			}
		}
		
		private void finalizar() {
			
			// Criar Venda
			venda = new Venda();
			venda.atendido = 0;
			venda.dtimplantacao = DateTime.Today;
			venda.pessoa = 1;
			venda.endereco = "Padrão";
			venda.sede = this.sede;
			venda.usuario = this.funcionario.codigo;
			venda.pagamento = pagamentos.ElementAt(cbxPagamento.SelectedIndex).codigo;
			venda.observacao = "Venda balcão realizada pelo funcionario " + this.funcionario.nome;
			
			// Comando para adicionar venda
			Comando com = new Comando("SELECT NewVenda(@loja, @cliente, @entrega, @dt, @cond, @atendido, @observacao, @usuario)");
			com.addParametro("@loja", venda.sede);
			com.addParametro("@cliente", venda.pessoa);
			com.addParametro("@entrega", venda.endereco);
			com.addParametro("@dt", venda.dtimplantacao);
			com.addParametro("@cond", venda.pagamento);
			com.addParametro("@atendido", venda.atendido);
			com.addParametro("@observacao", venda.observacao);
			com.addParametro("@usuario", venda.usuario);
			
			// Execução do comando
			Resultado res = com.consultarValor();
			
			// Inserir itens
			String mensagem = "== Situação inserção de pedido ==" + Environment.NewLine + "= " + res.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + res.mensagem + Environment.NewLine + Environment.NewLine + "== Inserção de Produtos ==" + Environment.NewLine;
			if(res.condicao) {
				int codigo = res.converter<int>();
				foreach (Venda_Produto v in itens) {
					v.pedido = codigo;
					Resultado resProd = vDao.inserir(v);
					mensagem = mensagem + "= " + resProd.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + resProd.mensagem + Environment.NewLine; 
				}
				
				if(!mensagem.Contains("Fora -")) {
					venda.codigo = codigo;
					this.contas = Financeiro.gerarParcela(total, venda.dtimplantacao, 1, venda.sede, venda.pessoa, pagamentos.ElementAt(cbxPagamento.SelectedIndex), "Venda", venda.codigo);
					Resultado resAtende = Atende.venda(venda, contas);
					mensagem = mensagem + Environment.NewLine + Environment.NewLine + resAtende.mensagem;
					if(resAtende.condicao) {
						MessageBox.Show(mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.DialogResult = DialogResult.OK;
					} else {
						MessageBox.Show("NÃO FOI POSSIVEL ATENDER A VENDA :\n " + resAtende.mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
						new ObjectDao<Venda>().delete(venda.codigo);
					}
				} else {
					MessageBox.Show("NÃO FOI POSSIVEL ATENDER A VENDA :\n " + mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
					new ObjectDao<Venda>().delete(codigo);
				}
			} else {
				MessageBox.Show("NÃO FOI POSSIVEL ATENDER A VENDA :\n " + res.mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			
			
		}
		
	}
}
