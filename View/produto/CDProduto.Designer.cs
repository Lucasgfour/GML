
namespace GM.View.produto
{
	partial class CDProduto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDProduto));
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.labCodigo = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.cbxFamilia = new System.Windows.Forms.ComboBox();
			this.labFamilia = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.labValor = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.labDescricao = new ReaLTaiizor.Controls.DungeonLabel();
			this.labTitulo = new ReaLTaiizor.Controls.DungeonLabel();
			this.cbxSituacao = new System.Windows.Forms.ComboBox();
			this.labSituacao = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtUnidade = new System.Windows.Forms.TextBox();
			this.labUnidade = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtCodBarra = new System.Windows.Forms.TextBox();
			this.labCodBarra = new ReaLTaiizor.Controls.DungeonLabel();
			this.SuspendLayout();
			// 
			// txtCodigo
			// 
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigo.Location = new System.Drawing.Point(131, 81);
			this.txtCodigo.MaxLength = 20;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(141, 23);
			this.txtCodigo.TabIndex = 0;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCodigo.Location = new System.Drawing.Point(38, 81);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(85, 23);
			this.labCodigo.TabIndex = 29;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(188, 263);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Size = new System.Drawing.Size(129, 33);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Sair";
			this.btnCancelar.Click += new System.EventHandler(this.sairClique);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSalvar.Location = new System.Drawing.Point(324, 263);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(129, 33);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 7;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.salvarClique);
			// 
			// cbxFamilia
			// 
			this.cbxFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxFamilia.FormattingEnabled = true;
			this.cbxFamilia.Location = new System.Drawing.Point(131, 141);
			this.cbxFamilia.Name = "cbxFamilia";
			this.cbxFamilia.Size = new System.Drawing.Size(224, 23);
			this.cbxFamilia.TabIndex = 2;
			// 
			// labFamilia
			// 
			this.labFamilia.BackColor = System.Drawing.Color.Transparent;
			this.labFamilia.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labFamilia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labFamilia.Location = new System.Drawing.Point(38, 141);
			this.labFamilia.Name = "labFamilia";
			this.labFamilia.Size = new System.Drawing.Size(85, 24);
			this.labFamilia.TabIndex = 27;
			this.labFamilia.Text = "Família :";
			this.labFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtValor
			// 
			this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtValor.Location = new System.Drawing.Point(131, 203);
			this.txtValor.MaxLength = 15;
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(225, 23);
			this.txtValor.TabIndex = 5;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labValor
			// 
			this.labValor.BackColor = System.Drawing.Color.Transparent;
			this.labValor.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labValor.Location = new System.Drawing.Point(9, 203);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(114, 23);
			this.labValor.TabIndex = 26;
			this.labValor.Text = "Valor Unit. (R$) :";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescricao
			// 
			this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescricao.Location = new System.Drawing.Point(131, 111);
			this.txtDescricao.MaxLength = 100;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(323, 23);
			this.txtDescricao.TabIndex = 1;
			// 
			// labDescricao
			// 
			this.labDescricao.BackColor = System.Drawing.Color.Transparent;
			this.labDescricao.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labDescricao.Location = new System.Drawing.Point(38, 111);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(85, 23);
			this.labDescricao.TabIndex = 25;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labTitulo
			// 
			this.labTitulo.BackColor = System.Drawing.Color.Transparent;
			this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labTitulo.Location = new System.Drawing.Point(14, 10);
			this.labTitulo.Name = "labTitulo";
			this.labTitulo.Size = new System.Drawing.Size(440, 32);
			this.labTitulo.TabIndex = 23;
			this.labTitulo.Text = "Cadastro / Edição de Produto";
			this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbxSituacao
			// 
			this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSituacao.FormattingEnabled = true;
			this.cbxSituacao.Items.AddRange(new object[] {
									"SUSPENSO",
									"ATIVO"});
			this.cbxSituacao.Location = new System.Drawing.Point(244, 172);
			this.cbxSituacao.Name = "cbxSituacao";
			this.cbxSituacao.Size = new System.Drawing.Size(111, 23);
			this.cbxSituacao.TabIndex = 4;
			// 
			// labSituacao
			// 
			this.labSituacao.BackColor = System.Drawing.Color.Transparent;
			this.labSituacao.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSituacao.Location = new System.Drawing.Point(152, 172);
			this.labSituacao.Name = "labSituacao";
			this.labSituacao.Size = new System.Drawing.Size(85, 24);
			this.labSituacao.TabIndex = 31;
			this.labSituacao.Text = "Situação :";
			this.labSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUnidade
			// 
			this.txtUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUnidade.Location = new System.Drawing.Point(131, 172);
			this.txtUnidade.MaxLength = 2;
			this.txtUnidade.Name = "txtUnidade";
			this.txtUnidade.Size = new System.Drawing.Size(32, 23);
			this.txtUnidade.TabIndex = 3;
			// 
			// labUnidade
			// 
			this.labUnidade.BackColor = System.Drawing.Color.Transparent;
			this.labUnidade.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labUnidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labUnidade.Location = new System.Drawing.Point(38, 172);
			this.labUnidade.Name = "labUnidade";
			this.labUnidade.Size = new System.Drawing.Size(85, 23);
			this.labUnidade.TabIndex = 33;
			this.labUnidade.Text = "Unidade :";
			this.labUnidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodBarra
			// 
			this.txtCodBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodBarra.Location = new System.Drawing.Point(131, 233);
			this.txtCodBarra.MaxLength = 200;
			this.txtCodBarra.Multiline = true;
			this.txtCodBarra.Name = "txtCodBarra";
			this.txtCodBarra.Size = new System.Drawing.Size(323, 23);
			this.txtCodBarra.TabIndex = 6;
			// 
			// labCodBarra
			// 
			this.labCodBarra.BackColor = System.Drawing.Color.Transparent;
			this.labCodBarra.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labCodBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCodBarra.Location = new System.Drawing.Point(27, 233);
			this.labCodBarra.Name = "labCodBarra";
			this.labCodBarra.Size = new System.Drawing.Size(97, 23);
			this.labCodBarra.TabIndex = 35;
			this.labCodBarra.Text = "Cod. Barras :";
			this.labCodBarra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CDProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 312);
			this.Controls.Add(this.txtCodBarra);
			this.Controls.Add(this.labCodBarra);
			this.Controls.Add(this.txtUnidade);
			this.Controls.Add(this.labUnidade);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.cbxFamilia);
			this.Controls.Add(this.labFamilia);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.labValor);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
			this.Controls.Add(this.labTitulo);
			this.Controls.Add(this.cbxSituacao);
			this.Controls.Add(this.labSituacao);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "CDProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Produto";
			this.Load += new System.EventHandler(this.Arranque);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private ReaLTaiizor.Controls.DungeonLabel labCodBarra;
		private System.Windows.Forms.TextBox txtCodBarra;
		private ReaLTaiizor.Controls.DungeonLabel labUnidade;
		private System.Windows.Forms.TextBox txtUnidade;
		private ReaLTaiizor.Controls.DungeonLabel labSituacao;
		private System.Windows.Forms.ComboBox cbxSituacao;
		private ReaLTaiizor.Controls.DungeonLabel labTitulo;
		private ReaLTaiizor.Controls.DungeonLabel labDescricao;
		private System.Windows.Forms.TextBox txtDescricao;
		private ReaLTaiizor.Controls.DungeonLabel labValor;
		private System.Windows.Forms.TextBox txtValor;
		private ReaLTaiizor.Controls.DungeonLabel labFamilia;
		private System.Windows.Forms.ComboBox cbxFamilia;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private ReaLTaiizor.Controls.DungeonLabel labCodigo;
		private System.Windows.Forms.TextBox txtCodigo;
	}
}
