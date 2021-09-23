
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using GM.View.pessoa;

namespace GM.View.compra {
	public partial class CSCompra : Form {
		
		private ObjectDao<Compra> cDao = new ObjectDao<Compra>();
		
		private Compra compra;
		private DataTable itens;
		private int codigo = 0;
		
		public CSCompra() {
			InitializeComponent();
		}
		
		public CSCompra(int codigo) {
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
		
		// Buscar e exibir dados da COMPRA
		public void consultar(int codigo) {
			Resultado res = cDao.consultar(codigo);
			if(!res.condicao) {
				MessageBox.Show("Compra não encontrada !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				this.compra = res.converter<Compra>();
				
				txtCodigo.Text = compra.codigo.ToString().PadLeft(6, '0');
				cbxSituacao.SelectedIndex = compra.atendido;
				txtData.Text = compra.dtcompra.ToString("dd/MM/yyyy");
				txtObservacoes.Text = compra.observacao;
				
				listaProdutos.Items.Clear();
				decimal total = 0;
				
				Comando schProdutos = new Comando("SELECT quantidade AS Quantidade, descricao AS Nome, A.preco AS Preço, (quantidade * A.preco) AS Total  FROM compra_item AS A INNER JOIN produto AS B ON B.codigo = A.produto AND A.compra = @pedido");
				schProdutos.addParametro("@pedido", compra.codigo);
				Resultado resProdutos = schProdutos.consultarToDataTable();
				if(!resProdutos.condicao) {
					MessageBox.Show("Não foi possível localizar os produtos da compra, motivo : " + resProdutos.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					itens = resProdutos.converter<DataTable>();
					foreach (DataRow linha in itens.Rows) {
						ListViewItem itm = new ListViewItem();
						itm.Text =  decimal.Parse(linha[0].ToString()).ToString("n3");
						itm.SubItems.Add(linha[1].ToString());
						itm.SubItems.Add("R$ " + String.Format("{0:N}", decimal.Parse(linha[2].ToString())));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", decimal.Parse(linha[3].ToString())));
						total += decimal.Parse(linha[3].ToString());
						listaProdutos.Items.Add(itm);
					}
					
				}
				
				txtValor.Text = "R$ " + String.Format("{0:N}", total);
				showSede(compra.sede);
				showFornecedor(compra.fornecedor);
				showCondicao(compra.condpagto);
			}
		}
		
		// Função para buscar nome do Fornecedor e exibir na tela
		private void showFornecedor(int codigo) {
			Resultado res = new Comando("SELECT nome FROM pessoa WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtFornecedor.Text = res.resultado.ToString(); } else { txtFornecedor.Text = "NÃO ENCONTRADO"; }
		}
		
		// Função para buscar nome da Sede e exibir na tela
		private void showSede(int codigo) {
			Resultado res = new Comando("SELECT nome FROM sede WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtSede.Text = res.resultado.ToString(); } else { txtSede.Text = "NÃO ENCONTRADO"; }
		}
		
		// Função para buscar nome da Condição e exibir na tela
		private void showCondicao(int codigo) {
			Resultado res = new Comando("SELECT nome FROM condicao WHERE codigo = " + codigo.ToString()).consultarValor();
			if(res.condicao) { txtCondicao.Text = res.resultado.ToString(); } else { txtCondicao.Text = "NÃO ENCONTRADO"; }
		}
		
		// === Fim do setor de busca ao dados =========================================================================
		// === Inicío das funções de navegação ========================================================================
		
		private void getPrimeiro() {
			Resultado res = new Comando("SELECT codigo FROM compra ORDER BY codigo ASC LIMIT 1").consultarValor();
			if(res.condicao) { consultar(int.Parse(res.resultado.ToString())); }
		}
		
		private void getUltimo() {
			Resultado res = new Comando("SELECT codigo FROM compra ORDER BY codigo DESC LIMIT 1").consultarValor();
			if(res.condicao) { consultar(int.Parse(res.resultado.ToString())); }
		}
		
		private void getProximo() {
			Resultado res = new Comando("SELECT codigo FROM compra WHERE codigo > " + compra.codigo + " ORDER BY codigo ASC LIMIT 1").consultarValor();
			if(res.condicao) { consultar(int.Parse(res.resultado.ToString())); }
			else { getPrimeiro(); }
		}
		
		private void getAnterior() {
			Resultado res = new Comando("SELECT codigo FROM compra WHERE codigo < " + compra.codigo + " ORDER BY codigo DESC LIMIT 1").consultarValor();
			if(res.condicao) { consultar(int.Parse(res.resultado.ToString())); }
			else { getUltimo(); }
		}
		
		// === Fim das funções de navegação ==========================================================================
		// === Ínicio dos eventos dos botões =========================================================================
		
		void voltarClique(object sender, EventArgs e) {
			if(compra != null) { getAnterior(); }
		}
		
		void proximoClique(object sender, EventArgs e) {
			if(compra != null) { getProximo(); }
		}
		
		void novoClique(object sender, EventArgs e) {
			CDCompra cd = new CDCompra();
			if(cd.ShowDialog() == DialogResult.OK) {
				getUltimo();
			}
		}
		
		void editarClique(object sender, EventArgs e) {
			if(compra != null) { 
				CDCompra cd = new CDCompra(compra);
				if(cd.ShowDialog() == DialogResult.OK) {
					consultar(compra.codigo);
				}	
			}
		}
		
		void deletarClique(object sender, EventArgs e) {
			if(compra != null) {
				if(compra.atendido == 0) {
					if(MessageBox.Show("Tem certeza ? Não é possível desfazer esta ação.", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
						Resultado res = cDao.delete(compra);
						MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
						if(res.condicao) { getPrimeiro(); }
					}
				} else {
					MessageBox.Show("Não é possível deletar uma compra não atendida !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			Resultado pq = Pesquisa.compra();
			if(pq.condicao) {
				consultar(pq.converter<Compra>().codigo);
			}
		}
		
		void efetivarClique(object sender, EventArgs e) {
			ATCompra at = new ATCompra(compra.codigo);
			if(at.ShowDialog() == DialogResult.OK) {
				consultar(compra.codigo);
			}
		}
	}
}
