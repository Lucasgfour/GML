
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.estoque {
	public partial class CSEstoque : Form {
		
		private Produto produto;
		private ObjectDao<Produto> pDao = new ObjectDao<Produto>();
		
		private Decimal saldo;
		
		private LinkedList<Estoque> movimento;
		private ObjectDao<Estoque> mDao = new ObjectDao<Estoque>();
		
		public CSEstoque() {
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				txtDtInicio.Text = DateTime.Today.AddDays(((DateTime.Today.Day - 1) * -1)).ToString("dd/MM/yyyy");
				txtDtFinal.Text = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
			}
		}
		
		public void pesquisar() {
			if(txtDtInicio.Text.Equals("") || txtDtFinal.Text.Equals("")) {
				MessageBox.Show("Favor informar o período de busca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(txtProduto.Text.Equals("") || txtProduto.Text.Equals("NÃO ENCONTRADO")) {
				MessageBox.Show("Favor informar um produto válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				Resultado resMov = mDao.listar("SELECT * FROM estoque WHERE produto = " + produto.codigo.ToString() + " ORDER BY dtmov, codigo ASC");
				if(!resMov.condicao) {
					MessageBox.Show("Não foi encontrada nenhuma movimentação de estoque para o produto selecionado. Detalhes :" + resMov.mensagem, "Sem resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					listaMovimento.Items.Clear();
					movimento = resMov.converter<LinkedList<Estoque>>();
					foreach (Estoque est in movimento) {
						ListViewItem itm = new ListViewItem();
						itm.Text = est.dtmov.ToString("dd/MM/yyyy");
						if(est.tipo == 1) {
							itm.SubItems.Add(est.quantidade.ToString("n3"));
							itm.SubItems.Add("Entrada");
							itm.BackColor = Color.FromArgb(230, 255, 230);
						} else {
							itm.SubItems.Add((est.quantidade * -1).ToString("n3"));
							itm.SubItems.Add("Saída");
							itm.BackColor = Color.FromArgb(255, 230, 230);
						}
						itm.SubItems.Add(est.refe_nome + ": " + est.refe_cod);
						listaMovimento.Items.Add(itm);
					}
				}
			}
		}
		
		private void setProduto() {
			txtCodigo.Text = produto.codigo.ToString();
			txtProduto.Text = produto.descricao;
			txtUnidade.Text = produto.unidade;
			cbxSituacao.SelectedIndex = produto.situacao;
			
			Resultado bscSaldo = new Comando("SELECT SaldoEstoque(" + produto.codigo.ToString() + ")").consultarValor();
			if(bscSaldo.condicao) {
				txtSaldo.Text = bscSaldo.converter<decimal>().ToString("n3");
			} else {
				txtSaldo.Text = "0,000";
				MessageBox.Show("Não foi possível localizar o saldo do produto, motivo : " + bscSaldo.mensagem, "Erro", MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		// === Eventos ==================================================================================
		
		void cliqueProcurarProduto(object sender, EventArgs e) {
			Resultado pq = Pesquisa.produto();
			if(pq.condicao) {
				produto = pq.converter<Produto>();
				setProduto();
			}
		}
		
		void buscaProduto(object sender, EventArgs e) {
			try {
				int codigo = int.Parse(txtCodigo.Text);
				Resultado res = pDao.consultar(codigo);
				if(!res.condicao) {
					txtProduto.Text = "NÃO ENCONTRADO";	
				} else {
					produto = res.converter<Produto>();
					setProduto();
				}
			} catch (Exception) {
				txtProduto.Text = "NÃO ENCONTRADO";
			}
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			pesquisar();
		}
		
		
		void duploCliqueLista(object sender, MouseEventArgs e) {
			try {
				Estoque sel = movimento.ElementAt(listaMovimento.FocusedItem.Index);
				Ferramentas.openReferencia(sel.refe_nome, sel.refe_cod);
			} catch (Exception) { }
		}
		
		void maskData(object sender, EventArgs e) {
			Ferramentas.maskData((TextBox) sender);
		}
		
		void maskDataLeave(object sender, EventArgs e) {
			TextBox txt = (TextBox) sender;
			try {
				DateTime.Parse(txt.Text);
			} catch (Exception) {
				txt.Text = "";
			}
		}
	}
}
