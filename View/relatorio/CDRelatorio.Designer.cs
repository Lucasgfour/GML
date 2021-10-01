
namespace GM.View.relatorio
{
	partial class CDRelatorio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDRelatorio));
			this.txtDescricao = new GM.Componentes.MinBox();
			this.labDescricao = new System.Windows.Forms.Label();
			this.txtObservação = new GM.Componentes.MinBox();
			this.labObservacao = new System.Windows.Forms.Label();
			this.gpxComando = new System.Windows.Forms.GroupBox();
			this.txtComando = new GM.Componentes.MinBox();
			this.gpxParametro = new System.Windows.Forms.GroupBox();
			this.cbxTipo = new GM.Componentes.MinComboBox();
			this.labTipo = new System.Windows.Forms.Label();
			this.txtParametro = new GM.Componentes.MinBox();
			this.listaParametro = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.labParametro = new System.Windows.Forms.Label();
			this.cbxNivel = new GM.Componentes.MinComboBox();
			this.labNivel = new System.Windows.Forms.Label();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnRemover = new MaterialSkin.Controls.MaterialRaisedButton();
			this.gpxComando.SuspendLayout();
			this.gpxParametro.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.White;
			this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDescricao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CustomBGColor = System.Drawing.Color.White;
			this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtDescricao.ForeColor = System.Drawing.Color.Black;
			this.txtDescricao.Location = new System.Drawing.Point(108, 72);
			this.txtDescricao.MaxLength = 70;
			this.txtDescricao.Multiline = false;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.ReadOnly = false;
			this.txtDescricao.SelectionStart = 0;
			this.txtDescricao.Size = new System.Drawing.Size(594, 28);
			this.txtDescricao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDescricao.TabIndex = 0;
			this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.UseSystemPasswordChar = false;
			// 
			// labDescricao
			// 
			this.labDescricao.BackColor = System.Drawing.Color.Transparent;
			this.labDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDescricao.Location = new System.Drawing.Point(12, 72);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(90, 25);
			this.labDescricao.TabIndex = 19;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtObservação
			// 
			this.txtObservação.BackColor = System.Drawing.Color.White;
			this.txtObservação.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtObservação.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservação.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservação.CustomBGColor = System.Drawing.Color.White;
			this.txtObservação.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtObservação.ForeColor = System.Drawing.Color.Black;
			this.txtObservação.Location = new System.Drawing.Point(108, 103);
			this.txtObservação.MaxLength = 70;
			this.txtObservação.Multiline = true;
			this.txtObservação.Name = "txtObservação";
			this.txtObservação.ReadOnly = false;
			this.txtObservação.SelectionStart = 0;
			this.txtObservação.Size = new System.Drawing.Size(594, 60);
			this.txtObservação.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtObservação.TabIndex = 1;
			this.txtObservação.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservação.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservação.UseSystemPasswordChar = false;
			// 
			// labObservacao
			// 
			this.labObservacao.BackColor = System.Drawing.Color.Transparent;
			this.labObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labObservacao.Location = new System.Drawing.Point(12, 103);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(90, 25);
			this.labObservacao.TabIndex = 21;
			this.labObservacao.Text = "Observação :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gpxComando
			// 
			this.gpxComando.BackColor = System.Drawing.Color.Transparent;
			this.gpxComando.Controls.Add(this.txtComando);
			this.gpxComando.Location = new System.Drawing.Point(12, 169);
			this.gpxComando.Name = "gpxComando";
			this.gpxComando.Size = new System.Drawing.Size(690, 286);
			this.gpxComando.TabIndex = 201;
			this.gpxComando.TabStop = false;
			this.gpxComando.Text = "Comando SQL";
			// 
			// txtComando
			// 
			this.txtComando.BackColor = System.Drawing.Color.White;
			this.txtComando.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtComando.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtComando.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtComando.CustomBGColor = System.Drawing.Color.White;
			this.txtComando.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtComando.ForeColor = System.Drawing.Color.Black;
			this.txtComando.Location = new System.Drawing.Point(6, 22);
			this.txtComando.MaxLength = 1000;
			this.txtComando.Multiline = true;
			this.txtComando.Name = "txtComando";
			this.txtComando.ReadOnly = false;
			this.txtComando.SelectionStart = 0;
			this.txtComando.Size = new System.Drawing.Size(678, 258);
			this.txtComando.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtComando.TabIndex = 2;
			this.txtComando.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtComando.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtComando.UseSystemPasswordChar = false;
			// 
			// gpxParametro
			// 
			this.gpxParametro.BackColor = System.Drawing.Color.White;
			this.gpxParametro.Controls.Add(this.btnRemover);
			this.gpxParametro.Controls.Add(this.btnAdicionar);
			this.gpxParametro.Controls.Add(this.cbxTipo);
			this.gpxParametro.Controls.Add(this.labTipo);
			this.gpxParametro.Controls.Add(this.txtParametro);
			this.gpxParametro.Controls.Add(this.listaParametro);
			this.gpxParametro.Controls.Add(this.labParametro);
			this.gpxParametro.Location = new System.Drawing.Point(12, 461);
			this.gpxParametro.Name = "gpxParametro";
			this.gpxParametro.Size = new System.Drawing.Size(466, 215);
			this.gpxParametro.TabIndex = 202;
			this.gpxParametro.TabStop = false;
			this.gpxParametro.Text = "Parâmetros";
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
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxTipo.ForeColor = System.Drawing.Color.Black;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxTipo.IntegralHeight = false;
			this.cbxTipo.ItemHeight = 20;
			this.cbxTipo.Items.AddRange(new object[] {
									"TEXTO",
									"NÚMERO INTEIRO",
									"NÚMERO float",
									"DATA"});
			this.cbxTipo.Location = new System.Drawing.Point(306, 55);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(154, 26);
			this.cbxTipo.StartIndex = 0;
			this.cbxTipo.TabIndex = 4;
			this.cbxTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterParametro);
			// 
			// labTipo
			// 
			this.labTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTipo.Location = new System.Drawing.Point(210, 55);
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(90, 25);
			this.labTipo.TabIndex = 205;
			this.labTipo.Text = "Tipo :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtParametro
			// 
			this.txtParametro.BackColor = System.Drawing.Color.White;
			this.txtParametro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtParametro.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtParametro.CustomBGColor = System.Drawing.Color.White;
			this.txtParametro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtParametro.ForeColor = System.Drawing.Color.Black;
			this.txtParametro.Location = new System.Drawing.Point(306, 24);
			this.txtParametro.MaxLength = 70;
			this.txtParametro.Multiline = false;
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.ReadOnly = false;
			this.txtParametro.SelectionStart = 0;
			this.txtParametro.Size = new System.Drawing.Size(154, 28);
			this.txtParametro.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtParametro.TabIndex = 3;
			this.txtParametro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtParametro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtParametro.UseSystemPasswordChar = false;
			this.txtParametro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterParametro);
			// 
			// listaParametro
			// 
			this.listaParametro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02});
			this.listaParametro.FullRowSelect = true;
			this.listaParametro.GridLines = true;
			this.listaParametro.Location = new System.Drawing.Point(6, 24);
			this.listaParametro.MultiSelect = false;
			this.listaParametro.Name = "listaParametro";
			this.listaParametro.Size = new System.Drawing.Size(198, 185);
			this.listaParametro.TabIndex = 7;
			this.listaParametro.UseCompatibleStateImageBehavior = false;
			this.listaParametro.View = System.Windows.Forms.View.Details;
			// 
			// Col01
			// 
			this.Col01.Text = "Parâmetro";
			this.Col01.Width = 90;
			// 
			// Col02
			// 
			this.Col02.Text = "Tipo";
			this.Col02.Width = 80;
			// 
			// labParametro
			// 
			this.labParametro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labParametro.Location = new System.Drawing.Point(210, 24);
			this.labParametro.Name = "labParametro";
			this.labParametro.Size = new System.Drawing.Size(90, 25);
			this.labParametro.TabIndex = 204;
			this.labParametro.Text = "Parâmetro :";
			this.labParametro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxNivel
			// 
			this.cbxNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxNivel.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxNivel.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxNivel.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxNivel.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxNivel.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxNivel.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxNivel.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxNivel.ColorH = System.Drawing.Color.White;
			this.cbxNivel.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxNivel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxNivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxNivel.DropDownHeight = 100;
			this.cbxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxNivel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxNivel.ForeColor = System.Drawing.Color.Black;
			this.cbxNivel.FormattingEnabled = true;
			this.cbxNivel.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxNivel.IntegralHeight = false;
			this.cbxNivel.ItemHeight = 20;
			this.cbxNivel.Items.AddRange(new object[] {
									"Nível 0",
									"Nível 1",
									"Nível 2",
									"Nível 3",
									"Nível 4",
									"Nível 5",
									"Nível 6",
									"Nível 7",
									"Nível 8",
									"Nível 9",
									"Nível 10"});
			this.cbxNivel.Location = new System.Drawing.Point(517, 516);
			this.cbxNivel.Name = "cbxNivel";
			this.cbxNivel.Size = new System.Drawing.Size(154, 26);
			this.cbxNivel.StartIndex = 0;
			this.cbxNivel.TabIndex = 8;
			// 
			// labNivel
			// 
			this.labNivel.BackColor = System.Drawing.Color.Transparent;
			this.labNivel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNivel.Location = new System.Drawing.Point(484, 470);
			this.labNivel.Name = "labNivel";
			this.labNivel.Size = new System.Drawing.Size(218, 40);
			this.labNivel.TabIndex = 209;
			this.labNivel.Text = "Nível de usuário necessário para gerar o relatório :";
			this.labNivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(510, 644);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(93, 31);
			this.btnCancelar.TabIndex = 211;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.cliqueSair);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(609, 644);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(93, 31);
			this.btnSalvar.TabIndex = 210;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Depth = 0;
			this.btnAdicionar.Location = new System.Drawing.Point(355, 87);
			this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Primary = true;
			this.btnAdicionar.Size = new System.Drawing.Size(105, 28);
			this.btnAdicionar.TabIndex = 212;
			this.btnAdicionar.Text = "ADICIONAR";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueAdicionar);
			// 
			// btnRemover
			// 
			this.btnRemover.Depth = 0;
			this.btnRemover.Location = new System.Drawing.Point(210, 181);
			this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Primary = true;
			this.btnRemover.Size = new System.Drawing.Size(105, 28);
			this.btnRemover.TabIndex = 213;
			this.btnRemover.Text = "REMOVER";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.cliqueRemover);
			// 
			// CDRelatorio
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(714, 687);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.cbxNivel);
			this.Controls.Add(this.labNivel);
			this.Controls.Add(this.gpxParametro);
			this.Controls.Add(this.gpxComando);
			this.Controls.Add(this.txtObservação);
			this.Controls.Add(this.labObservacao);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDRelatorio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Relatório";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.gpxComando.ResumeLayout(false);
			this.gpxParametro.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labNivel;
		private GM.Componentes.MinComboBox cbxNivel;
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
		private MaterialSkin.Controls.MaterialRaisedButton btnRemover;
		private GM.Componentes.MinComboBox cbxTipo;
		private System.Windows.Forms.Label labParametro;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaParametro;
		private GM.Componentes.MinBox txtParametro;
		private System.Windows.Forms.Label labTipo;
		private System.Windows.Forms.GroupBox gpxParametro;
		private GM.Componentes.MinBox txtComando;
		private System.Windows.Forms.GroupBox gpxComando;
		private System.Windows.Forms.Label labObservacao;
		private GM.Componentes.MinBox txtObservação;
		private System.Windows.Forms.Label labDescricao;
		private GM.Componentes.MinBox txtDescricao;
	}
}
