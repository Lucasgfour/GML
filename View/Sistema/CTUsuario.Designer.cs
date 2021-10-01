
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
			this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnRedefinir = new MaterialSkin.Controls.MaterialRaisedButton();
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
			this.btnEditar.Depth = 0;
			this.btnEditar.Location = new System.Drawing.Point(112, 72);
			this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Primary = true;
			this.btnEditar.Size = new System.Drawing.Size(69, 28);
			this.btnEditar.TabIndex = 72;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.cliqueEditar);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Depth = 0;
			this.btnAdicionar.Location = new System.Drawing.Point(12, 72);
			this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Primary = true;
			this.btnAdicionar.Size = new System.Drawing.Size(94, 28);
			this.btnAdicionar.TabIndex = 71;
			this.btnAdicionar.Text = "ADICIONAR";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueNovo);
			// 
			// btnRedefinir
			// 
			this.btnRedefinir.Depth = 0;
			this.btnRedefinir.Location = new System.Drawing.Point(352, 72);
			this.btnRedefinir.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRedefinir.Name = "btnRedefinir";
			this.btnRedefinir.Primary = true;
			this.btnRedefinir.Size = new System.Drawing.Size(151, 28);
			this.btnRedefinir.TabIndex = 73;
			this.btnRedefinir.Text = "REDEFINIR SENHA";
			this.btnRedefinir.UseVisualStyleBackColor = true;
			this.btnRedefinir.Click += new System.EventHandler(this.redefinirSenha);
			// 
			// CTUsuario
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(515, 440);
			this.Controls.Add(this.btnRedefinir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdicionar);
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
		private MaterialSkin.Controls.MaterialRaisedButton btnRedefinir;
		private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
		private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaUsuario;
	}
}
