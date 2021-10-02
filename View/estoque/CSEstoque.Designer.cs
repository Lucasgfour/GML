
namespace GM.View.estoque
{
	partial class CSEstoque
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSEstoque));
			this.listaMovimento = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.txtCodigo = new GM.Componentes.MinBox();
			this.labProduto = new System.Windows.Forms.Label();
			this.txtProduto = new GM.Componentes.MinBox();
			this.txtUnidade = new GM.Componentes.MinBox();
			this.labSituacao = new System.Windows.Forms.Label();
			this.cbxSituacao = new GM.Componentes.MinComboBox();
			this.labAte = new System.Windows.Forms.Label();
			this.labPeriodo = new System.Windows.Forms.Label();
			this.txtDtFinal = new GM.Componentes.MinBox();
			this.txtDtInicio = new GM.Componentes.MinBox();
			this.txtSaldo = new GM.Componentes.MinBox();
			this.labSaldo = new System.Windows.Forms.Label();
			this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listaMovimento
			// 
			this.listaMovimento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04});
			this.listaMovimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaMovimento.FullRowSelect = true;
			this.listaMovimento.GridLines = true;
			this.listaMovimento.Location = new System.Drawing.Point(12, 167);
			this.listaMovimento.MultiSelect = false;
			this.listaMovimento.Name = "listaMovimento";
			this.listaMovimento.Size = new System.Drawing.Size(397, 388);
			this.listaMovimento.TabIndex = 6;
			this.listaMovimento.UseCompatibleStateImageBehavior = false;
			this.listaMovimento.View = System.Windows.Forms.View.Details;
			this.listaMovimento.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploCliqueLista);
			// 
			// Col01
			// 
			this.Col01.Text = "Data";
			this.Col01.Width = 80;
			// 
			// Col02
			// 
			this.Col02.Text = "Quantidade       ";
			this.Col02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Col02.Width = 110;
			// 
			// Col03
			// 
			this.Col03.Text = "Tipo";
			this.Col03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col03.Width = 80;
			// 
			// Col04
			// 
			this.Col04.Text = "Referência";
			this.Col04.Width = 90;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
			this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigo.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.ForeColor = System.Drawing.Color.Black;
			this.txtCodigo.Location = new System.Drawing.Point(77, 71);
			this.txtCodigo.MaxLength = 50;
			this.txtCodigo.Multiline = false;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = false;
			this.txtCodigo.SelectionStart = 0;
			this.txtCodigo.Size = new System.Drawing.Size(45, 26);
			this.txtCodigo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigo.TabIndex = 1;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.UseSystemPasswordChar = false;
			this.txtCodigo.Leave += new System.EventHandler(this.buscaProduto);
			// 
			// labProduto
			// 
			this.labProduto.BackColor = System.Drawing.Color.Transparent;
			this.labProduto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labProduto.Location = new System.Drawing.Point(12, 71);
			this.labProduto.Name = "labProduto";
			this.labProduto.Size = new System.Drawing.Size(59, 28);
			this.labProduto.TabIndex = 9;
			this.labProduto.Text = "Produto :";
			this.labProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtProduto
			// 
			this.txtProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtProduto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtProduto.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtProduto.CustomBGColor = System.Drawing.Color.White;
			this.txtProduto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProduto.ForeColor = System.Drawing.Color.Black;
			this.txtProduto.Location = new System.Drawing.Point(164, 71);
			this.txtProduto.MaxLength = 50;
			this.txtProduto.Multiline = false;
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.ReadOnly = true;
			this.txtProduto.SelectionStart = 0;
			this.txtProduto.Size = new System.Drawing.Size(245, 26);
			this.txtProduto.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtProduto.TabIndex = 10;
			this.txtProduto.TabStop = false;
			this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtProduto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtProduto.UseSystemPasswordChar = false;
			// 
			// txtUnidade
			// 
			this.txtUnidade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtUnidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtUnidade.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtUnidade.CustomBGColor = System.Drawing.Color.White;
			this.txtUnidade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidade.ForeColor = System.Drawing.Color.Black;
			this.txtUnidade.Location = new System.Drawing.Point(189, 103);
			this.txtUnidade.MaxLength = 50;
			this.txtUnidade.Multiline = false;
			this.txtUnidade.Name = "txtUnidade";
			this.txtUnidade.ReadOnly = true;
			this.txtUnidade.SelectionStart = 0;
			this.txtUnidade.Size = new System.Drawing.Size(38, 26);
			this.txtUnidade.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtUnidade.TabIndex = 34;
			this.txtUnidade.TabStop = false;
			this.txtUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUnidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUnidade.UseSystemPasswordChar = false;
			// 
			// labSituacao
			// 
			this.labSituacao.BackColor = System.Drawing.Color.Transparent;
			this.labSituacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSituacao.Location = new System.Drawing.Point(233, 105);
			this.labSituacao.Name = "labSituacao";
			this.labSituacao.Size = new System.Drawing.Size(60, 24);
			this.labSituacao.TabIndex = 35;
			this.labSituacao.Text = "Situação:";
			this.labSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSituacao
			// 
			this.cbxSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxSituacao.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSituacao.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSituacao.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxSituacao.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxSituacao.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxSituacao.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSituacao.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSituacao.ColorH = System.Drawing.Color.White;
			this.cbxSituacao.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxSituacao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxSituacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxSituacao.DropDownHeight = 100;
			this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSituacao.Enabled = false;
			this.cbxSituacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSituacao.ForeColor = System.Drawing.Color.Black;
			this.cbxSituacao.FormattingEnabled = true;
			this.cbxSituacao.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxSituacao.IntegralHeight = false;
			this.cbxSituacao.ItemHeight = 20;
			this.cbxSituacao.Items.AddRange(new object[] {
									"SUSPENSO",
									"ATIVO"});
			this.cbxSituacao.Location = new System.Drawing.Point(299, 103);
			this.cbxSituacao.Name = "cbxSituacao";
			this.cbxSituacao.Size = new System.Drawing.Size(110, 26);
			this.cbxSituacao.StartIndex = 0;
			this.cbxSituacao.TabIndex = 36;
			this.cbxSituacao.TabStop = false;
			// 
			// labAte
			// 
			this.labAte.BackColor = System.Drawing.Color.Transparent;
			this.labAte.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAte.Location = new System.Drawing.Point(158, 135);
			this.labAte.Name = "labAte";
			this.labAte.Size = new System.Drawing.Size(28, 26);
			this.labAte.TabIndex = 40;
			this.labAte.Text = "até";
			this.labAte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labPeriodo
			// 
			this.labPeriodo.BackColor = System.Drawing.Color.Transparent;
			this.labPeriodo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPeriodo.Location = new System.Drawing.Point(12, 135);
			this.labPeriodo.Name = "labPeriodo";
			this.labPeriodo.Size = new System.Drawing.Size(59, 23);
			this.labPeriodo.TabIndex = 39;
			this.labPeriodo.Text = "Período :";
			this.labPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDtFinal
			// 
			this.txtDtFinal.BackColor = System.Drawing.Color.Transparent;
			this.txtDtFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDtFinal.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDtFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDtFinal.CustomBGColor = System.Drawing.Color.White;
			this.txtDtFinal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDtFinal.ForeColor = System.Drawing.Color.Black;
			this.txtDtFinal.Location = new System.Drawing.Point(188, 135);
			this.txtDtFinal.MaxLength = 10;
			this.txtDtFinal.Multiline = false;
			this.txtDtFinal.Name = "txtDtFinal";
			this.txtDtFinal.ReadOnly = false;
			this.txtDtFinal.SelectionStart = 0;
			this.txtDtFinal.Size = new System.Drawing.Size(80, 26);
			this.txtDtFinal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDtFinal.TabIndex = 4;
			this.txtDtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDtFinal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDtFinal.UseSystemPasswordChar = false;
			this.txtDtFinal.TextChanged += new System.EventHandler(this.maskData);
			this.txtDtFinal.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// txtDtInicio
			// 
			this.txtDtInicio.BackColor = System.Drawing.Color.Transparent;
			this.txtDtInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDtInicio.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDtInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDtInicio.CustomBGColor = System.Drawing.Color.White;
			this.txtDtInicio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDtInicio.ForeColor = System.Drawing.Color.Black;
			this.txtDtInicio.Location = new System.Drawing.Point(77, 135);
			this.txtDtInicio.MaxLength = 10;
			this.txtDtInicio.Multiline = false;
			this.txtDtInicio.Name = "txtDtInicio";
			this.txtDtInicio.ReadOnly = false;
			this.txtDtInicio.SelectionStart = 0;
			this.txtDtInicio.Size = new System.Drawing.Size(80, 26);
			this.txtDtInicio.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDtInicio.TabIndex = 3;
			this.txtDtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDtInicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDtInicio.UseSystemPasswordChar = false;
			this.txtDtInicio.TextChanged += new System.EventHandler(this.maskData);
			this.txtDtInicio.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// txtSaldo
			// 
			this.txtSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtSaldo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtSaldo.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSaldo.CustomBGColor = System.Drawing.Color.White;
			this.txtSaldo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaldo.ForeColor = System.Drawing.Color.Black;
			this.txtSaldo.Location = new System.Drawing.Point(77, 103);
			this.txtSaldo.MaxLength = 50;
			this.txtSaldo.Multiline = false;
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.ReadOnly = true;
			this.txtSaldo.SelectionStart = 0;
			this.txtSaldo.Size = new System.Drawing.Size(106, 26);
			this.txtSaldo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtSaldo.TabIndex = 42;
			this.txtSaldo.TabStop = false;
			this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSaldo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSaldo.UseSystemPasswordChar = false;
			// 
			// labSaldo
			// 
			this.labSaldo.BackColor = System.Drawing.Color.Transparent;
			this.labSaldo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSaldo.Location = new System.Drawing.Point(12, 103);
			this.labSaldo.Name = "labSaldo";
			this.labSaldo.Size = new System.Drawing.Size(59, 23);
			this.labSaldo.TabIndex = 41;
			this.labSaldo.Text = "Saldo :";
			this.labSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Depth = 0;
			this.btnPesquisar.Location = new System.Drawing.Point(274, 135);
			this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Primary = true;
			this.btnPesquisar.Size = new System.Drawing.Size(135, 26);
			this.btnPesquisar.TabIndex = 5;
			this.btnPesquisar.Text = "CONSULTAR";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
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
			this.button1.Location = new System.Drawing.Point(124, 71);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(38, 26);
			this.button1.TabIndex = 2;
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.cliqueProcurarProduto);
			// 
			// CSEstoque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 567);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.labSaldo);
			this.Controls.Add(this.labAte);
			this.Controls.Add(this.labPeriodo);
			this.Controls.Add(this.txtDtFinal);
			this.Controls.Add(this.txtDtInicio);
			this.Controls.Add(this.cbxSituacao);
			this.Controls.Add(this.labSituacao);
			this.Controls.Add(this.txtUnidade);
			this.Controls.Add(this.txtProduto);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labProduto);
			this.Controls.Add(this.listaMovimento);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSEstoque";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de Estoque";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
		private System.Windows.Forms.Label labSaldo;
		private GM.Componentes.MinBox txtSaldo;
		private GM.Componentes.MinBox txtDtInicio;
		private GM.Componentes.MinBox txtDtFinal;
		private System.Windows.Forms.Label labPeriodo;
		private System.Windows.Forms.Label labAte;
		private GM.Componentes.MinComboBox cbxSituacao;
		private System.Windows.Forms.Label labSituacao;
		private GM.Componentes.MinBox txtUnidade;
		private GM.Componentes.MinBox txtProduto;
		private System.Windows.Forms.Label labProduto;
		private GM.Componentes.MinBox txtCodigo;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaMovimento;
	}
}
