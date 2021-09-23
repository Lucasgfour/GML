
namespace GM.View.venda
{
	partial class selectSede
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
			this.labSede = new MaterialSkin.Controls.MaterialLabel();
			this.cbxSede = new GM.Componentes.MinComboBox();
			this.btnAbrir = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Depth = 0;
			this.labSede.Font = new System.Drawing.Font("Roboto", 11F);
			this.labSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labSede.Location = new System.Drawing.Point(12, 73);
			this.labSede.MouseState = MaterialSkin.MouseState.HOVER;
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(80, 28);
			this.labSede.TabIndex = 6;
			this.labSede.Text = "Loja :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSede
			// 
			this.cbxSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxSede.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSede.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSede.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxSede.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxSede.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxSede.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSede.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSede.ColorH = System.Drawing.Color.White;
			this.cbxSede.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxSede.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxSede.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxSede.DropDownHeight = 100;
			this.cbxSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSede.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbxSede.ForeColor = System.Drawing.Color.Black;
			this.cbxSede.FormattingEnabled = true;
			this.cbxSede.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxSede.IntegralHeight = false;
			this.cbxSede.ItemHeight = 20;
			this.cbxSede.Location = new System.Drawing.Point(98, 76);
			this.cbxSede.Name = "cbxSede";
			this.cbxSede.Size = new System.Drawing.Size(217, 26);
			this.cbxSede.StartIndex = 0;
			this.cbxSede.TabIndex = 7;
			// 
			// btnAbrir
			// 
			this.btnAbrir.Depth = 0;
			this.btnAbrir.Location = new System.Drawing.Point(209, 115);
			this.btnAbrir.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Primary = true;
			this.btnAbrir.Size = new System.Drawing.Size(106, 32);
			this.btnAbrir.TabIndex = 8;
			this.btnAbrir.Text = "ABRIR";
			this.btnAbrir.UseVisualStyleBackColor = true;
			this.btnAbrir.Click += new System.EventHandler(this.cliqueSelecionar);
			// 
			// selectSede
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 159);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.cbxSede);
			this.Controls.Add(this.labSede);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "selectSede";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Selecionar Loja";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnAbrir;
		private GM.Componentes.MinComboBox cbxSede;
		private MaterialSkin.Controls.MaterialLabel labSede;
	}
}
