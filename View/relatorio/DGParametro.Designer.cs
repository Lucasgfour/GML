
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
			this.txtParametro = new GM.Componentes.MinBox();
			this.labParametro = new System.Windows.Forms.Label();
			this.labTitulo = new System.Windows.Forms.Label();
			this.btnOK = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// txtParametro
			// 
			this.txtParametro.BackColor = System.Drawing.Color.White;
			this.txtParametro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtParametro.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtParametro.CustomBGColor = System.Drawing.Color.White;
			this.txtParametro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtParametro.ForeColor = System.Drawing.Color.Black;
			this.txtParametro.Location = new System.Drawing.Point(122, 115);
			this.txtParametro.MaxLength = 32767;
			this.txtParametro.Multiline = false;
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.ReadOnly = false;
			this.txtParametro.SelectionStart = 0;
			this.txtParametro.Size = new System.Drawing.Size(239, 28);
			this.txtParametro.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtParametro.TabIndex = 16;
			this.txtParametro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtParametro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtParametro.UseSystemPasswordChar = false;
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
			this.btnOK.Depth = 0;
			this.btnOK.Location = new System.Drawing.Point(256, 156);
			this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnOK.Name = "btnOK";
			this.btnOK.Primary = true;
			this.btnOK.Size = new System.Drawing.Size(105, 28);
			this.btnOK.TabIndex = 213;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
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
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnOK;
		private System.Windows.Forms.Label labTitulo;
		private System.Windows.Forms.Label labParametro;
		private GM.Componentes.MinBox txtParametro;
	}
}
