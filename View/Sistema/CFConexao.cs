
using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.Sistema {
	public partial class CFConexao : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		public CFConexao() {
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
    		materialSkinManager.AddFormToManage(this);
		}
		
		void cliqueSalvar(object sender, EventArgs e) {
			Preferencias.Default.Srv_IP = txtIP.Text;
			Preferencias.Default.Srv_User = txtUsuario.Text;
			Preferencias.Default.Srv_Senha = txtSenha.Text;
			Preferencias.Default.Srv_Banco = txtBanco.Text;
			Preferencias.Default.Save();
			MessageBox.Show("Configurado, necessário reiniciar para ter efeito !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Application.Exit();
		}
		
	}
}
