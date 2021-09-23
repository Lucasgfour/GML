
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using Newtonsoft.Json;

namespace GM.View.relatorio {
	public partial class GRGrafico : Form {
		
		private DataTable dados;
		private String titulo;
		
		public GRGrafico(DataTable dados, String titulo) {
			this.titulo = titulo;
			this.dados = dados;
			InitializeComponent();
		}
		
		private Resultado ToInfo() {
			Resultado saida = new Resultado(false, "Não gerado");
			
			LinkedList<String> rotulos = new LinkedList<String>();
			LinkedList<String> labData = new LinkedList<String>();
			LinkedList<LinkedList<int>> data = new LinkedList<LinkedList<int>>();
			
			if(dados.Columns.Count < 2 || dados.Rows.Count == 0) {
				saida = new Resultado(true, "Informações insuficientes para gerar um relatório.");
			} else {
				try {
					int colunas = dados.Columns.Count - 1;
					for (int i = 1; i <= colunas; i++) {
						LinkedList<int> lin = new LinkedList<int>();
						labData.AddLast(dados.Columns[i].ColumnName);
						foreach (DataRow linha in dados.Rows) {
							lin.AddLast(int.Parse(linha[i].ToString()));
						}
						data.AddLast(lin);
					}
					
					foreach (DataRow linha in dados.Rows) {
						rotulos.AddLast(linha[0].ToString());
					}
					
					GraficoDados gd = new GraficoDados();
					gd.titulo = titulo;
					gd.labData = labData;
					gd.tipo = getTipo();
					gd.labels = rotulos;
					gd.dados = data;
					
					saida = new Resultado(true, "OK", JsonConvert.SerializeObject(gd));
					
				} catch (Exception eGerar) {
					saida = new Resultado(false, "Erro ao gerar gráfico : " + eGerar.Message);
				}
			}
			
			return saida;
		}
		
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				cbxTipo.SelectedIndex = 0;
			}
		}
		
		void gerar(object sender, EventArgs e) {
			Resultado sd = ToInfo();
			if(!sd.condicao) {
				MessageBox.Show(sd.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				String pagina = File.ReadAllText(Application.StartupPath + "\\Relatorio\\Chart\\Modelo.html");
				
				pagina = pagina.Replace("@titulo", titulo);
				pagina = pagina.Replace("@dados", sd.resultado.ToString());
				
				try {
					String nome = "Relatorio_Grafico_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".html";
					File.WriteAllText(Application.StartupPath + "\\Relatorio\\Chart\\" + nome, pagina, System.Text.Encoding.UTF8);
					
					Process.Start(Application.StartupPath + "\\Relatorio\\Chart\\" + nome);
				} catch (Exception eSalvar) {
					MessageBox.Show("Erro ao salvar arquivo : " + eSalvar.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		private String getTipo() {
			if(cbxTipo.SelectedIndex == 0) {
				return "line";
			} else if(cbxTipo.SelectedIndex == 1) {
				return "bar";
			} else if(cbxTipo.SelectedIndex == 3) {
				return "radar";
			} else {
				return "pie";
			}
		}
	}
	
	public class GraficoDados {
		
		public String titulo {get; set;}
		public String tipo {get; set;}
		public LinkedList<String> labels {get; set;}
		public LinkedList<String> labData {get; set;}
		public LinkedList<LinkedList<int>> dados {get; set;}
		
	}
}
