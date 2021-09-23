
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.caixa {

	public partial class CSCaixa : Form {
		
		private ObjectDao<Sede> sDao = new ObjectDao<Sede>();
		private LinkedList<Sede> sedes;
		
		private LinkedList<Caixa> caixas;
		
		public CSCaixa() {
			InitializeComponent();
		}
		
		public void pesquisar() {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				Comando com = new Comando("SELECT * FROM caixa WHERE sede = @sede AND dtcaixa BETWEEN @datai AND @dataf ORDER BY dtcaixa ASC");
				com.addParametro("@sede", sedes.ElementAt(cbxSede.SelectedIndex).codigo);
				com.addParametro("@datai", txtDatai.Value);
				com.addParametro("@dataf", txtDataf.Value);
				
				Resultado res = com.listar<Caixa>();
				pnlMovimentacoes.Controls.Clear();
				if(!res.condicao) {
					MessageBox.Show("Nenhum caixa localizado, Detalhes : " + res.mensagem, "Não localizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					caixas = res.converter<LinkedList<Caixa>>();
					listar();
				}
			}
		}
		
		public void listar() {
	        decimal saldo = getCredito() - getDebito();
			DateTime dia = caixas.ElementAt(0).dtcaixa;
			addDia(dia);
			bool sim = true;
			foreach (Caixa cx in caixas) {
				if(cx.dtcaixa != dia) {
					fecharDia(saldo);
					addDia(cx.dtcaixa);
					dia = cx.dtcaixa;
					sim = true;
				}
				if(cx.tipo == 0) { saldo = saldo - cx.valor; }
				else if(cx.tipo == 1) { saldo = saldo + cx.valor; }
				zMVCaixa mv = cx.ToMov(saldo, sim);
				pnlMovimentacoes.Controls.Add(mv);
				mv.BringToFront();
				sim = !sim;
			}
			fecharDia(saldo);
		}
		
		public decimal getCredito() {
			Comando com = new Comando("SELECT valor FROM caixa WHERE sede = @sede AND tipo = 1 AND dtcaixa < @dt");
			com.addParametro("@sede", sedes.ElementAt(cbxSede.SelectedIndex).codigo);
			com.addParametro("@dt", txtDatai.Value);
			Resultado res = com.consultarToDataTable();
			if(!res.condicao) {
				return 0;
			} else {
				return decimal.Parse(((DataTable)res.resultado).Rows[0][0].ToString());
			}
		}
		
		public decimal getDebito() {
			Comando com = new Comando("SELECT valor FROM caixa WHERE sede = @sede AND tipo = 0 AND dtcaixa < @dt");
			com.addParametro("@sede", sedes.ElementAt(cbxSede.SelectedIndex).codigo);
			com.addParametro("@dt", txtDatai.Value);
			Resultado res = com.consultarToDataTable();
			if(!res.condicao) {
				return 0;
			} else {
				return decimal.Parse(((DataTable)res.resultado).Rows[0][0].ToString());
			}
		}
		
		public void addDia(DateTime dt) {
			Label a = new Label();
			a.Text = dt.ToString("dd/MM/yyyy");
			a.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			a.ForeColor = Color.White;
			a.BackColor = Color.Black;
			a.Dock = DockStyle.Top;
			pnlMovimentacoes.Controls.Add(a);
			a.BringToFront();
		}
		
		public void fecharDia(decimal saldo) {
			Label a = new Label();
			a.Text = "SALDO DO DIA : ";
			if(saldo < 0) {
				a.Text = a.Text + "R$ " + String.Format("{0:N}", saldo);	
				a.BackColor = Color.FromArgb(245, 216, 216);
			} else {
				a.Text = a.Text + "R$ " + String.Format("{0:N}", saldo);	
				a.BackColor = Color.FromArgb(211, 243, 214);
			}			
			a.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			a.Dock = DockStyle.Top;
			pnlMovimentacoes.Controls.Add(a);
			a.BringToFront();
		}
		
		void Arranque(object sender, EventArgs e) {
			Resultado res = sDao.listar();
			if(!res.condicao) {
				MessageBox.Show("Nenhuma empresa localizada, favor verificar : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			} else {
				sedes = res.converter<LinkedList<Sede>>();
				foreach (Sede sd in sedes) {
					cbxSede.Items.Add(sd.nome);
				}
				cbxSede.SelectedIndex = 0;
			}
		}
		
		void btnPesquisarClique(object sender, EventArgs e) {
			pesquisar();
		}
		
		void AdicionarClique(object sender, EventArgs e) {
			CDCaixa cd = new CDCaixa();
			cd.Show();
		}
	}
}
