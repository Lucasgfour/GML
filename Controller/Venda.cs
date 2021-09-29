
using System;

namespace GM.Controller { 
	public class Venda {
		
		public int codigo {get; set;}
		public DateTime dtimplantacao {get; set;}
		public String observacao {get; set;}
		public int atendido {get; set;} // 0 - Não Atendido / 1 - Atendido
		public int usuario {get; set;}
		public int sede {get; set;}
		public int pessoa {get; set;}
		public String endereco {get; set;}
		public int pagamento {get; set;}
		
		
	}
	
	public class Venda_Produto {
		
		public int codigo {get; set;}
		public int pedido {get; set;}
		public int produto {get; set;}
		public float quantidade {get; set;}
		public float valor {get; set;}
		
	}
	
	public class vendaestoque {
		
		public int venda {get; set;}
		public String produto {get; set;}
		public float solicitada {get; set;}
		public float disponivel {get; set;}
		
	}
}
