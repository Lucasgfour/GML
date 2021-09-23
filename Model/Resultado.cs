using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GM.Model {
    public class Resultado {
		
		// Objeto padrão para comunicação entre Funções

        public bool condicao { get; set; } 
        public String mensagem { get; set; }
        public Object resultado { get; set; }

        public Resultado() {
            this.condicao = false;
            this.mensagem = "NÃO INFORMADO";
        }

        public Resultado(bool condicao, String mensagem) {
            this.condicao = condicao;
            this.mensagem = mensagem;
        }

        public Resultado(bool condicao, String mensagem, object resultado) {
            this.condicao = condicao;
            this.mensagem = mensagem;
            this.resultado = resultado;
        }
        
        public T converter<T>() {
        	return (T) this.resultado;
        }
    }

    public class Periodo {
        public DateTime inicio { get; set; }
        public DateTime final { get; set; }
    }
}
