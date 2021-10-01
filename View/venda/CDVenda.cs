
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Componentes;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.venda {
	public partial class CDVenda : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private Venda venda = new Venda();
		
		private Pessoa cliente;
		private Endereco endereco;
		private LinkedList<Venda_Produto> produtos;
		
		private LinkedList<Produto> prod;
		private LinkedList<Sede> sede;
		private LinkedList<Condicao> pagamentos;
		
		private ObjectDao<Venda_Produto> vDao = new ObjectDao<Venda_Produto>();
		private ObjectDao<Venda> veDao = new ObjectDao<Venda>();
		
		public CDVenda() {
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		public CDVenda(Venda venda) {
			this.venda = venda;
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				getData();
				txtData.Text = DateTime.Today.ToString("dd/MM/yyyy");
				txtTotal.Text = "R$ 0,00";
				if(venda.codigo > 0 && venda.atendido == 1) {
					MessageBox.Show("Venda já foi atendida !", "Venda já atendida !", MessageBoxButtons.OK ,MessageBoxIcon.Error);
					this.Close();
				} else if(venda.codigo > 0) {
					
					Resultado resProd = vDao.listar("SELECT * FROM venda_produto WHERE pedido = " + venda.codigo.ToString());
					if(resProd.condicao) {
						produtos = resProd.converter<LinkedList<Venda_Produto>>();
						edtVenda();
					} else {
						MessageBox.Show("Produtos do pedido não encontrado ! Detalhes : " + resProd.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();
					}
				} else {
					produtos = new LinkedList<Venda_Produto>();
				}
			}
		}
		
		// Caso for editar venda, ele busca os dados e exibe conforme o banco
		private void edtVenda() {
			this.Show();
			txtCodigoCliente.Text = venda.pessoa.ToString();
			txtCodigoCliente.Focus();
			
			txtCodigoEndereco.Text = venda.endereco;
			txtCodigoEndereco.Focus();
			txtObservacao.Text = venda.observacao;
			txtObservacao.Focus();
			
			txtData.Text = venda.dtimplantacao.ToString("dd/MM/yyyy");
			
			foreach (Sede sd in sede) {
				if(sd.codigo == venda.codigo) {
					cbxSede.Text = sd.nome;
				}
			}
			
			foreach (Condicao cd in pagamentos) {
				if(cd.codigo == venda.pagamento) {
					cbxCondicao.Text = cd.nome;
				}
			}
			
			foreach (Venda_Produto vp in produtos) {
				ListViewItem itm = new ListViewItem();
				itm.Text = vp.quantidade.ToString("n3");
				itm.SubItems.Add(new Comando("SELECT descricao FROM produto WHERE codigo = " + vp.produto.ToString()).consultarValor().resultado.ToString());
				itm.SubItems.Add("R$ " + String.Format("{0:N}", vp.valor));
				itm.SubItems.Add("R$ " + String.Format("{0:N}", (vp.quantidade * vp.valor)));
				listaProduto.Items.Add(itm);		
			}
			atualizarInfo();
		}
		
		// Obter dados referentes a venda
		private void getData() {
			Resultado resProduto = new ObjectDao<Produto>().listar("SELECT * FROM produto WHERE situacao = 1");
			Resultado resSede = new ObjectDao<Sede>().listar();
			Resultado resCondicao = new ObjectDao<Condicao>().listar("SELECT * FROM condicao WHERE tipo != 1");
			if(resProduto.condicao && resSede.condicao && resCondicao.condicao) {
				prod = resProduto.converter<LinkedList<Produto>>();
				sede = resSede.converter<LinkedList<Sede>>();
				pagamentos = resCondicao.converter<LinkedList<Condicao>>();
				setData();
			} else {
				MessageBox.Show("Erro ao obter dados relacionados ao pedido :\nProduto: " + resProduto.mensagem + "\nSede: " + resSede.mensagem + "\nCondição de Pagamento: " + resCondicao.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.DialogResult = DialogResult.Cancel;
			}
		}
		
		// Setar dados referente a venda
		private void setData() {
			
			// Produtos
			AutoCompleteStringCollection dadosLista = new AutoCompleteStringCollection();
			AutoCompleteStringCollection dadosListaCodigo = new AutoCompleteStringCollection();
			foreach (Produto p in prod) {
				cbxProdutoCodigo.Items.Add(p.cod_cliente);
				cbxProduto.Items.Add(p.descricao);
				dadosListaCodigo.Add(p.cod_cliente);
				dadosLista.Add(p.cod_cliente + " - " + p.descricao);
			}
			cbxProduto.AutoCompleteCustomSource = dadosLista;
			cbxProdutoCodigo.AutoCompleteCustomSource = dadosListaCodigo;
			
			// Sede
			foreach (Sede s in sede) {
				cbxSede.Items.Add(s.nome);
			}
			cbxSede.SelectedIndex = 0;
			
			// Condição
			foreach (Condicao c in pagamentos) {
				cbxCondicao.Items.Add(c.nome);
			}
			cbxCondicao.SelectedIndex = 0;
		}
		
		void pressionarEnterProduto(object sender, System.Windows.Forms.KeyEventArgs e) {
			if(e.KeyCode== Keys.Enter) {
				btnAdicionar.PerformClick();	
			}
		}
		
		// Função para atualizar dinamicamente os dados do pedido enquato o usuário vai fazendo alterações
		private void atualizarInfo() {
			try {
				float vlrTotal = 0;
				foreach (Venda_Produto vp in produtos) {
					vlrTotal += (vp.quantidade * vp.valor);
				}
				txtTotal.Text = "R$ " + String.Format("{0:N}", vlrTotal);
				
				listaParcela.Items.Clear();
				Condicao cd = pagamentos.ElementAt(cbxCondicao.SelectedIndex);
				LinkedList<Contas> parc = Financeiro.gerarParcela(vlrTotal, DateTime.Parse(txtData.Text), 1, 1, 0, cd, "VENDA", 0);
				foreach (Contas ct in parc) {
					ListViewItem itm = new ListViewItem();
					itm.Text = ct.vencimento.ToString("dd/MM/yyyy");
					itm.SubItems.Add(ct.sequencia.ToString());
					itm.SubItems.Add("R$ " + String.Format("{0:N}", ct.valor));
					listaParcela.Items.Add(itm);
				}
			} catch (Exception) { }
			
		}
		
		// ==== Selecionar Cliente / Endereço ===================================================================
		
		void buscaCliente(object sender, EventArgs e) {
			Resultado resCliente = Pesquisa.pessoa(0);
			if(resCliente.condicao) {
				cliente = resCliente.converter<Pessoa>();
				txtCodigoCliente.Text = cliente.codigo.ToString();
				txtCliente.Text = cliente.nome;
			}
		}
		
		void buscaClienteCodigo(object sender, EventArgs e) {
			try {
				int codigo = int.Parse(txtCodigoCliente.Text);
				Resultado resCliente = new ObjectDao<Pessoa>().consultar("SELECT * FROM pessoa WHERE codigo = " + codigo.ToString() + " AND tipo != 1");
				if(resCliente.condicao) {
					cliente = resCliente.converter<Pessoa>();
					txtCodigoCliente.Text = cliente.codigo.ToString();
					txtCliente.Text = cliente.nome;
				} else {
					cliente = null;
					txtCliente.Text = "NÃO ENCONTRADO";
				}
			} catch (Exception) {
				cliente = null;
				txtCliente.Text = "NÃO ENCONTRADO";
			}
		}
		
		void cliqueBuscaEndereco(object sender, EventArgs e) {
			if(cliente == null) {
				MessageBox.Show("Nenhum cliente selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				Resultado resPesq = Pesquisa.endereco(cliente);
				if(resPesq.condicao) {
					endereco = resPesq.converter<Endereco>();
					txtCodigoEndereco.Text = endereco.codigo;
					txtEndereco.Text = endereco.rua;
				}
			}
		}
		
		void leaveBuscaEndereco(object sender, EventArgs e) {
			if(cliente == null) {
				txtEndereco.Text = "NÃO ENCONTRADO";
				endereco = null;
			} else {
				Resultado resPesq = new ObjectDao<Endereco>().consultar("SELECT * FROM endereco WHERE pessoa = " + cliente.codigo.ToString() + " AND codigo = '" + txtCodigoEndereco.Text.Replace("'", "") + "'");
				if(resPesq.condicao) {
					endereco = resPesq.converter<Endereco>();
					txtCodigoEndereco.Text = endereco.codigo;
					txtEndereco.Text = endereco.rua;
				} else {
					txtEndereco.Text = "NÃO ENCONTRADO";
					endereco = null;
				}
			}
		}
		
		// ==== Mascaras de Campo ===============================================================================
		
		void maskNumber(object sender, EventArgs e) {
			Ferramentas.maskNumber((MinBox) sender);
		}
		
		void maskMoney(object sender, EventArgs e) {
			Ferramentas.maskMoney((MinBox) sender);
		}
		
		void maskQuantidade(object sender, EventArgs e) {
			Ferramentas.maskMoney((MinBox) sender, 3);
		}
		
		void maskData(object sender, EventArgs e) {
			Ferramentas.maskData((MinBox) sender);
		}
		
		// ==== Botões ==========================================================================================
		
		void cliqueAdicionar(object sender, EventArgs e) {
			try {
				if(cbxProduto.SelectedIndex > -1) {
					Produto pd = prod.ElementAt(cbxProduto.SelectedIndex);
					float quantidade = float.Parse(txtQuantidade.Text);
					float valor = float.Parse(txtPreco.Text);
					if(quantidade == 0 || valor == 0) {
						MessageBox.Show("Quantidade/Valor não podem ser R$ 0,00 !", "Valor R$ 0,00", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					} else {
						Venda_Produto n = new Venda_Produto();
						n.produto = pd.codigo;
						n.quantidade = quantidade;
						n.valor = valor;
						produtos.AddLast(n);
						txtQuantidade.Text = "";
						txtPreco.Text = "";
						
						ListViewItem itm = new ListViewItem();
						itm.Text = n.quantidade.ToString("n3");
						itm.SubItems.Add(pd.descricao);
						itm.SubItems.Add("R$ " + String.Format("{0:N}", n.valor));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", (n.quantidade * n.valor)));
						listaProduto.Items.Add(itm);
						atualizarInfo();
					}
				}
			} catch (Exception eConversao) {
				MessageBox.Show("Erro na conversão de valores, favor verificar Quantidade/Valor.\nDetalhes : " + eConversao.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		void cliqueExcluirProduto(object sender, EventArgs e) {
			try {
				produtos.Remove(produtos.ElementAt(listaProduto.FocusedItem.Index));
				listaProduto.Items.RemoveAt(listaProduto.FocusedItem.Index);
				atualizarInfo();
			} catch (Exception) { }
		}
		
		void cliqueLimpar(object sender, EventArgs e) {
			produtos = new LinkedList<Venda_Produto>();
			listaProduto.Items.Clear();
			atualizarInfo();
		}
		
		void selectProduto(object sender, EventArgs e) {
			try {
				ComboBox cbxSele = (ComboBox) sender;
				if(cbxProduto.SelectedIndex != cbxSele.SelectedIndex) {
					cbxProduto.SelectedIndex = cbxSele.SelectedIndex;
				} else if(cbxProdutoCodigo.SelectedIndex != cbxSele.SelectedIndex) {
					cbxProdutoCodigo.SelectedIndex = cbxSele.SelectedIndex;
				}
				txtPreco.Text = prod.ElementAt(((ComboBox) sender).SelectedIndex).preco.ToString();
			} catch (Exception) { }
		}
		
		void trocaCondicao(object sender, EventArgs e) {
			atualizarInfo();
		}
		
		void cliqueSalvarVenda(object sender, EventArgs e) {
			if(cliente == null) {
				MessageBox.Show("Favor selecionar um cliente válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(endereco == null) {
				MessageBox.Show("Favor selecionar um endereço para o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(produtos.Count == 0) {
				MessageBox.Show("Nenhum produto adicionado, favor adicionar ao menos para concluir a venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(txtData.Text.Equals("")) {
				MessageBox.Show("Favor informar a data do pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				// Preencher o Objeto
				venda.atendido = 0;
				venda.dtimplantacao = DateTime.Parse(txtData.Text);
				venda.endereco = endereco.codigo;
				venda.observacao = txtObservacao.Text;
				venda.pagamento = pagamentos.ElementAt(cbxCondicao.SelectedIndex).codigo;
				venda.pessoa = cliente.codigo;
				venda.sede = sede.ElementAt(cbxSede.SelectedIndex).codigo;
				venda.usuario = Ferramentas.sessao.codigo;
				
				Resultado res = new Resultado(false, "Não executado");
				if(venda.codigo == 0) { // Caso for nova venda
					// Comando personalizado para nova venda
					Comando com = new Comando("SELECT NewVenda(@loja, @cliente, @entrega, @dt, @cond, @atendido, @observacao, @usuario)");
					com.addParametro("@loja", venda.sede);
					com.addParametro("@cliente", venda.pessoa);
					com.addParametro("@entrega", venda.endereco);
					com.addParametro("@dt", venda.dtimplantacao);
					com.addParametro("@cond", venda.pagamento);
					com.addParametro("@atendido", venda.atendido);
					com.addParametro("@observacao", venda.observacao);
					com.addParametro("@usuario", venda.usuario);
					
					// Faz inserção e obtem código da venda
					res = com.consultarValor();
				} else { // Caso for alteração
					res = new ObjectDao<Venda>().alterar(venda);
					if(res.condicao) {
						res = new Comando("DELETE FROM venda_produto WHERE pedido = " + venda.codigo.ToString()).executar();
						if(res.condicao) { // Ele deleta os produtos e faz a inserção novamente para evitar erro
							res = new Resultado(true, "Alterado com sucesso !", venda.codigo);
						}
					}
				}
				
				String mensagem = "== Situação inserção de pedido ==" + Environment.NewLine + "= " + res.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + res.mensagem + Environment.NewLine + Environment.NewLine + "== Inserção de Produtos ==" + Environment.NewLine;
				if(res.condicao) {
					// Faz inserção dos produtos no banco
					int codigo = res.converter<int>();
					foreach (Venda_Produto v in produtos) {
						v.pedido = codigo;
						Resultado resProd = vDao.inserir(v);
						mensagem = mensagem + "= " + resProd.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + resProd.mensagem + Environment.NewLine; 
					}
					this.DialogResult = DialogResult.OK;
				}
				
				MessageBox.Show(mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	
	}
}
