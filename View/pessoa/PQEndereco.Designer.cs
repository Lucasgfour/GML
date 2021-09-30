
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
			this.btnDeletar = new Sunny.UI.UISymbolButton();
			this.btnEditar = new Sunny.UI.UISymbolButton();
			this.btnNovo = new Sunny.UI.UISymbolButton();
			this.btnSelecionar = new Sunny.UI.UISymbolButton();
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
			// btnDeletar
			// 
			this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeletar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnDeletar.Location = new System.Drawing.Point(88, 72);
			this.btnDeletar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnDeletar.Size = new System.Drawing.Size(37, 29);
			this.btnDeletar.Symbol = 61944;
			this.btnDeletar.TabIndex = 7;
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnEditar.Location = new System.Drawing.Point(50, 72);
			this.btnEditar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnEditar.Size = new System.Drawing.Size(37, 29);
			this.btnEditar.Symbol = 61508;
			this.btnEditar.TabIndex = 6;
			this.btnEditar.Click += new System.EventHandler(this.editarClique);
			// 
			// btnNovo
			// 
			this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnNovo.Location = new System.Drawing.Point(12, 72);
			this.btnNovo.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnNovo.Size = new System.Drawing.Size(37, 29);
			this.btnNovo.Symbol = 61543;
			this.btnNovo.TabIndex = 5;
			this.btnNovo.Click += new System.EventHandler(this.novoClique);
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSelecionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSelecionar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSelecionar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSelecionar.Location = new System.Drawing.Point(373, 72);
			this.btnSelecionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSelecionar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSelecionar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSelecionar.Size = new System.Drawing.Size(202, 29);
			this.btnSelecionar.Style = Sunny.UI.UIStyle.Green;
			this.btnSelecionar.TabIndex = 36;
			this.btnSelecionar.Text = "Selecionar";
			this.btnSelecionar.Click += new System.EventHandler(this.selecionarClique);
			// 
			// PQEndereco
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 325);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.listEndereco);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PQEndereco";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Endereço(s)";
			this.Load += new System.EventHandler(this.arranque);
			this.ResumeLayout(false);
		}
		private Sunny.UI.UISymbolButton btnSelecionar;
		private Sunny.UI.UISymbolButton btnNovo;
		private Sunny.UI.UISymbolButton btnEditar;
		private Sunny.UI.UISymbolButton btnDeletar;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listEndereco;
	}
}
