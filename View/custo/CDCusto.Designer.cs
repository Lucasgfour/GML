
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
			this.listaPagamento = new System.Windows.Forms.ListView();
			this.ColPag2 = new System.Windows.Forms.ColumnHeader();
			this.ColPag3 = new System.Windows.Forms.ColumnHeader();
			this.gpxPagamento = new System.Windows.Forms.GroupBox();
			this.btnRemover = new Sunny.UI.UISymbolButton();
			this.btnAdicionar = new Sunny.UI.UISymbolButton();
			this.txtParcVencimento = new System.Windows.Forms.TextBox();
			this.labValorParcela = new System.Windows.Forms.Label();
			this.txtVencimento = new System.Windows.Forms.TextBox();
			this.labVencimento = new System.Windows.Forms.Label();
			this.labDescricao = new System.Windows.Forms.Label();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.labEmissao = new System.Windows.Forms.Label();
			this.txtEmissao = new System.Windows.Forms.TextBox();
			this.labObservacao = new System.Windows.Forms.Label();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.labTipo = new System.Windows.Forms.Label();
			this.cbxTipo = new System.Windows.Forms.ComboBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.labValor = new System.Windows.Forms.Label();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.labCategoria = new System.Windows.Forms.Label();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
			this.txtCodigoFornecedor = new System.Windows.Forms.TextBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.cbxLoja = new System.Windows.Forms.ComboBox();
			this.labLoja = new System.Windows.Forms.Label();
			this.txtNomeCategoria = new System.Windows.Forms.TextBox();
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
			this.gpxPagamento.Controls.Add(this.btnRemover);
			this.gpxPagamento.Controls.Add(this.btnAdicionar);
			this.gpxPagamento.Controls.Add(this.txtParcVencimento);
			this.gpxPagamento.Controls.Add(this.labValorParcela);
			this.gpxPagamento.Controls.Add(this.txtVencimento);
			this.gpxPagamento.Controls.Add(this.listaPagamento);
			this.gpxPagamento.Controls.Add(this.labVencimento);
			this.gpxPagamento.Location = new System.Drawing.Point(10, 182);
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
			this.btnRemover.Location = new System.Drawing.Point(296, 80);
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
			this.btnAdicionar.Location = new System.Drawing.Point(411, 80);
			this.btnAdicionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Radius = 0;
			this.btnAdicionar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAdicionar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAdicionar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.Size = new System.Drawing.Size(84, 24);
			this.btnAdicionar.Style = Sunny.UI.UIStyle.Green;
			this.btnAdicionar.SymbolSize = 0;
			this.btnAdicionar.TabIndex = 11;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueAdicionarPagamento);
			// 
			// txtParcVencimento
			// 
			this.txtParcVencimento.Location = new System.Drawing.Point(389, 52);
			this.txtParcVencimento.MaxLength = 10;
			this.txtParcVencimento.Name = "txtParcVencimento";
			this.txtParcVencimento.Size = new System.Drawing.Size(106, 25);
			this.txtParcVencimento.TabIndex = 10;
			this.txtParcVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtParcVencimento.TextChanged += new System.EventHandler(this.maskValor);
			this.txtParcVencimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterPagamento);
			// 
			// labValorParcela
			// 
			this.labValorParcela.Location = new System.Drawing.Point(296, 52);
			this.labValorParcela.Name = "labValorParcela";
			this.labValorParcela.Size = new System.Drawing.Size(87, 25);
			this.labValorParcela.TabIndex = 17;
			this.labValorParcela.Text = "Valor (R$) :";
			this.labValorParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtVencimento
			// 
			this.txtVencimento.Location = new System.Drawing.Point(389, 24);
			this.txtVencimento.MaxLength = 10;
			this.txtVencimento.Name = "txtVencimento";
			this.txtVencimento.Size = new System.Drawing.Size(106, 25);
			this.txtVencimento.TabIndex = 9;
			this.txtVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtVencimento.TextChanged += new System.EventHandler(this.maskData);
			this.txtVencimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterPagamento);
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
			this.labDescricao.Location = new System.Drawing.Point(24, 36);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(75, 25);
			this.labDescricao.TabIndex = 2;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(105, 36);
			this.txtDescricao.MaxLength = 70;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(528, 25);
			this.txtDescricao.TabIndex = 3;
			// 
			// labEmissao
			// 
			this.labEmissao.Location = new System.Drawing.Point(446, 67);
			this.labEmissao.Name = "labEmissao";
			this.labEmissao.Size = new System.Drawing.Size(75, 25);
			this.labEmissao.TabIndex = 4;
			this.labEmissao.Text = "Emissão :";
			this.labEmissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmissao
			// 
			this.txtEmissao.Location = new System.Drawing.Point(527, 67);
			this.txtEmissao.MaxLength = 10;
			this.txtEmissao.Name = "txtEmissao";
			this.txtEmissao.Size = new System.Drawing.Size(106, 25);
			this.txtEmissao.TabIndex = 6;
			this.txtEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtEmissao.TextChanged += new System.EventHandler(this.maskData);
			this.txtEmissao.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// labObservacao
			// 
			this.labObservacao.Location = new System.Drawing.Point(13, 98);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(86, 25);
			this.labObservacao.TabIndex = 6;
			this.labObservacao.Text = "Observação :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtObservacao
			// 
			this.txtObservacao.Location = new System.Drawing.Point(105, 98);
			this.txtObservacao.MaxLength = 200;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(528, 47);
			this.txtObservacao.TabIndex = 7;
			// 
			// labTipo
			// 
			this.labTipo.Location = new System.Drawing.Point(24, 67);
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(75, 25);
			this.labTipo.TabIndex = 8;
			this.labTipo.Text = "Tipo :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxTipo
			// 
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.Items.AddRange(new object[] {
									"Custo",
									"Despesa"});
			this.cbxTipo.Location = new System.Drawing.Point(105, 67);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(102, 25);
			this.cbxTipo.TabIndex = 4;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(294, 67);
			this.txtValor.MaxLength = 10;
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(146, 25);
			this.txtValor.TabIndex = 5;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtValor.TextChanged += new System.EventHandler(this.maskValor);
			// 
			// labValor
			// 
			this.labValor.Location = new System.Drawing.Point(213, 67);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(75, 25);
			this.labValor.TabIndex = 10;
			this.labValor.Text = "Valor (R$) :";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCategoria
			// 
			this.txtCategoria.Location = new System.Drawing.Point(105, 151);
			this.txtCategoria.MaxLength = 30;
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(75, 25);
			this.txtCategoria.TabIndex = 8;
			this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCategoria.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCategoria.Leave += new System.EventHandler(this.showCategoria);
			this.txtCategoria.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.buscarCategoria);
			// 
			// labCategoria
			// 
			this.labCategoria.Location = new System.Drawing.Point(24, 151);
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
			this.btnCancelar.Location = new System.Drawing.Point(410, 389);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
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
			this.btnSalvar.Location = new System.Drawing.Point(527, 389);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
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
			this.txtNomeFornecedor.Location = new System.Drawing.Point(186, 5);
			this.txtNomeFornecedor.Name = "txtNomeFornecedor";
			this.txtNomeFornecedor.ReadOnly = true;
			this.txtNomeFornecedor.Size = new System.Drawing.Size(223, 25);
			this.txtNomeFornecedor.TabIndex = 18;
			this.txtNomeFornecedor.TabStop = false;
			// 
			// txtCodigoFornecedor
			// 
			this.txtCodigoFornecedor.Location = new System.Drawing.Point(105, 5);
			this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
			this.txtCodigoFornecedor.Size = new System.Drawing.Size(75, 25);
			this.txtCodigoFornecedor.TabIndex = 1;
			this.txtCodigoFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCodigoFornecedor.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCodigoFornecedor.Leave += new System.EventHandler(this.showCliente);
			this.txtCodigoFornecedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.buscarCliente);
			// 
			// labFornecedor
			// 
			this.labFornecedor.Location = new System.Drawing.Point(-34, 5);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(133, 23);
			this.labFornecedor.TabIndex = 17;
			this.labFornecedor.Text = "Fornecedor :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxLoja
			// 
			this.cbxLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxLoja.FormattingEnabled = true;
			this.cbxLoja.Location = new System.Drawing.Point(458, 5);
			this.cbxLoja.Name = "cbxLoja";
			this.cbxLoja.Size = new System.Drawing.Size(175, 25);
			this.cbxLoja.TabIndex = 2;
			// 
			// labLoja
			// 
			this.labLoja.Location = new System.Drawing.Point(399, 5);
			this.labLoja.Name = "labLoja";
			this.labLoja.Size = new System.Drawing.Size(57, 25);
			this.labLoja.TabIndex = 21;
			this.labLoja.Text = "Loja : ";
			this.labLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNomeCategoria
			// 
			this.txtNomeCategoria.Location = new System.Drawing.Point(186, 151);
			this.txtNomeCategoria.MaxLength = 10;
			this.txtNomeCategoria.Name = "txtNomeCategoria";
			this.txtNomeCategoria.ReadOnly = true;
			this.txtNomeCategoria.Size = new System.Drawing.Size(254, 25);
			this.txtNomeCategoria.TabIndex = 22;
			this.txtNomeCategoria.TabStop = false;
			this.txtNomeCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CDCusto
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(645, 429);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CDCusto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Custo / Despesa";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.gpxPagamento.ResumeLayout(false);
			this.gpxPagamento.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtNomeCategoria;
		private System.Windows.Forms.Label labLoja;
		private System.Windows.Forms.ComboBox cbxLoja;
		private System.Windows.Forms.Label labFornecedor;
		private System.Windows.Forms.TextBox txtCodigoFornecedor;
		private System.Windows.Forms.TextBox txtNomeFornecedor;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private Sunny.UI.UISymbolButton btnRemover;
		private Sunny.UI.UISymbolButton btnAdicionar;
		private System.Windows.Forms.Label labVencimento;
		private System.Windows.Forms.TextBox txtVencimento;
		private System.Windows.Forms.Label labValorParcela;
		private System.Windows.Forms.TextBox txtParcVencimento;
		private System.Windows.Forms.Label labCategoria;
		private System.Windows.Forms.TextBox txtCategoria;
		private System.Windows.Forms.Label labValor;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.ComboBox cbxTipo;
		private System.Windows.Forms.Label labTipo;
		private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.Label labObservacao;
		private System.Windows.Forms.TextBox txtEmissao;
		private System.Windows.Forms.Label labEmissao;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.Label labDescricao;
		private System.Windows.Forms.GroupBox gpxPagamento;
		private System.Windows.Forms.ColumnHeader ColPag3;
		private System.Windows.Forms.ColumnHeader ColPag2;
		private System.Windows.Forms.ListView listaPagamento;
	}
}
