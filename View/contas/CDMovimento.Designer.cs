
namespace GM.View.contas
{
	partial class CDMovimento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDMovimento));
			this.cbxTipo = new System.Windows.Forms.ComboBox();
			this.labTipo = new System.Windows.Forms.Label();
			this.labDescricao = new System.Windows.Forms.Label();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.labValor = new System.Windows.Forms.Label();
			this.txtData = new System.Windows.Forms.TextBox();
			this.labData = new System.Windows.Forms.Label();
			this.labTitulo = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.labSaldo = new ReaLTaiizor.Controls.DungeonLabel();
			this.SuspendLayout();
			// 
			// cbxTipo
			// 
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.Items.AddRange(new object[] {
									"Entrada",
									"Saída"});
			this.cbxTipo.Location = new System.Drawing.Point(91, 141);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(118, 23);
			this.cbxTipo.TabIndex = 1;
			this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.mudarTipo);
			// 
			// labTipo
			// 
			this.labTipo.BackColor = System.Drawing.Color.Transparent;
			this.labTipo.Location = new System.Drawing.Point(12, 141);
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(73, 23);
			this.labTipo.TabIndex = 1;
			this.labTipo.Text = "Tipo :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labDescricao
			// 
			this.labDescricao.BackColor = System.Drawing.Color.Transparent;
			this.labDescricao.Location = new System.Drawing.Point(12, 170);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(73, 23);
			this.labDescricao.TabIndex = 3;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(91, 170);
			this.txtDescricao.MaxLength = 50;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(206, 23);
			this.txtDescricao.TabIndex = 2;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(91, 199);
			this.txtValor.MaxLength = 50;
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(140, 23);
			this.txtValor.TabIndex = 3;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtValor.TextChanged += new System.EventHandler(this.maskMoney);
			// 
			// labValor
			// 
			this.labValor.BackColor = System.Drawing.Color.Transparent;
			this.labValor.Location = new System.Drawing.Point(12, 199);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(73, 23);
			this.labValor.TabIndex = 5;
			this.labValor.Text = "Valor (R$) :";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(91, 112);
			this.txtData.MaxLength = 50;
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(140, 23);
			this.txtData.TabIndex = 0;
			this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtData.TextChanged += new System.EventHandler(this.maskData);
			this.txtData.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// labData
			// 
			this.labData.BackColor = System.Drawing.Color.Transparent;
			this.labData.Location = new System.Drawing.Point(12, 112);
			this.labData.Name = "labData";
			this.labData.Size = new System.Drawing.Size(73, 23);
			this.labData.TabIndex = 7;
			this.labData.Text = "Data :";
			this.labData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labTitulo
			// 
			this.labTitulo.BackColor = System.Drawing.Color.Transparent;
			this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labTitulo.Location = new System.Drawing.Point(12, 77);
			this.labTitulo.Name = "labTitulo";
			this.labTitulo.Size = new System.Drawing.Size(285, 28);
			this.labTitulo.TabIndex = 24;
			this.labTitulo.Text = "Cadastro de Movimentação de Conta";
			this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(69, 256);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Size = new System.Drawing.Size(111, 29);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 26;
			this.btnCancelar.Text = "Sair";
			this.btnCancelar.Click += new System.EventHandler(this.cliqueSair);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSalvar.Location = new System.Drawing.Point(186, 256);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(111, 29);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 25;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// labSaldo
			// 
			this.labSaldo.BackColor = System.Drawing.Color.Transparent;
			this.labSaldo.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSaldo.Location = new System.Drawing.Point(12, 225);
			this.labSaldo.Name = "labSaldo";
			this.labSaldo.Size = new System.Drawing.Size(285, 28);
			this.labSaldo.TabIndex = 27;
			this.labSaldo.Text = "Saldo : ";
			this.labSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CDMovimento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 297);
			this.Controls.Add(this.labSaldo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.labTitulo);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.labData);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.labValor);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
			this.Controls.Add(this.labTipo);
			this.Controls.Add(this.cbxTipo);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDMovimento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de movimentação de conta";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private ReaLTaiizor.Controls.DungeonLabel labSaldo;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private ReaLTaiizor.Controls.DungeonLabel labTitulo;
		private System.Windows.Forms.Label labData;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Label labValor;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.Label labDescricao;
		private System.Windows.Forms.Label labTipo;
		private System.Windows.Forms.ComboBox cbxTipo;
	}
}
