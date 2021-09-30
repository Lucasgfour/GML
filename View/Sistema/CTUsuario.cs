
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
	public partial class CTUsuario : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private ObjectDao<Usuario> uDao = new ObjectDao<Usuario>();
		private LinkedList<Usuario> usuarios = new LinkedList<Usuario>();
		
		public CTUsuario() {
			InitializeComponent();	
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void Arranque(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
			}
		}
		
		private void pesquisar() {
			Resultado resUsr = uDao.listar("SELECT codigo, usuario, 'censurado' AS senha, nome, permissao, vendedor, sede, 'censurado' AS pin FROM usuario ORDER BY codigo");
			listaUsuario.Items.Clear();
			if(resUsr.condicao) {
				usuarios = resUsr.converter<LinkedList<Usuario>>();
				foreach (Usuario usr in usuarios) {
					ListViewItem itm = new ListViewItem();
					itm.Text = usr.codigo.ToString();
					itm.SubItems.Add(usr.usuario);
					itm.SubItems.Add(usr.permissao.ToString());
					itm.SubItems.Add(usr.nome);
					listaUsuario.Items.Add(itm);
				}
			} else {
				MessageBox.Show("Erro ao localizar usuários :" + resUsr.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void cliqueNovo(object sender, EventArgs e) {
			CDUsuario cd = new CDUsuario();
			if(cd.ShowDialog() == DialogResult.OK) { }
			pesquisar();
		}
		
		void cliqueEditar(object sender, EventArgs e) {
			try {
				Usuario usr = usuarios.ElementAt(listaUsuario.FocusedItem.Index);
				CDUsuario cd = new CDUsuario(usr);
				if(cd.ShowDialog() == DialogResult.OK) { }
				pesquisar();
			} catch (Exception) { }
		}
		
		void redefinirSenha(object sender, EventArgs e) {
			try {
				Usuario usr = usuarios.ElementAt(listaUsuario.FocusedItem.Index);
				if(MessageBox.Show("Tem certeza ? Ao fazer isso a senha do usuário sera redefinida para 'chave123'", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Comando com = new Comando("UPDATE usuario SET senha = MD5('chave123') WHERE codigo = @cod");
					com.addParametro("@cod", usr.codigo);
					
					Resultado res = com.executar();
					if(res.condicao) {
						MessageBox.Show("Senha redefinada com sucesso !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
					} else {
						MessageBox.Show("Erro : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			} catch (Exception) { }
		}
	}
}
