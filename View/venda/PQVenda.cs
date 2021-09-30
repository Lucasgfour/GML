
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.venda {
	public partial class PQVenda : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private DataTable dados;
		private ObjectDao<Venda> vDao = new ObjectDao<Venda>();
		public Venda saida;
		
		public PQVenda() {
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
			}
		}
		
		private void pesquisar() {
			String SQL = "SELECT A.codigo AS Numero, A.dtimplantacao AS Data_Venda, C.nome AS Loja, B.nome AS Cliente, A.observacao AS Observacao, REPLACE(REPLACE(atendido, 0, 'NÃO ATENDIDO'), 1, 'ATENDIDO') AS Situação FROM venda AS A INNER JOIN pessoa AS B ON B.codigo = A.pessoa INNER JOIN sede AS C ON C.codigo = A.sede WHERE  CONCAT(A.codigo, C.nome, DATE_FORMAT(A.dtimplantacao,'%d/%m/%Y'), B.nome, A.observacao) LIKE '%" + txtPesquisa.Text.Replace("'", "") + "%' ORDER BY A.codigo ASC LIMIT 100";
			Comando com = new Comando(SQL);
			listaCompra.Items.Clear();
			Resultado res = com.consultarToDataTable();
			if(res.condicao) {
				this.dados = res.converter<DataTable>();
				foreach (DataRow linha in dados.Rows) {
					ListViewItem itm = new ListViewItem();
					itm.Text = linha[0].ToString();
					itm.SubItems.Add(DateTime.Parse(linha[1].ToString()).ToString("dd/MM/yyyy"));
					itm.SubItems.Add(linha[2].ToString());
					itm.SubItems.Add(linha[3].ToString());
					itm.SubItems.Add(linha[4].ToString());
					itm.SubItems.Add(linha[5].ToString());
					listaCompra.Items.Add(itm);
				}
			}
		}
		
		private void selecionar() {
			try {
				int codigo = int.Parse(listaCompra.FocusedItem.Text);
				Resultado res = vDao.consultar(codigo);
				if(res.condicao) {
					this.saida = res.converter<Venda>();
					this.DialogResult = DialogResult.OK;
				}
			} catch (Exception) { }
		}

		void pressEnter(object sender, KeyEventArgs e) {
			pesquisar();
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			pesquisar();
		}
		
		void sairClique(object sender, EventArgs e) {
			this.Close();
		}
		
		void selecionarClique(object sender, EventArgs e) {
			selecionar();
		}
		
		void duploClique(object sender, MouseEventArgs e) {
			selecionar();
		}
		
	}
}
