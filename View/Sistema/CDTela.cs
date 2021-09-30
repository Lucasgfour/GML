
using System;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.Sistema {
	public partial class CDTela : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private Tela tela = new Tela();
		private ObjectDao<Tela> tDao = new ObjectDao<Tela>();
		
		public CDTela() {
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		public CDTela(Tela tela) {
			this.tela = tela;
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else if(tela.codigo > 0) {
				txtTela.ReadOnly = true;
				txtTela.Text = tela.nome;
				cbxSituacao.SelectedIndex = tela.disponivel;
				cbxNivel.SelectedIndex = tela.nivel;
			} else {
				cbxNivel.SelectedIndex = 0;
				cbxSituacao.SelectedIndex = 1;
			}
		}
		
		void cliqueSalvar(object sender, EventArgs e) {
			tela.nome = txtTela.Text;
			tela.nivel = cbxNivel.SelectedIndex;
			tela.disponivel = cbxSituacao.SelectedIndex;
			
			Resultado res = new Resultado(false, "Não executado");
			if(tela.codigo > 0) {
				res = tDao.alterar(tela);
			} else {
				Comando com = new Comando("SELECT COUNT(codigo) FROM tela WHERE nome = @tela");
				com.addParametro("@tela", txtTela.Text);
				
				res = com.consultarValor();
				if(res.condicao) {
					if(int.Parse(res.resultado.ToString()) == 0) {
						res = tDao.inserir(tela);
					} else {
						res = new Resultado(false, "Já existe uma tela com este nome !");
					}
				}
			}
			
			MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if(res.condicao) {
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
		
		void cliqueSair(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
