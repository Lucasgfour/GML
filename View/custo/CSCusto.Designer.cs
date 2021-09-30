
namespace GM.View.custo
{
	partial class CSCusto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSCusto));
			this.txtFornecedor = new System.Windows.Forms.TextBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.txtLoja = new System.Windows.Forms.TextBox();
			this.labLoja = new System.Windows.Forms.Label();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.labDescricao = new System.Windows.Forms.Label();
			this.txtEmissao = new System.Windows.Forms.TextBox();
			this.labEmissao = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.labCodigo = new System.Windows.Forms.Label();
			this.cbxTipo = new System.Windows.Forms.ComboBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.labValor = new System.Windows.Forms.Label();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.labCategoria = new System.Windows.Forms.Label();
			this.btnAbrir = new Sunny.UI.UISymbolButton();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.labObservacao = new System.Windows.Forms.Label();
			this.listaParcelas = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.Col05 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// txtFornecedor
			// 
			this.txtFornecedor.BackColor = System.Drawing.Color.White;
			this.txtFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtFornecedor.Location = new System.Drawing.Point(260, 76);
			this.txtFornecedor.Name = "txtFornecedor";
			this.txtFornecedor.ReadOnly = true;
			this.txtFornecedor.Size = new System.Drawing.Size(242, 25);
			this.txtFornecedor.TabIndex = 12;
			// 
			// labFornecedor
			// 
			this.labFornecedor.BackColor = System.Drawing.Color.Transparent;
			this.labFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labFornecedor.Location = new System.Drawing.Point(197, 76);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(57, 25);
			this.labFornecedor.TabIndex = 13;
			this.labFornecedor.Text = "Fornec. :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtLoja
			// 
			this.txtLoja.BackColor = System.Drawing.Color.White;
			this.txtLoja.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtLoja.Location = new System.Drawing.Point(85, 106);
			this.txtLoja.Name = "txtLoja";
			this.txtLoja.ReadOnly = true;
			this.txtLoja.Size = new System.Drawing.Size(120, 25);
			this.txtLoja.TabIndex = 14;
			this.txtLoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labLoja
			// 
			this.labLoja.BackColor = System.Drawing.Color.Transparent;
			this.labLoja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLoja.Location = new System.Drawing.Point(17, 106);
			this.labLoja.Name = "labLoja";
			this.labLoja.Size = new System.Drawing.Size(62, 25);
			this.labLoja.TabIndex = 15;
			this.labLoja.Text = "Loja :";
			this.labLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.White;
			this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtDescricao.Location = new System.Drawing.Point(85, 138);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.ReadOnly = true;
			this.txtDescricao.Size = new System.Drawing.Size(417, 25);
			this.txtDescricao.TabIndex = 16;
			// 
			// labDescricao
			// 
			this.labDescricao.BackColor = System.Drawing.Color.Transparent;
			this.labDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDescricao.Location = new System.Drawing.Point(-11, 138);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(90, 25);
			this.labDescricao.TabIndex = 17;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmissao
			// 
			this.txtEmissao.BackColor = System.Drawing.Color.White;
			this.txtEmissao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtEmissao.Location = new System.Drawing.Point(286, 107);
			this.txtEmissao.Name = "txtEmissao";
			this.txtEmissao.ReadOnly = true;
			this.txtEmissao.Size = new System.Drawing.Size(84, 25);
			this.txtEmissao.TabIndex = 18;
			this.txtEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labEmissao
			// 
			this.labEmissao.BackColor = System.Drawing.Color.Transparent;
			this.labEmissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labEmissao.Location = new System.Drawing.Point(211, 106);
			this.labEmissao.Name = "labEmissao";
			this.labEmissao.Size = new System.Drawing.Size(69, 25);
			this.labEmissao.TabIndex = 19;
			this.labEmissao.Text = "Emissão :";
			this.labEmissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCodigo.Location = new System.Drawing.Point(85, 76);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(73, 25);
			this.txtCodigo.TabIndex = 20;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterCodigo);
			this.txtCodigo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.duploCliquePesquisa);
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCodigo.Location = new System.Drawing.Point(12, 76);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(67, 25);
			this.labCodigo.TabIndex = 21;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxTipo
			// 
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.Enabled = false;
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.Items.AddRange(new object[] {
									"Custo",
									"Despesa"});
			this.cbxTipo.Location = new System.Drawing.Point(376, 107);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(126, 25);
			this.cbxTipo.TabIndex = 22;
			// 
			// txtValor
			// 
			this.txtValor.BackColor = System.Drawing.Color.White;
			this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtValor.Location = new System.Drawing.Point(85, 169);
			this.txtValor.Name = "txtValor";
			this.txtValor.ReadOnly = true;
			this.txtValor.Size = new System.Drawing.Size(120, 25);
			this.txtValor.TabIndex = 23;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labValor
			// 
			this.labValor.BackColor = System.Drawing.Color.Transparent;
			this.labValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labValor.Location = new System.Drawing.Point(-1, 169);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(80, 25);
			this.labValor.TabIndex = 24;
			this.labValor.Text = "Valor (R$) :";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCategoria
			// 
			this.txtCategoria.BackColor = System.Drawing.Color.White;
			this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCategoria.Location = new System.Drawing.Point(297, 168);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.ReadOnly = true;
			this.txtCategoria.Size = new System.Drawing.Size(205, 25);
			this.txtCategoria.TabIndex = 25;
			this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labCategoria
			// 
			this.labCategoria.BackColor = System.Drawing.Color.Transparent;
			this.labCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCategoria.Location = new System.Drawing.Point(211, 168);
			this.labCategoria.Name = "labCategoria";
			this.labCategoria.Size = new System.Drawing.Size(80, 25);
			this.labCategoria.TabIndex = 26;
			this.labCategoria.Text = "Categoria :";
			this.labCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAbrir
			// 
			this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Location = new System.Drawing.Point(158, 76);
			this.btnAbrir.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Radius = 0;
			this.btnAbrir.Size = new System.Drawing.Size(33, 25);
			this.btnAbrir.Symbol = 61816;
			this.btnAbrir.TabIndex = 32;
			this.btnAbrir.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAbrir.Click += new System.EventHandler(this.cliqueIr);
			// 
			// txtObservacao
			// 
			this.txtObservacao.BackColor = System.Drawing.Color.White;
			this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtObservacao.Location = new System.Drawing.Point(85, 200);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.ReadOnly = true;
			this.txtObservacao.Size = new System.Drawing.Size(417, 54);
			this.txtObservacao.TabIndex = 33;
			// 
			// labObservacao
			// 
			this.labObservacao.BackColor = System.Drawing.Color.Transparent;
			this.labObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labObservacao.Location = new System.Drawing.Point(-11, 200);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(90, 25);
			this.labObservacao.TabIndex = 34;
			this.labObservacao.Text = "Obs. :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listaParcelas
			// 
			this.listaParcelas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04,
									this.Col05});
			this.listaParcelas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.listaParcelas.FullRowSelect = true;
			this.listaParcelas.GridLines = true;
			this.listaParcelas.Location = new System.Drawing.Point(12, 260);
			this.listaParcelas.Name = "listaParcelas";
			this.listaParcelas.Size = new System.Drawing.Size(490, 195);
			this.listaParcelas.TabIndex = 35;
			this.listaParcelas.UseCompatibleStateImageBehavior = false;
			this.listaParcelas.View = System.Windows.Forms.View.Details;
			this.listaParcelas.DoubleClick += new System.EventHandler(this.duploCliqueParcela);
			// 
			// Col01
			// 
			this.Col01.Text = "Código";
			this.Col01.Width = 70;
			// 
			// Col02
			// 
			this.Col02.Text = "P/";
			this.Col02.Width = 30;
			// 
			// Col03
			// 
			this.Col03.Text = "Vencimento";
			this.Col03.Width = 80;
			// 
			// Col04
			// 
			this.Col04.Text = "Valor (R$)";
			this.Col04.Width = 140;
			// 
			// Col05
			// 
			this.Col05.Text = "Saldo (R$)";
			this.Col05.Width = 140;
			// 
			// CSCusto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 468);
			this.Controls.Add(this.listaParcelas);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.labObservacao);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.txtCategoria);
			this.Controls.Add(this.labCategoria);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.labValor);
			this.Controls.Add(this.cbxTipo);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.txtEmissao);
			this.Controls.Add(this.labEmissao);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
			this.Controls.Add(this.txtLoja);
			this.Controls.Add(this.labLoja);
			this.Controls.Add(this.txtFornecedor);
			this.Controls.Add(this.labFornecedor);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSCusto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de Custo/Despesa";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader Col05;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaParcelas;
		private System.Windows.Forms.Label labObservacao;
		private System.Windows.Forms.TextBox txtObservacao;
		private Sunny.UI.UISymbolButton btnAbrir;
		private System.Windows.Forms.Label labCategoria;
		private System.Windows.Forms.TextBox txtCategoria;
		private System.Windows.Forms.Label labValor;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.ComboBox cbxTipo;
		private System.Windows.Forms.Label labCodigo;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label labEmissao;
		private System.Windows.Forms.TextBox txtEmissao;
		private System.Windows.Forms.Label labDescricao;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.Label labLoja;
		private System.Windows.Forms.TextBox txtLoja;
		private System.Windows.Forms.Label labFornecedor;
		private System.Windows.Forms.TextBox txtFornecedor;
	}
}
