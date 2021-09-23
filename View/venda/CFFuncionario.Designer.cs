
namespace GM.View.venda
{
	partial class CFFuncionario
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
			this.txtPin = new System.Windows.Forms.TextBox();
			this.labZTroco = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPin
			// 
			this.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPin.Location = new System.Drawing.Point(12, 40);
			this.txtPin.MaxLength = 4;
			this.txtPin.Name = "txtPin";
			this.txtPin.Size = new System.Drawing.Size(259, 27);
			this.txtPin.TabIndex = 16;
			this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPin.UseSystemPasswordChar = true;
			this.txtPin.TextChanged += new System.EventHandler(this.maskNumber);
			// 
			// labZTroco
			// 
			this.labZTroco.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.labZTroco.Location = new System.Drawing.Point(12, 9);
			this.labZTroco.Name = "labZTroco";
			this.labZTroco.Size = new System.Drawing.Size(259, 28);
			this.labZTroco.TabIndex = 17;
			this.labZTroco.Text = "PIN Funcionário : [ ENTER ]";
			this.labZTroco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CFFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
			this.ClientSize = new System.Drawing.Size(283, 80);
			this.Controls.Add(this.txtPin);
			this.Controls.Add(this.labZTroco);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "CFFuncionario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Confirmação de PIN - Usuário";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnter);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labZTroco;
		private System.Windows.Forms.TextBox txtPin;
	}
}
