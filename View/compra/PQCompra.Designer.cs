
namespace GM.View.compra
{
	partial class PQCompra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQCompra));
			this.btnSair = new Sunny.UI.UISymbolButton();
			this.btnSelecionar = new Sunny.UI.UISymbolButton();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.labSede = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.listaCompra = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.Col05 = new System.Windows.Forms.ColumnHeader();
			this.Col06 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// btnSair
			// 
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSair.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnSair.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSair.Location = new System.Drawing.Point(569, 69);
			this.btnSair.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSair.Name = "btnSair";
			this.btnSair.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSair.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnSair.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.Size = new System.Drawing.Size(110, 29);
			this.btnSair.Style = Sunny.UI.UIStyle.Red;
			this.btnSair.Symbol = 61453;
			this.btnSair.TabIndex = 43;
			this.btnSair.Text = "Sair";
			this.btnSair.Click += new System.EventHandler(this.sairClique);
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSelecionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSelecionar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSelecionar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSelecionar.Location = new System.Drawing.Point(685, 69);
			this.btnSelecionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSelecionar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSelecionar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.Size = new System.Drawing.Size(175, 29);
			this.btnSelecionar.Style = Sunny.UI.UIStyle.Green;
			this.btnSelecionar.TabIndex = 42;
			this.btnSelecionar.Text = "Selecionar";
			this.btnSelecionar.Click += new System.EventHandler(this.selecionarClique);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(77, 74);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(156, 20);
			this.txtPesquisa.TabIndex = 41;
			this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSede.Location = new System.Drawing.Point(12, 74);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(59, 20);
			this.labSede.TabIndex = 40;
			this.labSede.Text = "Pesquisa :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnPesquisar.Location = new System.Drawing.Point(239, 69);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(37, 29);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 39;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// listaCompra
			// 
			this.listaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listaCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04,
									this.Col05,
									this.Col06});
			this.listaCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaCompra.FullRowSelect = true;
			this.listaCompra.GridLines = true;
			this.listaCompra.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listaCompra.Location = new System.Drawing.Point(12, 104);
			this.listaCompra.Name = "listaCompra";
			this.listaCompra.Size = new System.Drawing.Size(848, 380);
			this.listaCompra.TabIndex = 38;
			this.listaCompra.UseCompatibleStateImageBehavior = false;
			this.listaCompra.View = System.Windows.Forms.View.Details;
			this.listaCompra.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploClique);
			// 
			// Col01
			// 
			this.Col01.Text = "Número";
			this.Col01.Width = 70;
			// 
			// Col02
			// 
			this.Col02.Text = "Data";
			this.Col02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col02.Width = 90;
			// 
			// Col03
			// 
			this.Col03.Text = "Loja";
			this.Col03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col03.Width = 120;
			// 
			// Col04
			// 
			this.Col04.Text = "Fornecedor";
			this.Col04.Width = 200;
			// 
			// Col05
			// 
			this.Col05.Text = "Observação";
			this.Col05.Width = 200;
			// 
			// Col06
			// 
			this.Col06.Text = "Situação";
			this.Col06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col06.Width = 120;
			// 
			// PQCompra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 496);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.listaCompra);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PQCompra";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pesquisa por Compra";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader Col06;
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaCompra;
		private Sunny.UI.UISymbolButton btnPesquisar;
		private ReaLTaiizor.Controls.DungeonLabel labSede;
		private System.Windows.Forms.TextBox txtPesquisa;
		private Sunny.UI.UISymbolButton btnSelecionar;
		private Sunny.UI.UISymbolButton btnSair;
	}
}
