
namespace GM.View.relatorio.programado
{
	partial class CDProgramado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDProgramado));
			this.txtEmail = new GM.Componentes.MinBox();
			this.labEmail = new MaterialSkin.Controls.MaterialLabel();
			this.labRelatorio = new MaterialSkin.Controls.MaterialLabel();
			this.cbxRelatorio = new GM.Componentes.MinComboBox();
			this.labTipo = new MaterialSkin.Controls.MaterialLabel();
			this.cbxTipo = new GM.Componentes.MinComboBox();
			this.txtAssunto = new GM.Componentes.MinBox();
			this.labAssunto = new MaterialSkin.Controls.MaterialLabel();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.Transparent;
			this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtEmail.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtEmail.CustomBGColor = System.Drawing.Color.White;
			this.txtEmail.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
			this.txtEmail.Location = new System.Drawing.Point(97, 75);
			this.txtEmail.MaxLength = 50;
			this.txtEmail.Multiline = false;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ReadOnly = false;
			this.txtEmail.SelectionStart = 0;
			this.txtEmail.Size = new System.Drawing.Size(383, 28);
			this.txtEmail.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtEmail.TabIndex = 1;
			this.txtEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEmail.UseSystemPasswordChar = false;
			// 
			// labEmail
			// 
			this.labEmail.BackColor = System.Drawing.Color.Transparent;
			this.labEmail.Depth = 0;
			this.labEmail.Font = new System.Drawing.Font("Roboto", 11F);
			this.labEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labEmail.Location = new System.Drawing.Point(13, 75);
			this.labEmail.MouseState = MaterialSkin.MouseState.HOVER;
			this.labEmail.Name = "labEmail";
			this.labEmail.Size = new System.Drawing.Size(78, 28);
			this.labEmail.TabIndex = 4;
			this.labEmail.Text = "Email :";
			this.labEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labRelatorio
			// 
			this.labRelatorio.BackColor = System.Drawing.Color.Transparent;
			this.labRelatorio.Depth = 0;
			this.labRelatorio.Font = new System.Drawing.Font("Roboto", 11F);
			this.labRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labRelatorio.Location = new System.Drawing.Point(13, 109);
			this.labRelatorio.MouseState = MaterialSkin.MouseState.HOVER;
			this.labRelatorio.Name = "labRelatorio";
			this.labRelatorio.Size = new System.Drawing.Size(78, 26);
			this.labRelatorio.TabIndex = 6;
			this.labRelatorio.Text = "Relatório :";
			this.labRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxRelatorio
			// 
			this.cbxRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxRelatorio.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxRelatorio.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxRelatorio.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxRelatorio.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxRelatorio.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxRelatorio.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxRelatorio.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxRelatorio.ColorH = System.Drawing.Color.White;
			this.cbxRelatorio.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxRelatorio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxRelatorio.DropDownHeight = 100;
			this.cbxRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxRelatorio.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbxRelatorio.ForeColor = System.Drawing.Color.Black;
			this.cbxRelatorio.FormattingEnabled = true;
			this.cbxRelatorio.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxRelatorio.IntegralHeight = false;
			this.cbxRelatorio.ItemHeight = 20;
			this.cbxRelatorio.Location = new System.Drawing.Point(97, 109);
			this.cbxRelatorio.Name = "cbxRelatorio";
			this.cbxRelatorio.Size = new System.Drawing.Size(250, 26);
			this.cbxRelatorio.StartIndex = 0;
			this.cbxRelatorio.TabIndex = 2;
			// 
			// labTipo
			// 
			this.labTipo.BackColor = System.Drawing.Color.Transparent;
			this.labTipo.Depth = 0;
			this.labTipo.Font = new System.Drawing.Font("Roboto", 11F);
			this.labTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labTipo.Location = new System.Drawing.Point(13, 141);
			this.labTipo.MouseState = MaterialSkin.MouseState.HOVER;
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(78, 26);
			this.labTipo.TabIndex = 8;
			this.labTipo.Text = "Tipo :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbxTipo.ForeColor = System.Drawing.Color.Black;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxTipo.IntegralHeight = false;
			this.cbxTipo.ItemHeight = 20;
			this.cbxTipo.Items.AddRange(new object[] {
									"Diário",
									"Semanal",
									"Mensal"});
			this.cbxTipo.Location = new System.Drawing.Point(97, 141);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(142, 26);
			this.cbxTipo.StartIndex = 0;
			this.cbxTipo.TabIndex = 3;
			// 
			// txtAssunto
			// 
			this.txtAssunto.BackColor = System.Drawing.Color.Transparent;
			this.txtAssunto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtAssunto.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtAssunto.CustomBGColor = System.Drawing.Color.White;
			this.txtAssunto.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtAssunto.ForeColor = System.Drawing.Color.DimGray;
			this.txtAssunto.Location = new System.Drawing.Point(97, 173);
			this.txtAssunto.MaxLength = 32;
			this.txtAssunto.Multiline = false;
			this.txtAssunto.Name = "txtAssunto";
			this.txtAssunto.ReadOnly = false;
			this.txtAssunto.SelectionStart = 0;
			this.txtAssunto.Size = new System.Drawing.Size(250, 28);
			this.txtAssunto.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtAssunto.TabIndex = 4;
			this.txtAssunto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtAssunto.UseSystemPasswordChar = false;
			// 
			// labAssunto
			// 
			this.labAssunto.BackColor = System.Drawing.Color.Transparent;
			this.labAssunto.Depth = 0;
			this.labAssunto.Font = new System.Drawing.Font("Roboto", 11F);
			this.labAssunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labAssunto.Location = new System.Drawing.Point(13, 173);
			this.labAssunto.MouseState = MaterialSkin.MouseState.HOVER;
			this.labAssunto.Name = "labAssunto";
			this.labAssunto.Size = new System.Drawing.Size(78, 28);
			this.labAssunto.TabIndex = 10;
			this.labAssunto.Text = "Assunto :";
			this.labAssunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(368, 220);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(111, 29);
			this.btnSalvar.TabIndex = 5;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(251, 220);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(111, 29);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.cliqueCancelar);
			// 
			// CDProgramado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 261);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtAssunto);
			this.Controls.Add(this.labAssunto);
			this.Controls.Add(this.cbxTipo);
			this.Controls.Add(this.labTipo);
			this.Controls.Add(this.cbxRelatorio);
			this.Controls.Add(this.labRelatorio);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.labEmail);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "CDProgramado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Relatórios programados";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarTecla);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private MaterialSkin.Controls.MaterialLabel labAssunto;
		private GM.Componentes.MinBox txtAssunto;
		private GM.Componentes.MinComboBox cbxTipo;
		private MaterialSkin.Controls.MaterialLabel labTipo;
		private GM.Componentes.MinComboBox cbxRelatorio;
		private MaterialSkin.Controls.MaterialLabel labRelatorio;
		private MaterialSkin.Controls.MaterialLabel labEmail;
		private GM.Componentes.MinBox txtEmail;
	}
}
