
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
			this.listaMovimento = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.labProduto = new System.Windows.Forms.Label();
			this.txtProduto = new System.Windows.Forms.TextBox();
			this.btnAbrir = new Sunny.UI.UISymbolButton();
			this.txtUnidade = new System.Windows.Forms.TextBox();
			this.labSituacao = new System.Windows.Forms.Label();
			this.cbxSituacao = new System.Windows.Forms.ComboBox();
			this.labAte = new System.Windows.Forms.Label();
			this.labPeriodo = new System.Windows.Forms.Label();
			this.txtDtFinal = new System.Windows.Forms.TextBox();
			this.txtDtInicio = new System.Windows.Forms.TextBox();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.labSaldo = new System.Windows.Forms.Label();
			this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// listaMovimento
			// 
			this.listaMovimento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04});
			this.listaMovimento.FullRowSelect = true;
			this.listaMovimento.GridLines = true;
			this.listaMovimento.Location = new System.Drawing.Point(12, 96);
			this.listaMovimento.MultiSelect = false;
			this.listaMovimento.Name = "listaMovimento";
			this.listaMovimento.Size = new System.Drawing.Size(397, 390);
			this.listaMovimento.TabIndex = 0;
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
			this.txtCodigo.Location = new System.Drawing.Point(91, 9);
			this.txtCodigo.MaxLength = 50;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(45, 23);
			this.txtCodigo.TabIndex = 8;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCodigo.Leave += new System.EventHandler(this.buscaProduto);
			// 
			// labProduto
			// 
			this.labProduto.Location = new System.Drawing.Point(12, 9);
			this.labProduto.Name = "labProduto";
			this.labProduto.Size = new System.Drawing.Size(73, 23);
			this.labProduto.TabIndex = 9;
			this.labProduto.Text = "Produto :";
			this.labProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtProduto
			// 
			this.txtProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtProduto.Location = new System.Drawing.Point(183, 9);
			this.txtProduto.MaxLength = 50;
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.ReadOnly = true;
			this.txtProduto.Size = new System.Drawing.Size(226, 23);
			this.txtProduto.TabIndex = 10;
			this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnAbrir
			// 
			this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Location = new System.Drawing.Point(136, 9);
			this.btnAbrir.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Radius = 0;
			this.btnAbrir.Size = new System.Drawing.Size(41, 23);
			this.btnAbrir.Symbol = 61442;
			this.btnAbrir.TabIndex = 32;
			this.btnAbrir.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Click += new System.EventHandler(this.cliqueProcurarProduto);
			// 
			// txtUnidade
			// 
			this.txtUnidade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtUnidade.Location = new System.Drawing.Point(203, 38);
			this.txtUnidade.MaxLength = 50;
			this.txtUnidade.Name = "txtUnidade";
			this.txtUnidade.ReadOnly = true;
			this.txtUnidade.Size = new System.Drawing.Size(38, 23);
			this.txtUnidade.TabIndex = 34;
			this.txtUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labSituacao
			// 
			this.labSituacao.Location = new System.Drawing.Point(246, 38);
			this.labSituacao.Name = "labSituacao";
			this.labSituacao.Size = new System.Drawing.Size(60, 23);
			this.labSituacao.TabIndex = 35;
			this.labSituacao.Text = "Situação:";
			this.labSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSituacao
			// 
			this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSituacao.Enabled = false;
			this.cbxSituacao.FormattingEnabled = true;
			this.cbxSituacao.Items.AddRange(new object[] {
									"SUSPENSO",
									"ATIVO"});
			this.cbxSituacao.Location = new System.Drawing.Point(312, 38);
			this.cbxSituacao.Name = "cbxSituacao";
			this.cbxSituacao.Size = new System.Drawing.Size(97, 23);
			this.cbxSituacao.TabIndex = 36;
			// 
			// labAte
			// 
			this.labAte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAte.Location = new System.Drawing.Point(183, 66);
			this.labAte.Name = "labAte";
			this.labAte.Size = new System.Drawing.Size(31, 23);
			this.labAte.TabIndex = 40;
			this.labAte.Text = "até";
			this.labAte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labPeriodo
			// 
			this.labPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPeriodo.Location = new System.Drawing.Point(12, 67);
			this.labPeriodo.Name = "labPeriodo";
			this.labPeriodo.Size = new System.Drawing.Size(73, 23);
			this.labPeriodo.TabIndex = 39;
			this.labPeriodo.Text = "Período :";
			this.labPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDtFinal
			// 
			this.txtDtFinal.Location = new System.Drawing.Point(220, 67);
			this.txtDtFinal.Name = "txtDtFinal";
			this.txtDtFinal.Size = new System.Drawing.Size(86, 23);
			this.txtDtFinal.TabIndex = 38;
			this.txtDtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDtFinal.TextChanged += new System.EventHandler(this.maskData);
			this.txtDtFinal.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// txtDtInicio
			// 
			this.txtDtInicio.Location = new System.Drawing.Point(91, 67);
			this.txtDtInicio.Name = "txtDtInicio";
			this.txtDtInicio.Size = new System.Drawing.Size(86, 23);
			this.txtDtInicio.TabIndex = 37;
			this.txtDtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDtInicio.TextChanged += new System.EventHandler(this.maskData);
			this.txtDtInicio.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// txtSaldo
			// 
			this.txtSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtSaldo.Location = new System.Drawing.Point(91, 38);
			this.txtSaldo.MaxLength = 50;
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.ReadOnly = true;
			this.txtSaldo.Size = new System.Drawing.Size(106, 23);
			this.txtSaldo.TabIndex = 42;
			this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labSaldo
			// 
			this.labSaldo.Location = new System.Drawing.Point(12, 38);
			this.labSaldo.Name = "labSaldo";
			this.labSaldo.Size = new System.Drawing.Size(73, 23);
			this.labSaldo.TabIndex = 41;
			this.labSaldo.Text = "Saldo :";
			this.labSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// uiSymbolButton1
			// 
			this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.uiSymbolButton1.Location = new System.Drawing.Point(312, 67);
			this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiSymbolButton1.Name = "uiSymbolButton1";
			this.uiSymbolButton1.Radius = 0;
			this.uiSymbolButton1.Size = new System.Drawing.Size(97, 23);
			this.uiSymbolButton1.Symbol = 61442;
			this.uiSymbolButton1.TabIndex = 43;
			this.uiSymbolButton1.Text = "Pesquisar";
			this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.uiSymbolButton1.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// CSEstoque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 498);
			this.Controls.Add(this.uiSymbolButton1);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.labSaldo);
			this.Controls.Add(this.labAte);
			this.Controls.Add(this.labPeriodo);
			this.Controls.Add(this.txtDtFinal);
			this.Controls.Add(this.txtDtInicio);
			this.Controls.Add(this.cbxSituacao);
			this.Controls.Add(this.labSituacao);
			this.Controls.Add(this.txtUnidade);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.txtProduto);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labProduto);
			this.Controls.Add(this.listaMovimento);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CSEstoque";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de Estoque";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton uiSymbolButton1;
		private System.Windows.Forms.Label labSaldo;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.TextBox txtDtInicio;
		private System.Windows.Forms.TextBox txtDtFinal;
		private System.Windows.Forms.Label labPeriodo;
		private System.Windows.Forms.Label labAte;
		private System.Windows.Forms.ComboBox cbxSituacao;
		private System.Windows.Forms.Label labSituacao;
		private System.Windows.Forms.TextBox txtUnidade;
		private Sunny.UI.UISymbolButton btnAbrir;
		private System.Windows.Forms.TextBox txtProduto;
		private System.Windows.Forms.Label labProduto;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaMovimento;
	}
}
