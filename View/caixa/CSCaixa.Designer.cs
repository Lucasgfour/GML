
namespace GM.View.caixa
{
	partial class CSCaixa
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
			this.txtDatai = new System.Windows.Forms.DateTimePicker();
			this.txtDataf = new System.Windows.Forms.DateTimePicker();
			this.labAte = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.pnlMovimentacoes = new System.Windows.Forms.Panel();
			this.cbxSede = new GM.Componentes.MinComboBox();
			this.labSede = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnAdicionar = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// txtDatai
			// 
			this.txtDatai.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDatai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtDatai.Location = new System.Drawing.Point(385, 16);
			this.txtDatai.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
			this.txtDatai.Name = "txtDatai";
			this.txtDatai.Size = new System.Drawing.Size(109, 23);
			this.txtDatai.TabIndex = 1;
			this.txtDatai.Value = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
			// 
			// txtDataf
			// 
			this.txtDataf.Font = new System.Drawing.Font("Consolas", 9.75F);
			this.txtDataf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtDataf.Location = new System.Drawing.Point(543, 16);
			this.txtDataf.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
			this.txtDataf.Name = "txtDataf";
			this.txtDataf.Size = new System.Drawing.Size(109, 23);
			this.txtDataf.TabIndex = 2;
			this.txtDataf.Value = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
			// 
			// labAte
			// 
			this.labAte.BackColor = System.Drawing.Color.Transparent;
			this.labAte.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labAte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labAte.Location = new System.Drawing.Point(500, 16);
			this.labAte.Name = "labAte";
			this.labAte.Size = new System.Drawing.Size(37, 23);
			this.labAte.TabIndex = 15;
			this.labAte.Text = "até";
			this.labAte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnPesquisar.Location = new System.Drawing.Point(658, 12);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(37, 29);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 16;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisarClique);
			// 
			// pnlMovimentacoes
			// 
			this.pnlMovimentacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMovimentacoes.AutoScroll = true;
			this.pnlMovimentacoes.BackColor = System.Drawing.Color.Gainsboro;
			this.pnlMovimentacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlMovimentacoes.Location = new System.Drawing.Point(12, 47);
			this.pnlMovimentacoes.MaximumSize = new System.Drawing.Size(814, 2000);
			this.pnlMovimentacoes.MinimumSize = new System.Drawing.Size(814, 287);
			this.pnlMovimentacoes.Name = "pnlMovimentacoes";
			this.pnlMovimentacoes.Size = new System.Drawing.Size(814, 392);
			this.pnlMovimentacoes.TabIndex = 17;
			// 
			// cbxSede
			// 
			this.cbxSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSede.FormattingEnabled = true;
			this.cbxSede.Location = new System.Drawing.Point(258, 18);
			this.cbxSede.Name = "cbxSede";
			this.cbxSede.Size = new System.Drawing.Size(121, 21);
			this.cbxSede.TabIndex = 18;
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSede.Location = new System.Drawing.Point(188, 18);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(64, 21);
			this.labSede.TabIndex = 19;
			this.labSede.Text = "Empresa :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.btnAdicionar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
			this.btnAdicionar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnAdicionar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnAdicionar.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
			this.btnAdicionar.Location = new System.Drawing.Point(12, 12);
			this.btnAdicionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.btnAdicionar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
			this.btnAdicionar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnAdicionar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnAdicionar.Size = new System.Drawing.Size(170, 29);
			this.btnAdicionar.Style = Sunny.UI.UIStyle.Gray;
			this.btnAdicionar.Symbol = 61543;
			this.btnAdicionar.TabIndex = 20;
			this.btnAdicionar.Text = "Adicionar Fluxo de Caixa";
			this.btnAdicionar.Click += new System.EventHandler(this.AdicionarClique);
			// 
			// CSCaixa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 451);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.cbxSede);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.pnlMovimentacoes);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.labAte);
			this.Controls.Add(this.txtDataf);
			this.Controls.Add(this.txtDatai);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(854, 20000);
			this.MinimumSize = new System.Drawing.Size(854, 287);
			this.Name = "CSCaixa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fluxo de caixa";
			this.Load += new System.EventHandler(this.Arranque);
			this.ResumeLayout(false);
		}
		private Sunny.UI.UISymbolButton btnAdicionar;
		private ReaLTaiizor.Controls.DungeonLabel labSede;
		private System.Windows.Forms.ComboBox cbxSede;
		private System.Windows.Forms.Panel pnlMovimentacoes;
		private Sunny.UI.UISymbolButton btnPesquisar;
		private ReaLTaiizor.Controls.DungeonLabel labAte;
		private System.Windows.Forms.DateTimePicker txtDataf;
		private System.Windows.Forms.DateTimePicker txtDatai;
	}
}
