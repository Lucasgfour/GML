
namespace GM.View.Sistema
{
	partial class CDUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDUsuario));
			this.txtUsuario = new GM.Componentes.MinBox();
			this.labUsuario = new System.Windows.Forms.Label();
			this.txtNome = new GM.Componentes.MinBox();
			this.labNome = new System.Windows.Forms.Label();
			this.cbxNivel = new GM.Componentes.MinComboBox();
			this.labPermissao = new System.Windows.Forms.Label();
			this.chkVendedor = new System.Windows.Forms.CheckBox();
			this.labSede = new System.Windows.Forms.Label();
			this.cbxSede = new GM.Componentes.MinComboBox();
			this.labPin1 = new System.Windows.Forms.Label();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.White;
			this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtUsuario.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtUsuario.CustomBGColor = System.Drawing.Color.White;
			this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtUsuario.ForeColor = System.Drawing.Color.Black;
			this.txtUsuario.Location = new System.Drawing.Point(108, 72);
			this.txtUsuario.MaxLength = 20;
			this.txtUsuario.Multiline = false;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.ReadOnly = false;
			this.txtUsuario.SelectionStart = 0;
			this.txtUsuario.Size = new System.Drawing.Size(141, 28);
			this.txtUsuario.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtUsuario.TabIndex = 20;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUsuario.UseSystemPasswordChar = false;
			// 
			// labUsuario
			// 
			this.labUsuario.BackColor = System.Drawing.Color.Transparent;
			this.labUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labUsuario.Location = new System.Drawing.Point(12, 72);
			this.labUsuario.Name = "labUsuario";
			this.labUsuario.Size = new System.Drawing.Size(90, 25);
			this.labUsuario.TabIndex = 21;
			this.labUsuario.Text = "Usuário :";
			this.labUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.White;
			this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtNome.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNome.CustomBGColor = System.Drawing.Color.White;
			this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtNome.ForeColor = System.Drawing.Color.Black;
			this.txtNome.Location = new System.Drawing.Point(108, 106);
			this.txtNome.MaxLength = 40;
			this.txtNome.Multiline = false;
			this.txtNome.Name = "txtNome";
			this.txtNome.ReadOnly = false;
			this.txtNome.SelectionStart = 0;
			this.txtNome.Size = new System.Drawing.Size(338, 28);
			this.txtNome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNome.TabIndex = 25;
			this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.UseSystemPasswordChar = false;
			// 
			// labNome
			// 
			this.labNome.BackColor = System.Drawing.Color.Transparent;
			this.labNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNome.Location = new System.Drawing.Point(12, 106);
			this.labNome.Name = "labNome";
			this.labNome.Size = new System.Drawing.Size(90, 25);
			this.labNome.TabIndex = 26;
			this.labNome.Text = "Nome :";
			this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.cbxNivel.Location = new System.Drawing.Point(108, 140);
			this.cbxNivel.Name = "cbxNivel";
			this.cbxNivel.Size = new System.Drawing.Size(154, 26);
			this.cbxNivel.StartIndex = 0;
			this.cbxNivel.TabIndex = 27;
			// 
			// labPermissao
			// 
			this.labPermissao.BackColor = System.Drawing.Color.Transparent;
			this.labPermissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPermissao.Location = new System.Drawing.Point(12, 140);
			this.labPermissao.Name = "labPermissao";
			this.labPermissao.Size = new System.Drawing.Size(90, 25);
			this.labPermissao.TabIndex = 28;
			this.labPermissao.Text = "Permissão :";
			this.labPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkVendedor
			// 
			this.chkVendedor.BackColor = System.Drawing.Color.Transparent;
			this.chkVendedor.Location = new System.Drawing.Point(279, 140);
			this.chkVendedor.Name = "chkVendedor";
			this.chkVendedor.Size = new System.Drawing.Size(167, 25);
			this.chkVendedor.TabIndex = 29;
			this.chkVendedor.Text = "Vendedor";
			this.chkVendedor.UseVisualStyleBackColor = false;
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSede.Location = new System.Drawing.Point(12, 172);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(90, 25);
			this.labSede.TabIndex = 31;
			this.labSede.Text = "Sede :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSede
			// 
			this.cbxSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxSede.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSede.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSede.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxSede.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxSede.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxSede.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSede.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSede.ColorH = System.Drawing.Color.White;
			this.cbxSede.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxSede.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxSede.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxSede.DropDownHeight = 100;
			this.cbxSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSede.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxSede.ForeColor = System.Drawing.Color.Black;
			this.cbxSede.FormattingEnabled = true;
			this.cbxSede.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxSede.IntegralHeight = false;
			this.cbxSede.ItemHeight = 20;
			this.cbxSede.Items.AddRange(new object[] {
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
			this.cbxSede.Location = new System.Drawing.Point(108, 172);
			this.cbxSede.Name = "cbxSede";
			this.cbxSede.Size = new System.Drawing.Size(154, 26);
			this.cbxSede.StartIndex = 0;
			this.cbxSede.TabIndex = 30;
			// 
			// labPin1
			// 
			this.labPin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(185)))));
			this.labPin1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPin1.Location = new System.Drawing.Point(12, 204);
			this.labPin1.Name = "labPin1";
			this.labPin1.Padding = new System.Windows.Forms.Padding(1);
			this.labPin1.Size = new System.Drawing.Size(237, 36);
			this.labPin1.TabIndex = 33;
			this.labPin1.Text = "Por padrão a senha é \"chave123\" e o pin é \"1234\"";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(255, 204);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(93, 36);
			this.btnCancelar.TabIndex = 215;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.cliqueSair);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(353, 204);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(93, 36);
			this.btnSalvar.TabIndex = 214;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// CDUsuario
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(458, 250);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.labPin1);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.cbxSede);
			this.Controls.Add(this.chkVendedor);
			this.Controls.Add(this.labPermissao);
			this.Controls.Add(this.cbxNivel);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.labNome);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.labUsuario);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro/edição de usuário";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private System.Windows.Forms.Label labPin1;
		private GM.Componentes.MinComboBox cbxSede;
		private System.Windows.Forms.Label labSede;
		private System.Windows.Forms.CheckBox chkVendedor;
		private System.Windows.Forms.Label labPermissao;
		private GM.Componentes.MinComboBox cbxNivel;
		private System.Windows.Forms.Label labNome;
		private GM.Componentes.MinBox txtNome;
		private System.Windows.Forms.Label labUsuario;
		private GM.Componentes.MinBox txtUsuario;
	}
}
