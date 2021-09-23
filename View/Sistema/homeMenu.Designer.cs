
namespace GM.View.Sistema
{
	partial class homeMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeMenu));
			this.btnFBalcao = new System.Windows.Forms.Button();
			this.TabControle = new MaterialSkin.Controls.MaterialTabControl();
			this.TabVendaCompra = new System.Windows.Forms.TabPage();
			this.btnFCompra = new System.Windows.Forms.Button();
			this.btnFVenda = new System.Windows.Forms.Button();
			this.TabProduto = new System.Windows.Forms.TabPage();
			this.btnFFamilia = new System.Windows.Forms.Button();
			this.btnFProduto = new System.Windows.Forms.Button();
			this.btnFEstoque = new System.Windows.Forms.Button();
			this.TabFinanceiro = new System.Windows.Forms.TabPage();
			this.btnFContasReceber = new System.Windows.Forms.Button();
			this.btnFContasPagar = new System.Windows.Forms.Button();
			this.TabDiversos = new System.Windows.Forms.TabPage();
			this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
			this.TabControle.SuspendLayout();
			this.TabVendaCompra.SuspendLayout();
			this.TabProduto.SuspendLayout();
			this.TabFinanceiro.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnFBalcao
			// 
			this.btnFBalcao.BackColor = System.Drawing.Color.Silver;
			this.btnFBalcao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFBalcao.FlatAppearance.BorderSize = 0;
			this.btnFBalcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFBalcao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFBalcao.ForeColor = System.Drawing.Color.White;
			this.btnFBalcao.Image = ((System.Drawing.Image)(resources.GetObject("btnFBalcao.Image")));
			this.btnFBalcao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFBalcao.Location = new System.Drawing.Point(8, 6);
			this.btnFBalcao.Name = "btnFBalcao";
			this.btnFBalcao.Size = new System.Drawing.Size(137, 87);
			this.btnFBalcao.TabIndex = 1;
			this.btnFBalcao.Text = "Venda Balcão";
			this.btnFBalcao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFBalcao.UseVisualStyleBackColor = false;
			this.btnFBalcao.Click += new System.EventHandler(this.cliqueVendaBalcao);
			// 
			// TabControle
			// 
			this.TabControle.Controls.Add(this.TabVendaCompra);
			this.TabControle.Controls.Add(this.TabProduto);
			this.TabControle.Controls.Add(this.TabFinanceiro);
			this.TabControle.Controls.Add(this.TabDiversos);
			this.TabControle.Depth = 0;
			this.TabControle.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TabControle.Location = new System.Drawing.Point(0, 101);
			this.TabControle.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabControle.Name = "TabControle";
			this.TabControle.SelectedIndex = 0;
			this.TabControle.Size = new System.Drawing.Size(786, 394);
			this.TabControle.TabIndex = 2;
			// 
			// TabVendaCompra
			// 
			this.TabVendaCompra.Controls.Add(this.btnFCompra);
			this.TabVendaCompra.Controls.Add(this.btnFVenda);
			this.TabVendaCompra.Controls.Add(this.btnFBalcao);
			this.TabVendaCompra.Location = new System.Drawing.Point(4, 22);
			this.TabVendaCompra.Name = "TabVendaCompra";
			this.TabVendaCompra.Padding = new System.Windows.Forms.Padding(3);
			this.TabVendaCompra.Size = new System.Drawing.Size(778, 368);
			this.TabVendaCompra.TabIndex = 0;
			this.TabVendaCompra.Text = "Vendas e Compras";
			this.TabVendaCompra.UseVisualStyleBackColor = true;
			// 
			// btnFCompra
			// 
			this.btnFCompra.BackColor = System.Drawing.Color.Silver;
			this.btnFCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFCompra.FlatAppearance.BorderSize = 0;
			this.btnFCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFCompra.ForeColor = System.Drawing.Color.White;
			this.btnFCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnFCompra.Image")));
			this.btnFCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFCompra.Location = new System.Drawing.Point(294, 6);
			this.btnFCompra.Name = "btnFCompra";
			this.btnFCompra.Size = new System.Drawing.Size(137, 87);
			this.btnFCompra.TabIndex = 3;
			this.btnFCompra.Text = "Consulta de \r\nPedidos de Compra";
			this.btnFCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFCompra.UseVisualStyleBackColor = false;
			this.btnFCompra.Click += new System.EventHandler(this.cliqueCompraConsulta);
			// 
			// btnFVenda
			// 
			this.btnFVenda.BackColor = System.Drawing.Color.Silver;
			this.btnFVenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFVenda.FlatAppearance.BorderSize = 0;
			this.btnFVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFVenda.ForeColor = System.Drawing.Color.White;
			this.btnFVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnFVenda.Image")));
			this.btnFVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFVenda.Location = new System.Drawing.Point(151, 6);
			this.btnFVenda.Name = "btnFVenda";
			this.btnFVenda.Size = new System.Drawing.Size(137, 87);
			this.btnFVenda.TabIndex = 2;
			this.btnFVenda.Text = "Consulta de \r\nPedidos de Venda";
			this.btnFVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFVenda.UseVisualStyleBackColor = false;
			this.btnFVenda.Click += new System.EventHandler(this.cliqueVendaConsulta);
			// 
			// TabProduto
			// 
			this.TabProduto.Controls.Add(this.btnFFamilia);
			this.TabProduto.Controls.Add(this.btnFProduto);
			this.TabProduto.Controls.Add(this.btnFEstoque);
			this.TabProduto.Location = new System.Drawing.Point(4, 22);
			this.TabProduto.Name = "TabProduto";
			this.TabProduto.Padding = new System.Windows.Forms.Padding(3);
			this.TabProduto.Size = new System.Drawing.Size(778, 368);
			this.TabProduto.TabIndex = 1;
			this.TabProduto.Text = "Produtos e Estoque";
			this.TabProduto.UseVisualStyleBackColor = true;
			// 
			// btnFFamilia
			// 
			this.btnFFamilia.BackColor = System.Drawing.Color.Silver;
			this.btnFFamilia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFFamilia.FlatAppearance.BorderSize = 0;
			this.btnFFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFFamilia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFFamilia.ForeColor = System.Drawing.Color.White;
			this.btnFFamilia.Image = ((System.Drawing.Image)(resources.GetObject("btnFFamilia.Image")));
			this.btnFFamilia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFFamilia.Location = new System.Drawing.Point(294, 6);
			this.btnFFamilia.Name = "btnFFamilia";
			this.btnFFamilia.Size = new System.Drawing.Size(137, 87);
			this.btnFFamilia.TabIndex = 4;
			this.btnFFamilia.Text = "Consulta de Famílias de Produtos";
			this.btnFFamilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFFamilia.UseVisualStyleBackColor = false;
			this.btnFFamilia.Click += new System.EventHandler(this.cliqueFamiliaConsulta);
			// 
			// btnFProduto
			// 
			this.btnFProduto.BackColor = System.Drawing.Color.Silver;
			this.btnFProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFProduto.FlatAppearance.BorderSize = 0;
			this.btnFProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFProduto.ForeColor = System.Drawing.Color.White;
			this.btnFProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnFProduto.Image")));
			this.btnFProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFProduto.Location = new System.Drawing.Point(151, 6);
			this.btnFProduto.Name = "btnFProduto";
			this.btnFProduto.Size = new System.Drawing.Size(137, 87);
			this.btnFProduto.TabIndex = 3;
			this.btnFProduto.Text = "Consulta de Produtos";
			this.btnFProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFProduto.UseVisualStyleBackColor = false;
			this.btnFProduto.Click += new System.EventHandler(this.cliqueProdutoConsulta);
			// 
			// btnFEstoque
			// 
			this.btnFEstoque.BackColor = System.Drawing.Color.Silver;
			this.btnFEstoque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFEstoque.FlatAppearance.BorderSize = 0;
			this.btnFEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFEstoque.ForeColor = System.Drawing.Color.White;
			this.btnFEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnFEstoque.Image")));
			this.btnFEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFEstoque.Location = new System.Drawing.Point(8, 6);
			this.btnFEstoque.Name = "btnFEstoque";
			this.btnFEstoque.Size = new System.Drawing.Size(137, 87);
			this.btnFEstoque.TabIndex = 2;
			this.btnFEstoque.Text = "Consulta de Estoque";
			this.btnFEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFEstoque.UseVisualStyleBackColor = false;
			this.btnFEstoque.Click += new System.EventHandler(this.cliqueEstoqueConsulta);
			// 
			// TabFinanceiro
			// 
			this.TabFinanceiro.Controls.Add(this.btnFContasReceber);
			this.TabFinanceiro.Controls.Add(this.btnFContasPagar);
			this.TabFinanceiro.Location = new System.Drawing.Point(4, 22);
			this.TabFinanceiro.Name = "TabFinanceiro";
			this.TabFinanceiro.Padding = new System.Windows.Forms.Padding(3);
			this.TabFinanceiro.Size = new System.Drawing.Size(778, 368);
			this.TabFinanceiro.TabIndex = 2;
			this.TabFinanceiro.Text = "Financeiro";
			this.TabFinanceiro.UseVisualStyleBackColor = true;
			// 
			// btnFContasReceber
			// 
			this.btnFContasReceber.BackColor = System.Drawing.Color.Silver;
			this.btnFContasReceber.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFContasReceber.FlatAppearance.BorderSize = 0;
			this.btnFContasReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFContasReceber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFContasReceber.ForeColor = System.Drawing.Color.White;
			this.btnFContasReceber.Image = ((System.Drawing.Image)(resources.GetObject("btnFContasReceber.Image")));
			this.btnFContasReceber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFContasReceber.Location = new System.Drawing.Point(151, 6);
			this.btnFContasReceber.Name = "btnFContasReceber";
			this.btnFContasReceber.Size = new System.Drawing.Size(137, 87);
			this.btnFContasReceber.TabIndex = 3;
			this.btnFContasReceber.Text = "Consulta de\r\nContas á Receber";
			this.btnFContasReceber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFContasReceber.UseVisualStyleBackColor = false;
			this.btnFContasReceber.Click += new System.EventHandler(this.cliqueReceberConsulta);
			// 
			// btnFContasPagar
			// 
			this.btnFContasPagar.BackColor = System.Drawing.Color.Silver;
			this.btnFContasPagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFContasPagar.FlatAppearance.BorderSize = 0;
			this.btnFContasPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFContasPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFContasPagar.ForeColor = System.Drawing.Color.White;
			this.btnFContasPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnFContasPagar.Image")));
			this.btnFContasPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFContasPagar.Location = new System.Drawing.Point(8, 6);
			this.btnFContasPagar.Name = "btnFContasPagar";
			this.btnFContasPagar.Size = new System.Drawing.Size(137, 87);
			this.btnFContasPagar.TabIndex = 2;
			this.btnFContasPagar.Text = "Consulta de\r\nContas á Pagar";
			this.btnFContasPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFContasPagar.UseVisualStyleBackColor = false;
			this.btnFContasPagar.Click += new System.EventHandler(this.cliquePagarConsulta);
			// 
			// TabDiversos
			// 
			this.TabDiversos.Location = new System.Drawing.Point(4, 22);
			this.TabDiversos.Name = "TabDiversos";
			this.TabDiversos.Padding = new System.Windows.Forms.Padding(3);
			this.TabDiversos.Size = new System.Drawing.Size(778, 368);
			this.TabDiversos.TabIndex = 3;
			this.TabDiversos.Text = "Diversos";
			this.TabDiversos.UseVisualStyleBackColor = true;
			// 
			// materialTabSelector1
			// 
			this.materialTabSelector1.BaseTabControl = this.TabControle;
			this.materialTabSelector1.Depth = 0;
			this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
			this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabSelector1.Name = "materialTabSelector1";
			this.materialTabSelector1.Size = new System.Drawing.Size(786, 38);
			this.materialTabSelector1.TabIndex = 2;
			this.materialTabSelector1.Text = "materialTabSelector1";
			// 
			// homeMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 495);
			this.Controls.Add(this.materialTabSelector1);
			this.Controls.Add(this.TabControle);
			this.MaximizeBox = false;
			this.Name = "homeMenu";
			this.Sizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GML - Gestão";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.TabControle.ResumeLayout(false);
			this.TabVendaCompra.ResumeLayout(false);
			this.TabProduto.ResumeLayout(false);
			this.TabFinanceiro.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnFContasPagar;
		private System.Windows.Forms.Button btnFContasReceber;
		private System.Windows.Forms.Button btnFFamilia;
		private System.Windows.Forms.Button btnFProduto;
		private System.Windows.Forms.Button btnFEstoque;
		private System.Windows.Forms.Button btnFCompra;
		private System.Windows.Forms.Button btnFVenda;
		private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
		private System.Windows.Forms.TabPage TabDiversos;
		private System.Windows.Forms.TabPage TabFinanceiro;
		private System.Windows.Forms.TabPage TabProduto;
		private System.Windows.Forms.TabPage TabVendaCompra;
		private MaterialSkin.Controls.MaterialTabControl TabControle;
		private System.Windows.Forms.Button btnFBalcao;
	}
}
