
namespace GM.View.contas
{
	partial class CSCredito
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSCredito));
			this.btnAbrir = new Sunny.UI.UISymbolButton();
			this.txtFornecedor = new GM.Componentes.MinBox();
			this.txtCodigo = new GM.Componentes.MinBox();
			this.labProduto = new System.Windows.Forms.Label();
			this.listaMovimento = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// btnAbrir
			// 
			this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Location = new System.Drawing.Point(193, 71);
			this.btnAbrir.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Radius = 0;
			this.btnAbrir.Size = new System.Drawing.Size(48, 27);
			this.btnAbrir.Symbol = 61442;
			this.btnAbrir.TabIndex = 36;
			this.btnAbrir.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Click += new System.EventHandler(this.selecionarCliente);
			// 
			// txtFornecedor
			// 
			this.txtFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtFornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtFornecedor.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtFornecedor.CustomBGColor = System.Drawing.Color.White;
			this.txtFornecedor.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtFornecedor.ForeColor = System.Drawing.Color.Black;
			this.txtFornecedor.Location = new System.Drawing.Point(247, 70);
			this.txtFornecedor.MaxLength = 50;
			this.txtFornecedor.Multiline = false;
			this.txtFornecedor.Name = "txtFornecedor";
			this.txtFornecedor.ReadOnly = true;
			this.txtFornecedor.SelectionStart = 0;
			this.txtFornecedor.Size = new System.Drawing.Size(255, 28);
			this.txtFornecedor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtFornecedor.TabIndex = 35;
			this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtFornecedor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtFornecedor.UseSystemPasswordChar = false;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
			this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigo.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtCodigo.ForeColor = System.Drawing.Color.Black;
			this.txtCodigo.Location = new System.Drawing.Point(135, 70);
			this.txtCodigo.MaxLength = 50;
			this.txtCodigo.Multiline = false;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = false;
			this.txtCodigo.SelectionStart = 0;
			this.txtCodigo.Size = new System.Drawing.Size(52, 28);
			this.txtCodigo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigo.TabIndex = 33;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.UseSystemPasswordChar = false;
			this.txtCodigo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploClique);
			this.txtCodigo.TextChanged += new System.EventHandler(this.maskNumber);
			// 
			// labProduto
			// 
			this.labProduto.BackColor = System.Drawing.Color.Transparent;
			this.labProduto.Location = new System.Drawing.Point(12, 70);
			this.labProduto.Name = "labProduto";
			this.labProduto.Size = new System.Drawing.Size(117, 23);
			this.labProduto.TabIndex = 34;
			this.labProduto.Text = "Fornecedor/Cliente :";
			this.labProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.listaMovimento.Location = new System.Drawing.Point(12, 104);
			this.listaMovimento.MultiSelect = false;
			this.listaMovimento.Name = "listaMovimento";
			this.listaMovimento.Size = new System.Drawing.Size(490, 363);
			this.listaMovimento.TabIndex = 37;
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
			this.Col02.Text = "Valor Original (R$)";
			this.Col02.Width = 140;
			// 
			// Col03
			// 
			this.Col03.Text = "Saldo (R$)";
			this.Col03.Width = 140;
			// 
			// Col04
			// 
			this.Col04.Text = "Referência";
			this.Col04.Width = 100;
			// 
			// CSCredito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 479);
			this.Controls.Add(this.listaMovimento);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.txtFornecedor);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labProduto);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSCredito";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Crédito Cliente/Fornecedores";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaMovimento;
		private System.Windows.Forms.Label labProduto;
		private GM.Componentes.MinBox txtCodigo;
		private GM.Componentes.MinBox txtFornecedor;
		private Sunny.UI.UISymbolButton btnAbrir;
	}
}
