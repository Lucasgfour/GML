
namespace GM.View.compra
{
	partial class CDCompra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDCompra));
			this.areaCabecalho = new System.Windows.Forms.GroupBox();
			this.cbxLoja = new GM.Componentes.MinComboBox();
			this.labLoja = new System.Windows.Forms.Label();
			this.txtDataCompra = new GM.Componentes.MinBox();
			this.labDataCompra = new System.Windows.Forms.Label();
			this.txtNomeFornecedor = new GM.Componentes.MinBox();
			this.txtCodigoFornecedor = new GM.Componentes.MinBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.areaObservacoes = new System.Windows.Forms.GroupBox();
			this.txtObservacao = new GM.Componentes.MinBox();
			this.areaProdutos = new System.Windows.Forms.GroupBox();
			this.btnClearProduto = new Sunny.UI.UISymbolButton();
			this.btnDelProduto = new Sunny.UI.UISymbolButton();
			this.listProduto = new System.Windows.Forms.ListView();
			this.PCol1 = new System.Windows.Forms.ColumnHeader();
			this.PCol2 = new System.Windows.Forms.ColumnHeader();
			this.PCol3 = new System.Windows.Forms.ColumnHeader();
			this.PCol4 = new System.Windows.Forms.ColumnHeader();
			this.btnAddProduto = new Sunny.UI.UISymbolButton();
			this.txtPreco = new GM.Componentes.MinBox();
			this.labPreco = new System.Windows.Forms.Label();
			this.txtQuantidade = new GM.Componentes.MinBox();
			this.labQuantidade = new System.Windows.Forms.Label();
			this.txtProduto = new System.Windows.Forms.ComboBox();
			this.labProduto = new System.Windows.Forms.Label();
			this.areaConclusao = new System.Windows.Forms.GroupBox();
			this.btnCalculo = new Sunny.UI.UISymbolButton();
			this.cbxCondicao = new GM.Componentes.MinComboBox();
			this.labPagamento = new System.Windows.Forms.Label();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.txtValorTotal = new GM.Componentes.MinBox();
			this.labValorTotal = new System.Windows.Forms.Label();
			this.areaCabecalho.SuspendLayout();
			this.areaObservacoes.SuspendLayout();
			this.areaProdutos.SuspendLayout();
			this.areaConclusao.SuspendLayout();
			this.SuspendLayout();
			// 
			// areaCabecalho
			// 
			this.areaCabecalho.BackColor = System.Drawing.Color.White;
			this.areaCabecalho.Controls.Add(this.cbxLoja);
			this.areaCabecalho.Controls.Add(this.labLoja);
			this.areaCabecalho.Controls.Add(this.txtDataCompra);
			this.areaCabecalho.Controls.Add(this.labDataCompra);
			this.areaCabecalho.Controls.Add(this.txtNomeFornecedor);
			this.areaCabecalho.Controls.Add(this.txtCodigoFornecedor);
			this.areaCabecalho.Controls.Add(this.labFornecedor);
			this.areaCabecalho.Location = new System.Drawing.Point(12, 80);
			this.areaCabecalho.Name = "areaCabecalho";
			this.areaCabecalho.Size = new System.Drawing.Size(529, 82);
			this.areaCabecalho.TabIndex = 0;
			this.areaCabecalho.TabStop = false;
			this.areaCabecalho.Text = "Cabeçalho";
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
			this.cbxLoja.Location = new System.Drawing.Point(343, 21);
			this.cbxLoja.Name = "cbxLoja";
			this.cbxLoja.Size = new System.Drawing.Size(180, 26);
			this.cbxLoja.StartIndex = 0;
			this.cbxLoja.TabIndex = 1;
			// 
			// labLoja
			// 
			this.labLoja.Location = new System.Drawing.Point(280, 19);
			this.labLoja.Name = "labLoja";
			this.labLoja.Size = new System.Drawing.Size(57, 23);
			this.labLoja.TabIndex = 5;
			this.labLoja.Text = "Loja : ";
			this.labLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDataCompra
			// 
			this.txtDataCompra.BackColor = System.Drawing.Color.Transparent;
			this.txtDataCompra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDataCompra.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDataCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDataCompra.CustomBGColor = System.Drawing.Color.White;
			this.txtDataCompra.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtDataCompra.ForeColor = System.Drawing.Color.Black;
			this.txtDataCompra.Location = new System.Drawing.Point(145, 19);
			this.txtDataCompra.MaxLength = 10;
			this.txtDataCompra.Multiline = false;
			this.txtDataCompra.Name = "txtDataCompra";
			this.txtDataCompra.ReadOnly = false;
			this.txtDataCompra.SelectionStart = 0;
			this.txtDataCompra.Size = new System.Drawing.Size(129, 28);
			this.txtDataCompra.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDataCompra.TabIndex = 0;
			this.txtDataCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDataCompra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDataCompra.UseSystemPasswordChar = false;
			this.txtDataCompra.TextChanged += new System.EventHandler(this.maskData);
			this.txtDataCompra.Leave += new System.EventHandler(this.maskDataAux);
			// 
			// labDataCompra
			// 
			this.labDataCompra.Location = new System.Drawing.Point(6, 19);
			this.labDataCompra.Name = "labDataCompra";
			this.labDataCompra.Size = new System.Drawing.Size(133, 23);
			this.labDataCompra.TabIndex = 3;
			this.labDataCompra.Text = "Data da Compra :";
			this.labDataCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.txtNomeFornecedor.Location = new System.Drawing.Point(226, 48);
			this.txtNomeFornecedor.MaxLength = 32767;
			this.txtNomeFornecedor.Multiline = false;
			this.txtNomeFornecedor.Name = "txtNomeFornecedor";
			this.txtNomeFornecedor.ReadOnly = true;
			this.txtNomeFornecedor.SelectionStart = 0;
			this.txtNomeFornecedor.Size = new System.Drawing.Size(297, 28);
			this.txtNomeFornecedor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNomeFornecedor.TabIndex = 2;
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
			this.txtCodigoFornecedor.Location = new System.Drawing.Point(145, 48);
			this.txtCodigoFornecedor.MaxLength = 32767;
			this.txtCodigoFornecedor.Multiline = false;
			this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
			this.txtCodigoFornecedor.ReadOnly = false;
			this.txtCodigoFornecedor.SelectionStart = 0;
			this.txtCodigoFornecedor.Size = new System.Drawing.Size(75, 28);
			this.txtCodigoFornecedor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigoFornecedor.TabIndex = 2;
			this.txtCodigoFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoFornecedor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoFornecedor.UseSystemPasswordChar = false;
			this.txtCodigoFornecedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.buscarCliente);
			this.txtCodigoFornecedor.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCodigoFornecedor.Leave += new System.EventHandler(this.showCliente);
			// 
			// labFornecedor
			// 
			this.labFornecedor.Location = new System.Drawing.Point(6, 48);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(133, 23);
			this.labFornecedor.TabIndex = 0;
			this.labFornecedor.Text = "Cód. Fornecedor :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// areaObservacoes
			// 
			this.areaObservacoes.BackColor = System.Drawing.Color.Transparent;
			this.areaObservacoes.Controls.Add(this.txtObservacao);
			this.areaObservacoes.Location = new System.Drawing.Point(547, 80);
			this.areaObservacoes.Name = "areaObservacoes";
			this.areaObservacoes.Size = new System.Drawing.Size(303, 82);
			this.areaObservacoes.TabIndex = 1;
			this.areaObservacoes.TabStop = false;
			this.areaObservacoes.Text = "Observações";
			// 
			// txtObservacao
			// 
			this.txtObservacao.BackColor = System.Drawing.Color.Transparent;
			this.txtObservacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtObservacao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CustomBGColor = System.Drawing.Color.White;
			this.txtObservacao.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtObservacao.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtObservacao.ForeColor = System.Drawing.Color.Black;
			this.txtObservacao.Location = new System.Drawing.Point(3, 19);
			this.txtObservacao.MaxLength = 200;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.ReadOnly = false;
			this.txtObservacao.SelectionStart = 0;
			this.txtObservacao.Size = new System.Drawing.Size(297, 60);
			this.txtObservacao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtObservacao.TabIndex = 3;
			this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.UseSystemPasswordChar = false;
			// 
			// areaProdutos
			// 
			this.areaProdutos.BackColor = System.Drawing.Color.Transparent;
			this.areaProdutos.Controls.Add(this.btnClearProduto);
			this.areaProdutos.Controls.Add(this.btnDelProduto);
			this.areaProdutos.Controls.Add(this.listProduto);
			this.areaProdutos.Controls.Add(this.btnAddProduto);
			this.areaProdutos.Controls.Add(this.txtPreco);
			this.areaProdutos.Controls.Add(this.labPreco);
			this.areaProdutos.Controls.Add(this.txtQuantidade);
			this.areaProdutos.Controls.Add(this.labQuantidade);
			this.areaProdutos.Controls.Add(this.txtProduto);
			this.areaProdutos.Controls.Add(this.labProduto);
			this.areaProdutos.Location = new System.Drawing.Point(12, 168);
			this.areaProdutos.Name = "areaProdutos";
			this.areaProdutos.Size = new System.Drawing.Size(838, 267);
			this.areaProdutos.TabIndex = 2;
			this.areaProdutos.TabStop = false;
			this.areaProdutos.Text = "Produtos";
			// 
			// btnClearProduto
			// 
			this.btnClearProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClearProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnClearProduto.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnClearProduto.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnClearProduto.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnClearProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnClearProduto.Location = new System.Drawing.Point(7, 77);
			this.btnClearProduto.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnClearProduto.Name = "btnClearProduto";
			this.btnClearProduto.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnClearProduto.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnClearProduto.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnClearProduto.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnClearProduto.Size = new System.Drawing.Size(81, 23);
			this.btnClearProduto.Style = Sunny.UI.UIStyle.Red;
			this.btnClearProduto.Symbol = 61543;
			this.btnClearProduto.SymbolSize = 0;
			this.btnClearProduto.TabIndex = 10;
			this.btnClearProduto.Text = "Limpar";
			this.btnClearProduto.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnClearProduto.Click += new System.EventHandler(this.limparProdutoClique);
			// 
			// btnDelProduto
			// 
			this.btnDelProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnDelProduto.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnDelProduto.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDelProduto.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnDelProduto.Location = new System.Drawing.Point(7, 48);
			this.btnDelProduto.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnDelProduto.Name = "btnDelProduto";
			this.btnDelProduto.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnDelProduto.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnDelProduto.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDelProduto.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDelProduto.Size = new System.Drawing.Size(81, 23);
			this.btnDelProduto.Style = Sunny.UI.UIStyle.Red;
			this.btnDelProduto.Symbol = 61543;
			this.btnDelProduto.SymbolSize = 0;
			this.btnDelProduto.TabIndex = 9;
			this.btnDelProduto.Text = "Excluir";
			this.btnDelProduto.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnDelProduto.Click += new System.EventHandler(this.excluirProdutoClique);
			// 
			// listProduto
			// 
			this.listProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.PCol1,
									this.PCol2,
									this.PCol3,
									this.PCol4});
			this.listProduto.FullRowSelect = true;
			this.listProduto.GridLines = true;
			this.listProduto.Location = new System.Drawing.Point(94, 48);
			this.listProduto.MultiSelect = false;
			this.listProduto.Name = "listProduto";
			this.listProduto.Size = new System.Drawing.Size(738, 213);
			this.listProduto.TabIndex = 8;
			this.listProduto.UseCompatibleStateImageBehavior = false;
			this.listProduto.View = System.Windows.Forms.View.Details;
			// 
			// PCol1
			// 
			this.PCol1.Text = "Quantidade";
			this.PCol1.Width = 90;
			// 
			// PCol2
			// 
			this.PCol2.Text = "Descrição";
			this.PCol2.Width = 300;
			// 
			// PCol3
			// 
			this.PCol3.Text = "Preço Unitário";
			this.PCol3.Width = 100;
			// 
			// PCol4
			// 
			this.PCol4.Text = "Totais (R$)";
			this.PCol4.Width = 120;
			// 
			// btnAddProduto
			// 
			this.btnAddProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAddProduto.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAddProduto.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAddProduto.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAddProduto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddProduto.Location = new System.Drawing.Point(773, 19);
			this.btnAddProduto.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAddProduto.Name = "btnAddProduto";
			this.btnAddProduto.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnAddProduto.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAddProduto.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAddProduto.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAddProduto.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAddProduto.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.btnAddProduto.Size = new System.Drawing.Size(59, 28);
			this.btnAddProduto.Style = Sunny.UI.UIStyle.Green;
			this.btnAddProduto.Symbol = 61543;
			this.btnAddProduto.SymbolSize = 0;
			this.btnAddProduto.TabIndex = 7;
			this.btnAddProduto.Text = "+";
			this.btnAddProduto.Click += new System.EventHandler(this.adicionarProdutoClique);
			// 
			// txtPreco
			// 
			this.txtPreco.BackColor = System.Drawing.Color.Transparent;
			this.txtPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtPreco.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPreco.CustomBGColor = System.Drawing.Color.White;
			this.txtPreco.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtPreco.ForeColor = System.Drawing.Color.Black;
			this.txtPreco.Location = new System.Drawing.Point(695, 19);
			this.txtPreco.MaxLength = 32767;
			this.txtPreco.Multiline = false;
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.ReadOnly = false;
			this.txtPreco.SelectionStart = 0;
			this.txtPreco.Size = new System.Drawing.Size(72, 28);
			this.txtPreco.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPreco.TabIndex = 6;
			this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPreco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPreco.UseSystemPasswordChar = false;
			this.txtPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterProduto);
			this.txtPreco.TextChanged += new System.EventHandler(this.maskfloat);
			// 
			// labPreco
			// 
			this.labPreco.Location = new System.Drawing.Point(632, 18);
			this.labPreco.Name = "labPreco";
			this.labPreco.Size = new System.Drawing.Size(57, 24);
			this.labPreco.TabIndex = 9;
			this.labPreco.Text = "Preço :";
			this.labPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.BackColor = System.Drawing.Color.Transparent;
			this.txtQuantidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtQuantidade.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtQuantidade.CustomBGColor = System.Drawing.Color.White;
			this.txtQuantidade.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
			this.txtQuantidade.Location = new System.Drawing.Point(554, 18);
			this.txtQuantidade.MaxLength = 32767;
			this.txtQuantidade.Multiline = false;
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.ReadOnly = false;
			this.txtQuantidade.SelectionStart = 0;
			this.txtQuantidade.Size = new System.Drawing.Size(72, 28);
			this.txtQuantidade.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtQuantidade.TabIndex = 5;
			this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtQuantidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtQuantidade.UseSystemPasswordChar = false;
			this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterProduto);
			this.txtQuantidade.TextChanged += new System.EventHandler(this.maskQuantidade);
			// 
			// labQuantidade
			// 
			this.labQuantidade.Location = new System.Drawing.Point(482, 18);
			this.labQuantidade.Name = "labQuantidade";
			this.labQuantidade.Size = new System.Drawing.Size(66, 24);
			this.labQuantidade.TabIndex = 8;
			this.labQuantidade.Text = "Quant. :";
			this.labQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtProduto
			// 
			this.txtProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtProduto.FormattingEnabled = true;
			this.txtProduto.Location = new System.Drawing.Point(94, 18);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(382, 24);
			this.txtProduto.TabIndex = 4;
			this.txtProduto.SelectedIndexChanged += new System.EventHandler(this.mudarInfo);
			this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterProduto);
			// 
			// labProduto
			// 
			this.labProduto.Location = new System.Drawing.Point(6, 19);
			this.labProduto.Name = "labProduto";
			this.labProduto.Size = new System.Drawing.Size(81, 23);
			this.labProduto.TabIndex = 7;
			this.labProduto.Text = "Produto :";
			this.labProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// areaConclusao
			// 
			this.areaConclusao.BackColor = System.Drawing.Color.White;
			this.areaConclusao.Controls.Add(this.btnCalculo);
			this.areaConclusao.Controls.Add(this.cbxCondicao);
			this.areaConclusao.Controls.Add(this.labPagamento);
			this.areaConclusao.Controls.Add(this.btnCancelar);
			this.areaConclusao.Controls.Add(this.btnSalvar);
			this.areaConclusao.Controls.Add(this.txtValorTotal);
			this.areaConclusao.Controls.Add(this.labValorTotal);
			this.areaConclusao.Location = new System.Drawing.Point(12, 441);
			this.areaConclusao.Name = "areaConclusao";
			this.areaConclusao.Size = new System.Drawing.Size(838, 57);
			this.areaConclusao.TabIndex = 4;
			this.areaConclusao.TabStop = false;
			this.areaConclusao.Text = "Conclusão e Conferência";
			// 
			// btnCalculo
			// 
			this.btnCalculo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCalculo.Location = new System.Drawing.Point(554, 17);
			this.btnCalculo.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCalculo.Name = "btnCalculo";
			this.btnCalculo.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnCalculo.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.btnCalculo.Size = new System.Drawing.Size(44, 31);
			this.btnCalculo.Symbol = 61932;
			this.btnCalculo.TabIndex = 22;
			this.btnCalculo.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCalculo.Click += new System.EventHandler(this.calculoClique);
			// 
			// cbxCondicao
			// 
			this.cbxCondicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
			this.cbxCondicao.Location = new System.Drawing.Point(336, 20);
			this.cbxCondicao.Name = "cbxCondicao";
			this.cbxCondicao.Size = new System.Drawing.Size(212, 26);
			this.cbxCondicao.StartIndex = 0;
			this.cbxCondicao.TabIndex = 6;
			// 
			// labPagamento
			// 
			this.labPagamento.Location = new System.Drawing.Point(235, 20);
			this.labPagamento.Name = "labPagamento";
			this.labPagamento.Size = new System.Drawing.Size(99, 23);
			this.labPagamento.TabIndex = 21;
			this.labPagamento.Text = "Pagamento :";
			this.labPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCancelar.Location = new System.Drawing.Point(604, 17);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.btnCancelar.Size = new System.Drawing.Size(121, 31);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 20;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCancelar.Click += new System.EventHandler(this.cancelarClique);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnSalvar.Location = new System.Drawing.Point(731, 17);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.btnSalvar.Size = new System.Drawing.Size(100, 31);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 11;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnSalvar.Click += new System.EventHandler(this.continuarClique);
			// 
			// txtValorTotal
			// 
			this.txtValorTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtValorTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtValorTotal.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValorTotal.CustomBGColor = System.Drawing.Color.White;
			this.txtValorTotal.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtValorTotal.ForeColor = System.Drawing.Color.Black;
			this.txtValorTotal.Location = new System.Drawing.Point(94, 20);
			this.txtValorTotal.MaxLength = 32767;
			this.txtValorTotal.Multiline = false;
			this.txtValorTotal.Name = "txtValorTotal";
			this.txtValorTotal.ReadOnly = true;
			this.txtValorTotal.SelectionStart = 0;
			this.txtValorTotal.Size = new System.Drawing.Size(138, 28);
			this.txtValorTotal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtValorTotal.TabIndex = 19;
			this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValorTotal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValorTotal.UseSystemPasswordChar = false;
			// 
			// labValorTotal
			// 
			this.labValorTotal.Location = new System.Drawing.Point(6, 20);
			this.labValorTotal.Name = "labValorTotal";
			this.labValorTotal.Size = new System.Drawing.Size(82, 23);
			this.labValorTotal.TabIndex = 6;
			this.labValorTotal.Text = "Total (R$) :";
			this.labValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CDCompra
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(862, 515);
			this.Controls.Add(this.areaConclusao);
			this.Controls.Add(this.areaProdutos);
			this.Controls.Add(this.areaObservacoes);
			this.Controls.Add(this.areaCabecalho);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDCompra";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de compra";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.areaCabecalho.ResumeLayout(false);
			this.areaObservacoes.ResumeLayout(false);
			this.areaProdutos.ResumeLayout(false);
			this.areaConclusao.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private Sunny.UI.UISymbolButton btnCalculo;
		private System.Windows.Forms.Label labPagamento;
		private GM.Componentes.MinComboBox cbxCondicao;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private System.Windows.Forms.Label labValorTotal;
		private GM.Componentes.MinBox txtValorTotal;
		private System.Windows.Forms.GroupBox areaConclusao;
		private Sunny.UI.UISymbolButton btnDelProduto;
		private Sunny.UI.UISymbolButton btnClearProduto;
		private System.Windows.Forms.ColumnHeader PCol4;
		private System.Windows.Forms.ColumnHeader PCol3;
		private System.Windows.Forms.ColumnHeader PCol2;
		private System.Windows.Forms.ColumnHeader PCol1;
		private System.Windows.Forms.ListView listProduto;
		private Sunny.UI.UISymbolButton btnAddProduto;
		private System.Windows.Forms.Label labQuantidade;
		private GM.Componentes.MinBox txtQuantidade;
		private System.Windows.Forms.Label labPreco;
		private GM.Componentes.MinBox txtPreco;
		private System.Windows.Forms.Label labProduto;
		private System.Windows.Forms.ComboBox txtProduto;
		private System.Windows.Forms.GroupBox areaProdutos;
		private GM.Componentes.MinBox txtObservacao;
		private System.Windows.Forms.GroupBox areaObservacoes;
		private System.Windows.Forms.Label labDataCompra;
		private GM.Componentes.MinBox txtDataCompra;
		private System.Windows.Forms.Label labLoja;
		private GM.Componentes.MinComboBox cbxLoja;
		private System.Windows.Forms.Label labFornecedor;
		private GM.Componentes.MinBox txtCodigoFornecedor;
		private GM.Componentes.MinBox txtNomeFornecedor;
		private System.Windows.Forms.GroupBox areaCabecalho;
	}
}
