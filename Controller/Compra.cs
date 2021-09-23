
using System;

namespace GM.Controller {
	public class Compra {
		
		public int codigo {get; set;}
		public int fornecedor {get; set;}
		public int sede {get; set;}
		public int condpagto {get; set;}
		public int atendido {get; set;} // 0 - Não / 1 - Sim
		public DateTime dtcompra {get; set;}
		public String observacao {get; set;}
		public int usuario {get; set;}
		
	}
	
	public class Compra_item {
		
		public int codigo {get; set;}
		public int compra {get; set;}
		public int produto {get; set;}
		public decimal quantidade {get; set;}
		public decimal preco {get; set;}
		
	}
}
