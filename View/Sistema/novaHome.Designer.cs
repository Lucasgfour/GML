
namespace GM.View.Sistema
{
	partial class novaHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(novaHome));
			this.pnVendas = new System.Windows.Forms.Panel();
			this.bnCDBalca = new System.Windows.Forms.Button();
			this.bnCDVenda = new System.Windows.Forms.Button();
			this.bnCSVenda = new System.Windows.Forms.Button();
			this.labVenda = new System.Windows.Forms.Label();
			this.labTitulo = new System.Windows.Forms.Label();
			this.pnProdutos = new System.Windows.Forms.Panel();
			this.bnCSEstoque = new System.Windows.Forms.Button();
			this.bnCSFamilia = new System.Windows.Forms.Button();
			this.bnCSProduto = new System.Windows.Forms.Button();
			this.labProduto = new System.Windows.Forms.Label();
			this.pnCompras = new System.Windows.Forms.Panel();
			this.bnCDCompra = new System.Windows.Forms.Button();
			this.bnCSCompra = new System.Windows.Forms.Button();
			this.labCompra = new System.Windows.Forms.Label();
			this.pnFinanceiro = new System.Windows.Forms.Panel();
			this.btnCSCred = new System.Windows.Forms.Button();
			this.bnCSCusto = new System.Windows.Forms.Button();
			this.bnCDCusto = new System.Windows.Forms.Button();
			this.bnCSConta = new System.Windows.Forms.Button();
			this.bnCSPagar = new System.Windows.Forms.Button();
			this.labFinanceiro = new System.Windows.Forms.Label();
			this.pnDiversos = new System.Windows.Forms.Panel();
			this.bnCTRelatorio = new System.Windows.Forms.Button();
			this.bnCTModulo = new System.Windows.Forms.Button();
			this.bnCTUsuario = new System.Windows.Forms.Button();
			this.bnCDPessoa = new System.Windows.Forms.Button();
			this.bnCSCondicao = new System.Windows.Forms.Button();
			this.labDiversos = new System.Windows.Forms.Label();
			this.bnSair = new System.Windows.Forms.Button();
			this.bnMinimizar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pnVendas.SuspendLayout();
			this.pnProdutos.SuspendLayout();
			this.pnCompras.SuspendLayout();
			this.pnFinanceiro.SuspendLayout();
			this.pnDiversos.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnVendas
			// 
			this.pnVendas.BackColor = System.Drawing.Color.LightSkyBlue;
			this.pnVendas.Controls.Add(this.bnCDBalca);
			this.pnVendas.Controls.Add(this.bnCDVenda);
			this.pnVendas.Controls.Add(this.bnCSVenda);
			this.pnVendas.Controls.Add(this.labVenda);
			this.pnVendas.Location = new System.Drawing.Point(0, 51);
			this.pnVendas.Name = "pnVendas";
			this.pnVendas.Size = new System.Drawing.Size(200, 155);
			this.pnVendas.TabIndex = 0;
			// 
			// bnCDBalca
			// 
			this.bnCDBalca.BackColor = System.Drawing.Color.Lime;
			this.bnCDBalca.Enabled = false;
			this.bnCDBalca.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCDBalca.FlatAppearance.BorderSize = 0;
			this.bnCDBalca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCDBalca.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCDBalca.ForeColor = System.Drawing.Color.White;
			this.bnCDBalca.Image = ((System.Drawing.Image)(resources.GetObject("bnCDBalca.Image")));
			this.bnCDBalca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCDBalca.Location = new System.Drawing.Point(0, 121);
			this.bnCDBalca.Name = "bnCDBalca";
			this.bnCDBalca.Size = new System.Drawing.Size(200, 34);
			this.bnCDBalca.TabIndex = 3;
			this.bnCDBalca.Text = "Venda Balcão";
			this.bnCDBalca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCDBalca.UseVisualStyleBackColor = false;
			this.bnCDBalca.Click += new System.EventHandler(this.openBalcao);
			// 
			// bnCDVenda
			// 
			this.bnCDVenda.BackColor = System.Drawing.Color.Lime;
			this.bnCDVenda.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCDVenda.FlatAppearance.BorderSize = 0;
			this.bnCDVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCDVenda.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCDVenda.ForeColor = System.Drawing.Color.White;
			this.bnCDVenda.Image = ((System.Drawing.Image)(resources.GetObject("bnCDVenda.Image")));
			this.bnCDVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCDVenda.Location = new System.Drawing.Point(0, 86);
			this.bnCDVenda.Name = "bnCDVenda";
			this.bnCDVenda.Size = new System.Drawing.Size(200, 34);
			this.bnCDVenda.TabIndex = 2;
			this.bnCDVenda.Text = "Cadastrar Venda";
			this.bnCDVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCDVenda.UseVisualStyleBackColor = false;
			this.bnCDVenda.Click += new System.EventHandler(this.openCadastrarVenda);
			// 
			// bnCSVenda
			// 
			this.bnCSVenda.BackColor = System.Drawing.Color.Lime;
			this.bnCSVenda.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCSVenda.FlatAppearance.BorderSize = 0;
			this.bnCSVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCSVenda.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCSVenda.ForeColor = System.Drawing.Color.White;
			this.bnCSVenda.Image = ((System.Drawing.Image)(resources.GetObject("bnCSVenda.Image")));
			this.bnCSVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCSVenda.Location = new System.Drawing.Point(0, 51);
			this.bnCSVenda.Name = "bnCSVenda";
			this.bnCSVenda.Size = new System.Drawing.Size(200, 34);
			this.bnCSVenda.TabIndex = 1;
			this.bnCSVenda.Text = "Consulta Vendas";
			this.bnCSVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCSVenda.UseVisualStyleBackColor = false;
			this.bnCSVenda.Click += new System.EventHandler(this.openConsultaVenda);
			// 
			// labVenda
			// 
			this.labVenda.BackColor = System.Drawing.Color.SteelBlue;
			this.labVenda.Dock = System.Windows.Forms.DockStyle.Top;
			this.labVenda.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labVenda.ForeColor = System.Drawing.Color.White;
			this.labVenda.Location = new System.Drawing.Point(0, 0);
			this.labVenda.Name = "labVenda";
			this.labVenda.Size = new System.Drawing.Size(200, 50);
			this.labVenda.TabIndex = 1;
			this.labVenda.Text = "Venda";
			this.labVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labTitulo
			// 
			this.labTitulo.BackColor = System.Drawing.Color.SteelBlue;
			this.labTitulo.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTitulo.ForeColor = System.Drawing.Color.White;
			this.labTitulo.Location = new System.Drawing.Point(0, 0);
			this.labTitulo.Name = "labTitulo";
			this.labTitulo.Size = new System.Drawing.Size(589, 50);
			this.labTitulo.TabIndex = 3;
			this.labTitulo.Text = "GM - Sistema de Controle";
			this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnProdutos
			// 
			this.pnProdutos.BackColor = System.Drawing.Color.LightSkyBlue;
			this.pnProdutos.Controls.Add(this.bnCSEstoque);
			this.pnProdutos.Controls.Add(this.bnCSFamilia);
			this.pnProdutos.Controls.Add(this.bnCSProduto);
			this.pnProdutos.Controls.Add(this.labProduto);
			this.pnProdutos.Location = new System.Drawing.Point(201, 51);
			this.pnProdutos.Name = "pnProdutos";
			this.pnProdutos.Size = new System.Drawing.Size(200, 155);
			this.pnProdutos.TabIndex = 4;
			// 
			// bnCSEstoque
			// 
			this.bnCSEstoque.BackColor = System.Drawing.Color.Yellow;
			this.bnCSEstoque.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCSEstoque.FlatAppearance.BorderSize = 0;
			this.bnCSEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCSEstoque.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCSEstoque.ForeColor = System.Drawing.Color.White;
			this.bnCSEstoque.Image = ((System.Drawing.Image)(resources.GetObject("bnCSEstoque.Image")));
			this.bnCSEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCSEstoque.Location = new System.Drawing.Point(0, 121);
			this.bnCSEstoque.Name = "bnCSEstoque";
			this.bnCSEstoque.Size = new System.Drawing.Size(200, 34);
			this.bnCSEstoque.TabIndex = 3;
			this.bnCSEstoque.Text = "Consulta Estoque";
			this.bnCSEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCSEstoque.UseVisualStyleBackColor = false;
			this.bnCSEstoque.Click += new System.EventHandler(this.openConsultaEstoque);
			// 
			// bnCSFamilia
			// 
			this.bnCSFamilia.BackColor = System.Drawing.Color.Yellow;
			this.bnCSFamilia.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCSFamilia.FlatAppearance.BorderSize = 0;
			this.bnCSFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCSFamilia.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCSFamilia.ForeColor = System.Drawing.Color.White;
			this.bnCSFamilia.Image = ((System.Drawing.Image)(resources.GetObject("bnCSFamilia.Image")));
			this.bnCSFamilia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCSFamilia.Location = new System.Drawing.Point(0, 86);
			this.bnCSFamilia.Name = "bnCSFamilia";
			this.bnCSFamilia.Size = new System.Drawing.Size(200, 34);
			this.bnCSFamilia.TabIndex = 2;
			this.bnCSFamilia.Text = "Consulta Famílias";
			this.bnCSFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCSFamilia.UseVisualStyleBackColor = false;
			this.bnCSFamilia.Click += new System.EventHandler(this.openConsultaFamilia);
			// 
			// bnCSProduto
			// 
			this.bnCSProduto.BackColor = System.Drawing.Color.Yellow;
			this.bnCSProduto.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCSProduto.FlatAppearance.BorderSize = 0;
			this.bnCSProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCSProduto.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCSProduto.ForeColor = System.Drawing.Color.White;
			this.bnCSProduto.Image = ((System.Drawing.Image)(resources.GetObject("bnCSProduto.Image")));
			this.bnCSProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCSProduto.Location = new System.Drawing.Point(0, 51);
			this.bnCSProduto.Name = "bnCSProduto";
			this.bnCSProduto.Size = new System.Drawing.Size(200, 34);
			this.bnCSProduto.TabIndex = 1;
			this.bnCSProduto.Text = "Consulta Produtos";
			this.bnCSProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCSProduto.UseVisualStyleBackColor = false;
			this.bnCSProduto.Click += new System.EventHandler(this.openConsultaProduto);
			// 
			// labProduto
			// 
			this.labProduto.BackColor = System.Drawing.Color.SteelBlue;
			this.labProduto.Dock = System.Windows.Forms.DockStyle.Top;
			this.labProduto.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labProduto.ForeColor = System.Drawing.Color.White;
			this.labProduto.Location = new System.Drawing.Point(0, 0);
			this.labProduto.Name = "labProduto";
			this.labProduto.Size = new System.Drawing.Size(200, 50);
			this.labProduto.TabIndex = 1;
			this.labProduto.Text = "Produto";
			this.labProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnCompras
			// 
			this.pnCompras.BackColor = System.Drawing.Color.LightSkyBlue;
			this.pnCompras.Controls.Add(this.bnCDCompra);
			this.pnCompras.Controls.Add(this.bnCSCompra);
			this.pnCompras.Controls.Add(this.labCompra);
			this.pnCompras.Location = new System.Drawing.Point(0, 207);
			this.pnCompras.Name = "pnCompras";
			this.pnCompras.Size = new System.Drawing.Size(200, 120);
			this.pnCompras.TabIndex = 4;
			// 
			// bnCDCompra
			// 
			this.bnCDCompra.BackColor = System.Drawing.Color.Lime;
			this.bnCDCompra.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCDCompra.FlatAppearance.BorderSize = 0;
			this.bnCDCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCDCompra.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCDCompra.ForeColor = System.Drawing.Color.White;
			this.bnCDCompra.Image = ((System.Drawing.Image)(resources.GetObject("bnCDCompra.Image")));
			this.bnCDCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCDCompra.Location = new System.Drawing.Point(0, 86);
			this.bnCDCompra.Name = "bnCDCompra";
			this.bnCDCompra.Size = new System.Drawing.Size(200, 34);
			this.bnCDCompra.TabIndex = 2;
			this.bnCDCompra.Text = "Cadastrar Compra";
			this.bnCDCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCDCompra.UseVisualStyleBackColor = false;
			this.bnCDCompra.Click += new System.EventHandler(this.openCadastrarCompra);
			// 
			// bnCSCompra
			// 
			this.bnCSCompra.BackColor = System.Drawing.Color.Lime;
			this.bnCSCompra.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCSCompra.FlatAppearance.BorderSize = 0;
			this.bnCSCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCSCompra.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCSCompra.ForeColor = System.Drawing.Color.White;
			this.bnCSCompra.Image = ((System.Drawing.Image)(resources.GetObject("bnCSCompra.Image")));
			this.bnCSCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCSCompra.Location = new System.Drawing.Point(0, 51);
			this.bnCSCompra.Name = "bnCSCompra";
			this.bnCSCompra.Size = new System.Drawing.Size(200, 34);
			this.bnCSCompra.TabIndex = 1;
			this.bnCSCompra.Text = "Consulta Compras";
			this.bnCSCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCSCompra.UseVisualStyleBackColor = false;
			this.bnCSCompra.Click += new System.EventHandler(this.openConsultaCompra);
			// 
			// labCompra
			// 
			this.labCompra.BackColor = System.Drawing.Color.SteelBlue;
			this.labCompra.Dock = System.Windows.Forms.DockStyle.Top;
			this.labCompra.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCompra.ForeColor = System.Drawing.Color.White;
			this.labCompra.Location = new System.Drawing.Point(0, 0);
			this.labCompra.Name = "labCompra";
			this.labCompra.Size = new System.Drawing.Size(200, 50);
			this.labCompra.TabIndex = 1;
			this.labCompra.Text = "Compra";
			this.labCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnFinanceiro
			// 
			this.pnFinanceiro.BackColor = System.Drawing.Color.LightSkyBlue;
			this.pnFinanceiro.Controls.Add(this.btnCSCred);
			this.pnFinanceiro.Controls.Add(this.bnCSCusto);
			this.pnFinanceiro.Controls.Add(this.bnCDCusto);
			this.pnFinanceiro.Controls.Add(this.bnCSConta);
			this.pnFinanceiro.Controls.Add(this.bnCSPagar);
			this.pnFinanceiro.Controls.Add(this.labFinanceiro);
			this.pnFinanceiro.Location = new System.Drawing.Point(402, 51);
			this.pnFinanceiro.Name = "pnFinanceiro";
			this.pnFinanceiro.Size = new System.Drawing.Size(257, 226);
			this.pnFinanceiro.TabIndex = 5;
			// 
			// btnCSCred
			// 
			this.btnCSCred.BackColor = System.Drawing.Color.CadetBlue;
			this.btnCSCred.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.btnCSCred.FlatAppearance.BorderSize = 0;
			this.btnCSCred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCSCred.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.btnCSCred.ForeColor = System.Drawing.Color.White;
			this.btnCSCred.Image = ((System.Drawing.Image)(resources.GetObject("btnCSCred.Image")));
			this.btnCSCred.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCSCred.Location = new System.Drawing.Point(0, 191);
			this.btnCSCred.Name = "btnCSCred";
			this.btnCSCred.Size = new System.Drawing.Size(257, 34);
			this.btnCSCred.TabIndex = 5;
			this.btnCSCred.Text = "Créd. Cliente/Fornecedor";
			this.btnCSCred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCSCred.UseVisualStyleBackColor = false;
			this.btnCSCred.Click += new System.EventHandler(this.openCredito);
			// 
			// bnCSCusto
			// 
			this.bnCSCusto.BackColor = System.Drawing.Color.CadetBlue;
			this.bnCSCusto.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCSCusto.FlatAppearance.BorderSize = 0;
			this.bnCSCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCSCusto.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCSCusto.ForeColor = System.Drawing.Color.White;
			this.bnCSCusto.Image = ((System.Drawing.Image)(resources.GetObject("bnCSCusto.Image")));
			this.bnCSCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCSCusto.Location = new System.Drawing.Point(0, 156);
			this.bnCSCusto.Name = "bnCSCusto";
			this.bnCSCusto.Size = new System.Drawing.Size(257, 34);
			this.bnCSCusto.TabIndex = 4;
			this.bnCSCusto.Text = "Consulta Custo/Despesa";
			this.bnCSCusto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCSCusto.UseVisualStyleBackColor = false;
			this.bnCSCusto.Click += new System.EventHandler(this.openCustoDespesa);
			// 
			// bnCDCusto
			// 
			this.bnCDCusto.BackColor = System.Drawing.Color.CadetBlue;
			this.bnCDCusto.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCDCusto.FlatAppearance.BorderSize = 0;
			this.bnCDCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCDCusto.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCDCusto.ForeColor = System.Drawing.Color.White;
			this.bnCDCusto.Image = ((System.Drawing.Image)(resources.GetObject("bnCDCusto.Image")));
			this.bnCDCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCDCusto.Location = new System.Drawing.Point(0, 121);
			this.bnCDCusto.Name = "bnCDCusto";
			this.bnCDCusto.Size = new System.Drawing.Size(257, 34);
			this.bnCDCusto.TabIndex = 3;
			this.bnCDCusto.Text = "Cadastrar Custo/Despesa";
			this.bnCDCusto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCDCusto.UseVisualStyleBackColor = false;
			this.bnCDCusto.Click += new System.EventHandler(this.openConsultaCustoDespesa);
			// 
			// bnCSConta
			// 
			this.bnCSConta.BackColor = System.Drawing.Color.Cyan;
			this.bnCSConta.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCSConta.FlatAppearance.BorderSize = 0;
			this.bnCSConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCSConta.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCSConta.ForeColor = System.Drawing.Color.White;
			this.bnCSConta.Image = ((System.Drawing.Image)(resources.GetObject("bnCSConta.Image")));
			this.bnCSConta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCSConta.Location = new System.Drawing.Point(0, 86);
			this.bnCSConta.Name = "bnCSConta";
			this.bnCSConta.Size = new System.Drawing.Size(257, 34);
			this.bnCSConta.TabIndex = 2;
			this.bnCSConta.Text = "Contas á Receber";
			this.bnCSConta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCSConta.UseVisualStyleBackColor = false;
			this.bnCSConta.Click += new System.EventHandler(this.openConsultaCReceber);
			// 
			// bnCSPagar
			// 
			this.bnCSPagar.BackColor = System.Drawing.Color.Cyan;
			this.bnCSPagar.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCSPagar.FlatAppearance.BorderSize = 0;
			this.bnCSPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCSPagar.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCSPagar.ForeColor = System.Drawing.Color.White;
			this.bnCSPagar.Image = ((System.Drawing.Image)(resources.GetObject("bnCSPagar.Image")));
			this.bnCSPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCSPagar.Location = new System.Drawing.Point(0, 51);
			this.bnCSPagar.Name = "bnCSPagar";
			this.bnCSPagar.Size = new System.Drawing.Size(257, 34);
			this.bnCSPagar.TabIndex = 1;
			this.bnCSPagar.Text = "Contas á Pagar";
			this.bnCSPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCSPagar.UseVisualStyleBackColor = false;
			this.bnCSPagar.Click += new System.EventHandler(this.openConsultaCPagar);
			// 
			// labFinanceiro
			// 
			this.labFinanceiro.BackColor = System.Drawing.Color.SteelBlue;
			this.labFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
			this.labFinanceiro.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labFinanceiro.ForeColor = System.Drawing.Color.White;
			this.labFinanceiro.Location = new System.Drawing.Point(0, 0);
			this.labFinanceiro.Name = "labFinanceiro";
			this.labFinanceiro.Size = new System.Drawing.Size(257, 50);
			this.labFinanceiro.TabIndex = 1;
			this.labFinanceiro.Text = "Financeiro";
			this.labFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnDiversos
			// 
			this.pnDiversos.BackColor = System.Drawing.Color.LightSkyBlue;
			this.pnDiversos.Controls.Add(this.bnCTRelatorio);
			this.pnDiversos.Controls.Add(this.bnCTModulo);
			this.pnDiversos.Controls.Add(this.bnCTUsuario);
			this.pnDiversos.Controls.Add(this.bnCDPessoa);
			this.pnDiversos.Controls.Add(this.bnCSCondicao);
			this.pnDiversos.Controls.Add(this.labDiversos);
			this.pnDiversos.Location = new System.Drawing.Point(402, 278);
			this.pnDiversos.Name = "pnDiversos";
			this.pnDiversos.Size = new System.Drawing.Size(257, 225);
			this.pnDiversos.TabIndex = 6;
			// 
			// bnCTRelatorio
			// 
			this.bnCTRelatorio.BackColor = System.Drawing.Color.CadetBlue;
			this.bnCTRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCTRelatorio.FlatAppearance.BorderSize = 0;
			this.bnCTRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCTRelatorio.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCTRelatorio.ForeColor = System.Drawing.Color.White;
			this.bnCTRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("bnCTRelatorio.Image")));
			this.bnCTRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCTRelatorio.Location = new System.Drawing.Point(0, 191);
			this.bnCTRelatorio.Name = "bnCTRelatorio";
			this.bnCTRelatorio.Size = new System.Drawing.Size(257, 34);
			this.bnCTRelatorio.TabIndex = 5;
			this.bnCTRelatorio.Text = "Relatórios";
			this.bnCTRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCTRelatorio.UseVisualStyleBackColor = false;
			this.bnCTRelatorio.Click += new System.EventHandler(this.openRelatorio);
			// 
			// bnCTModulo
			// 
			this.bnCTModulo.BackColor = System.Drawing.Color.CadetBlue;
			this.bnCTModulo.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCTModulo.FlatAppearance.BorderSize = 0;
			this.bnCTModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCTModulo.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCTModulo.ForeColor = System.Drawing.Color.White;
			this.bnCTModulo.Image = ((System.Drawing.Image)(resources.GetObject("bnCTModulo.Image")));
			this.bnCTModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCTModulo.Location = new System.Drawing.Point(0, 156);
			this.bnCTModulo.Name = "bnCTModulo";
			this.bnCTModulo.Size = new System.Drawing.Size(257, 34);
			this.bnCTModulo.TabIndex = 4;
			this.bnCTModulo.Text = "Controle de Permissões";
			this.bnCTModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCTModulo.UseVisualStyleBackColor = false;
			this.bnCTModulo.Click += new System.EventHandler(this.openControleModulo);
			// 
			// bnCTUsuario
			// 
			this.bnCTUsuario.BackColor = System.Drawing.Color.CadetBlue;
			this.bnCTUsuario.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCTUsuario.FlatAppearance.BorderSize = 0;
			this.bnCTUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCTUsuario.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCTUsuario.ForeColor = System.Drawing.Color.White;
			this.bnCTUsuario.Image = ((System.Drawing.Image)(resources.GetObject("bnCTUsuario.Image")));
			this.bnCTUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCTUsuario.Location = new System.Drawing.Point(0, 121);
			this.bnCTUsuario.Name = "bnCTUsuario";
			this.bnCTUsuario.Size = new System.Drawing.Size(257, 34);
			this.bnCTUsuario.TabIndex = 3;
			this.bnCTUsuario.Text = "Controle de Usuários";
			this.bnCTUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCTUsuario.UseVisualStyleBackColor = false;
			this.bnCTUsuario.Click += new System.EventHandler(this.oepnControleUsuario);
			// 
			// bnCDPessoa
			// 
			this.bnCDPessoa.BackColor = System.Drawing.Color.CadetBlue;
			this.bnCDPessoa.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCDPessoa.FlatAppearance.BorderSize = 0;
			this.bnCDPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCDPessoa.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCDPessoa.ForeColor = System.Drawing.Color.White;
			this.bnCDPessoa.Image = ((System.Drawing.Image)(resources.GetObject("bnCDPessoa.Image")));
			this.bnCDPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCDPessoa.Location = new System.Drawing.Point(0, 86);
			this.bnCDPessoa.Name = "bnCDPessoa";
			this.bnCDPessoa.Size = new System.Drawing.Size(257, 34);
			this.bnCDPessoa.TabIndex = 2;
			this.bnCDPessoa.Text = "Clientes e Fornecedores";
			this.bnCDPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCDPessoa.UseVisualStyleBackColor = false;
			this.bnCDPessoa.Click += new System.EventHandler(this.openCadastroPessoa);
			// 
			// bnCSCondicao
			// 
			this.bnCSCondicao.BackColor = System.Drawing.Color.CadetBlue;
			this.bnCSCondicao.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnCSCondicao.FlatAppearance.BorderSize = 0;
			this.bnCSCondicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnCSCondicao.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnCSCondicao.ForeColor = System.Drawing.Color.White;
			this.bnCSCondicao.Image = ((System.Drawing.Image)(resources.GetObject("bnCSCondicao.Image")));
			this.bnCSCondicao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnCSCondicao.Location = new System.Drawing.Point(0, 51);
			this.bnCSCondicao.Name = "bnCSCondicao";
			this.bnCSCondicao.Size = new System.Drawing.Size(257, 34);
			this.bnCSCondicao.TabIndex = 1;
			this.bnCSCondicao.Text = "Condições de Pagamento";
			this.bnCSCondicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnCSCondicao.UseVisualStyleBackColor = false;
			this.bnCSCondicao.Click += new System.EventHandler(this.openCondicaoPagamento);
			// 
			// labDiversos
			// 
			this.labDiversos.BackColor = System.Drawing.Color.SteelBlue;
			this.labDiversos.Dock = System.Windows.Forms.DockStyle.Top;
			this.labDiversos.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDiversos.ForeColor = System.Drawing.Color.White;
			this.labDiversos.Location = new System.Drawing.Point(0, 0);
			this.labDiversos.Name = "labDiversos";
			this.labDiversos.Size = new System.Drawing.Size(257, 50);
			this.labDiversos.TabIndex = 1;
			this.labDiversos.Text = "Diversos";
			this.labDiversos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bnSair
			// 
			this.bnSair.BackColor = System.Drawing.Color.LightCoral;
			this.bnSair.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnSair.FlatAppearance.BorderSize = 0;
			this.bnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnSair.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnSair.ForeColor = System.Drawing.Color.White;
			this.bnSair.Image = ((System.Drawing.Image)(resources.GetObject("bnSair.Image")));
			this.bnSair.Location = new System.Drawing.Point(625, 0);
			this.bnSair.Name = "bnSair";
			this.bnSair.Size = new System.Drawing.Size(34, 50);
			this.bnSair.TabIndex = 5;
			this.bnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnSair.UseVisualStyleBackColor = false;
			this.bnSair.Click += new System.EventHandler(this.cliqueSair);
			// 
			// bnMinimizar
			// 
			this.bnMinimizar.BackColor = System.Drawing.Color.CadetBlue;
			this.bnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.bnMinimizar.FlatAppearance.BorderSize = 0;
			this.bnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bnMinimizar.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.bnMinimizar.ForeColor = System.Drawing.Color.White;
			this.bnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("bnMinimizar.Image")));
			this.bnMinimizar.Location = new System.Drawing.Point(590, 0);
			this.bnMinimizar.Name = "bnMinimizar";
			this.bnMinimizar.Size = new System.Drawing.Size(34, 50);
			this.bnMinimizar.TabIndex = 5;
			this.bnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnMinimizar.UseVisualStyleBackColor = false;
			this.bnMinimizar.Click += new System.EventHandler(this.cliqueMinimizar);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.CadetBlue;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(115, 389);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "Cadastrar Compra";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.teste);
			// 
			// novaHome
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(660, 505);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bnMinimizar);
			this.Controls.Add(this.bnSair);
			this.Controls.Add(this.pnDiversos);
			this.Controls.Add(this.pnFinanceiro);
			this.Controls.Add(this.pnCompras);
			this.Controls.Add(this.pnProdutos);
			this.Controls.Add(this.labTitulo);
			this.Controls.Add(this.pnVendas);
			this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "novaHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GM - Sistema de Controle";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confirmaSair);
			this.pnVendas.ResumeLayout(false);
			this.pnProdutos.ResumeLayout(false);
			this.pnCompras.ResumeLayout(false);
			this.pnFinanceiro.ResumeLayout(false);
			this.pnDiversos.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnCSCred;
		private System.Windows.Forms.Button bnMinimizar;
		private System.Windows.Forms.Button bnSair;
		private System.Windows.Forms.Button bnCTRelatorio;
		private System.Windows.Forms.Label labDiversos;
		private System.Windows.Forms.Button bnCSCondicao;
		private System.Windows.Forms.Button bnCDPessoa;
		private System.Windows.Forms.Button bnCTUsuario;
		private System.Windows.Forms.Button bnCTModulo;
		private System.Windows.Forms.Panel pnDiversos;
		private System.Windows.Forms.Button bnCSCusto;
		private System.Windows.Forms.Label labFinanceiro;
		private System.Windows.Forms.Button bnCSPagar;
		private System.Windows.Forms.Button bnCSConta;
		private System.Windows.Forms.Button bnCDCusto;
		private System.Windows.Forms.Panel pnFinanceiro;
		private System.Windows.Forms.Label labCompra;
		private System.Windows.Forms.Button bnCSCompra;
		private System.Windows.Forms.Button bnCDCompra;
		private System.Windows.Forms.Panel pnCompras;
		private System.Windows.Forms.Label labProduto;
		private System.Windows.Forms.Button bnCSProduto;
		private System.Windows.Forms.Button bnCSFamilia;
		private System.Windows.Forms.Button bnCSEstoque;
		private System.Windows.Forms.Panel pnProdutos;
		private System.Windows.Forms.Button bnCDBalca;
		private System.Windows.Forms.Label labTitulo;
		private System.Windows.Forms.Button bnCSVenda;
		private System.Windows.Forms.Button bnCDVenda;
		private System.Windows.Forms.Label labVenda;
		private System.Windows.Forms.Panel pnVendas;
	}
}
