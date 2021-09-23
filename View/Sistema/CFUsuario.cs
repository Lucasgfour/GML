
using System;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.Sistema {
	public partial class CFUsuario : Form {
		
		private Usuario usuario = Ferramentas.sessao;
		
		public CFUsuario() {
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			txtNome.Text = usuario.nome;
		}
		
		void cliqueSalvar(object sender, EventArgs e) {
			Comando valSenha = new Comando("SELECT COUNT(codigo) FROM usuario WHERE usuario = @log AND senha = MD5(@sen)");
			valSenha.addParametro("@log", usuario.usuario);
			valSenha.addParametro("@sen", txtSenhaAtual.Text);
			
			Resultado resSenha = valSenha.consultarValor();
			if(!resSenha.condicao) {
				MessageBox.Show("Senha incorreta !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				int quant = int.Parse(resSenha.resultado.ToString());
				if(quant == 0) {
					MessageBox.Show("Senha incorreta !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else if(txtNome.Text.Equals("")) {
					MessageBox.Show("Nome não pode estar em branco !", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else {
					
					Resultado res = new Resultado(false, "Não executado !");
					if(txtSenha.Text.Equals("") && txtPin.Text.Equals("")) {
						Comando com = new Comando("UPDATE usuario SET nome = @nom WHERE codigo = @cod");
						com.addParametro("@nom", txtNome.Text);
						com.addParametro("@cod", usuario.codigo);
						res = com.executar();
					} else if(txtSenha.Text.Equals("") && !(txtPin.Text.Equals(""))) {
						Comando com = new Comando("UPDATE usuario SET nome = @nom, pin = @pin WHERE codigo = @cod");
						com.addParametro("@nom", txtNome.Text);
						com.addParametro("@pin", txtPin.Text);
						com.addParametro("@cod", usuario.codigo);
						res = com.executar();
					} else if(!(txtSenha.Text.Equals("")) && txtPin.Text.Equals("")) {
						Comando com = new Comando("UPDATE usuario SET nome = @nom, senha = MD5(@sen) WHERE codigo = @cod");
						com.addParametro("@nom", txtNome.Text);
						com.addParametro("@sen", txtSenha.Text);
						com.addParametro("@cod", usuario.codigo);
						res = com.executar();
					} else {
						Comando com = new Comando("UPDATE usuario SET nome = @nom, senha = MD5(@sen), pin = @pin WHERE codigo = @cod");
						com.addParametro("@nom", txtNome.Text);
						com.addParametro("@sen", txtSenha.Text);
						com.addParametro("@pin", txtPin.Text);
						com.addParametro("@cod", usuario.codigo);
						res = com.executar();
					}
					
					MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if(res.condicao) {
						Ferramentas.sessao.usuario = txtNome.Text;
						this.DialogResult = DialogResult.OK;
						this.Close();
					}
					
				}
			}
		}
	}
}
