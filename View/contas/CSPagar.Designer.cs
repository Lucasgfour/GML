
namespace GM.View.contas
{
	partial class CSPagar
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
			System.Windows.Forms.ColumnHeader Col04;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSPagar));
			this.listaContas = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col05 = new System.Windows.Forms.ColumnHeader();
			this.Col06 = new System.Windows.Forms.ColumnHeader();
			this.Col07 = new System.Windows.Forms.ColumnHeader();
			this.labAte = new System.Windows.Forms.Label();
			this.labEmissao = new System.Windows.Forms.Label();
			this.txtDtFinal = new GM.Componentes.MinBox();
			this.txtDtInicio = new GM.Componentes.MinBox();
			this.cbxOrdenacao = new GM.Componentes.MinComboBox();
			this.labOrdenacao = new System.Windows.Forms.Label();
			this.cbxLoja = new GM.Componentes.MinComboBox();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.chkSaldo = new System.Windows.Forms.CheckBox();
			this.labLoja = new System.Windows.Forms.Label();
			Col04 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// Col04
			// 
			Col04.Text = "Valor Original (R$)";
			Col04.Width = 115;
			// 
			// listaContas
			// 
			this.listaContas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listaContas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									Col04,
									this.Col05,
									this.Col06,
									this.Col07});
			this.listaContas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaContas.FullRowSelect = true;
			this.listaContas.GridLines = true;
			this.listaContas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listaContas.Location = new System.Drawing.Point(12, 139);
			this.listaContas.Name = "listaContas";
			this.listaContas.Size = new System.Drawing.Size(816, 393);
			this.listaContas.TabIndex = 0;
			this.listaContas.UseCompatibleStateImageBehavior = false;
			this.listaContas.View = System.Windows.Forms.View.Details;
			this.listaContas.SelectedIndexChanged += new System.EventHandler(this.ListaContasSelectedIndexChanged);
			this.listaContas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploCliqueLista);
			// 
			// Col01
			// 
			this.Col01.Text = "Número";
			// 
			// Col02
			// 
			this.Col02.Text = "Emissão";
			this.Col02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col02.Width = 80;
			// 
			// Col03
			// 
			this.Col03.Text = "Vencimento";
			this.Col03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Col03.Width = 80;
			// 
			// Col05
			// 
			this.Col05.Text = "Saldo Aberto(R$)";
			this.Col05.Width = 115;
			// 
			// Col06
			// 
			this.Col06.Text = "Fornecedor";
			this.Col06.Width = 180;
			// 
			// Col07
			// 
			this.Col07.Text = "Referência";
			this.Col07.Width = 150;
			// 
			// labAte
			// 
			this.labAte.BackColor = System.Drawing.Color.Transparent;
			this.labAte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAte.Location = new System.Drawing.Point(202, 106);
			this.labAte.Name = "labAte";
			this.labAte.Size = new System.Drawing.Size(31, 29);
			this.labAte.TabIndex = 42;
			this.labAte.Text = "até";
			this.labAte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labEmissao
			// 
			this.labEmissao.BackColor = System.Drawing.Color.Transparent;
			this.labEmissao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labEmissao.Location = new System.Drawing.Point(13, 107);
			this.labEmissao.Name = "labEmissao";
			this.labEmissao.Size = new System.Drawing.Size(78, 26);
			this.labEmissao.TabIndex = 41;
			this.labEmissao.Text = "Vencimento :";
			this.labEmissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDtFinal
			// 
			this.txtDtFinal.BackColor = System.Drawing.Color.Transparent;
			this.txtDtFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDtFinal.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDtFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDtFinal.CustomBGColor = System.Drawing.Color.White;
			this.txtDtFinal.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtDtFinal.ForeColor = System.Drawing.Color.Black;
			this.txtDtFinal.Location = new System.Drawing.Point(239, 105);
			this.txtDtFinal.MaxLength = 32767;
			this.txtDtFinal.Multiline = false;
			this.txtDtFinal.Name = "txtDtFinal";
			this.txtDtFinal.ReadOnly = false;
			this.txtDtFinal.SelectionStart = 0;
			this.txtDtFinal.Size = new System.Drawing.Size(99, 28);
			this.txtDtFinal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDtFinal.TabIndex = 40;
			this.txtDtFinal.Text = "00/00/0000";
			this.txtDtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDtFinal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDtFinal.UseSystemPasswordChar = false;
			// 
			// txtDtInicio
			// 
			this.txtDtInicio.BackColor = System.Drawing.Color.Transparent;
			this.txtDtInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDtInicio.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDtInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDtInicio.CustomBGColor = System.Drawing.Color.White;
			this.txtDtInicio.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtDtInicio.ForeColor = System.Drawing.Color.Black;
			this.txtDtInicio.Location = new System.Drawing.Point(97, 106);
			this.txtDtInicio.MaxLength = 32767;
			this.txtDtInicio.Multiline = false;
			this.txtDtInicio.Name = "txtDtInicio";
			this.txtDtInicio.ReadOnly = false;
			this.txtDtInicio.SelectionStart = 0;
			this.txtDtInicio.Size = new System.Drawing.Size(99, 28);
			this.txtDtInicio.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDtInicio.TabIndex = 39;
			this.txtDtInicio.Text = "00/00/0000";
			this.txtDtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDtInicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDtInicio.UseSystemPasswordChar = false;
			// 
			// cbxOrdenacao
			// 
			this.cbxOrdenacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxOrdenacao.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxOrdenacao.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxOrdenacao.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxOrdenacao.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxOrdenacao.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxOrdenacao.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxOrdenacao.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxOrdenacao.ColorH = System.Drawing.Color.White;
			this.cbxOrdenacao.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxOrdenacao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxOrdenacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxOrdenacao.DropDownHeight = 100;
			this.cbxOrdenacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxOrdenacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxOrdenacao.ForeColor = System.Drawing.Color.Black;
			this.cbxOrdenacao.FormattingEnabled = true;
			this.cbxOrdenacao.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxOrdenacao.IntegralHeight = false;
			this.cbxOrdenacao.ItemHeight = 20;
			this.cbxOrdenacao.Items.AddRange(new object[] {
									"Vencimento",
									"Emissao",
									"Numero",
									"Fornecedor",
									"Referencia"});
			this.cbxOrdenacao.Location = new System.Drawing.Point(300, 76);
			this.cbxOrdenacao.Name = "cbxOrdenacao";
			this.cbxOrdenacao.Size = new System.Drawing.Size(109, 26);
			this.cbxOrdenacao.StartIndex = 0;
			this.cbxOrdenacao.TabIndex = 37;
			// 
			// labOrdenacao
			// 
			this.labOrdenacao.BackColor = System.Drawing.Color.Transparent;
			this.labOrdenacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labOrdenacao.Location = new System.Drawing.Point(219, 74);
			this.labOrdenacao.Name = "labOrdenacao";
			this.labOrdenacao.Size = new System.Drawing.Size(75, 26);
			this.labOrdenacao.TabIndex = 38;
			this.labOrdenacao.Text = "Ordernação :";
			this.labOrdenacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxLoja
			// 
			this.cbxLoja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxLoja.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxLoja.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxLoja.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxLoja.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxLoja.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxLoja.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxLoja.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxLoja.ColorH = System.Drawing.Color.White;
			this.cbxLoja.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxLoja.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxLoja.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxLoja.DropDownHeight = 100;
			this.cbxLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxLoja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxLoja.ForeColor = System.Drawing.Color.Black;
			this.cbxLoja.FormattingEnabled = true;
			this.cbxLoja.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxLoja.IntegralHeight = false;
			this.cbxLoja.ItemHeight = 20;
			this.cbxLoja.Location = new System.Drawing.Point(61, 74);
			this.cbxLoja.Name = "cbxLoja";
			this.cbxLoja.Size = new System.Drawing.Size(152, 26);
			this.cbxLoja.StartIndex = 0;
			this.cbxLoja.TabIndex = 34;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnPesquisar.Location = new System.Drawing.Point(344, 105);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Radius = 0;
			this.btnPesquisar.Size = new System.Drawing.Size(157, 28);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 43;
			this.btnPesquisar.Text = "PESQUISAR";
			this.btnPesquisar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			// 
			// chkSaldo
			// 
			this.chkSaldo.BackColor = System.Drawing.Color.Transparent;
			this.chkSaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkSaldo.Location = new System.Drawing.Point(415, 76);
			this.chkSaldo.Name = "chkSaldo";
			this.chkSaldo.Size = new System.Drawing.Size(86, 26);
			this.chkSaldo.TabIndex = 36;
			this.chkSaldo.Text = "Sem Saldo";
			this.chkSaldo.UseVisualStyleBackColor = false;
			// 
			// labLoja
			// 
			this.labLoja.BackColor = System.Drawing.Color.Transparent;
			this.labLoja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLoja.Location = new System.Drawing.Point(12, 74);
			this.labLoja.Name = "labLoja";
			this.labLoja.Size = new System.Drawing.Size(43, 23);
			this.labLoja.TabIndex = 35;
			this.labLoja.Text = "Loja : ";
			this.labLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CSPagar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 547);
			this.Controls.Add(this.labAte);
			this.Controls.Add(this.labEmissao);
			this.Controls.Add(this.txtDtFinal);
			this.Controls.Add(this.txtDtInicio);
			this.Controls.Add(this.cbxOrdenacao);
			this.Controls.Add(this.labOrdenacao);
			this.Controls.Add(this.cbxLoja);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.chkSaldo);
			this.Controls.Add(this.labLoja);
			this.Controls.Add(this.listaContas);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSPagar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta contas a pagar";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private Sunny.UI.UISymbolButton btnPesquisar;
		private GM.Componentes.MinBox txtDtInicio;
		private GM.Componentes.MinBox txtDtFinal;
		private System.Windows.Forms.Label labEmissao;
		private System.Windows.Forms.Label labAte;
		private System.Windows.Forms.Label labOrdenacao;
		private GM.Componentes.MinComboBox cbxOrdenacao;
		private System.Windows.Forms.CheckBox chkSaldo;
		private System.Windows.Forms.Label labLoja;
		private GM.Componentes.MinComboBox cbxLoja;
		private System.Windows.Forms.ColumnHeader Col07;
		private System.Windows.Forms.ColumnHeader Col06;
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaContas;
	}
}
