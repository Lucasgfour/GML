
using System;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.produto {
	public partial class CDFamilia : Form {
		
		private ObjectDao<Familia> fDao = new ObjectDao<Familia>();
		private Familia fam = new Familia();
		
		public CDFamilia() {
			InitializeComponent();
		}
		
		public CDFamilia(Familia fam) {
			this.fam = fam;
			InitializeComponent();
		}
		
		public void salvar() {
			if(txtNome.Text.Equals("")) {
				MessageBox.Show("Favor informar num nome para a Família.", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				fam.nome = txtNome.Text;
				fam.descricao = txtDescricao.Text;
				Resultado res = new Resultado(false, "Não enviado");
				
				if(fam.codigo > 0) {
					res = fDao.alterar(fam);
				} else {
					res = fDao.inserir(fam);
				}
				
				MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				if(res.condicao) {
					this.Close();
				}
			}
		}
		
		void pressEnter(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				salvar();
			}
		}
		
		void salvarClique(object sender, EventArgs e) {
			salvar();
		}
		
		void sairClique(object sender, EventArgs e) {
			this.Close();
		}
		
		void Arranque(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else if(fam.codigo > 0) {
				txtNome.Text = fam.nome;
				txtDescricao.Text = fam.descricao;
			}
		}
	}
}
