
namespace GM.View.venda
{
	partial class CDBalcao
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
			this.listaProdutos = new System.Windows.Forms.ListView();
			this.ColQuantidade = new System.Windows.Forms.ColumnHeader();
			this.ColUnidade = new System.Windows.Forms.ColumnHeader();
			this.ColProduto = new System.Windows.Forms.ColumnHeader();
			this.ColVlrUnidade = new System.Windows.Forms.ColumnHeader();
			this.ColVlrTotal = new System.Windows.Forms.ColumnHeader();
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.pnlProduto = new System.Windows.Forms.Panel();
			this.labValor = new System.Windows.Forms.Label();
			this.labUnidade = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPreco = new GM.Componentes.MinBox();
			this.txtQuantidade = new GM.Componentes.MinBox();
			this.labPreco = new System.Windows.Forms.Label();
			this.labQuantidade = new System.Windows.Forms.Label();
			this.cbxProduto = new System.Windows.Forms.ComboBox();
			this.cbxProdutoCodigo = new System.Windows.Forms.ComboBox();
			this.labSelProduto = new System.Windows.Forms.Label();
			this.labLojaLogo = new System.Windows.Forms.Label();
			this.labProduto = new System.Windows.Forms.Label();
			this.labAtalho2 = new System.Windows.Forms.Label();
			this.labResumo = new System.Windows.Forms.Label();
			this.pnlResumo = new System.Windows.Forms.Panel();
			this.cbxVendedor = new System.Windows.Forms.ComboBox();
			this.labVendedor = new System.Windows.Forms.Label();
			this.labZTotal = new System.Windows.Forms.Label();
			this.labTotal = new System.Windows.Forms.Label();
			this.pnlProduto.SuspendLayout();
			this.pnlResumo.SuspendLayout();
			this.SuspendLayout();
			// 
			// listaProdutos
			// 
			this.listaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColQuantidade,
									this.ColUnidade,
									this.ColProduto,
									this.ColVlrUnidade,
									this.ColVlrTotal});
			this.listaProdutos.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.listaProdutos.FullRowSelect = true;
			this.listaProdutos.GridLines = true;
			this.listaProdutos.Location = new System.Drawing.Point(12, 193);
			this.listaProdutos.Name = "listaProdutos";
			this.listaProdutos.Size = new System.Drawing.Size(1000, 563);
			this.listaProdutos.TabIndex = 1;
			this.listaProdutos.TabStop = false;
			this.listaProdutos.UseCompatibleStateImageBehavior = false;
			this.listaProdutos.View = System.Windows.Forms.View.Details;
			this.listaProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploClique);
			// 
			// ColQuantidade
			// 
			this.ColQuantidade.Text = "Quantidade";
			this.ColQuantidade.Width = 120;
			// 
			// ColUnidade
			// 
			this.ColUnidade.Text = "Un";
			this.ColUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ColProduto
			// 
			this.ColProduto.Text = "Descrição";
			this.ColProduto.Width = 420;
			// 
			// ColVlrUnidade
			// 
			this.ColVlrUnidade.Text = "Preço Unid. (R$)";
			this.ColVlrUnidade.Width = 180;
			// 
			// ColVlrTotal
			// 
			this.ColVlrTotal.Text = "Valor Total (R$)";
			this.ColVlrTotal.Width = 180;
			// 
			// pnlLogo
			// 
			this.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlLogo.Location = new System.Drawing.Point(12, 31);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(156, 156);
			this.pnlLogo.TabIndex = 2;
			// 
			// pnlProduto
			// 
			this.pnlProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlProduto.Controls.Add(this.labValor);
			this.pnlProduto.Controls.Add(this.labUnidade);
			this.pnlProduto.Controls.Add(this.label4);
			this.pnlProduto.Controls.Add(this.txtPreco);
			this.pnlProduto.Controls.Add(this.txtQuantidade);
			this.pnlProduto.Controls.Add(this.labPreco);
			this.pnlProduto.Controls.Add(this.labQuantidade);
			this.pnlProduto.Controls.Add(this.cbxProduto);
			this.pnlProduto.Controls.Add(this.cbxProdutoCodigo);
			this.pnlProduto.Controls.Add(this.labSelProduto);
			this.pnlProduto.Location = new System.Drawing.Point(174, 55);
			this.pnlProduto.Name = "pnlProduto";
			this.pnlProduto.Size = new System.Drawing.Size(477, 132);
			this.pnlProduto.TabIndex = 3;
			// 
			// labValor
			// 
			this.labValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labValor.BackColor = System.Drawing.Color.White;
			this.labValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labValor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.labValor.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labValor.Location = new System.Drawing.Point(240, 79);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(35, 27);
			this.labValor.TabIndex = 12;
			this.labValor.Text = "R$";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labUnidade
			// 
			this.labUnidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labUnidade.BackColor = System.Drawing.Color.White;
			this.labUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.labUnidade.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labUnidade.Location = new System.Drawing.Point(240, 46);
			this.labUnidade.Name = "labUnidade";
			this.labUnidade.Size = new System.Drawing.Size(35, 27);
			this.labUnidade.TabIndex = 8;
			this.labUnidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.label4.Location = new System.Drawing.Point(273, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(199, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "[ ENTER ] PARA ADICIONAR";
			// 
			// txtPreco
			// 
			this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPreco.Location = new System.Drawing.Point(87, 79);
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(148, 27);
			this.txtPreco.TabIndex = 4;
			this.txtPreco.TextChanged += new System.EventHandler(this.maskMoney);
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantidade.Location = new System.Drawing.Point(87, 46);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(148, 27);
			this.txtQuantidade.TabIndex = 3;
			this.txtQuantidade.TextChanged += new System.EventHandler(this.maskQuantidade);
			// 
			// labPreco
			// 
			this.labPreco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPreco.Location = new System.Drawing.Point(3, 83);
			this.labPreco.Name = "labPreco";
			this.labPreco.Size = new System.Drawing.Size(78, 23);
			this.labPreco.TabIndex = 2;
			this.labPreco.Text = "Preço Unid. :";
			this.labPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labQuantidade
			// 
			this.labQuantidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labQuantidade.Location = new System.Drawing.Point(3, 49);
			this.labQuantidade.Name = "labQuantidade";
			this.labQuantidade.Size = new System.Drawing.Size(78, 23);
			this.labQuantidade.TabIndex = 0;
			this.labQuantidade.Text = "Quantidade :";
			this.labQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxProduto
			// 
			this.cbxProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.cbxProduto.FormattingEnabled = true;
			this.cbxProduto.Location = new System.Drawing.Point(206, 12);
			this.cbxProduto.Name = "cbxProduto";
			this.cbxProduto.Size = new System.Drawing.Size(256, 28);
			this.cbxProduto.TabIndex = 2;
			this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.selectProduto);
			// 
			// cbxProdutoCodigo
			// 
			this.cbxProdutoCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbxProdutoCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxProdutoCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.cbxProdutoCodigo.FormattingEnabled = true;
			this.cbxProdutoCodigo.Location = new System.Drawing.Point(87, 12);
			this.cbxProdutoCodigo.Name = "cbxProdutoCodigo";
			this.cbxProdutoCodigo.Size = new System.Drawing.Size(113, 28);
			this.cbxProdutoCodigo.TabIndex = 1;
			this.cbxProdutoCodigo.SelectedIndexChanged += new System.EventHandler(this.selectProduto);
			// 
			// labSelProduto
			// 
			this.labSelProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSelProduto.Location = new System.Drawing.Point(3, 15);
			this.labSelProduto.Name = "labSelProduto";
			this.labSelProduto.Size = new System.Drawing.Size(78, 23);
			this.labSelProduto.TabIndex = 1;
			this.labSelProduto.Text = "Produto :";
			this.labSelProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labLojaLogo
			// 
			this.labLojaLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labLojaLogo.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labLojaLogo.Location = new System.Drawing.Point(12, 9);
			this.labLojaLogo.Name = "labLojaLogo";
			this.labLojaLogo.Size = new System.Drawing.Size(156, 23);
			this.labLojaLogo.TabIndex = 4;
			this.labLojaLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labProduto
			// 
			this.labProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.labProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labProduto.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labProduto.Location = new System.Drawing.Point(174, 33);
			this.labProduto.Name = "labProduto";
			this.labProduto.Size = new System.Drawing.Size(477, 23);
			this.labProduto.TabIndex = 5;
			this.labProduto.Text = "ADICIONAR PRODUTO";
			this.labProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labAtalho2
			// 
			this.labAtalho2.BackColor = System.Drawing.Color.Transparent;
			this.labAtalho2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.labAtalho2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.labAtalho2.Location = new System.Drawing.Point(174, 10);
			this.labAtalho2.Name = "labAtalho2";
			this.labAtalho2.Size = new System.Drawing.Size(838, 23);
			this.labAtalho2.TabIndex = 14;
			this.labAtalho2.Text = "[ F1 ] FINALIZAR VENDA     [ F2 ] FECHAR TELA     [ F3 ] LIMPAR PRODUTOS";
			// 
			// labResumo
			// 
			this.labResumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labResumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labResumo.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labResumo.Location = new System.Drawing.Point(657, 33);
			this.labResumo.Name = "labResumo";
			this.labResumo.Size = new System.Drawing.Size(355, 23);
			this.labResumo.TabIndex = 7;
			this.labResumo.Text = "RESUMO";
			this.labResumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlResumo
			// 
			this.pnlResumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlResumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlResumo.Controls.Add(this.cbxVendedor);
			this.pnlResumo.Controls.Add(this.labVendedor);
			this.pnlResumo.Location = new System.Drawing.Point(657, 55);
			this.pnlResumo.Name = "pnlResumo";
			this.pnlResumo.Size = new System.Drawing.Size(355, 42);
			this.pnlResumo.TabIndex = 4;
			// 
			// cbxVendedor
			// 
			this.cbxVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cbxVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxVendedor.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.cbxVendedor.FormattingEnabled = true;
			this.cbxVendedor.Location = new System.Drawing.Point(87, 6);
			this.cbxVendedor.Name = "cbxVendedor";
			this.cbxVendedor.Size = new System.Drawing.Size(252, 28);
			this.cbxVendedor.TabIndex = 0;
			this.cbxVendedor.TabStop = false;
			// 
			// labVendedor
			// 
			this.labVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labVendedor.Location = new System.Drawing.Point(3, 10);
			this.labVendedor.Name = "labVendedor";
			this.labVendedor.Size = new System.Drawing.Size(78, 23);
			this.labVendedor.TabIndex = 12;
			this.labVendedor.Text = "Vendedor : ";
			this.labVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labZTotal
			// 
			this.labZTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labZTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labZTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labZTotal.Location = new System.Drawing.Point(657, 104);
			this.labZTotal.Name = "labZTotal";
			this.labZTotal.Size = new System.Drawing.Size(355, 23);
			this.labZTotal.TabIndex = 8;
			this.labZTotal.Text = "TOTAL DO PEDIDO (R$)";
			this.labZTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labTotal
			// 
			this.labTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labTotal.Font = new System.Drawing.Font("Segoe UI Light", 28F);
			this.labTotal.Location = new System.Drawing.Point(657, 126);
			this.labTotal.Name = "labTotal";
			this.labTotal.Size = new System.Drawing.Size(355, 61);
			this.labTotal.TabIndex = 15;
			this.labTotal.Text = "R$ 0,00";
			this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CDBalcao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.labAtalho2);
			this.Controls.Add(this.labZTotal);
			this.Controls.Add(this.labTotal);
			this.Controls.Add(this.pnlResumo);
			this.Controls.Add(this.labResumo);
			this.Controls.Add(this.labProduto);
			this.Controls.Add(this.labLojaLogo);
			this.Controls.Add(this.pnlProduto);
			this.Controls.Add(this.pnlLogo);
			this.Controls.Add(this.listaProdutos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "CDBalcao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CDBalcao";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionaBotao);
			this.pnlProduto.ResumeLayout(false);
			this.pnlProduto.PerformLayout();
			this.pnlResumo.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ColumnHeader ColUnidade;
		private System.Windows.Forms.Label labAtalho2;
		private System.Windows.Forms.Label labValor;
		private System.Windows.Forms.Label labUnidade;
		private System.Windows.Forms.Label labTotal;
		private System.Windows.Forms.Label labZTotal;
		private System.Windows.Forms.Label labVendedor;
		private System.Windows.Forms.ComboBox cbxVendedor;
		private System.Windows.Forms.Label label4;
		private GM.Componentes.MinBox txtQuantidade;
		private GM.Componentes.MinBox txtPreco;
		private System.Windows.Forms.ComboBox cbxProdutoCodigo;
		private System.Windows.Forms.ComboBox cbxProduto;
		private System.Windows.Forms.Label labQuantidade;
		private System.Windows.Forms.Label labSelProduto;
		private System.Windows.Forms.Label labPreco;
		private System.Windows.Forms.Panel pnlResumo;
		private System.Windows.Forms.Label labResumo;
		private System.Windows.Forms.Label labProduto;
		private System.Windows.Forms.Label labLojaLogo;
		private System.Windows.Forms.Panel pnlProduto;
		private System.Windows.Forms.Panel pnlLogo;
		private System.Windows.Forms.ColumnHeader ColVlrTotal;
		private System.Windows.Forms.ColumnHeader ColVlrUnidade;
		private System.Windows.Forms.ColumnHeader ColProduto;
		private System.Windows.Forms.ColumnHeader ColQuantidade;
		private System.Windows.Forms.ListView listaProdutos;
	}
}
