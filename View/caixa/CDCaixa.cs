
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.caixa {
	public partial class CDCaixa : Form {
		
		private ObjectDao<Sede> sDao = new ObjectDao<Sede>();
		private ObjectDao<Caixa> cDao = new ObjectDao<Caixa>();
		private LinkedList<Sede> sedes;
		
		public CDCaixa() {
			InitializeComponent();
		}
		
		void Arranque(object sender, EventArgs e) {
			Resultado itela = Ferramentas.infoTela(this.Name);
			if(!itela.condicao) {
				this.Close();
			} else {
				Resultado res = sDao.listar();
				if(!res.condicao) {
					MessageBox.Show("Erro ao buscar sede(s) : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
				} else {
					sedes = res.converter<LinkedList<Sede>>();
					foreach (Sede sd in sedes) {
						cbxSede.Items.Add(sd.nome);
					}
					cbxSede.SelectedIndex = 0;
					
					if(Ferramentas.sessao.permissao < 5) {
						cbxTipo.Items.Clear();
						cbxTipo.Items.Add("Crédito");
					}
					cbxTipo.SelectedIndex = 0;
				}
			}
		}
		
		void maskMoney(object sender, EventArgs e) {
			Ferramentas.maskMoney(txtValor);
		}
		
		void maskData(object sender, EventArgs e) {
			Ferramentas.maskData(txtData);
		}
		
		private void salvar() {
			if(txtValor.Text.Equals("")) {
				MessageBox.Show("Favor informar o valor da movimentação !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtValor.Focus();
			} else if(float.Parse(txtValor.Text) == 0) {
				MessageBox.Show("Valor deve ser superior a 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtValor.Focus();
			} else {
				try {
					Caixa cx = new Caixa();
					cx.descricao = txtDescricao.Text;
					cx.dtcaixa = DateTime.Parse(txtData.Text);
					cx.sede = sedes.ElementAt(cbxSede.SelectedIndex).codigo;
					if(cbxTipo.Text.Equals("Crédito")) {
						cx.tipo = 1;	
					} else {
						cx.tipo = 0;	
					}
					
					cx.valor = float.Parse(txtValor.Text);
					cx.refe_nome = "MANUAL";
					cx.refe_cod = "0";
					
					Resultado sv = cDao.inserir(cx);
					MessageBox.Show(sv.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if(sv.condicao) {
						txtDescricao.Text = "";
						txtValor.Text = "";
						txtDescricao.Focus();
					}
				} catch (Exception) {
					MessageBox.Show("Um ou mais campos foram preenchidos incorretamente !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
		
		void pressEnter(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				salvar();
			}
		}
		
		void btnSalvarClique(object sender, EventArgs e) {
			salvar();
		}
		
		void btnSairClique(object sender, EventArgs e) {
			this.Close();
		}
		
		
	}
}
