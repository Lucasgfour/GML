
namespace GM.View.Sistema
{
	partial class CFUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFUsuario));
			this.txtNome = new System.Windows.Forms.TextBox();
			this.labNome = new System.Windows.Forms.Label();
			this.labTitulo = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.labNovaSenha = new System.Windows.Forms.Label();
			this.txtPin = new System.Windows.Forms.TextBox();
			this.labNovoPin = new System.Windows.Forms.Label();
			this.txtSenhaAtual = new System.Windows.Forms.TextBox();
			this.labSenha = new System.Windows.Forms.Label();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.White;
			this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtNome.Location = new System.Drawing.Point(108, 112);
			this.txtNome.MaxLength = 40;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(306, 25);
			this.txtNome.TabIndex = 27;
			// 
			// labNome
			// 
			this.labNome.BackColor = System.Drawing.Color.Transparent;
			this.labNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNome.Location = new System.Drawing.Point(12, 112);
			this.labNome.Name = "labNome";
			this.labNome.Size = new System.Drawing.Size(90, 25);
			this.labNome.TabIndex = 28;
			this.labNome.Text = "Nome :";
			this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labTitulo
			// 
			this.labTitulo.BackColor = System.Drawing.Color.Transparent;
			this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.labTitulo.Location = new System.Drawing.Point(12, 72);
			this.labTitulo.Name = "labTitulo";
			this.labTitulo.Size = new System.Drawing.Size(402, 29);
			this.labTitulo.TabIndex = 29;
			this.labTitulo.Text = "Configurações de Usuário";
			this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.Color.White;
			this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSenha.Location = new System.Drawing.Point(108, 143);
			this.txtSenha.MaxLength = 15;
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(131, 25);
			this.txtSenha.TabIndex = 30;
			// 
			// labNovaSenha
			// 
			this.labNovaSenha.BackColor = System.Drawing.Color.Transparent;
			this.labNovaSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNovaSenha.Location = new System.Drawing.Point(12, 143);
			this.labNovaSenha.Name = "labNovaSenha";
			this.labNovaSenha.Size = new System.Drawing.Size(90, 25);
			this.labNovaSenha.TabIndex = 31;
			this.labNovaSenha.Text = "Nova Senha :";
			this.labNovaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPin
			// 
			this.txtPin.BackColor = System.Drawing.Color.White;
			this.txtPin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtPin.Location = new System.Drawing.Point(108, 174);
			this.txtPin.MaxLength = 4;
			this.txtPin.Name = "txtPin";
			this.txtPin.Size = new System.Drawing.Size(94, 25);
			this.txtPin.TabIndex = 32;
			this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labNovoPin
			// 
			this.labNovoPin.BackColor = System.Drawing.Color.Transparent;
			this.labNovoPin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNovoPin.Location = new System.Drawing.Point(12, 174);
			this.labNovoPin.Name = "labNovoPin";
			this.labNovoPin.Size = new System.Drawing.Size(90, 25);
			this.labNovoPin.TabIndex = 33;
			this.labNovoPin.Text = "Novo Pin :";
			this.labNovoPin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSenhaAtual
			// 
			this.txtSenhaAtual.BackColor = System.Drawing.Color.White;
			this.txtSenhaAtual.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSenhaAtual.Location = new System.Drawing.Point(108, 228);
			this.txtSenhaAtual.MaxLength = 15;
			this.txtSenhaAtual.Name = "txtSenhaAtual";
			this.txtSenhaAtual.Size = new System.Drawing.Size(131, 25);
			this.txtSenhaAtual.TabIndex = 34;
			this.txtSenhaAtual.UseSystemPasswordChar = true;
			// 
			// labSenha
			// 
			this.labSenha.BackColor = System.Drawing.Color.Transparent;
			this.labSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSenha.Location = new System.Drawing.Point(12, 228);
			this.labSenha.Name = "labSenha";
			this.labSenha.Size = new System.Drawing.Size(90, 25);
			this.labSenha.TabIndex = 35;
			this.labSenha.Text = "Senha Atual :";
			this.labSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSalvar.Location = new System.Drawing.Point(283, 224);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(131, 29);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 36;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// CFUsuario
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(426, 266);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtSenhaAtual);
			this.Controls.Add(this.labSenha);
			this.Controls.Add(this.txtPin);
			this.Controls.Add(this.labNovoPin);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.labNovaSenha);
			this.Controls.Add(this.labTitulo);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.labNome);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CFUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configurações Usuário";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton btnSalvar;
		private System.Windows.Forms.Label labSenha;
		private System.Windows.Forms.TextBox txtSenhaAtual;
		private System.Windows.Forms.Label labNovoPin;
		private System.Windows.Forms.TextBox txtPin;
		private System.Windows.Forms.Label labNovaSenha;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label labTitulo;
		private System.Windows.Forms.Label labNome;
		private System.Windows.Forms.TextBox txtNome;
	}
}
