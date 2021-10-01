
namespace GM.View.Sistema
{
	partial class CTModulo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTModulo));
			this.listaTela = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.btnRemover = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// listaTela
			// 
			this.listaTela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02});
			this.listaTela.FullRowSelect = true;
			this.listaTela.GridLines = true;
			this.listaTela.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listaTela.Location = new System.Drawing.Point(12, 104);
			this.listaTela.MultiSelect = false;
			this.listaTela.Name = "listaTela";
			this.listaTela.Size = new System.Drawing.Size(273, 374);
			this.listaTela.TabIndex = 0;
			this.listaTela.UseCompatibleStateImageBehavior = false;
			this.listaTela.View = System.Windows.Forms.View.Details;
			// 
			// Col01
			// 
			this.Col01.Text = "Código da Tela";
			this.Col01.Width = 160;
			// 
			// Col02
			// 
			this.Col02.Text = "Permissão";
			this.Col02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col02.Width = 80;
			// 
			// btnRemover
			// 
			this.btnRemover.Depth = 0;
			this.btnRemover.Location = new System.Drawing.Point(187, 70);
			this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Primary = true;
			this.btnRemover.Size = new System.Drawing.Size(98, 28);
			this.btnRemover.TabIndex = 71;
			this.btnRemover.Text = "REMOVER";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Visible = false;
			this.btnRemover.Click += new System.EventHandler(this.cliqueRemover);
			// 
			// btnEditar
			// 
			this.btnEditar.Depth = 0;
			this.btnEditar.Location = new System.Drawing.Point(112, 70);
			this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Primary = true;
			this.btnEditar.Size = new System.Drawing.Size(69, 28);
			this.btnEditar.TabIndex = 70;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.cliqueEditar);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Depth = 0;
			this.btnAdicionar.Location = new System.Drawing.Point(12, 70);
			this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Primary = true;
			this.btnAdicionar.Size = new System.Drawing.Size(94, 28);
			this.btnAdicionar.TabIndex = 69;
			this.btnAdicionar.Text = "ADICIONAR";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueNovo);
			// 
			// CTModulo
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(297, 490);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.listaTela);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CTModulo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administrador - Controle de Módulos";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
		private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
		private MaterialSkin.Controls.MaterialRaisedButton btnRemover;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaTela;
	}
}
