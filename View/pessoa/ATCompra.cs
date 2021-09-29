
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.pessoa {
	public partial class ATCompra : Form {
		
		float total = 0;
		
		private ObjectDao<Compra> cDao = new ObjectDao<Compra>();
		
		private Compra compra;
		private Condicao condicao;
		private DataTable itens;
		private LinkedList<Contas> contas;
		private int codigo = 0;
		
		public ATCompra(int codigo) {
			this.codigo = codigo;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				consultar(codigo);
			}
		}
		
		public void consultar(int codigo) {
			Resultado res = cDao.consultar(codigo);
			if(!res.condicao) {
				MessageBox.Show("Compra não encontrada !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				this.compra = res.converter<Compra>();
				
				if(this.compra.atendido != 0) {
					MessageBox.Show("Compra já foi atendida !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.DialogResult = DialogResult.Cancel;
				}
				
				txtCodigo.Text = compra.codigo.ToString().PadLeft(6, '0');
				txtData.Text = compra.dtcompra.ToString("dd/MM/yyyy");
				
				listaProdutos.Items.Clear();
				
				
				/// ==================== BUSCA OS PRODUTOS E EXIBE
				Comando schProdutos = new Comando("SELECT quantidade AS Quantidade, descricao AS Nome, A.preco AS Preço, (quantidade * A.preco) AS Total  FROM compra_item AS A INNER JOIN produto AS B ON B.codigo = A.produto AND A.compra = @pedido");
				schProdutos.addParametro("@pedido", compra.codigo);
				Resultado resProdutos = schProdutos.consultarToDataTable();
				if(!resProdutos.condicao) {
					MessageBox.Show("Não foi possível localizar os produtos da compra, motivo : " + resProdutos.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					itens = resProdutos.converter<DataTable>();
					foreach (DataRow linha in itens.Rows) {
						ListViewItem itm = new ListViewItem();
						itm.Text =  float.Parse(linha[0].ToString()).ToString("n3");
						itm.SubItems.Add(linha[1].ToString());
						itm.SubItems.Add("R$ " + String.Format("{0:N}", float.Parse(linha[2].ToString())));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", float.Parse(linha[3].ToString())));
						total +=  (float.Parse(linha[0].ToString()) * float.Parse(linha[2].ToString()));
						listaProdutos.Items.Add(itm);
					}
					
				}
				
				txtTotal.Text = "R$ " + String.Format("{0:N}", total);
				showSede(compra.sede);
				showFornecedor(compra.fornecedor);
				showCondicao(compra.condpagto);
			}
		}
		
		private void showFornecedor(int codigo) {
			Resultado res = new Comando("SELECT nome FROM pessoa WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtFornecedor.Text = res.resultado.ToString(); } else { txtFornecedor.Text = "NÃO ENCONTRADO"; }
		}
		
		private void showSede(int codigo) {
			Resultado res = new Comando("SELECT nome FROM sede WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtSede.Text = res.resultado.ToString(); } else { txtSede.Text = "NÃO ENCONTRADO"; }
		}
		
		private void showCondicao(int codigo) {
			Resultado res = new ObjectDao<Condicao>().consultar(codigo);
			this.condicao = res.converter<Condicao>();
			if(res.condicao) { 
				txtCondicao.Text = this.condicao.nome; 
				this.contas = Financeiro.gerarParcela(total, compra.dtcompra, 0, compra.sede, compra.fornecedor, this.condicao, "Compra", compra.codigo);
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
			Resultado res = Atende.compra(compra, contas);
			
			MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			if(res.condicao) {
				this.DialogResult = DialogResult.OK;
			}
			
		}
	}
}
