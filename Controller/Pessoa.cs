
using System;
using GM.Model;

namespace GM.Controller {
	public class Pessoa {
		
		public int codigo {get; set;}
		public String nome {get; set;}
		public String documento {get; set;}
		public String observacao {get; set;}
		public String contato {get; set;}
		public int tipo {get; set;} // 0 - Cliente / 1 - Fornecedor / 2 - Ambos
		
		public String tipoToString() {
			if(tipo == 0) {
				return "Cliente";
			} else if(tipo == 1) {
				return "Fornecedor";
			} else {
				return "Ambos";
			}
		}
	}
	
	public class Endereco {
		public String codigo {get; set;}
		public String rua {get; set;}
		public String bairro {get; set;}
		public int cidade {get; set;}
		public int pessoa {get; set;}

	}
	
	public class zEndereco : Endereco {
		public String nomeCidade {get; set;}
		
		public Endereco getEndereco() {
			Endereco saida = new Endereco();
			saida.codigo = this.codigo;
			saida.rua = this.rua;
			saida.bairro = this.bairro;
			saida.cidade = this.cidade;
			saida.pessoa = this.pessoa;
			return saida;
		}
	}

	
	public class Cidade {
		public int codigo {get; set;}
		public String nome {get; set;}
		public String uf {get; set;}
	}
}
