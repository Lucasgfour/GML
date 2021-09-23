
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GM.Controller;

namespace GM.Model {
	public static class Atende {
		
		// =======================================================================================================
		// = Classe dedicada a manipular os dados para "faturamento" e movimentação de pedidos, compras e estoque
		// =======================================================================================================
		
		
		// ===== Função responsável por "Faturar" os pedidos de compra =================================
		public static Resultado compra(Compra compra, LinkedList<Contas> parcelas) {
			Resultado bscItens = new ObjectDao<Compra_item>().listar("SELECT * FROM compra_item WHERE compra = " + compra.codigo.ToString());
			if(!bscItens.condicao) {
				return new Resultado(false, "Não foi localizado itens para compra selecionada !");
			} else {
				LinkedList<Compra_item> itens = bscItens.converter<LinkedList<Compra_item>>();
				String mensagem = "=== Atendimento de Compra ===" + Environment.NewLine;
				mensagem = mensagem + createEstoque(itens, compra) + Environment.NewLine;
				mensagem = mensagem + createParcela(parcelas) + Environment.NewLine;
				
				compra.atendido = 1;
				Resultado resAt = new ObjectDao<Compra>().alterar(compra);
				mensagem = mensagem + "= Situação atendimento : " + resAt.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + resAt.mensagem;
				
				return new Resultado(true, mensagem);
			}
		}
		
		// ===== Função responsável por "Faturar" os pedidos de cenda =================================
		public static Resultado venda(Venda venda, LinkedList<Contas> parcelas) {
			// Busca os dados
			Resultado bscItens = new ObjectDao<Venda_Produto>().listar("SELECT * FROM venda_produto WHERE pedido = " + venda.codigo.ToString());
			Resultado valiEstoque = validaEstoque(venda.codigo);
			
			// Conf. busca dados
			if(!bscItens.condicao) { 
				return new Resultado(false, "Não foi localizado itens para venda selecionada !");
			} else if(!valiEstoque.condicao) {
				return valiEstoque;
			} else {
				LinkedList<Venda_Produto> itens = bscItens.converter<LinkedList<Venda_Produto>>();
				String mensagem = "=== Atendimento de Venda ===" + Environment.NewLine;
				mensagem = mensagem + saidaEstoque(itens, venda) + Environment.NewLine; // Faz a saída no estoque dos produtos da venda
				mensagem = mensagem + createParcela(parcelas) + Environment.NewLine; // Faz a criação das parcelas na Tabela Contas
				
				venda.atendido = 1;
				Resultado resAt = new ObjectDao<Venda>().alterar(venda);
				mensagem = mensagem + "= Situação atendimento : " + resAt.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + resAt.mensagem;
				
				return new Resultado(true, mensagem);
			}
		}
		
		
		// ===== Função responsável dar entrada no estoque =================================
		private static String createEstoque(LinkedList<Compra_item> itens, Compra cp) {
			String saida = "= Entrada no estoque =" + Environment.NewLine;
			ObjectDao<Estoque> eDao = new ObjectDao<Estoque>();
			foreach (Compra_item itm in itens) {
				Estoque a = new Estoque();
				a.dtmov = DateTime.Today;
				a.produto = itm.produto;
				a.quantidade = itm.quantidade;
				a.refe_nome = "Compra";
				a.refe_cod = cp.codigo;
				a.sede = cp.sede;
				a.tipo = 1;
				Resultado res = eDao.inserir(a);
				saida = saida + "= " + res.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + res.mensagem + Environment.NewLine;
			}
			return saida;
		}
		
		// ===== Função responsável dar saída no estoque =================================
		private static String saidaEstoque(LinkedList<Venda_Produto> itens, Venda cp) {
			String saida = "= Saída no estoque =" + Environment.NewLine;
			ObjectDao<Estoque> eDao = new ObjectDao<Estoque>();
			foreach (Venda_Produto itm in itens) {
				Estoque a = new Estoque();
				a.dtmov = DateTime.Today;
				a.produto = itm.produto;
				if(itm.quantidade > 0) {
					a.quantidade = itm.quantidade * -1;
				} else {
					a.quantidade = itm.quantidade;	
				}
				a.refe_nome = "Venda";
				a.refe_cod = cp.codigo;
				a.sede = cp.sede;
				a.tipo = 0;
				Resultado res = eDao.inserir(a);
				saida = saida + "= " + res.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + res.mensagem + Environment.NewLine;
			}
			return saida;
		}
		
		// ===== Função responsável por verificar se há estoque disponivel =================================
		public static Resultado validaEstoque(int codigoVenda) {
			Resultado resBsc = new ObjectDao<vendaestoque>().listar("SELECT * FROM vendaestoque WHERE venda = " + codigoVenda.ToString());
			bool situ = true;
			String mensagem = "== Situação estoque ==" + Environment.NewLine;
			if(!resBsc.condicao) {
				return new Resultado(false, "Não foi possível validar estoque. Detalhes : " + resBsc.mensagem);
			} else {
				foreach (vendaestoque ve in resBsc.converter<LinkedList<vendaestoque>>()) {
					if(ve.solicitada > ve.disponivel) { // Caso SIM
						mensagem = mensagem + ve.produto + Environment.NewLine + " - Solicitado : " + ve.solicitada.ToString("n3") + Environment.NewLine + "  - Disponivel : " + ve.disponivel.ToString("n3") + Environment.NewLine + " Situação : Estoque Insuficiente" + Environment.NewLine;
						situ = false;
					} else { // Caso NÃO
						mensagem = mensagem + ve.produto + Environment.NewLine + " - Solicitado : " + ve.solicitada.ToString("n3") + Environment.NewLine + "  - Disponivel : " + ve.disponivel.ToString("n3") + Environment.NewLine + " Situação : Estoque OK" + Environment.NewLine;
					}
				}
				return new Resultado(situ, mensagem);
			}
		}
		
		// ===== Função responsável por criar as parcelas na tabela contas =================================
		public static String createParcela(LinkedList<Contas> parcelas) {
			String saida = "= Entrada das Parcelas =" + Environment.NewLine;
			ObjectDao<Contas> cDao = new ObjectDao<Contas>();
			
			foreach (Contas cnt in parcelas) {
				Resultado res = cDao.inserir(cnt);
				saida = saida + "= " + res.condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + " - " + res.mensagem + Environment.NewLine;
				
				// ==== Caso o vencimento seja para Hoje, o sistema pergunta se já desejar dar baixa na parcela ====
				if(res.condicao && cnt.vencimento == DateTime.Today) {
					if(MessageBox.Show("Parcela " + cnt.sequencia + " está com vencimento para hoje(" + cnt.vencimento.ToString("dd/MM/yyyy") + "), deseja marcar como recebido ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
						
						Comando com = new Comando("SELECT codigo FROM contas WHERE sequencia = @parcela AND refe_nome = @rnome AND refe_cod = @rcod");
						com.addParametro("@parcela", cnt.sequencia);
						com.addParametro("@rnome", cnt.refe_nome);
						com.addParametro("@rcod", cnt.refe_cod);
						
						Resultado resBsc = com.consultarValor();
						if(resBsc.condicao) {
							Movi_Contas mc = new Movi_Contas();
							mc.conta = resBsc.converter<int>();
							mc.descricao = "liquidação";
							mc.dtmovimento = DateTime.Today;
							if(cnt.valor > 0) {
								mc.valor = cnt.valor * -1;
							} else {
								mc.valor = cnt.valor;
							}	
							saida = saida + "= Baixa : " + new ObjectDao<Movi_Contas>().inserir(mc).condicao.ToString().Replace("True", "OK").Replace("False", "Fora") + Environment.NewLine;;
						} else {
							saida = saida + "= Erro na baixa : " + resBsc.mensagem + Environment.NewLine;;
						}
						
						
					}
				}
			}
			return saida;
		}
		
	}
}
