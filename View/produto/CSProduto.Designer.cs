
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
			this.txtPesquisa = new GM.Componentes.MinBox();
			this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnRemover = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
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
			this.txtPesquisa.BackColor = System.Drawing.Color.Transparent;
			this.txtPesquisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtPesquisa.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPesquisa.CustomBGColor = System.Drawing.Color.White;
			this.txtPesquisa.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
			this.txtPesquisa.Location = new System.Drawing.Point(16, 76);
			this.txtPesquisa.MaxLength = 32767;
			this.txtPesquisa.Multiline = false;
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.ReadOnly = false;
			this.txtPesquisa.SelectionStart = 0;
			this.txtPesquisa.Size = new System.Drawing.Size(214, 28);
			this.txtPesquisa.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPesquisa.TabIndex = 25;
			this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.UseSystemPasswordChar = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Depth = 0;
			this.btnBuscar.Location = new System.Drawing.Point(236, 76);
			this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Primary = true;
			this.btnBuscar.Size = new System.Drawing.Size(94, 28);
			this.btnBuscar.TabIndex = 70;
			this.btnBuscar.Text = "BUSCAR";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// btnRemover
			// 
			this.btnRemover.Depth = 0;
			this.btnRemover.Location = new System.Drawing.Point(715, 76);
			this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Primary = true;
			this.btnRemover.Size = new System.Drawing.Size(94, 28);
			this.btnRemover.TabIndex = 69;
			this.btnRemover.Text = "REMOVER";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Visible = false;
			// 
			// btnEditar
			// 
			this.btnEditar.Depth = 0;
			this.btnEditar.Location = new System.Drawing.Point(615, 76);
			this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Primary = true;
			this.btnEditar.Size = new System.Drawing.Size(94, 28);
			this.btnEditar.TabIndex = 68;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.editarClique);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Depth = 0;
			this.btnAdicionar.Location = new System.Drawing.Point(515, 76);
			this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Primary = true;
			this.btnAdicionar.Size = new System.Drawing.Size(94, 28);
			this.btnAdicionar.TabIndex = 67;
			this.btnAdicionar.Text = "ADICIONAR";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.adicionarClique);
			// 
			// CSProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 575);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.listProduto);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta Produtos";
			this.Load += new System.EventHandler(this.Arranque);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnRemover;
		private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
		private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
		private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
		private GM.Componentes.MinBox txtPesquisa;
		private System.Windows.Forms.ColumnHeader Col06;
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listProduto;
	}
}
