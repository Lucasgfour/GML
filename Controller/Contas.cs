
using System;

namespace GM.Controller {
	
	public class Contas {
		
		public int codigo {get; set;}
		public DateTime emissao {get; set;}
		public DateTime vencimento {get; set;}
		public int tipo {get; set;} // 0 - Pagar / 1 - Receber / 3 - Crédito
		public int sede {get; set;}
		public decimal valor {get; set;}
		public int sequencia {get; set;}
		public int pessoa {get; set;}
		
		public String refe_nome {get; set;}
		public int refe_cod {get; set;}
		
		public Contas() { }

		public Contas(DateTime emissao, DateTime vencimento, int tipo, int sede, decimal valor, int sequencia, int pessoa, String refe_nome, int refe_cod) {
			this.emissao = emissao;
			this.vencimento = vencimento;
			this.tipo = tipo;
			this.sede = sede;
			this.valor = valor;
			this.sequencia = sequencia;
			this.pessoa = pessoa;
			this.refe_cod = refe_cod;
			this.refe_nome = refe_nome;
		}
	}
	
	public class Movi_Contas {
		
		public int codigo {get; set;}
		public DateTime dtmovimento {get; set;}
		public String descricao {get; set;}
		public int conta {get; set;}
		public decimal valor{get; set;}
		
	}
	
}