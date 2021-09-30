
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.Sistema {
	public partial class PQCidade : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private LinkedList<Cidade> cidades = new LinkedList<Cidade>();
		private ObjectDao<Cidade> cDao = new ObjectDao<Cidade>();
		public Resultado resultado;
		
		public PQCidade() {
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranque(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
			}
		}
		
		public void pesquisar() {
			Resultado res = cDao.listar("SELECT * FROM cidade WHERE nome LIKE '%" + txtPesquisa.Text.Replace("'", "") + "%' LIMIT 500");
			listCidade.Items.Clear();
			if(res.condicao) {
				cidades = res.converter<LinkedList<Cidade>>();
				foreach (Cidade cid in cidades) {
					ListViewItem itm = new ListViewItem();
					itm.Text = cid.codigo.ToString();
					itm.SubItems.Add(cid.nome);
					itm.SubItems.Add(cid.uf);
					listCidade.Items.Add(itm);
				}
			} else {
				MessageBox.Show("Não foi possível localizar nenhum registro, motivo : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void selecionar() {
			try {
				this.resultado = new Resultado(true, "OK", cidades.ElementAt(listCidade.FocusedItem.Index));
				this.DialogResult = DialogResult.OK;
			} catch (Exception) { }
		}
		
		void selecionarClique(object sender, EventArgs e) {
			selecionar();
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			pesquisar();
		}
		
		
	}
}
