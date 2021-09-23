
using System;
using System.Runtime.InteropServices;

namespace GM.Controller {
	public class Custo {
		
		public int codigo {get; set;}
		public int pessoa {get; set;}
		public int sede {get; set;}
		public int tipo {get; set;} // 0 - Custo / 1 - Despesa
		public String descricao {get; set;}
		public String observacao {get; set;}
		public decimal valor {get; set;}
		public DateTime emissao {get; set;}
		public int categoria {get; set;}
		
	}
	
	public class Custo_categoria {
		
		public int codigo {get; set;}
		public String nome {get; set;}
		
	}
}
