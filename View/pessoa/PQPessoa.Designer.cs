
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
			this.txtPesquisa = new GM.Componentes.MinBox();
			this.listPessoa = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
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
			this.txtPesquisa.Location = new System.Drawing.Point(12, 71);
			this.txtPesquisa.MaxLength = 32767;
			this.txtPesquisa.Multiline = false;
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.ReadOnly = false;
			this.txtPesquisa.SelectionStart = 0;
			this.txtPesquisa.Size = new System.Drawing.Size(156, 28);
			this.txtPesquisa.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPesquisa.TabIndex = 35;
			this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPesquisa.UseSystemPasswordChar = false;
			this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterPesquisa);
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
			// btnPesquisar
			// 
			this.btnPesquisar.Depth = 0;
			this.btnPesquisar.Location = new System.Drawing.Point(174, 71);
			this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Primary = true;
			this.btnPesquisar.Size = new System.Drawing.Size(103, 28);
			this.btnPesquisar.TabIndex = 57;
			this.btnPesquisar.Text = "PESQUISAR";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(333, 69);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(103, 30);
			this.btnCancelar.TabIndex = 59;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.sairClique);
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Depth = 0;
			this.btnSelecionar.Location = new System.Drawing.Point(442, 69);
			this.btnSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.Primary = true;
			this.btnSelecionar.Size = new System.Drawing.Size(129, 30);
			this.btnSelecionar.TabIndex = 58;
			this.btnSelecionar.Text = "SELECIONAR";
			this.btnSelecionar.UseVisualStyleBackColor = true;
			this.btnSelecionar.Click += new System.EventHandler(this.selecionarClique);
			// 
			// PQPessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 397);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.listPessoa);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PQPessoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pesquisa de pessoa";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listPessoa;
		private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
		private GM.Componentes.MinBox txtPesquisa;
		private MaterialSkin.Controls.MaterialRaisedButton btnSelecionar;
	}
}
