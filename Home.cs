
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;
using GM.View.caixa;
using GM.View.compra;
using GM.View.condicao;
using GM.View.contas;
using GM.View.custo;
using GM.View.estoque;
using GM.View.pessoa;
using GM.View.produto;
using GM.View.relatorio;
using GM.View.Sistema;
using GM.View.venda;

namespace GM {
	public partial class Home : Form {
		public Home() {
			InitializeComponent();
		}
		
		void Arranque(object sender, EventArgs e) {
			labNomeUsuario.Text = Ferramentas.sessao.nome;
			new novaHome().Show();
		}
		
		void Sair(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}
		
		void BtnTesteClick(object sender, EventArgs e) {
			CSCaixa cx = new CSCaixa();
			cx.Show();
		}
		
		void familiaClique(object sender, EventArgs e) {
			CSFamilia csfam = new CSFamilia();
			csfam.Show();
		}
		
		void produtoClique(object sender, EventArgs e) {
			CSProduto cspro = new CSProduto();
			cspro.Show();
		}
		
		void pessoaClique(object sender, EventArgs e) {
			CDPessoa cspes = new CDPessoa();
			cspes.Show();
		}
		
		void Button1Click(object sender, EventArgs e) {
			Pessoa p = new Pessoa();
			p.codigo = 1;
			Resultado a = Pesquisa.endereco(p);
			MessageBox.Show(Newtonsoft.Json.JsonConvert.SerializeObject(a));
		}
		
		void abrirCompra(object sender, EventArgs e) {
			CSCompra cdcom = new CSCompra();
			cdcom.Show();
		}
		
		void condicaoClique(object sender, EventArgs e) {
			CSCondicao cscond = new CSCondicao();
			cscond.Show();
		}
		
		void BtnPagarClick(object sender, EventArgs e) {
			CSPagar cspag = new CSPagar(0);
			cspag.Show();
		}
		
		void openEstoque(object sender, EventArgs e) {
			CSEstoque csest = new CSEstoque();
			csest.Show();
		}
		
		void btnVenda(object sender, EventArgs e) {
			CSVenda cdven = new CSVenda();
			cdven.Show();
		}
		
		void cliqueReceber(object sender, EventArgs e) {
			CSPagar cspag = new CSPagar(1);
			cspag.Show();
		}
		
		void cliqueCustoDespesa(object sender, EventArgs e) {
			CDCusto cdcusto = new CDCusto();
			cdcusto.Show();
		}
		
		void openRelatorio(object sender, EventArgs e) {
			CSRelatorio cdrela = new CSRelatorio();
			cdrela.Show();
		}
		
		void openUsuraio(object sender, EventArgs e) {
			CTUsuario ctusr = new CTUsuario();
			ctusr.Show();
		}
		
		void openTela(object sender, EventArgs e) {
			CTModulo ctmod = new CTModulo();
			ctmod.Show();
		}
		
		void openConfiguracoes(object sender, EventArgs e) {
			CFUsuario cduser = new CFUsuario();
			cduser.Show();
		}
	}
}
