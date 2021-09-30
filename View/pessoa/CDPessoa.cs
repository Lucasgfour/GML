
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GM.View.pessoa {
	public partial class CDPessoa : MaterialForm {
		
		protected override CreateParams CreateParams { get { const int CS_DROPSHADOW = 0x20000; CreateParams cp = base.CreateParams; cp.ClassStyle |= CS_DROPSHADOW; return cp; } }
		
		private ObjectDao<Pessoa> pDao = new ObjectDao<Pessoa>();
		private Pessoa p;
		
		public CDPessoa() {
			InitializeComponent();
			MaterialSkinManager.Instance.AddFormToManage(this);
		}
		
		void Arranque(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				primeiro();
			}
			foreach (Button btn in this.Controls.OfType<Button>()) {
				btn.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
			}
		}
		
		private void setDados(Resultado res) {
			if(res.condicao) {
				alternarModo(false);
				
				p = res.converter<Pessoa>();
				txtCodigo.Text = p.codigo.ToString();
				txtNome.Text = p.nome;
				cbxTipo.SelectedIndex = p.tipo;
				if(p.documento.Length == 18) {
					cbxDocumento.SelectedIndex = 1;
				} else {
					cbxDocumento.SelectedIndex = 0;
				}
				txtDocumento.Text = p.documento;
				txtContato.Text = p.contato;
				txtObservacao.Text = p.observacao;
			}
		}
		
		void maskDocumento(object sender, EventArgs e) {
			if(cbxDocumento.SelectedIndex == 0) {
				Ferramentas.maskCPF(txtDocumento);
			} else {
				Ferramentas.maskCNPJ(txtDocumento);
			}
		}
		
		private void primeiro() {
			Resultado res = pDao.consultar("SELECT * FROM pessoa WHERE codigo > 1 ORDER BY codigo ASC LIMIT 1");
			if(res.condicao) {
				setDados(res);
			} else {
				MessageBox.Show("Não foi encontrado nenhum registro. Detalhes : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void ultimo() {
			Resultado res = pDao.consultar("SELECT * FROM pessoa WHERE codigo > 1 ORDER BY codigo DESC LIMIT 1");
			if(res.condicao) {
				setDados(res);
			} else {
				MessageBox.Show("Não foi encontrado nenhum registro. Detalhes : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void proximo() {
			Resultado res = pDao.consultar("SELECT * FROM pessoa WHERE codigo > " + p.codigo.ToString() + "AND codigo > 1 ORDER BY codigo ASC LIMIT 1");
			if(res.condicao) { setDados(res); } else { primeiro(); }
		}
		
		private void anterior() {
			Resultado res = pDao.consultar("SELECT * FROM pessoa WHERE codigo < " + p.codigo.ToString() + " AND codigo > 1 ORDER BY codigo DESC LIMIT 1");
			if(res.condicao) { setDados(res); } else { ultimo(); }
		}
		
		private void irAte(int codigo) {
			Resultado res = pDao.consultar("SELECT * FROM pessoa WHERE codigo = " + p.codigo.ToString() + " AND codigo > 1 LIMIT 1");
			if(res.condicao) { setDados(res); }
		}
		
		private void alternarModo(bool edicao) {
			btnVoltar.Enabled = !(edicao);
			btnProximo.Enabled = !(edicao);
			btnNovo.Enabled = !(edicao);
			btnEditar.Enabled = !(edicao);
			btnDeletar.Enabled = !(edicao);
			btnPesquisar.Enabled = !(edicao);
			btnEndereco.Enabled = !(edicao);
			
			btnSalvar.Enabled = edicao;
			btnCancelar.Enabled = edicao;
			
			txtNome.ReadOnly = !(edicao);
			cbxTipo.Enabled = edicao;
			cbxDocumento.Enabled = edicao;
			txtDocumento.ReadOnly = !(edicao);
			txtContato.ReadOnly = !(edicao);
			txtObservacao.ReadOnly = !(edicao);
		}
		
		void voltarClique(object sender, EventArgs e) { anterior(); }
		
		void proximoClique(object sender, EventArgs e) { proximo(); }
		
		void novoClique(object sender, EventArgs e) {
			p = new Pessoa();
			txtCodigo.Text = "";
			txtNome.Text = "";
			cbxTipo.SelectedIndex = 0;
			cbxDocumento.SelectedIndex = 0;
			txtContato.Text = "";
			txtDocumento.Text = "";
			txtObservacao.Text = "";
			
			txtNome.Focus();
			
			alternarModo(true);
		}
		
		void editarClique(object sender, EventArgs e) { 
			if(p.codigo > 0) {
				alternarModo(true);
				txtNome.Focus();
			} else {
				MessageBox.Show("Nenhum registro selecionado !", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void salvarClique(object sender, EventArgs e) {
			if(txtNome.Text.Equals("") || txtDocumento.Text.Equals("") || !(txtDocumento.Text.Length == 14 || txtDocumento.Text.Length == 18)) {
				MessageBox.Show("Campos Nome e CPF/CNPJ não podem ser inválido/vázio !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				p.nome = txtNome.Text;
				p.tipo = cbxTipo.SelectedIndex;
				p.documento = txtDocumento.Text;
				p.observacao = txtObservacao.Text;
				p.contato = txtContato.Text;
				
				Resultado res = new Resultado(false, "Não houve tentativa");
				if(p.codigo > 0) {
					res = pDao.alterar(p);
				} else {
					res = pDao.inserir(p);
				}
				
				MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				if(p.codigo > 0 && res.condicao) {
					irAte(p.codigo);
				} else if(res.condicao) {
					ultimo();
				}
			}
		}
		
		
		void cancelarClique(object sender, EventArgs e) {
			if(p.codigo > 0) {
				irAte(p.codigo);
			} else {
				primeiro();
			}
		}
		
		void enderecoClique(object sender, EventArgs e) {
			PQEndereco pq = new PQEndereco(this.p);
			if(pq.ShowDialog() == DialogResult.OK) { }
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			setDados(Pesquisa.pessoa(2));
		}
	}
}
