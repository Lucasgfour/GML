
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.produto {
	public partial class PQProduto : Form {
		
		public Resultado saida = new Resultado(false, "Nenhum registro selecionado.");
		private ObjectDao<Produto> pDao = new ObjectDao<Produto>();
		private LinkedList<Produto> produtos = new LinkedList<Produto>();
		
		public PQProduto() {
			InitializeComponent();
		}
		
		public void pesquisar() {
			Resultado res = pDao.listar("SELECT * FROM produto WHERE CONCAT(cod_cliente, descricao, familia) LIKE '%" + txtPesquisa.Text.Replace("'", "") + "%' OR cod_barra LIKE '%" + txtPesquisa.Text.Replace("'", "") + "%' LIMIT 100");
			listProduto.Items.Clear();
			if(res.condicao) {
				produtos = res.converter<LinkedList<Produto>>();
				foreach (Produto pro in produtos) {
					ListViewItem itm = new ListViewItem();
					itm.Text = pro.cod_cliente;
					itm.SubItems.Add(pro.descricao);
					itm.SubItems.Add(pro.familia.ToString());
					itm.SubItems.Add(pro.unidade);
					if(pro.situacao == 0) {
						itm.SubItems.Add("Suspenso");
					} else {
						itm.SubItems.Add("Ativo");
					}
					itm.SubItems.Add("R$ " + String.Format("{0:N}", pro.preco));
					listProduto.Items.Add(itm);
				}
			} else {
				MessageBox.Show(res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
		void Arranque(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
			}
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			pesquisar();
		}
		
		private void selecionar() {
			try {
				this.saida = new Resultado(true, "Produto OK", produtos.ElementAt(listProduto.FocusedItem.Index));
				this.DialogResult = DialogResult.OK;
			} catch (Exception) {
				MessageBox.Show("Selecione um produto válido !", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void selecionarClique(object sender, EventArgs e) {
			selecionar();
		}
		
		void sairClique(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
		}
		
		void duploClique(object sender, MouseEventArgs e) {
			selecionar();
		}
	}
}
