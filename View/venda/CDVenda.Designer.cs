
namespace GM.View.venda
{
	partial class CDVenda
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDVenda));
			this.gpCliente = new System.Windows.Forms.GroupBox();
			this.btnBuscaEndereco = new Sunny.UI.UISymbolButton();
			this.btnAbrir = new Sunny.UI.UISymbolButton();
			this.labEndereco = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.labCliente = new System.Windows.Forms.Label();
			this.txtCodigoEndereco = new System.Windows.Forms.TextBox();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.txtCodigoCliente = new System.Windows.Forms.TextBox();
			this.gpCabecalho = new System.Windows.Forms.GroupBox();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.labObservacao = new System.Windows.Forms.Label();
			this.labData = new System.Windows.Forms.Label();
			this.txtData = new System.Windows.Forms.TextBox();
			this.labSede = new System.Windows.Forms.Label();
			this.cbxSede = new System.Windows.Forms.ComboBox();
			this.gpProduto = new System.Windows.Forms.GroupBox();
			this.cbxProdutoCodigo = new System.Windows.Forms.ComboBox();
			this.btnAdicionarProduto = new Sunny.UI.UISymbolButton();
			this.btnLimpar = new Sunny.UI.UISymbolButton();
			this.btnExcluir = new Sunny.UI.UISymbolButton();
			this.labPreco = new System.Windows.Forms.Label();
			this.txtPreco = new System.Windows.Forms.TextBox();
			this.labQuantidade = new System.Windows.Forms.Label();
			this.cbxProduto = new System.Windows.Forms.ComboBox();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.labProduto = new System.Windows.Forms.Label();
			this.listaProduto = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.gpResumo = new System.Windows.Forms.GroupBox();
			this.listaParcela = new System.Windows.Forms.ListView();
			this.ColV1 = new System.Windows.Forms.ColumnHeader();
			this.ColV2 = new System.Windows.Forms.ColumnHeader();
			this.ColV3 = new System.Windows.Forms.ColumnHeader();
			this.btnVenda = new Sunny.UI.UISymbolButton();
			this.labCondicao = new System.Windows.Forms.Label();
			this.labTotal = new System.Windows.Forms.Label();
			this.cbxCondicao = new System.Windows.Forms.ComboBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.gpCliente.SuspendLayout();
			this.gpCabecalho.SuspendLayout();
			this.gpProduto.SuspendLayout();
			this.gpResumo.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpCliente
			// 
			this.gpCliente.BackColor = System.Drawing.Color.Transparent;
			this.gpCliente.Controls.Add(this.btnBuscaEndereco);
			this.gpCliente.Controls.Add(this.btnAbrir);
			this.gpCliente.Controls.Add(this.labEndereco);
			this.gpCliente.Controls.Add(this.txtEndereco);
			this.gpCliente.Controls.Add(this.labCliente);
			this.gpCliente.Controls.Add(this.txtCodigoEndereco);
			this.gpCliente.Controls.Add(this.txtCliente);
			this.gpCliente.Controls.Add(this.txtCodigoCliente);
			this.gpCliente.Location = new System.Drawing.Point(12, 75);
			this.gpCliente.Name = "gpCliente";
			this.gpCliente.Size = new System.Drawing.Size(462, 82);
			this.gpCliente.TabIndex = 0;
			this.gpCliente.TabStop = false;
			this.gpCliente.Text = "Cliente";
			// 
			// btnBuscaEndereco
			// 
			this.btnBuscaEndereco.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscaEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnBuscaEndereco.Location = new System.Drawing.Point(171, 48);
			this.btnBuscaEndereco.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnBuscaEndereco.Name = "btnBuscaEndereco";
			this.btnBuscaEndereco.Radius = 0;
			this.btnBuscaEndereco.Size = new System.Drawing.Size(41, 23);
			this.btnBuscaEndereco.Symbol = 61442;
			this.btnBuscaEndereco.TabIndex = 40;
			this.btnBuscaEndereco.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnBuscaEndereco.Click += new System.EventHandler(this.cliqueBuscaEndereco);
			// 
			// btnAbrir
			// 
			this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Location = new System.Drawing.Point(130, 19);
			this.btnAbrir.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Radius = 0;
			this.btnAbrir.Size = new System.Drawing.Size(41, 23);
			this.btnAbrir.Symbol = 61442;
			this.btnAbrir.TabIndex = 36;
			this.btnAbrir.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Click += new System.EventHandler(this.buscaCliente);
			// 
			// labEndereco
			// 
			this.labEndereco.Location = new System.Drawing.Point(6, 48);
			this.labEndereco.Name = "labEndereco";
			this.labEndereco.Size = new System.Drawing.Size(73, 23);
			this.labEndereco.TabIndex = 38;
			this.labEndereco.Text = "Endereço :";
			this.labEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEndereco
			// 
			this.txtEndereco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtEndereco.Location = new System.Drawing.Point(218, 48);
			this.txtEndereco.MaxLength = 50;
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.ReadOnly = true;
			this.txtEndereco.Size = new System.Drawing.Size(238, 23);
			this.txtEndereco.TabIndex = 39;
			// 
			// labCliente
			// 
			this.labCliente.Location = new System.Drawing.Point(6, 19);
			this.labCliente.Name = "labCliente";
			this.labCliente.Size = new System.Drawing.Size(73, 23);
			this.labCliente.TabIndex = 34;
			this.labCliente.Text = "Cliente :";
			this.labCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigoEndereco
			// 
			this.txtCodigoEndereco.Location = new System.Drawing.Point(85, 48);
			this.txtCodigoEndereco.MaxLength = 10;
			this.txtCodigoEndereco.Name = "txtCodigoEndereco";
			this.txtCodigoEndereco.Size = new System.Drawing.Size(86, 23);
			this.txtCodigoEndereco.TabIndex = 37;
			this.txtCodigoEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCodigoEndereco.Leave += new System.EventHandler(this.leaveBuscaEndereco);
			// 
			// txtCliente
			// 
			this.txtCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtCliente.Location = new System.Drawing.Point(177, 19);
			this.txtCliente.MaxLength = 50;
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.ReadOnly = true;
			this.txtCliente.Size = new System.Drawing.Size(279, 23);
			this.txtCliente.TabIndex = 35;
			// 
			// txtCodigoCliente
			// 
			this.txtCodigoCliente.Location = new System.Drawing.Point(85, 19);
			this.txtCodigoCliente.MaxLength = 50;
			this.txtCodigoCliente.Name = "txtCodigoCliente";
			this.txtCodigoCliente.Size = new System.Drawing.Size(45, 23);
			this.txtCodigoCliente.TabIndex = 33;
			this.txtCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCodigoCliente.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCodigoCliente.Leave += new System.EventHandler(this.buscaClienteCodigo);
			// 
			// gpCabecalho
			// 
			this.gpCabecalho.BackColor = System.Drawing.Color.Transparent;
			this.gpCabecalho.Controls.Add(this.txtObservacao);
			this.gpCabecalho.Controls.Add(this.labObservacao);
			this.gpCabecalho.Controls.Add(this.labData);
			this.gpCabecalho.Controls.Add(this.txtData);
			this.gpCabecalho.Controls.Add(this.labSede);
			this.gpCabecalho.Controls.Add(this.cbxSede);
			this.gpCabecalho.Location = new System.Drawing.Point(480, 75);
			this.gpCabecalho.Name = "gpCabecalho";
			this.gpCabecalho.Size = new System.Drawing.Size(361, 196);
			this.gpCabecalho.TabIndex = 1;
			this.gpCabecalho.TabStop = false;
			this.gpCabecalho.Text = "Cabeçalho da venda";
			// 
			// txtObservacao
			// 
			this.txtObservacao.Location = new System.Drawing.Point(6, 97);
			this.txtObservacao.MaxLength = 200;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(349, 93);
			this.txtObservacao.TabIndex = 44;
			// 
			// labObservacao
			// 
			this.labObservacao.Location = new System.Drawing.Point(6, 71);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(86, 23);
			this.labObservacao.TabIndex = 43;
			this.labObservacao.Text = "Observações :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labData
			// 
			this.labData.Location = new System.Drawing.Point(19, 48);
			this.labData.Name = "labData";
			this.labData.Size = new System.Drawing.Size(73, 23);
			this.labData.TabIndex = 42;
			this.labData.Text = "Data :";
			this.labData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(98, 48);
			this.txtData.MaxLength = 15;
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(118, 23);
			this.txtData.TabIndex = 41;
			this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtData.TextChanged += new System.EventHandler(this.maskData);
			// 
			// labSede
			// 
			this.labSede.Location = new System.Drawing.Point(19, 19);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(73, 23);
			this.labSede.TabIndex = 3;
			this.labSede.Text = "Sede :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSede
			// 
			this.cbxSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSede.FormattingEnabled = true;
			this.cbxSede.Location = new System.Drawing.Point(98, 19);
			this.cbxSede.Name = "cbxSede";
			this.cbxSede.Size = new System.Drawing.Size(166, 23);
			this.cbxSede.TabIndex = 2;
			// 
			// gpProduto
			// 
			this.gpProduto.BackColor = System.Drawing.Color.Transparent;
			this.gpProduto.Controls.Add(this.cbxProdutoCodigo);
			this.gpProduto.Controls.Add(this.btnAdicionarProduto);
			this.gpProduto.Controls.Add(this.btnLimpar);
			this.gpProduto.Controls.Add(this.btnExcluir);
			this.gpProduto.Controls.Add(this.labPreco);
			this.gpProduto.Controls.Add(this.txtPreco);
			this.gpProduto.Controls.Add(this.labQuantidade);
			this.gpProduto.Controls.Add(this.cbxProduto);
			this.gpProduto.Controls.Add(this.txtQuantidade);
			this.gpProduto.Controls.Add(this.labProduto);
			this.gpProduto.Controls.Add(this.listaProduto);
			this.gpProduto.Location = new System.Drawing.Point(12, 163);
			this.gpProduto.Name = "gpProduto";
			this.gpProduto.Size = new System.Drawing.Size(462, 370);
			this.gpProduto.TabIndex = 2;
			this.gpProduto.TabStop = false;
			this.gpProduto.Text = "Produtos";
			// 
			// cbxProdutoCodigo
			// 
			this.cbxProdutoCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxProdutoCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxProdutoCodigo.FormattingEnabled = true;
			this.cbxProdutoCodigo.Location = new System.Drawing.Point(81, 22);
			this.cbxProdutoCodigo.Name = "cbxProdutoCodigo";
			this.cbxProdutoCodigo.Size = new System.Drawing.Size(90, 23);
			this.cbxProdutoCodigo.TabIndex = 53;
			this.cbxProdutoCodigo.SelectedIndexChanged += new System.EventHandler(this.selectProduto);
			// 
			// btnAdicionarProduto
			// 
			this.btnAdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionarProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAdicionarProduto.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAdicionarProduto.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionarProduto.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAdicionarProduto.Location = new System.Drawing.Point(359, 79);
			this.btnAdicionarProduto.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionarProduto.Name = "btnAdicionarProduto";
			this.btnAdicionarProduto.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnAdicionarProduto.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAdicionarProduto.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAdicionarProduto.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionarProduto.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionarProduto.Size = new System.Drawing.Size(97, 23);
			this.btnAdicionarProduto.Style = Sunny.UI.UIStyle.Green;
			this.btnAdicionarProduto.Symbol = 61543;
			this.btnAdicionarProduto.SymbolSize = 0;
			this.btnAdicionarProduto.TabIndex = 52;
			this.btnAdicionarProduto.Text = "Adicionar";
			this.btnAdicionarProduto.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAdicionarProduto.Click += new System.EventHandler(this.cliqueAdicionar);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnLimpar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnLimpar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnLimpar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnLimpar.Location = new System.Drawing.Point(96, 80);
			this.btnLimpar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnLimpar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnLimpar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnLimpar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnLimpar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnLimpar.Size = new System.Drawing.Size(81, 23);
			this.btnLimpar.Style = Sunny.UI.UIStyle.Red;
			this.btnLimpar.Symbol = 61543;
			this.btnLimpar.SymbolSize = 0;
			this.btnLimpar.TabIndex = 51;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnLimpar.Click += new System.EventHandler(this.cliqueLimpar);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnExcluir.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnExcluir.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnExcluir.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnExcluir.Location = new System.Drawing.Point(9, 80);
			this.btnExcluir.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnExcluir.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnExcluir.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnExcluir.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnExcluir.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnExcluir.Size = new System.Drawing.Size(81, 23);
			this.btnExcluir.Style = Sunny.UI.UIStyle.Red;
			this.btnExcluir.Symbol = 61543;
			this.btnExcluir.SymbolSize = 0;
			this.btnExcluir.TabIndex = 50;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnExcluir.Click += new System.EventHandler(this.cliqueExcluirProduto);
			// 
			// labPreco
			// 
			this.labPreco.Location = new System.Drawing.Point(240, 51);
			this.labPreco.Name = "labPreco";
			this.labPreco.Size = new System.Drawing.Size(83, 23);
			this.labPreco.TabIndex = 49;
			this.labPreco.Text = "Preço (R$) :";
			this.labPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPreco
			// 
			this.txtPreco.Location = new System.Drawing.Point(325, 51);
			this.txtPreco.MaxLength = 10;
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(131, 23);
			this.txtPreco.TabIndex = 48;
			this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPreco.TextChanged += new System.EventHandler(this.maskMoney);
			// 
			// labQuantidade
			// 
			this.labQuantidade.Location = new System.Drawing.Point(3, 51);
			this.labQuantidade.Name = "labQuantidade";
			this.labQuantidade.Size = new System.Drawing.Size(76, 23);
			this.labQuantidade.TabIndex = 42;
			this.labQuantidade.Text = "Quantidade :";
			this.labQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxProduto
			// 
			this.cbxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxProduto.FormattingEnabled = true;
			this.cbxProduto.Location = new System.Drawing.Point(177, 22);
			this.cbxProduto.Name = "cbxProduto";
			this.cbxProduto.Size = new System.Drawing.Size(279, 23);
			this.cbxProduto.TabIndex = 47;
			this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.selectProduto);
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(81, 51);
			this.txtQuantidade.MaxLength = 10;
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(153, 23);
			this.txtQuantidade.TabIndex = 41;
			this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtQuantidade.TextChanged += new System.EventHandler(this.maskQuantidade);
			// 
			// labProduto
			// 
			this.labProduto.Location = new System.Drawing.Point(6, 22);
			this.labProduto.Name = "labProduto";
			this.labProduto.Size = new System.Drawing.Size(73, 23);
			this.labProduto.TabIndex = 46;
			this.labProduto.Text = "Produto :";
			this.labProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listaProduto
			// 
			this.listaProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04});
			this.listaProduto.FullRowSelect = true;
			this.listaProduto.GridLines = true;
			this.listaProduto.Location = new System.Drawing.Point(9, 108);
			this.listaProduto.MultiSelect = false;
			this.listaProduto.Name = "listaProduto";
			this.listaProduto.Size = new System.Drawing.Size(447, 256);
			this.listaProduto.TabIndex = 0;
			this.listaProduto.UseCompatibleStateImageBehavior = false;
			this.listaProduto.View = System.Windows.Forms.View.Details;
			// 
			// Col01
			// 
			this.Col01.Text = "Quantidade";
			this.Col01.Width = 90;
			// 
			// Col02
			// 
			this.Col02.Text = "Produto";
			this.Col02.Width = 140;
			// 
			// Col03
			// 
			this.Col03.Text = "Preço Un(R$)";
			this.Col03.Width = 90;
			// 
			// Col04
			// 
			this.Col04.Text = "Vlr Total (R$)";
			this.Col04.Width = 90;
			// 
			// gpResumo
			// 
			this.gpResumo.BackColor = System.Drawing.Color.Transparent;
			this.gpResumo.Controls.Add(this.listaParcela);
			this.gpResumo.Controls.Add(this.btnVenda);
			this.gpResumo.Controls.Add(this.labCondicao);
			this.gpResumo.Controls.Add(this.labTotal);
			this.gpResumo.Controls.Add(this.cbxCondicao);
			this.gpResumo.Controls.Add(this.txtTotal);
			this.gpResumo.Location = new System.Drawing.Point(480, 277);
			this.gpResumo.Name = "gpResumo";
			this.gpResumo.Size = new System.Drawing.Size(361, 256);
			this.gpResumo.TabIndex = 3;
			this.gpResumo.TabStop = false;
			this.gpResumo.Text = "Resumo e finalização";
			// 
			// listaParcela
			// 
			this.listaParcela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColV1,
									this.ColV2,
									this.ColV3});
			this.listaParcela.FullRowSelect = true;
			this.listaParcela.GridLines = true;
			this.listaParcela.Location = new System.Drawing.Point(19, 80);
			this.listaParcela.MultiSelect = false;
			this.listaParcela.Name = "listaParcela";
			this.listaParcela.Size = new System.Drawing.Size(322, 142);
			this.listaParcela.TabIndex = 53;
			this.listaParcela.UseCompatibleStateImageBehavior = false;
			this.listaParcela.View = System.Windows.Forms.View.Details;
			// 
			// ColV1
			// 
			this.ColV1.Text = "Vencimento";
			this.ColV1.Width = 80;
			// 
			// ColV2
			// 
			this.ColV2.Text = "P/";
			this.ColV2.Width = 25;
			// 
			// ColV3
			// 
			this.ColV3.Text = "Valor Parcela (R$)";
			this.ColV3.Width = 150;
			// 
			// btnVenda
			// 
			this.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVenda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnVenda.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnVenda.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnVenda.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnVenda.Location = new System.Drawing.Point(19, 227);
			this.btnVenda.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnVenda.Name = "btnVenda";
			this.btnVenda.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnVenda.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnVenda.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnVenda.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnVenda.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnVenda.Size = new System.Drawing.Size(322, 23);
			this.btnVenda.Style = Sunny.UI.UIStyle.Green;
			this.btnVenda.Symbol = 61543;
			this.btnVenda.SymbolSize = 0;
			this.btnVenda.TabIndex = 53;
			this.btnVenda.Text = "Salvar Venda";
			this.btnVenda.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnVenda.Click += new System.EventHandler(this.cliqueSalvarVenda);
			// 
			// labCondicao
			// 
			this.labCondicao.Location = new System.Drawing.Point(19, 51);
			this.labCondicao.Name = "labCondicao";
			this.labCondicao.Size = new System.Drawing.Size(113, 23);
			this.labCondicao.TabIndex = 46;
			this.labCondicao.Text = "Cond. Pagamento :";
			this.labCondicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labTotal
			// 
			this.labTotal.Location = new System.Drawing.Point(29, 22);
			this.labTotal.Name = "labTotal";
			this.labTotal.Size = new System.Drawing.Size(103, 23);
			this.labTotal.TabIndex = 46;
			this.labTotal.Text = "Valor Total (R$) :";
			this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCondicao
			// 
			this.cbxCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCondicao.FormattingEnabled = true;
			this.cbxCondicao.Location = new System.Drawing.Point(138, 51);
			this.cbxCondicao.Name = "cbxCondicao";
			this.cbxCondicao.Size = new System.Drawing.Size(203, 23);
			this.cbxCondicao.TabIndex = 45;
			this.cbxCondicao.SelectedIndexChanged += new System.EventHandler(this.trocaCondicao);
			// 
			// txtTotal
			// 
			this.txtTotal.BackColor = System.Drawing.Color.White;
			this.txtTotal.Location = new System.Drawing.Point(138, 22);
			this.txtTotal.MaxLength = 15;
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(147, 23);
			this.txtTotal.TabIndex = 45;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CDVenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 544);
			this.Controls.Add(this.gpResumo);
			this.Controls.Add(this.gpProduto);
			this.Controls.Add(this.gpCabecalho);
			this.Controls.Add(this.gpCliente);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDVenda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro / Edição de pedido de venda";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.gpCliente.ResumeLayout(false);
			this.gpCliente.PerformLayout();
			this.gpCabecalho.ResumeLayout(false);
			this.gpCabecalho.PerformLayout();
			this.gpProduto.ResumeLayout(false);
			this.gpProduto.PerformLayout();
			this.gpResumo.ResumeLayout(false);
			this.gpResumo.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cbxProdutoCodigo;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.ComboBox cbxCondicao;
		private System.Windows.Forms.Label labTotal;
		private System.Windows.Forms.Label labCondicao;
		private Sunny.UI.UISymbolButton btnVenda;
		private System.Windows.Forms.ColumnHeader ColV3;
		private System.Windows.Forms.ColumnHeader ColV2;
		private System.Windows.Forms.ColumnHeader ColV1;
		private System.Windows.Forms.ListView listaParcela;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private Sunny.UI.UISymbolButton btnExcluir;
		private Sunny.UI.UISymbolButton btnLimpar;
		private Sunny.UI.UISymbolButton btnAdicionarProduto;
		private System.Windows.Forms.ListView listaProduto;
		private System.Windows.Forms.Label labProduto;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.ComboBox cbxProduto;
		private System.Windows.Forms.Label labQuantidade;
		private System.Windows.Forms.TextBox txtPreco;
		private System.Windows.Forms.Label labPreco;
		private System.Windows.Forms.GroupBox gpResumo;
		private System.Windows.Forms.GroupBox gpProduto;
		private System.Windows.Forms.Label labObservacao;
		private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Label labData;
		private System.Windows.Forms.ComboBox cbxSede;
		private System.Windows.Forms.Label labSede;
		private System.Windows.Forms.GroupBox gpCabecalho;
		private System.Windows.Forms.TextBox txtCodigoCliente;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.TextBox txtCodigoEndereco;
		private System.Windows.Forms.Label labCliente;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.Label labEndereco;
		private Sunny.UI.UISymbolButton btnAbrir;
		private Sunny.UI.UISymbolButton btnBuscaEndereco;
		private System.Windows.Forms.GroupBox gpCliente;
	}
}
