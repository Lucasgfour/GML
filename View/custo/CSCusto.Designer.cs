
namespace GM.View.custo
{
	partial class CSCusto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSCusto));
			this.txtFornecedor = new GM.Componentes.MinBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.txtLoja = new GM.Componentes.MinBox();
			this.labLoja = new System.Windows.Forms.Label();
			this.txtDescricao = new GM.Componentes.MinBox();
			this.labDescricao = new System.Windows.Forms.Label();
			this.txtEmissao = new GM.Componentes.MinBox();
			this.labEmissao = new System.Windows.Forms.Label();
			this.txtCodigo = new GM.Componentes.MinBox();
			this.labCodigo = new System.Windows.Forms.Label();
			this.cbxTipo = new GM.Componentes.MinComboBox();
			this.txtValor = new GM.Componentes.MinBox();
			this.labValor = new System.Windows.Forms.Label();
			this.txtCategoria = new GM.Componentes.MinBox();
			this.labCategoria = new System.Windows.Forms.Label();
			this.btnAbrir = new Sunny.UI.UISymbolButton();
			this.txtObservacao = new GM.Componentes.MinBox();
			this.labObservacao = new System.Windows.Forms.Label();
			this.listaParcelas = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.Col05 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// txtFornecedor
			// 
			this.txtFornecedor.BackColor = System.Drawing.Color.White;
			this.txtFornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtFornecedor.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtFornecedor.CustomBGColor = System.Drawing.Color.White;
			this.txtFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtFornecedor.ForeColor = System.Drawing.Color.Black;
			this.txtFornecedor.Location = new System.Drawing.Point(260, 76);
			this.txtFornecedor.MaxLength = 32767;
			this.txtFornecedor.Multiline = false;
			this.txtFornecedor.Name = "txtFornecedor";
			this.txtFornecedor.ReadOnly = true;
			this.txtFornecedor.SelectionStart = 0;
			this.txtFornecedor.Size = new System.Drawing.Size(242, 28);
			this.txtFornecedor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtFornecedor.TabIndex = 12;
			this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtFornecedor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtFornecedor.UseSystemPasswordChar = false;
			// 
			// labFornecedor
			// 
			this.labFornecedor.BackColor = System.Drawing.Color.Transparent;
			this.labFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labFornecedor.Location = new System.Drawing.Point(197, 76);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(57, 25);
			this.labFornecedor.TabIndex = 13;
			this.labFornecedor.Text = "Fornec. :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtLoja
			// 
			this.txtLoja.BackColor = System.Drawing.Color.White;
			this.txtLoja.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtLoja.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtLoja.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtLoja.CustomBGColor = System.Drawing.Color.White;
			this.txtLoja.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtLoja.ForeColor = System.Drawing.Color.Black;
			this.txtLoja.Location = new System.Drawing.Point(85, 109);
			this.txtLoja.MaxLength = 32767;
			this.txtLoja.Multiline = false;
			this.txtLoja.Name = "txtLoja";
			this.txtLoja.ReadOnly = true;
			this.txtLoja.SelectionStart = 0;
			this.txtLoja.Size = new System.Drawing.Size(120, 28);
			this.txtLoja.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtLoja.TabIndex = 14;
			this.txtLoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtLoja.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtLoja.UseSystemPasswordChar = false;
			// 
			// labLoja
			// 
			this.labLoja.BackColor = System.Drawing.Color.Transparent;
			this.labLoja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLoja.Location = new System.Drawing.Point(17, 109);
			this.labLoja.Name = "labLoja";
			this.labLoja.Size = new System.Drawing.Size(62, 25);
			this.labLoja.TabIndex = 15;
			this.labLoja.Text = "Loja :";
			this.labLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.White;
			this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDescricao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CustomBGColor = System.Drawing.Color.White;
			this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtDescricao.ForeColor = System.Drawing.Color.Black;
			this.txtDescricao.Location = new System.Drawing.Point(85, 144);
			this.txtDescricao.MaxLength = 32767;
			this.txtDescricao.Multiline = false;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.ReadOnly = true;
			this.txtDescricao.SelectionStart = 0;
			this.txtDescricao.Size = new System.Drawing.Size(417, 28);
			this.txtDescricao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDescricao.TabIndex = 16;
			this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.UseSystemPasswordChar = false;
			// 
			// labDescricao
			// 
			this.labDescricao.BackColor = System.Drawing.Color.Transparent;
			this.labDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDescricao.Location = new System.Drawing.Point(-11, 144);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(90, 25);
			this.labDescricao.TabIndex = 17;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmissao
			// 
			this.txtEmissao.BackColor = System.Drawing.Color.White;
			this.txtEmissao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtEmissao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtEmissao.CustomBGColor = System.Drawing.Color.White;
			this.txtEmissao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtEmissao.ForeColor = System.Drawing.Color.Black;
			this.txtEmissao.Location = new System.Drawing.Point(286, 110);
			this.txtEmissao.MaxLength = 32767;
			this.txtEmissao.Multiline = false;
			this.txtEmissao.Name = "txtEmissao";
			this.txtEmissao.ReadOnly = true;
			this.txtEmissao.SelectionStart = 0;
			this.txtEmissao.Size = new System.Drawing.Size(84, 28);
			this.txtEmissao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtEmissao.TabIndex = 18;
			this.txtEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEmissao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEmissao.UseSystemPasswordChar = false;
			// 
			// labEmissao
			// 
			this.labEmissao.BackColor = System.Drawing.Color.Transparent;
			this.labEmissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labEmissao.Location = new System.Drawing.Point(211, 109);
			this.labEmissao.Name = "labEmissao";
			this.labEmissao.Size = new System.Drawing.Size(69, 25);
			this.labEmissao.TabIndex = 19;
			this.labEmissao.Text = "Emissão :";
			this.labEmissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.White;
			this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigo.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCodigo.ForeColor = System.Drawing.Color.Black;
			this.txtCodigo.Location = new System.Drawing.Point(85, 76);
			this.txtCodigo.MaxLength = 32767;
			this.txtCodigo.Multiline = false;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = false;
			this.txtCodigo.SelectionStart = 0;
			this.txtCodigo.Size = new System.Drawing.Size(73, 28);
			this.txtCodigo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigo.TabIndex = 20;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.UseSystemPasswordChar = false;
			this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterCodigo);
			this.txtCodigo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploCliquePesquisa);
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCodigo.Location = new System.Drawing.Point(12, 76);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(67, 25);
			this.labCodigo.TabIndex = 21;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.cbxTipo.Enabled = false;
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxTipo.ForeColor = System.Drawing.Color.Black;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxTipo.IntegralHeight = false;
			this.cbxTipo.ItemHeight = 20;
			this.cbxTipo.Items.AddRange(new object[] {
									"Custo",
									"Despesa"});
			this.cbxTipo.Location = new System.Drawing.Point(376, 111);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(126, 26);
			this.cbxTipo.StartIndex = 0;
			this.cbxTipo.TabIndex = 22;
			// 
			// txtValor
			// 
			this.txtValor.BackColor = System.Drawing.Color.White;
			this.txtValor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtValor.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValor.CustomBGColor = System.Drawing.Color.White;
			this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtValor.ForeColor = System.Drawing.Color.Black;
			this.txtValor.Location = new System.Drawing.Point(85, 179);
			this.txtValor.MaxLength = 32767;
			this.txtValor.Multiline = false;
			this.txtValor.Name = "txtValor";
			this.txtValor.ReadOnly = true;
			this.txtValor.SelectionStart = 0;
			this.txtValor.Size = new System.Drawing.Size(120, 28);
			this.txtValor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtValor.TabIndex = 23;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValor.UseSystemPasswordChar = false;
			// 
			// labValor
			// 
			this.labValor.BackColor = System.Drawing.Color.Transparent;
			this.labValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labValor.Location = new System.Drawing.Point(-1, 179);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(80, 25);
			this.labValor.TabIndex = 24;
			this.labValor.Text = "Valor (R$) :";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCategoria
			// 
			this.txtCategoria.BackColor = System.Drawing.Color.White;
			this.txtCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCategoria.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCategoria.CustomBGColor = System.Drawing.Color.White;
			this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCategoria.ForeColor = System.Drawing.Color.Black;
			this.txtCategoria.Location = new System.Drawing.Point(297, 178);
			this.txtCategoria.MaxLength = 32767;
			this.txtCategoria.Multiline = false;
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.ReadOnly = true;
			this.txtCategoria.SelectionStart = 0;
			this.txtCategoria.Size = new System.Drawing.Size(205, 28);
			this.txtCategoria.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCategoria.TabIndex = 25;
			this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCategoria.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCategoria.UseSystemPasswordChar = false;
			// 
			// labCategoria
			// 
			this.labCategoria.BackColor = System.Drawing.Color.Transparent;
			this.labCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCategoria.Location = new System.Drawing.Point(211, 178);
			this.labCategoria.Name = "labCategoria";
			this.labCategoria.Size = new System.Drawing.Size(80, 25);
			this.labCategoria.TabIndex = 26;
			this.labCategoria.Text = "Categoria :";
			this.labCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAbrir
			// 
			this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Location = new System.Drawing.Point(161, 76);
			this.btnAbrir.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Radius = 0;
			this.btnAbrir.Size = new System.Drawing.Size(33, 28);
			this.btnAbrir.Symbol = 61816;
			this.btnAbrir.TabIndex = 32;
			this.btnAbrir.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Click += new System.EventHandler(this.cliqueIr);
			// 
			// txtObservacao
			// 
			this.txtObservacao.BackColor = System.Drawing.Color.White;
			this.txtObservacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtObservacao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CustomBGColor = System.Drawing.Color.White;
			this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtObservacao.ForeColor = System.Drawing.Color.Black;
			this.txtObservacao.Location = new System.Drawing.Point(85, 213);
			this.txtObservacao.MaxLength = 32767;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.ReadOnly = true;
			this.txtObservacao.SelectionStart = 0;
			this.txtObservacao.Size = new System.Drawing.Size(417, 54);
			this.txtObservacao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtObservacao.TabIndex = 33;
			this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.UseSystemPasswordChar = false;
			// 
			// labObservacao
			// 
			this.labObservacao.BackColor = System.Drawing.Color.Transparent;
			this.labObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labObservacao.Location = new System.Drawing.Point(-11, 213);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(90, 25);
			this.labObservacao.TabIndex = 34;
			this.labObservacao.Text = "Obs. :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listaParcelas
			// 
			this.listaParcelas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04,
									this.Col05});
			this.listaParcelas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.listaParcelas.FullRowSelect = true;
			this.listaParcelas.GridLines = true;
			this.listaParcelas.Location = new System.Drawing.Point(12, 273);
			this.listaParcelas.Name = "listaParcelas";
			this.listaParcelas.Size = new System.Drawing.Size(490, 204);
			this.listaParcelas.TabIndex = 35;
			this.listaParcelas.UseCompatibleStateImageBehavior = false;
			this.listaParcelas.View = System.Windows.Forms.View.Details;
			this.listaParcelas.DoubleClick += new System.EventHandler(this.duploCliqueParcela);
			// 
			// Col01
			// 
			this.Col01.Text = "Código";
			this.Col01.Width = 70;
			// 
			// Col02
			// 
			this.Col02.Text = "P/";
			this.Col02.Width = 30;
			// 
			// Col03
			// 
			this.Col03.Text = "Vencimento";
			this.Col03.Width = 80;
			// 
			// Col04
			// 
			this.Col04.Text = "Valor (R$)";
			this.Col04.Width = 140;
			// 
			// Col05
			// 
			this.Col05.Text = "Saldo (R$)";
			this.Col05.Width = 140;
			// 
			// CSCusto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 489);
			this.Controls.Add(this.listaParcelas);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.labObservacao);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.txtCategoria);
			this.Controls.Add(this.labCategoria);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.labValor);
			this.Controls.Add(this.cbxTipo);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.txtEmissao);
			this.Controls.Add(this.labEmissao);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
			this.Controls.Add(this.txtLoja);
			this.Controls.Add(this.labLoja);
			this.Controls.Add(this.txtFornecedor);
			this.Controls.Add(this.labFornecedor);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSCusto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de Custo/Despesa";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaParcelas;
		private System.Windows.Forms.Label labObservacao;
		private GM.Componentes.MinBox txtObservacao;
		private Sunny.UI.UISymbolButton btnAbrir;
		private System.Windows.Forms.Label labCategoria;
		private GM.Componentes.MinBox txtCategoria;
		private System.Windows.Forms.Label labValor;
		private GM.Componentes.MinBox txtValor;
		private GM.Componentes.MinComboBox cbxTipo;
		private System.Windows.Forms.Label labCodigo;
		private GM.Componentes.MinBox txtCodigo;
		private System.Windows.Forms.Label labEmissao;
		private GM.Componentes.MinBox txtEmissao;
		private System.Windows.Forms.Label labDescricao;
		private GM.Componentes.MinBox txtDescricao;
		private System.Windows.Forms.Label labLoja;
		private GM.Componentes.MinBox txtLoja;
		private System.Windows.Forms.Label labFornecedor;
		private GM.Componentes.MinBox txtFornecedor;
	}
}
