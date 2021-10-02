
namespace GM.View.contas
{
	partial class CSConta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSConta));
			this.txtFornecedor = new GM.Componentes.MinBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.txtCodigo = new GM.Componentes.MinBox();
			this.labCodigo = new System.Windows.Forms.Label();
			this.txtReferencia = new GM.Componentes.MinBox();
			this.labReferencia = new System.Windows.Forms.Label();
			this.txtVencimento = new GM.Componentes.MinBox();
			this.labVencimento = new System.Windows.Forms.Label();
			this.txtEmissao = new GM.Componentes.MinBox();
			this.labEmissao = new System.Windows.Forms.Label();
			this.listaMovimento = new System.Windows.Forms.ListView();
			this.ColMv1 = new System.Windows.Forms.ColumnHeader();
			this.ColMv2 = new System.Windows.Forms.ColumnHeader();
			this.ColMv3 = new System.Windows.Forms.ColumnHeader();
			this.labMovimento = new System.Windows.Forms.Label();
			this.listaRelacao = new System.Windows.Forms.ListView();
			this.ColRe1 = new System.Windows.Forms.ColumnHeader();
			this.ColRe2 = new System.Windows.Forms.ColumnHeader();
			this.ColRe3 = new System.Windows.Forms.ColumnHeader();
			this.labRelacao = new System.Windows.Forms.Label();
			this.labSaldo = new System.Windows.Forms.Label();
			this.txtSaldo = new GM.Componentes.MinBox();
			this.txtSituação = new GM.Componentes.MinBox();
			this.labSituacao = new System.Windows.Forms.Label();
			this.btnEntrada = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnReferencia = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnAbrir = new System.Windows.Forms.Button();
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
			this.txtFornecedor.Location = new System.Drawing.Point(305, 70);
			this.txtFornecedor.MaxLength = 32767;
			this.txtFornecedor.Multiline = false;
			this.txtFornecedor.Name = "txtFornecedor";
			this.txtFornecedor.ReadOnly = true;
			this.txtFornecedor.SelectionStart = 0;
			this.txtFornecedor.Size = new System.Drawing.Size(257, 28);
			this.txtFornecedor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtFornecedor.TabIndex = 10;
			this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtFornecedor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtFornecedor.UseSystemPasswordChar = false;
			// 
			// labFornecedor
			// 
			this.labFornecedor.BackColor = System.Drawing.Color.Transparent;
			this.labFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labFornecedor.Location = new System.Drawing.Point(209, 70);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(90, 28);
			this.labFornecedor.TabIndex = 11;
			this.labFornecedor.Text = "Forn./Cliente :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.txtCodigo.Location = new System.Drawing.Point(85, 70);
			this.txtCodigo.MaxLength = 32767;
			this.txtCodigo.Multiline = false;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = false;
			this.txtCodigo.SelectionStart = 0;
			this.txtCodigo.Size = new System.Drawing.Size(73, 28);
			this.txtCodigo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigo.TabIndex = 12;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.UseSystemPasswordChar = false;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCodigo.Location = new System.Drawing.Point(12, 70);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(67, 28);
			this.labCodigo.TabIndex = 13;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtReferencia
			// 
			this.txtReferencia.BackColor = System.Drawing.Color.White;
			this.txtReferencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtReferencia.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtReferencia.CustomBGColor = System.Drawing.Color.White;
			this.txtReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtReferencia.ForeColor = System.Drawing.Color.Black;
			this.txtReferencia.Location = new System.Drawing.Point(430, 104);
			this.txtReferencia.MaxLength = 32767;
			this.txtReferencia.Multiline = false;
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.ReadOnly = true;
			this.txtReferencia.SelectionStart = 0;
			this.txtReferencia.Size = new System.Drawing.Size(132, 28);
			this.txtReferencia.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtReferencia.TabIndex = 34;
			this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtReferencia.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtReferencia.UseSystemPasswordChar = false;
			// 
			// labReferencia
			// 
			this.labReferencia.BackColor = System.Drawing.Color.Transparent;
			this.labReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labReferencia.Location = new System.Drawing.Point(345, 103);
			this.labReferencia.Name = "labReferencia";
			this.labReferencia.Size = new System.Drawing.Size(79, 25);
			this.labReferencia.TabIndex = 35;
			this.labReferencia.Text = "Referência :";
			this.labReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtVencimento
			// 
			this.txtVencimento.BackColor = System.Drawing.Color.White;
			this.txtVencimento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtVencimento.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtVencimento.CustomBGColor = System.Drawing.Color.White;
			this.txtVencimento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtVencimento.ForeColor = System.Drawing.Color.Black;
			this.txtVencimento.Location = new System.Drawing.Point(261, 104);
			this.txtVencimento.MaxLength = 32767;
			this.txtVencimento.Multiline = false;
			this.txtVencimento.Name = "txtVencimento";
			this.txtVencimento.ReadOnly = true;
			this.txtVencimento.SelectionStart = 0;
			this.txtVencimento.Size = new System.Drawing.Size(78, 28);
			this.txtVencimento.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtVencimento.TabIndex = 36;
			this.txtVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtVencimento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtVencimento.UseSystemPasswordChar = false;
			// 
			// labVencimento
			// 
			this.labVencimento.BackColor = System.Drawing.Color.Transparent;
			this.labVencimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labVencimento.Location = new System.Drawing.Point(171, 104);
			this.labVencimento.Name = "labVencimento";
			this.labVencimento.Size = new System.Drawing.Size(84, 25);
			this.labVencimento.TabIndex = 37;
			this.labVencimento.Text = "Vencimento :";
			this.labVencimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.txtEmissao.Location = new System.Drawing.Point(85, 104);
			this.txtEmissao.MaxLength = 32767;
			this.txtEmissao.Multiline = false;
			this.txtEmissao.Name = "txtEmissao";
			this.txtEmissao.ReadOnly = true;
			this.txtEmissao.SelectionStart = 0;
			this.txtEmissao.Size = new System.Drawing.Size(80, 28);
			this.txtEmissao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtEmissao.TabIndex = 38;
			this.txtEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEmissao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEmissao.UseSystemPasswordChar = false;
			// 
			// labEmissao
			// 
			this.labEmissao.BackColor = System.Drawing.Color.Transparent;
			this.labEmissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labEmissao.Location = new System.Drawing.Point(12, 104);
			this.labEmissao.Name = "labEmissao";
			this.labEmissao.Size = new System.Drawing.Size(67, 25);
			this.labEmissao.TabIndex = 39;
			this.labEmissao.Text = "Emissão :";
			this.labEmissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listaMovimento
			// 
			this.listaMovimento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColMv1,
									this.ColMv2,
									this.ColMv3});
			this.listaMovimento.FullRowSelect = true;
			this.listaMovimento.GridLines = true;
			this.listaMovimento.Location = new System.Drawing.Point(12, 163);
			this.listaMovimento.Name = "listaMovimento";
			this.listaMovimento.Size = new System.Drawing.Size(550, 143);
			this.listaMovimento.TabIndex = 40;
			this.listaMovimento.UseCompatibleStateImageBehavior = false;
			this.listaMovimento.View = System.Windows.Forms.View.Details;
			// 
			// ColMv1
			// 
			this.ColMv1.Text = "Data";
			this.ColMv1.Width = 80;
			// 
			// ColMv2
			// 
			this.ColMv2.Text = "Descrição";
			this.ColMv2.Width = 300;
			// 
			// ColMv3
			// 
			this.ColMv3.Text = "Valor (R$)";
			this.ColMv3.Width = 130;
			// 
			// labMovimento
			// 
			this.labMovimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labMovimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labMovimento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labMovimento.Location = new System.Drawing.Point(12, 138);
			this.labMovimento.Name = "labMovimento";
			this.labMovimento.Size = new System.Drawing.Size(550, 26);
			this.labMovimento.TabIndex = 41;
			this.labMovimento.Text = "Movimentações";
			this.labMovimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listaRelacao
			// 
			this.listaRelacao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColRe1,
									this.ColRe2,
									this.ColRe3});
			this.listaRelacao.FullRowSelect = true;
			this.listaRelacao.GridLines = true;
			this.listaRelacao.Location = new System.Drawing.Point(12, 334);
			this.listaRelacao.Name = "listaRelacao";
			this.listaRelacao.Size = new System.Drawing.Size(327, 116);
			this.listaRelacao.TabIndex = 42;
			this.listaRelacao.UseCompatibleStateImageBehavior = false;
			this.listaRelacao.View = System.Windows.Forms.View.Details;
			// 
			// ColRe1
			// 
			this.ColRe1.Text = "Número";
			this.ColRe1.Width = 70;
			// 
			// ColRe2
			// 
			this.ColRe2.Text = "Vencimento";
			this.ColRe2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColRe2.Width = 80;
			// 
			// ColRe3
			// 
			this.ColRe3.Text = "Valor (R$)";
			this.ColRe3.Width = 150;
			// 
			// labRelacao
			// 
			this.labRelacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labRelacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labRelacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labRelacao.Location = new System.Drawing.Point(12, 309);
			this.labRelacao.Name = "labRelacao";
			this.labRelacao.Size = new System.Drawing.Size(327, 26);
			this.labRelacao.TabIndex = 43;
			this.labRelacao.Text = "Relações";
			this.labRelacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labSaldo
			// 
			this.labSaldo.BackColor = System.Drawing.Color.Transparent;
			this.labSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSaldo.Location = new System.Drawing.Point(345, 421);
			this.labSaldo.Name = "labSaldo";
			this.labSaldo.Size = new System.Drawing.Size(68, 28);
			this.labSaldo.TabIndex = 44;
			this.labSaldo.Text = "Saldo :";
			this.labSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSaldo
			// 
			this.txtSaldo.BackColor = System.Drawing.Color.White;
			this.txtSaldo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtSaldo.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSaldo.CustomBGColor = System.Drawing.Color.White;
			this.txtSaldo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSaldo.ForeColor = System.Drawing.Color.Black;
			this.txtSaldo.Location = new System.Drawing.Point(419, 421);
			this.txtSaldo.MaxLength = 32767;
			this.txtSaldo.Multiline = false;
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.ReadOnly = true;
			this.txtSaldo.SelectionStart = 0;
			this.txtSaldo.Size = new System.Drawing.Size(143, 28);
			this.txtSaldo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtSaldo.TabIndex = 45;
			this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSaldo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSaldo.UseSystemPasswordChar = false;
			// 
			// txtSituação
			// 
			this.txtSituação.BackColor = System.Drawing.Color.White;
			this.txtSituação.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtSituação.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSituação.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSituação.CustomBGColor = System.Drawing.Color.White;
			this.txtSituação.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSituação.ForeColor = System.Drawing.Color.Black;
			this.txtSituação.Location = new System.Drawing.Point(419, 387);
			this.txtSituação.MaxLength = 32767;
			this.txtSituação.Multiline = false;
			this.txtSituação.Name = "txtSituação";
			this.txtSituação.ReadOnly = true;
			this.txtSituação.SelectionStart = 0;
			this.txtSituação.Size = new System.Drawing.Size(143, 28);
			this.txtSituação.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtSituação.TabIndex = 46;
			this.txtSituação.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSituação.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSituação.UseSystemPasswordChar = false;
			// 
			// labSituacao
			// 
			this.labSituacao.BackColor = System.Drawing.Color.Transparent;
			this.labSituacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.labSituacao.Location = new System.Drawing.Point(345, 387);
			this.labSituacao.Name = "labSituacao";
			this.labSituacao.Size = new System.Drawing.Size(68, 25);
			this.labSituacao.TabIndex = 47;
			this.labSituacao.Text = "Situação :";
			this.labSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnEntrada
			// 
			this.btnEntrada.Depth = 0;
			this.btnEntrada.Location = new System.Drawing.Point(345, 309);
			this.btnEntrada.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnEntrada.Name = "btnEntrada";
			this.btnEntrada.Primary = true;
			this.btnEntrada.Size = new System.Drawing.Size(217, 38);
			this.btnEntrada.TabIndex = 61;
			this.btnEntrada.Text = "NOVA MOVIMENTAÇÃO";
			this.btnEntrada.UseVisualStyleBackColor = true;
			this.btnEntrada.Click += new System.EventHandler(this.cliqueNovoMovimentacao);
			// 
			// btnReferencia
			// 
			this.btnReferencia.Depth = 0;
			this.btnReferencia.Location = new System.Drawing.Point(345, 353);
			this.btnReferencia.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnReferencia.Name = "btnReferencia";
			this.btnReferencia.Primary = true;
			this.btnReferencia.Size = new System.Drawing.Size(217, 28);
			this.btnReferencia.TabIndex = 62;
			this.btnReferencia.Text = "ABRIR REFERÊNCIA";
			this.btnReferencia.UseVisualStyleBackColor = true;
			this.btnReferencia.Click += new System.EventHandler(this.cliqueAbrirReferencia);
			// 
			// btnAbrir
			// 
			this.btnAbrir.BackColor = System.Drawing.Color.Transparent;
			this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnAbrir.FlatAppearance.BorderSize = 0;
			this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbrir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAbrir.ForeColor = System.Drawing.Color.White;
			this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
			this.btnAbrir.Location = new System.Drawing.Point(160, 70);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Size = new System.Drawing.Size(38, 28);
			this.btnAbrir.TabIndex = 63;
			this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAbrir.UseVisualStyleBackColor = false;
			this.btnAbrir.Click += new System.EventHandler(this.cliquePesquisar);
			// 
			// CSConta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 461);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.btnReferencia);
			this.Controls.Add(this.btnEntrada);
			this.Controls.Add(this.txtSituação);
			this.Controls.Add(this.labSituacao);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.labSaldo);
			this.Controls.Add(this.listaRelacao);
			this.Controls.Add(this.labRelacao);
			this.Controls.Add(this.listaMovimento);
			this.Controls.Add(this.txtEmissao);
			this.Controls.Add(this.labEmissao);
			this.Controls.Add(this.txtVencimento);
			this.Controls.Add(this.labVencimento);
			this.Controls.Add(this.txtReferencia);
			this.Controls.Add(this.labReferencia);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.txtFornecedor);
			this.Controls.Add(this.labFornecedor);
			this.Controls.Add(this.labMovimento);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSConta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de conta";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnAbrir;
		private MaterialSkin.Controls.MaterialRaisedButton btnReferencia;
		private MaterialSkin.Controls.MaterialRaisedButton btnEntrada;
		private System.Windows.Forms.Label labSituacao;
		private GM.Componentes.MinBox txtSituação;
		private GM.Componentes.MinBox txtSaldo;
		private System.Windows.Forms.Label labSaldo;
		private System.Windows.Forms.Label labRelacao;
		private System.Windows.Forms.ColumnHeader ColRe3;
		private System.Windows.Forms.ColumnHeader ColRe2;
		private System.Windows.Forms.ColumnHeader ColRe1;
		private System.Windows.Forms.ListView listaRelacao;
		private System.Windows.Forms.Label labMovimento;
		private System.Windows.Forms.ColumnHeader ColMv3;
		private System.Windows.Forms.ColumnHeader ColMv2;
		private System.Windows.Forms.ColumnHeader ColMv1;
		private System.Windows.Forms.ListView listaMovimento;
		private System.Windows.Forms.Label labEmissao;
		private GM.Componentes.MinBox txtEmissao;
		private System.Windows.Forms.Label labVencimento;
		private GM.Componentes.MinBox txtVencimento;
		private System.Windows.Forms.Label labReferencia;
		private GM.Componentes.MinBox txtReferencia;
		private System.Windows.Forms.Label labCodigo;
		private GM.Componentes.MinBox txtCodigo;
		private System.Windows.Forms.Label labFornecedor;
		private GM.Componentes.MinBox txtFornecedor;
	}
}
