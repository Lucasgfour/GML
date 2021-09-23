
namespace GM
{
	partial class Home
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
			this.labNomeUsuario = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnTeste = new System.Windows.Forms.Button();
			this.btnFamilia = new System.Windows.Forms.Button();
			this.btnProduto = new System.Windows.Forms.Button();
			this.btnPessoa = new System.Windows.Forms.Button();
			this.novaCompra = new System.Windows.Forms.Button();
			this.btnCondicao = new System.Windows.Forms.Button();
			this.btnPagar = new System.Windows.Forms.Button();
			this.btnEstoque = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnContaReceber = new System.Windows.Forms.Button();
			this.btnCustoDespesa = new System.Windows.Forms.Button();
			this.btnRelatorio = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labNomeUsuario
			// 
			this.labNomeUsuario.BackColor = System.Drawing.Color.Transparent;
			this.labNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labNomeUsuario.Location = new System.Drawing.Point(12, 423);
			this.labNomeUsuario.Name = "labNomeUsuario";
			this.labNomeUsuario.Size = new System.Drawing.Size(277, 28);
			this.labNomeUsuario.TabIndex = 6;
			this.labNomeUsuario.Text = "Nome de usuário";
			this.labNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnTeste
			// 
			this.btnTeste.Location = new System.Drawing.Point(12, 12);
			this.btnTeste.Name = "btnTeste";
			this.btnTeste.Size = new System.Drawing.Size(174, 23);
			this.btnTeste.TabIndex = 7;
			this.btnTeste.Text = "button1";
			this.btnTeste.UseVisualStyleBackColor = true;
			this.btnTeste.Click += new System.EventHandler(this.BtnTesteClick);
			// 
			// btnFamilia
			// 
			this.btnFamilia.Location = new System.Drawing.Point(648, 41);
			this.btnFamilia.Name = "btnFamilia";
			this.btnFamilia.Size = new System.Drawing.Size(174, 23);
			this.btnFamilia.TabIndex = 8;
			this.btnFamilia.Text = "Família";
			this.btnFamilia.UseVisualStyleBackColor = true;
			this.btnFamilia.Click += new System.EventHandler(this.familiaClique);
			// 
			// btnProduto
			// 
			this.btnProduto.Location = new System.Drawing.Point(648, 70);
			this.btnProduto.Name = "btnProduto";
			this.btnProduto.Size = new System.Drawing.Size(174, 23);
			this.btnProduto.TabIndex = 9;
			this.btnProduto.Text = "Produto";
			this.btnProduto.UseVisualStyleBackColor = true;
			this.btnProduto.Click += new System.EventHandler(this.produtoClique);
			// 
			// btnPessoa
			// 
			this.btnPessoa.Location = new System.Drawing.Point(648, 99);
			this.btnPessoa.Name = "btnPessoa";
			this.btnPessoa.Size = new System.Drawing.Size(174, 23);
			this.btnPessoa.TabIndex = 10;
			this.btnPessoa.Text = "Pessoa";
			this.btnPessoa.UseVisualStyleBackColor = true;
			this.btnPessoa.Click += new System.EventHandler(this.pessoaClique);
			// 
			// novaCompra
			// 
			this.novaCompra.Location = new System.Drawing.Point(648, 128);
			this.novaCompra.Name = "novaCompra";
			this.novaCompra.Size = new System.Drawing.Size(174, 23);
			this.novaCompra.TabIndex = 12;
			this.novaCompra.Text = "Compra";
			this.novaCompra.UseVisualStyleBackColor = true;
			this.novaCompra.Click += new System.EventHandler(this.abrirCompra);
			// 
			// btnCondicao
			// 
			this.btnCondicao.Location = new System.Drawing.Point(648, 157);
			this.btnCondicao.Name = "btnCondicao";
			this.btnCondicao.Size = new System.Drawing.Size(174, 23);
			this.btnCondicao.TabIndex = 13;
			this.btnCondicao.Text = "Condição de Pagamento";
			this.btnCondicao.UseVisualStyleBackColor = true;
			this.btnCondicao.Click += new System.EventHandler(this.condicaoClique);
			// 
			// btnPagar
			// 
			this.btnPagar.Location = new System.Drawing.Point(648, 186);
			this.btnPagar.Name = "btnPagar";
			this.btnPagar.Size = new System.Drawing.Size(174, 23);
			this.btnPagar.TabIndex = 14;
			this.btnPagar.Text = "Contas a pagar";
			this.btnPagar.UseVisualStyleBackColor = true;
			this.btnPagar.Click += new System.EventHandler(this.BtnPagarClick);
			// 
			// btnEstoque
			// 
			this.btnEstoque.Location = new System.Drawing.Point(648, 244);
			this.btnEstoque.Name = "btnEstoque";
			this.btnEstoque.Size = new System.Drawing.Size(174, 23);
			this.btnEstoque.TabIndex = 15;
			this.btnEstoque.Text = "Estoque";
			this.btnEstoque.UseVisualStyleBackColor = true;
			this.btnEstoque.Click += new System.EventHandler(this.openEstoque);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(648, 273);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(174, 23);
			this.button2.TabIndex = 16;
			this.button2.Text = "Venda";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btnVenda);
			// 
			// btnContaReceber
			// 
			this.btnContaReceber.Location = new System.Drawing.Point(648, 215);
			this.btnContaReceber.Name = "btnContaReceber";
			this.btnContaReceber.Size = new System.Drawing.Size(174, 23);
			this.btnContaReceber.TabIndex = 17;
			this.btnContaReceber.Text = "Contas a receber";
			this.btnContaReceber.UseVisualStyleBackColor = true;
			this.btnContaReceber.Click += new System.EventHandler(this.cliqueReceber);
			// 
			// btnCustoDespesa
			// 
			this.btnCustoDespesa.Location = new System.Drawing.Point(648, 302);
			this.btnCustoDespesa.Name = "btnCustoDespesa";
			this.btnCustoDespesa.Size = new System.Drawing.Size(174, 23);
			this.btnCustoDespesa.TabIndex = 18;
			this.btnCustoDespesa.Text = "Custo / Despesa";
			this.btnCustoDespesa.UseVisualStyleBackColor = true;
			this.btnCustoDespesa.Click += new System.EventHandler(this.cliqueCustoDespesa);
			// 
			// btnRelatorio
			// 
			this.btnRelatorio.Location = new System.Drawing.Point(12, 70);
			this.btnRelatorio.Name = "btnRelatorio";
			this.btnRelatorio.Size = new System.Drawing.Size(174, 23);
			this.btnRelatorio.TabIndex = 19;
			this.btnRelatorio.Text = "Relatório";
			this.btnRelatorio.UseVisualStyleBackColor = true;
			this.btnRelatorio.Click += new System.EventHandler(this.openRelatorio);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(648, 331);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(174, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "Usuário";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.openUsuraio);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(648, 360);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(174, 23);
			this.button3.TabIndex = 21;
			this.button3.Text = "Telas";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.openTela);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 99);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(174, 23);
			this.button4.TabIndex = 22;
			this.button4.Text = "Configuracoes";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.openConfiguracoes);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 460);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnRelatorio);
			this.Controls.Add(this.btnCustoDespesa);
			this.Controls.Add(this.btnContaReceber);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnEstoque);
			this.Controls.Add(this.btnPagar);
			this.Controls.Add(this.btnCondicao);
			this.Controls.Add(this.novaCompra);
			this.Controls.Add(this.btnPessoa);
			this.Controls.Add(this.btnProduto);
			this.Controls.Add(this.btnFamilia);
			this.Controls.Add(this.btnTeste);
			this.Controls.Add(this.labNomeUsuario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GM - Página inicial";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sair);
			this.Load += new System.EventHandler(this.Arranque);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnRelatorio;
		private System.Windows.Forms.Button btnCustoDespesa;
		private System.Windows.Forms.Button btnContaReceber;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnEstoque;
		private System.Windows.Forms.Button btnPagar;
		private System.Windows.Forms.Button btnCondicao;
		private System.Windows.Forms.Button novaCompra;
		private System.Windows.Forms.Button btnPessoa;
		private System.Windows.Forms.Button btnProduto;
		private System.Windows.Forms.Button btnFamilia;
		private System.Windows.Forms.Button btnTeste;
		private ReaLTaiizor.Controls.DungeonLabel labNomeUsuario;
	}
}
