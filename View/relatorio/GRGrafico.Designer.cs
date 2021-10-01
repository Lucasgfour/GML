
namespace GM.View.relatorio
{
	partial class GRGrafico
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRGrafico));
			this.cbxTipo = new GM.Componentes.MinComboBox();
			this.labTipo = new System.Windows.Forms.Label();
			this.btnGerar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// cbxTipo
			// 
			this.cbxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxTipo.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxTipo.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxTipo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxTipo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxTipo.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxTipo.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxTipo.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxTipo.ColorH = System.Drawing.Color.White;
			this.cbxTipo.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxTipo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxTipo.DropDownHeight = 100;
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxTipo.ForeColor = System.Drawing.Color.Black;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxTipo.IntegralHeight = false;
			this.cbxTipo.ItemHeight = 20;
			this.cbxTipo.Items.AddRange(new object[] {
									"Gráfico em Linha",
									"Gráfico em Barra",
									"Gráfico em Pizza",
									"Gráfico em Radar"});
			this.cbxTipo.Location = new System.Drawing.Point(139, 69);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(234, 26);
			this.cbxTipo.StartIndex = 0;
			this.cbxTipo.TabIndex = 206;
			// 
			// labTipo
			// 
			this.labTipo.BackColor = System.Drawing.Color.Transparent;
			this.labTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTipo.Location = new System.Drawing.Point(3, 69);
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(130, 25);
			this.labTipo.TabIndex = 207;
			this.labTipo.Text = "Tipo de Gráfico :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnGerar
			// 
			this.btnGerar.Depth = 0;
			this.btnGerar.Location = new System.Drawing.Point(241, 101);
			this.btnGerar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnGerar.Name = "btnGerar";
			this.btnGerar.Primary = true;
			this.btnGerar.Size = new System.Drawing.Size(132, 28);
			this.btnGerar.TabIndex = 214;
			this.btnGerar.Text = "GERAR";
			this.btnGerar.UseVisualStyleBackColor = true;
			this.btnGerar.Click += new System.EventHandler(this.gerar);
			// 
			// GRGrafico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 139);
			this.Controls.Add(this.btnGerar);
			this.Controls.Add(this.cbxTipo);
			this.Controls.Add(this.labTipo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "GRGrafico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerar relatório em gráfico";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnGerar;
		private System.Windows.Forms.Label labTipo;
		private GM.Componentes.MinComboBox cbxTipo;
	}
}
