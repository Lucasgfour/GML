
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.contas {
	public partial class CSCredito : Form {
		
		private ObjectDao<Pessoa> pDao = new ObjectDao<Pessoa>();
		private DataTable dados;
		private	Pessoa p;
		
		public CSCredito() {
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			
		}
			
		void duploClique(object sender, MouseEventArgs e) {
			Resultado buscaPessoa = Pesquisa.pessoa(2);
			if(buscaPessoa.condicao) {
				txtCodigo.Text = buscaPessoa.converter<Pessoa>().codigo.ToString();
				btnAbrir.PerformClick();
			}
		}
		
		void selecionarCliente(object sender, EventArgs e) {
			if(txtCodigo.Text.Equals("")) {
				MessageBox.Show("Favor informar um Cliente/Fornecedor !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				Resultado resPessoa = pDao.consultar(int.Parse(txtCodigo.Text));
				if(resPessoa.condicao) {
					p = resPessoa.converter<Pessoa>();
					txtFornecedor.Text = p.nome;
					
					listaMovimento.Items.Clear();
					
					Comando com = new Comando("SELECT * FROM Credito WHERE cod_fornecedor = @cod");
					com.addParametro("@cod", p.codigo);
					Resultado resDados = com.consultarToDataTable();
					if(!resDados.condicao) {
						MessageBox.Show(resDados.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
					} else {
						dados = resDados.converter<DataTable>();
						foreach (DataRow dt in dados.Rows) {
							ListViewItem lv = new ListViewItem();
							lv.Text = DateTime.Parse(dt[1].ToString()).ToString("dd/MM/yyyy");
							lv.SubItems.Add("R$ " + String.Format("{0:N}", decimal.Parse(dt[2].ToString())));
							lv.SubItems.Add("R$ " + String.Format("{0:N}", decimal.Parse(dt[3].ToString())));
							lv.SubItems.Add(dt[6].ToString());
							listaMovimento.Items.Add(lv);
						}
					}
					
				} else {
					MessageBox.Show(resPessoa.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		
		void maskNumber(object sender, EventArgs e) {
			Ferramentas.maskNumber(txtCodigo);
		}
		
		void duploCliqueLista(object sender, MouseEventArgs e) {
			try {
				CSConta cscon = new CSConta(int.Parse(dados.Rows[listaMovimento.FocusedItem.Index][0].ToString()));
				cscon.Show();
			} catch (Exception) { }
		}
	}
}
