
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.Sistema {
	public partial class CDUsuario : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private LinkedList<Sede> sedes;
		private ObjectDao<Sede> sDao = new ObjectDao<Sede>();
		private Usuario usuario = new Usuario();
		
		public CDUsuario() {
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		public CDUsuario(Usuario usuario) {
			this.usuario = usuario;
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				Resultado res = sDao.listar();
				if(!res.condicao) {
					MessageBox.Show("Erro ao buscar sede(s) : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
				} else {
					sedes = res.converter<LinkedList<Sede>>();
					cbxSede.Items.Clear();
					foreach (Sede sd in sedes) {
						cbxSede.Items.Add(sd.nome);
					}
					cbxSede.SelectedIndex = 0;
					cbxNivel.SelectedIndex = 0;
				}
				
				if(usuario.codigo > 0) {
					txtUsuario.Text = usuario.usuario;
					txtNome.Text = usuario.nome;
					if(usuario.vendedor == 1) {
						chkVendedor.Checked = true;
					}
					for (int i = 0; i < sedes.Count; i++) {
						if(sedes.ElementAt(i).codigo == usuario.sede) {
							cbxSede.SelectedIndex = i;
						}
					}
					cbxNivel.SelectedIndex = usuario.permissao;
				}
			}
		}
		
		void cliqueSalvar(object sender, EventArgs e) {
			if(txtUsuario.Text.Equals("")) {
				MessageBox.Show("Favor informar o login do usuário !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(txtNome.Text.Equals("")) {
				MessageBox.Show("Favor informar o nome do usuário !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				usuario.usuario = txtUsuario.Text;
				usuario.nome = txtNome.Text;
				usuario.permissao = cbxNivel.SelectedIndex;
				if(chkVendedor.Checked) {
					usuario.vendedor = 1;
				} else {
					usuario.vendedor = 0;
				}
				usuario.sede = sedes.ElementAt(cbxSede.SelectedIndex).codigo;
				
				Comando sv = new Comando("");
				
				if(!validarUsuario()) {
					MessageBox.Show("Login já existente !", "Já existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else if(usuario.codigo > 0) {
					sv = new Comando("UPDATE usuario SET usuario = @usuario, nome = @nome, permissao = @permissao, vendedor = @vendedor, sede = @sede WHERE codigo = @codigo");
					sv.addParametro("@usuario", usuario.usuario);
					sv.addParametro("@nome", usuario.nome);
					sv.addParametro("@permissao", usuario.permissao);
					sv.addParametro("@vendedor", usuario.vendedor);
					sv.addParametro("@sede", usuario.sede);
					sv.addParametro("@codigo", usuario.codigo);
				} else {
					sv = new Comando("INSERT INTO usuario(usuario, nome, permissao, vendedor, sede, senha, pin) VALUES(@usuario, @nome, @permissao, @vendedor, @sede, MD5('chave123'), '1234')");
					sv.addParametro("@usuario", usuario.usuario);
					sv.addParametro("@nome", usuario.nome);
					sv.addParametro("@permissao", usuario.permissao);
					sv.addParametro("@vendedor", usuario.vendedor);
					sv.addParametro("@sede", usuario.sede);
				}
				
				Resultado res = sv.executar();
				MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if(res.condicao) {
					this.Close();
				}
			}
		}
		
		private bool validarUsuario() {
			Comando com = new Comando("SELECT COUNT(codigo) FROM usuario WHERE usuario = @usr AND codigo != @cod");
			com.addParametro("@usr", usuario.usuario);
			com.addParametro("@cod", usuario.codigo);
			
			Resultado resTeste = com.consultarValor();
			int quant = int.Parse(resTeste.resultado.ToString());
			
			if(quant > 0) {
				return false;
			} else {
				return true;
			}
		}
		
		void cliqueSair(object sender, EventArgs e) {
			this.Close();
		}
	}
}
