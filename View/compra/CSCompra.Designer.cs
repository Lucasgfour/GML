
namespace GM.View.compra
{
	partial class CSCompra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSCompra));
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.labCodigo = new System.Windows.Forms.Label();
			this.txtFornecedor = new System.Windows.Forms.TextBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.labSituacao = new System.Windows.Forms.Label();
			this.cbxSituacao = new System.Windows.Forms.ComboBox();
			this.txtCondicao = new System.Windows.Forms.TextBox();
			this.labCondicao = new System.Windows.Forms.Label();
			this.labSede = new System.Windows.Forms.Label();
			this.txtSede = new System.Windows.Forms.TextBox();
			this.labObservacoes = new System.Windows.Forms.Label();
			this.txtObservacoes = new System.Windows.Forms.TextBox();
			this.listaProdutos = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.labValor = new System.Windows.Forms.Label();
			this.txtData = new System.Windows.Forms.TextBox();
			this.labData = new System.Windows.Forms.Label();
			this.btnVoltar = new Sunny.UI.UISymbolButton();
			this.btnProximo = new Sunny.UI.UISymbolButton();
			this.btnAdicionar = new Sunny.UI.UISymbolButton();
			this.btnEditar = new Sunny.UI.UISymbolButton();
			this.btnDeletar = new Sunny.UI.UISymbolButton();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.btnEfetivar = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCodigo.Location = new System.Drawing.Point(108, 118);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = true;
			this.txtCodigo.Size = new System.Drawing.Size(94, 25);
			this.txtCodigo.TabIndex = 6;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCodigo.Location = new System.Drawing.Point(12, 118);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(90, 25);
			this.labCodigo.TabIndex = 7;
			this.labCodigo.Text = "N° Compra :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFornecedor
			// 
			this.txtFornecedor.BackColor = System.Drawing.Color.White;
			this.txtFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtFornecedor.Location = new System.Drawing.Point(108, 149);
			this.txtFornecedor.Name = "txtFornecedor";
			this.txtFornecedor.ReadOnly = true;
			this.txtFornecedor.Size = new System.Drawing.Size(290, 25);
			this.txtFornecedor.TabIndex = 8;
			this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labFornecedor
			// 
			this.labFornecedor.BackColor = System.Drawing.Color.Transparent;
			this.labFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labFornecedor.Location = new System.Drawing.Point(12, 149);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(90, 25);
			this.labFornecedor.TabIndex = 9;
			this.labFornecedor.Text = "Fornecedor :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labSituacao
			// 
			this.labSituacao.BackColor = System.Drawing.Color.Transparent;
			this.labSituacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSituacao.Location = new System.Drawing.Point(208, 117);
			this.labSituacao.Name = "labSituacao";
			this.labSituacao.Size = new System.Drawing.Size(70, 25);
			this.labSituacao.TabIndex = 10;
			this.labSituacao.Text = "Situação :";
			this.labSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSituacao
			// 
			this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSituacao.Enabled = false;
			this.cbxSituacao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxSituacao.FormattingEnabled = true;
			this.cbxSituacao.Items.AddRange(new object[] {
									"NÃO ATENDIDO",
									"ATENDIDO"});
			this.cbxSituacao.Location = new System.Drawing.Point(284, 117);
			this.cbxSituacao.Name = "cbxSituacao";
			this.cbxSituacao.Size = new System.Drawing.Size(136, 25);
			this.cbxSituacao.TabIndex = 12;
			// 
			// txtCondicao
			// 
			this.txtCondicao.BackColor = System.Drawing.Color.White;
			this.txtCondicao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCondicao.Location = new System.Drawing.Point(108, 241);
			this.txtCondicao.Name = "txtCondicao";
			this.txtCondicao.ReadOnly = true;
			this.txtCondicao.Size = new System.Drawing.Size(193, 25);
			this.txtCondicao.TabIndex = 13;
			this.txtCondicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labCondicao
			// 
			this.labCondicao.BackColor = System.Drawing.Color.Transparent;
			this.labCondicao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCondicao.Location = new System.Drawing.Point(29, 241);
			this.labCondicao.Name = "labCondicao";
			this.labCondicao.Size = new System.Drawing.Size(73, 25);
			this.labCondicao.TabIndex = 14;
			this.labCondicao.Text = "Condição :";
			this.labCondicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSede.Location = new System.Drawing.Point(404, 148);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(47, 25);
			this.labSede.TabIndex = 15;
			this.labSede.Text = "Sede :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSede
			// 
			this.txtSede.BackColor = System.Drawing.Color.White;
			this.txtSede.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSede.Location = new System.Drawing.Point(457, 150);
			this.txtSede.Name = "txtSede";
			this.txtSede.ReadOnly = true;
			this.txtSede.Size = new System.Drawing.Size(157, 25);
			this.txtSede.TabIndex = 16;
			this.txtSede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labObservacoes
			// 
			this.labObservacoes.BackColor = System.Drawing.Color.Transparent;
			this.labObservacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labObservacoes.Location = new System.Drawing.Point(-3, 180);
			this.labObservacoes.Name = "labObservacoes";
			this.labObservacoes.Size = new System.Drawing.Size(105, 25);
			this.labObservacoes.TabIndex = 17;
			this.labObservacoes.Text = "Observações :";
			this.labObservacoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.BackColor = System.Drawing.Color.White;
			this.txtObservacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtObservacoes.Location = new System.Drawing.Point(108, 180);
			this.txtObservacoes.Multiline = true;
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.ReadOnly = true;
			this.txtObservacoes.Size = new System.Drawing.Size(506, 54);
			this.txtObservacoes.TabIndex = 18;
			this.txtObservacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// listaProdutos
			// 
			this.listaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04});
			this.listaProdutos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaProdutos.FullRowSelect = true;
			this.listaProdutos.GridLines = true;
			this.listaProdutos.Location = new System.Drawing.Point(12, 272);
			this.listaProdutos.Name = "listaProdutos";
			this.listaProdutos.Size = new System.Drawing.Size(602, 252);
			this.listaProdutos.TabIndex = 19;
			this.listaProdutos.UseCompatibleStateImageBehavior = false;
			this.listaProdutos.View = System.Windows.Forms.View.Details;
			// 
			// Col01
			// 
			this.Col01.Text = "Quantidade";
			this.Col01.Width = 75;
			// 
			// Col02
			// 
			this.Col02.Text = "Produto";
			this.Col02.Width = 250;
			// 
			// Col03
			// 
			this.Col03.Text = "Valor Unitário (R$)";
			this.Col03.Width = 110;
			// 
			// Col04
			// 
			this.Col04.Text = "Valor total (R$)";
			this.Col04.Width = 125;
			// 
			// txtValor
			// 
			this.txtValor.BackColor = System.Drawing.Color.White;
			this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtValor.Location = new System.Drawing.Point(426, 240);
			this.txtValor.Name = "txtValor";
			this.txtValor.ReadOnly = true;
			this.txtValor.Size = new System.Drawing.Size(188, 25);
			this.txtValor.TabIndex = 21;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labValor
			// 
			this.labValor.BackColor = System.Drawing.Color.Transparent;
			this.labValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labValor.Location = new System.Drawing.Point(302, 240);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(118, 25);
			this.labValor.TabIndex = 20;
			this.labValor.Text = "Valor Total (R$) :";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtData
			// 
			this.txtData.BackColor = System.Drawing.Color.White;
			this.txtData.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtData.Location = new System.Drawing.Point(479, 119);
			this.txtData.Name = "txtData";
			this.txtData.ReadOnly = true;
			this.txtData.Size = new System.Drawing.Size(135, 25);
			this.txtData.TabIndex = 23;
			this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labData
			// 
			this.labData.BackColor = System.Drawing.Color.Transparent;
			this.labData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labData.Location = new System.Drawing.Point(426, 119);
			this.labData.Name = "labData";
			this.labData.Size = new System.Drawing.Size(47, 25);
			this.labData.TabIndex = 24;
			this.labData.Text = "Data :";
			this.labData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnVoltar.Location = new System.Drawing.Point(12, 74);
			this.btnVoltar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Radius = 0;
			this.btnVoltar.Size = new System.Drawing.Size(40, 40);
			this.btnVoltar.Symbol = 61536;
			this.btnVoltar.TabIndex = 25;
			this.btnVoltar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnVoltar.Click += new System.EventHandler(this.voltarClique);
			// 
			// btnProximo
			// 
			this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnProximo.Location = new System.Drawing.Point(53, 74);
			this.btnProximo.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Radius = 0;
			this.btnProximo.Size = new System.Drawing.Size(40, 40);
			this.btnProximo.Symbol = 61537;
			this.btnProximo.TabIndex = 26;
			this.btnProximo.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnProximo.Click += new System.EventHandler(this.proximoClique);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAdicionar.Location = new System.Drawing.Point(99, 74);
			this.btnAdicionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Radius = 0;
			this.btnAdicionar.Size = new System.Drawing.Size(40, 40);
			this.btnAdicionar.Symbol = 61543;
			this.btnAdicionar.TabIndex = 27;
			this.btnAdicionar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnAdicionar.Click += new System.EventHandler(this.novoClique);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnEditar.Location = new System.Drawing.Point(140, 74);
			this.btnEditar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Radius = 0;
			this.btnEditar.Size = new System.Drawing.Size(40, 40);
			this.btnEditar.Symbol = 61508;
			this.btnEditar.TabIndex = 28;
			this.btnEditar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnEditar.Click += new System.EventHandler(this.editarClique);
			// 
			// btnDeletar
			// 
			this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnDeletar.Location = new System.Drawing.Point(181, 74);
			this.btnDeletar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Radius = 0;
			this.btnDeletar.Size = new System.Drawing.Size(40, 40);
			this.btnDeletar.Symbol = 62164;
			this.btnDeletar.TabIndex = 29;
			this.btnDeletar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnDeletar.Click += new System.EventHandler(this.deletarClique);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnPesquisar.Location = new System.Drawing.Point(227, 74);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Radius = 0;
			this.btnPesquisar.Size = new System.Drawing.Size(40, 40);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 30;
			this.btnPesquisar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// btnEfetivar
			// 
			this.btnEfetivar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEfetivar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnEfetivar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnEfetivar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnEfetivar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnEfetivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnEfetivar.Location = new System.Drawing.Point(426, 74);
			this.btnEfetivar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnEfetivar.Name = "btnEfetivar";
			this.btnEfetivar.Radius = 0;
			this.btnEfetivar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnEfetivar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnEfetivar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnEfetivar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnEfetivar.Size = new System.Drawing.Size(188, 40);
			this.btnEfetivar.Style = Sunny.UI.UIStyle.Green;
			this.btnEfetivar.Symbol = 61528;
			this.btnEfetivar.TabIndex = 31;
			this.btnEfetivar.Text = "ATENDER COMPRA";
			this.btnEfetivar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnEfetivar.Click += new System.EventHandler(this.efetivarClique);
			// 
			// CSCompra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(626, 535);
			this.Controls.Add(this.btnEfetivar);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.btnProximo);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.labData);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.labValor);
			this.Controls.Add(this.listaProdutos);
			this.Controls.Add(this.txtObservacoes);
			this.Controls.Add(this.labObservacoes);
			this.Controls.Add(this.txtSede);
			this.Controls.Add(this.txtCondicao);
			this.Controls.Add(this.labCondicao);
			this.Controls.Add(this.cbxSituacao);
			this.Controls.Add(this.labSituacao);
			this.Controls.Add(this.txtFornecedor);
			this.Controls.Add(this.labFornecedor);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.labSede);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSCompra";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta compra";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton btnEfetivar;
		private Sunny.UI.UISymbolButton btnPesquisar;
		private Sunny.UI.UISymbolButton btnDeletar;
		private Sunny.UI.UISymbolButton btnEditar;
		private Sunny.UI.UISymbolButton btnAdicionar;
		private Sunny.UI.UISymbolButton btnProximo;
		private Sunny.UI.UISymbolButton btnVoltar;
		private System.Windows.Forms.Label labData;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.ListView listaProdutos;
		private System.Windows.Forms.TextBox txtObservacoes;
		private System.Windows.Forms.Label labObservacoes;
		private System.Windows.Forms.TextBox txtSede;
		private System.Windows.Forms.Label labSede;
		private System.Windows.Forms.Label labCondicao;
		private System.Windows.Forms.TextBox txtCondicao;
		private System.Windows.Forms.ComboBox cbxSituacao;
		private System.Windows.Forms.Label labValor;
		private System.Windows.Forms.Label labSituacao;
		private System.Windows.Forms.Label labFornecedor;
		private System.Windows.Forms.TextBox txtFornecedor;
		private System.Windows.Forms.Label labCodigo;
		private System.Windows.Forms.TextBox txtCodigo;
	}
}
