
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDCondicao));
			this.txtNome = new GM.Componentes.MinBox();
			this.labNome = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtCodigo = new GM.Componentes.MinBox();
			this.labCodigo = new ReaLTaiizor.Controls.DungeonLabel();
			this.labTitulo = new ReaLTaiizor.Controls.DungeonLabel();
			this.labDias = new ReaLTaiizor.Controls.DungeonLabel();
			this.listaDias = new System.Windows.Forms.ListView();
			this.ColDia = new System.Windows.Forms.ColumnHeader();
			this.txtDias = new GM.Componentes.MinBox();
			this.labAddDias = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.btnAdicionar = new Sunny.UI.UISymbolButton();
			this.btnDeletar = new Sunny.UI.UISymbolButton();
			this.cbxTipo = new ReaLTaiizor.Controls.DungeonLabel();
			this.cbxCondicao = new GM.Componentes.MinComboBox();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.Transparent;
			this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtNome.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNome.CustomBGColor = System.Drawing.Color.White;
			this.txtNome.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtNome.ForeColor = System.Drawing.Color.Black;
			this.txtNome.Location = new System.Drawing.Point(91, 155);
			this.txtNome.MaxLength = 50;
			this.txtNome.Multiline = false;
			this.txtNome.Name = "txtNome";
			this.txtNome.ReadOnly = false;
			this.txtNome.SelectionStart = 0;
			this.txtNome.Size = new System.Drawing.Size(277, 28);
			this.txtNome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNome.TabIndex = 30;
			this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.UseSystemPasswordChar = false;
			// 
			// labNome
			// 
			this.labNome.BackColor = System.Drawing.Color.Transparent;
			this.labNome.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labNome.Location = new System.Drawing.Point(12, 155);
			this.labNome.Name = "labNome";
			this.labNome.Size = new System.Drawing.Size(73, 28);
			this.labNome.TabIndex = 31;
			this.labNome.Text = "Nome :";
			this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
			this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigo.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtCodigo.ForeColor = System.Drawing.Color.Black;
			this.txtCodigo.Location = new System.Drawing.Point(91, 121);
			this.txtCodigo.MaxLength = 50;
			this.txtCodigo.Multiline = false;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = true;
			this.txtCodigo.SelectionStart = 0;
			this.txtCodigo.Size = new System.Drawing.Size(77, 28);
			this.txtCodigo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigo.TabIndex = 32;
			this.txtCodigo.TabStop = false;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.UseSystemPasswordChar = false;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCodigo.Location = new System.Drawing.Point(12, 121);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(73, 28);
			this.labCodigo.TabIndex = 0;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labTitulo
			// 
			this.labTitulo.BackColor = System.Drawing.Color.Transparent;
			this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labTitulo.Location = new System.Drawing.Point(12, 80);
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
			this.labDias.Location = new System.Drawing.Point(12, 221);
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
			this.listaDias.Location = new System.Drawing.Point(91, 221);
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
			this.ColDia.Width = 76;
			// 
			// txtDias
			// 
			this.txtDias.BackColor = System.Drawing.Color.Transparent;
			this.txtDias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDias.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDias.CustomBGColor = System.Drawing.Color.White;
			this.txtDias.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtDias.ForeColor = System.Drawing.Color.Black;
			this.txtDias.Location = new System.Drawing.Point(209, 221);
			this.txtDias.MaxLength = 50;
			this.txtDias.Multiline = false;
			this.txtDias.Name = "txtDias";
			this.txtDias.ReadOnly = false;
			this.txtDias.SelectionStart = 0;
			this.txtDias.Size = new System.Drawing.Size(55, 28);
			this.txtDias.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDias.TabIndex = 37;
			this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDias.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDias.UseSystemPasswordChar = false;
			this.txtDias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterDias);
			this.txtDias.TextChanged += new System.EventHandler(this.MaskDias);
			// 
			// labAddDias
			// 
			this.labAddDias.BackColor = System.Drawing.Color.Transparent;
			this.labAddDias.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labAddDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labAddDias.Location = new System.Drawing.Point(265, 221);
			this.labAddDias.Name = "labAddDias";
			this.labAddDias.Size = new System.Drawing.Size(70, 28);
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
			this.btnCancelar.Location = new System.Drawing.Point(143, 378);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
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
			this.btnSalvar.Location = new System.Drawing.Point(260, 378);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
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
			this.btnAdicionar.Location = new System.Drawing.Point(303, 221);
			this.btnAdicionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnAdicionar.Size = new System.Drawing.Size(68, 31);
			this.btnAdicionar.TabIndex = 41;
			this.btnAdicionar.Text = "Add";
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueAdd);
			// 
			// btnDeletar
			// 
			this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeletar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnDeletar.Location = new System.Drawing.Point(209, 253);
			this.btnDeletar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnDeletar.Size = new System.Drawing.Size(45, 31);
			this.btnDeletar.Symbol = 61453;
			this.btnDeletar.TabIndex = 42;
			this.btnDeletar.Click += new System.EventHandler(this.cliqueDeletar);
			// 
			// cbxTipo
			// 
			this.cbxTipo.BackColor = System.Drawing.Color.Transparent;
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.cbxTipo.Location = new System.Drawing.Point(12, 189);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(73, 26);
			this.cbxTipo.TabIndex = 43;
			this.cbxTipo.Text = "Tipo :";
			this.cbxTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCondicao
			// 
			this.cbxCondicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxCondicao.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxCondicao.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxCondicao.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxCondicao.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxCondicao.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxCondicao.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxCondicao.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxCondicao.ColorH = System.Drawing.Color.White;
			this.cbxCondicao.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxCondicao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxCondicao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxCondicao.DropDownHeight = 100;
			this.cbxCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCondicao.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbxCondicao.ForeColor = System.Drawing.Color.Black;
			this.cbxCondicao.FormattingEnabled = true;
			this.cbxCondicao.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxCondicao.IntegralHeight = false;
			this.cbxCondicao.ItemHeight = 20;
			this.cbxCondicao.Items.AddRange(new object[] {
									"Compra/Venda",
									"Compra",
									"Venda"});
			this.cbxCondicao.Location = new System.Drawing.Point(91, 189);
			this.cbxCondicao.Name = "cbxCondicao";
			this.cbxCondicao.Size = new System.Drawing.Size(112, 26);
			this.cbxCondicao.StartIndex = 0;
			this.cbxCondicao.TabIndex = 44;
			// 
			// CDCondicao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 419);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDCondicao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Condição";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private GM.Componentes.MinComboBox cbxCondicao;
		private ReaLTaiizor.Controls.DungeonLabel cbxTipo;
		private Sunny.UI.UISymbolButton btnDeletar;
		private Sunny.UI.UISymbolButton btnAdicionar;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private System.Windows.Forms.ColumnHeader ColDia;
		private ReaLTaiizor.Controls.DungeonLabel labAddDias;
		private GM.Componentes.MinBox txtDias;
		private System.Windows.Forms.ListView listaDias;
		private ReaLTaiizor.Controls.DungeonLabel labDias;
		private ReaLTaiizor.Controls.DungeonLabel labTitulo;
		private ReaLTaiizor.Controls.DungeonLabel labCodigo;
		private GM.Componentes.MinBox txtCodigo;
		private ReaLTaiizor.Controls.DungeonLabel labNome;
		private GM.Componentes.MinBox txtNome;
	}
}
