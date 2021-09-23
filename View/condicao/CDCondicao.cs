
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.condicao {
	public partial class CDCondicao : Form {
		
		private Condicao condicao = new Condicao();
		private ObjectDao<Condicao> cDao = new ObjectDao<Condicao>();
		
		public CDCondicao() {
			InitializeComponent();
		}
		
		public CDCondicao(Condicao condicao) {
			this.condicao = condicao;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				cbxCondicao.SelectedIndex = 0;
				if(condicao.codigo > 0) {
					txtCodigo.Text = condicao.codigo.ToString();
					txtNome.Text = condicao.nome;
					foreach (int cd in condicao.getCondicao()) {
						listaDias.Items.Add(cd.ToString());
					}
					cbxCondicao.SelectedIndex = condicao.tipo;
				}
			}
		}
		
		private void salvar() {
			if(listaDias.Items.Count == 0) {
				MessageBox.Show("Favor adicionar ao menos um dia a condição de pagamento !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(txtNome.Text.Equals("")) {
				MessageBox.Show(".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				this.condicao.nome = txtNome.Text;
				this.condicao.condicao = transformCondicao();
				this.condicao.tipo = cbxCondicao.SelectedIndex;
				
				Resultado res = new Resultado(false, "Não houve tentativa.");
				
				if(this.condicao.codigo > 0) {
					res = cDao.alterar(this.condicao);
				} else {
					res = cDao.inserir(this.condicao);
				}
				
				MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				if(res.condicao) {
					this.DialogResult = DialogResult.OK;
				}
			}
		}
		
		private String transformCondicao() {
			int[] condicoes = new int[listaDias.Items.Count];
			foreach (ListViewItem itm in listaDias.Items) {
				condicoes[itm.Index] = int.Parse(itm.Text);
			}
			
			int temp = 0;
			for (int write = 0; write < condicoes.Length; write++) {
			    for (int sort = 0; sort < condicoes.Length - 1; sort++) {
			        if (condicoes[sort] > condicoes[sort + 1]) {
			            temp = condicoes[sort + 1];
			            condicoes[sort + 1] = condicoes[sort];
			            condicoes[sort] = temp;
			        }
			    }
			}
			
			String saida = "";
			for (int i = 0; i < condicoes.Length; i++) {
				if (saida.Equals("")) {
					saida = condicoes[i].ToString();
				} else {
					saida = saida + "/" + condicoes[i].ToString();
				}
			}
			return saida;
		}
		
		
		
		void cliqueAdd(object sender, EventArgs e) {
			if(!txtDias.Text.Equals("")) {
				listaDias.Items.Add(txtDias.Text);
				txtDias.Text = "";
				txtDias.Focus();
			}
		}
		
		void MaskDias(object sender, EventArgs e) {
			Ferramentas.maskNumber(txtDias);
		}
		
		void pressEnterDias(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter && !txtDias.Text.Equals("")) {
				listaDias.Items.Add(txtDias.Text);
				txtDias.Text = "";
			}
		}
		
		void cliqueDeletar(object sender, EventArgs e) {
			try {
				listaDias.Items.RemoveAt(listaDias.FocusedItem.Index);
			} catch (Exception) { }
		}
		
		void cliqueSalvar(object sender, EventArgs e) {
			salvar();
		}
		
		void sairClique(object sender, EventArgs e) {
			this.Close();
		}
	}
}
