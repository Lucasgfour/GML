
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.produto {
	public partial class CDProduto : Form {
		
		public LinkedList<Familia> familias;
		public Produto produto = new Produto();
		public ObjectDao<Produto> pDao = new ObjectDao<Produto>();
		
		public CDProduto() {
			InitializeComponent();
		}
		
		public CDProduto(Produto p) {
			this.produto = p;
			InitializeComponent();
		}
		
		void Arranque(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				Resultado res = new ObjectDao<Familia>().listar();
				if(res.condicao) {
					familias = res.converter<LinkedList<Familia>>();
					foreach (Familia f in familias) {
						String itm = f.codigo.ToString() + " - " + f.nome;
						cbxFamilia.Items.Add(itm);
						if(f.codigo == produto.familia) {
							cbxFamilia.Text = itm;
						}
					}
					
					if(produto.codigo > 0) {
						txtCodigo.Text = produto.cod_cliente;
						txtUnidade.Text = produto.unidade;
						txtDescricao.Text = produto.descricao;
						txtValor.Text = produto.preco.ToString().Replace(".", ",");
						txtCodBarra.Text = produto.cod_barra;
						cbxSituacao.SelectedIndex = produto.situacao;
					} else {
						cbxSituacao.SelectedIndex = 1;
						cbxFamilia.SelectedIndex = 0;
					}
				} else {
					MessageBox.Show("Não foi possível localizar as Famílias de produtos, segue detalhes : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		private void salvar() {
			if(txtCodigo.Text.Equals("") || txtDescricao.Text.Equals("") || txtUnidade.Text.Equals("") || txtValor.Text.Equals("")) {
				MessageBox.Show("Favor preencher todos os campos corretamente.", "Campo em branco.",MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				try {
					produto.cod_cliente = txtCodigo.Text;
					produto.descricao = txtDescricao.Text;
					produto.unidade = txtUnidade.Text;
					produto.preco = decimal.Parse(txtValor.Text);
					produto.situacao = cbxSituacao.SelectedIndex;
					produto.familia = familias.ElementAt(cbxFamilia.SelectedIndex).codigo;
					produto.cod_barra = txtCodBarra.Text;
					
					Resultado res = new Resultado(false, "Não executado");
					if(produto.codigo > 0) {
						res = pDao.alterar(produto);
					} else {
						res = pDao.inserir(produto);
					}
					
					MessageBox.Show(res.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if(res.condicao && produto.codigo == 0) {
						if(MessageBox.Show("Deseja adicionar mais produtos ?", "Adicionado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
							txtCodigo.Text = "";
							txtDescricao.Text = "";	
							txtValor.Text = "";
							txtCodBarra.Text = "";
							txtDescricao.Focus();
						} else {
							this.Close();
						}
					} else if(res.condicao) {
						this.Close();
					}
				} catch(Exception e) {
					MessageBox.Show("Erro na conversão dos valores : " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
				
			}
		}
		
		void salvarClique(object sender, EventArgs e) {
			salvar();
		}
		
		void pressEnter(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				salvar();
			}
		}
		
		void sairClique(object sender, EventArgs e) {
			this.Close();
		}
	}
}
