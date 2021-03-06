
namespace GM.View.condicao
{
	partial class CSCondicao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSCondicao));
			this.btnDeletar = new Sunny.UI.UISymbolButton();
			this.btnEditar = new Sunny.UI.UISymbolButton();
			this.btnAdicionar = new Sunny.UI.UISymbolButton();
			this.txtPesquisa = new GM.Componentes.MinBox();
			this.labSede = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.listaCondicao = new System.Windows.Forms.ListView();
			this.ColCodigo = new System.Windows.Forms.ColumnHeader();
			this.ColNome = new System.Windows.Forms.ColumnHeader();
			this.ColCondicao = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// btnDeletar
			// 
			this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeletar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnDeletar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnDeletar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDeletar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDeletar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnDeletar.Location = new System.Drawing.Point(509, 75);
			this.btnDeletar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnDeletar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnDeletar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnDeletar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDeletar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDeletar.Size = new System.Drawing.Size(37, 29);
			this.btnDeletar.Style = Sunny.UI.UIStyle.Red;
			this.btnDeletar.Symbol = 61453;
			this.btnDeletar.TabIndex = 31;
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnEditar.Location = new System.Drawing.Point(471, 75);
			this.btnEditar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnEditar.Size = new System.Drawing.Size(37, 29);
			this.btnEditar.Symbol = 61508;
			this.btnEditar.TabIndex = 30;
			this.btnEditar.Click += new System.EventHandler(this.cliqueEditar);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnAdicionar.Location = new System.Drawing.Point(297, 75);
			this.btnAdicionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnAdicionar.Size = new System.Drawing.Size(173, 29);
			this.btnAdicionar.Symbol = 61543;
			this.btnAdicionar.TabIndex = 29;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueAdicionar);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.BackColor = System.Drawing.Color.Transparent;
			this.txtPesquisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtPesquisa.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPesquisa.CustomBGColor = System.Drawing.Color.White;
			this.txtPesquisa.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
			this.txtPesquisa.Location = new System.Drawing.Point(77, 75);
			this.txtPesquisa.MaxLength = 32767;
			this.txtPesquisa.Multiline = false;
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.ReadOnly = false;
			this.txtPesquisa.SelectionStart = 0;
			this.txtPesquisa.Size = new System.Drawing.Size(118, 28);
			this.txtPesquisa.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPesquisa.TabIndex = 28;
			this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.UseSystemPasswordChar = false;
			this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSede.Location = new System.Drawing.Point(12, 75);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(59, 28);
			this.labSede.TabIndex = 27;
			this.labSede.Text = "Pesquisa :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnPesquisar.Location = new System.Drawing.Point(201, 75);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnPesquisar.Size = new System.Drawing.Size(37, 29);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 26;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// listaCondicao
			// 
			this.listaCondicao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColCodigo,
									this.ColNome,
									this.ColCondicao});
			this.listaCondicao.FullRowSelect = true;
			this.listaCondicao.GridLines = true;
			this.listaCondicao.Location = new System.Drawing.Point(12, 110);
			this.listaCondicao.MultiSelect = false;
			this.listaCondicao.Name = "listaCondicao";
			this.listaCondicao.Size = new System.Drawing.Size(534, 404);
			this.listaCondicao.TabIndex = 32;
			this.listaCondicao.UseCompatibleStateImageBehavior = false;
			this.listaCondicao.View = System.Windows.Forms.View.Details;
			// 
			// ColCodigo
			// 
			this.ColCodigo.Text = "Código";
			this.ColCodigo.Width = 70;
			// 
			// ColNome
			// 
			this.ColNome.Text = "Nome";
			this.ColNome.Width = 150;
			// 
			// ColCondicao
			// 
			this.ColCondicao.Text = "Condição";
			this.ColCondicao.Width = 275;
			// 
			// CSCondicao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 526);
			this.Controls.Add(this.listaCondicao);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.btnPesquisar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSCondicao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Condições de pagamento";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ColumnHeader ColCondicao;
		private System.Windows.Forms.ColumnHeader ColNome;
		private System.Windows.Forms.ColumnHeader ColCodigo;
		private System.Windows.Forms.ListView listaCondicao;
		private Sunny.UI.UISymbolButton btnPesquisar;
		private ReaLTaiizor.Controls.DungeonLabel labSede;
		private GM.Componentes.MinBox txtPesquisa;
		private Sunny.UI.UISymbolButton btnAdicionar;
		private Sunny.UI.UISymbolButton btnEditar;
		private Sunny.UI.UISymbolButton btnDeletar;
	}
}
