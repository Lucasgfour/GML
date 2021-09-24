
using System;
using System.Collections.Generic;
using System.Drawing;
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
			
		}
		
		private void pesquisar() {
			
		}
	}
}
