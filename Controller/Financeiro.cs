
using System;
using System.Collections.Generic;
using System.Linq;

namespace GM.Controller {
	public static class Financeiro {
		
		public static LinkedList<Contas> gerarParcela(decimal total, DateTime emissao, int tipo, int sede, int pessoa, Condicao condicao, String refe_nome, int refe_cod) {
			
			LinkedList<Contas> saida = new LinkedList<Contas>();
			LinkedList<int> condicoes = condicao.getCondicao();
			
			decimal valorParcela = decimal.Parse(Math.Round(total / condicoes.Count, 2).ToString());
			decimal valorDiferenca = total - valorParcela * condicoes.Count;    
			
			for (int i = 0; i < condicoes.Count; i++) {
			
			    //Calculo dos valores;
			    int parcela = (i + 1);
			    decimal valor = !(i + 1 == condicoes.Count) ? valorParcela : (valorParcela + valorDiferenca);
			    int meses = int.Parse(((condicoes.ElementAt(i) / 30)).ToString().Split(new Char[] { ',' })[0]);
				int dias = condicoes.ElementAt(i) - (meses * 30);
			    
				DateTime dataVencimento = emissao.AddMonths(meses).AddDays(dias);
			    
			    Contas ct = new Contas(emissao, dataVencimento, tipo, sede, valor, parcela, pessoa, refe_nome, refe_cod);
			    saida.AddLast(ct);
			}
			
			return saida;
			
		}
		
		public static String parcelaToString(LinkedList<Contas> parcelas) {
			String saida = " == Parcelas : " + Environment.NewLine;
			decimal total = 0;
			foreach (Contas dp in parcelas) {
				saida = saida + "N° Parcela : " + dp.sequencia.ToString().PadLeft(2, '0') + Environment.NewLine;
				saida = saida + "Valor (R$) : " + dp.valor.ToString() + Environment.NewLine;
				saida = saida + "Vencimento : " + dp.vencimento.ToString("dd/MM/yyyy") + Environment.NewLine;
				saida = saida + "=" + Environment.NewLine;
				total += dp.valor;
			}
			return (saida + " Total (R$) : " + total.ToString());
		}
		
	}
}
