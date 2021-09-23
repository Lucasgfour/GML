
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.venda {
	public partial class selectSede : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private ObjectDao<Sede> sDao = new ObjectDao<Sede>();
		private LinkedList<Sede> sedes = new LinkedList<Sede>();
		
		public selectSede() {
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
    		materialSkinManager.AddFormToManage(this);
		}
		
		
		void arranqueFormulario(object sender, EventArgs e) {
			pesquisar();
		}
		
		private void pesquisar() {
			Resultado busca = sDao.listar();
			if(!busca.condicao) {
				MessageBox.Show("Não foi possível localizar nenhuma sede !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				sedes = (LinkedList<Sede>) busca.resultado;
				foreach (Sede s in sedes) {
					cbxSede.Items.Add(s.nome);
				}
				cbxSede.SelectedIndex = 0;
			}
		}
		
		void cliqueSelecionar(object sender, EventArgs e) {
			try {
				Sede s = sedes.ElementAt(cbxSede.SelectedIndex);
				CDBalcao cdbal = new CDBalcao(s);
				cdbal.Show();
				this.Close();
			} catch (Exception) { }
		}
	}
}
