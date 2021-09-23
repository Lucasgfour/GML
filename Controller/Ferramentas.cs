using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using GM.View.compra;
using GM.View.contas;
using GM.View.custo;
using GM.View.venda;

namespace GM.Controller {
    public static class Ferramentas {
		
		public static Usuario sessao {get; set;}
		
		// Abre tela de Consulta na Referência do registro
		public static void openReferencia(String refe_nome, int refe_codigo) {
			if(refe_nome.Equals("Compra")) {
				CSCompra cscom = new CSCompra(refe_codigo);
				cscom.Show();
			} else if(refe_nome.Equals("Venda")) {
				CSVenda csven = new CSVenda(refe_codigo);
				csven.Show();
			} else if(refe_nome.Equals("Custo") || refe_nome.Equals("Despesa")) {
				CSCusto cscus = new CSCusto(refe_codigo);
				cscus.Show();
			} else if(refe_nome.Equals("Conta")) {
				CSConta cscon = new CSConta(refe_codigo);
				cscon.Show();
			} else {
				MessageBox.Show("Referência não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		// Conversão de STRING para MD5 (Senha)
        public static String ToMD5(String input) {
            MD5 md5Hask = MD5.Create();
            byte[] data = md5Hask.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append(data[i].ToString("X2"));
            }
            return sBuilder.ToString();
        }
		
		
		// Obter informações sobre a tela para validar se o usuário possui permissão para acesso
		public static Resultado infoTela(String tela) {
			ObjectDao<Tela> tDao = new ObjectDao<Tela>();
			Resultado res = tDao.consultar("SELECT * FROM tela WHERE nome = '" + tela + "'");
			if(!res.condicao) {
				MessageBox.Show("Tela não encontrada (" + tela + ") ! Detalhes : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return new Resultado(false, "Tela não encontrada");
			} else {
				Tela t = (Tela) res.resultado;
				if(t.disponivel == 0) {
					MessageBox.Show("Tela indisponível para essa instalação, contate o administrador do sistema para solicitar acesso !", "Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return new Resultado(false, "Tela indisponível para essa instalação", t);
				} else if(sessao.permissao < t.nivel) {
					MessageBox.Show("Seu usuário não possuí permissão para acessar esta tela !", "Sem permissão !", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return new Resultado(false, "Sem permissão !", t);
				} else {
					return new Resultado(true, "Permissão concedida !", t);
				}
			}
		}
		
		// Obter cidade atraves de código IBGE
		public static Resultado getCidade(int cod) {
			Resultado res = new ObjectDao<Cidade>().consultar(cod);
			return res;
		}
		
		
		// ============================== MASCARAS DE CAMPO ============================================
		
		// Mascára TextBox para dinheiro
		public static void maskMoney(TextBox txt) {
			maskMoney(txt, 2);
		}
		
		// Mascára TextBox para dinheiro com parametrizao de casas
		public static void maskMoney(TextBox txt, int casa) {
			String vlr = txt.Text;
			String vlrCompara = "";
			int posicao = txt.SelectionStart;
			int posVirg = 0;
			
			for (int i = 0; i < vlr.Length; i++) {
				String letra = vlr.ElementAt(i).ToString();
				String[] permitido = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "," };
				if(letra.Equals(",")) { posVirg = i; }
				if(permitido.Contains(letra) && (posVirg == 0 || i <= (posVirg + casa))) { vlrCompara = vlrCompara + letra; }
			}
			
			if(!vlrCompara.Equals(vlr)) {
				txt.Text = vlrCompara;				
				if(vlrCompara.Length < posicao) {
					txt.SelectionStart = vlrCompara.Length;
				} else if(posicao > 0) {
					txt.SelectionStart = posicao - 1;
				}
			}
			
		}
		
		// Mascára TextBox para número inteiro
		public static void maskNumber(TextBox txt) {
			String vlr = txt.Text;
			String vlrCompara = "";
			int posicao = txt.SelectionStart;
			
			for (int i = 0; i < vlr.Length; i++) {
				String letra = vlr.ElementAt(i).ToString();
				String[] permitido = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
				if(permitido.Contains(letra)) { vlrCompara = vlrCompara + letra; }
			}
			
			if(!vlrCompara.Equals(vlr)) {
				txt.Text = vlrCompara;				
				if(vlrCompara.Length < posicao) {
					txt.SelectionStart = vlrCompara.Length;
				} else if(posicao > 0) {
					txt.SelectionStart = posicao - 1;
				}
			}
		}
		
		// Mascára TextBox para Data
		public static void maskData(TextBox txt) {
			String vlr = txt.Text;
			String vlrCompara = "";
			int posicao = txt.SelectionStart;
			
			for (int i = 0; i < vlr.Length; i++) {
				String letra = vlr.ElementAt(i).ToString();
				String[] permitido = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "/" };
				
				// Validação das /
				if((i == 2 || i == 5) && !(letra.Equals("/"))) { vlrCompara = vlrCompara + "/"; posicao += 2; }
				else if(!(i == 2 || i == 5) && letra.Equals("/")) { letra = ""; }
				if(permitido.Contains(letra)) { vlrCompara = vlrCompara + letra; }
			}
			
			vlrCompara = vlrCompara.Replace("//", "/");
			
			if(!vlrCompara.Equals(vlr)) {
				txt.Text = vlrCompara;				
				if(vlrCompara.Length < posicao) {
					txt.SelectionStart = vlrCompara.Length;
				} else if(posicao > 0) {
					txt.SelectionStart = posicao - 1;
				}
			}
		}
		
		// Mascára TextBox para CPF
		public static void maskCPF(TextBox txt) {
			String vlr = txt.Text;
			String vlrCompara = "";
			int posicao = txt.SelectionStart;
			
			for (int i = 0; i < vlr.Length; i++) {
				String letra = vlr.ElementAt(i).ToString();
				String[] permitido = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ".", "-" };
				
				// Validação de posição dos pontos
				if((i == 3 || i == 7) && !(letra.Equals("."))) { vlrCompara = vlrCompara + "."; posicao += 2; }
				else if(!(i == 3 || i == 7) && letra.Equals(".")) { letra = ""; }
				
				if((i == 11) && !(letra.Equals("-"))) { vlrCompara = vlrCompara + "-"; posicao += 2; }
				else if(!(i == 11) && letra.Equals("-")) { letra = ""; }
				
				if(permitido.Contains(letra)) { vlrCompara = vlrCompara + letra; }
			}
			
			vlrCompara = vlrCompara.Replace("..", ".");
			vlrCompara = vlrCompara.Replace("--", "-");
			
			txt.MaxLength = 14;
			
			if(!vlrCompara.Equals(vlr)) {
				txt.Text = vlrCompara;				
				if(vlrCompara.Length < posicao) {
					txt.SelectionStart = vlrCompara.Length;
				} else if(posicao > 0) {
					txt.SelectionStart = posicao - 1;
				}
			}
		}
		
		// Mascára TextBox para CNPJ
		public static void maskCNPJ(TextBox txt) {
			String vlr = txt.Text;
			String vlrCompara = "";
			int posicao = txt.SelectionStart;
			
			for (int i = 0; i < vlr.Length; i++) {
				String letra = vlr.ElementAt(i).ToString();
				String[] permitido = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "/", ".", "-"};
				
				// Validação de posição dos pontos
				if((i == 2 || i == 6) && !(letra.Equals("."))) { vlrCompara = vlrCompara + "."; posicao += 2; }
				else if(!(i == 2 || i == 6) && letra.Equals(".")) { letra = ""; }
				
				if((i == 15) && !(letra.Equals("-"))) { vlrCompara = vlrCompara + "-"; posicao += 2; }
				else if(!(i == 15) && letra.Equals("-")) { letra = ""; }
				
				if((i == 10) && !(letra.Equals("/"))) { vlrCompara = vlrCompara + "/"; posicao += 2; }
				else if(!(i == 10) && letra.Equals("/")) { letra = ""; }
				
				if(permitido.Contains(letra)) { vlrCompara = vlrCompara + letra; }
			}
			
			vlrCompara = vlrCompara.Replace("..", ".");
			vlrCompara = vlrCompara.Replace("--", "-");
			vlrCompara = vlrCompara.Replace("//", "/");
			
			txt.MaxLength = 18;
			
			if(!vlrCompara.Equals(vlr)) {
				txt.Text = vlrCompara;				
				if(vlrCompara.Length < posicao) {
					txt.SelectionStart = vlrCompara.Length;
				} else if(posicao > 0) {
					txt.SelectionStart = posicao - 1;
				}
			}
		}
		
    }
}
