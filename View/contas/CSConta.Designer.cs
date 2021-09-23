
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
			this.txtFornecedor = new System.Windows.Forms.TextBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.labCodigo = new System.Windows.Forms.Label();
			this.btnAbrir = new Sunny.UI.UISymbolButton();
			this.btnNovaMovimento = new Sunny.UI.UISymbolButton();
			this.btnAbrirReferencia = new Sunny.UI.UISymbolButton();
			this.txtReferencia = new System.Windows.Forms.TextBox();
			this.labReferencia = new System.Windows.Forms.Label();
			this.txtVencimento = new System.Windows.Forms.TextBox();
			this.labVencimento = new System.Windows.Forms.Label();
			this.txtEmissao = new System.Windows.Forms.TextBox();
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
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.txtSituação = new System.Windows.Forms.TextBox();
			this.labSituacao = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtFornecedor
			// 
			this.txtFornecedor.BackColor = System.Drawing.Color.White;
			this.txtFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtFornecedor.Location = new System.Drawing.Point(305, 9);
			this.txtFornecedor.Name = "txtFornecedor";
			this.txtFornecedor.ReadOnly = true;
			this.txtFornecedor.Size = new System.Drawing.Size(257, 25);
			this.txtFornecedor.TabIndex = 10;
			this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labFornecedor
			// 
			this.labFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labFornecedor.Location = new System.Drawing.Point(209, 9);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(90, 25);
			this.labFornecedor.TabIndex = 11;
			this.labFornecedor.Text = "Forn./Cliente :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCodigo.Location = new System.Drawing.Point(85, 9);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(73, 25);
			this.txtCodigo.TabIndex = 12;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labCodigo
			// 
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCodigo.Location = new System.Drawing.Point(12, 9);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(67, 25);
			this.labCodigo.TabIndex = 13;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAbrir
			// 
			this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Location = new System.Drawing.Point(160, 9);
			this.btnAbrir.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Radius = 0;
			this.btnAbrir.Size = new System.Drawing.Size(47, 25);
			this.btnAbrir.Symbol = 61816;
			this.btnAbrir.TabIndex = 31;
			this.btnAbrir.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Click += new System.EventHandler(this.cliquePesquisar);
			// 
			// btnNovaMovimento
			// 
			this.btnNovaMovimento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNovaMovimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovaMovimento.Location = new System.Drawing.Point(345, 239);
			this.btnNovaMovimento.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnNovaMovimento.Name = "btnNovaMovimento";
			this.btnNovaMovimento.Radius = 0;
			this.btnNovaMovimento.RectColor = System.Drawing.Color.Gray;
			this.btnNovaMovimento.Size = new System.Drawing.Size(217, 26);
			this.btnNovaMovimento.Style = Sunny.UI.UIStyle.Custom;
			this.btnNovaMovimento.Symbol = 61543;
			this.btnNovaMovimento.SymbolSize = 0;
			this.btnNovaMovimento.TabIndex = 32;
			this.btnNovaMovimento.Text = "NOVA MOVIMENTAÇÃO";
			this.btnNovaMovimento.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnNovaMovimento.Click += new System.EventHandler(this.cliqueNovoMovimentacao);
			// 
			// btnAbrirReferencia
			// 
			this.btnAbrirReferencia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbrirReferencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAbrirReferencia.Location = new System.Drawing.Point(345, 271);
			this.btnAbrirReferencia.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAbrirReferencia.Name = "btnAbrirReferencia";
			this.btnAbrirReferencia.Radius = 0;
			this.btnAbrirReferencia.RectColor = System.Drawing.Color.Gray;
			this.btnAbrirReferencia.Size = new System.Drawing.Size(217, 25);
			this.btnAbrirReferencia.Style = Sunny.UI.UIStyle.Custom;
			this.btnAbrirReferencia.Symbol = 61543;
			this.btnAbrirReferencia.SymbolSize = 0;
			this.btnAbrirReferencia.TabIndex = 33;
			this.btnAbrirReferencia.Text = "ABRIR REFERÊNCIA";
			this.btnAbrirReferencia.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrirReferencia.Click += new System.EventHandler(this.cliqueAbrirReferencia);
			// 
			// txtReferencia
			// 
			this.txtReferencia.BackColor = System.Drawing.Color.White;
			this.txtReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtReferencia.Location = new System.Drawing.Point(430, 37);
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.ReadOnly = true;
			this.txtReferencia.Size = new System.Drawing.Size(132, 25);
			this.txtReferencia.TabIndex = 34;
			this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labReferencia
			// 
			this.labReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labReferencia.Location = new System.Drawing.Point(345, 36);
			this.labReferencia.Name = "labReferencia";
			this.labReferencia.Size = new System.Drawing.Size(79, 25);
			this.labReferencia.TabIndex = 35;
			this.labReferencia.Text = "Referência :";
			this.labReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtVencimento
			// 
			this.txtVencimento.BackColor = System.Drawing.Color.White;
			this.txtVencimento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtVencimento.Location = new System.Drawing.Point(261, 37);
			this.txtVencimento.Name = "txtVencimento";
			this.txtVencimento.ReadOnly = true;
			this.txtVencimento.Size = new System.Drawing.Size(78, 25);
			this.txtVencimento.TabIndex = 36;
			this.txtVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labVencimento
			// 
			this.labVencimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labVencimento.Location = new System.Drawing.Point(171, 37);
			this.labVencimento.Name = "labVencimento";
			this.labVencimento.Size = new System.Drawing.Size(84, 25);
			this.labVencimento.TabIndex = 37;
			this.labVencimento.Text = "Vencimento :";
			this.labVencimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmissao
			// 
			this.txtEmissao.BackColor = System.Drawing.Color.White;
			this.txtEmissao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtEmissao.Location = new System.Drawing.Point(85, 37);
			this.txtEmissao.Name = "txtEmissao";
			this.txtEmissao.ReadOnly = true;
			this.txtEmissao.Size = new System.Drawing.Size(80, 25);
			this.txtEmissao.TabIndex = 38;
			this.txtEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labEmissao
			// 
			this.labEmissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labEmissao.Location = new System.Drawing.Point(12, 37);
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
			this.listaMovimento.Location = new System.Drawing.Point(12, 93);
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
			this.labMovimento.Location = new System.Drawing.Point(12, 68);
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
			this.listaRelacao.Location = new System.Drawing.Point(12, 264);
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
			this.labRelacao.Location = new System.Drawing.Point(12, 239);
			this.labRelacao.Name = "labRelacao";
			this.labRelacao.Size = new System.Drawing.Size(327, 26);
			this.labRelacao.TabIndex = 43;
			this.labRelacao.Text = "Relações";
			this.labRelacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labSaldo
			// 
			this.labSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSaldo.Location = new System.Drawing.Point(345, 330);
			this.labSaldo.Name = "labSaldo";
			this.labSaldo.Size = new System.Drawing.Size(217, 26);
			this.labSaldo.TabIndex = 44;
			this.labSaldo.Text = "Saldo";
			this.labSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtSaldo
			// 
			this.txtSaldo.BackColor = System.Drawing.Color.White;
			this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSaldo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSaldo.Location = new System.Drawing.Point(345, 355);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.ReadOnly = true;
			this.txtSaldo.Size = new System.Drawing.Size(217, 25);
			this.txtSaldo.TabIndex = 45;
			this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSituação
			// 
			this.txtSituação.BackColor = System.Drawing.Color.White;
			this.txtSituação.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSituação.Location = new System.Drawing.Point(419, 301);
			this.txtSituação.Name = "txtSituação";
			this.txtSituação.ReadOnly = true;
			this.txtSituação.Size = new System.Drawing.Size(143, 25);
			this.txtSituação.TabIndex = 46;
			this.txtSituação.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labSituacao
			// 
			this.labSituacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSituacao.Location = new System.Drawing.Point(345, 301);
			this.labSituacao.Name = "labSituacao";
			this.labSituacao.Size = new System.Drawing.Size(68, 25);
			this.labSituacao.TabIndex = 47;
			this.labSituacao.Text = "Situação :";
			this.labSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CSConta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 392);
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
			this.Controls.Add(this.btnAbrirReferencia);
			this.Controls.Add(this.btnNovaMovimento);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.txtFornecedor);
			this.Controls.Add(this.labFornecedor);
			this.Controls.Add(this.labMovimento);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CSConta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de conta";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labSituacao;
		private System.Windows.Forms.TextBox txtSituação;
		private System.Windows.Forms.TextBox txtSaldo;
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
		private System.Windows.Forms.TextBox txtEmissao;
		private System.Windows.Forms.Label labVencimento;
		private System.Windows.Forms.TextBox txtVencimento;
		private System.Windows.Forms.Label labReferencia;
		private System.Windows.Forms.TextBox txtReferencia;
		private Sunny.UI.UISymbolButton btnAbrirReferencia;
		private Sunny.UI.UISymbolButton btnNovaMovimento;
		private Sunny.UI.UISymbolButton btnAbrir;
		private System.Windows.Forms.Label labCodigo;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label labFornecedor;
		private System.Windows.Forms.TextBox txtFornecedor;
	}
}
