
using System;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.pessoa {
	public partial class CDEndereco : Form {
		
		private int pessoa;
		private Endereco endereco;
		private ObjectDao<Endereco> eDao = new ObjectDao<Endereco>("codigo", false);
		
		public CDEndereco(int pessoa) {
			this.pessoa = pessoa;
			this.endereco = new Endereco();
			this.endereco.pessoa = this.pessoa;
			InitializeComponent();
		}
		
		public CDEndereco(Endereco end) {
			this.endereco = end;
			this.pessoa = 0;
			InitializeComponent();
		}
		
		void ArranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else if(this.pessoa == 0) {
				this.Show();
				txtCodigo.Text = this.endereco.codigo;
				txtCodigo.ReadOnly = true;
				txtRua.Text = this.endereco.rua;
				txtBairro.Text = this.endereco.bairro;
				txtCidade.Text = this.endereco.cidade.ToString();
				txtCidade.Focus();
				txtRua.Focus();
			}
		}
		
		void pesquisarClique(object sender, EventArgs e) {
			Resultado res = Pesquisa.cidade();
			if(res.condicao) {
				txtCidade.Text = res.converter<Cidade>().codigo.ToString();
				txtNomeCidade.Text = res.converter<Cidade>().nome;
			}
		}
		
		void buscaCidade(object sender, EventArgs e) {
			try {
				setCidade(Ferramentas.getCidade(int.Parse(txtCidade.Text)));	
			} catch (Exception) {
				txtNomeCidade.Text = "NÃO ENCONTRADO";
			}
		}
		
		private void setCidade(Resultado res) {
			if(res.condicao) {
				txtNomeCidade.Text = res.converter<Cidade>().nome;
			} else {
				txtNomeCidade.Text = "NÃO ENCONTRADO";
			}
		}
		
		private Boolean disponivel(String codigo) {
			Comando com = new Comando("SELECT COUNT(codigo) FROM endereco WHERE pessoa = @p AND codigo = @c");
			com.addParametro("@p", this.pessoa);
			com.addParametro("@c", txtCodigo.Text);
			
			Resultado res = com.consultarValor();
			if(!res.condicao) {
				return false;
			} else {
				int vlr = int.Parse(res.resultado.ToString());
				if(vlr == 0) {
					return true;
				} else {
					return false;
				}
			}
		}
		
		private void salvar() {
			
			
			if(txtNomeCidade.Text.Equals("NÃO ENCONTRADO") || txtNomeCidade.Text.Equals("")) {
				MessageBox.Show("Nenhuma cidade foi selecionada para o endereço !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if(txtCodigo.Text.Equals("")) {
				MessageBox.Show("Favor informar um código para o endereço !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if(!disponivel(txtCodigo.Text) && this.pessoa > 0) {
				MessageBox.Show("Cliente/Fornecedor já possui um endereço com esse código !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if(txtRua.Text.Equals("") || txtBairro.Text.Equals("")) {
				MessageBox.Show("Bairro/Rua não pode ser em branco !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				endereco.codigo = txtCodigo.Text;
				endereco.cidade = int.Parse(txtCidade.Text);
				endereco.rua = txtRua.Text;
				endereco.bairro = txtBairro.Text;
				
				Resultado res = new Resultado(false, "Não enviado !");
				
				if(this.pessoa == 0) {
					Comando com = new Comando("UPDATE endereco SET rua = @rua, bairro = @bairro, cidade = @cidade WHERE codigo = @codigo AND pessoa = @pessoa");
					com.addParametro("@rua", endereco.rua);
					com.addParametro("@bairro", endereco.bairro);
					com.addParametro("@cidade", endereco.cidade);
					com.addParametro("@codigo", endereco.codigo);
					com.addParametro("@pessoa", endereco.pessoa);
					res = com.executar();
				} else {
					res = eDao.inserir(endereco);
				}
				
				if(!(res.condicao) && res.mensagem.ToLower().Contains("duplicate")) {
					MessageBox.Show("Cliente já possuí um endereço com esse código !", "Já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else if(!(res.condicao)) {
					MessageBox.Show("Erro ao salvar : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} else {
					this.Close();
				}

			}
		}
		
		void maskNumber(object sender, EventArgs e) {
			Ferramentas.maskNumber(txtCidade);
		}
		
		void salvarClique(object sender, EventArgs e) {
			salvar();
		}
		
		void cancelarClique(object sender, EventArgs e) {
			this.Close();
		}
		
		
	}
}
