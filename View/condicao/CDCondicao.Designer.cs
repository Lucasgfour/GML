
namespace GM.View.condicao
{
	partial class CDCondicao
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
			this.txtNome = new System.Windows.Forms.TextBox();
			this.labNome = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.labCodigo = new ReaLTaiizor.Controls.DungeonLabel();
			this.labTitulo = new ReaLTaiizor.Controls.DungeonLabel();
			this.labDias = new ReaLTaiizor.Controls.DungeonLabel();
			this.listaDias = new System.Windows.Forms.ListView();
			this.ColDia = new System.Windows.Forms.ColumnHeader();
			this.txtDias = new System.Windows.Forms.TextBox();
			this.labAddDias = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.btnAdicionar = new Sunny.UI.UISymbolButton();
			this.btnDeletar = new Sunny.UI.UISymbolButton();
			this.cbxTipo = new ReaLTaiizor.Controls.DungeonLabel();
			this.cbxCondicao = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNome.Location = new System.Drawing.Point(91, 63);
			this.txtNome.MaxLength = 50;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(277, 20);
			this.txtNome.TabIndex = 30;
			// 
			// labNome
			// 
			this.labNome.BackColor = System.Drawing.Color.Transparent;
			this.labNome.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labNome.Location = new System.Drawing.Point(12, 63);
			this.labNome.Name = "labNome";
			this.labNome.Size = new System.Drawing.Size(73, 20);
			this.labNome.TabIndex = 31;
			this.labNome.Text = "Nome :";
			this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodigo.Location = new System.Drawing.Point(91, 40);
			this.txtCodigo.MaxLength = 50;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = true;
			this.txtCodigo.Size = new System.Drawing.Size(77, 20);
			this.txtCodigo.TabIndex = 32;
			this.txtCodigo.TabStop = false;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCodigo.Location = new System.Drawing.Point(12, 40);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(73, 20);
			this.labCodigo.TabIndex = 0;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labTitulo
			// 
			this.labTitulo.BackColor = System.Drawing.Color.Transparent;
			this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labTitulo.Location = new System.Drawing.Point(12, 9);
			this.labTitulo.Name = "labTitulo";
			this.labTitulo.Size = new System.Drawing.Size(359, 28);
			this.labTitulo.TabIndex = 34;
			this.labTitulo.Text = "Cadastro/Edição de condição de pagamento";
			this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labDias
			// 
			this.labDias.BackColor = System.Drawing.Color.Transparent;
			this.labDias.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labDias.Location = new System.Drawing.Point(12, 116);
			this.labDias.Name = "labDias";
			this.labDias.Size = new System.Drawing.Size(73, 20);
			this.labDias.TabIndex = 35;
			this.labDias.Text = "Dias :";
			this.labDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listaDias
			// 
			this.listaDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listaDias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColDia});
			this.listaDias.FullRowSelect = true;
			this.listaDias.GridLines = true;
			this.listaDias.Location = new System.Drawing.Point(91, 116);
			this.listaDias.MultiSelect = false;
			this.listaDias.Name = "listaDias";
			this.listaDias.Size = new System.Drawing.Size(112, 143);
			this.listaDias.TabIndex = 36;
			this.listaDias.UseCompatibleStateImageBehavior = false;
			this.listaDias.View = System.Windows.Forms.View.Details;
			// 
			// ColDia
			// 
			this.ColDia.Text = "Dias";
			this.ColDia.Width = 80;
			// 
			// txtDias
			// 
			this.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDias.Location = new System.Drawing.Point(209, 122);
			this.txtDias.MaxLength = 50;
			this.txtDias.Name = "txtDias";
			this.txtDias.Size = new System.Drawing.Size(55, 20);
			this.txtDias.TabIndex = 37;
			this.txtDias.TextChanged += new System.EventHandler(this.MaskDias);
			this.txtDias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterDias);
			// 
			// labAddDias
			// 
			this.labAddDias.BackColor = System.Drawing.Color.Transparent;
			this.labAddDias.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labAddDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labAddDias.Location = new System.Drawing.Point(266, 122);
			this.labAddDias.Name = "labAddDias";
			this.labAddDias.Size = new System.Drawing.Size(70, 20);
			this.labAddDias.TabIndex = 38;
			this.labAddDias.Text = "Dia(s)";
			this.labAddDias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(143, 266);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Size = new System.Drawing.Size(111, 29);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 40;
			this.btnCancelar.Text = "Sair";
			this.btnCancelar.Click += new System.EventHandler(this.sairClique);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSalvar.Location = new System.Drawing.Point(260, 266);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(111, 29);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 39;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionar.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.btnAdicionar.Location = new System.Drawing.Point(303, 116);
			this.btnAdicionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(65, 31);
			this.btnAdicionar.TabIndex = 41;
			this.btnAdicionar.Text = "Add";
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueAdd);
			// 
			// btnDeletar
			// 
			this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeletar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnDeletar.Location = new System.Drawing.Point(209, 148);
			this.btnDeletar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(33, 31);
			this.btnDeletar.Symbol = 61453;
			this.btnDeletar.TabIndex = 42;
			this.btnDeletar.Click += new System.EventHandler(this.cliqueDeletar);
			// 
			// cbxTipo
			// 
			this.cbxTipo.BackColor = System.Drawing.Color.Transparent;
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.cbxTipo.Location = new System.Drawing.Point(12, 89);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(73, 21);
			this.cbxTipo.TabIndex = 43;
			this.cbxTipo.Text = "Tipo :";
			this.cbxTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCondicao
			// 
			this.cbxCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCondicao.FormattingEnabled = true;
			this.cbxCondicao.Items.AddRange(new object[] {
									"Compra/Venda",
									"Compra",
									"Venda"});
			this.cbxCondicao.Location = new System.Drawing.Point(91, 89);
			this.cbxCondicao.Name = "cbxCondicao";
			this.cbxCondicao.Size = new System.Drawing.Size(112, 21);
			this.cbxCondicao.TabIndex = 44;
			// 
			// CDCondicao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 309);
			this.Controls.Add(this.cbxCondicao);
			this.Controls.Add(this.cbxTipo);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.labAddDias);
			this.Controls.Add(this.txtDias);
			this.Controls.Add(this.listaDias);
			this.Controls.Add(this.labDias);
			this.Controls.Add(this.labTitulo);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.labNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CDCondicao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Condição";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox cbxCondicao;
		private ReaLTaiizor.Controls.DungeonLabel cbxTipo;
		private Sunny.UI.UISymbolButton btnDeletar;
		private Sunny.UI.UISymbolButton btnAdicionar;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private System.Windows.Forms.ColumnHeader ColDia;
		private ReaLTaiizor.Controls.DungeonLabel labAddDias;
		private System.Windows.Forms.TextBox txtDias;
		private System.Windows.Forms.ListView listaDias;
		private ReaLTaiizor.Controls.DungeonLabel labDias;
		private ReaLTaiizor.Controls.DungeonLabel labTitulo;
		private ReaLTaiizor.Controls.DungeonLabel labCodigo;
		private System.Windows.Forms.TextBox txtCodigo;
		private ReaLTaiizor.Controls.DungeonLabel labNome;
		private System.Windows.Forms.TextBox txtNome;
	}
}
