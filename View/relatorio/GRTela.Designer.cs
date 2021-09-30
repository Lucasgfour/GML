
namespace GM.View.relatorio
{
	partial class GRTela
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRTela));
			this.dgDados = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
			this.SuspendLayout();
			// 
			// dgDados
			// 
			this.dgDados.AllowUserToAddRows = false;
			this.dgDados.AllowUserToDeleteRows = false;
			this.dgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgDados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgDados.Location = new System.Drawing.Point(0, 0);
			this.dgDados.Name = "dgDados";
			this.dgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgDados.ShowEditingIcon = false;
			this.dgDados.Size = new System.Drawing.Size(852, 535);
			this.dgDados.TabIndex = 0;
			// 
			// GRTela
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 535);
			this.Controls.Add(this.dgDados);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GRTela";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Relatório";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dgDados;
	}
}
