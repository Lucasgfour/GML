
namespace GM.View.venda
{
	partial class CDBalcao2
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
			this.cbxPagamento = new GM.Componentes.MinComboBox();
			this.labPagamento = new System.Windows.Forms.Label();
			this.labZTroco = new System.Windows.Forms.Label();
			this.txtTroco = new GM.Componentes.MinBox();
			this.labTroco = new System.Windows.Forms.Label();
			this.labZTotal = new System.Windows.Forms.Label();
			this.labTotal = new System.Windows.Forms.Label();
			this.labAtalho1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbxPagamento
			// 
			this.cbxPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cbxPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxPagamento.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.cbxPagamento.FormattingEnabled = true;
			this.cbxPagamento.Location = new System.Drawing.Point(115, 12);
			this.cbxPagamento.Name = "cbxPagamento";
			this.cbxPagamento.Size = new System.Drawing.Size(252, 28);
			this.cbxPagamento.TabIndex = 1;
			// 
			// labPagamento
			// 
			this.labPagamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPagamento.Location = new System.Drawing.Point(31, 12);
			this.labPagamento.Name = "labPagamento";
			this.labPagamento.Size = new System.Drawing.Size(78, 28);
			this.labPagamento.TabIndex = 14;
			this.labPagamento.Text = "Pagamento :";
			this.labPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labZTroco
			// 
			this.labZTroco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labZTroco.Location = new System.Drawing.Point(4, 72);
			this.labZTroco.Name = "labZTroco";
			this.labZTroco.Size = new System.Drawing.Size(105, 28);
			this.labZTroco.TabIndex = 15;
			this.labZTroco.Text = "Calcular troco :";
			this.labZTroco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTroco
			// 
			this.txtTroco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTroco.Location = new System.Drawing.Point(115, 73);
			this.txtTroco.Name = "txtTroco";
			this.txtTroco.Size = new System.Drawing.Size(121, 27);
			this.txtTroco.TabIndex = 2;
			this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTroco.TextChanged += new System.EventHandler(this.maskMoney);
			// 
			// labTroco
			// 
			this.labTroco.BackColor = System.Drawing.Color.White;
			this.labTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labTroco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.labTroco.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labTroco.Location = new System.Drawing.Point(242, 73);
			this.labTroco.Name = "labTroco";
			this.labTroco.Size = new System.Drawing.Size(125, 27);
			this.labTroco.TabIndex = 17;
			this.labTroco.Text = "R$ 0,00";
			this.labTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labZTotal
			// 
			this.labZTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labZTotal.Location = new System.Drawing.Point(31, 43);
			this.labZTotal.Name = "labZTotal";
			this.labZTotal.Size = new System.Drawing.Size(78, 28);
			this.labZTotal.TabIndex = 18;
			this.labZTotal.Text = "Total (R$) :";
			this.labZTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labTotal
			// 
			this.labTotal.BackColor = System.Drawing.Color.White;
			this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.labTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labTotal.Location = new System.Drawing.Point(115, 43);
			this.labTotal.Name = "labTotal";
			this.labTotal.Size = new System.Drawing.Size(252, 27);
			this.labTotal.TabIndex = 19;
			this.labTotal.Text = "R$ 0,00";
			this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labAtalho1
			// 
			this.labAtalho1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labAtalho1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.labAtalho1.Location = new System.Drawing.Point(168, 115);
			this.labAtalho1.Name = "labAtalho1";
			this.labAtalho1.Size = new System.Drawing.Size(199, 23);
			this.labAtalho1.TabIndex = 20;
			this.labAtalho1.Text = "[ ENTER ] PARA FINALIZAR";
			// 
			// CDBalcao2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
			this.ClientSize = new System.Drawing.Size(379, 147);
			this.Controls.Add(this.labAtalho1);
			this.Controls.Add(this.labTotal);
			this.Controls.Add(this.labZTotal);
			this.Controls.Add(this.labTroco);
			this.Controls.Add(this.txtTroco);
			this.Controls.Add(this.labZTroco);
			this.Controls.Add(this.cbxPagamento);
			this.Controls.Add(this.labPagamento);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "CDBalcao2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CDBalcao2";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarTecla);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labAtalho1;
		private System.Windows.Forms.Label labTotal;
		private System.Windows.Forms.Label labZTotal;
		private System.Windows.Forms.Label labTroco;
		private GM.Componentes.MinBox txtTroco;
		private System.Windows.Forms.Label labZTroco;
		private System.Windows.Forms.Label labPagamento;
		private System.Windows.Forms.ComboBox cbxPagamento;
	}
}
