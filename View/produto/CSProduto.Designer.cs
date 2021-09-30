
namespace GM.View.produto
{
	partial class CSProduto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSProduto));
			this.listProduto = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.Col05 = new System.Windows.Forms.ColumnHeader();
			this.Col06 = new System.Windows.Forms.ColumnHeader();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.labSede = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.btnAdicionar = new Sunny.UI.UISymbolButton();
			this.btnEditar = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// listProduto
			// 
			this.listProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04,
									this.Col05,
									this.Col06});
			this.listProduto.FullRowSelect = true;
			this.listProduto.GridLines = true;
			this.listProduto.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listProduto.Location = new System.Drawing.Point(16, 115);
			this.listProduto.MultiSelect = false;
			this.listProduto.Name = "listProduto";
			this.listProduto.Size = new System.Drawing.Size(793, 448);
			this.listProduto.TabIndex = 1;
			this.listProduto.UseCompatibleStateImageBehavior = false;
			this.listProduto.View = System.Windows.Forms.View.Details;
			// 
			// Col01
			// 
			this.Col01.Text = "Código";
			this.Col01.Width = 70;
			// 
			// Col02
			// 
			this.Col02.Text = "Descrição";
			this.Col02.Width = 250;
			// 
			// Col03
			// 
			this.Col03.Text = "Família";
			this.Col03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Col04
			// 
			this.Col04.Text = "Unidade";
			this.Col04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Col05
			// 
			this.Col05.Text = "Situação";
			this.Col05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col05.Width = 80;
			// 
			// Col06
			// 
			this.Col06.Text = "Preço";
			this.Col06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col06.Width = 120;
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(92, 81);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(137, 23);
			this.txtPesquisa.TabIndex = 25;
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSede.Location = new System.Drawing.Point(16, 81);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(69, 23);
			this.labSede.TabIndex = 24;
			this.labSede.Text = "Pesquisa :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnPesquisar.Location = new System.Drawing.Point(236, 75);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnPesquisar.Size = new System.Drawing.Size(43, 33);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 23;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnAdicionar.Location = new System.Drawing.Point(287, 75);
			this.btnAdicionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnAdicionar.Size = new System.Drawing.Size(202, 33);
			this.btnAdicionar.Symbol = 61543;
			this.btnAdicionar.TabIndex = 26;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.Click += new System.EventHandler(this.adicionarClique);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnEditar.Location = new System.Drawing.Point(495, 75);
			this.btnEditar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnEditar.Size = new System.Drawing.Size(43, 33);
			this.btnEditar.Symbol = 61508;
			this.btnEditar.TabIndex = 27;
			this.btnEditar.Click += new System.EventHandler(this.editarClique);
			// 
			// CSProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 575);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.listProduto);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta Produtos";
			this.Load += new System.EventHandler(this.Arranque);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton btnEditar;
		private Sunny.UI.UISymbolButton btnAdicionar;
		private Sunny.UI.UISymbolButton btnPesquisar;
		private ReaLTaiizor.Controls.DungeonLabel labSede;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.ColumnHeader Col06;
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listProduto;
	}
}
