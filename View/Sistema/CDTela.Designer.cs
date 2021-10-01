
namespace GM.View.Sistema
{
	partial class CDTela
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDTela));
			this.txtTela = new GM.Componentes.MinBox();
			this.labTela = new System.Windows.Forms.Label();
			this.labSituacao = new System.Windows.Forms.Label();
			this.cbxSituacao = new GM.Componentes.MinComboBox();
			this.labPermissao = new System.Windows.Forms.Label();
			this.cbxNivel = new GM.Componentes.MinComboBox();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// txtTela
			// 
			this.txtTela.BackColor = System.Drawing.Color.White;
			this.txtTela.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtTela.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtTela.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtTela.CustomBGColor = System.Drawing.Color.White;
			this.txtTela.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtTela.ForeColor = System.Drawing.Color.Black;
			this.txtTela.Location = new System.Drawing.Point(108, 74);
			this.txtTela.MaxLength = 30;
			this.txtTela.Multiline = false;
			this.txtTela.Name = "txtTela";
			this.txtTela.ReadOnly = false;
			this.txtTela.SelectionStart = 0;
			this.txtTela.Size = new System.Drawing.Size(208, 28);
			this.txtTela.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtTela.TabIndex = 22;
			this.txtTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtTela.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtTela.UseSystemPasswordChar = false;
			// 
			// labTela
			// 
			this.labTela.BackColor = System.Drawing.Color.Transparent;
			this.labTela.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTela.Location = new System.Drawing.Point(12, 74);
			this.labTela.Name = "labTela";
			this.labTela.Size = new System.Drawing.Size(90, 25);
			this.labTela.TabIndex = 23;
			this.labTela.Text = "Tela :";
			this.labTela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labSituacao
			// 
			this.labSituacao.BackColor = System.Drawing.Color.Transparent;
			this.labSituacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSituacao.Location = new System.Drawing.Point(12, 105);
			this.labSituacao.Name = "labSituacao";
			this.labSituacao.Size = new System.Drawing.Size(90, 25);
			this.labSituacao.TabIndex = 33;
			this.labSituacao.Text = "Situação :";
			this.labSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSituacao
			// 
			this.cbxSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxSituacao.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSituacao.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSituacao.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxSituacao.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxSituacao.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxSituacao.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSituacao.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSituacao.ColorH = System.Drawing.Color.White;
			this.cbxSituacao.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxSituacao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxSituacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxSituacao.DropDownHeight = 100;
			this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSituacao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxSituacao.ForeColor = System.Drawing.Color.Black;
			this.cbxSituacao.FormattingEnabled = true;
			this.cbxSituacao.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxSituacao.IntegralHeight = false;
			this.cbxSituacao.ItemHeight = 20;
			this.cbxSituacao.Items.AddRange(new object[] {
									"Bloqueada",
									"Ativa"});
			this.cbxSituacao.Location = new System.Drawing.Point(108, 105);
			this.cbxSituacao.Name = "cbxSituacao";
			this.cbxSituacao.Size = new System.Drawing.Size(90, 26);
			this.cbxSituacao.StartIndex = 0;
			this.cbxSituacao.TabIndex = 32;
			// 
			// labPermissao
			// 
			this.labPermissao.BackColor = System.Drawing.Color.Transparent;
			this.labPermissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPermissao.Location = new System.Drawing.Point(12, 136);
			this.labPermissao.Name = "labPermissao";
			this.labPermissao.Size = new System.Drawing.Size(90, 25);
			this.labPermissao.TabIndex = 35;
			this.labPermissao.Text = "Permissão :";
			this.labPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.cbxNivel.Location = new System.Drawing.Point(108, 136);
			this.cbxNivel.Name = "cbxNivel";
			this.cbxNivel.Size = new System.Drawing.Size(154, 26);
			this.cbxNivel.StartIndex = 0;
			this.cbxNivel.TabIndex = 34;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(124, 174);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(93, 31);
			this.btnCancelar.TabIndex = 213;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.cliqueSair);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(223, 174);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(93, 31);
			this.btnSalvar.TabIndex = 212;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// CDTela
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(328, 217);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.labPermissao);
			this.Controls.Add(this.cbxNivel);
			this.Controls.Add(this.labSituacao);
			this.Controls.Add(this.cbxSituacao);
			this.Controls.Add(this.txtTela);
			this.Controls.Add(this.labTela);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CDTela";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro/Edição de tela";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private GM.Componentes.MinComboBox cbxNivel;
		private System.Windows.Forms.Label labPermissao;
		private GM.Componentes.MinComboBox cbxSituacao;
		private System.Windows.Forms.Label labSituacao;
		private System.Windows.Forms.Label labTela;
		private GM.Componentes.MinBox txtTela;
	}
}
