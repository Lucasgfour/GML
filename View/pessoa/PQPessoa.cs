
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.pessoa {
	public partial class PQPessoa : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private ObjectDao<Pessoa> pDao = new ObjectDao<Pessoa>();
		private LinkedList<Pessoa> pessoas = new LinkedList<Pessoa>();
		private int tipo = 3;
		public Pessoa saida;
		
		public PQPessoa(int tipo) {
			if(tipo == 0) {
				this.tipo = 1;
			} else if(tipo == 1) {
				this.tipo = 0;
			} else if(tipo == 3) {
				this.tipo = 4;
			}
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisa();
			}
		}
		
		private void pesquisa() {
			Resultado res = pDao.listar("SELECT * FROM pessoa WHERE tipo != " + this.tipo + " AND codigo > 1 AND CONCAT(codigo, nome, documento) LIKE '%" + txtPesquisa.Text.Replace("'","") + "%'");
			
			listPessoa.Items.Clear();
			if(res.condicao) {
				pessoas = res.converter<LinkedList<Pessoa>>();
				foreach (Pessoa p in pessoas) {
					ListViewItem itm = new ListViewItem();
					itm.Text = p.codigo.ToString();
					itm.SubItems.Add(p.nome);
					itm.SubItems.Add(p.documento);
					listPessoa.Items.Add(itm);
				}
			}
		}
		
		private void selecionar() {
			try {
				saida = pessoas.ElementAt(listPessoa.FocusedItem.Index);
				this.DialogResult = DialogResult.OK;
			} catch (Exception) { }
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			pesquisa();
		}
		
		void sairClique(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
		}
		
		void selecionarClique(object sender, EventArgs e) {
			selecionar();
		}
		
		void duploClique(object sender, EventArgs e) {
			selecionar();
		}
		
		void pressEnterPesquisa(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				pesquisa();
			}
		}
		
	
	}
}
