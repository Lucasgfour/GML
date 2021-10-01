
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSRelatorio));
			this.listaRelatorios = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.gpxSelecionado = new System.Windows.Forms.GroupBox();
			this.txtObservacao = new GM.Componentes.MinBox();
			this.txtDescricao = new GM.Componentes.MinBox();
			this.gpxFerramentas = new System.Windows.Forms.GroupBox();
			this.btnRemover = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnTabela = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnWeb = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnGrafico = new MaterialSkin.Controls.MaterialRaisedButton();
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
			this.listaRelatorios.Location = new System.Drawing.Point(12, 78);
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
			this.gpxSelecionado.BackColor = System.Drawing.Color.Transparent;
			this.gpxSelecionado.Controls.Add(this.btnGrafico);
			this.gpxSelecionado.Controls.Add(this.btnWeb);
			this.gpxSelecionado.Controls.Add(this.btnTabela);
			this.gpxSelecionado.Controls.Add(this.txtObservacao);
			this.gpxSelecionado.Controls.Add(this.txtDescricao);
			this.gpxSelecionado.Location = new System.Drawing.Point(338, 129);
			this.gpxSelecionado.Name = "gpxSelecionado";
			this.gpxSelecionado.Size = new System.Drawing.Size(284, 328);
			this.gpxSelecionado.TabIndex = 1;
			this.gpxSelecionado.TabStop = false;
			this.gpxSelecionado.Text = "Relatório Selecionado";
			// 
			// txtObservacao
			// 
			this.txtObservacao.BackColor = System.Drawing.Color.White;
			this.txtObservacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtObservacao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtObservacao.CustomBGColor = System.Drawing.Color.White;
			this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.txtObservacao.ForeColor = System.Drawing.Color.Black;
			this.txtObservacao.Location = new System.Drawing.Point(6, 52);
			this.txtObservacao.MaxLength = 32767;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.ReadOnly = false;
			this.txtObservacao.SelectionStart = 0;
			this.txtObservacao.Size = new System.Drawing.Size(272, 113);
			this.txtObservacao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtObservacao.TabIndex = 23;
			this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtObservacao.UseSystemPasswordChar = false;
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.White;
			this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDescricao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CustomBGColor = System.Drawing.Color.White;
			this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.txtDescricao.ForeColor = System.Drawing.Color.Black;
			this.txtDescricao.Location = new System.Drawing.Point(6, 24);
			this.txtDescricao.MaxLength = 32767;
			this.txtDescricao.Multiline = false;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.ReadOnly = false;
			this.txtDescricao.SelectionStart = 0;
			this.txtDescricao.Size = new System.Drawing.Size(272, 25);
			this.txtDescricao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDescricao.TabIndex = 22;
			this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.UseSystemPasswordChar = false;
			// 
			// gpxFerramentas
			// 
			this.gpxFerramentas.BackColor = System.Drawing.Color.Transparent;
			this.gpxFerramentas.Controls.Add(this.btnRemover);
			this.gpxFerramentas.Controls.Add(this.btnEditar);
			this.gpxFerramentas.Controls.Add(this.btnAdicionar);
			this.gpxFerramentas.Location = new System.Drawing.Point(338, 69);
			this.gpxFerramentas.Name = "gpxFerramentas";
			this.gpxFerramentas.Size = new System.Drawing.Size(284, 54);
			this.gpxFerramentas.TabIndex = 2;
			this.gpxFerramentas.TabStop = false;
			this.gpxFerramentas.Text = "Ferramentas";
			// 
			// btnRemover
			// 
			this.btnRemover.Depth = 0;
			this.btnRemover.Location = new System.Drawing.Point(181, 20);
			this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Primary = true;
			this.btnRemover.Size = new System.Drawing.Size(97, 28);
			this.btnRemover.TabIndex = 68;
			this.btnRemover.Text = "REMOVER";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Visible = false;
			this.btnRemover.Click += new System.EventHandler(this.cliqueRemover);
			// 
			// btnEditar
			// 
			this.btnEditar.Depth = 0;
			this.btnEditar.Location = new System.Drawing.Point(106, 20);
			this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Primary = true;
			this.btnEditar.Size = new System.Drawing.Size(69, 28);
			this.btnEditar.TabIndex = 67;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.cliqueEditar);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Depth = 0;
			this.btnAdicionar.Location = new System.Drawing.Point(6, 20);
			this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Primary = true;
			this.btnAdicionar.Size = new System.Drawing.Size(94, 28);
			this.btnAdicionar.TabIndex = 66;
			this.btnAdicionar.Text = "ADICIONAR";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueNovo);
			// 
			// btnTabela
			// 
			this.btnTabela.Depth = 0;
			this.btnTabela.Location = new System.Drawing.Point(6, 171);
			this.btnTabela.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnTabela.Name = "btnTabela";
			this.btnTabela.Primary = true;
			this.btnTabela.Size = new System.Drawing.Size(272, 28);
			this.btnTabela.TabIndex = 69;
			this.btnTabela.Text = "GERAR NA TELA";
			this.btnTabela.UseVisualStyleBackColor = true;
			this.btnTabela.Click += new System.EventHandler(this.cliqueGerarTabela);
			// 
			// btnWeb
			// 
			this.btnWeb.Depth = 0;
			this.btnWeb.Location = new System.Drawing.Point(6, 205);
			this.btnWeb.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnWeb.Name = "btnWeb";
			this.btnWeb.Primary = true;
			this.btnWeb.Size = new System.Drawing.Size(272, 28);
			this.btnWeb.TabIndex = 70;
			this.btnWeb.Text = "GERAR WEB";
			this.btnWeb.UseVisualStyleBackColor = true;
			this.btnWeb.Click += new System.EventHandler(this.cliqueGerarWeb);
			// 
			// btnGrafico
			// 
			this.btnGrafico.Depth = 0;
			this.btnGrafico.Location = new System.Drawing.Point(6, 239);
			this.btnGrafico.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnGrafico.Name = "btnGrafico";
			this.btnGrafico.Primary = true;
			this.btnGrafico.Size = new System.Drawing.Size(272, 28);
			this.btnGrafico.TabIndex = 71;
			this.btnGrafico.Text = "GERAR GRÁFICO";
			this.btnGrafico.UseVisualStyleBackColor = true;
			this.btnGrafico.Click += new System.EventHandler(this.cliqueGerarGrafico);
			// 
			// CSRelatorio
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(634, 469);
			this.Controls.Add(this.gpxFerramentas);
			this.Controls.Add(this.gpxSelecionado);
			this.Controls.Add(this.listaRelatorios);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CSRelatorio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de relatórios";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.gpxSelecionado.ResumeLayout(false);
			this.gpxFerramentas.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
		private MaterialSkin.Controls.MaterialRaisedButton btnTabela;
		private MaterialSkin.Controls.MaterialRaisedButton btnWeb;
		private MaterialSkin.Controls.MaterialRaisedButton btnGrafico;
		private GM.Componentes.MinBox txtDescricao;
		private GM.Componentes.MinBox txtObservacao;
		private MaterialSkin.Controls.MaterialRaisedButton btnRemover;
		private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.GroupBox gpxFerramentas;
		private System.Windows.Forms.GroupBox gpxSelecionado;
		private System.Windows.Forms.ListView listaRelatorios;
	}
}
