
namespace GM.View.compra
{
	partial class CDCompra
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
			this.areaCabecalho = new System.Windows.Forms.GroupBox();
			this.cbxLoja = new System.Windows.Forms.ComboBox();
			this.labLoja = new System.Windows.Forms.Label();
			this.txtDataCompra = new System.Windows.Forms.TextBox();
			this.labDataCompra = new System.Windows.Forms.Label();
			this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
			this.txtCodigoFornecedor = new System.Windows.Forms.TextBox();
			this.labFornecedor = new System.Windows.Forms.Label();
			this.areaObservacoes = new System.Windows.Forms.GroupBox();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.areaProdutos = new System.Windows.Forms.GroupBox();
			this.btnClearProduto = new Sunny.UI.UISymbolButton();
			this.btnDelProduto = new Sunny.UI.UISymbolButton();
			this.listProduto = new System.Windows.Forms.ListView();
			this.PCol1 = new System.Windows.Forms.ColumnHeader();
			this.PCol2 = new System.Windows.Forms.ColumnHeader();
			this.PCol3 = new System.Windows.Forms.ColumnHeader();
			this.PCol4 = new System.Windows.Forms.ColumnHeader();
			this.btnAddProduto = new Sunny.UI.UISymbolButton();
			this.txtPreco = new System.Windows.Forms.TextBox();
			this.labPreco = new System.Windows.Forms.Label();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.labQuantidade = new System.Windows.Forms.Label();
			this.txtProduto = new System.Windows.Forms.ComboBox();
			this.labProduto = new System.Windows.Forms.Label();
			this.areaConclusao = new System.Windows.Forms.GroupBox();
			this.btnCalculo = new Sunny.UI.UISymbolButton();
			this.cbxCondicao = new System.Windows.Forms.ComboBox();
			this.labPagamento = new System.Windows.Forms.Label();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.txtValorTotal = new System.Windows.Forms.TextBox();
			this.labValorTotal = new System.Windows.Forms.Label();
			this.areaCabecalho.SuspendLayout();
			this.areaObservacoes.SuspendLayout();
			this.areaProdutos.SuspendLayout();
			this.areaConclusao.SuspendLayout();
			this.SuspendLayout();
			// 
			// areaCabecalho
			// 
			this.areaCabecalho.Controls.Add(this.cbxLoja);
			this.areaCabecalho.Controls.Add(this.labLoja);
			this.areaCabecalho.Controls.Add(this.txtDataCompra);
			this.areaCabecalho.Controls.Add(this.labDataCompra);
			this.areaCabecalho.Controls.Add(this.txtNomeFornecedor);
			this.areaCabecalho.Controls.Add(this.txtCodigoFornecedor);
			this.areaCabecalho.Controls.Add(this.labFornecedor);
			this.areaCabecalho.Location = new System.Drawing.Point(12, 12);
			this.areaCabecalho.Name = "areaCabecalho";
			this.areaCabecalho.Size = new System.Drawing.Size(529, 82);
			this.areaCabecalho.TabIndex = 0;
			this.areaCabecalho.TabStop = false;
			this.areaCabecalho.Text = "Cabeçalho";
			// 
			// cbxLoja
			// 
			this.cbxLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxLoja.FormattingEnabled = true;
			this.cbxLoja.Location = new System.Drawing.Point(343, 18);
			this.cbxLoja.Name = "cbxLoja";
			this.cbxLoja.Size = new System.Drawing.Size(180, 24);
			this.cbxLoja.TabIndex = 1;
			// 
			// labLoja
			// 
			this.labLoja.Location = new System.Drawing.Point(280, 19);
			this.labLoja.Name = "labLoja";
			this.labLoja.Size = new System.Drawing.Size(57, 23);
			this.labLoja.TabIndex = 5;
			this.labLoja.Text = "Loja : ";
			this.labLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDataCompra
			// 
			this.txtDataCompra.Location = new System.Drawing.Point(145, 19);
			this.txtDataCompra.Name = "txtDataCompra";
			this.txtDataCompra.Size = new System.Drawing.Size(129, 23);
			this.txtDataCompra.TabIndex = 0;
			this.txtDataCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDataCompra.TextChanged += new System.EventHandler(this.maskData);
			this.txtDataCompra.Leave += new System.EventHandler(this.maskDataAux);
			// 
			// labDataCompra
			// 
			this.labDataCompra.Location = new System.Drawing.Point(6, 19);
			this.labDataCompra.Name = "labDataCompra";
			this.labDataCompra.Size = new System.Drawing.Size(133, 23);
			this.labDataCompra.TabIndex = 3;
			this.labDataCompra.Text = "Data da Compra :";
			this.labDataCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNomeFornecedor
			// 
			this.txtNomeFornecedor.Location = new System.Drawing.Point(226, 48);
			this.txtNomeFornecedor.Name = "txtNomeFornecedor";
			this.txtNomeFornecedor.ReadOnly = true;
			this.txtNomeFornecedor.Size = new System.Drawing.Size(297, 23);
			this.txtNomeFornecedor.TabIndex = 2;
			this.txtNomeFornecedor.TabStop = false;
			// 
			// txtCodigoFornecedor
			// 
			this.txtCodigoFornecedor.Location = new System.Drawing.Point(145, 48);
			this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
			this.txtCodigoFornecedor.Size = new System.Drawing.Size(75, 23);
			this.txtCodigoFornecedor.TabIndex = 2;
			this.txtCodigoFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCodigoFornecedor.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCodigoFornecedor.Leave += new System.EventHandler(this.showCliente);
			this.txtCodigoFornecedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.buscarCliente);
			// 
			// labFornecedor
			// 
			this.labFornecedor.Location = new System.Drawing.Point(6, 48);
			this.labFornecedor.Name = "labFornecedor";
			this.labFornecedor.Size = new System.Drawing.Size(133, 23);
			this.labFornecedor.TabIndex = 0;
			this.labFornecedor.Text = "Cód. Fornecedor :";
			this.labFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// areaObservacoes
			// 
			this.areaObservacoes.Controls.Add(this.txtObservacao);
			this.areaObservacoes.Location = new System.Drawing.Point(547, 12);
			this.areaObservacoes.Name = "areaObservacoes";
			this.areaObservacoes.Size = new System.Drawing.Size(303, 82);
			this.areaObservacoes.TabIndex = 1;
			this.areaObservacoes.TabStop = false;
			this.areaObservacoes.Text = "Observações";
			// 
			// txtObservacao
			// 
			this.txtObservacao.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtObservacao.Location = new System.Drawing.Point(3, 19);
			this.txtObservacao.MaxLength = 200;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(297, 60);
			this.txtObservacao.TabIndex = 3;
			// 
			// areaProdutos
			// 
			this.areaProdutos.Controls.Add(this.btnClearProduto);
			this.areaProdutos.Controls.Add(this.btnDelProduto);
			this.areaProdutos.Controls.Add(this.listProduto);
			this.areaProdutos.Controls.Add(this.btnAddProduto);
			this.areaProdutos.Controls.Add(this.txtPreco);
			this.areaProdutos.Controls.Add(this.labPreco);
			this.areaProdutos.Controls.Add(this.txtQuantidade);
			this.areaProdutos.Controls.Add(this.labQuantidade);
			this.areaProdutos.Controls.Add(this.txtProduto);
			this.areaProdutos.Controls.Add(this.labProduto);
			this.areaProdutos.Location = new System.Drawing.Point(12, 100);
			this.areaProdutos.Name = "areaProdutos";
			this.areaProdutos.Size = new System.Drawing.Size(838, 267);
			this.areaProdutos.TabIndex = 2;
			this.areaProdutos.TabStop = false;
			this.areaProdutos.Text = "Produtos";
			// 
			// btnClearProduto
			// 
			this.btnClearProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClearProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnClearProduto.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnClearProduto.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnClearProduto.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnClearProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnClearProduto.Location = new System.Drawing.Point(7, 77);
			this.btnClearProduto.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnClearProduto.Name = "btnClearProduto";
			this.btnClearProduto.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnClearProduto.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnClearProduto.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnClearProduto.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnClearProduto.Size = new System.Drawing.Size(81, 23);
			this.btnClearProduto.Style = Sunny.UI.UIStyle.Red;
			this.btnClearProduto.Symbol = 61543;
			this.btnClearProduto.SymbolSize = 0;
			this.btnClearProduto.TabIndex = 10;
			this.btnClearProduto.Text = "Limpar";
			this.btnClearProduto.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnClearProduto.Click += new System.EventHandler(this.limparProdutoClique);
			// 
			// btnDelProduto
			// 
			this.btnDelProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnDelProduto.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnDelProduto.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDelProduto.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnDelProduto.Location = new System.Drawing.Point(7, 48);
			this.btnDelProduto.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnDelProduto.Name = "btnDelProduto";
			this.btnDelProduto.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnDelProduto.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnDelProduto.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDelProduto.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnDelProduto.Size = new System.Drawing.Size(81, 23);
			this.btnDelProduto.Style = Sunny.UI.UIStyle.Red;
			this.btnDelProduto.Symbol = 61543;
			this.btnDelProduto.SymbolSize = 0;
			this.btnDelProduto.TabIndex = 9;
			this.btnDelProduto.Text = "Excluir";
			this.btnDelProduto.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnDelProduto.Click += new System.EventHandler(this.excluirProdutoClique);
			// 
			// listProduto
			// 
			this.listProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.PCol1,
									this.PCol2,
									this.PCol3,
									this.PCol4});
			this.listProduto.FullRowSelect = true;
			this.listProduto.GridLines = true;
			this.listProduto.Location = new System.Drawing.Point(94, 48);
			this.listProduto.MultiSelect = false;
			this.listProduto.Name = "listProduto";
			this.listProduto.Size = new System.Drawing.Size(738, 213);
			this.listProduto.TabIndex = 8;
			this.listProduto.UseCompatibleStateImageBehavior = false;
			this.listProduto.View = System.Windows.Forms.View.Details;
			// 
			// PCol1
			// 
			this.PCol1.Text = "Quantidade";
			this.PCol1.Width = 90;
			// 
			// PCol2
			// 
			this.PCol2.Text = "Descrição";
			this.PCol2.Width = 300;
			// 
			// PCol3
			// 
			this.PCol3.Text = "Preço Unitário";
			this.PCol3.Width = 100;
			// 
			// PCol4
			// 
			this.PCol4.Text = "Totais (R$)";
			this.PCol4.Width = 120;
			// 
			// btnAddProduto
			// 
			this.btnAddProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAddProduto.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAddProduto.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAddProduto.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAddProduto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddProduto.Location = new System.Drawing.Point(773, 19);
			this.btnAddProduto.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAddProduto.Name = "btnAddProduto";
			this.btnAddProduto.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAddProduto.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAddProduto.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAddProduto.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAddProduto.Size = new System.Drawing.Size(59, 23);
			this.btnAddProduto.Style = Sunny.UI.UIStyle.Green;
			this.btnAddProduto.Symbol = 61543;
			this.btnAddProduto.SymbolSize = 0;
			this.btnAddProduto.TabIndex = 7;
			this.btnAddProduto.Text = "+";
			this.btnAddProduto.Click += new System.EventHandler(this.adicionarProdutoClique);
			// 
			// txtPreco
			// 
			this.txtPreco.Location = new System.Drawing.Point(695, 19);
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(72, 23);
			this.txtPreco.TabIndex = 6;
			this.txtPreco.TextChanged += new System.EventHandler(this.maskfloat);
			this.txtPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterProduto);
			// 
			// labPreco
			// 
			this.labPreco.Location = new System.Drawing.Point(632, 18);
			this.labPreco.Name = "labPreco";
			this.labPreco.Size = new System.Drawing.Size(57, 24);
			this.labPreco.TabIndex = 9;
			this.labPreco.Text = "Preço :";
			this.labPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(554, 18);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(72, 23);
			this.txtQuantidade.TabIndex = 5;
			this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtQuantidade.TextChanged += new System.EventHandler(this.maskQuantidade);
			this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterProduto);
			// 
			// labQuantidade
			// 
			this.labQuantidade.Location = new System.Drawing.Point(482, 18);
			this.labQuantidade.Name = "labQuantidade";
			this.labQuantidade.Size = new System.Drawing.Size(66, 24);
			this.labQuantidade.TabIndex = 8;
			this.labQuantidade.Text = "Quant. :";
			this.labQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtProduto
			// 
			this.txtProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtProduto.FormattingEnabled = true;
			this.txtProduto.Location = new System.Drawing.Point(94, 18);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(382, 24);
			this.txtProduto.TabIndex = 4;
			this.txtProduto.SelectedIndexChanged += new System.EventHandler(this.mudarInfo);
			this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnterProduto);
			// 
			// labProduto
			// 
			this.labProduto.Location = new System.Drawing.Point(6, 19);
			this.labProduto.Name = "labProduto";
			this.labProduto.Size = new System.Drawing.Size(81, 23);
			this.labProduto.TabIndex = 7;
			this.labProduto.Text = "Produto :";
			this.labProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// areaConclusao
			// 
			this.areaConclusao.Controls.Add(this.btnCalculo);
			this.areaConclusao.Controls.Add(this.cbxCondicao);
			this.areaConclusao.Controls.Add(this.labPagamento);
			this.areaConclusao.Controls.Add(this.btnCancelar);
			this.areaConclusao.Controls.Add(this.btnSalvar);
			this.areaConclusao.Controls.Add(this.txtValorTotal);
			this.areaConclusao.Controls.Add(this.labValorTotal);
			this.areaConclusao.Location = new System.Drawing.Point(12, 373);
			this.areaConclusao.Name = "areaConclusao";
			this.areaConclusao.Size = new System.Drawing.Size(838, 57);
			this.areaConclusao.TabIndex = 4;
			this.areaConclusao.TabStop = false;
			this.areaConclusao.Text = "Conclusão e Conferência";
			// 
			// btnCalculo
			// 
			this.btnCalculo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCalculo.Location = new System.Drawing.Point(554, 17);
			this.btnCalculo.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCalculo.Name = "btnCalculo";
			this.btnCalculo.Size = new System.Drawing.Size(44, 31);
			this.btnCalculo.Symbol = 61932;
			this.btnCalculo.TabIndex = 22;
			this.btnCalculo.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCalculo.Click += new System.EventHandler(this.calculoClique);
			// 
			// cbxCondicao
			// 
			this.cbxCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCondicao.FormattingEnabled = true;
			this.cbxCondicao.Location = new System.Drawing.Point(336, 20);
			this.cbxCondicao.Name = "cbxCondicao";
			this.cbxCondicao.Size = new System.Drawing.Size(212, 24);
			this.cbxCondicao.TabIndex = 6;
			// 
			// labPagamento
			// 
			this.labPagamento.Location = new System.Drawing.Point(235, 20);
			this.labPagamento.Name = "labPagamento";
			this.labPagamento.Size = new System.Drawing.Size(99, 23);
			this.labPagamento.TabIndex = 21;
			this.labPagamento.Text = "Pagamento :";
			this.labPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCancelar.Location = new System.Drawing.Point(604, 17);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Size = new System.Drawing.Size(121, 31);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 20;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCancelar.Click += new System.EventHandler(this.cancelarClique);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnSalvar.Location = new System.Drawing.Point(731, 17);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(100, 31);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 11;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnSalvar.Click += new System.EventHandler(this.continuarClique);
			// 
			// txtValorTotal
			// 
			this.txtValorTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtValorTotal.Location = new System.Drawing.Point(94, 20);
			this.txtValorTotal.Name = "txtValorTotal";
			this.txtValorTotal.ReadOnly = true;
			this.txtValorTotal.Size = new System.Drawing.Size(138, 23);
			this.txtValorTotal.TabIndex = 19;
			// 
			// labValorTotal
			// 
			this.labValorTotal.Location = new System.Drawing.Point(6, 20);
			this.labValorTotal.Name = "labValorTotal";
			this.labValorTotal.Size = new System.Drawing.Size(82, 23);
			this.labValorTotal.TabIndex = 6;
			this.labValorTotal.Text = "Total (R$) :";
			this.labValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CDCompra
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(862, 443);
			this.Controls.Add(this.areaConclusao);
			this.Controls.Add(this.areaProdutos);
			this.Controls.Add(this.areaObservacoes);
			this.Controls.Add(this.areaCabecalho);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CDCompra";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de compra - 1 DE 2";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.areaCabecalho.ResumeLayout(false);
			this.areaCabecalho.PerformLayout();
			this.areaObservacoes.ResumeLayout(false);
			this.areaObservacoes.PerformLayout();
			this.areaProdutos.ResumeLayout(false);
			this.areaProdutos.PerformLayout();
			this.areaConclusao.ResumeLayout(false);
			this.areaConclusao.PerformLayout();
			this.ResumeLayout(false);
		}
		private Sunny.UI.UISymbolButton btnCalculo;
		private System.Windows.Forms.Label labPagamento;
		private System.Windows.Forms.ComboBox cbxCondicao;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private System.Windows.Forms.Label labValorTotal;
		private System.Windows.Forms.TextBox txtValorTotal;
		private System.Windows.Forms.GroupBox areaConclusao;
		private Sunny.UI.UISymbolButton btnDelProduto;
		private Sunny.UI.UISymbolButton btnClearProduto;
		private System.Windows.Forms.ColumnHeader PCol4;
		private System.Windows.Forms.ColumnHeader PCol3;
		private System.Windows.Forms.ColumnHeader PCol2;
		private System.Windows.Forms.ColumnHeader PCol1;
		private System.Windows.Forms.ListView listProduto;
		private Sunny.UI.UISymbolButton btnAddProduto;
		private System.Windows.Forms.Label labQuantidade;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.Label labPreco;
		private System.Windows.Forms.TextBox txtPreco;
		private System.Windows.Forms.Label labProduto;
		private System.Windows.Forms.ComboBox txtProduto;
		private System.Windows.Forms.GroupBox areaProdutos;
		private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.GroupBox areaObservacoes;
		private System.Windows.Forms.Label labDataCompra;
		private System.Windows.Forms.TextBox txtDataCompra;
		private System.Windows.Forms.Label labLoja;
		private System.Windows.Forms.ComboBox cbxLoja;
		private System.Windows.Forms.Label labFornecedor;
		private System.Windows.Forms.TextBox txtCodigoFornecedor;
		private System.Windows.Forms.TextBox txtNomeFornecedor;
		private System.Windows.Forms.GroupBox areaCabecalho;
	}
}
