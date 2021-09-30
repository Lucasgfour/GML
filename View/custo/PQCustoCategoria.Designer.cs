
namespace GM.View.custo
{
	partial class PQCustoCategoria
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQCustoCategoria));
			this.listaCategoria = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.btnSair = new Sunny.UI.UISymbolButton();
			this.btnSelecionar = new Sunny.UI.UISymbolButton();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// listaCategoria
			// 
			this.listaCategoria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02});
			this.listaCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaCategoria.FullRowSelect = true;
			this.listaCategoria.GridLines = true;
			this.listaCategoria.Location = new System.Drawing.Point(12, 107);
			this.listaCategoria.Name = "listaCategoria";
			this.listaCategoria.Size = new System.Drawing.Size(360, 257);
			this.listaCategoria.TabIndex = 21;
			this.listaCategoria.UseCompatibleStateImageBehavior = false;
			this.listaCategoria.View = System.Windows.Forms.View.Details;
			this.listaCategoria.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploCliqueLista);
			// 
			// Col01
			// 
			this.Col01.Text = "Código";
			this.Col01.Width = 75;
			// 
			// Col02
			// 
			this.Col02.Text = "Nome";
			this.Col02.Width = 250;
			// 
			// btnSair
			// 
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSair.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnSair.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSair.Location = new System.Drawing.Point(173, 76);
			this.btnSair.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSair.Name = "btnSair";
			this.btnSair.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSair.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnSair.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.Size = new System.Drawing.Size(76, 25);
			this.btnSair.Style = Sunny.UI.UIStyle.Red;
			this.btnSair.Symbol = 61453;
			this.btnSair.TabIndex = 53;
			this.btnSair.Text = "Sair";
			this.btnSair.Click += new System.EventHandler(this.cliqueSair);
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSelecionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSelecionar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSelecionar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSelecionar.Location = new System.Drawing.Point(255, 76);
			this.btnSelecionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSelecionar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSelecionar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.Size = new System.Drawing.Size(117, 25);
			this.btnSelecionar.Style = Sunny.UI.UIStyle.Green;
			this.btnSelecionar.TabIndex = 52;
			this.btnSelecionar.Text = "Selecionar";
			this.btnSelecionar.Click += new System.EventHandler(this.cliqueSelecionar);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(12, 76);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(112, 25);
			this.txtPesquisa.TabIndex = 51;
			this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterPesquisa);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnPesquisar.Location = new System.Drawing.Point(130, 76);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(37, 25);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 50;
			this.btnPesquisar.Click += new System.EventHandler(this.cliquePesquisar);
			// 
			// PQCustoCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 379);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.listaCategoria);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PQCustoCategoria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pesquisar Categoria de Custo";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton btnPesquisar;
		private System.Windows.Forms.TextBox txtPesquisa;
		private Sunny.UI.UISymbolButton btnSelecionar;
		private Sunny.UI.UISymbolButton btnSair;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaCategoria;
	}
}
