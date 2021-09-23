
using System;
using System.Windows.Forms;
using GM.Model;
using GM.View.caixa;
using GM.View.compra;
using GM.View.custo;
using GM.View.pessoa;
using GM.View.produto;
using GM.View.Sistema;
using GM.View.venda;

namespace GM.Controller {
	public static class Pesquisa {
		
		// ====================================================================================
		// = Objeto para padronização das telas de PESQUISA do sistema
		// ====================================================================================
		
		public static Resultado produto() {
			PQProduto pq = new PQProduto();
			if(pq.ShowDialog() == DialogResult.OK) {
				return pq.saida;
			} else {
				return new Resultado(false, "Nenhum produto foi selecionado !");
			}
		}
		
		public static Resultado cidade() {
			PQCidade pq = new PQCidade();
			if(pq.ShowDialog() == DialogResult.OK) {
				return pq.resultado;
			} else {
				return new Resultado(false, "Nenhuma cidade selecionada !");
			}
		}
		
		public static Resultado endereco(Pessoa p) {
			PQEndereco pq = new PQEndereco(p, true);
			if(pq.ShowDialog() == DialogResult.OK) {
				return new Resultado(true, "OK", pq.saida);
			} else {
				return new Resultado(false, "Nenhum endereço selecionada !");
			}
		}
		
		public static Resultado pessoa(int tipoPessoa) {
			PQPessoa pq = new PQPessoa(tipoPessoa);
			if(pq.ShowDialog() == DialogResult.OK) {
				return new Resultado(true, "OK", pq.saida);
			} else {
				return new Resultado(false, "Nenhum cliente/fornecedor selecionado !");
			}
		}
		
		public static Resultado compra() {
			PQCompra pq = new PQCompra();
			if(pq.ShowDialog() == DialogResult.OK) {
				return new Resultado(true, "OK", pq.saida);
			} else {
				return new Resultado(false, "Nenhuma compra selecionado !");
			}
		}
		
		public static Resultado venda() {
			PQVenda pq = new PQVenda();
			if(pq.ShowDialog() == DialogResult.OK) {
				return new Resultado(true, "OK", pq.saida);
			} else {
				return new Resultado(false, "Nenhuma venda selecionado !");
			}
		}
		
		public static Resultado custo() {
			PQCusto pq = new PQCusto();
			if(pq.ShowDialog() == DialogResult.OK) {
				return new Resultado(true, "OK", pq.saida);
			} else {
				return new Resultado(false, "Nenhuma compra selecionado !");
			}
		}
		
		public static Resultado custo_categoria() {
			PQCustoCategoria pq = new PQCustoCategoria();
			if(pq.ShowDialog() == DialogResult.OK) {
				return new Resultado(true, "OK", pq.saida);
			} else {
				return new Resultado(false, "Nenhuma categoria selecionado !");
			}
		}
	}
}
