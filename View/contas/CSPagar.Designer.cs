
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
			this.cbxLoja = new System.Windows.Forms.ComboBox();
			this.labLoja = new System.Windows.Forms.Label();
			this.chkSaldo = new System.Windows.Forms.CheckBox();
			this.cbxOrdenacao = new System.Windows.Forms.ComboBox();
			this.labOrdenacao = new System.Windows.Forms.Label();
			this.gpxFiltro = new System.Windows.Forms.GroupBox();
			this.labAte = new System.Windows.Forms.Label();
			this.labEmissao = new System.Windows.Forms.Label();
			this.txtDtFinal = new System.Windows.Forms.TextBox();
			this.txtDtInicio = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			Col04 = new System.Windows.Forms.ColumnHeader();
			this.gpxFiltro.SuspendLayout();
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
			this.listaContas.Location = new System.Drawing.Point(12, 124);
			this.listaContas.Name = "listaContas";
			this.listaContas.Size = new System.Drawing.Size(816, 408);
			this.listaContas.TabIndex = 0;
			this.listaContas.UseCompatibleStateImageBehavior = false;
			this.listaContas.View = System.Windows.Forms.View.Details;
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
			// cbxLoja
			// 
			this.cbxLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxLoja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxLoja.FormattingEnabled = true;
			this.cbxLoja.Location = new System.Drawing.Point(55, 18);
			this.cbxLoja.Name = "cbxLoja";
			this.cbxLoja.Size = new System.Drawing.Size(152, 23);
			this.cbxLoja.TabIndex = 6;
			// 
			// labLoja
			// 
			this.labLoja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLoja.Location = new System.Drawing.Point(6, 18);
			this.labLoja.Name = "labLoja";
			this.labLoja.Size = new System.Drawing.Size(43, 23);
			this.labLoja.TabIndex = 7;
			this.labLoja.Text = "Loja : ";
			this.labLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkSaldo
			// 
			this.chkSaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkSaldo.Location = new System.Drawing.Point(213, 18);
			this.chkSaldo.Name = "chkSaldo";
			this.chkSaldo.Size = new System.Drawing.Size(83, 23);
			this.chkSaldo.TabIndex = 8;
			this.chkSaldo.Text = "Sem Saldo";
			this.chkSaldo.UseVisualStyleBackColor = true;
			// 
			// cbxOrdenacao
			// 
			this.cbxOrdenacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxOrdenacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxOrdenacao.FormattingEnabled = true;
			this.cbxOrdenacao.Items.AddRange(new object[] {
									"Vencimento",
									"Emissao",
									"Numero",
									"Fornecedor",
									"Referencia"});
			this.cbxOrdenacao.Location = new System.Drawing.Point(656, 17);
			this.cbxOrdenacao.Name = "cbxOrdenacao";
			this.cbxOrdenacao.Size = new System.Drawing.Size(86, 23);
			this.cbxOrdenacao.TabIndex = 9;
			// 
			// labOrdenacao
			// 
			this.labOrdenacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labOrdenacao.Location = new System.Drawing.Point(575, 17);
			this.labOrdenacao.Name = "labOrdenacao";
			this.labOrdenacao.Size = new System.Drawing.Size(75, 23);
			this.labOrdenacao.TabIndex = 10;
			this.labOrdenacao.Text = "Ordernação :";
			this.labOrdenacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gpxFiltro
			// 
			this.gpxFiltro.BackColor = System.Drawing.Color.Transparent;
			this.gpxFiltro.Controls.Add(this.labAte);
			this.gpxFiltro.Controls.Add(this.labEmissao);
			this.gpxFiltro.Controls.Add(this.txtDtFinal);
			this.gpxFiltro.Controls.Add(this.txtDtInicio);
			this.gpxFiltro.Controls.Add(this.cbxOrdenacao);
			this.gpxFiltro.Controls.Add(this.labOrdenacao);
			this.gpxFiltro.Controls.Add(this.cbxLoja);
			this.gpxFiltro.Controls.Add(this.chkSaldo);
			this.gpxFiltro.Controls.Add(this.labLoja);
			this.gpxFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpxFiltro.Location = new System.Drawing.Point(12, 71);
			this.gpxFiltro.Name = "gpxFiltro";
			this.gpxFiltro.Size = new System.Drawing.Size(816, 47);
			this.gpxFiltro.TabIndex = 12;
			this.gpxFiltro.TabStop = false;
			this.gpxFiltro.Text = "Filtro";
			// 
			// labAte
			// 
			this.labAte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAte.Location = new System.Drawing.Point(456, 17);
			this.labAte.Name = "labAte";
			this.labAte.Size = new System.Drawing.Size(31, 23);
			this.labAte.TabIndex = 14;
			this.labAte.Text = "até";
			this.labAte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labEmissao
			// 
			this.labEmissao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labEmissao.Location = new System.Drawing.Point(290, 17);
			this.labEmissao.Name = "labEmissao";
			this.labEmissao.Size = new System.Drawing.Size(78, 23);
			this.labEmissao.TabIndex = 13;
			this.labEmissao.Text = "Vencimento :";
			this.labEmissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDtFinal
			// 
			this.txtDtFinal.Location = new System.Drawing.Point(493, 17);
			this.txtDtFinal.Name = "txtDtFinal";
			this.txtDtFinal.Size = new System.Drawing.Size(76, 23);
			this.txtDtFinal.TabIndex = 12;
			this.txtDtFinal.Text = "00/00/0000";
			this.txtDtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDtFinal.TextChanged += new System.EventHandler(this.maskData);
			this.txtDtFinal.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// txtDtInicio
			// 
			this.txtDtInicio.Location = new System.Drawing.Point(374, 17);
			this.txtDtInicio.Name = "txtDtInicio";
			this.txtDtInicio.Size = new System.Drawing.Size(76, 23);
			this.txtDtInicio.TabIndex = 11;
			this.txtDtInicio.Text = "00/00/0000";
			this.txtDtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDtInicio.TextChanged += new System.EventHandler(this.maskData);
			this.txtDtInicio.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnPesquisar.Location = new System.Drawing.Point(760, 80);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Radius = 0;
			this.btnPesquisar.Size = new System.Drawing.Size(67, 38);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 33;
			this.btnPesquisar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnPesquisar.Click += new System.EventHandler(this.cliquePesquisar);
			// 
			// CSPagar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 547);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.listaContas);
			this.Controls.Add(this.gpxFiltro);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSPagar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta contas a pagar";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.gpxFiltro.ResumeLayout(false);
			this.gpxFiltro.PerformLayout();
			this.ResumeLayout(false);
		}
		private Sunny.UI.UISymbolButton btnPesquisar;
		private System.Windows.Forms.TextBox txtDtInicio;
		private System.Windows.Forms.TextBox txtDtFinal;
		private System.Windows.Forms.Label labEmissao;
		private System.Windows.Forms.Label labAte;
		private System.Windows.Forms.GroupBox gpxFiltro;
		private System.Windows.Forms.Label labOrdenacao;
		private System.Windows.Forms.ComboBox cbxOrdenacao;
		private System.Windows.Forms.CheckBox chkSaldo;
		private System.Windows.Forms.Label labLoja;
		private System.Windows.Forms.ComboBox cbxLoja;
		private System.Windows.Forms.ColumnHeader Col07;
		private System.Windows.Forms.ColumnHeader Col06;
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaContas;
	}
}
