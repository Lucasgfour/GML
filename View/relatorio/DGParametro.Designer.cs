
namespace GM.View.relatorio
{
	partial class DGParametro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DGParametro));
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.labParametro = new System.Windows.Forms.Label();
			this.labTitulo = new System.Windows.Forms.Label();
			this.btnOK = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// txtParametro
			// 
			this.txtParametro.BackColor = System.Drawing.Color.White;
			this.txtParametro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtParametro.Location = new System.Drawing.Point(122, 115);
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.Size = new System.Drawing.Size(239, 25);
			this.txtParametro.TabIndex = 16;
			this.txtParametro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtParametro.TextChanged += new System.EventHandler(this.maskParametro);
			// 
			// labParametro
			// 
			this.labParametro.BackColor = System.Drawing.Color.Transparent;
			this.labParametro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labParametro.Location = new System.Drawing.Point(12, 115);
			this.labParametro.Name = "labParametro";
			this.labParametro.Size = new System.Drawing.Size(104, 25);
			this.labParametro.TabIndex = 17;
			this.labParametro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labTitulo
			// 
			this.labTitulo.BackColor = System.Drawing.Color.Transparent;
			this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTitulo.Location = new System.Drawing.Point(12, 73);
			this.labTitulo.Name = "labTitulo";
			this.labTitulo.Size = new System.Drawing.Size(349, 25);
			this.labTitulo.TabIndex = 18;
			this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnOK
			// 
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnOK.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnOK.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnOK.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnOK.Location = new System.Drawing.Point(250, 152);
			this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnOK.Name = "btnOK";
			this.btnOK.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnOK.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnOK.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnOK.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnOK.Size = new System.Drawing.Size(111, 29);
			this.btnOK.Style = Sunny.UI.UIStyle.Green;
			this.btnOK.TabIndex = 19;
			this.btnOK.Click += new System.EventHandler(this.cliqueOK);
			// 
			// DGParametro
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(373, 196);
			this.ControlBox = false;
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.labTitulo);
			this.Controls.Add(this.txtParametro);
			this.Controls.Add(this.labParametro);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "DGParametro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Entrada de parâmetro";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionar);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton btnOK;
		private System.Windows.Forms.Label labTitulo;
		private System.Windows.Forms.Label labParametro;
		private System.Windows.Forms.TextBox txtParametro;
	}
}
