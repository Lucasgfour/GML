
using System;

namespace GM.Controller {
	public class Produto {
		
		public int codigo {get; set;}
		public String cod_cliente {get; set;}
		public String descricao {get; set;}
		public int familia {get; set;}
		public String unidade {get; set;}
		public String cod_barra {get; set;}
		public decimal preco {get; set;}
		public int situacao {get; set;} // 0 - Suspenso / 1 - Ativo
		
	}
}
