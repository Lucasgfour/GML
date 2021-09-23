
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;

namespace GM.View.venda {
	public partial class CDBalcao : Form {
		
		/// <summary>
		/// Tela de venda BALCÃO
		/// </summary>
		
		public LinkedList<Usuario> funcionarios;
		public LinkedList<Produto> produtos;
		
		public LinkedList<Venda_Produto> itens;
		
		public Sede loja;
		
		public CDBalcao(Sede loja) {
			this.loja = loja;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			responsivo();
			aparencia();
			getData();
			novaVenda();
		}
		
		// Se adapta a tela inteira
		private void responsivo() {
			ColQuantidade.Width = ((listaProdutos.Size.Width / 100) * 12);
			ColUnidade.Width = ((listaProdutos.Size.Width / 100) * 6);
			ColProduto.Width = ((listaProdutos.Size.Width / 100) * 42);
			ColVlrUnidade.Width = ((listaProdutos.Size.Width / 100) * 18);
			ColVlrTotal.Width = ((listaProdutos.Size.Width / 100) * 18);
		}
		
		// Constroe a aparência da tela
		private void aparencia() {
			labLojaLogo.Text = loja.nome;
			if(System.IO.File.Exists(Application.StartupPath + "\\Parametros\\logo.png")) {
				pnlLogo.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Parametros\\logo.png");
			}
		}
		
		// Obtem dados necessários (Produtos, Funcionários, etc);
		private void getData() {
			Resultado resProduto = new ObjectDao<Produto>().listar("SELECT * FROM produto WHERE situacao = 1");
			Resultado resFuncionario = new ObjectDao<Usuario>().listar("SELECT codigo, usuario, 'claroQueNãoVaiTerSenha' AS senha, nome, permissao, vendedor, sede, pin FROM usuario WHERE vendedor = 1 AND sede = " + this.loja.codigo);
			if(!resProduto.condicao || !resFuncionario.condicao) {
				MessageBox.Show("== Situação obter dados para venda balcão ==" + Environment.NewLine + "== Produtos : " + resProduto.mensagem + Environment.NewLine + "== Funcionários : " + resFuncionario.mensagem, "Situação", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				this.produtos = resProduto.converter<LinkedList<Produto>>();
				this.funcionarios = resFuncionario.converter<LinkedList<Usuario>>();
				
				AutoCompleteStringCollection dadosLista = new AutoCompleteStringCollection();
				AutoCompleteStringCollection dadosListaCodigo = new AutoCompleteStringCollection();
				foreach (Produto p in produtos) {
					cbxProdutoCodigo.Items.Add(p.cod_cliente);
					cbxProduto.Items.Add(p.descricao);
					dadosListaCodigo.Add(p.cod_cliente);
					dadosLista.Add(p.descricao);
				}
				cbxProduto.AutoCompleteCustomSource = dadosLista;
				cbxProdutoCodigo.AutoCompleteCustomSource = dadosListaCodigo;
				
				foreach (Usuario u in funcionarios) {
					cbxVendedor.Items.Add(u.nome);
				}
				cbxVendedor.SelectedIndex = 0;
			}
		}
		
		void selectProduto(object sender, EventArgs e) {
			try {
				ComboBox cbxSele = (ComboBox) sender;
				if(cbxProduto.SelectedIndex != cbxSele.SelectedIndex) {
					cbxProduto.SelectedIndex = cbxSele.SelectedIndex;
				} else if(cbxProdutoCodigo.SelectedIndex != cbxSele.SelectedIndex) {
					cbxProdutoCodigo.SelectedIndex = cbxSele.SelectedIndex;
				}
				Produto p = produtos.ElementAt(((ComboBox) sender).SelectedIndex);
				txtPreco.Text = String.Format("{0:N}", p.preco);
				labUnidade.Text = p.unidade;
				txtQuantidade.Text = "1,000";
			} catch (Exception) { }
		}
		
		// Captura o pressionamento de botões na tela
		void pressionaBotao(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				addProduto();
			} else if(e.KeyCode == Keys.F2) {
				if(MessageBox.Show("Tem certeza que deseja sair ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					this.Close();
				}
			} else if(e.KeyCode == Keys.F3) {
				if(MessageBox.Show("Tem certeza que deseja limpar os produtos adicionados ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					novaVenda();
					cbxProdutoCodigo.Focus();
				}
			} else if(e.KeyCode == Keys.F1) {
				try {
					CFFuncionario cdbal = new CFFuncionario(itens, funcionarios.ElementAt(cbxVendedor.SelectedIndex), loja.codigo);
					if(cdbal.ShowDialog() == DialogResult.OK) {
						novaVenda();
					}
				} catch (Exception eCon) {
					MessageBox.Show("Erro ao finalizar a venda, motivo ; " + eCon.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		private void novaVenda() {
			listaProdutos.Items.Clear();
			itens = new LinkedList<Venda_Produto>();
			atualizarDados();
		}
		
		private void atualizarDados() {
			decimal total = 0;
			foreach (Venda_Produto iten in itens) {
				total += (iten.quantidade * iten.valor);
			}
			labTotal.Text = "R$ " + String.Format("{0:N}", total);
		}
		
		// === Mascaras =========================================================================
		
		void maskQuantidade(object sender, EventArgs e) {
			Ferramentas.maskMoney(txtQuantidade, 3);
		}
		
		void maskMoney(object sender, EventArgs e) {
			Ferramentas.maskMoney(txtPreco);
		}
		
		// === Eventos ============================================================================
		
		private void addProduto() {
			try {
				decimal quantidade = decimal.Parse(txtQuantidade.Text);
				decimal valor = decimal.Parse(txtPreco.Text);
				Produto produto = produtos.ElementAt(cbxProdutoCodigo.SelectedIndex);
				
				if(quantidade == 0) {
					MessageBox.Show("Quantidade não pode ser igual a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else if(valor == 0) {
					MessageBox.Show("Valor não pode ser igual a R$ 0,00.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else {
					Venda_Produto v = new Venda_Produto();
					v.produto = produto.codigo;
					v.quantidade = quantidade;
					v.valor = valor;
					
					itens.AddLast(v);
					
					ListViewItem itm = new ListViewItem();
					itm.Text = v.quantidade.ToString("n3");
					itm.SubItems.Add(produto.unidade);
					itm.SubItems.Add(produto.descricao);
					itm.SubItems.Add("R$ " + String.Format("{0:N}", v.valor));
					itm.SubItems.Add("R$ " + String.Format("{0:N}", (v.quantidade * v.valor)));
					listaProdutos.Items.Add(itm);
					
					txtQuantidade.Text = "";
					txtPreco.Text = "";
					cbxProduto.SelectedIndex = -1;
					labUnidade.Text = "";
					
					atualizarDados();
					
					cbxProdutoCodigo.Focus();
				}
			} catch (Exception) {
				MessageBox.Show("Favor verificar os dados do produtos !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void duploClique(object sender, MouseEventArgs e) {
			try {
				itens.Remove(itens.ElementAt(listaProdutos.FocusedItem.Index));
				listaProdutos.Items.RemoveAt(listaProdutos.FocusedItem.Index);
				atualizarDados();
			} catch (Exception) { }
		}
	}
}
