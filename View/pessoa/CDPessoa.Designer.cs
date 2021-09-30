
namespace GM.View.pessoa
{
	partial class CDPessoa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDPessoa));
			this.txtCodigo = new GM.Componentes.MinBox();
			this.labCodigo = new ReaLTaiizor.Controls.DungeonLabel();
			this.cbxTipo = new GM.Componentes.MinComboBox();
			this.labTipo = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtNome = new GM.Componentes.MinBox();
			this.labNome = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtContato = new GM.Componentes.MinBox();
			this.labContato = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtDocumento = new GM.Componentes.MinBox();
			this.labDocumento = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtObservacao = new GM.Componentes.MinBox();
			this.labObservacao = new ReaLTaiizor.Controls.DungeonLabel();
			this.cbxDocumento = new GM.Componentes.MinComboBox();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnProximo = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.btnEndereco = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
			this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigo.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.ForeColor = System.Drawing.Color.Black;
			this.txtCodigo.Location = new System.Drawing.Point(88, 143);
			this.txtCodigo.MaxLength = 70;
			this.txtCodigo.Multiline = false;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = true;
			this.txtCodigo.SelectionStart = 0;
			this.txtCodigo.Size = new System.Drawing.Size(98, 26);
			this.txtCodigo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigo.TabIndex = 26;
			this.txtCodigo.TabStop = false;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.UseSystemPasswordChar = false;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCodigo.Location = new System.Drawing.Point(9, 143);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(73, 26);
			this.labCodigo.TabIndex = 31;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxTipo
			// 
			this.cbxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxTipo.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxTipo.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxTipo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxTipo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxTipo.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxTipo.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxTipo.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxTipo.ColorH = System.Drawing.Color.White;
			this.cbxTipo.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxTipo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxTipo.DropDownHeight = 100;
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxTipo.ForeColor = System.Drawing.Color.Black;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxTipo.IntegralHeight = false;
			this.cbxTipo.ItemHeight = 20;
			this.cbxTipo.Items.AddRange(new object[] {
									"Cliente",
									"Fornecedor",
									"Ambos"});
			this.cbxTipo.Location = new System.Drawing.Point(88, 207);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(121, 26);
			this.cbxTipo.StartIndex = 0;
			this.cbxTipo.TabIndex = 7;
			// 
			// labTipo
			// 
			this.labTipo.BackColor = System.Drawing.Color.Transparent;
			this.labTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labTipo.Location = new System.Drawing.Point(9, 207);
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(73, 21);
			this.labTipo.TabIndex = 30;
			this.labTipo.Text = "Tipo :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.Transparent;
			this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtNome.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNome.CustomBGColor = System.Drawing.Color.White;
			this.txtNome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.ForeColor = System.Drawing.Color.Black;
			this.txtNome.Location = new System.Drawing.Point(88, 175);
			this.txtNome.MaxLength = 70;
			this.txtNome.Multiline = false;
			this.txtNome.Name = "txtNome";
			this.txtNome.ReadOnly = false;
			this.txtNome.SelectionStart = 0;
			this.txtNome.Size = new System.Drawing.Size(277, 26);
			this.txtNome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNome.TabIndex = 6;
			this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.UseSystemPasswordChar = false;
			// 
			// labNome
			// 
			this.labNome.BackColor = System.Drawing.Color.Transparent;
			this.labNome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labNome.Location = new System.Drawing.Point(9, 175);
			this.labNome.Name = "labNome";
			this.labNome.Size = new System.Drawing.Size(73, 20);
			this.labNome.TabIndex = 29;
			this.labNome.Text = "Nome :";
			this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtContato
			// 
			this.txtContato.BackColor = System.Drawing.Color.Transparent;
			this.txtContato.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtContato.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtContato.CustomBGColor = System.Drawing.Color.White;
			this.txtContato.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContato.ForeColor = System.Drawing.Color.Black;
			this.txtContato.Location = new System.Drawing.Point(88, 271);
			this.txtContato.MaxLength = 50;
			this.txtContato.Multiline = true;
			this.txtContato.Name = "txtContato";
			this.txtContato.ReadOnly = false;
			this.txtContato.SelectionStart = 0;
			this.txtContato.Size = new System.Drawing.Size(121, 43);
			this.txtContato.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtContato.TabIndex = 10;
			this.txtContato.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtContato.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtContato.UseSystemPasswordChar = false;
			// 
			// labContato
			// 
			this.labContato.BackColor = System.Drawing.Color.Transparent;
			this.labContato.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labContato.Location = new System.Drawing.Point(9, 269);
			this.labContato.Name = "labContato";
			this.labContato.Size = new System.Drawing.Size(73, 20);
			this.labContato.TabIndex = 33;
			this.labContato.Text = "Contato :";
			this.labContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDocumento
			// 
			this.txtDocumento.BackColor = System.Drawing.Color.Transparent;
			this.txtDocumento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDocumento.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDocumento.CustomBGColor = System.Drawing.Color.White;
			this.txtDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocumento.ForeColor = System.Drawing.Color.Black;
			this.txtDocumento.Location = new System.Drawing.Point(154, 239);
			this.txtDocumento.MaxLength = 70;
			this.txtDocumento.Multiline = false;
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.ReadOnly = false;
			this.txtDocumento.SelectionStart = 0;
			this.txtDocumento.Size = new System.Drawing.Size(160, 26);
			this.txtDocumento.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDocumento.TabIndex = 9;
			this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDocumento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDocumento.UseSystemPasswordChar = false;
			this.txtDocumento.TextChanged += new System.EventHandler(this.maskDocumento);
			// 
			// labDocumento
			// 
			this.labDocumento.BackColor = System.Drawing.Color.Transparent;
			this.labDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labDocumento.Location = new System.Drawing.Point(9, 240);
			this.labDocumento.Name = "labDocumento";
			this.labDocumento.Size = new System.Drawing.Size(73, 20);
			this.labDocumento.TabIndex = 35;
			this.labDocumento.Text = "CPF / CNPJ :";
			this.labDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtObservacao
			// 
			this.txtObservacao.BackColor = System.Drawing.Color.Transparent;
			this.txtObservacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtObservacao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CustomBGColor = System.Drawing.Color.White;
			this.txtObservacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacao.ForeColor = System.Drawing.Color.Black;
			this.txtObservacao.Location = new System.Drawing.Point(88, 320);
			this.txtObservacao.MaxLength = 200;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.ReadOnly = false;
			this.txtObservacao.SelectionStart = 0;
			this.txtObservacao.Size = new System.Drawing.Size(277, 67);
			this.txtObservacao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtObservacao.TabIndex = 11;
			this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.UseSystemPasswordChar = false;
			// 
			// labObservacao
			// 
			this.labObservacao.BackColor = System.Drawing.Color.Transparent;
			this.labObservacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labObservacao.Location = new System.Drawing.Point(2, 318);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(80, 20);
			this.labObservacao.TabIndex = 37;
			this.labObservacao.Text = "Observação :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxDocumento
			// 
			this.cbxDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxDocumento.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxDocumento.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxDocumento.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxDocumento.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxDocumento.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxDocumento.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxDocumento.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxDocumento.ColorH = System.Drawing.Color.White;
			this.cbxDocumento.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxDocumento.DropDownHeight = 100;
			this.cbxDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDocumento.ForeColor = System.Drawing.Color.Black;
			this.cbxDocumento.FormattingEnabled = true;
			this.cbxDocumento.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxDocumento.IntegralHeight = false;
			this.cbxDocumento.ItemHeight = 20;
			this.cbxDocumento.Items.AddRange(new object[] {
									"CPF",
									"CNPJ"});
			this.cbxDocumento.Location = new System.Drawing.Point(88, 239);
			this.cbxDocumento.Name = "cbxDocumento";
			this.cbxDocumento.Size = new System.Drawing.Size(60, 26);
			this.cbxDocumento.StartIndex = 0;
			this.cbxDocumento.TabIndex = 8;
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.Silver;
			this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.White;
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.Location = new System.Drawing.Point(108, 75);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(30, 51);
			this.btnEditar.TabIndex = 60;
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.editarClique);
			// 
			// btnVoltar
			// 
			this.btnVoltar.BackColor = System.Drawing.Color.Silver;
			this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.ForeColor = System.Drawing.Color.White;
			this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
			this.btnVoltar.Location = new System.Drawing.Point(10, 75);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(30, 51);
			this.btnVoltar.TabIndex = 59;
			this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.voltarClique);
			// 
			// btnProximo
			// 
			this.btnProximo.BackColor = System.Drawing.Color.Silver;
			this.btnProximo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProximo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProximo.ForeColor = System.Drawing.Color.White;
			this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
			this.btnProximo.Location = new System.Drawing.Point(41, 75);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new System.Drawing.Size(30, 51);
			this.btnProximo.TabIndex = 61;
			this.btnProximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnProximo.UseVisualStyleBackColor = false;
			this.btnProximo.Click += new System.EventHandler(this.proximoClique);
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.Silver;
			this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.ForeColor = System.Drawing.Color.White;
			this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
			this.btnNovo.Location = new System.Drawing.Point(77, 75);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(30, 51);
			this.btnNovo.TabIndex = 62;
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.novoClique);
			// 
			// btnDeletar
			// 
			this.btnDeletar.BackColor = System.Drawing.Color.Silver;
			this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeletar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeletar.ForeColor = System.Drawing.Color.White;
			this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
			this.btnDeletar.Location = new System.Drawing.Point(139, 75);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(30, 51);
			this.btnDeletar.TabIndex = 63;
			this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDeletar.UseVisualStyleBackColor = false;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.Silver;
			this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ForeColor = System.Drawing.Color.White;
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.Location = new System.Drawing.Point(175, 75);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(35, 51);
			this.btnSalvar.TabIndex = 64;
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.salvarClique);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Silver;
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.White;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(211, 75);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(35, 51);
			this.btnCancelar.TabIndex = 65;
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.cancelarClique);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.Color.Silver;
			this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.ForeColor = System.Drawing.Color.White;
			this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
			this.btnPesquisar.Location = new System.Drawing.Point(252, 75);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(30, 51);
			this.btnPesquisar.TabIndex = 66;
			this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// btnEndereco
			// 
			this.btnEndereco.BackColor = System.Drawing.Color.Silver;
			this.btnEndereco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEndereco.ForeColor = System.Drawing.Color.White;
			this.btnEndereco.Image = ((System.Drawing.Image)(resources.GetObject("btnEndereco.Image")));
			this.btnEndereco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEndereco.Location = new System.Drawing.Point(283, 75);
			this.btnEndereco.Name = "btnEndereco";
			this.btnEndereco.Size = new System.Drawing.Size(85, 51);
			this.btnEndereco.TabIndex = 67;
			this.btnEndereco.Text = "Endereço(s)\r";
			this.btnEndereco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEndereco.UseVisualStyleBackColor = false;
			this.btnEndereco.Click += new System.EventHandler(this.enderecoClique);
			// 
			// CDPessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 409);
			this.Controls.Add(this.btnEndereco);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.btnProximo);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.cbxDocumento);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.labObservacao);
			this.Controls.Add(this.txtDocumento);
			this.Controls.Add(this.labDocumento);
			this.Controls.Add(this.txtContato);
			this.Controls.Add(this.labContato);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.cbxTipo);
			this.Controls.Add(this.labTipo);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.labNome);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDPessoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Cliente / Fornecedores";
			this.Load += new System.EventHandler(this.Arranque);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnEndereco;
		private GM.Componentes.MinComboBox cbxDocumento;
		private ReaLTaiizor.Controls.DungeonLabel labObservacao;
		private GM.Componentes.MinBox txtObservacao;
		private ReaLTaiizor.Controls.DungeonLabel labDocumento;
		private GM.Componentes.MinBox txtDocumento;
		private ReaLTaiizor.Controls.DungeonLabel labContato;
		private GM.Componentes.MinBox txtContato;
		private ReaLTaiizor.Controls.DungeonLabel labNome;
		private GM.Componentes.MinBox txtNome;
		private ReaLTaiizor.Controls.DungeonLabel labTipo;
		private GM.Componentes.MinComboBox cbxTipo;
		private ReaLTaiizor.Controls.DungeonLabel labCodigo;
		private GM.Componentes.MinBox txtCodigo;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnProximo;
		private System.Windows.Forms.Button btnVoltar;
	}
}
