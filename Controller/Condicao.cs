
using System;
using System.Collections.Generic;

namespace GM.Controller {
	public class Condicao {
		
		public int codigo {get; set;}
		public String nome {get; set;}
		public int tipo {get; set;} // 0 - Compra/Venda // 1 - Compra // 2 - Venda
		public String condicao {get; set;}
		
		public LinkedList<int> getCondicao() {
			try {
				LinkedList<int> saida = new LinkedList<int>();
				String[] condicoes = this.condicao.Split(new Char[] { '/' });
				foreach (String cond in condicoes) {
					saida.AddLast(int.Parse(cond));
				}
				return saida;
			} catch (Exception) {
				return null;
			}
		}
	}
}
