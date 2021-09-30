
namespace GM.View.pessoa
{
	partial class CDPessoa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDPessoa));
			this.btnVoltar = new Sunny.UI.UISymbolButton();
			this.btnProximo = new Sunny.UI.UISymbolButton();
			this.btnNovo = new Sunny.UI.UISymbolButton();
			this.btnEditar = new Sunny.UI.UISymbolButton();
			this.btnDeletar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.labCodigo = new ReaLTaiizor.Controls.DungeonLabel();
			this.cbxTipo = new System.Windows.Forms.ComboBox();
			this.labTipo = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.labNome = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtContato = new System.Windows.Forms.TextBox();
			this.labContato = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtDocumento = new System.Windows.Forms.TextBox();
			this.labDocumento = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.labObservacao = new ReaLTaiizor.Controls.DungeonLabel();
			this.cbxDocumento = new System.Windows.Forms.ComboBox();
			this.btnEndereco = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// btnVoltar
			// 
			this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVoltar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.btnVoltar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
			this.btnVoltar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnVoltar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnVoltar.Location = new System.Drawing.Point(12, 77);
			this.btnVoltar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnVoltar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.btnVoltar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
			this.btnVoltar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnVoltar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnVoltar.Size = new System.Drawing.Size(37, 33);
			this.btnVoltar.Style = Sunny.UI.UIStyle.Gray;
			this.btnVoltar.Symbol = 61536;
			this.btnVoltar.TabIndex = 0;
			this.btnVoltar.Click += new System.EventHandler(this.voltarClique);
			// 
			// btnProximo
			// 
			this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProximo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.btnProximo.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
			this.btnProximo.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnProximo.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnProximo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnProximo.Location = new System.Drawing.Point(50, 77);
			this.btnProximo.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnProximo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.btnProximo.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
			this.btnProximo.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnProximo.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
			this.btnProximo.Size = new System.Drawing.Size(37, 33);
			this.btnProximo.Style = Sunny.UI.UIStyle.Gray;
			this.btnProximo.Symbol = 61537;
			this.btnProximo.TabIndex = 1;
			this.btnProximo.Click += new System.EventHandler(this.proximoClique);
			// 
			// btnNovo
			// 
			this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnNovo.Location = new System.Drawing.Point(93, 77);
			this.btnNovo.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnNovo.Size = new System.Drawing.Size(37, 33);
			this.btnNovo.Symbol = 61543;
			this.btnNovo.TabIndex = 2;
			this.btnNovo.Click += new System.EventHandler(this.novoClique);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnEditar.Location = new System.Drawing.Point(131, 77);
			this.btnEditar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnEditar.Size = new System.Drawing.Size(37, 33);
			this.btnEditar.Symbol = 61508;
			this.btnEditar.TabIndex = 3;
			this.btnEditar.Click += new System.EventHandler(this.editarClique);
			// 
			// btnDeletar
			// 
			this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeletar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnDeletar.Location = new System.Drawing.Point(169, 77);
			this.btnDeletar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnDeletar.Size = new System.Drawing.Size(37, 33);
			this.btnDeletar.Symbol = 61944;
			this.btnDeletar.TabIndex = 4;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSalvar.Location = new System.Drawing.Point(212, 77);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(37, 33);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 12;
			this.btnSalvar.Click += new System.EventHandler(this.salvarClique);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(251, 77);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Size = new System.Drawing.Size(37, 33);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 13;
			this.btnCancelar.Click += new System.EventHandler(this.cancelarClique);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnPesquisar.Location = new System.Drawing.Point(294, 77);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnPesquisar.Size = new System.Drawing.Size(74, 33);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 5;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// txtCodigo
			// 
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(91, 125);
			this.txtCodigo.MaxLength = 70;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = true;
			this.txtCodigo.Size = new System.Drawing.Size(98, 23);
			this.txtCodigo.TabIndex = 26;
			this.txtCodigo.TabStop = false;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCodigo.Location = new System.Drawing.Point(12, 125);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(73, 20);
			this.labCodigo.TabIndex = 31;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxTipo
			// 
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.Items.AddRange(new object[] {
									"Cliente",
									"Fornecedor",
									"Ambos"});
			this.cbxTipo.Location = new System.Drawing.Point(91, 183);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(121, 23);
			this.cbxTipo.TabIndex = 7;
			// 
			// labTipo
			// 
			this.labTipo.BackColor = System.Drawing.Color.Transparent;
			this.labTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labTipo.Location = new System.Drawing.Point(12, 183);
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(73, 21);
			this.labTipo.TabIndex = 30;
			this.labTipo.Text = "Tipo :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNome
			// 
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(91, 154);
			this.txtNome.MaxLength = 70;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(277, 23);
			this.txtNome.TabIndex = 6;
			// 
			// labNome
			// 
			this.labNome.BackColor = System.Drawing.Color.Transparent;
			this.labNome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labNome.Location = new System.Drawing.Point(12, 154);
			this.labNome.Name = "labNome";
			this.labNome.Size = new System.Drawing.Size(73, 20);
			this.labNome.TabIndex = 29;
			this.labNome.Text = "Nome :";
			this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtContato
			// 
			this.txtContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContato.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContato.Location = new System.Drawing.Point(91, 241);
			this.txtContato.MaxLength = 50;
			this.txtContato.Multiline = true;
			this.txtContato.Name = "txtContato";
			this.txtContato.Size = new System.Drawing.Size(121, 43);
			this.txtContato.TabIndex = 10;
			// 
			// labContato
			// 
			this.labContato.BackColor = System.Drawing.Color.Transparent;
			this.labContato.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labContato.Location = new System.Drawing.Point(12, 239);
			this.labContato.Name = "labContato";
			this.labContato.Size = new System.Drawing.Size(73, 20);
			this.labContato.TabIndex = 33;
			this.labContato.Text = "Contato :";
			this.labContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDocumento
			// 
			this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocumento.Location = new System.Drawing.Point(157, 212);
			this.txtDocumento.MaxLength = 70;
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.Size = new System.Drawing.Size(160, 23);
			this.txtDocumento.TabIndex = 9;
			this.txtDocumento.TextChanged += new System.EventHandler(this.maskDocumento);
			// 
			// labDocumento
			// 
			this.labDocumento.BackColor = System.Drawing.Color.Transparent;
			this.labDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labDocumento.Location = new System.Drawing.Point(12, 213);
			this.labDocumento.Name = "labDocumento";
			this.labDocumento.Size = new System.Drawing.Size(73, 20);
			this.labDocumento.TabIndex = 35;
			this.labDocumento.Text = "CPF / CNPJ :";
			this.labDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtObservacao
			// 
			this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtObservacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacao.Location = new System.Drawing.Point(91, 290);
			this.txtObservacao.MaxLength = 200;
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(277, 50);
			this.txtObservacao.TabIndex = 11;
			// 
			// labObservacao
			// 
			this.labObservacao.BackColor = System.Drawing.Color.Transparent;
			this.labObservacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labObservacao.Location = new System.Drawing.Point(5, 288);
			this.labObservacao.Name = "labObservacao";
			this.labObservacao.Size = new System.Drawing.Size(80, 20);
			this.labObservacao.TabIndex = 37;
			this.labObservacao.Text = "Observação :";
			this.labObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxDocumento
			// 
			this.cbxDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDocumento.FormattingEnabled = true;
			this.cbxDocumento.Items.AddRange(new object[] {
									"CPF",
									"CNPJ"});
			this.cbxDocumento.Location = new System.Drawing.Point(91, 212);
			this.cbxDocumento.Name = "cbxDocumento";
			this.cbxDocumento.Size = new System.Drawing.Size(60, 23);
			this.cbxDocumento.TabIndex = 8;
			// 
			// btnEndereco
			// 
			this.btnEndereco.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEndereco.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnEndereco.Location = new System.Drawing.Point(195, 125);
			this.btnEndereco.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnEndereco.Name = "btnEndereco";
			this.btnEndereco.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnEndereco.Size = new System.Drawing.Size(173, 23);
			this.btnEndereco.Symbol = 61649;
			this.btnEndereco.TabIndex = 38;
			this.btnEndereco.Text = "Endereço(s)";
			this.btnEndereco.Click += new System.EventHandler(this.enderecoClique);
			// 
			// CDPessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 355);
			this.Controls.Add(this.btnEndereco);
			this.Controls.Add(this.cbxDocumento);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.labObservacao);
			this.Controls.Add(this.txtDocumento);
			this.Controls.Add(this.labDocumento);
			this.Controls.Add(this.txtContato);
			this.Controls.Add(this.labContato);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.cbxTipo);
			this.Controls.Add(this.labTipo);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.labNome);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.btnProximo);
			this.Controls.Add(this.btnVoltar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CDPessoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Cliente / Fornecedores";
			this.Load += new System.EventHandler(this.Arranque);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton btnEndereco;
		private System.Windows.Forms.ComboBox cbxDocumento;
		private ReaLTaiizor.Controls.DungeonLabel labObservacao;
		private System.Windows.Forms.TextBox txtObservacao;
		private ReaLTaiizor.Controls.DungeonLabel labDocumento;
		private System.Windows.Forms.TextBox txtDocumento;
		private ReaLTaiizor.Controls.DungeonLabel labContato;
		private System.Windows.Forms.TextBox txtContato;
		private ReaLTaiizor.Controls.DungeonLabel labNome;
		private System.Windows.Forms.TextBox txtNome;
		private ReaLTaiizor.Controls.DungeonLabel labTipo;
		private System.Windows.Forms.ComboBox cbxTipo;
		private ReaLTaiizor.Controls.DungeonLabel labCodigo;
		private System.Windows.Forms.TextBox txtCodigo;
		private Sunny.UI.UISymbolButton btnPesquisar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnDeletar;
		private Sunny.UI.UISymbolButton btnEditar;
		private Sunny.UI.UISymbolButton btnNovo;
		private Sunny.UI.UISymbolButton btnProximo;
		private Sunny.UI.UISymbolButton btnVoltar;
	}
}
