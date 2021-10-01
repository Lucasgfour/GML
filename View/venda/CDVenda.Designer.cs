
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
			this.labEndereco = new System.Windows.Forms.Label();
			this.txtEndereco = new GM.Componentes.MinBox();
			this.labCliente = new System.Windows.Forms.Label();
			this.txtCodigoEndereco = new GM.Componentes.MinBox();
			this.txtCliente = new GM.Componentes.MinBox();
			this.txtCodigoCliente = new GM.Componentes.MinBox();
			this.txtObservacao = new GM.Componentes.MinBox();
			this.labObservacao = new System.Windows.Forms.Label();
			this.labData = new System.Windows.Forms.Label();
			this.txtData = new GM.Componentes.MinBox();
			this.labSede = new System.Windows.Forms.Label();
			this.cbxSede = new GM.Componentes.MinComboBox();
			this.cbxProdutoCodigo = new System.Windows.Forms.ComboBox();
			this.labPreco = new System.Windows.Forms.Label();
			this.txtPreco = new GM.Componentes.MinBox();
			this.labQuantidade = new System.Windows.Forms.Label();
			this.cbxProduto = new System.Windows.Forms.ComboBox();
			this.txtQuantidade = new GM.Componentes.MinBox();
			this.labProduto = new System.Windows.Forms.Label();
			this.listaProduto = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.listaParcela = new System.Windows.Forms.ListView();
			this.ColV1 = new System.Windows.Forms.ColumnHeader();
			this.ColV2 = new System.Windows.Forms.ColumnHeader();
			this.ColV3 = new System.Windows.Forms.ColumnHeader();
			this.labCondicao = new System.Windows.Forms.Label();
			this.labTotal = new System.Windows.Forms.Label();
			this.cbxCondicao = new GM.Componentes.MinComboBox();
			this.txtTotal = new GM.Componentes.MinBox();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnSalvarPedido = new MaterialSkin.Controls.MaterialRaisedButton();
			this.labVencimento = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labEndereco
			// 
			this.labEndereco.BackColor = System.Drawing.Color.Transparent;
			this.labEndereco.Location = new System.Drawing.Point(12, 132);
			this.labEndereco.Name = "labEndereco";
			this.labEndereco.Size = new System.Drawing.Size(67, 28);
			this.labEndereco.TabIndex = 38;
			this.labEndereco.Text = "Endereço :";
			this.labEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEndereco
			// 
			this.txtEndereco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtEndereco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtEndereco.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtEndereco.CustomBGColor = System.Drawing.Color.White;
			this.txtEndereco.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtEndereco.ForeColor = System.Drawing.Color.Black;
			this.txtEndereco.Location = new System.Drawing.Point(197, 132);
			this.txtEndereco.MaxLength = 50;
			this.txtEndereco.Multiline = false;
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.ReadOnly = true;
			this.txtEndereco.SelectionStart = 0;
			this.txtEndereco.Size = new System.Drawing.Size(221, 26);
			this.txtEndereco.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtEndereco.TabIndex = 39;
			this.txtEndereco.TabStop = false;
			this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEndereco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEndereco.UseSystemPasswordChar = false;
			// 
			// labCliente
			// 
			this.labCliente.BackColor = System.Drawing.Color.Transparent;
			this.labCliente.Location = new System.Drawing.Point(12, 100);
			this.labCliente.Name = "labCliente";
			this.labCliente.Size = new System.Drawing.Size(67, 28);
			this.labCliente.TabIndex = 34;
			this.labCliente.Text = "Cliente :";
			this.labCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigoEndereco
			// 
			this.txtCodigoEndereco.BackColor = System.Drawing.Color.Transparent;
			this.txtCodigoEndereco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigoEndereco.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigoEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigoEndereco.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigoEndereco.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtCodigoEndereco.ForeColor = System.Drawing.Color.Black;
			this.txtCodigoEndereco.Location = new System.Drawing.Point(81, 132);
			this.txtCodigoEndereco.MaxLength = 10;
			this.txtCodigoEndereco.Multiline = false;
			this.txtCodigoEndereco.Name = "txtCodigoEndereco";
			this.txtCodigoEndereco.ReadOnly = false;
			this.txtCodigoEndereco.SelectionStart = 0;
			this.txtCodigoEndereco.Size = new System.Drawing.Size(86, 26);
			this.txtCodigoEndereco.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigoEndereco.TabIndex = 5;
			this.txtCodigoEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoEndereco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoEndereco.UseSystemPasswordChar = false;
			this.txtCodigoEndereco.Leave += new System.EventHandler(this.leaveBuscaEndereco);
			// 
			// txtCliente
			// 
			this.txtCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCliente.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCliente.CustomBGColor = System.Drawing.Color.White;
			this.txtCliente.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtCliente.ForeColor = System.Drawing.Color.Black;
			this.txtCliente.Location = new System.Drawing.Point(197, 100);
			this.txtCliente.MaxLength = 50;
			this.txtCliente.Multiline = false;
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.ReadOnly = true;
			this.txtCliente.SelectionStart = 0;
			this.txtCliente.Size = new System.Drawing.Size(221, 26);
			this.txtCliente.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCliente.TabIndex = 35;
			this.txtCliente.TabStop = false;
			this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCliente.UseSystemPasswordChar = false;
			// 
			// txtCodigoCliente
			// 
			this.txtCodigoCliente.BackColor = System.Drawing.Color.Transparent;
			this.txtCodigoCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigoCliente.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigoCliente.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigoCliente.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtCodigoCliente.ForeColor = System.Drawing.Color.Black;
			this.txtCodigoCliente.Location = new System.Drawing.Point(80, 100);
			this.txtCodigoCliente.MaxLength = 50;
			this.txtCodigoCliente.Multiline = false;
			this.txtCodigoCliente.Name = "txtCodigoCliente";
			this.txtCodigoCliente.ReadOnly = false;
			this.txtCodigoCliente.SelectionStart = 0;
			this.txtCodigoCliente.Size = new System.Drawing.Size(87, 26);
			this.txtCodigoCliente.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigoCliente.TabIndex = 3;
			this.txtCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoCliente.UseSystemPasswordChar = false;
			this.txtCodigoCliente.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCodigoCliente.Leave += new System.EventHandler(this.buscaClienteCodigo);
			// 
			// txtObservacao
			// 
			this.txtObservacao.BackColor = System.Drawing.Color.Transparent;
			this.txtObservacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtObservacao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CustomBGColor = System.Drawing.Color.White;
			this.txtObservacao.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtObservacao.ForeColor = System.Drawing.Color.Black;
			this.txtObservacao.Location = new System.Drawing.Point(424, 94);
			this.txtObservacao.MaxLength = 200;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.ReadOnly = false;
			this.txtObservacao.SelectionStart = 0;
			this.txtObservacao.Size = new System.Drawing.Size(326, 64);
			this.txtObservacao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtObservacao.TabIndex = 44;
			this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.UseSystemPasswordChar = false;
			// 
			// labObservacao
			// 
			this.labObservacao.BackColor = System.Drawing.Color.Transparent;
			this.labObservacao.Location = new System.Drawing.Point(424, 68);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(86, 23);
			this.labObservacao.TabIndex = 43;
			this.labObservacao.Text = "Observações :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labData
			// 
			this.labData.BackColor = System.Drawing.Color.Transparent;
			this.labData.Location = new System.Drawing.Point(12, 68);
			this.labData.Name = "labData";
			this.labData.Size = new System.Drawing.Size(62, 28);
			this.labData.TabIndex = 42;
			this.labData.Text = "Data :";
			this.labData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtData
			// 
			this.txtData.BackColor = System.Drawing.Color.Transparent;
			this.txtData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtData.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtData.CustomBGColor = System.Drawing.Color.White;
			this.txtData.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtData.ForeColor = System.Drawing.Color.Black;
			this.txtData.Location = new System.Drawing.Point(80, 68);
			this.txtData.MaxLength = 15;
			this.txtData.Multiline = false;
			this.txtData.Name = "txtData";
			this.txtData.ReadOnly = false;
			this.txtData.SelectionStart = 0;
			this.txtData.Size = new System.Drawing.Size(118, 26);
			this.txtData.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtData.TabIndex = 1;
			this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtData.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtData.UseSystemPasswordChar = false;
			this.txtData.TextChanged += new System.EventHandler(this.maskData);
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Location = new System.Drawing.Point(204, 68);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(42, 28);
			this.labSede.TabIndex = 3;
			this.labSede.Text = "Loja :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSede
			// 
			this.cbxSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxSede.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSede.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSede.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxSede.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxSede.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxSede.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSede.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSede.ColorH = System.Drawing.Color.White;
			this.cbxSede.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxSede.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxSede.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxSede.DropDownHeight = 100;
			this.cbxSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSede.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSede.ForeColor = System.Drawing.Color.Black;
			this.cbxSede.FormattingEnabled = true;
			this.cbxSede.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxSede.IntegralHeight = false;
			this.cbxSede.ItemHeight = 20;
			this.cbxSede.Location = new System.Drawing.Point(252, 68);
			this.cbxSede.Name = "cbxSede";
			this.cbxSede.Size = new System.Drawing.Size(166, 26);
			this.cbxSede.StartIndex = 0;
			this.cbxSede.TabIndex = 2;
			// 
			// cbxProdutoCodigo
			// 
			this.cbxProdutoCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxProdutoCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxProdutoCodigo.FormattingEnabled = true;
			this.cbxProdutoCodigo.Location = new System.Drawing.Point(81, 167);
			this.cbxProdutoCodigo.Name = "cbxProdutoCodigo";
			this.cbxProdutoCodigo.Size = new System.Drawing.Size(90, 23);
			this.cbxProdutoCodigo.TabIndex = 7;
			this.cbxProdutoCodigo.SelectedIndexChanged += new System.EventHandler(this.selectProduto);
			this.cbxProdutoCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterProduto);
			// 
			// labPreco
			// 
			this.labPreco.BackColor = System.Drawing.Color.Transparent;
			this.labPreco.Location = new System.Drawing.Point(533, 162);
			this.labPreco.Name = "labPreco";
			this.labPreco.Size = new System.Drawing.Size(45, 28);
			this.labPreco.TabIndex = 49;
			this.labPreco.Text = "Valor :";
			this.labPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPreco
			// 
			this.txtPreco.BackColor = System.Drawing.Color.Transparent;
			this.txtPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtPreco.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPreco.CustomBGColor = System.Drawing.Color.White;
			this.txtPreco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPreco.ForeColor = System.Drawing.Color.Black;
			this.txtPreco.Location = new System.Drawing.Point(578, 164);
			this.txtPreco.MaxLength = 10;
			this.txtPreco.Multiline = false;
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.ReadOnly = false;
			this.txtPreco.SelectionStart = 0;
			this.txtPreco.Size = new System.Drawing.Size(80, 26);
			this.txtPreco.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPreco.TabIndex = 10;
			this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPreco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPreco.UseSystemPasswordChar = false;
			this.txtPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterProduto);
			this.txtPreco.TextChanged += new System.EventHandler(this.maskMoney);
			// 
			// labQuantidade
			// 
			this.labQuantidade.BackColor = System.Drawing.Color.Transparent;
			this.labQuantidade.Location = new System.Drawing.Point(394, 162);
			this.labQuantidade.Name = "labQuantidade";
			this.labQuantidade.Size = new System.Drawing.Size(54, 28);
			this.labQuantidade.TabIndex = 42;
			this.labQuantidade.Text = "Quant. :";
			this.labQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxProduto
			// 
			this.cbxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxProduto.FormattingEnabled = true;
			this.cbxProduto.Location = new System.Drawing.Point(177, 167);
			this.cbxProduto.Name = "cbxProduto";
			this.cbxProduto.Size = new System.Drawing.Size(212, 23);
			this.cbxProduto.TabIndex = 8;
			this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.selectProduto);
			this.cbxProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterProduto);
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.BackColor = System.Drawing.Color.Transparent;
			this.txtQuantidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtQuantidade.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtQuantidade.CustomBGColor = System.Drawing.Color.White;
			this.txtQuantidade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
			this.txtQuantidade.Location = new System.Drawing.Point(450, 164);
			this.txtQuantidade.MaxLength = 10;
			this.txtQuantidade.Multiline = false;
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.ReadOnly = false;
			this.txtQuantidade.SelectionStart = 0;
			this.txtQuantidade.Size = new System.Drawing.Size(81, 26);
			this.txtQuantidade.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtQuantidade.TabIndex = 9;
			this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtQuantidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtQuantidade.UseSystemPasswordChar = false;
			this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterProduto);
			this.txtQuantidade.TextChanged += new System.EventHandler(this.maskQuantidade);
			// 
			// labProduto
			// 
			this.labProduto.BackColor = System.Drawing.Color.Transparent;
			this.labProduto.Location = new System.Drawing.Point(6, 168);
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
			this.listaProduto.Location = new System.Drawing.Point(80, 196);
			this.listaProduto.MultiSelect = false;
			this.listaProduto.Name = "listaProduto";
			this.listaProduto.Size = new System.Drawing.Size(669, 256);
			this.listaProduto.TabIndex = 12;
			this.listaProduto.UseCompatibleStateImageBehavior = false;
			this.listaProduto.View = System.Windows.Forms.View.Details;
			// 
			// Col01
			// 
			this.Col01.Text = "Quantidade";
			this.Col01.Width = 100;
			// 
			// Col02
			// 
			this.Col02.Text = "Descrição do Produto";
			this.Col02.Width = 290;
			// 
			// Col03
			// 
			this.Col03.Text = "Preço Unidade (R$)";
			this.Col03.Width = 120;
			// 
			// Col04
			// 
			this.Col04.Text = "Valor Total (R$)";
			this.Col04.Width = 120;
			// 
			// listaParcela
			// 
			this.listaParcela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColV1,
									this.ColV2,
									this.ColV3});
			this.listaParcela.FullRowSelect = true;
			this.listaParcela.GridLines = true;
			this.listaParcela.Location = new System.Drawing.Point(81, 458);
			this.listaParcela.MultiSelect = false;
			this.listaParcela.Name = "listaParcela";
			this.listaParcela.Size = new System.Drawing.Size(322, 138);
			this.listaParcela.TabIndex = 53;
			this.listaParcela.TabStop = false;
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
			// labCondicao
			// 
			this.labCondicao.BackColor = System.Drawing.Color.Transparent;
			this.labCondicao.Location = new System.Drawing.Point(409, 458);
			this.labCondicao.Name = "labCondicao";
			this.labCondicao.Size = new System.Drawing.Size(113, 26);
			this.labCondicao.TabIndex = 46;
			this.labCondicao.Text = "Cond. Pagamento :";
			this.labCondicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labTotal
			// 
			this.labTotal.BackColor = System.Drawing.Color.Transparent;
			this.labTotal.Location = new System.Drawing.Point(419, 490);
			this.labTotal.Name = "labTotal";
			this.labTotal.Size = new System.Drawing.Size(103, 28);
			this.labTotal.TabIndex = 46;
			this.labTotal.Text = "Valor Total (R$) :";
			this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCondicao
			// 
			this.cbxCondicao.BackColor = System.Drawing.Color.White;
			this.cbxCondicao.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxCondicao.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxCondicao.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxCondicao.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxCondicao.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxCondicao.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxCondicao.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxCondicao.ColorH = System.Drawing.Color.White;
			this.cbxCondicao.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxCondicao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxCondicao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxCondicao.DropDownHeight = 100;
			this.cbxCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCondicao.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbxCondicao.ForeColor = System.Drawing.Color.Black;
			this.cbxCondicao.FormattingEnabled = true;
			this.cbxCondicao.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxCondicao.IntegralHeight = false;
			this.cbxCondicao.ItemHeight = 20;
			this.cbxCondicao.Location = new System.Drawing.Point(528, 458);
			this.cbxCondicao.Name = "cbxCondicao";
			this.cbxCondicao.Size = new System.Drawing.Size(222, 26);
			this.cbxCondicao.StartIndex = 0;
			this.cbxCondicao.TabIndex = 15;
			this.cbxCondicao.SelectedIndexChanged += new System.EventHandler(this.trocaCondicao);
			// 
			// txtTotal
			// 
			this.txtTotal.BackColor = System.Drawing.Color.White;
			this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtTotal.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtTotal.CustomBGColor = System.Drawing.Color.White;
			this.txtTotal.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtTotal.ForeColor = System.Drawing.Color.Black;
			this.txtTotal.Location = new System.Drawing.Point(528, 490);
			this.txtTotal.MaxLength = 16;
			this.txtTotal.Multiline = false;
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.SelectionStart = 0;
			this.txtTotal.Size = new System.Drawing.Size(222, 26);
			this.txtTotal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtTotal.TabIndex = 45;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtTotal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtTotal.UseSystemPasswordChar = false;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
			this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnAdicionar.FlatAppearance.BorderSize = 0;
			this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdicionar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
			this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
			this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdicionar.Location = new System.Drawing.Point(661, 163);
			this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(88, 27);
			this.btnAdicionar.TabIndex = 11;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdicionar.UseVisualStyleBackColor = false;
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueAdicionar);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(168, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(28, 28);
			this.button1.TabIndex = 4;
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.buscaCliente);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(168, 132);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(28, 28);
			this.button2.TabIndex = 6;
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.cliqueBuscaEndereco);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
			this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.ForeColor = System.Drawing.Color.Black;
			this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
			this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpar.Location = new System.Drawing.Point(6, 196);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(73, 36);
			this.btnLimpar.TabIndex = 13;
			this.btnLimpar.Text = "Limpar\r\nTodos";
			this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.cliqueLimpar);
			// 
			// btnRemover
			// 
			this.btnRemover.BackColor = System.Drawing.Color.Transparent;
			this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnRemover.FlatAppearance.BorderSize = 0;
			this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemover.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnRemover.ForeColor = System.Drawing.Color.Black;
			this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
			this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemover.Location = new System.Drawing.Point(6, 238);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(73, 36);
			this.btnRemover.TabIndex = 14;
			this.btnRemover.Text = "Remover\r\nSelec.";
			this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemover.UseVisualStyleBackColor = false;
			this.btnRemover.Click += new System.EventHandler(this.cliqueExcluirProduto);
			// 
			// btnSalvarPedido
			// 
			this.btnSalvarPedido.Depth = 0;
			this.btnSalvarPedido.Location = new System.Drawing.Point(595, 568);
			this.btnSalvarPedido.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvarPedido.Name = "btnSalvarPedido";
			this.btnSalvarPedido.Primary = true;
			this.btnSalvarPedido.Size = new System.Drawing.Size(155, 28);
			this.btnSalvarPedido.TabIndex = 17;
			this.btnSalvarPedido.Text = "SALVAR PEDIDO";
			this.btnSalvarPedido.UseVisualStyleBackColor = true;
			this.btnSalvarPedido.Click += new System.EventHandler(this.cliqueSalvarVenda);
			// 
			// labVencimento
			// 
			this.labVencimento.BackColor = System.Drawing.Color.Transparent;
			this.labVencimento.Location = new System.Drawing.Point(2, 458);
			this.labVencimento.Name = "labVencimento";
			this.labVencimento.Size = new System.Drawing.Size(73, 23);
			this.labVencimento.TabIndex = 73;
			this.labVencimento.Text = "Parcelas :";
			this.labVencimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CDVenda
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(762, 608);
			this.Controls.Add(this.labVencimento);
			this.Controls.Add(this.btnSalvarPedido);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.cbxProdutoCodigo);
			this.Controls.Add(this.listaParcela);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.labCondicao);
			this.Controls.Add(this.labEndereco);
			this.Controls.Add(this.labPreco);
			this.Controls.Add(this.labTotal);
			this.Controls.Add(this.labObservacao);
			this.Controls.Add(this.cbxCondicao);
			this.Controls.Add(this.cbxProduto);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtQuantidade);
			this.Controls.Add(this.labData);
			this.Controls.Add(this.labProduto);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.listaProduto);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.cbxSede);
			this.Controls.Add(this.labCliente);
			this.Controls.Add(this.txtCodigoEndereco);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.txtCodigoCliente);
			this.Controls.Add(this.labQuantidade);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDVenda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro / Edição de pedido de venda";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labVencimento;
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvarPedido;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.ComboBox cbxProdutoCodigo;
		private GM.Componentes.MinBox txtTotal;
		private GM.Componentes.MinComboBox cbxCondicao;
		private System.Windows.Forms.Label labTotal;
		private System.Windows.Forms.Label labCondicao;
		private System.Windows.Forms.ColumnHeader ColV3;
		private System.Windows.Forms.ColumnHeader ColV2;
		private System.Windows.Forms.ColumnHeader ColV1;
		private System.Windows.Forms.ListView listaParcela;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaProduto;
		private System.Windows.Forms.Label labProduto;
		private GM.Componentes.MinBox txtQuantidade;
		private System.Windows.Forms.ComboBox cbxProduto;
		private System.Windows.Forms.Label labQuantidade;
		private GM.Componentes.MinBox txtPreco;
		private System.Windows.Forms.Label labPreco;
		private System.Windows.Forms.Label labObservacao;
		private GM.Componentes.MinBox txtObservacao;
		private GM.Componentes.MinBox txtData;
		private System.Windows.Forms.Label labData;
		private GM.Componentes.MinComboBox cbxSede;
		private System.Windows.Forms.Label labSede;
		private GM.Componentes.MinBox txtCodigoCliente;
		private GM.Componentes.MinBox txtCliente;
		private GM.Componentes.MinBox txtCodigoEndereco;
		private System.Windows.Forms.Label labCliente;
		private GM.Componentes.MinBox txtEndereco;
		private System.Windows.Forms.Label labEndereco;
	}
}
