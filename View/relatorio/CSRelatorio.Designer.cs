
namespace GM.View.relatorio
{
	partial class CSRelatorio
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
			this.listaRelatorios = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.gpxSelecionado = new System.Windows.Forms.GroupBox();
			this.gerarGrafico = new Sunny.UI.UISymbolButton();
			this.gerarWeb = new Sunny.UI.UISymbolButton();
			this.gerarTabela = new Sunny.UI.UISymbolButton();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.gpxFerramentas = new System.Windows.Forms.GroupBox();
			this.btnRemover = new Sunny.UI.UISymbolButton();
			this.btnEditar = new Sunny.UI.UISymbolButton();
			this.btnNovo = new Sunny.UI.UISymbolButton();
			this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
			this.gpxSelecionado.SuspendLayout();
			this.gpxFerramentas.SuspendLayout();
			this.SuspendLayout();
			// 
			// listaRelatorios
			// 
			this.listaRelatorios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01});
			this.listaRelatorios.FullRowSelect = true;
			this.listaRelatorios.GridLines = true;
			this.listaRelatorios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listaRelatorios.Location = new System.Drawing.Point(12, 12);
			this.listaRelatorios.MultiSelect = false;
			this.listaRelatorios.Name = "listaRelatorios";
			this.listaRelatorios.Size = new System.Drawing.Size(320, 379);
			this.listaRelatorios.TabIndex = 0;
			this.listaRelatorios.UseCompatibleStateImageBehavior = false;
			this.listaRelatorios.View = System.Windows.Forms.View.Details;
			this.listaRelatorios.SelectedIndexChanged += new System.EventHandler(this.mudancaSelecionado);
			// 
			// Col01
			// 
			this.Col01.Text = "Descrição";
			this.Col01.Width = 290;
			// 
			// gpxSelecionado
			// 
			this.gpxSelecionado.Controls.Add(this.uiSymbolButton1);
			this.gpxSelecionado.Controls.Add(this.gerarGrafico);
			this.gpxSelecionado.Controls.Add(this.gerarWeb);
			this.gpxSelecionado.Controls.Add(this.gerarTabela);
			this.gpxSelecionado.Controls.Add(this.txtObservacao);
			this.gpxSelecionado.Controls.Add(this.txtDescricao);
			this.gpxSelecionado.Location = new System.Drawing.Point(338, 63);
			this.gpxSelecionado.Name = "gpxSelecionado";
			this.gpxSelecionado.Size = new System.Drawing.Size(284, 328);
			this.gpxSelecionado.TabIndex = 1;
			this.gpxSelecionado.TabStop = false;
			this.gpxSelecionado.Text = "Relatório Selecionado";
			// 
			// gerarGrafico
			// 
			this.gerarGrafico.Cursor = System.Windows.Forms.Cursors.Hand;
			this.gerarGrafico.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.gerarGrafico.Location = new System.Drawing.Point(134, 241);
			this.gerarGrafico.MinimumSize = new System.Drawing.Size(1, 1);
			this.gerarGrafico.Name = "gerarGrafico";
			this.gerarGrafico.Size = new System.Drawing.Size(144, 29);
			this.gerarGrafico.SymbolSize = 0;
			this.gerarGrafico.TabIndex = 25;
			this.gerarGrafico.Text = " Gerar em gráfico";
			this.gerarGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.gerarGrafico.Click += new System.EventHandler(this.cliqueGerarGrafico);
			// 
			// gerarWeb
			// 
			this.gerarWeb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.gerarWeb.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.gerarWeb.Location = new System.Drawing.Point(134, 206);
			this.gerarWeb.MinimumSize = new System.Drawing.Size(1, 1);
			this.gerarWeb.Name = "gerarWeb";
			this.gerarWeb.Size = new System.Drawing.Size(144, 29);
			this.gerarWeb.SymbolSize = 0;
			this.gerarWeb.TabIndex = 24;
			this.gerarWeb.Text = " Gerar em Web";
			this.gerarWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.gerarWeb.Click += new System.EventHandler(this.cliqueGerarWeb);
			// 
			// gerarTabela
			// 
			this.gerarTabela.Cursor = System.Windows.Forms.Cursors.Hand;
			this.gerarTabela.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.gerarTabela.Location = new System.Drawing.Point(134, 171);
			this.gerarTabela.MinimumSize = new System.Drawing.Size(1, 1);
			this.gerarTabela.Name = "gerarTabela";
			this.gerarTabela.Size = new System.Drawing.Size(144, 29);
			this.gerarTabela.SymbolSize = 0;
			this.gerarTabela.TabIndex = 23;
			this.gerarTabela.Text = " Gerar em tabela";
			this.gerarTabela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.gerarTabela.Click += new System.EventHandler(this.cliqueGerarTabela);
			// 
			// txtObservacao
			// 
			this.txtObservacao.BackColor = System.Drawing.Color.White;
			this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.txtObservacao.Location = new System.Drawing.Point(6, 52);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(272, 113);
			this.txtObservacao.TabIndex = 23;
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.White;
			this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.txtDescricao.Location = new System.Drawing.Point(6, 24);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(272, 22);
			this.txtDescricao.TabIndex = 22;
			// 
			// gpxFerramentas
			// 
			this.gpxFerramentas.Controls.Add(this.btnRemover);
			this.gpxFerramentas.Controls.Add(this.btnEditar);
			this.gpxFerramentas.Controls.Add(this.btnNovo);
			this.gpxFerramentas.Location = new System.Drawing.Point(338, 3);
			this.gpxFerramentas.Name = "gpxFerramentas";
			this.gpxFerramentas.Size = new System.Drawing.Size(284, 54);
			this.gpxFerramentas.TabIndex = 2;
			this.gpxFerramentas.TabStop = false;
			this.gpxFerramentas.Text = "Ferramentas";
			// 
			// btnRemover
			// 
			this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnRemover.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnRemover.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnRemover.Location = new System.Drawing.Point(156, 19);
			this.btnRemover.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnRemover.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnRemover.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.Size = new System.Drawing.Size(122, 29);
			this.btnRemover.Style = Sunny.UI.UIStyle.Red;
			this.btnRemover.SymbolSize = 0;
			this.btnRemover.TabIndex = 22;
			this.btnRemover.Text = "Remover";
			this.btnRemover.Click += new System.EventHandler(this.cliqueRemover);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnEditar.Location = new System.Drawing.Point(82, 19);
			this.btnEditar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(68, 29);
			this.btnEditar.SymbolSize = 0;
			this.btnEditar.TabIndex = 21;
			this.btnEditar.Text = "Editar";
			this.btnEditar.Click += new System.EventHandler(this.cliqueEditar);
			// 
			// btnNovo
			// 
			this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNovo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnNovo.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnNovo.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnNovo.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnNovo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnNovo.Location = new System.Drawing.Point(6, 19);
			this.btnNovo.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnNovo.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnNovo.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnNovo.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnNovo.Size = new System.Drawing.Size(70, 29);
			this.btnNovo.Style = Sunny.UI.UIStyle.Green;
			this.btnNovo.SymbolSize = 0;
			this.btnNovo.TabIndex = 20;
			this.btnNovo.Text = "Novo";
			this.btnNovo.Click += new System.EventHandler(this.cliqueNovo);
			// 
			// uiSymbolButton1
			// 
			this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.uiSymbolButton1.Location = new System.Drawing.Point(134, 276);
			this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiSymbolButton1.Name = "uiSymbolButton1";
			this.uiSymbolButton1.Size = new System.Drawing.Size(144, 29);
			this.uiSymbolButton1.SymbolSize = 0;
			this.uiSymbolButton1.TabIndex = 26;
			this.uiSymbolButton1.Text = " Gerar em teste";
			this.uiSymbolButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.uiSymbolButton1.Click += new System.EventHandler(this.UiSymbolButton1Click);
			// 
			// CSRelatorio
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(634, 403);
			this.Controls.Add(this.gpxFerramentas);
			this.Controls.Add(this.gpxSelecionado);
			this.Controls.Add(this.listaRelatorios);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CSRelatorio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de relatórios";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.gpxSelecionado.ResumeLayout(false);
			this.gpxSelecionado.PerformLayout();
			this.gpxFerramentas.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private Sunny.UI.UISymbolButton uiSymbolButton1;
		private Sunny.UI.UISymbolButton gerarTabela;
		private Sunny.UI.UISymbolButton gerarWeb;
		private Sunny.UI.UISymbolButton gerarGrafico;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.TextBox txtObservacao;
		private Sunny.UI.UISymbolButton btnRemover;
		private Sunny.UI.UISymbolButton btnNovo;
		private Sunny.UI.UISymbolButton btnEditar;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.GroupBox gpxFerramentas;
		private System.Windows.Forms.GroupBox gpxSelecionado;
		private System.Windows.Forms.ListView listaRelatorios;
	}
}
