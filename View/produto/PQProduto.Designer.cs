
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
			this.txtPesquisa = new GM.Componentes.MinBox();
			this.listProduto = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.Col05 = new System.Windows.Forms.ColumnHeader();
			this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnSelecionar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
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
			this.txtPesquisa.Location = new System.Drawing.Point(16, 71);
			this.txtPesquisa.MaxLength = 32767;
			this.txtPesquisa.Multiline = false;
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.ReadOnly = false;
			this.txtPesquisa.SelectionStart = 0;
			this.txtPesquisa.Size = new System.Drawing.Size(181, 28);
			this.txtPesquisa.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPesquisa.TabIndex = 29;
			this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.UseSystemPasswordChar = false;
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
			this.listProduto.Location = new System.Drawing.Point(16, 105);
			this.listProduto.Name = "listProduto";
			this.listProduto.Size = new System.Drawing.Size(644, 329);
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
			// btnPesquisar
			// 
			this.btnPesquisar.Depth = 0;
			this.btnPesquisar.Location = new System.Drawing.Point(203, 71);
			this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Primary = true;
			this.btnPesquisar.Size = new System.Drawing.Size(103, 28);
			this.btnPesquisar.TabIndex = 60;
			this.btnPesquisar.Text = "PESQUISAR";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(422, 71);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(103, 28);
			this.btnCancelar.TabIndex = 62;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.sairClique);
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Depth = 0;
			this.btnSelecionar.Location = new System.Drawing.Point(531, 71);
			this.btnSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.Primary = true;
			this.btnSelecionar.Size = new System.Drawing.Size(129, 28);
			this.btnSelecionar.TabIndex = 61;
			this.btnSelecionar.Text = "SELECIONAR";
			this.btnSelecionar.UseVisualStyleBackColor = true;
			this.btnSelecionar.Click += new System.EventHandler(this.selecionarClique);
			// 
			// PQProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 446);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.txtPesquisa);
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
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private MaterialSkin.Controls.MaterialRaisedButton btnSelecionar;
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listProduto;
		private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
		private GM.Componentes.MinBox txtPesquisa;
	}
}
