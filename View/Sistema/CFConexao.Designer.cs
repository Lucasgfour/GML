
namespace GM.View.Sistema
{
	partial class CFConexao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFConexao));
			this.labIP = new MaterialSkin.Controls.MaterialLabel();
			this.labUsuario = new MaterialSkin.Controls.MaterialLabel();
			this.labSenha = new MaterialSkin.Controls.MaterialLabel();
			this.labBanco = new MaterialSkin.Controls.MaterialLabel();
			this.txtIP = new GM.Componentes.MinBox();
			this.txtUsuario = new GM.Componentes.MinBox();
			this.txtSenha = new GM.Componentes.MinBox();
			this.txtBanco = new GM.Componentes.MinBox();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// labIP
			// 
			this.labIP.BackColor = System.Drawing.Color.Transparent;
			this.labIP.Depth = 0;
			this.labIP.Font = new System.Drawing.Font("Roboto", 11F);
			this.labIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labIP.Location = new System.Drawing.Point(8, 73);
			this.labIP.MouseState = MaterialSkin.MouseState.HOVER;
			this.labIP.Name = "labIP";
			this.labIP.Size = new System.Drawing.Size(78, 28);
			this.labIP.TabIndex = 0;
			this.labIP.Text = "IP :";
			this.labIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labUsuario
			// 
			this.labUsuario.BackColor = System.Drawing.Color.Transparent;
			this.labUsuario.Depth = 0;
			this.labUsuario.Font = new System.Drawing.Font("Roboto", 11F);
			this.labUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labUsuario.Location = new System.Drawing.Point(8, 107);
			this.labUsuario.MouseState = MaterialSkin.MouseState.HOVER;
			this.labUsuario.Name = "labUsuario";
			this.labUsuario.Size = new System.Drawing.Size(78, 28);
			this.labUsuario.TabIndex = 1;
			this.labUsuario.Text = "Usuário :";
			this.labUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labSenha
			// 
			this.labSenha.BackColor = System.Drawing.Color.Transparent;
			this.labSenha.Depth = 0;
			this.labSenha.Font = new System.Drawing.Font("Roboto", 11F);
			this.labSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labSenha.Location = new System.Drawing.Point(8, 141);
			this.labSenha.MouseState = MaterialSkin.MouseState.HOVER;
			this.labSenha.Name = "labSenha";
			this.labSenha.Size = new System.Drawing.Size(78, 28);
			this.labSenha.TabIndex = 2;
			this.labSenha.Text = "Senha :";
			this.labSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labBanco
			// 
			this.labBanco.BackColor = System.Drawing.Color.Transparent;
			this.labBanco.Depth = 0;
			this.labBanco.Font = new System.Drawing.Font("Roboto", 11F);
			this.labBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labBanco.Location = new System.Drawing.Point(8, 175);
			this.labBanco.MouseState = MaterialSkin.MouseState.HOVER;
			this.labBanco.Name = "labBanco";
			this.labBanco.Size = new System.Drawing.Size(78, 28);
			this.labBanco.TabIndex = 3;
			this.labBanco.Text = "Banco :";
			this.labBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIP
			// 
			this.txtIP.BackColor = System.Drawing.Color.Transparent;
			this.txtIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtIP.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtIP.CustomBGColor = System.Drawing.Color.White;
			this.txtIP.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtIP.ForeColor = System.Drawing.Color.DimGray;
			this.txtIP.Location = new System.Drawing.Point(92, 73);
			this.txtIP.MaxLength = 32767;
			this.txtIP.Multiline = false;
			this.txtIP.Name = "txtIP";
			this.txtIP.ReadOnly = false;
			this.txtIP.SelectionStart = 0;
			this.txtIP.Size = new System.Drawing.Size(154, 28);
			this.txtIP.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtIP.TabIndex = 1;
			this.txtIP.Text = "localhost";
			this.txtIP.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtIP.UseSystemPasswordChar = false;
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
			this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtUsuario.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtUsuario.CustomBGColor = System.Drawing.Color.White;
			this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
			this.txtUsuario.Location = new System.Drawing.Point(92, 107);
			this.txtUsuario.MaxLength = 32767;
			this.txtUsuario.Multiline = false;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.ReadOnly = false;
			this.txtUsuario.SelectionStart = 0;
			this.txtUsuario.Size = new System.Drawing.Size(154, 28);
			this.txtUsuario.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.Text = "root";
			this.txtUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUsuario.UseSystemPasswordChar = false;
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.Color.Transparent;
			this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtSenha.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSenha.CustomBGColor = System.Drawing.Color.White;
			this.txtSenha.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtSenha.ForeColor = System.Drawing.Color.DimGray;
			this.txtSenha.Location = new System.Drawing.Point(92, 141);
			this.txtSenha.MaxLength = 32767;
			this.txtSenha.Multiline = false;
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.ReadOnly = false;
			this.txtSenha.SelectionStart = 0;
			this.txtSenha.Size = new System.Drawing.Size(154, 28);
			this.txtSenha.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtSenha.TabIndex = 3;
			this.txtSenha.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSenha.UseSystemPasswordChar = false;
			// 
			// txtBanco
			// 
			this.txtBanco.BackColor = System.Drawing.Color.Transparent;
			this.txtBanco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtBanco.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtBanco.CustomBGColor = System.Drawing.Color.White;
			this.txtBanco.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtBanco.ForeColor = System.Drawing.Color.DimGray;
			this.txtBanco.Location = new System.Drawing.Point(92, 175);
			this.txtBanco.MaxLength = 32767;
			this.txtBanco.Multiline = false;
			this.txtBanco.Name = "txtBanco";
			this.txtBanco.ReadOnly = false;
			this.txtBanco.SelectionStart = 0;
			this.txtBanco.Size = new System.Drawing.Size(154, 28);
			this.txtBanco.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtBanco.TabIndex = 4;
			this.txtBanco.Text = "gm";
			this.txtBanco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtBanco.UseSystemPasswordChar = false;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(146, 208);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(100, 32);
			this.btnSalvar.TabIndex = 5;
			this.btnSalvar.Text = "salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// CFConexao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 252);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtBanco);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.labBanco);
			this.Controls.Add(this.labSenha);
			this.Controls.Add(this.labUsuario);
			this.Controls.Add(this.labIP);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CFConexao";
			this.Sizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configurar Conexão";
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private GM.Componentes.MinBox txtBanco;
		private GM.Componentes.MinBox txtSenha;
		private GM.Componentes.MinBox txtUsuario;
		private GM.Componentes.MinBox txtIP;
		private MaterialSkin.Controls.MaterialLabel labBanco;
		private MaterialSkin.Controls.MaterialLabel labSenha;
		private MaterialSkin.Controls.MaterialLabel labUsuario;
		private MaterialSkin.Controls.MaterialLabel labIP;
	}
}
