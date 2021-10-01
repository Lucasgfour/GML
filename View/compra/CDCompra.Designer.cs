
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
			this.cbxLoja = new GM.Componentes.MinComboBox();
			this.labLoja = new System.Windows.Forms.Label();
			this.txtNomeFornecedor = new GM.Componentes.MinBox();
			this.txtCodigoFornecedor = new GM.Componentes.MinBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.txtDataCompra = new GM.Componentes.MinBox();
			this.labDataCompra = new System.Windows.Forms.Label();
			this.txtObservacao = new GM.Componentes.MinBox();
			this.listProduto = new System.Windows.Forms.ListView();
			this.PCol1 = new System.Windows.Forms.ColumnHeader();
			this.PCol2 = new System.Windows.Forms.ColumnHeader();
			this.PCol3 = new System.Windows.Forms.ColumnHeader();
			this.PCol4 = new System.Windows.Forms.ColumnHeader();
			this.txtPreco = new GM.Componentes.MinBox();
			this.labPreco = new System.Windows.Forms.Label();
			this.txtQuantidade = new GM.Componentes.MinBox();
			this.labQuantidade = new System.Windows.Forms.Label();
			this.txtProduto = new System.Windows.Forms.ComboBox();
			this.labProduto = new System.Windows.Forms.Label();
			this.cbxCondicao = new GM.Componentes.MinComboBox();
			this.labPagamento = new System.Windows.Forms.Label();
			this.txtValorTotal = new GM.Componentes.MinBox();
			this.labValorTotal = new System.Windows.Forms.Label();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.labObservacao = new System.Windows.Forms.Label();
			this.labVencimento = new System.Windows.Forms.Label();
			this.listaParcela = new System.Windows.Forms.ListView();
			this.ColV1 = new System.Windows.Forms.ColumnHeader();
			this.ColV2 = new System.Windows.Forms.ColumnHeader();
			this.ColV3 = new System.Windows.Forms.ColumnHeader();
			this.btnSalvarPedido = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
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
			this.cbxLoja.Location = new System.Drawing.Point(312, 72);
			this.cbxLoja.Name = "cbxLoja";
			this.cbxLoja.Size = new System.Drawing.Size(180, 26);
			this.cbxLoja.StartIndex = 0;
			this.cbxLoja.TabIndex = 2;
			// 
			// labLoja
			// 
			this.labLoja.BackColor = System.Drawing.Color.Transparent;
			this.labLoja.Location = new System.Drawing.Point(261, 72);
			this.labLoja.Name = "labLoja";
			this.labLoja.Size = new System.Drawing.Size(45, 26);
			this.labLoja.TabIndex = 5;
			this.labLoja.Text = "Loja : ";
			this.labLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNomeFornecedor
			// 
			this.txtNomeFornecedor.BackColor = System.Drawing.Color.Transparent;
			this.txtNomeFornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtNomeFornecedor.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNomeFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNomeFornecedor.CustomBGColor = System.Drawing.Color.White;
			this.txtNomeFornecedor.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtNomeFornecedor.ForeColor = System.Drawing.Color.Black;
			this.txtNomeFornecedor.Location = new System.Drawing.Point(230, 104);
			this.txtNomeFornecedor.MaxLength = 32767;
			this.txtNomeFornecedor.Multiline = false;
			this.txtNomeFornecedor.Name = "txtNomeFornecedor";
			this.txtNomeFornecedor.ReadOnly = true;
			this.txtNomeFornecedor.SelectionStart = 0;
			this.txtNomeFornecedor.Size = new System.Drawing.Size(262, 26);
			this.txtNomeFornecedor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNomeFornecedor.TabIndex = 5;
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
			this.txtCodigoFornecedor.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtCodigoFornecedor.ForeColor = System.Drawing.Color.Black;
			this.txtCodigoFornecedor.Location = new System.Drawing.Point(126, 104);
			this.txtCodigoFornecedor.MaxLength = 32767;
			this.txtCodigoFornecedor.Multiline = false;
			this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
			this.txtCodigoFornecedor.ReadOnly = false;
			this.txtCodigoFornecedor.SelectionStart = 0;
			this.txtCodigoFornecedor.Size = new System.Drawing.Size(75, 26);
			this.txtCodigoFornecedor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigoFornecedor.TabIndex = 3;
			this.txtCodigoFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoFornecedor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigoFornecedor.UseSystemPasswordChar = false;
			this.txtCodigoFornecedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.buscarCliente);
			this.txtCodigoFornecedor.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCodigoFornecedor.Leave += new System.EventHandler(this.showCliente);
			// 
			// labFornecedor
			// 
			this.labFornecedor.BackColor = System.Drawing.Color.White;
			this.labFornecedor.Location = new System.Drawing.Point(12, 104);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(108, 26);
			this.labFornecedor.TabIndex = 0;
			this.labFornecedor.Text = "Cód. Fornecedor :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDataCompra
			// 
			this.txtDataCompra.BackColor = System.Drawing.Color.Transparent;
			this.txtDataCompra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDataCompra.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDataCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDataCompra.CustomBGColor = System.Drawing.Color.White;
			this.txtDataCompra.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtDataCompra.ForeColor = System.Drawing.Color.Black;
			this.txtDataCompra.Location = new System.Drawing.Point(126, 72);
			this.txtDataCompra.MaxLength = 10;
			this.txtDataCompra.Multiline = false;
			this.txtDataCompra.Name = "txtDataCompra";
			this.txtDataCompra.ReadOnly = false;
			this.txtDataCompra.SelectionStart = 0;
			this.txtDataCompra.Size = new System.Drawing.Size(129, 26);
			this.txtDataCompra.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDataCompra.TabIndex = 1;
			this.txtDataCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDataCompra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDataCompra.UseSystemPasswordChar = false;
			this.txtDataCompra.TextChanged += new System.EventHandler(this.maskData);
			this.txtDataCompra.Leave += new System.EventHandler(this.maskDataAux);
			// 
			// labDataCompra
			// 
			this.labDataCompra.BackColor = System.Drawing.Color.White;
			this.labDataCompra.Location = new System.Drawing.Point(12, 72);
			this.labDataCompra.Name = "labDataCompra";
			this.labDataCompra.Size = new System.Drawing.Size(108, 26);
			this.labDataCompra.TabIndex = 3;
			this.labDataCompra.Text = "Data da Compra :";
			this.labDataCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.txtObservacao.Location = new System.Drawing.Point(498, 98);
			this.txtObservacao.MaxLength = 200;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.ReadOnly = false;
			this.txtObservacao.SelectionStart = 0;
			this.txtObservacao.Size = new System.Drawing.Size(348, 64);
			this.txtObservacao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtObservacao.TabIndex = 8;
			this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.UseSystemPasswordChar = false;
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
			this.listProduto.Location = new System.Drawing.Point(126, 200);
			this.listProduto.MultiSelect = false;
			this.listProduto.Name = "listProduto";
			this.listProduto.Size = new System.Drawing.Size(720, 213);
			this.listProduto.TabIndex = 13;
			this.listProduto.UseCompatibleStateImageBehavior = false;
			this.listProduto.View = System.Windows.Forms.View.Details;
			// 
			// PCol1
			// 
			this.PCol1.Text = "Quantidade";
			this.PCol1.Width = 100;
			// 
			// PCol2
			// 
			this.PCol2.Text = "Descrição do Produto";
			this.PCol2.Width = 340;
			// 
			// PCol3
			// 
			this.PCol3.Text = "Preço Unidade (R$)";
			this.PCol3.Width = 120;
			// 
			// PCol4
			// 
			this.PCol4.Text = "Valor Total (R$)";
			this.PCol4.Width = 120;
			// 
			// txtPreco
			// 
			this.txtPreco.BackColor = System.Drawing.Color.Transparent;
			this.txtPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtPreco.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPreco.CustomBGColor = System.Drawing.Color.White;
			this.txtPreco.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtPreco.ForeColor = System.Drawing.Color.Black;
			this.txtPreco.Location = new System.Drawing.Point(693, 168);
			this.txtPreco.MaxLength = 32767;
			this.txtPreco.Multiline = false;
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.ReadOnly = false;
			this.txtPreco.SelectionStart = 0;
			this.txtPreco.Size = new System.Drawing.Size(72, 26);
			this.txtPreco.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPreco.TabIndex = 11;
			this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPreco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPreco.UseSystemPasswordChar = false;
			this.txtPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterProduto);
			this.txtPreco.TextChanged += new System.EventHandler(this.maskfloat);
			// 
			// labPreco
			// 
			this.labPreco.BackColor = System.Drawing.Color.White;
			this.labPreco.Location = new System.Drawing.Point(636, 168);
			this.labPreco.Name = "labPreco";
			this.labPreco.Size = new System.Drawing.Size(51, 26);
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
			this.txtQuantidade.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
			this.txtQuantidade.Location = new System.Drawing.Point(558, 168);
			this.txtQuantidade.MaxLength = 32767;
			this.txtQuantidade.Multiline = false;
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.ReadOnly = false;
			this.txtQuantidade.SelectionStart = 0;
			this.txtQuantidade.Size = new System.Drawing.Size(72, 26);
			this.txtQuantidade.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtQuantidade.TabIndex = 10;
			this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtQuantidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtQuantidade.UseSystemPasswordChar = false;
			this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterProduto);
			this.txtQuantidade.TextChanged += new System.EventHandler(this.maskQuantidade);
			// 
			// labQuantidade
			// 
			this.labQuantidade.BackColor = System.Drawing.Color.White;
			this.labQuantidade.Location = new System.Drawing.Point(498, 169);
			this.labQuantidade.Name = "labQuantidade";
			this.labQuantidade.Size = new System.Drawing.Size(54, 22);
			this.labQuantidade.TabIndex = 8;
			this.labQuantidade.Text = "Quant. :";
			this.labQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtProduto
			// 
			this.txtProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtProduto.FormattingEnabled = true;
			this.txtProduto.Location = new System.Drawing.Point(126, 168);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(366, 23);
			this.txtProduto.TabIndex = 9;
			this.txtProduto.SelectedIndexChanged += new System.EventHandler(this.mudarInfo);
			this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterProduto);
			// 
			// labProduto
			// 
			this.labProduto.BackColor = System.Drawing.Color.White;
			this.labProduto.Location = new System.Drawing.Point(38, 169);
			this.labProduto.Name = "labProduto";
			this.labProduto.Size = new System.Drawing.Size(81, 22);
			this.labProduto.TabIndex = 7;
			this.labProduto.Text = "Produto :";
			this.labProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.cbxCondicao.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.cbxCondicao.ForeColor = System.Drawing.Color.Black;
			this.cbxCondicao.FormattingEnabled = true;
			this.cbxCondicao.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxCondicao.IntegralHeight = false;
			this.cbxCondicao.ItemHeight = 20;
			this.cbxCondicao.Location = new System.Drawing.Point(126, 136);
			this.cbxCondicao.Name = "cbxCondicao";
			this.cbxCondicao.Size = new System.Drawing.Size(212, 26);
			this.cbxCondicao.StartIndex = 0;
			this.cbxCondicao.TabIndex = 6;
			// 
			// labPagamento
			// 
			this.labPagamento.BackColor = System.Drawing.Color.White;
			this.labPagamento.Location = new System.Drawing.Point(21, 139);
			this.labPagamento.Name = "labPagamento";
			this.labPagamento.Size = new System.Drawing.Size(99, 23);
			this.labPagamento.TabIndex = 21;
			this.labPagamento.Text = "Pagamento :";
			this.labPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtValorTotal
			// 
			this.txtValorTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtValorTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtValorTotal.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValorTotal.CustomBGColor = System.Drawing.Color.White;
			this.txtValorTotal.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtValorTotal.ForeColor = System.Drawing.Color.Black;
			this.txtValorTotal.Location = new System.Drawing.Point(648, 419);
			this.txtValorTotal.MaxLength = 32767;
			this.txtValorTotal.Multiline = false;
			this.txtValorTotal.Name = "txtValorTotal";
			this.txtValorTotal.ReadOnly = true;
			this.txtValorTotal.SelectionStart = 0;
			this.txtValorTotal.Size = new System.Drawing.Size(198, 26);
			this.txtValorTotal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtValorTotal.TabIndex = 14;
			this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValorTotal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValorTotal.UseSystemPasswordChar = false;
			// 
			// labValorTotal
			// 
			this.labValorTotal.BackColor = System.Drawing.Color.White;
			this.labValorTotal.Location = new System.Drawing.Point(560, 419);
			this.labValorTotal.Name = "labValorTotal";
			this.labValorTotal.Size = new System.Drawing.Size(82, 26);
			this.labValorTotal.TabIndex = 6;
			this.labValorTotal.Text = "Total (R$) :";
			this.labValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.btnRemover.Location = new System.Drawing.Point(46, 242);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(73, 36);
			this.btnRemover.TabIndex = 18;
			this.btnRemover.Text = "Remover\r\nSelec.";
			this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemover.UseVisualStyleBackColor = false;
			this.btnRemover.Click += new System.EventHandler(this.excluirProdutoClique);
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
			this.btnLimpar.Location = new System.Drawing.Point(47, 200);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(73, 36);
			this.btnLimpar.TabIndex = 17;
			this.btnLimpar.Text = "Limpar\r\nTodos";
			this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.limparProdutoClique);
			// 
			// btnCliente
			// 
			this.btnCliente.BackColor = System.Drawing.Color.Transparent;
			this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCliente.FlatAppearance.BorderSize = 0;
			this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCliente.ForeColor = System.Drawing.Color.White;
			this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
			this.btnCliente.Location = new System.Drawing.Point(201, 104);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(28, 26);
			this.btnCliente.TabIndex = 4;
			this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCliente.UseVisualStyleBackColor = false;
			this.btnCliente.Click += new System.EventHandler(this.buscaCliente);
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
			this.btnAdicionar.Location = new System.Drawing.Point(768, 168);
			this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(78, 26);
			this.btnAdicionar.TabIndex = 12;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdicionar.UseVisualStyleBackColor = false;
			this.btnAdicionar.Click += new System.EventHandler(this.adicionarProdutoClique);
			// 
			// labObservacao
			// 
			this.labObservacao.BackColor = System.Drawing.Color.Transparent;
			this.labObservacao.Location = new System.Drawing.Point(498, 72);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(86, 23);
			this.labObservacao.TabIndex = 44;
			this.labObservacao.Text = "Observações :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labVencimento
			// 
			this.labVencimento.BackColor = System.Drawing.Color.Transparent;
			this.labVencimento.Location = new System.Drawing.Point(47, 419);
			this.labVencimento.Name = "labVencimento";
			this.labVencimento.Size = new System.Drawing.Size(73, 23);
			this.labVencimento.TabIndex = 75;
			this.labVencimento.Text = "Parcelas :";
			this.labVencimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listaParcela
			// 
			this.listaParcela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColV1,
									this.ColV2,
									this.ColV3});
			this.listaParcela.FullRowSelect = true;
			this.listaParcela.GridLines = true;
			this.listaParcela.Location = new System.Drawing.Point(126, 419);
			this.listaParcela.MultiSelect = false;
			this.listaParcela.Name = "listaParcela";
			this.listaParcela.Size = new System.Drawing.Size(281, 137);
			this.listaParcela.TabIndex = 74;
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
			// btnSalvarPedido
			// 
			this.btnSalvarPedido.Depth = 0;
			this.btnSalvarPedido.Location = new System.Drawing.Point(691, 528);
			this.btnSalvarPedido.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvarPedido.Name = "btnSalvarPedido";
			this.btnSalvarPedido.Primary = true;
			this.btnSalvarPedido.Size = new System.Drawing.Size(155, 28);
			this.btnSalvarPedido.TabIndex = 15;
			this.btnSalvarPedido.Text = "SALVAR PEDIDO";
			this.btnSalvarPedido.UseVisualStyleBackColor = true;
			this.btnSalvarPedido.Click += new System.EventHandler(this.continuarClique);
			// 
			// CDCompra
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(858, 568);
			this.Controls.Add(this.btnSalvarPedido);
			this.Controls.Add(this.labVencimento);
			this.Controls.Add(this.listaParcela);
			this.Controls.Add(this.txtValorTotal);
			this.Controls.Add(this.labValorTotal);
			this.Controls.Add(this.labObservacao);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.listProduto);
			this.Controls.Add(this.cbxCondicao);
			this.Controls.Add(this.cbxLoja);
			this.Controls.Add(this.labPreco);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.labPagamento);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.txtQuantidade);
			this.Controls.Add(this.labLoja);
			this.Controls.Add(this.labQuantidade);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.txtProduto);
			this.Controls.Add(this.labProduto);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.txtNomeFornecedor);
			this.Controls.Add(this.txtDataCompra);
			this.Controls.Add(this.txtCodigoFornecedor);
			this.Controls.Add(this.labFornecedor);
			this.Controls.Add(this.labDataCompra);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDCompra";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro compras";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvarPedido;
		private System.Windows.Forms.ColumnHeader ColV3;
		private System.Windows.Forms.ColumnHeader ColV2;
		private System.Windows.Forms.ColumnHeader ColV1;
		private System.Windows.Forms.ListView listaParcela;
		private System.Windows.Forms.Label labVencimento;
		private System.Windows.Forms.Label labObservacao;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Label labPagamento;
		private GM.Componentes.MinComboBox cbxCondicao;
		private System.Windows.Forms.Label labValorTotal;
		private GM.Componentes.MinBox txtValorTotal;
		private System.Windows.Forms.ColumnHeader PCol4;
		private System.Windows.Forms.ColumnHeader PCol3;
		private System.Windows.Forms.ColumnHeader PCol2;
		private System.Windows.Forms.ColumnHeader PCol1;
		private System.Windows.Forms.ListView listProduto;
		private System.Windows.Forms.Label labQuantidade;
		private GM.Componentes.MinBox txtQuantidade;
		private System.Windows.Forms.Label labPreco;
		private GM.Componentes.MinBox txtPreco;
		private System.Windows.Forms.Label labProduto;
		private System.Windows.Forms.ComboBox txtProduto;
		private GM.Componentes.MinBox txtObservacao;
		private System.Windows.Forms.Label labDataCompra;
		private GM.Componentes.MinBox txtDataCompra;
		private System.Windows.Forms.Label labLoja;
		private GM.Componentes.MinComboBox cbxLoja;
		private System.Windows.Forms.Label labFornecedor;
		private GM.Componentes.MinBox txtCodigoFornecedor;
		private GM.Componentes.MinBox txtNomeFornecedor;
	}
}
