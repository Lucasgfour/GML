
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
			this.labSenha = new System.Windows.Forms.Label();
			this.labSenha2 = new System.Windows.Forms.Label();
			this.txtNome = new GM.Componentes.MinBox();
			this.labNome = new System.Windows.Forms.Label();
			this.cbxNivel = new GM.Componentes.MinComboBox();
			this.labPermissao = new System.Windows.Forms.Label();
			this.chkVendedor = new System.Windows.Forms.CheckBox();
			this.labSede = new System.Windows.Forms.Label();
			this.cbxSede = new GM.Componentes.MinComboBox();
			this.labPin = new System.Windows.Forms.Label();
			this.labPin2 = new System.Windows.Forms.Label();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.White;
			this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtUsuario.Location = new System.Drawing.Point(108, 72);
			this.txtUsuario.MaxLength = 20;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(141, 25);
			this.txtUsuario.TabIndex = 20;
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
			// labSenha
			// 
			this.labSenha.BackColor = System.Drawing.Color.Transparent;
			this.labSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSenha.Location = new System.Drawing.Point(12, 103);
			this.labSenha.Name = "labSenha";
			this.labSenha.Size = new System.Drawing.Size(90, 25);
			this.labSenha.TabIndex = 23;
			this.labSenha.Text = "Senha :";
			this.labSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labSenha2
			// 
			this.labSenha2.BackColor = System.Drawing.Color.Transparent;
			this.labSenha2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSenha2.Location = new System.Drawing.Point(108, 103);
			this.labSenha2.Name = "labSenha2";
			this.labSenha2.Size = new System.Drawing.Size(211, 25);
			this.labSenha2.TabIndex = 24;
			this.labSenha2.Text = "Por padrão a senha é chave123";
			this.labSenha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.White;
			this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtNome.Location = new System.Drawing.Point(108, 131);
			this.txtNome.MaxLength = 40;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(338, 25);
			this.txtNome.TabIndex = 25;
			// 
			// labNome
			// 
			this.labNome.BackColor = System.Drawing.Color.Transparent;
			this.labNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNome.Location = new System.Drawing.Point(12, 131);
			this.labNome.Name = "labNome";
			this.labNome.Size = new System.Drawing.Size(90, 25);
			this.labNome.TabIndex = 26;
			this.labNome.Text = "Nome :";
			this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxNivel
			// 
			this.cbxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxNivel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxNivel.FormattingEnabled = true;
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
			this.cbxNivel.Location = new System.Drawing.Point(108, 162);
			this.cbxNivel.Name = "cbxNivel";
			this.cbxNivel.Size = new System.Drawing.Size(154, 25);
			this.cbxNivel.TabIndex = 27;
			// 
			// labPermissao
			// 
			this.labPermissao.BackColor = System.Drawing.Color.Transparent;
			this.labPermissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPermissao.Location = new System.Drawing.Point(12, 162);
			this.labPermissao.Name = "labPermissao";
			this.labPermissao.Size = new System.Drawing.Size(90, 25);
			this.labPermissao.TabIndex = 28;
			this.labPermissao.Text = "Permissão :";
			this.labPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkVendedor
			// 
			this.chkVendedor.BackColor = System.Drawing.Color.Transparent;
			this.chkVendedor.Location = new System.Drawing.Point(279, 162);
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
			this.labSede.Location = new System.Drawing.Point(12, 193);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(90, 25);
			this.labSede.TabIndex = 31;
			this.labSede.Text = "Sede :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSede
			// 
			this.cbxSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSede.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxSede.FormattingEnabled = true;
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
			this.cbxSede.Location = new System.Drawing.Point(108, 193);
			this.cbxSede.Name = "cbxSede";
			this.cbxSede.Size = new System.Drawing.Size(154, 25);
			this.cbxSede.TabIndex = 30;
			// 
			// labPin
			// 
			this.labPin.BackColor = System.Drawing.Color.Transparent;
			this.labPin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPin.Location = new System.Drawing.Point(12, 221);
			this.labPin.Name = "labPin";
			this.labPin.Size = new System.Drawing.Size(90, 25);
			this.labPin.TabIndex = 32;
			this.labPin.Text = "PIN :";
			this.labPin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labPin2
			// 
			this.labPin2.BackColor = System.Drawing.Color.Transparent;
			this.labPin2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPin2.Location = new System.Drawing.Point(108, 221);
			this.labPin2.Name = "labPin2";
			this.labPin2.Size = new System.Drawing.Size(154, 25);
			this.labPin2.TabIndex = 33;
			this.labPin2.Text = "Por padrão o pin é 1234";
			this.labPin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(228, 255);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Size = new System.Drawing.Size(101, 29);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 35;
			this.btnCancelar.Text = "Sair";
			this.btnCancelar.Click += new System.EventHandler(this.cliqueSair);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSalvar.Location = new System.Drawing.Point(335, 255);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(111, 29);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 34;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// CDUsuario
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(458, 296);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.labPin2);
			this.Controls.Add(this.labPin);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.cbxSede);
			this.Controls.Add(this.chkVendedor);
			this.Controls.Add(this.labPermissao);
			this.Controls.Add(this.cbxNivel);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.labNome);
			this.Controls.Add(this.labSenha2);
			this.Controls.Add(this.labSenha);
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
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private System.Windows.Forms.Label labPin2;
		private System.Windows.Forms.Label labPin;
		private System.Windows.Forms.ComboBox cbxSede;
		private System.Windows.Forms.Label labSede;
		private System.Windows.Forms.CheckBox chkVendedor;
		private System.Windows.Forms.Label labPermissao;
		private System.Windows.Forms.ComboBox cbxNivel;
		private System.Windows.Forms.Label labNome;
		private GM.Componentes.MinBox txtNome;
		private System.Windows.Forms.Label labSenha2;
		private System.Windows.Forms.Label labSenha;
		private System.Windows.Forms.Label labUsuario;
		private GM.Componentes.MinBox txtUsuario;
	}
}
