
using System;

namespace GM.Controller {

	public class Estoque {
		
		public int codigo {get; set;}
		public DateTime dtmov{get; set;}
		public int sede {get; set;}
		public int produto {get; set;}
		public decimal quantidade {get; set;}
		public int tipo {get; set;} // 0 - Saída e 1 - Entrada
		
		public String refe_nome {get; set;}
		public int refe_cod {get; set;}
		
	}
}
