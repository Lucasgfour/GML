
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using GM.Model;
using GM.View.relatorio;
using Newtonsoft.Json;

namespace GM.Controller {
	
	public class Relatorio {
		
		public int codigo {get; set;}
		public String descricao {get; set;}
		public String observacao {get; set;}
		public int permissao {get; set;}
		public String comando {get; set;}
		
	}
	
	public class Relatorio_Parametro {
		
		public int relatorio {get; set;}
		public String parametro {get; set;}
		public int tipo {get; set;} // 0 - String, 1 - Int, 2 - Decimal, 3 - Date
		
		public String tipoToString() {
			if(tipo == 0) {
				return "TEXTO";
			} else if(tipo == 1) {
				return "INTEIRO";
			} else if(tipo == 2) {
				return "DECIMAL";
			} else if(tipo == 3) {
				return "DATA";
			} else {
				return "ERRO";
			}
		}
	}
	
	public static class relatorio {
		
		public static Resultado gerarDataTable(Relatorio a) {
			Resultado saida = new Resultado(false, "Não gerado");
			Resultado resultadoParametro = new ObjectDao<Relatorio_Parametro>().listar("SELECT * FROM relatorio_parametro WHERE relatorio = " + a.codigo.ToString());
			
			LinkedList<Relatorio_Parametro> parametros = new LinkedList<Relatorio_Parametro>();
			if(resultadoParametro.condicao) {
				parametros = resultadoParametro.converter<LinkedList<Relatorio_Parametro>>();
			}
			
			Comando com = new Comando(a.comando);
			bool gerar = true;
			
			foreach (Relatorio_Parametro par in parametros) {
				DGParametro dg = new DGParametro(par);
				if(dg.ShowDialog() == DialogResult.OK) {
					try {
						Object vlr = new Object();
						
						if(par.tipo == 0) {
							vlr = dg.getValor();
						} else if(par.tipo == 1) {
							vlr = int.Parse(dg.getValor());
						} else if(par.tipo == 2) {
							vlr = decimal.Parse(dg.getValor());
						} else if(par.tipo == 3) {
							vlr = DateTime.Parse(dg.getValor());
						}
						
						com.addParametro(par.parametro, vlr);
						
					} catch (Exception epar) {
						gerar = false;
						saida = new Resultado(false, "Parâmetro '" + par.parametro + "' incorreto : " + epar.Message);
					}
				} else {
					gerar = false;
					saida = new Resultado(false, "Parâmetro '" + par.parametro + "' não informado.");
				}
			}
			
			if(gerar) {
				saida = com.consultarToDataTable();
			}
			
			return saida;
		}
		
		public static void gerarTela(Relatorio a) {
			Resultado dt = gerarDataTable(a);
			if(!dt.condicao) {
				MessageBox.Show("Erro ao gerar relatório : " + dt.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				GRTela gr = new GRTela(dt.converter<DataTable>());
				gr.Show();
			}
		}
		
		public static void gerarGrafico(Relatorio a) {
			Resultado dt = gerarDataTable(a);
			if(!dt.condicao) {
				MessageBox.Show("Erro ao gerar relatório : " + dt.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				GRGrafico gr = new GRGrafico(dt.converter<DataTable>(), a.descricao);
				gr.ShowDialog();
			}
		}
		
		public static void gerarWeb(Relatorio a) {
			Resultado dt = gerarDataTable(a);
			if(!dt.condicao) {
				MessageBox.Show("Erro ao gerar relatório : " + dt.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else if(!File.Exists(Application.StartupPath + "\\Relatorio\\Web\\Modelo.html")) {
				MessageBox.Show("Arquivo modelo de relatório WEB não encontrado, contate o administrador do sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				String pagina = File.ReadAllText(Application.StartupPath + "\\Relatorio\\Web\\Modelo.html");
				DataTable dados = dt.converter<DataTable>();
				
				String tabela = "<thead><tr>";
				foreach (DataColumn coluna in dados.Columns) {
					tabela = tabela + "<th>" + coluna.ColumnName + "</th>";
				}
				tabela = tabela + "</tr></thead><tbody>";
				
				foreach (DataRow linha in dados.Rows) {
					tabela = tabela + "<tr>";
					foreach (DataColumn coluna in dados.Columns) {
						tabela = tabela + "<td>" + linha[coluna.ColumnName].ToString() + "</td>"; 
					}
					tabela = tabela + "</tr>";
				}
				
				pagina = pagina.Replace("@titulo", a.descricao);
				pagina = pagina.Replace("@dados", tabela);
				
				try {
					String nome = "Relatorio_Codigo" + a.codigo.ToString() + "_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".html";
					File.WriteAllText(Application.StartupPath + "\\Relatorio\\Web\\" + nome, pagina, System.Text.Encoding.UTF8);
					
					Process.Start(Application.StartupPath + "\\Relatorio\\Web\\" + nome);
				} catch (Exception eSalvar) {
					MessageBox.Show("Erro ao salvar arquivo : " + eSalvar.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
			}
		}
		
		
	}
}
