
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.relatorio.programado {
	public partial class CDProgramado : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private Relatorio_Programado programado = new Relatorio_Programado();
		private ObjectDao<Relatorio_Programado> pDao = new ObjectDao<Relatorio_Programado>();
		private LinkedList<Relatorio> relatorios;
		
		public CDProgramado() {
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
    		materialSkinManager.AddFormToManage(this);
		}
		
		
		public CDProgramado(Relatorio_Programado p) {
			this.programado = p;
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
    		materialSkinManager.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			preencherConsulta();
			if(programado.codigo > 0) {
				txtEmail.Text = programado.email;
				txtAssunto.Text = programado.nome;
				cbxTipo.SelectedIndex = programado.tipo;
			} else {
				cbxRelatorio.SelectedIndex = 0;
				cbxTipo.SelectedIndex = 0;
			}
		}
		
		private void preencherConsulta() {
			Resultado buscaConsulta = new ObjectDao<Relatorio>().listar();
			if(!buscaConsulta.condicao) {
				MessageBox.Show("Não foi localizado relatórios ! " + buscaConsulta.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			} else {
				relatorios = buscaConsulta.converter<LinkedList<Relatorio>>();
				foreach (Relatorio r in relatorios) {
					cbxRelatorio.Items.Add(r.descricao);
					if(r.codigo == programado.codigo) {
						cbxRelatorio.SelectedIndex = (cbxRelatorio.Items.Count - 1);
					}
				}
				
			}
		}
		
		private void salvar() {
			if(txtAssunto.Text.Equals("")) {
				MessageBox.Show("Assunto inválido !", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else if(txtEmail.Text.Equals("") || !txtEmail.Text.Contains("@")) {
				MessageBox.Show("Formato de e-mail inválido !", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			} else {
				programado.nome = txtAssunto.Text;
				programado.tipo = cbxTipo.SelectedIndex;
				programado.email = txtEmail.Text;
				programado.relatorio = relatorios.ElementAt(cbxTipo.SelectedIndex).codigo;
				
				Resultado resSalvar = new Resultado(false, "Erro");
				if(programado.codigo > 0) {
					resSalvar = pDao.alterar(programado);
				} else {
					programado.ultimo = DateTime.Today.AddDays(-30);
					resSalvar = pDao.inserir(programado);
				}
				
				if(!resSalvar.condicao) {
					MessageBox.Show(resSalvar.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					this.DialogResult = DialogResult.OK;
				}
			}
		}
		
		
		void cliqueSalvar(object sender, EventArgs e) {
			salvar();
		}
		
		void cliqueCancelar(object sender, EventArgs e) {
			this.Close();
		}
		
		void pressionarTecla(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				btnSalvar.PerformClick();
			}
		}
	}
}
