using MaterialSkin.Controls;

namespace GM.View
{
	partial class IDUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDUsuario));
			this.txtUsuario = new ReaLTaiizor.Controls.DungeonTextBox();
			this.txtSenha = new ReaLTaiizor.Controls.DungeonTextBox();
			this.labSenha = new MaterialSkin.Controls.MaterialLabel();
			this.labUsuario = new MaterialSkin.Controls.MaterialLabel();
			this.btnEntrar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
			this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtUsuario.EdgeColor = System.Drawing.Color.White;
			this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
			this.txtUsuario.Location = new System.Drawing.Point(113, 87);
			this.txtUsuario.MaxLength = 32767;
			this.txtUsuario.Multiline = false;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.ReadOnly = false;
			this.txtUsuario.Size = new System.Drawing.Size(193, 28);
			this.txtUsuario.TabIndex = 0;
			this.txtUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUsuario.UseSystemPasswordChar = false;
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.Color.Transparent;
			this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtSenha.EdgeColor = System.Drawing.Color.White;
			this.txtSenha.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtSenha.ForeColor = System.Drawing.Color.DimGray;
			this.txtSenha.Location = new System.Drawing.Point(113, 121);
			this.txtSenha.MaxLength = 32767;
			this.txtSenha.Multiline = false;
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.ReadOnly = false;
			this.txtSenha.Size = new System.Drawing.Size(193, 28);
			this.txtSenha.TabIndex = 1;
			this.txtSenha.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSenha.UseSystemPasswordChar = true;
			// 
			// labSenha
			// 
			this.labSenha.BackColor = System.Drawing.Color.Transparent;
			this.labSenha.Depth = 0;
			this.labSenha.Font = new System.Drawing.Font("Roboto", 11F);
			this.labSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labSenha.Location = new System.Drawing.Point(27, 121);
			this.labSenha.MouseState = MaterialSkin.MouseState.HOVER;
			this.labSenha.Name = "labSenha";
			this.labSenha.Size = new System.Drawing.Size(80, 28);
			this.labSenha.TabIndex = 4;
			this.labSenha.Text = "Senha :";
			this.labSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labUsuario
			// 
			this.labUsuario.BackColor = System.Drawing.Color.Transparent;
			this.labUsuario.Depth = 0;
			this.labUsuario.Font = new System.Drawing.Font("Roboto", 11F);
			this.labUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labUsuario.Location = new System.Drawing.Point(27, 87);
			this.labUsuario.MouseState = MaterialSkin.MouseState.HOVER;
			this.labUsuario.Name = "labUsuario";
			this.labUsuario.Size = new System.Drawing.Size(80, 28);
			this.labUsuario.TabIndex = 5;
			this.labUsuario.Text = "Usuário :";
			this.labUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnEntrar
			// 
			this.btnEntrar.Depth = 0;
			this.btnEntrar.Location = new System.Drawing.Point(200, 164);
			this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Primary = true;
			this.btnEntrar.Size = new System.Drawing.Size(106, 32);
			this.btnEntrar.TabIndex = 7;
			this.btnEntrar.Text = "ENTRAR";
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Clique);
			// 
			// IDUsuario
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(344, 222);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.labUsuario);
			this.Controls.Add(this.labSenha);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtUsuario);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "IDUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GM - Entrar";
			this.Load += new System.EventHandler(this.Arranque);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IDUsuarioKeyDown);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnEntrar;
		private MaterialSkin.Controls.MaterialLabel labUsuario;
		private MaterialSkin.Controls.MaterialLabel labSenha;
		private ReaLTaiizor.Controls.DungeonTextBox txtSenha;
		private ReaLTaiizor.Controls.DungeonTextBox txtUsuario;
	}
}
