
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.custo {
	public partial class CDCusto : Form {
		
		private Custo custo = new Custo();
		private LinkedList<Contas> pagamentos;
		
		private LinkedList<Sede> sedes;
		private ObjectDao<Sede> sDao = new ObjectDao<Sede>();
		
		private ObjectDao<Contas> cDao = new ObjectDao<Contas>();
		
		private ObjectDao<Custo_categoria> catDao = new ObjectDao<Custo_categoria>();
		
		public CDCusto() {
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				cbxTipo.SelectedIndex = 0;
				
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
			}
		}
		
		// Realizar busca do cliente e exibir na tela
		void buscarCliente(object sender, MouseEventArgs e) {
			Resultado res = Pesquisa.pessoa(1);
			if(res.condicao) {
				txtCodigoFornecedor.Text = res.converter<Pessoa>().codigo.ToString();
				txtNomeFornecedor.Text = res.converter<Pessoa>().nome.ToString();
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
		
		void showCategoria(object sender, EventArgs e) {
			try {
				Resultado res = catDao.consultar("SELECT * FROM custo_categoria WHERE codigo = " + int.Parse(txtCategoria.Text));
				if(!res.condicao) {
					txtNomeCategoria.Text = "NÃO ENCONTRADO";
				} else {
					txtNomeCategoria.Text = res.converter<Custo_categoria>().nome;
				}
			} catch (Exception) {
				txtNomeFornecedor.Text = "NÃO ENCONTRADO";
			}
		}
		
		void buscarCategoria(object sender, MouseEventArgs e) {
			Resultado res = Pesquisa.custo_categoria();
			if(res.condicao) {
				txtCategoria.Text = res.converter<Custo_categoria>().codigo.ToString();
				txtNomeCategoria.Text = res.converter<Custo_categoria>().nome.ToString();
			}
		}
		
		// === Mascara =========================================================================
		
		void maskData(object sender, EventArgs e) {
			Ferramentas.maskData((TextBox) sender);
		}
		
		void maskValor(object sender, EventArgs e) {
			Ferramentas.maskMoney((TextBox) sender);
		}
		
		void maskNumber(object sender, EventArgs e) {
			Ferramentas.maskNumber(txtCodigoFornecedor);
		}
		
		void maskDataLeave(object sender, EventArgs e) {
			try {
				DateTime.Parse(((TextBox) sender).Text);
			} catch (Exception) {
				((TextBox) sender).Text = "";
			}
		}
		
		// === Vencimento ======================================================================
		
		void cliqueAdicionarPagamento(object sender, EventArgs e) {
			if(txtVencimento.Text.Equals("")) {
				MessageBox.Show("Favor insira uma data válida !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(txtParcVencimento.Text.Equals("")) {
				MessageBox.Show("Favor inserir um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				DateTime data = DateTime.Parse(txtVencimento.Text);
				float valor = float.Parse(txtParcVencimento.Text);
				
				if(data < DateTime.Today) {
					MessageBox.Show("Atenção ! Data de vencimento é inferior a Hoje, favor verificar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				
				if(valor < 0) {
					MessageBox.Show("Valor não pode ser inferior a R$ 0,00", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
				} else {
					ListViewItem itm = new ListViewItem();
					itm.Text = data.ToString("dd/MM/yyyy");
					itm.SubItems.Add(String.Format("{0:N}", valor));
					listaPagamento.Items.Add(itm);
					
					txtVencimento.Text = "";
					txtVencimento.Focus();
				}
			}
		}
		
		
		void cliqueRemoverPagamento(object sender, EventArgs e) {
			try {
				listaPagamento.Items.RemoveAt(listaPagamento.FocusedItem.Index);
			} catch (Exception) { }
		}
		
		void pressionarEnterPagamento(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				btnAdicionar.PerformClick();	
			}
		}
		
		// == Finalizar e Adicionar =======================================================
		
		void cliqueSair(object sender, EventArgs e) {
			this.Close();
		}
		
		void cliqueSalvar(object sender, EventArgs e) {
			if(txtNomeFornecedor.Text.Equals("") || txtNomeFornecedor.Text.Equals("NÃO ENCONTRADO")) {
				MessageBox.Show("Fornecedor não selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if(txtDescricao.Text.Equals("")) {
				MessageBox.Show("Descrição não pode ser em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if(txtValor.Text.Equals("") || txtEmissao.Text.Equals("") || txtValor.Text.Equals(",")) {
				MessageBox.Show("Favor informar o valor/data do custo/despesa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if(txtNomeCategoria.Text.Equals("") || txtNomeCategoria.Text.Equals("NÃO ENCONTRADO")) {
				MessageBox.Show("Favor informar uma categoria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				// Preenchimento Objeto
				custo.categoria = int.Parse(txtCategoria.Text);
				custo.descricao = txtDescricao.Text;
				custo.emissao = DateTime.Parse(txtEmissao.Text);
				custo.observacao = txtObservacao.Text;
				custo.tipo = cbxTipo.SelectedIndex;
				custo.valor = float.Parse(txtValor.Text);
				custo.pessoa = int.Parse(txtCodigoFornecedor.Text);
				custo.sede = sedes.ElementAt(cbxLoja.SelectedIndex).codigo;
				
				// Criação das Parcelas
				float totalParcela = 0;
				int parcela = 1;
				pagamentos = new LinkedList<Contas>();
				foreach (ListViewItem itm in listaPagamento.Items) {
					Contas nova = new Contas();
					nova.emissao = custo.emissao;
					nova.pessoa = custo.pessoa;
					nova.refe_nome = cbxTipo.Text;
					nova.sede = custo.sede;
					nova.sequencia = parcela;
					parcela += 1;
					nova.tipo = 0;
					nova.valor = float.Parse(itm.SubItems[1].Text);
					nova.vencimento = DateTime.Parse(itm.SubItems[0].Text);
					pagamentos.AddLast(nova);
					totalParcela += nova.valor;
				}
				
				if(custo.valor != totalParcela) { // Validação de Parcelas batem com valor total informado
					MessageBox.Show("Valor total das parcelas (R$ " + String.Format("{0:N}", totalParcela) + ") difere do valor informado (R$ " + String.Format("{0:N}", custo.valor) + ").", "Valor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else {
					// Comando personalizado para inserção do custo e obter Código
					String mensagem = "== INSERÇÃO DE CUSTO/DESPESA ==" + Environment.NewLine;
					Comando com = new Comando("SELECT NewCusto(@fornecedor, @loja, @tipo, @emissao, @descricao, @observacao, @valor , @categoria)");
					com.addParametro("@fornecedor", custo.pessoa);
					com.addParametro("@loja", custo.sede);
					com.addParametro("@tipo", custo.tipo);
					com.addParametro("@emissao", custo.emissao);
					com.addParametro("@descricao", custo.descricao);
					com.addParametro("@observacao", custo.observacao);
					com.addParametro("@valor", custo.valor);
					com.addParametro("@categoria", custo.categoria);
					
					Resultado resCusto = com.consultarValor();
					mensagem = mensagem + "= " + resCusto.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + resCusto.mensagem + Environment.NewLine;
					if(resCusto.condicao) {
						// Após inserção do Custo e criado as parcela
						int codigo = resCusto.converter<int>();
						foreach (Contas ct in pagamentos) {
							ct.refe_cod = codigo;
						}
						
						mensagem = mensagem + Environment.NewLine + Atende.createParcela(pagamentos);
					}
					
					MessageBox.Show(mensagem);
					if(resCusto.condicao) {
						this.Close();
					}
				}
			}
		}
		
		
	}
}
