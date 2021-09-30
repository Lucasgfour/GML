
namespace GM.View.pessoa
{
	partial class PQPessoa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQPessoa));
			this.btnSair = new Sunny.UI.UISymbolButton();
			this.btnSelecionar = new Sunny.UI.UISymbolButton();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.labSede = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.listPessoa = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
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
			this.btnSair.Location = new System.Drawing.Point(282, 70);
			this.btnSair.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSair.Name = "btnSair";
			this.btnSair.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSair.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSair.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnSair.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnSair.Size = new System.Drawing.Size(110, 29);
			this.btnSair.Style = Sunny.UI.UIStyle.Red;
			this.btnSair.Symbol = 61453;
			this.btnSair.TabIndex = 37;
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
			this.btnSelecionar.Location = new System.Drawing.Point(398, 70);
			this.btnSelecionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSelecionar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSelecionar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSelecionar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.Size = new System.Drawing.Size(173, 29);
			this.btnSelecionar.Style = Sunny.UI.UIStyle.Green;
			this.btnSelecionar.TabIndex = 36;
			this.btnSelecionar.Text = "Selecionar";
			this.btnSelecionar.Click += new System.EventHandler(this.selecionarClique);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(77, 75);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(156, 20);
			this.txtPesquisa.TabIndex = 35;
			this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterPesquisa);
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSede.Location = new System.Drawing.Point(12, 75);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(59, 20);
			this.labSede.TabIndex = 34;
			this.labSede.Text = "Pesquisa :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnPesquisar.Location = new System.Drawing.Point(239, 70);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnPesquisar.Size = new System.Drawing.Size(37, 29);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 33;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// listPessoa
			// 
			this.listPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listPessoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03});
			this.listPessoa.FullRowSelect = true;
			this.listPessoa.GridLines = true;
			this.listPessoa.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listPessoa.Location = new System.Drawing.Point(12, 105);
			this.listPessoa.Name = "listPessoa";
			this.listPessoa.Size = new System.Drawing.Size(559, 280);
			this.listPessoa.TabIndex = 32;
			this.listPessoa.UseCompatibleStateImageBehavior = false;
			this.listPessoa.View = System.Windows.Forms.View.Details;
			this.listPessoa.DoubleClick += new System.EventHandler(this.duploClique);
			// 
			// Col01
			// 
			this.Col01.Text = "Código";
			this.Col01.Width = 70;
			// 
			// Col02
			// 
			this.Col02.Text = "Nome";
			this.Col02.Width = 250;
			// 
			// Col03
			// 
			this.Col03.Text = "CPF/CNPJ";
			this.Col03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col03.Width = 150;
			// 
			// PQPessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 397);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.listPessoa);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PQPessoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pesquisa de pessoa";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listPessoa;
		private Sunny.UI.UISymbolButton btnPesquisar;
		private ReaLTaiizor.Controls.DungeonLabel labSede;
		private System.Windows.Forms.TextBox txtPesquisa;
		private Sunny.UI.UISymbolButton btnSelecionar;
		private Sunny.UI.UISymbolButton btnSair;
	}
}
