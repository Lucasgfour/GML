
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.custo {
	public partial class PQCusto : Form {
		
		private DataTable dados;
		private ObjectDao<Custo> cDao = new ObjectDao<Custo>();
		public Custo saida {get; private set;}
		
		public PQCusto() {
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
			}
		}
		
		private void pesquisar() {
			String SQL = "SELECT a.codigo AS codigo, b.nome AS fornecedor, a.descricao AS descricao, c.nome AS loja, a.categoria AS categoria, DATE_FORMAT(a.emissao,'%d/%m/%Y') AS emissao, a.observacao AS observacao FROM custo AS a INNER JOIN pessoa AS b ON b.codigo = a.pessoa INNER JOIN sede AS c ON c.codigo = a.sede WHERE CONCAT(a.codigo, b.nome, c.nome, a.descricao, a.categoria, DATE_FORMAT(a.emissao,'%d/%m/%Y'), a.observacao) LIKE '%" + txtPesquisa.Text.Replace("'", "") + "%' LIMIT 100";
			Comando com = new Comando(SQL);
			listaCusto.Items.Clear();
			Resultado res = com.consultarToDataTable();
			if(res.condicao) {
				this.dados = res.converter<DataTable>();
				foreach (DataRow linha in dados.Rows) {
					ListViewItem itm = new ListViewItem();
					itm.Text = linha[0].ToString();
					itm.SubItems.Add(linha[1].ToString());
					itm.SubItems.Add(linha[2].ToString());
					itm.SubItems.Add(linha[3].ToString());
					itm.SubItems.Add(linha[4].ToString());
					itm.SubItems.Add(linha[5].ToString());
					itm.SubItems.Add(linha[6].ToString());
					listaCusto.Items.Add(itm);
				}
			}
		}
		
		private void selecionar() {
			try {
				int codigo = int.Parse(listaCusto.FocusedItem.Text);
				Resultado res = cDao.consultar(codigo);
				if(res.condicao) {
					this.saida = res.converter<Custo>();
					this.DialogResult = DialogResult.OK;
				}
			} catch (Exception) { }
		}

		void pressEnter(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				pesquisar();	
			}
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
