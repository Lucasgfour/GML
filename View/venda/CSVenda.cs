
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.venda {
	public partial class CSVenda : Form {
		
		private Venda venda;
		private DataTable itens;
		private int codigo = 0;
		private ObjectDao<Venda> cDao = new ObjectDao<Venda>();
		
		public CSVenda() {
			InitializeComponent();
		}
		
		public CSVenda(int codigo) {
			this.codigo = codigo;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else if(codigo == 0) {
				getPrimeiro();			
			} else {
				consultar(codigo);
			}
		}
		
		public void consultar(int codigo) {
			Resultado res = cDao.consultar(codigo);
			if(!res.condicao) {
				MessageBox.Show("Pedido não encontrado !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				this.venda = res.converter<Venda>();
				
				txtCodigo.Text = venda.codigo.ToString().PadLeft(6, '0');
				cbxSituacao.SelectedIndex = venda.atendido;
				txtData.Text = venda.dtimplantacao.ToString("dd/MM/yyyy");
				txtObservacoes.Text = venda.observacao;
				
				listaProdutos.Items.Clear();
				float total = 0;
				
				Comando schProdutos = new Comando("SELECT quantidade AS Quantidade, descricao AS Nome, A.valor AS Preço, (quantidade * A.valor) AS Total FROM venda_produto AS A INNER JOIN produto AS B ON B.codigo = A.produto AND A.pedido = @pedido");
				schProdutos.addParametro("@pedido", venda.codigo);
				Resultado resProdutos = schProdutos.consultarToDataTable();
				if(!resProdutos.condicao) {
					MessageBox.Show("Não foi possível localizar os produtos do pedido, motivo : " + resProdutos.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					itens = resProdutos.converter<DataTable>();
					foreach (DataRow linha in itens.Rows) {
						ListViewItem itm = new ListViewItem();
						itm.Text =  float.Parse(linha[0].ToString()).ToString("n3");
						itm.SubItems.Add(linha[1].ToString());
						itm.SubItems.Add("R$ " + String.Format("{0:N}", float.Parse(linha[2].ToString())));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", float.Parse(linha[3].ToString())));
						total += float.Parse(linha[3].ToString());
						listaProdutos.Items.Add(itm);
					}
					
				}
				
				txtValor.Text = "R$ " + String.Format("{0:N}", total);
				showSede(venda.sede);
				showCliente(venda.pessoa);
				showCondicao(venda.pagamento);
			}
		}
		
		private void showCliente(int codigo) {
			Resultado res = new Comando("SELECT nome FROM pessoa WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtCliente.Text = res.resultado.ToString(); } else { txtCliente.Text = "NÃO ENCONTRADO"; }
		}
		
		private void showSede(int codigo) {
			Resultado res = new Comando("SELECT nome FROM sede WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtSede.Text = res.resultado.ToString(); } else { txtSede.Text = "NÃO ENCONTRADO"; }
		}
		
		private void showCondicao(int codigo) {
			Resultado res = new Comando("SELECT nome FROM condicao WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtCondicao.Text = res.resultado.ToString(); } else { txtCondicao.Text = "NÃO ENCONTRADO"; }
		}
		
		// === Fim do setor de busca ao dados =========================================================================
		// === Inicío das funções de navegação ========================================================================
		
		private void getPrimeiro() {
			Resultado res = new Comando("SELECT codigo FROM venda ORDER BY codigo ASC LIMIT 1").consultarValor();
			if(res.condicao) { consultar(int.Parse(res.resultado.ToString())); }
		}
		
		private void getUltimo() {
			Resultado res = new Comando("SELECT codigo FROM venda ORDER BY codigo DESC LIMIT 1").consultarValor();
			if(res.condicao) { consultar(int.Parse(res.resultado.ToString())); }
		}
		
		private void getProximo() {
			Resultado res = new Comando("SELECT codigo FROM venda WHERE codigo > " + venda.codigo + " ORDER BY codigo ASC LIMIT 1").consultarValor();
			if(res.condicao) { consultar(int.Parse(res.resultado.ToString())); }
			else { getPrimeiro(); }
		}
		
		private void getAnterior() {
			Resultado res = new Comando("SELECT codigo FROM venda WHERE codigo < " + venda.codigo + " ORDER BY codigo DESC LIMIT 1").consultarValor();
			if(res.condicao) { consultar(int.Parse(res.resultado.ToString())); }
			else { getUltimo(); }
		}
		
		// === Fim das funções de navegação ==========================================================================
		// === Ínicio dos eventos dos botões =========================================================================
		
		void voltarClique(object sender, EventArgs e) {
			if(venda != null) { getAnterior(); }
		}
		
		void proximoClique(object sender, EventArgs e) {
			if(venda != null) { getProximo(); }
		}
		
		void novoClique(object sender, EventArgs e) {
			CDVenda cd = new CDVenda();
			if(cd.ShowDialog() == DialogResult.OK) {
				getUltimo();
			}
		}
		
		void editarClique(object sender, EventArgs e) {
			if(venda != null) { 
				CDVenda cd = new CDVenda(venda);
				if(cd.ShowDialog() == DialogResult.OK) {
					consultar(venda.codigo);
				}	
			}
		}
		
		void deletarClique(object sender, EventArgs e) {
			if(venda != null) {
				if(venda.atendido == 0) {
					if(MessageBox.Show("Tem certeza ? Não é possível desfazer esta ação.", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
						Resultado res = cDao.delete(venda);
						MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
						if(res.condicao) { getPrimeiro(); }
					}
				} else {
					MessageBox.Show("Não é possível deletar uma venda já atendida !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			Resultado pq = Pesquisa.venda();
			if(pq.condicao) {
				consultar(pq.converter<Venda>().codigo);
			}
		}
		
		void efetivarClique(object sender, EventArgs e) {
			ATVenda at = new ATVenda(venda.codigo);
			if(at.ShowDialog() == DialogResult.OK) {
				consultar(venda.codigo);
			}
		}
	}
}
