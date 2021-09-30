
namespace GM.View.Sistema
{
	partial class CTUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTUsuario));
			this.listaUsuario = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.btnEditar = new Sunny.UI.UISymbolButton();
			this.btnNovo = new Sunny.UI.UISymbolButton();
			this.btnSenha = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// listaUsuario
			// 
			this.listaUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04});
			this.listaUsuario.FullRowSelect = true;
			this.listaUsuario.GridLines = true;
			this.listaUsuario.Location = new System.Drawing.Point(12, 107);
			this.listaUsuario.MultiSelect = false;
			this.listaUsuario.Name = "listaUsuario";
			this.listaUsuario.Size = new System.Drawing.Size(491, 321);
			this.listaUsuario.TabIndex = 0;
			this.listaUsuario.UseCompatibleStateImageBehavior = false;
			this.listaUsuario.View = System.Windows.Forms.View.Details;
			// 
			// Col01
			// 
			this.Col01.Text = "Código";
			// 
			// Col02
			// 
			this.Col02.Text = "Usuário";
			this.Col02.Width = 110;
			// 
			// Col03
			// 
			this.Col03.Text = "Permissão";
			this.Col03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col03.Width = 70;
			// 
			// Col04
			// 
			this.Col04.Text = "Nome";
			this.Col04.Width = 220;
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnEditar.Location = new System.Drawing.Point(88, 72);
			this.btnEditar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnEditar.Size = new System.Drawing.Size(68, 29);
			this.btnEditar.SymbolSize = 0;
			this.btnEditar.TabIndex = 24;
			this.btnEditar.Text = "Editar";
			this.btnEditar.Click += new System.EventHandler(this.cliqueEditar);
			// 
			// btnNovo
			// 
			this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNovo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnNovo.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnNovo.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnNovo.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnNovo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnNovo.Location = new System.Drawing.Point(12, 72);
			this.btnNovo.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnNovo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnNovo.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnNovo.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnNovo.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnNovo.Size = new System.Drawing.Size(70, 29);
			this.btnNovo.Style = Sunny.UI.UIStyle.Green;
			this.btnNovo.SymbolSize = 0;
			this.btnNovo.TabIndex = 23;
			this.btnNovo.Text = "Novo";
			this.btnNovo.Click += new System.EventHandler(this.cliqueNovo);
			// 
			// btnSenha
			// 
			this.btnSenha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSenha.Location = new System.Drawing.Point(350, 72);
			this.btnSenha.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSenha.Name = "btnSenha";
			this.btnSenha.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSenha.Size = new System.Drawing.Size(153, 29);
			this.btnSenha.SymbolSize = 0;
			this.btnSenha.TabIndex = 25;
			this.btnSenha.Text = "Redefinir a senha";
			this.btnSenha.Click += new System.EventHandler(this.redefinirSenha);
			// 
			// CTUsuario
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(515, 440);
			this.Controls.Add(this.btnSenha);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.listaUsuario);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CTUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administrar usuários do sistema";
			this.Load += new System.EventHandler(this.Arranque);
			this.ResumeLayout(false);
		}
		private Sunny.UI.UISymbolButton btnSenha;
		private Sunny.UI.UISymbolButton btnNovo;
		private Sunny.UI.UISymbolButton btnEditar;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaUsuario;
	}
}
