
namespace GM.View.Sistema
{
	partial class homeMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeMenu));
			this.btnFBalcao = new System.Windows.Forms.Button();
			this.TabControle = new MaterialSkin.Controls.MaterialTabControl();
			this.TabVendaCompra = new System.Windows.Forms.TabPage();
			this.btnFCompra = new System.Windows.Forms.Button();
			this.btnFVenda = new System.Windows.Forms.Button();
			this.TabProduto = new System.Windows.Forms.TabPage();
			this.btnFFamilia = new System.Windows.Forms.Button();
			this.btnFProduto = new System.Windows.Forms.Button();
			this.btnFEstoque = new System.Windows.Forms.Button();
			this.TabFinanceiro = new System.Windows.Forms.TabPage();
			this.btnFCreditoConsulta = new System.Windows.Forms.Button();
			this.btnFCustoConsulta = new System.Windows.Forms.Button();
			this.btnFCadastroCusto = new System.Windows.Forms.Button();
			this.btnFContasReceber = new System.Windows.Forms.Button();
			this.btnFContasPagar = new System.Windows.Forms.Button();
			this.TabDiversos = new System.Windows.Forms.TabPage();
			this.btnFRelatorioProgramados = new System.Windows.Forms.Button();
			this.btnFRelatoriosConsulta = new System.Windows.Forms.Button();
			this.btnFUsuarioPermissao = new System.Windows.Forms.Button();
			this.btnFUsuarioControle = new System.Windows.Forms.Button();
			this.btnFPessoaConsulta = new System.Windows.Forms.Button();
			this.btnFCondicaoConsulta = new System.Windows.Forms.Button();
			this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
			this.bwkRelatorio = new System.ComponentModel.BackgroundWorker();
			this.btnFUsuarioConfigura = new System.Windows.Forms.Button();
			this.TabControle.SuspendLayout();
			this.TabVendaCompra.SuspendLayout();
			this.TabProduto.SuspendLayout();
			this.TabFinanceiro.SuspendLayout();
			this.TabDiversos.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnFBalcao
			// 
			this.btnFBalcao.BackColor = System.Drawing.Color.Silver;
			this.btnFBalcao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFBalcao.FlatAppearance.BorderSize = 0;
			this.btnFBalcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFBalcao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFBalcao.ForeColor = System.Drawing.Color.White;
			this.btnFBalcao.Image = ((System.Drawing.Image)(resources.GetObject("btnFBalcao.Image")));
			this.btnFBalcao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFBalcao.Location = new System.Drawing.Point(8, 6);
			this.btnFBalcao.Name = "btnFBalcao";
			this.btnFBalcao.Size = new System.Drawing.Size(137, 87);
			this.btnFBalcao.TabIndex = 1;
			this.btnFBalcao.Text = "Venda Balcão";
			this.btnFBalcao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFBalcao.UseVisualStyleBackColor = false;
			this.btnFBalcao.Click += new System.EventHandler(this.cliqueVendaBalcao);
			// 
			// TabControle
			// 
			this.TabControle.Controls.Add(this.TabVendaCompra);
			this.TabControle.Controls.Add(this.TabProduto);
			this.TabControle.Controls.Add(this.TabFinanceiro);
			this.TabControle.Controls.Add(this.TabDiversos);
			this.TabControle.Depth = 0;
			this.TabControle.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TabControle.Location = new System.Drawing.Point(0, 101);
			this.TabControle.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabControle.Name = "TabControle";
			this.TabControle.SelectedIndex = 0;
			this.TabControle.Size = new System.Drawing.Size(724, 394);
			this.TabControle.TabIndex = 2;
			// 
			// TabVendaCompra
			// 
			this.TabVendaCompra.Controls.Add(this.btnFCompra);
			this.TabVendaCompra.Controls.Add(this.btnFVenda);
			this.TabVendaCompra.Controls.Add(this.btnFBalcao);
			this.TabVendaCompra.Location = new System.Drawing.Point(4, 22);
			this.TabVendaCompra.Name = "TabVendaCompra";
			this.TabVendaCompra.Padding = new System.Windows.Forms.Padding(3);
			this.TabVendaCompra.Size = new System.Drawing.Size(716, 368);
			this.TabVendaCompra.TabIndex = 0;
			this.TabVendaCompra.Text = "Vendas e Compras";
			this.TabVendaCompra.UseVisualStyleBackColor = true;
			// 
			// btnFCompra
			// 
			this.btnFCompra.BackColor = System.Drawing.Color.Silver;
			this.btnFCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFCompra.FlatAppearance.BorderSize = 0;
			this.btnFCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFCompra.ForeColor = System.Drawing.Color.White;
			this.btnFCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnFCompra.Image")));
			this.btnFCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFCompra.Location = new System.Drawing.Point(294, 6);
			this.btnFCompra.Name = "btnFCompra";
			this.btnFCompra.Size = new System.Drawing.Size(137, 87);
			this.btnFCompra.TabIndex = 3;
			this.btnFCompra.Text = "Consulta de \r\nPedidos de Compra";
			this.btnFCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFCompra.UseVisualStyleBackColor = false;
			this.btnFCompra.Click += new System.EventHandler(this.cliqueCompraConsulta);
			// 
			// btnFVenda
			// 
			this.btnFVenda.BackColor = System.Drawing.Color.Silver;
			this.btnFVenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFVenda.FlatAppearance.BorderSize = 0;
			this.btnFVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFVenda.ForeColor = System.Drawing.Color.White;
			this.btnFVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnFVenda.Image")));
			this.btnFVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFVenda.Location = new System.Drawing.Point(151, 6);
			this.btnFVenda.Name = "btnFVenda";
			this.btnFVenda.Size = new System.Drawing.Size(137, 87);
			this.btnFVenda.TabIndex = 2;
			this.btnFVenda.Text = "Consulta de \r\nPedidos de Venda";
			this.btnFVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFVenda.UseVisualStyleBackColor = false;
			this.btnFVenda.Click += new System.EventHandler(this.cliqueVendaConsulta);
			// 
			// TabProduto
			// 
			this.TabProduto.Controls.Add(this.btnFFamilia);
			this.TabProduto.Controls.Add(this.btnFProduto);
			this.TabProduto.Controls.Add(this.btnFEstoque);
			this.TabProduto.Location = new System.Drawing.Point(4, 22);
			this.TabProduto.Name = "TabProduto";
			this.TabProduto.Padding = new System.Windows.Forms.Padding(3);
			this.TabProduto.Size = new System.Drawing.Size(716, 368);
			this.TabProduto.TabIndex = 1;
			this.TabProduto.Text = "Produtos e Estoque";
			this.TabProduto.UseVisualStyleBackColor = true;
			// 
			// btnFFamilia
			// 
			this.btnFFamilia.BackColor = System.Drawing.Color.Silver;
			this.btnFFamilia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFFamilia.FlatAppearance.BorderSize = 0;
			this.btnFFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFFamilia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFFamilia.ForeColor = System.Drawing.Color.White;
			this.btnFFamilia.Image = ((System.Drawing.Image)(resources.GetObject("btnFFamilia.Image")));
			this.btnFFamilia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFFamilia.Location = new System.Drawing.Point(294, 6);
			this.btnFFamilia.Name = "btnFFamilia";
			this.btnFFamilia.Size = new System.Drawing.Size(137, 87);
			this.btnFFamilia.TabIndex = 4;
			this.btnFFamilia.Text = "Consulta de Famílias de Produtos";
			this.btnFFamilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFFamilia.UseVisualStyleBackColor = false;
			this.btnFFamilia.Click += new System.EventHandler(this.cliqueFamiliaConsulta);
			// 
			// btnFProduto
			// 
			this.btnFProduto.BackColor = System.Drawing.Color.Silver;
			this.btnFProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFProduto.FlatAppearance.BorderSize = 0;
			this.btnFProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFProduto.ForeColor = System.Drawing.Color.White;
			this.btnFProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnFProduto.Image")));
			this.btnFProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFProduto.Location = new System.Drawing.Point(151, 6);
			this.btnFProduto.Name = "btnFProduto";
			this.btnFProduto.Size = new System.Drawing.Size(137, 87);
			this.btnFProduto.TabIndex = 3;
			this.btnFProduto.Text = "Consulta de Produtos";
			this.btnFProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFProduto.UseVisualStyleBackColor = false;
			this.btnFProduto.Click += new System.EventHandler(this.cliqueProdutoConsulta);
			// 
			// btnFEstoque
			// 
			this.btnFEstoque.BackColor = System.Drawing.Color.Silver;
			this.btnFEstoque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFEstoque.FlatAppearance.BorderSize = 0;
			this.btnFEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFEstoque.ForeColor = System.Drawing.Color.White;
			this.btnFEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnFEstoque.Image")));
			this.btnFEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFEstoque.Location = new System.Drawing.Point(8, 6);
			this.btnFEstoque.Name = "btnFEstoque";
			this.btnFEstoque.Size = new System.Drawing.Size(137, 87);
			this.btnFEstoque.TabIndex = 2;
			this.btnFEstoque.Text = "Consulta de Estoque";
			this.btnFEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFEstoque.UseVisualStyleBackColor = false;
			this.btnFEstoque.Click += new System.EventHandler(this.cliqueEstoqueConsulta);
			// 
			// TabFinanceiro
			// 
			this.TabFinanceiro.Controls.Add(this.btnFCreditoConsulta);
			this.TabFinanceiro.Controls.Add(this.btnFCustoConsulta);
			this.TabFinanceiro.Controls.Add(this.btnFCadastroCusto);
			this.TabFinanceiro.Controls.Add(this.btnFContasReceber);
			this.TabFinanceiro.Controls.Add(this.btnFContasPagar);
			this.TabFinanceiro.Location = new System.Drawing.Point(4, 22);
			this.TabFinanceiro.Name = "TabFinanceiro";
			this.TabFinanceiro.Padding = new System.Windows.Forms.Padding(3);
			this.TabFinanceiro.Size = new System.Drawing.Size(716, 368);
			this.TabFinanceiro.TabIndex = 2;
			this.TabFinanceiro.Text = "Financeiro";
			this.TabFinanceiro.UseVisualStyleBackColor = true;
			// 
			// btnFCreditoConsulta
			// 
			this.btnFCreditoConsulta.BackColor = System.Drawing.Color.Silver;
			this.btnFCreditoConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFCreditoConsulta.FlatAppearance.BorderSize = 0;
			this.btnFCreditoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFCreditoConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFCreditoConsulta.ForeColor = System.Drawing.Color.White;
			this.btnFCreditoConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnFCreditoConsulta.Image")));
			this.btnFCreditoConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFCreditoConsulta.Location = new System.Drawing.Point(580, 6);
			this.btnFCreditoConsulta.Name = "btnFCreditoConsulta";
			this.btnFCreditoConsulta.Size = new System.Drawing.Size(137, 87);
			this.btnFCreditoConsulta.TabIndex = 6;
			this.btnFCreditoConsulta.Text = "Crédito de\r\nClientes/Fornecedores";
			this.btnFCreditoConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFCreditoConsulta.UseVisualStyleBackColor = false;
			this.btnFCreditoConsulta.Click += new System.EventHandler(this.cliqueCreditoConsulta);
			// 
			// btnFCustoConsulta
			// 
			this.btnFCustoConsulta.BackColor = System.Drawing.Color.Silver;
			this.btnFCustoConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFCustoConsulta.FlatAppearance.BorderSize = 0;
			this.btnFCustoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFCustoConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFCustoConsulta.ForeColor = System.Drawing.Color.White;
			this.btnFCustoConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnFCustoConsulta.Image")));
			this.btnFCustoConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFCustoConsulta.Location = new System.Drawing.Point(437, 6);
			this.btnFCustoConsulta.Name = "btnFCustoConsulta";
			this.btnFCustoConsulta.Size = new System.Drawing.Size(137, 87);
			this.btnFCustoConsulta.TabIndex = 5;
			this.btnFCustoConsulta.Text = "Consulta de\r\nCusto/Despesa";
			this.btnFCustoConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFCustoConsulta.UseVisualStyleBackColor = false;
			this.btnFCustoConsulta.Click += new System.EventHandler(this.cliqueCustoConsulta);
			// 
			// btnFCadastroCusto
			// 
			this.btnFCadastroCusto.BackColor = System.Drawing.Color.Silver;
			this.btnFCadastroCusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnFCadastroCusto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFCadastroCusto.FlatAppearance.BorderSize = 0;
			this.btnFCadastroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFCadastroCusto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFCadastroCusto.ForeColor = System.Drawing.Color.White;
			this.btnFCadastroCusto.Image = ((System.Drawing.Image)(resources.GetObject("btnFCadastroCusto.Image")));
			this.btnFCadastroCusto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFCadastroCusto.Location = new System.Drawing.Point(294, 6);
			this.btnFCadastroCusto.Name = "btnFCadastroCusto";
			this.btnFCadastroCusto.Size = new System.Drawing.Size(137, 87);
			this.btnFCadastroCusto.TabIndex = 4;
			this.btnFCadastroCusto.Text = "Cadastro de\r\nCusto/Despesa";
			this.btnFCadastroCusto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFCadastroCusto.UseVisualStyleBackColor = false;
			this.btnFCadastroCusto.Click += new System.EventHandler(this.cliqueCustoCadastro);
			// 
			// btnFContasReceber
			// 
			this.btnFContasReceber.BackColor = System.Drawing.Color.Silver;
			this.btnFContasReceber.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFContasReceber.FlatAppearance.BorderSize = 0;
			this.btnFContasReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFContasReceber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFContasReceber.ForeColor = System.Drawing.Color.White;
			this.btnFContasReceber.Image = ((System.Drawing.Image)(resources.GetObject("btnFContasReceber.Image")));
			this.btnFContasReceber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFContasReceber.Location = new System.Drawing.Point(151, 6);
			this.btnFContasReceber.Name = "btnFContasReceber";
			this.btnFContasReceber.Size = new System.Drawing.Size(137, 87);
			this.btnFContasReceber.TabIndex = 3;
			this.btnFContasReceber.Text = "Consulta de\r\nContas á Receber";
			this.btnFContasReceber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFContasReceber.UseVisualStyleBackColor = false;
			this.btnFContasReceber.Click += new System.EventHandler(this.cliqueReceberConsulta);
			// 
			// btnFContasPagar
			// 
			this.btnFContasPagar.BackColor = System.Drawing.Color.Silver;
			this.btnFContasPagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFContasPagar.FlatAppearance.BorderSize = 0;
			this.btnFContasPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFContasPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFContasPagar.ForeColor = System.Drawing.Color.White;
			this.btnFContasPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnFContasPagar.Image")));
			this.btnFContasPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFContasPagar.Location = new System.Drawing.Point(8, 6);
			this.btnFContasPagar.Name = "btnFContasPagar";
			this.btnFContasPagar.Size = new System.Drawing.Size(137, 87);
			this.btnFContasPagar.TabIndex = 2;
			this.btnFContasPagar.Text = "Consulta de\r\nContas á Pagar";
			this.btnFContasPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFContasPagar.UseVisualStyleBackColor = false;
			this.btnFContasPagar.Click += new System.EventHandler(this.cliquePagarConsulta);
			// 
			// TabDiversos
			// 
			this.TabDiversos.Controls.Add(this.btnFUsuarioConfigura);
			this.TabDiversos.Controls.Add(this.btnFRelatorioProgramados);
			this.TabDiversos.Controls.Add(this.btnFRelatoriosConsulta);
			this.TabDiversos.Controls.Add(this.btnFUsuarioPermissao);
			this.TabDiversos.Controls.Add(this.btnFUsuarioControle);
			this.TabDiversos.Controls.Add(this.btnFPessoaConsulta);
			this.TabDiversos.Controls.Add(this.btnFCondicaoConsulta);
			this.TabDiversos.Location = new System.Drawing.Point(4, 22);
			this.TabDiversos.Name = "TabDiversos";
			this.TabDiversos.Padding = new System.Windows.Forms.Padding(3);
			this.TabDiversos.Size = new System.Drawing.Size(716, 368);
			this.TabDiversos.TabIndex = 3;
			this.TabDiversos.Text = "Diversos";
			this.TabDiversos.UseVisualStyleBackColor = true;
			// 
			// btnFRelatorioProgramados
			// 
			this.btnFRelatorioProgramados.BackColor = System.Drawing.Color.Silver;
			this.btnFRelatorioProgramados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFRelatorioProgramados.FlatAppearance.BorderSize = 0;
			this.btnFRelatorioProgramados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFRelatorioProgramados.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFRelatorioProgramados.ForeColor = System.Drawing.Color.White;
			this.btnFRelatorioProgramados.Image = ((System.Drawing.Image)(resources.GetObject("btnFRelatorioProgramados.Image")));
			this.btnFRelatorioProgramados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFRelatorioProgramados.Location = new System.Drawing.Point(8, 99);
			this.btnFRelatorioProgramados.Name = "btnFRelatorioProgramados";
			this.btnFRelatorioProgramados.Size = new System.Drawing.Size(137, 87);
			this.btnFRelatorioProgramados.TabIndex = 8;
			this.btnFRelatorioProgramados.Text = "Relatórios Programados";
			this.btnFRelatorioProgramados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFRelatorioProgramados.UseVisualStyleBackColor = false;
			this.btnFRelatorioProgramados.Click += new System.EventHandler(this.cliqueRelatorioProgramado);
			// 
			// btnFRelatoriosConsulta
			// 
			this.btnFRelatoriosConsulta.BackColor = System.Drawing.Color.Silver;
			this.btnFRelatoriosConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFRelatoriosConsulta.FlatAppearance.BorderSize = 0;
			this.btnFRelatoriosConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFRelatoriosConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFRelatoriosConsulta.ForeColor = System.Drawing.Color.White;
			this.btnFRelatoriosConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnFRelatoriosConsulta.Image")));
			this.btnFRelatoriosConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFRelatoriosConsulta.Location = new System.Drawing.Point(580, 6);
			this.btnFRelatoriosConsulta.Name = "btnFRelatoriosConsulta";
			this.btnFRelatoriosConsulta.Size = new System.Drawing.Size(137, 87);
			this.btnFRelatoriosConsulta.TabIndex = 7;
			this.btnFRelatoriosConsulta.Text = "Relatórios";
			this.btnFRelatoriosConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFRelatoriosConsulta.UseVisualStyleBackColor = false;
			this.btnFRelatoriosConsulta.Click += new System.EventHandler(this.cliqueRelatorioConsulta);
			// 
			// btnFUsuarioPermissao
			// 
			this.btnFUsuarioPermissao.BackColor = System.Drawing.Color.Silver;
			this.btnFUsuarioPermissao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFUsuarioPermissao.FlatAppearance.BorderSize = 0;
			this.btnFUsuarioPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFUsuarioPermissao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFUsuarioPermissao.ForeColor = System.Drawing.Color.White;
			this.btnFUsuarioPermissao.Image = ((System.Drawing.Image)(resources.GetObject("btnFUsuarioPermissao.Image")));
			this.btnFUsuarioPermissao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFUsuarioPermissao.Location = new System.Drawing.Point(437, 6);
			this.btnFUsuarioPermissao.Name = "btnFUsuarioPermissao";
			this.btnFUsuarioPermissao.Size = new System.Drawing.Size(137, 87);
			this.btnFUsuarioPermissao.TabIndex = 6;
			this.btnFUsuarioPermissao.Text = "Controle de Permissões";
			this.btnFUsuarioPermissao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFUsuarioPermissao.UseVisualStyleBackColor = false;
			this.btnFUsuarioPermissao.Click += new System.EventHandler(this.cliquePermissaoControle);
			// 
			// btnFUsuarioControle
			// 
			this.btnFUsuarioControle.BackColor = System.Drawing.Color.Silver;
			this.btnFUsuarioControle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFUsuarioControle.FlatAppearance.BorderSize = 0;
			this.btnFUsuarioControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFUsuarioControle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFUsuarioControle.ForeColor = System.Drawing.Color.White;
			this.btnFUsuarioControle.Image = ((System.Drawing.Image)(resources.GetObject("btnFUsuarioControle.Image")));
			this.btnFUsuarioControle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFUsuarioControle.Location = new System.Drawing.Point(294, 6);
			this.btnFUsuarioControle.Name = "btnFUsuarioControle";
			this.btnFUsuarioControle.Size = new System.Drawing.Size(137, 87);
			this.btnFUsuarioControle.TabIndex = 5;
			this.btnFUsuarioControle.Text = "Controle de \r\nUsuários";
			this.btnFUsuarioControle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFUsuarioControle.UseVisualStyleBackColor = false;
			this.btnFUsuarioControle.Click += new System.EventHandler(this.cliqueUsuarioControle);
			// 
			// btnFPessoaConsulta
			// 
			this.btnFPessoaConsulta.BackColor = System.Drawing.Color.Silver;
			this.btnFPessoaConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFPessoaConsulta.FlatAppearance.BorderSize = 0;
			this.btnFPessoaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFPessoaConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFPessoaConsulta.ForeColor = System.Drawing.Color.White;
			this.btnFPessoaConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnFPessoaConsulta.Image")));
			this.btnFPessoaConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFPessoaConsulta.Location = new System.Drawing.Point(151, 6);
			this.btnFPessoaConsulta.Name = "btnFPessoaConsulta";
			this.btnFPessoaConsulta.Size = new System.Drawing.Size(137, 87);
			this.btnFPessoaConsulta.TabIndex = 4;
			this.btnFPessoaConsulta.Text = "Consulta de Clientes e Fornecedores";
			this.btnFPessoaConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFPessoaConsulta.UseVisualStyleBackColor = false;
			this.btnFPessoaConsulta.Click += new System.EventHandler(this.cliquePessoaConsulta);
			// 
			// btnFCondicaoConsulta
			// 
			this.btnFCondicaoConsulta.BackColor = System.Drawing.Color.Silver;
			this.btnFCondicaoConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFCondicaoConsulta.FlatAppearance.BorderSize = 0;
			this.btnFCondicaoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFCondicaoConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFCondicaoConsulta.ForeColor = System.Drawing.Color.White;
			this.btnFCondicaoConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnFCondicaoConsulta.Image")));
			this.btnFCondicaoConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFCondicaoConsulta.Location = new System.Drawing.Point(8, 6);
			this.btnFCondicaoConsulta.Name = "btnFCondicaoConsulta";
			this.btnFCondicaoConsulta.Size = new System.Drawing.Size(137, 87);
			this.btnFCondicaoConsulta.TabIndex = 3;
			this.btnFCondicaoConsulta.Text = "Consulta de Condições de Pagamento";
			this.btnFCondicaoConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFCondicaoConsulta.UseVisualStyleBackColor = false;
			this.btnFCondicaoConsulta.Click += new System.EventHandler(this.cliqueCondicaoConsulta);
			// 
			// materialTabSelector1
			// 
			this.materialTabSelector1.BaseTabControl = this.TabControle;
			this.materialTabSelector1.Depth = 0;
			this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
			this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabSelector1.Name = "materialTabSelector1";
			this.materialTabSelector1.Size = new System.Drawing.Size(786, 38);
			this.materialTabSelector1.TabIndex = 2;
			this.materialTabSelector1.Text = "materialTabSelector1";
			// 
			// bwkRelatorio
			// 
			this.bwkRelatorio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProcessoProgramado);
			// 
			// btnFUsuarioConfigura
			// 
			this.btnFUsuarioConfigura.BackColor = System.Drawing.Color.Silver;
			this.btnFUsuarioConfigura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFUsuarioConfigura.FlatAppearance.BorderSize = 0;
			this.btnFUsuarioConfigura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFUsuarioConfigura.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFUsuarioConfigura.ForeColor = System.Drawing.Color.White;
			this.btnFUsuarioConfigura.Image = ((System.Drawing.Image)(resources.GetObject("btnFUsuarioConfigura.Image")));
			this.btnFUsuarioConfigura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFUsuarioConfigura.Location = new System.Drawing.Point(151, 99);
			this.btnFUsuarioConfigura.Name = "btnFUsuarioConfigura";
			this.btnFUsuarioConfigura.Size = new System.Drawing.Size(137, 87);
			this.btnFUsuarioConfigura.TabIndex = 9;
			this.btnFUsuarioConfigura.Text = "Configurações Meu Usuário";
			this.btnFUsuarioConfigura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFUsuarioConfigura.UseVisualStyleBackColor = false;
			this.btnFUsuarioConfigura.Click += new System.EventHandler(this.cliqueUsuarioConfigura);
			// 
			// homeMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 495);
			this.Controls.Add(this.materialTabSelector1);
			this.Controls.Add(this.TabControle);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "homeMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GML - Gestão";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sairSistema);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fecharSistema);
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.TabControle.ResumeLayout(false);
			this.TabVendaCompra.ResumeLayout(false);
			this.TabProduto.ResumeLayout(false);
			this.TabFinanceiro.ResumeLayout(false);
			this.TabDiversos.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnFUsuarioConfigura;
		private System.ComponentModel.BackgroundWorker bwkRelatorio;
		private System.Windows.Forms.Button btnFRelatorioProgramados;
		private System.Windows.Forms.Button btnFUsuarioPermissao;
		private System.Windows.Forms.Button btnFRelatoriosConsulta;
		private System.Windows.Forms.Button btnFUsuarioControle;
		private System.Windows.Forms.Button btnFPessoaConsulta;
		private System.Windows.Forms.Button btnFCondicaoConsulta;
		private System.Windows.Forms.Button btnFCreditoConsulta;
		private System.Windows.Forms.Button btnFCustoConsulta;
		private System.Windows.Forms.Button btnFCadastroCusto;
		private System.Windows.Forms.Button btnFContasPagar;
		private System.Windows.Forms.Button btnFContasReceber;
		private System.Windows.Forms.Button btnFFamilia;
		private System.Windows.Forms.Button btnFProduto;
		private System.Windows.Forms.Button btnFEstoque;
		private System.Windows.Forms.Button btnFCompra;
		private System.Windows.Forms.Button btnFVenda;
		private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
		private System.Windows.Forms.TabPage TabDiversos;
		private System.Windows.Forms.TabPage TabFinanceiro;
		private System.Windows.Forms.TabPage TabProduto;
		private System.Windows.Forms.TabPage TabVendaCompra;
		private MaterialSkin.Controls.MaterialTabControl TabControle;
		private System.Windows.Forms.Button btnFBalcao;
	}
}
