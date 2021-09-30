
namespace GM.View.custo
{
	partial class PQCusto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQCusto));
			this.txtPesquisa = new GM.Componentes.MinBox();
			this.labSede = new ReaLTaiizor.Controls.DungeonLabel();
			this.listaCusto = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.Col05 = new System.Windows.Forms.ColumnHeader();
			this.Col06 = new System.Windows.Forms.ColumnHeader();
			this.Col07 = new System.Windows.Forms.ColumnHeader();
			this.btnSelecionar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
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
			this.txtPesquisa.Location = new System.Drawing.Point(77, 73);
			this.txtPesquisa.MaxLength = 32767;
			this.txtPesquisa.Multiline = false;
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.ReadOnly = false;
			this.txtPesquisa.SelectionStart = 0;
			this.txtPesquisa.Size = new System.Drawing.Size(156, 28);
			this.txtPesquisa.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPesquisa.TabIndex = 1;
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
			this.labSede.Location = new System.Drawing.Point(12, 73);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(59, 28);
			this.labSede.TabIndex = 46;
			this.labSede.Text = "Pesquisa :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listaCusto
			// 
			this.listaCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listaCusto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04,
									this.Col05,
									this.Col06,
									this.Col07});
			this.listaCusto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.listaCusto.FullRowSelect = true;
			this.listaCusto.GridLines = true;
			this.listaCusto.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listaCusto.Location = new System.Drawing.Point(12, 109);
			this.listaCusto.Name = "listaCusto";
			this.listaCusto.Size = new System.Drawing.Size(848, 380);
			this.listaCusto.TabIndex = 3;
			this.listaCusto.UseCompatibleStateImageBehavior = false;
			this.listaCusto.View = System.Windows.Forms.View.Details;
			this.listaCusto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploClique);
			// 
			// Col01
			// 
			this.Col01.Text = "Código";
			this.Col01.Width = 70;
			// 
			// Col02
			// 
			this.Col02.Text = "Fornecedor";
			this.Col02.Width = 180;
			// 
			// Col03
			// 
			this.Col03.Text = "Descrição";
			this.Col03.Width = 200;
			// 
			// Col04
			// 
			this.Col04.Text = "Loja";
			this.Col04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col04.Width = 70;
			// 
			// Col05
			// 
			this.Col05.Text = "Categoria";
			this.Col05.Width = 90;
			// 
			// Col06
			// 
			this.Col06.Text = "Emissão";
			this.Col06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col06.Width = 80;
			// 
			// Col07
			// 
			this.Col07.Text = "Observação";
			this.Col07.Width = 120;
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Depth = 0;
			this.btnSelecionar.Location = new System.Drawing.Point(682, 73);
			this.btnSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.Primary = true;
			this.btnSelecionar.Size = new System.Drawing.Size(178, 30);
			this.btnSelecionar.TabIndex = 4;
			this.btnSelecionar.Text = "SELECIONAR";
			this.btnSelecionar.UseVisualStyleBackColor = true;
			this.btnSelecionar.Click += new System.EventHandler(this.selecionarClique);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(554, 73);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(122, 30);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.sairClique);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Depth = 0;
			this.btnPesquisar.Location = new System.Drawing.Point(239, 73);
			this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Primary = true;
			this.btnPesquisar.Size = new System.Drawing.Size(122, 28);
			this.btnPesquisar.TabIndex = 2;
			this.btnPesquisar.Text = "PESQUISAR";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// PQCusto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 501);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.listaCusto);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PQCusto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pesquisa de Custo/Despesa";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private System.Windows.Forms.ColumnHeader Col07;
		private System.Windows.Forms.ColumnHeader Col06;
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaCusto;
		private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
		private ReaLTaiizor.Controls.DungeonLabel labSede;
		private GM.Componentes.MinBox txtPesquisa;
		private MaterialSkin.Controls.MaterialRaisedButton btnSelecionar;
	}
}
