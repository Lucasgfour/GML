
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.venda {
	public partial class ATVenda : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		float total = 0;
		
		private ObjectDao<Venda> vDao = new ObjectDao<Venda>();
		
		private Venda venda;
		private Condicao condicao;
		private DataTable itens;
		private LinkedList<Contas> contas;
		private int codigo = 0;
		
		public ATVenda(int codigo) {
			this.codigo = codigo;
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				consultar(codigo);
			}
		}
		
		public void consultar(int codigo) {
			Resultado res = vDao.consultar(codigo);
			if(!res.condicao) {
				MessageBox.Show("Venda não encontrada !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				this.venda = res.converter<Venda>();
				
				if(this.venda.atendido != 0) {
					MessageBox.Show("Venda já foi atendida !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.DialogResult = DialogResult.Cancel;
				}
				
				txtCodigo.Text = venda.codigo.ToString().PadLeft(6, '0');
				txtData.Text = venda.dtimplantacao.ToString("dd/MM/yyyy");
				
				listaProdutos.Items.Clear();
				
				Comando schProdutos = new Comando("SELECT quantidade AS Quantidade, descricao AS Nome, A.valor AS Preço, (quantidade * A.valor) AS Total, saldoEstoque(B.codigo)  FROM venda_produto AS A INNER JOIN produto AS B ON B.codigo = A.produto AND A.pedido = @pedido");
				schProdutos.addParametro("@pedido", venda.codigo);
				Resultado resProdutos = schProdutos.consultarToDataTable();
				if(!resProdutos.condicao) {
					MessageBox.Show("Não foi possível localizar os produtos do pedido, motivo : " + resProdutos.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					itens = resProdutos.converter<DataTable>();
					String mensagem = "";
					foreach (DataRow linha in itens.Rows) {
						float estoque = float.Parse(linha[4].ToString());
						float quantidade = float.Parse(linha[0].ToString());
						ListViewItem itm = new ListViewItem();
						itm.Text = quantidade.ToString("n3");
						itm.SubItems.Add(linha[1].ToString());
						itm.SubItems.Add("R$ " + String.Format("{0:N}", float.Parse(linha[2].ToString())));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", float.Parse(linha[3].ToString())));
						itm.SubItems.Add(estoque.ToString("n3"));
						total +=  (float.Parse(linha[0].ToString()) * float.Parse(linha[2].ToString()));
						
						if(estoque < quantidade) {
							itm.BackColor = Color.LightSalmon;
							btnEntrada.Visible = false;
							mensagem = mensagem + "Produto " + linha[1].ToString() + " com estoque insuficiente !!" + Environment.NewLine;
						} else if(estoque == quantidade) {
							itm.BackColor = Color.Yellow;
						}
						
						listaProdutos.Items.Add(itm);
					}
					
					if(!mensagem.Equals("")) {
						MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				
				txtTotal.Text = "R$ " + String.Format("{0:N}", total);
				showSede(venda.sede);
				showCliente(venda.pessoa);
				showCondicao(venda.pagamento);
			}
		}
		
		// Buscar e exibir nome do cliente selecionado
		private void showCliente(int codigo) {
			Resultado res = new Comando("SELECT nome FROM pessoa WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtCliente.Text = res.resultado.ToString(); } else { txtCliente.Text = "NÃO ENCONTRADO"; }
		}
		
		// Buscar e exibir sede selecionada
		private void showSede(int codigo) {
			Resultado res = new Comando("SELECT nome FROM sede WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtSede.Text = res.resultado.ToString(); } else { txtSede.Text = "NÃO ENCONTRADO"; }
		}
		
		// Busca condição e cria as parcelas
		private void showCondicao(int codigo) {
			Resultado res = new ObjectDao<Condicao>().consultar(codigo);
			this.condicao = res.converter<Condicao>();
			if(res.condicao) { 
				txtCondicao.Text = this.condicao.nome; 
				this.contas = Financeiro.gerarParcela(total, venda.dtimplantacao, 1, venda.sede, venda.pessoa, this.condicao, "Venda", venda.codigo);
				foreach (Contas cont in contas) {
					ListViewItem itm = new ListViewItem();
					itm.Text = cont.vencimento.ToString("dd/MM/yyyy");
					itm.SubItems.Add("R$ " + String.Format("{0:N}", cont.valor));
					itm.SubItems.Add(cont.sequencia.ToString().PadLeft(2, '0'));
					listaPagamentos.Items.Add(itm);
				}
				
				
			} else { 
				MessageBox.Show("Não foi possível encontrar a condição de pagamento !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.Close();
			}
		}
		
		void atenderClique(object sender, EventArgs e) {
			Resultado res = Atende.venda(venda, contas);
			
			MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			if(res.condicao) {
				this.DialogResult = DialogResult.OK;
			}
			
		}
	}
}
