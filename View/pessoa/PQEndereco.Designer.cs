
namespace GM.View.pessoa
{
	partial class PQEndereco
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQEndereco));
			this.listEndereco = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.btnSelecionar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnRemover = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// listEndereco
			// 
			this.listEndereco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03});
			this.listEndereco.FullRowSelect = true;
			this.listEndereco.GridLines = true;
			this.listEndereco.Location = new System.Drawing.Point(12, 105);
			this.listEndereco.MultiSelect = false;
			this.listEndereco.Name = "listEndereco";
			this.listEndereco.Size = new System.Drawing.Size(563, 208);
			this.listEndereco.TabIndex = 0;
			this.listEndereco.UseCompatibleStateImageBehavior = false;
			this.listEndereco.View = System.Windows.Forms.View.Details;
			this.listEndereco.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploClique);
			// 
			// Col01
			// 
			this.Col01.Text = "Código";
			this.Col01.Width = 70;
			// 
			// Col02
			// 
			this.Col02.Text = "Endereço";
			this.Col02.Width = 255;
			// 
			// Col03
			// 
			this.Col03.Text = "Cidade";
			this.Col03.Width = 200;
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Depth = 0;
			this.btnSelecionar.Location = new System.Drawing.Point(406, 70);
			this.btnSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.Primary = true;
			this.btnSelecionar.Size = new System.Drawing.Size(169, 29);
			this.btnSelecionar.TabIndex = 59;
			this.btnSelecionar.Text = "SELECIONAR";
			this.btnSelecionar.UseVisualStyleBackColor = true;
			this.btnSelecionar.Click += new System.EventHandler(this.selecionarClique);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Depth = 0;
			this.btnAdicionar.Location = new System.Drawing.Point(12, 70);
			this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Primary = true;
			this.btnAdicionar.Size = new System.Drawing.Size(94, 29);
			this.btnAdicionar.TabIndex = 60;
			this.btnAdicionar.Text = "ADICIONAR";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.novoClique);
			// 
			// btnEditar
			// 
			this.btnEditar.Depth = 0;
			this.btnEditar.Location = new System.Drawing.Point(112, 70);
			this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Primary = true;
			this.btnEditar.Size = new System.Drawing.Size(94, 29);
			this.btnEditar.TabIndex = 61;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.editarClique);
			// 
			// btnRemover
			// 
			this.btnRemover.Depth = 0;
			this.btnRemover.Location = new System.Drawing.Point(212, 70);
			this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Primary = true;
			this.btnRemover.Size = new System.Drawing.Size(94, 29);
			this.btnRemover.TabIndex = 62;
			this.btnRemover.Text = "REMOVER";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Visible = false;
			// 
			// PQEndereco
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 325);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.listEndereco);
			this.Controls.Add(this.btnSelecionar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PQEndereco";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Endereço(s)";
			this.Load += new System.EventHandler(this.arranque);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnRemover;
		private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
		private MaterialSkin.Controls.MaterialRaisedButton btnSelecionar;
		private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listEndereco;
	}
}
