
namespace GM.View.caixa
{
	partial class zMVCaixa
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.txtDescricao = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.Label();
			this.txtOrigem = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.Transparent;
			this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescricao.Location = new System.Drawing.Point(0, 0);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(573, 25);
			this.txtDescricao.TabIndex = 0;
			this.txtDescricao.Text = "Pagamento Moto";
			this.txtDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtValor
			// 
			this.txtValor.BackColor = System.Drawing.Color.Transparent;
			this.txtValor.Dock = System.Windows.Forms.DockStyle.Right;
			this.txtValor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor.Location = new System.Drawing.Point(695, 0);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(159, 25);
			this.txtValor.TabIndex = 1;
			this.txtValor.Text = "R$ 0,00";
			this.txtValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtOrigem
			// 
			this.txtOrigem.BackColor = System.Drawing.Color.Transparent;
			this.txtOrigem.Dock = System.Windows.Forms.DockStyle.Right;
			this.txtOrigem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOrigem.Location = new System.Drawing.Point(573, 0);
			this.txtOrigem.Name = "txtOrigem";
			this.txtOrigem.Size = new System.Drawing.Size(122, 25);
			this.txtOrigem.TabIndex = 3;
			this.txtOrigem.Text = "Manual";
			this.txtOrigem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// zMVCaixa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.txtOrigem);
			this.Controls.Add(this.txtValor);
			this.Name = "zMVCaixa";
			this.Size = new System.Drawing.Size(854, 25);
			this.Load += new System.EventHandler(this.Arranque);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label txtOrigem;
		private System.Windows.Forms.Label txtValor;
		private System.Windows.Forms.Label txtDescricao;
	}
}
