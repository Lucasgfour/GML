
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.compra {
	public partial class CDCompra : Form {
		
		// Atributos
		private LinkedList<Produto> produtos = new LinkedList<Produto>();
	
		private ObjectDao<Sede> sDao = new ObjectDao<Sede>();
		private ObjectDao<Compra_item> iDao = new ObjectDao<Compra_item>();
		private ObjectDao<Condicao> cDao = new ObjectDao<Condicao>();
		
		private Compra compra;
		private LinkedList<Compra_item> itens = new LinkedList<Compra_item>();
		private LinkedList<Sede> sedes;
		private LinkedList<Condicao> condicoes;
		
		// Construtor
		public CDCompra() {
			InitializeComponent();
		}
		
		public CDCompra(Compra compra) {
			this.compra = compra;
			InitializeComponent();
		}
		
		// Evento LOAD
		void arranqueFormulario(object sender, EventArgs e) {
			atualizarDados();
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else if(this.compra != null && this.compra.atendido == 1) {
				MessageBox.Show("Compra já foi atendida !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			} else if(this.compra != null) {
				Resultado res = iDao.listar("SELECT * FROM compra_item WHERE compra = " + this.compra.codigo.ToString());
				if(!res.condicao) {
					MessageBox.Show("Não foi possível localizar o(s) item(ns) da compra, motivo : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
				} else {
					itens = res.converter<LinkedList<Compra_item>>();
					foreach (Compra_item i in itens) {
						ListViewItem itm = new ListViewItem();
						itm.Text = String.Format("{0:N}", i.quantidade);
						itm.SubItems.Add(new Comando("SELECT descricao FROM produto WHERE codigo = " + i.produto.ToString()).consultarValor().resultado.ToString());
						itm.SubItems.Add("R$ " + String.Format("{0:N}", i.preco));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", (i.quantidade * i.preco)));
						listProduto.Items.Add(itm);
					}
					attDisplay();
					this.Show();
					txtCodigoFornecedor.Text = compra.fornecedor.ToString();
					txtCodigoFornecedor.Focus();
					txtNomeFornecedor.Focus();
					txtDataCompra.Text = compra.dtcompra.ToString("dd/MM/yyyy");
					txtObservacao.Text = compra.observacao;
					
					foreach (Sede sd in sedes) {
						if(sd.codigo == compra.sede) {
							cbxLoja.Text = sd.nome;
						}
					}
					
					foreach (Condicao cd in condicoes) {
						if(cd.codigo == compra.condpagto) {
							cbxCondicao.Text = cd.nome;
						}
					}
			
				}
			} else {
				this.compra = new Compra();
			}
			
			
			
			txtDataCompra.Text = DateTime.Today.ToString("dd/MM/yyyy");
		}
		
		// Função para atualização dos dados em tela
		private void atualizarDados() {
			// Produto
			Resultado resProduto = new ObjectDao<Produto>().listar("SELECT * FROM produto WHERE situacao = 1");
			if(!resProduto.condicao) {
				MessageBox.Show("Não foi possível localizar os produtos cadastrados no sistema. " + resProduto.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			} else {
				this.produtos = resProduto.converter<LinkedList<Produto>>();
				AutoCompleteStringCollection dadosLista = new AutoCompleteStringCollection();
				foreach (Produto prod in produtos) {
					txtProduto.Items.Add(prod.cod_cliente + " - " + prod.descricao);
					dadosLista.Add(prod.cod_cliente + " - " + prod.descricao);
				}
				txtProduto.AutoCompleteCustomSource = dadosLista;
			}
			
			// Sedes
			Resultado res = sDao.listar();
			if(!res.condicao) {
				MessageBox.Show("Erro ao buscar sede(s) : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			} else {
				sedes = res.converter<LinkedList<Sede>>();
				cbxLoja.Items.Clear();
				foreach (Sede sd in sedes) {
					cbxLoja.Items.Add(sd.nome);
				}
				cbxLoja.SelectedIndex = 0;
			}
			
			// Condições
			Resultado cRes = cDao.listar("SELECT * FROM condicao WHERE tipo = 0 OR tipo = 1 ORDER BY nome ASC");
			if(!cRes.condicao) {
				MessageBox.Show("Não foi possível localizar as condições de pagamento, motivo : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			} else {
				condicoes = cRes.converter<LinkedList<Condicao>>();
				cbxCondicao.Items.Clear();
				foreach (Condicao cd in condicoes) {
					cbxCondicao.Items.Add(cd.nome);
				}
				cbxCondicao.SelectedIndex = 0;
				
			}
		}
		
		// ======================== DEFININDO MASCARAS ====================================
		
		void maskfloat(object sender, EventArgs e) {
			Ferramentas.maskMoney((TextBox) sender);
		}
		
		void maskData(object sender, EventArgs e) {
			Ferramentas.maskData((TextBox) sender);
		}
		
		void maskDataAux(object sender, EventArgs e) {
			TextBox txt = (TextBox) sender;
			try {
				DateTime a = DateTime.Parse(txt.Text);
			} catch (Exception) {
				txt.Text = "";
			}
		}
		
		void maskNumber(object sender, EventArgs e) {
			Ferramentas.maskNumber((TextBox) sender);
		}
		
		void maskQuantidade(object sender, EventArgs e) {
			Ferramentas.maskMoney((TextBox) sender, 3);
		}
		
		// ======================= EVENTOS E FUNÇÕES
		
		void buscarCliente(object sender, MouseEventArgs e) {
			Resultado res = Pesquisa.pessoa(1);
			if(res.condicao) {
				txtCodigoFornecedor.Text = res.converter<Pessoa>().codigo.ToString();
				txtNomeFornecedor.Text = res.converter<Pessoa>().nome.ToString();
			}
		}
		
		void mudarInfo(object sender, EventArgs e) {
			try {
				Produto p = produtos.ElementAt(txtProduto.SelectedIndex);
				txtPreco.Text = p.preco.ToString();
			} catch (Exception) { }
		}
		
		
		
		// ======================================================================================================
		// = Funções de Atualização
		
		private float getValorTotal() {
			float t = 0;
			foreach (Compra_item c in itens) {
				t += (c.quantidade * c.preco);
			}
			return t;
		}
		
		private void attDisplay() {
			txtValorTotal.Text = "R$ " + String.Format("{0:N}", getValorTotal());
		}
		
		// ======================================================================================================
		// = Produtos
		
		void adicionarProdutoClique(object sender, EventArgs e) {
			try {
				float quant = float.Parse(txtQuantidade.Text);
				float valor = float.Parse(txtPreco.Text);
				Produto p = produtos.ElementAt(txtProduto.SelectedIndex);
				int codigoProd = p.codigo;
				if(quant < 1) {
					MessageBox.Show("Quantidade não pode ser inferior a 1.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else if(valor < 1) {
					MessageBox.Show("Valor do produto não pode ser inferior a 1.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else if(codigoProd < 1) {
					MessageBox.Show("Produto inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					Compra_item i = new Compra_item();
					i.produto = codigoProd;
					i.preco = valor;
					i.quantidade = quant;
					itens.AddLast(i);
					
					ListViewItem itm = new ListViewItem();
					itm.Text = String.Format("{0:N}", i.quantidade);
					itm.SubItems.Add(p.descricao);
					itm.SubItems.Add("R$ " + String.Format("{0:N}", i.preco));
					itm.SubItems.Add("R$ " + String.Format("{0:N}", (i.quantidade * i.preco)));
					listProduto.Items.Add(itm);
					
					txtPreco.Text  = "";
					txtQuantidade.Text = "";
					txtProduto.Text = "";
					txtProduto.Focus();
					
					attDisplay();
				}
			} catch (Exception) {
				MessageBox.Show("Produto inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
		}
		
		void pressEnterProduto(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				btnAddProduto.PerformClick();
			}
			
		}
		
		void limparProdutoClique(object sender, EventArgs e) {
			itens = new LinkedList<Compra_item>();
			listProduto.Items.Clear();
		}
		
		void excluirProdutoClique(object sender, EventArgs e) {
			try {
				int pos = listProduto.FocusedItem.Index;
				
				LinkedList<Compra_item> nova = new LinkedList<Compra_item>();
				for (int i = 0; i < itens.Count; i++) {
					if(i != pos) {
						nova.AddLast(itens.ElementAt(i));
					}
				}
				itens = nova;
				listProduto.Items.RemoveAt(pos);
			} catch (Exception) { }
		}
		
		
		void cancelarClique(object sender, EventArgs e) {
			if(MessageBox.Show("Tem certeza que deseja cancelar ?", "Cancelar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				this.Close();
			}
		}
		
		void showCliente(object sender, EventArgs e) {
			try {
				Resultado res = new ObjectDao<Pessoa>().consultar("SELECT * FROM pessoa WHERE tipo != 0 AND codigo = " + int.Parse(txtCodigoFornecedor.Text));
				if(!res.condicao) {
					txtNomeFornecedor.Text = "NÃO ENCONTRADO";
				} else {
					txtNomeFornecedor.Text = res.converter<Pessoa>().nome;
				}
			} catch (Exception) {
				txtNomeFornecedor.Text = "NÃO ENCONTRADO";
			}
		}
		
		void continuarClique(object sender, EventArgs e) {
			try {
				// Conferência dos dados
				if(itens.Count == 0) {
					MessageBox.Show("Favor inserir ao menos um produto !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else if(txtNomeFornecedor.Text.Equals("NÃO ENCONTRADO") || txtNomeFornecedor.Text.Equals("")) {
					MessageBox.Show("Fornecedor inválido !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else if(txtDataCompra.Text.Equals("")) {
					MessageBox.Show("Favor informar uma data para compra !",  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else if(cbxLoja.SelectedIndex == -1) {
					MessageBox.Show("Favor informar uma loja !",  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else {
					// Preenchimento do Objeto
					compra.dtcompra = DateTime.Parse(txtDataCompra.Text);
					compra.fornecedor = int.Parse(txtCodigoFornecedor.Text);
					compra.observacao = txtObservacao.Text;
					compra.sede = sedes.ElementAt(cbxLoja.SelectedIndex).codigo;
					compra.condpagto = condicoes.ElementAt(cbxCondicao.SelectedIndex).codigo;
					compra.usuario = Ferramentas.sessao.codigo;
					
					Resultado res = new Resultado(false, "Não executado");
					
					if(this.compra.codigo == 0) {
						// Cria comando personalizado para inserção da Compra
						Comando com = new Comando("SELECT NewCompra(@loja, @fornecedor, @data, @condicao, @atendido, @observacao)");
						com.addParametro("@loja", compra.sede);
						com.addParametro("@fornecedor", compra.fornecedor);
						com.addParametro("@data", compra.dtcompra);
						com.addParametro("@condicao", compra.condpagto);
						com.addParametro("@atendido", compra.atendido);
						com.addParametro("@observacao", compra.observacao);
						
						// Validação se inserção foi com sucesso
						res = com.consultarValor();
						
					} else {
						res = new ObjectDao<Compra>().alterar(this.compra);
						if(res.condicao) {
							res = new Comando("DELETE FROM compra_item WHERE compra = " + compra.codigo.ToString()).executar();
							if(res.condicao) { // Ele deleta os produtos e faz a inserção novamente para evitar erro
								res = new Resultado(true, "Alterado com sucesso !", compra.codigo);
							}
						}
					}
					
					
					
					if(res.condicao) {
						// Caso tenha inserido a compra e obtido o Código,
						// Ele faz a inserção dos produtos
						int numPedido = res.converter<int>();
						foreach (Compra_item itm in itens) {
							itm.compra = numPedido;
							Resultado resItm = iDao.inserir(itm);
							if(!resItm.condicao) {
								MessageBox.Show("Erro ao inserir item : " + itm.codigo + " - " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						MessageBox.Show("Compra inserida com sucesso, número : " + res.resultado.ToString(), "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.DialogResult = DialogResult.OK;
					} else {
						MessageBox.Show("Erro : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			} catch (Exception) {
				
			}
		}
		
		
		// =================== Faz o calculo das parcelas e exibe ao usuário ===========================
		void calculoClique(object sender, EventArgs e) {
			if(itens.Count == 0) {
				MessageBox.Show("Favor inserir ao menos um produto !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if(txtNomeFornecedor.Text.Equals("NÃO ENCONTRADO") || txtNomeFornecedor.Text.Equals("")) {
				MessageBox.Show("Fornecedor inválido !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if(txtDataCompra.Text.Equals("")) {
				MessageBox.Show("Favor informar uma data para compra !",  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if(cbxLoja.SelectedIndex == -1) {
				MessageBox.Show("Favor informar uma loja !",  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				LinkedList<Contas> contas = Financeiro.gerarParcela(getValorTotal(), DateTime.Parse(txtDataCompra.Text), 0, sedes.ElementAt(cbxLoja.SelectedIndex).codigo, int.Parse(txtCodigoFornecedor.Text), condicoes.ElementAt(cbxCondicao.SelectedIndex), "Compra", 0);
				MessageBox.Show(Financeiro.parcelaToString(contas));
			}
		}
	}
}
