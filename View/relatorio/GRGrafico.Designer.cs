
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
			this.cbxTipo = new System.Windows.Forms.ComboBox();
			this.labTipo = new System.Windows.Forms.Label();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// cbxTipo
			// 
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.Items.AddRange(new object[] {
									"Gráfico em Linha",
									"Gráfico em Barra",
									"Gráfico em Pizza",
									"Gráfico em Radar"});
			this.cbxTipo.Location = new System.Drawing.Point(139, 69);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(234, 25);
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
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSalvar.Location = new System.Drawing.Point(216, 100);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(157, 29);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.Symbol = 61568;
			this.btnSalvar.TabIndex = 208;
			this.btnSalvar.Text = "Gerar Gráfico";
			this.btnSalvar.Click += new System.EventHandler(this.gerar);
			// 
			// GRGrafico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 139);
			this.Controls.Add(this.btnSalvar);
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
		private Sunny.UI.UISymbolButton btnSalvar;
		private System.Windows.Forms.Label labTipo;
		private System.Windows.Forms.ComboBox cbxTipo;
	}
}
