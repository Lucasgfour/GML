
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.contas {

	public partial class CSPagar : Form {
		
		private LinkedList<Sede> sedes;
		private DataTable dados;
		private int tipo = 0; 
		
		public CSPagar(int tipo) {
			// 0 - Pagar & 1 - Receber
			this.tipo = tipo;
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				if(tipo == 0) {
					this.Text = "Consulta contas a pagar";
				} else {
					this.Text = "Consulta contas a receber";
				}
				
				
				Resultado resSede = new ObjectDao<Sede>().listar();
				if(resSede.condicao) {
					sedes = resSede.converter<LinkedList<Sede>>();
					foreach (Sede sd in sedes) {
						cbxLoja.Items.Add(sd.nome);
					}
					cbxLoja.SelectedIndex = 0;
					cbxOrdenacao.SelectedIndex = 0;
					
					txtDtInicio.Text = DateTime.Today.AddMonths(-3).ToString("dd/MM/yyyy");
					txtDtFinal.Text = DateTime.Today.AddMonths(3).ToString("dd/MM/yyyy");
				} else {
					MessageBox.Show("Não foi encontrado nenhuma loja, detalhes: " + resSede.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
				}
			}
		}
		
		private void pesquisar() {
			if(txtDtInicio.Text.Equals("") || txtDtFinal.Text.Equals("")) {
				MessageBox.Show("Favor fornecer o intervalo de datas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {		
				String SQL = "SELECT * FROM " + getTipo() + " WHERE";
				if(!chkSaldo.Checked) {
					SQL = SQL + " saldo != 0 AND";
				}
				SQL = SQL + " sede = @sede AND vencimento BETWEEN @dti AND @dtf ORDER BY " + cbxOrdenacao.Text.ToLower() + " ASC";
				
				Comando comando = new Comando(SQL);
				comando.addParametro("@sede", sedes.ElementAt(cbxLoja.SelectedIndex).codigo);
				comando.addParametro("@dti", DateTime.Parse(txtDtInicio.Text));
				comando.addParametro("@dtf", DateTime.Parse(txtDtFinal.Text));
				
				Resultado resDados = comando.consultarToDataTable();
				listaContas.Items.Clear();
				if(resDados.condicao) {
					this.dados = resDados.converter<DataTable>();
					foreach (DataRow linha in dados.Rows) {
						ListViewItem itm = new ListViewItem();
						itm.Text = linha[0].ToString().PadLeft(6, '0');
						itm.SubItems.Add(DateTime.Parse(linha[1].ToString()).ToString("dd/MM/yyyy"));
						itm.SubItems.Add(DateTime.Parse(linha[2].ToString()).ToString("dd/MM/yyyy"));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", decimal.Parse(linha[3].ToString())));
						itm.SubItems.Add("R$ " + String.Format("{0:N}", decimal.Parse(linha[4].ToString())));
						itm.SubItems.Add(linha[5].ToString());
						itm.SubItems.Add(linha[6].ToString());
						
						if(DateTime.Parse(linha[2].ToString()) < DateTime.Today && decimal.Parse(linha[4].ToString()) > 0) {
							itm.BackColor = Color.Salmon;
						} else if(DateTime.Parse(linha[2].ToString()) == DateTime.Today && decimal.Parse(linha[4].ToString()) > 0) {
							itm.BackColor = Color.Yellow;
						} else if(decimal.Parse(linha[4].ToString()) == 0) {
							itm.BackColor = Color.LightGreen;
						}
						
						listaContas.Items.Add(itm);
					}
				}
			}
			
			
		}
		
		
		void maskData(object sender, EventArgs e) {
			Ferramentas.maskData((TextBox) sender);
		}
		
		void maskDataLeave(object sender, EventArgs e) {
			try {
				DateTime.Parse(((TextBox) sender).Text);
			} catch (Exception) {
				((TextBox) sender).Text = "";
			}
		}
		
		void cliquePesquisar(object sender, EventArgs e) {
			pesquisar();
		}
		
		void duploCliqueLista(object sender, MouseEventArgs e) {
			try {
				CSConta cscon = new CSConta(int.Parse(listaContas.FocusedItem.Text));
				cscon.Show();
			} catch (Exception) { }
		}
		
		private String getTipo() {
			if(tipo == 0) {
				return "ContasPagar";
			} else {
				return "ContasReceber";
			}
		}
	}
}
