
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
	public partial class CSProgramado : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private LinkedList<Relatorio_Programado> programados;
		private ObjectDao<Relatorio_Programado> pDao = new ObjectDao<Relatorio_Programado>();
		
		public CSProgramado() {
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
    		materialSkinManager.AddFormToManage(this);
		}
			
		void arranqueFormulario(object sender, EventArgs e) {
			pesquisar();
		}
		
		private void pesquisar() {
			Resultado resBusca = pDao.listar();
			listaRelatorios.Items.Clear();
			if(resBusca.condicao) {
				programados = resBusca.converter<LinkedList<Relatorio_Programado>>();
				foreach (Relatorio_Programado p in programados) {
					ListViewItem lv = new ListViewItem();
					lv.Text = p.nome;
					lv.SubItems.Add(p.relatorio.ToString());
					lv.SubItems.Add(p.ultimo.ToString("dd/MM/yyyy"));
	                listaRelatorios.Items.Add(lv);
				}
			}
		}
		
		void cliqueAdicionar(object sender, EventArgs e) {
			if(new CDProgramado().ShowDialog() == DialogResult.OK) {
				pesquisar();
			}
		}
		
		void cliqueEditar(object sender, EventArgs e) {
			try {
				Relatorio_Programado p = programados.ElementAt(listaRelatorios.FocusedItem.Index);
				if(new CDProgramado(p).ShowDialog() == DialogResult.OK) {
					pesquisar();
				}
			} catch (Exception) { }
		}
		
		void cliqueRemover(object sender, EventArgs e) {
			try {
				Relatorio_Programado p = programados.ElementAt(listaRelatorios.FocusedItem.Index);
				if(MessageBox.Show("Tem certeza que deseja deletar ? Essa ação não pode ser desfeita.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Resultado dele = pDao.delete(p);
					if(!dele.condicao) {
						MessageBox.Show(dele.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					} else {
						pesquisar();
					}
				}
			} catch (Exception) { }
		}
	}
}
