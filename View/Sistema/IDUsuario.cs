
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using GM.View.Sistema;
using GM.View.venda;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View {
	public partial class IDUsuario : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		public IDUsuario() {
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
    		materialSkinManager.AddFormToManage(this);
   			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen800, Primary.LightGreen900, Primary.LightGreen200, Accent.LightGreen200, TextShade.WHITE);
		}
		
		void btnEntrar_Clique(object sender, EventArgs e) {
			logar();
		}
		
		void Arranque(object sender, EventArgs e) {
			Conexao con = new Conexao();
			Resultado res = con.openConexao();
			con.fecharConexao();
			if(!res.condicao) {
				MessageBox.Show("Não foi possível estabelecer a conexão com o banco de dados : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			} else {
				if(!Preferencias.Default.Usr_last_login.Trim().Equals("")) {
					txtUsuario.Text = Preferencias.Default.Usr_last_login;
					this.Show();
					txtSenha.Focus();
				}
			}
			
		}
		
		void IDUsuarioKeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				logar();
			}
		}
		
		private void logar() {
			if(txtUsuario.Text.Equals("")) {
				MessageBox.Show("Favor informar o nome de usuário !", "Campo em branco !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUsuario.Focus();
			} else if(txtSenha.Text.Equals("")) {
				MessageBox.Show("Favor informar a senha !", "Campo em branco !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSenha.Focus();
			} else {
				Comando comando = new Comando("SELECT * FROM usuario WHERE usuario = @user AND senha = MD5(@pass)");
				comando.addParametro("@user", txtUsuario.Text.ToUpper());
				comando.addParametro("@pass", txtSenha.Text.ToLower());
				Resultado res = comando.consultar<Usuario>();
				if(res.condicao == false) {
					MessageBox.Show("Usuário ou senha inválidos !", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtSenha.Text = "";
					txtUsuario.Focus();
				} else {
					Ferramentas.sessao = res.converter<Usuario>();
					if(Ferramentas.sessao.permissao == 0) {
						MessageBox.Show("Este usuário esta bloqueado, favor entrar em contato com administrador do sistema !", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					} else {
						Preferencias.Default.Usr_last_login = txtUsuario.Text.ToUpper();
						Preferencias.Default.Save();
						this.Opacity = 0;
						this.ShowInTaskbar = false;
						this.Hide();
						new homeMenu().Show();
					}
				}
			}
		}
		
	}
}
