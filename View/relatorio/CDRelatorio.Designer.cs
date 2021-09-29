
namespace GM.View.relatorio
{
	partial class CDRelatorio
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
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.labDescricao = new System.Windows.Forms.Label();
			this.txtObservação = new System.Windows.Forms.TextBox();
			this.labObservacao = new System.Windows.Forms.Label();
			this.gpxComando = new System.Windows.Forms.GroupBox();
			this.txtComando = new System.Windows.Forms.TextBox();
			this.gpxParametro = new System.Windows.Forms.GroupBox();
			this.btnRemover = new Sunny.UI.UISymbolButton();
			this.btnAdicionar = new Sunny.UI.UISymbolButton();
			this.cbxTipo = new System.Windows.Forms.ComboBox();
			this.labTipo = new System.Windows.Forms.Label();
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.listaParametro = new System.Windows.Forms.ListView();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.labParametro = new System.Windows.Forms.Label();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.cbxNivel = new System.Windows.Forms.ComboBox();
			this.labNivel = new System.Windows.Forms.Label();
			this.gpxComando.SuspendLayout();
			this.gpxParametro.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.White;
			this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtDescricao.Location = new System.Drawing.Point(108, 9);
			this.txtDescricao.MaxLength = 70;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(594, 25);
			this.txtDescricao.TabIndex = 0;
			// 
			// labDescricao
			// 
			this.labDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDescricao.Location = new System.Drawing.Point(12, 9);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(90, 25);
			this.labDescricao.TabIndex = 19;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtObservação
			// 
			this.txtObservação.BackColor = System.Drawing.Color.White;
			this.txtObservação.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtObservação.Location = new System.Drawing.Point(108, 40);
			this.txtObservação.MaxLength = 70;
			this.txtObservação.Multiline = true;
			this.txtObservação.Name = "txtObservação";
			this.txtObservação.Size = new System.Drawing.Size(594, 60);
			this.txtObservação.TabIndex = 1;
			// 
			// labObservacao
			// 
			this.labObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labObservacao.Location = new System.Drawing.Point(12, 40);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(90, 25);
			this.labObservacao.TabIndex = 21;
			this.labObservacao.Text = "Observação :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gpxComando
			// 
			this.gpxComando.Controls.Add(this.txtComando);
			this.gpxComando.Location = new System.Drawing.Point(12, 106);
			this.gpxComando.Name = "gpxComando";
			this.gpxComando.Size = new System.Drawing.Size(690, 286);
			this.gpxComando.TabIndex = 201;
			this.gpxComando.TabStop = false;
			this.gpxComando.Text = "Comando SQL";
			// 
			// txtComando
			// 
			this.txtComando.BackColor = System.Drawing.Color.White;
			this.txtComando.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtComando.Location = new System.Drawing.Point(6, 22);
			this.txtComando.MaxLength = 1000;
			this.txtComando.Multiline = true;
			this.txtComando.Name = "txtComando";
			this.txtComando.Size = new System.Drawing.Size(678, 258);
			this.txtComando.TabIndex = 2;
			// 
			// gpxParametro
			// 
			this.gpxParametro.Controls.Add(this.btnRemover);
			this.gpxParametro.Controls.Add(this.btnAdicionar);
			this.gpxParametro.Controls.Add(this.cbxTipo);
			this.gpxParametro.Controls.Add(this.labTipo);
			this.gpxParametro.Controls.Add(this.txtParametro);
			this.gpxParametro.Controls.Add(this.listaParametro);
			this.gpxParametro.Controls.Add(this.labParametro);
			this.gpxParametro.Location = new System.Drawing.Point(12, 398);
			this.gpxParametro.Name = "gpxParametro";
			this.gpxParametro.Size = new System.Drawing.Size(466, 215);
			this.gpxParametro.TabIndex = 202;
			this.gpxParametro.TabStop = false;
			this.gpxParametro.Text = "Parâmetros";
			// 
			// btnRemover
			// 
			this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnRemover.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnRemover.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnRemover.Location = new System.Drawing.Point(210, 185);
			this.btnRemover.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Radius = 0;
			this.btnRemover.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnRemover.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnRemover.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnRemover.Size = new System.Drawing.Size(109, 24);
			this.btnRemover.Style = Sunny.UI.UIStyle.Red;
			this.btnRemover.SymbolSize = 0;
			this.btnRemover.TabIndex = 6;
			this.btnRemover.Text = "Remover";
			this.btnRemover.Click += new System.EventHandler(this.cliqueRemover);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAdicionar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAdicionar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnAdicionar.Location = new System.Drawing.Point(376, 86);
			this.btnAdicionar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Radius = 0;
			this.btnAdicionar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnAdicionar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnAdicionar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnAdicionar.Size = new System.Drawing.Size(84, 24);
			this.btnAdicionar.Style = Sunny.UI.UIStyle.Green;
			this.btnAdicionar.SymbolSize = 0;
			this.btnAdicionar.TabIndex = 5;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.Click += new System.EventHandler(this.cliqueAdicionar);
			// 
			// cbxTipo
			// 
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.Items.AddRange(new object[] {
									"TEXTO",
									"NÚMERO INTEIRO",
									"NÚMERO float",
									"DATA"});
			this.cbxTipo.Location = new System.Drawing.Point(306, 55);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(154, 25);
			this.cbxTipo.TabIndex = 4;
			this.cbxTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterParametro);
			// 
			// labTipo
			// 
			this.labTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTipo.Location = new System.Drawing.Point(210, 55);
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(90, 25);
			this.labTipo.TabIndex = 205;
			this.labTipo.Text = "Tipo :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtParametro
			// 
			this.txtParametro.BackColor = System.Drawing.Color.White;
			this.txtParametro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtParametro.Location = new System.Drawing.Point(306, 24);
			this.txtParametro.MaxLength = 70;
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.Size = new System.Drawing.Size(154, 25);
			this.txtParametro.TabIndex = 3;
			this.txtParametro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionarEnterParametro);
			// 
			// listaParametro
			// 
			this.listaParametro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02});
			this.listaParametro.FullRowSelect = true;
			this.listaParametro.GridLines = true;
			this.listaParametro.Location = new System.Drawing.Point(6, 24);
			this.listaParametro.MultiSelect = false;
			this.listaParametro.Name = "listaParametro";
			this.listaParametro.Size = new System.Drawing.Size(198, 185);
			this.listaParametro.TabIndex = 7;
			this.listaParametro.UseCompatibleStateImageBehavior = false;
			this.listaParametro.View = System.Windows.Forms.View.Details;
			// 
			// Col01
			// 
			this.Col01.Text = "Parâmetro";
			this.Col01.Width = 90;
			// 
			// Col02
			// 
			this.Col02.Text = "Tipo";
			this.Col02.Width = 80;
			// 
			// labParametro
			// 
			this.labParametro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labParametro.Location = new System.Drawing.Point(210, 24);
			this.labParametro.Name = "labParametro";
			this.labParametro.Size = new System.Drawing.Size(90, 25);
			this.labParametro.TabIndex = 204;
			this.labParametro.Text = "Parâmetro :";
			this.labParametro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(484, 584);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Size = new System.Drawing.Size(101, 29);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 10;
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
			this.btnSalvar.Location = new System.Drawing.Point(591, 584);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(111, 29);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 9;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// cbxNivel
			// 
			this.cbxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxNivel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbxNivel.FormattingEnabled = true;
			this.cbxNivel.Items.AddRange(new object[] {
									"Nível 0",
									"Nível 1",
									"Nível 2",
									"Nível 3",
									"Nível 4",
									"Nível 5",
									"Nível 6",
									"Nível 7",
									"Nível 8",
									"Nível 9",
									"Nível 10"});
			this.cbxNivel.Location = new System.Drawing.Point(517, 453);
			this.cbxNivel.Name = "cbxNivel";
			this.cbxNivel.Size = new System.Drawing.Size(154, 25);
			this.cbxNivel.TabIndex = 8;
			// 
			// labNivel
			// 
			this.labNivel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNivel.Location = new System.Drawing.Point(484, 407);
			this.labNivel.Name = "labNivel";
			this.labNivel.Size = new System.Drawing.Size(218, 40);
			this.labNivel.TabIndex = 209;
			this.labNivel.Text = "Nível de usuário necessário para gerar o relatório :";
			this.labNivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CDRelatorio
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(714, 625);
			this.Controls.Add(this.cbxNivel);
			this.Controls.Add(this.labNivel);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.gpxParametro);
			this.Controls.Add(this.gpxComando);
			this.Controls.Add(this.txtObservação);
			this.Controls.Add(this.labObservacao);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CDRelatorio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Relatório";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.gpxComando.ResumeLayout(false);
			this.gpxComando.PerformLayout();
			this.gpxParametro.ResumeLayout(false);
			this.gpxParametro.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labNivel;
		private System.Windows.Forms.ComboBox cbxNivel;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private Sunny.UI.UISymbolButton btnAdicionar;
		private Sunny.UI.UISymbolButton btnRemover;
		private System.Windows.Forms.ComboBox cbxTipo;
		private System.Windows.Forms.Label labParametro;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ListView listaParametro;
		private System.Windows.Forms.TextBox txtParametro;
		private System.Windows.Forms.Label labTipo;
		private System.Windows.Forms.GroupBox gpxParametro;
		private System.Windows.Forms.TextBox txtComando;
		private System.Windows.Forms.GroupBox gpxComando;
		private System.Windows.Forms.Label labObservacao;
		private System.Windows.Forms.TextBox txtObservação;
		private System.Windows.Forms.Label labDescricao;
		private System.Windows.Forms.TextBox txtDescricao;
	}
}
