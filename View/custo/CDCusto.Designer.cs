
namespace GM.View.custo
{
	partial class CDCusto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDCusto));
			this.listaPagamento = new System.Windows.Forms.ListView();
			this.ColPag2 = new System.Windows.Forms.ColumnHeader();
			this.ColPag3 = new System.Windows.Forms.ColumnHeader();
			this.gpxPagamento = new System.Windows.Forms.GroupBox();
			this.btnRemover = new Sunny.UI.UISymbolButton();
			this.btnAdicionar = new Sunny.UI.UISymbolButton();
			this.txtParcVencimento = new GM.Componentes.MinBox();
			this.labValorParcela = new System.Windows.Forms.Label();
			this.txtVencimento = new GM.Componentes.MinBox();
			this.labVencimento = new System.Windows.Forms.Label();
			this.labDescricao = new System.Windows.Forms.Label();
			this.txtDescricao = new GM.Componentes.MinBox();
			this.labEmissao = new System.Windows.Forms.Label();
			this.txtEmissao = new GM.Componentes.MinBox();
			this.labObservacao = new System.Windows.Forms.Label();
			this.txtObservacao = new GM.Componentes.MinBox();
			this.labTipo = new System.Windows.Forms.Label();
			this.cbxTipo = new GM.Componentes.MinComboBox();
			this.txtValor = new GM.Componentes.MinBox();
			this.labValor = new System.Windows.Forms.Label();
			this.txtCategoria = new GM.Componentes.MinBox();
			this.labCategoria = new System.Windows.Forms.Label();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.txtNomeFornecedor = new GM.Componentes.MinBox();
			this.txtCodigoFornecedor = new GM.Componentes.MinBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.cbxLoja = new GM.Componentes.MinComboBox();
			this.labLoja = new System.Windows.Forms.Label();
			this.txtNomeCategoria = new GM.Componentes.MinBox();
			this.gpxPagamento.SuspendLayout();
			this.SuspendLayout();
			// 
			// listaPagamento
			// 
			this.listaPagamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColPag2,
									this.ColPag3});
			this.listaPagamento.FullRowSelect = true;
			this.listaPagamento.GridLines = true;
			this.listaPagamento.Location = new System.Drawing.Point(6, 24);
			this.listaPagamento.MultiSelect = false;
			this.listaPagamento.Name = "listaPagamento";
			this.listaPagamento.Size = new System.Drawing.Size(284, 171);
			this.listaPagamento.TabIndex = 17;
			this.listaPagamento.UseCompatibleStateImageBehavior = false;
			this.listaPagamento.View = System.Windows.Forms.View.Details;
			// 
			// ColPag2
			// 
			this.ColPag2.Text = "Vencimento";
			this.ColPag2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColPag2.Width = 80;
			// 
			// ColPag3
			// 
			this.ColPag3.Text = "Valor (R$)";
			this.ColPag3.Width = 144;
			// 
			// gpxPagamento
			// 
			this.gpxPagamento.BackColor = System.Drawing.Color.Transparent;
			this.gpxPagamento.Controls.Add(this.btnRemover);
			this.gpxPagamento.Controls.Add(this.btnAdicionar);
			this.gpxPagamento.Controls.Add(this.txtParcVencimento);
			this.gpxPagamento.Controls.Add(this.labValorParcela);
			this.gpxPagamento.Controls.Add(this.txtVencimento);
			this.gpxPagamento.Controls.Add(this.listaPagamento);
			this.gpxPagamento.Controls.Add(this.labVencimento);
			this.gpxPagamento.Location = new System.Drawing.Point(12, 265);
			this.gpxPagamento.Name = "gpxPagamento";
			this.gpxPagamento.Size = new System.Drawing.Size(511, 201);
			this.gpxPagamento.TabIndex = 1;
			this.gpxPagamento.TabStop = false;
			this.gpxPagamento.Text = "Pagamentos";
			// 
			// btnRemover
			// 
			this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnRemover.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnRemover.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnRemover.Location = new System.Drawing.Point(296, 92);
			this.btnRemover.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Radius = 0;
			this.btnRemover.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnRemover.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnRemover.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.Size = new System.Drawing.Size(109, 24);
			this.btnRemover.Style = Sunny.UI.UIStyle.Red;
			this.btnRemover.SymbolSize = 0;
			this.btnRemover.TabIndex = 12;
			this.btnRemover.Text = "Remover";
			this.btnRemover.Click += new System.EventHandler(this.cliqueRemoverPagamento);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAdicionar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAdicionar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnAdicionar.Location = new System.Drawing.Point(406, 92);
			this.btnAdicionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Radius = 0;
			this.btnAdicionar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAdicionar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAdicionar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.Size = new System.Drawing.Size(89, 24);
			this.btnAdicionar.Style = Sunny.UI.UIStyle.Green;
			this.btnAdicionar.SymbolSize = 0;
			this.btnAdicionar.TabIndex = 11;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueAdicionarPagamento);
			// 
			// txtParcVencimento
			// 
			this.txtParcVencimento.BackColor = System.Drawing.Color.Transparent;
			this.txtParcVencimento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtParcVencimento.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtParcVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtParcVencimento.CustomBGColor = System.Drawing.Color.White;
			this.txtParcVencimento.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtParcVencimento.ForeColor = System.Drawing.Color.Black;
			this.txtParcVencimento.Location = new System.Drawing.Point(389, 58);
			this.txtParcVencimento.MaxLength = 10;
			this.txtParcVencimento.Multiline = false;
			this.txtParcVencimento.Name = "txtParcVencimento";
			this.txtParcVencimento.ReadOnly = false;
			this.txtParcVencimento.SelectionStart = 0;
			this.txtParcVencimento.Size = new System.Drawing.Size(106, 28);
			this.txtParcVencimento.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtParcVencimento.TabIndex = 10;
			this.txtParcVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtParcVencimento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtParcVencimento.UseSystemPasswordChar = false;
			this.txtParcVencimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterPagamento);
			this.txtParcVencimento.TextChanged += new System.EventHandler(this.maskValor);
			// 
			// labValorParcela
			// 
			this.labValorParcela.Location = new System.Drawing.Point(296, 58);
			this.labValorParcela.Name = "labValorParcela";
			this.labValorParcela.Size = new System.Drawing.Size(87, 25);
			this.labValorParcela.TabIndex = 17;
			this.labValorParcela.Text = "Valor (R$) :";
			this.labValorParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtVencimento
			// 
			this.txtVencimento.BackColor = System.Drawing.Color.Transparent;
			this.txtVencimento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtVencimento.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtVencimento.CustomBGColor = System.Drawing.Color.White;
			this.txtVencimento.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtVencimento.ForeColor = System.Drawing.Color.Black;
			this.txtVencimento.Location = new System.Drawing.Point(389, 24);
			this.txtVencimento.MaxLength = 10;
			this.txtVencimento.Multiline = false;
			this.txtVencimento.Name = "txtVencimento";
			this.txtVencimento.ReadOnly = false;
			this.txtVencimento.SelectionStart = 0;
			this.txtVencimento.Size = new System.Drawing.Size(106, 28);
			this.txtVencimento.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtVencimento.TabIndex = 9;
			this.txtVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtVencimento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtVencimento.UseSystemPasswordChar = false;
			this.txtVencimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterPagamento);
			this.txtVencimento.TextChanged += new System.EventHandler(this.maskData);
			this.txtVencimento.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// labVencimento
			// 
			this.labVencimento.Location = new System.Drawing.Point(296, 24);
			this.labVencimento.Name = "labVencimento";
			this.labVencimento.Size = new System.Drawing.Size(87, 25);
			this.labVencimento.TabIndex = 15;
			this.labVencimento.Text = "Vencimento :";
			this.labVencimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labDescricao
			// 
			this.labDescricao.BackColor = System.Drawing.Color.Transparent;
			this.labDescricao.Location = new System.Drawing.Point(24, 108);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(75, 25);
			this.labDescricao.TabIndex = 2;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.Transparent;
			this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDescricao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CustomBGColor = System.Drawing.Color.White;
			this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtDescricao.ForeColor = System.Drawing.Color.Black;
			this.txtDescricao.Location = new System.Drawing.Point(105, 108);
			this.txtDescricao.MaxLength = 70;
			this.txtDescricao.Multiline = false;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.ReadOnly = false;
			this.txtDescricao.SelectionStart = 0;
			this.txtDescricao.Size = new System.Drawing.Size(528, 28);
			this.txtDescricao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDescricao.TabIndex = 3;
			this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.UseSystemPasswordChar = false;
			// 
			// labEmissao
			// 
			this.labEmissao.BackColor = System.Drawing.Color.Transparent;
			this.labEmissao.Location = new System.Drawing.Point(446, 142);
			this.labEmissao.Name = "labEmissao";
			this.labEmissao.Size = new System.Drawing.Size(75, 25);
			this.labEmissao.TabIndex = 4;
			this.labEmissao.Text = "Emissão :";
			this.labEmissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmissao
			// 
			this.txtEmissao.BackColor = System.Drawing.Color.Transparent;
			this.txtEmissao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtEmissao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtEmissao.CustomBGColor = System.Drawing.Color.White;
			this.txtEmissao.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtEmissao.ForeColor = System.Drawing.Color.Black;
			this.txtEmissao.Location = new System.Drawing.Point(527, 142);
			this.txtEmissao.MaxLength = 10;
			this.txtEmissao.Multiline = false;
			this.txtEmissao.Name = "txtEmissao";
			this.txtEmissao.ReadOnly = false;
			this.txtEmissao.SelectionStart = 0;
			this.txtEmissao.Size = new System.Drawing.Size(106, 28);
			this.txtEmissao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtEmissao.TabIndex = 6;
			this.txtEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEmissao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEmissao.UseSystemPasswordChar = false;
			this.txtEmissao.TextChanged += new System.EventHandler(this.maskData);
			this.txtEmissao.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// labObservacao
			// 
			this.labObservacao.BackColor = System.Drawing.Color.Transparent;
			this.labObservacao.Location = new System.Drawing.Point(13, 176);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(86, 25);
			this.labObservacao.TabIndex = 6;
			this.labObservacao.Text = "Observação :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtObservacao
			// 
			this.txtObservacao.BackColor = System.Drawing.Color.Transparent;
			this.txtObservacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtObservacao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CustomBGColor = System.Drawing.Color.White;
			this.txtObservacao.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtObservacao.ForeColor = System.Drawing.Color.Black;
			this.txtObservacao.Location = new System.Drawing.Point(105, 176);
			this.txtObservacao.MaxLength = 200;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.ReadOnly = false;
			this.txtObservacao.SelectionStart = 0;
			this.txtObservacao.Size = new System.Drawing.Size(528, 47);
			this.txtObservacao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtObservacao.TabIndex = 7;
			this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.UseSystemPasswordChar = false;
			// 
			// labTipo
			// 
			this.labTipo.BackColor = System.Drawing.Color.Transparent;
			this.labTipo.Location = new System.Drawing.Point(24, 142);
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(75, 25);
			this.labTipo.TabIndex = 8;
			this.labTipo.Text = "Tipo :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxTipo
			// 
			this.cbxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxTipo.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxTipo.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxTipo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxTipo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxTipo.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxTipo.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxTipo.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxTipo.ColorH = System.Drawing.Color.White;
			this.cbxTipo.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxTipo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxTipo.DropDownHeight = 100;
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbxTipo.ForeColor = System.Drawing.Color.Black;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxTipo.IntegralHeight = false;
			this.cbxTipo.ItemHeight = 20;
			this.cbxTipo.Items.AddRange(new object[] {
									"Custo",
									"Despesa"});
			this.cbxTipo.Location = new System.Drawing.Point(105, 142);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(102, 26);
			this.cbxTipo.StartIndex = 0;
			this.cbxTipo.TabIndex = 4;
			// 
			// txtValor
			// 
			this.txtValor.BackColor = System.Drawing.Color.Transparent;
			this.txtValor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtValor.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValor.CustomBGColor = System.Drawing.Color.White;
			this.txtValor.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtValor.ForeColor = System.Drawing.Color.Black;
			this.txtValor.Location = new System.Drawing.Point(294, 142);
			this.txtValor.MaxLength = 10;
			this.txtValor.Multiline = false;
			this.txtValor.Name = "txtValor";
			this.txtValor.ReadOnly = false;
			this.txtValor.SelectionStart = 0;
			this.txtValor.Size = new System.Drawing.Size(146, 28);
			this.txtValor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtValor.TabIndex = 5;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValor.UseSystemPasswordChar = false;
			this.txtValor.TextChanged += new System.EventHandler(this.maskValor);
			// 
			// labValor
			// 
			this.labValor.BackColor = System.Drawing.Color.Transparent;
			this.labValor.Location = new System.Drawing.Point(213, 142);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(75, 25);
			this.labValor.TabIndex = 10;
			this.labValor.Text = "Valor (R$) :";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCategoria
			// 
			this.txtCategoria.BackColor = System.Drawing.Color.Transparent;
			this.txtCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCategoria.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCategoria.CustomBGColor = System.Drawing.Color.White;
			this.txtCategoria.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtCategoria.ForeColor = System.Drawing.Color.Black;
			this.txtCategoria.Location = new System.Drawing.Point(105, 229);
			this.txtCategoria.MaxLength = 30;
			this.txtCategoria.Multiline = false;
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.ReadOnly = false;
			this.txtCategoria.SelectionStart = 0;
			this.txtCategoria.Size = new System.Drawing.Size(75, 28);
			this.txtCategoria.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCategoria.TabIndex = 8;
			this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCategoria.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCategoria.UseSystemPasswordChar = false;
			this.txtCategoria.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.buscarCategoria);
			this.txtCategoria.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCategoria.Leave += new System.EventHandler(this.showCategoria);
			// 
			// labCategoria
			// 
			this.labCategoria.BackColor = System.Drawing.Color.Transparent;
			this.labCategoria.Location = new System.Drawing.Point(24, 229);
			this.labCategoria.Name = "labCategoria";
			this.labCategoria.Size = new System.Drawing.Size(75, 25);
			this.labCategoria.TabIndex = 12;
			this.labCategoria.Text = "Categoria :";
			this.labCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(410, 470);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Size = new System.Drawing.Size(111, 29);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "Sair";
			this.btnCancelar.Click += new System.EventHandler(this.cliqueSair);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSalvar.Location = new System.Drawing.Point(522, 470);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(111, 29);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 13;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// txtNomeFornecedor
			// 
			this.txtNomeFornecedor.BackColor = System.Drawing.Color.Transparent;
			this.txtNomeFornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtNomeFornecedor.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNomeFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNomeFornecedor.CustomBGColor = System.Drawing.Color.White;
			this.txtNomeFornecedor.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtNomeFornecedor.ForeColor = System.Drawing.Color.Black;
			this.txtNomeFornecedor.Location = new System.Drawing.Point(186, 74);
			this.txtNomeFornecedor.MaxLength = 32767;
			this.txtNomeFornecedor.Multiline = false;
			this.txtNomeFornecedor.Name = "txtNomeFornecedor";
			this.txtNomeFornecedor.ReadOnly = true;
			this.txtNomeFornecedor.SelectionStart = 0;
			this.txtNomeFornecedor.Size = new System.Drawing.Size(223, 28);
			this.txtNomeFornecedor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNomeFornecedor.TabIndex = 18;
			this.txtNomeFornecedor.TabStop = false;
			this.txtNomeFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNomeFornecedor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNomeFornecedor.UseSystemPasswordChar = false;
			// 
			// txtCodigoFornecedor
			// 
			this.txtCodigoFornecedor.BackColor = System.Drawing.Color.Transparent;
			this.txtCodigoFornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigoFornecedor.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigoFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigoFornecedor.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigoFornecedor.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtCodigoFornecedor.ForeColor = System.Drawing.Color.Black;
			this.txtCodigoFornecedor.Location = new System.Drawing.Point(105, 74);
			this.txtCodigoFornecedor.MaxLength = 32767;
			this.txtCodigoFornecedor.Multiline = false;
			this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
			this.txtCodigoFornecedor.ReadOnly = false;
			this.txtCodigoFornecedor.SelectionStart = 0;
			this.txtCodigoFornecedor.Size = new System.Drawing.Size(75, 28);
			this.txtCodigoFornecedor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigoFornecedor.TabIndex = 1;
			this.txtCodigoFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoFornecedor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoFornecedor.UseSystemPasswordChar = false;
			this.txtCodigoFornecedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.buscarCliente);
			this.txtCodigoFornecedor.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCodigoFornecedor.Leave += new System.EventHandler(this.showCliente);
			// 
			// labFornecedor
			// 
			this.labFornecedor.BackColor = System.Drawing.Color.Transparent;
			this.labFornecedor.Location = new System.Drawing.Point(-34, 74);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(133, 23);
			this.labFornecedor.TabIndex = 17;
			this.labFornecedor.Text = "Fornecedor :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxLoja
			// 
			this.cbxLoja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxLoja.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxLoja.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxLoja.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxLoja.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxLoja.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxLoja.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxLoja.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxLoja.ColorH = System.Drawing.Color.White;
			this.cbxLoja.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxLoja.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxLoja.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxLoja.DropDownHeight = 100;
			this.cbxLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxLoja.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbxLoja.ForeColor = System.Drawing.Color.Black;
			this.cbxLoja.FormattingEnabled = true;
			this.cbxLoja.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxLoja.IntegralHeight = false;
			this.cbxLoja.ItemHeight = 20;
			this.cbxLoja.Location = new System.Drawing.Point(458, 74);
			this.cbxLoja.Name = "cbxLoja";
			this.cbxLoja.Size = new System.Drawing.Size(175, 26);
			this.cbxLoja.StartIndex = 0;
			this.cbxLoja.TabIndex = 2;
			// 
			// labLoja
			// 
			this.labLoja.BackColor = System.Drawing.Color.Transparent;
			this.labLoja.Location = new System.Drawing.Point(399, 74);
			this.labLoja.Name = "labLoja";
			this.labLoja.Size = new System.Drawing.Size(57, 25);
			this.labLoja.TabIndex = 21;
			this.labLoja.Text = "Loja : ";
			this.labLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNomeCategoria
			// 
			this.txtNomeCategoria.BackColor = System.Drawing.Color.Transparent;
			this.txtNomeCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtNomeCategoria.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNomeCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNomeCategoria.CustomBGColor = System.Drawing.Color.White;
			this.txtNomeCategoria.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtNomeCategoria.ForeColor = System.Drawing.Color.Black;
			this.txtNomeCategoria.Location = new System.Drawing.Point(186, 229);
			this.txtNomeCategoria.MaxLength = 10;
			this.txtNomeCategoria.Multiline = false;
			this.txtNomeCategoria.Name = "txtNomeCategoria";
			this.txtNomeCategoria.ReadOnly = true;
			this.txtNomeCategoria.SelectionStart = 0;
			this.txtNomeCategoria.Size = new System.Drawing.Size(254, 28);
			this.txtNomeCategoria.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNomeCategoria.TabIndex = 22;
			this.txtNomeCategoria.TabStop = false;
			this.txtNomeCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNomeCategoria.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNomeCategoria.UseSystemPasswordChar = false;
			// 
			// CDCusto
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(645, 511);
			this.Controls.Add(this.txtNomeCategoria);
			this.Controls.Add(this.txtNomeFornecedor);
			this.Controls.Add(this.txtCodigoFornecedor);
			this.Controls.Add(this.labFornecedor);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtCategoria);
			this.Controls.Add(this.labCategoria);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.labValor);
			this.Controls.Add(this.cbxTipo);
			this.Controls.Add(this.labTipo);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.labObservacao);
			this.Controls.Add(this.txtEmissao);
			this.Controls.Add(this.labEmissao);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
			this.Controls.Add(this.gpxPagamento);
			this.Controls.Add(this.cbxLoja);
			this.Controls.Add(this.labLoja);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDCusto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Custo / Despesa";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.gpxPagamento.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private GM.Componentes.MinBox txtNomeCategoria;
		private System.Windows.Forms.Label labLoja;
		private GM.Componentes.MinComboBox cbxLoja;
		private System.Windows.Forms.Label labFornecedor;
		private GM.Componentes.MinBox txtCodigoFornecedor;
		private GM.Componentes.MinBox txtNomeFornecedor;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private Sunny.UI.UISymbolButton btnRemover;
		private Sunny.UI.UISymbolButton btnAdicionar;
		private System.Windows.Forms.Label labVencimento;
		private GM.Componentes.MinBox txtVencimento;
		private System.Windows.Forms.Label labValorParcela;
		private GM.Componentes.MinBox txtParcVencimento;
		private System.Windows.Forms.Label labCategoria;
		private GM.Componentes.MinBox txtCategoria;
		private System.Windows.Forms.Label labValor;
		private GM.Componentes.MinBox txtValor;
		private GM.Componentes.MinComboBox cbxTipo;
		private System.Windows.Forms.Label labTipo;
		private GM.Componentes.MinBox txtObservacao;
		private System.Windows.Forms.Label labObservacao;
		private GM.Componentes.MinBox txtEmissao;
		private System.Windows.Forms.Label labEmissao;
		private GM.Componentes.MinBox txtDescricao;
		private System.Windows.Forms.Label labDescricao;
		private System.Windows.Forms.GroupBox gpxPagamento;
		private System.Windows.Forms.ColumnHeader ColPag3;
		private System.Windows.Forms.ColumnHeader ColPag2;
		private System.Windows.Forms.ListView listaPagamento;
	}
}
