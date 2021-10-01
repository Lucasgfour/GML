
namespace GM.View.Sistema
{
	partial class PQCidade
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQCidade));
			this.listCidade = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.txtPesquisa = new GM.Componentes.MinBox();
			this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnSelecionar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// listCidade
			// 
			this.listCidade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03});
			this.listCidade.FullRowSelect = true;
			this.listCidade.GridLines = true;
			this.listCidade.Location = new System.Drawing.Point(12, 103);
			this.listCidade.MultiSelect = false;
			this.listCidade.Name = "listCidade";
			this.listCidade.Size = new System.Drawing.Size(550, 266);
			this.listCidade.TabIndex = 0;
			this.listCidade.UseCompatibleStateImageBehavior = false;
			this.listCidade.View = System.Windows.Forms.View.Details;
			// 
			// Col01
			// 
			this.Col01.Text = "Código";
			this.Col01.Width = 100;
			// 
			// Col02
			// 
			this.Col02.Text = "Cidade";
			this.Col02.Width = 250;
			// 
			// Col03
			// 
			this.Col03.Text = "UF";
			this.Col03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.txtPesquisa.Location = new System.Drawing.Point(12, 69);
			this.txtPesquisa.MaxLength = 32767;
			this.txtPesquisa.Multiline = false;
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.ReadOnly = false;
			this.txtPesquisa.SelectionStart = 0;
			this.txtPesquisa.Size = new System.Drawing.Size(181, 28);
			this.txtPesquisa.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPesquisa.TabIndex = 34;
			this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.UseSystemPasswordChar = false;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Depth = 0;
			this.btnPesquisar.Location = new System.Drawing.Point(199, 69);
			this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Primary = true;
			this.btnPesquisar.Size = new System.Drawing.Size(103, 28);
			this.btnPesquisar.TabIndex = 63;
			this.btnPesquisar.Text = "PESQUISAR";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Depth = 0;
			this.btnSelecionar.Location = new System.Drawing.Point(408, 69);
			this.btnSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.Primary = true;
			this.btnSelecionar.Size = new System.Drawing.Size(154, 28);
			this.btnSelecionar.TabIndex = 64;
			this.btnSelecionar.Text = "SELECIONAR";
			this.btnSelecionar.UseVisualStyleBackColor = true;
			this.btnSelecionar.Click += new System.EventHandler(this.selecionarClique);
			// 
			// PQCidade
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 381);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.listCidade);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PQCidade";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pesquisa por cidade";
			this.Load += new System.EventHandler(this.arranque);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnSelecionar;
		private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
		private GM.Componentes.MinBox txtPesquisa;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listCidade;
	}
}
