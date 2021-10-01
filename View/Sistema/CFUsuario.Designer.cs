
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
			this.txtNome = new GM.Componentes.MinBox();
			this.labNome = new System.Windows.Forms.Label();
			this.txtSenha = new GM.Componentes.MinBox();
			this.labNovaSenha = new System.Windows.Forms.Label();
			this.txtPin = new GM.Componentes.MinBox();
			this.labNovoPin = new System.Windows.Forms.Label();
			this.txtSenhaAtual = new GM.Componentes.MinBox();
			this.labSenha = new System.Windows.Forms.Label();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
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
			this.txtNome.Location = new System.Drawing.Point(108, 71);
			this.txtNome.MaxLength = 40;
			this.txtNome.Multiline = false;
			this.txtNome.Name = "txtNome";
			this.txtNome.ReadOnly = false;
			this.txtNome.SelectionStart = 0;
			this.txtNome.Size = new System.Drawing.Size(306, 28);
			this.txtNome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNome.TabIndex = 27;
			this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.UseSystemPasswordChar = false;
			// 
			// labNome
			// 
			this.labNome.BackColor = System.Drawing.Color.Transparent;
			this.labNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNome.Location = new System.Drawing.Point(12, 71);
			this.labNome.Name = "labNome";
			this.labNome.Size = new System.Drawing.Size(90, 25);
			this.labNome.TabIndex = 28;
			this.labNome.Text = "Nome :";
			this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.Color.White;
			this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtSenha.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSenha.CustomBGColor = System.Drawing.Color.White;
			this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSenha.ForeColor = System.Drawing.Color.Black;
			this.txtSenha.Location = new System.Drawing.Point(108, 105);
			this.txtSenha.MaxLength = 15;
			this.txtSenha.Multiline = false;
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.ReadOnly = false;
			this.txtSenha.SelectionStart = 0;
			this.txtSenha.Size = new System.Drawing.Size(131, 28);
			this.txtSenha.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtSenha.TabIndex = 30;
			this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSenha.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSenha.UseSystemPasswordChar = false;
			// 
			// labNovaSenha
			// 
			this.labNovaSenha.BackColor = System.Drawing.Color.Transparent;
			this.labNovaSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNovaSenha.Location = new System.Drawing.Point(12, 105);
			this.labNovaSenha.Name = "labNovaSenha";
			this.labNovaSenha.Size = new System.Drawing.Size(90, 25);
			this.labNovaSenha.TabIndex = 31;
			this.labNovaSenha.Text = "Nova Senha :";
			this.labNovaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPin
			// 
			this.txtPin.BackColor = System.Drawing.Color.White;
			this.txtPin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtPin.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPin.CustomBGColor = System.Drawing.Color.White;
			this.txtPin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtPin.ForeColor = System.Drawing.Color.Black;
			this.txtPin.Location = new System.Drawing.Point(108, 139);
			this.txtPin.MaxLength = 4;
			this.txtPin.Multiline = false;
			this.txtPin.Name = "txtPin";
			this.txtPin.ReadOnly = false;
			this.txtPin.SelectionStart = 0;
			this.txtPin.Size = new System.Drawing.Size(94, 28);
			this.txtPin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtPin.TabIndex = 32;
			this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPin.UseSystemPasswordChar = false;
			// 
			// labNovoPin
			// 
			this.labNovoPin.BackColor = System.Drawing.Color.Transparent;
			this.labNovoPin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNovoPin.Location = new System.Drawing.Point(12, 139);
			this.labNovoPin.Name = "labNovoPin";
			this.labNovoPin.Size = new System.Drawing.Size(90, 25);
			this.labNovoPin.TabIndex = 33;
			this.labNovoPin.Text = "Novo Pin :";
			this.labNovoPin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSenhaAtual
			// 
			this.txtSenhaAtual.BackColor = System.Drawing.Color.White;
			this.txtSenhaAtual.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtSenhaAtual.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSenhaAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSenhaAtual.CustomBGColor = System.Drawing.Color.White;
			this.txtSenhaAtual.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSenhaAtual.ForeColor = System.Drawing.Color.Black;
			this.txtSenhaAtual.Location = new System.Drawing.Point(108, 185);
			this.txtSenhaAtual.MaxLength = 15;
			this.txtSenhaAtual.Multiline = false;
			this.txtSenhaAtual.Name = "txtSenhaAtual";
			this.txtSenhaAtual.ReadOnly = false;
			this.txtSenhaAtual.SelectionStart = 0;
			this.txtSenhaAtual.Size = new System.Drawing.Size(131, 28);
			this.txtSenhaAtual.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtSenhaAtual.TabIndex = 34;
			this.txtSenhaAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSenhaAtual.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSenhaAtual.UseSystemPasswordChar = true;
			// 
			// labSenha
			// 
			this.labSenha.BackColor = System.Drawing.Color.Transparent;
			this.labSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSenha.Location = new System.Drawing.Point(12, 185);
			this.labSenha.Name = "labSenha";
			this.labSenha.Size = new System.Drawing.Size(90, 28);
			this.labSenha.TabIndex = 35;
			this.labSenha.Text = "Senha Atual :";
			this.labSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(321, 182);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(93, 31);
			this.btnSalvar.TabIndex = 213;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// CFUsuario
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(426, 225);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtSenhaAtual);
			this.Controls.Add(this.labSenha);
			this.Controls.Add(this.txtPin);
			this.Controls.Add(this.labNovoPin);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.labNovaSenha);
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
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private System.Windows.Forms.Label labSenha;
		private GM.Componentes.MinBox txtSenhaAtual;
		private System.Windows.Forms.Label labNovoPin;
		private GM.Componentes.MinBox txtPin;
		private System.Windows.Forms.Label labNovaSenha;
		private GM.Componentes.MinBox txtSenha;
		private System.Windows.Forms.Label labNome;
		private GM.Componentes.MinBox txtNome;
	}
}
