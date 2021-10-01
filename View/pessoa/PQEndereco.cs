
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
	public partial class PQEndereco : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private Pessoa pessoa;
		private LinkedList<zEndereco> enderecos = new LinkedList<zEndereco>();
		public Endereco saida;
		private bool pesquisa = false;
		
		public PQEndereco(Pessoa pessoa) {
			this.pessoa = pessoa;
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);

		}
		
		public PQEndereco(Pessoa pessoa, bool pesquisa) {
			this.pessoa = pessoa;
			this.pesquisa = pesquisa;
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);

		}
		
		void arranque(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
				btnSelecionar.Visible = pesquisa;
			}
		}
		
		public void pesquisar() {
			Comando com = new Comando("SELECT endereco.codigo, endereco.rua, endereco.bairro, endereco.cidade, endereco.pessoa, cidade.nome AS nomeCidade FROM endereco INNER JOIN cidade ON cidade.codigo = endereco.cidade WHERE endereco.pessoa = @cod");
			com.addParametro("@cod", pessoa.codigo.ToString());
			Resultado res = com.listar<zEndereco>();
			if(!(res.condicao)) {
				MessageBox.Show("Nenhum endereço localizado : " + res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				enderecos = res.converter<LinkedList<zEndereco>>();
				listEndereco.Items.Clear();
				foreach (zEndereco end in enderecos) {
					ListViewItem itm = new ListViewItem();
					itm.Text = end.codigo;
					itm.SubItems.Add(end.rua);
					itm.SubItems.Add(end.nomeCidade);
					listEndereco.Items.Add(itm);
				}
			}
		}
		
		void novoClique(object sender, EventArgs e) {
			CDEndereco cd = new CDEndereco(this.pessoa.codigo);
			if(cd.ShowDialog() == DialogResult.OK) { }
			pesquisar();
		}
		
		void editarClique(object sender, EventArgs e) {
			try {
				Endereco end = enderecos.ElementAt(listEndereco.FocusedItem.Index).getEndereco();
				CDEndereco cd = new CDEndereco(end);
				if(cd.ShowDialog() == DialogResult.OK) { }
				pesquisar();
			} catch (Exception) { }
		}
		
		private void selecionar() {
			try {
				saida = enderecos.ElementAt(listEndereco.FocusedItem.Index).getEndereco();
				this.DialogResult = DialogResult.OK;
			} catch (Exception) { }
		}
		
		void selecionarClique(object sender, EventArgs e) {
			selecionar();
		}
		
		void duploClique(object sender, MouseEventArgs e) {
			if(btnSelecionar.Visible == true) {
				selecionar();
			}
		}

	}
}
