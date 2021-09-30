
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.produto {
	public partial class CSProduto : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private ObjectDao<Produto> pDao = new ObjectDao<Produto>();
		private LinkedList<Produto> produtos = new LinkedList<Produto>();
		
		public CSProduto() {
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		public void pesquisar() {
			Resultado res = pDao.listar("SELECT * FROM produto WHERE CONCAT(cod_cliente, descricao, familia) LIKE '%" + txtPesquisa.Text.Replace("'", "") + "%' OR cod_barra LIKE '%" + txtPesquisa.Text.Replace("'", "") + "%'");
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
		
		void adicionarClique(object sender, EventArgs e) {
			CDProduto cd = new CDProduto();
			cd.Show();
		}
		
		void editarClique(object sender, EventArgs e) {
			try {
				CDProduto cd = new CDProduto(produtos.ElementAt(listProduto.FocusedItem.Index));
				cd.Show();
			} catch (Exception) { }
			
		}
	}
}
