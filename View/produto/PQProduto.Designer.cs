
namespace GM.View.produto
{
	partial class PQProduto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQProduto));
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.labSede = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.listProduto = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.Col05 = new System.Windows.Forms.ColumnHeader();
			this.btnSelecionar = new Sunny.UI.UISymbolButton();
			this.btnSair = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(92, 76);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(181, 23);
			this.txtPesquisa.TabIndex = 29;
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSede.Location = new System.Drawing.Point(16, 76);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(69, 23);
			this.labSede.TabIndex = 28;
			this.labSede.Text = "Pesquisa :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnPesquisar.Location = new System.Drawing.Point(281, 70);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnPesquisar.Size = new System.Drawing.Size(43, 33);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 27;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// listProduto
			// 
			this.listProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04,
									this.Col05});
			this.listProduto.FullRowSelect = true;
			this.listProduto.GridLines = true;
			this.listProduto.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listProduto.Location = new System.Drawing.Point(16, 110);
			this.listProduto.Name = "listProduto";
			this.listProduto.Size = new System.Drawing.Size(644, 324);
			this.listProduto.TabIndex = 26;
			this.listProduto.UseCompatibleStateImageBehavior = false;
			this.listProduto.View = System.Windows.Forms.View.Details;
			this.listProduto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploClique);
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
			// btnSelecionar
			// 
			this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSelecionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSelecionar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSelecionar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSelecionar.Location = new System.Drawing.Point(458, 70);
			this.btnSelecionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSelecionar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSelecionar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSelecionar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.Size = new System.Drawing.Size(202, 33);
			this.btnSelecionar.Style = Sunny.UI.UIStyle.Green;
			this.btnSelecionar.TabIndex = 30;
			this.btnSelecionar.Text = "Selecionar";
			this.btnSelecionar.Click += new System.EventHandler(this.selecionarClique);
			// 
			// btnSair
			// 
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSair.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnSair.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSair.Location = new System.Drawing.Point(331, 70);
			this.btnSair.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSair.Name = "btnSair";
			this.btnSair.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSair.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSair.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnSair.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.Size = new System.Drawing.Size(120, 33);
			this.btnSair.Style = Sunny.UI.UIStyle.Red;
			this.btnSair.Symbol = 61453;
			this.btnSair.TabIndex = 31;
			this.btnSair.Text = "Sair";
			this.btnSair.Click += new System.EventHandler(this.sairClique);
			// 
			// PQProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 446);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.listProduto);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PQProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pesquisa de Produto";
			this.Load += new System.EventHandler(this.Arranque);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton btnSair;
		private Sunny.UI.UISymbolButton btnSelecionar;
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listProduto;
		private Sunny.UI.UISymbolButton btnPesquisar;
		private ReaLTaiizor.Controls.DungeonLabel labSede;
		private System.Windows.Forms.TextBox txtPesquisa;
	}
}
