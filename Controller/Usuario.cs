
using System;

namespace GM.Controller {
	public class Usuario {	
		// Atributos
		public int codigo {get; set;}
		public String usuario {get; set;}
		public String senha {private get; set;}
		public String nome {get; set;}
		public int permissao {get; set;}	
		
		public int vendedor {get; set;} 
		public int sede {get; set;}
		public String pin {get; set;}
		
	}
}
