
using System;
using System.Windows.Forms;
using GM.View.caixa;

namespace GM.Controller {
	public class Caixa {
		
		public int codigo {get; set;}
		public DateTime dtcaixa {get; set;}
		public String descricao {get; set;}
		public int tipo {get; set;} // 0 - Débito / 1 - Crédito
		public float valor {get; set;}
		
		public int sede {get; set;}
		
		public String refe_nome {get; set;}
		public String refe_cod {get; set;}
		
		public zMVCaixa ToMov(float saldo, bool sim) {
			zMVCaixa mv = new zMVCaixa(this, saldo, sim);
			mv.Dock = DockStyle.Top;
			return mv;
		}
		
	}
}
