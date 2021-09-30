
namespace GM.View.pessoa
{
	partial class CDEndereco
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDEndereco));
			this.txtRua = new System.Windows.Forms.TextBox();
			this.labRua = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.labCodigo = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.labBairro = new ReaLTaiizor.Controls.DungeonLabel();
			this.labCidade = new ReaLTaiizor.Controls.DungeonLabel();
			this.labPadrao = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtNomeCidade = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new Sunny.UI.UISymbolButton();
			this.btnCancelar = new Sunny.UI.UISymbolButton();
			this.btnSalvar = new Sunny.UI.UISymbolButton();
			this.SuspendLayout();
			// 
			// txtRua
			// 
			this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRua.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRua.Location = new System.Drawing.Point(92, 102);
			this.txtRua.MaxLength = 70;
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(317, 23);
			this.txtRua.TabIndex = 1;
			// 
			// labRua
			// 
			this.labRua.BackColor = System.Drawing.Color.Transparent;
			this.labRua.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.labRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labRua.Location = new System.Drawing.Point(13, 102);
			this.labRua.Name = "labRua";
			this.labRua.Size = new System.Drawing.Size(73, 20);
			this.labRua.TabIndex = 31;
			this.labRua.Text = "Rua :";
			this.labRua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(92, 76);
			this.txtCodigo.MaxLength = 70;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(83, 23);
			this.txtCodigo.TabIndex = 0;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.labCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCodigo.Location = new System.Drawing.Point(13, 76);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(73, 20);
			this.labCodigo.TabIndex = 33;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBairro
			// 
			this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBairro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(92, 128);
			this.txtBairro.MaxLength = 70;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(128, 23);
			this.txtBairro.TabIndex = 2;
			// 
			// labBairro
			// 
			this.labBairro.BackColor = System.Drawing.Color.Transparent;
			this.labBairro.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.labBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labBairro.Location = new System.Drawing.Point(13, 128);
			this.labBairro.Name = "labBairro";
			this.labBairro.Size = new System.Drawing.Size(73, 20);
			this.labBairro.TabIndex = 35;
			this.labBairro.Text = "Bairro :";
			this.labBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labCidade
			// 
			this.labCidade.BackColor = System.Drawing.Color.Transparent;
			this.labCidade.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.labCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCidade.Location = new System.Drawing.Point(13, 154);
			this.labCidade.Name = "labCidade";
			this.labCidade.Size = new System.Drawing.Size(73, 20);
			this.labCidade.TabIndex = 36;
			this.labCidade.Text = "Cidade :";
			this.labCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labPadrao
			// 
			this.labPadrao.BackColor = System.Drawing.Color.Transparent;
			this.labPadrao.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.labPadrao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labPadrao.Location = new System.Drawing.Point(181, 76);
			this.labPadrao.Name = "labPadrao";
			this.labPadrao.Size = new System.Drawing.Size(188, 20);
			this.labPadrao.TabIndex = 37;
			this.labPadrao.Text = "Recomendado : Padrão";
			this.labPadrao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCidade
			// 
			this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCidade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(92, 154);
			this.txtCidade.MaxLength = 70;
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(83, 23);
			this.txtCidade.TabIndex = 3;
			this.txtCidade.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCidade.Leave += new System.EventHandler(this.buscaCidade);
			// 
			// txtNomeCidade
			// 
			this.txtNomeCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNomeCidade.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtNomeCidade.Location = new System.Drawing.Point(207, 154);
			this.txtNomeCidade.MaxLength = 70;
			this.txtNomeCidade.Name = "txtNomeCidade";
			this.txtNomeCidade.ReadOnly = true;
			this.txtNomeCidade.Size = new System.Drawing.Size(202, 23);
			this.txtNomeCidade.TabIndex = 39;
			this.txtNomeCidade.TabStop = false;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnPesquisar.Location = new System.Drawing.Point(177, 154);
			this.btnPesquisar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnPesquisar.Size = new System.Drawing.Size(28, 23);
			this.btnPesquisar.Symbol = 61442;
			this.btnPesquisar.TabIndex = 4;
			this.btnPesquisar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(181, 190);
			this.btnCancelar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnCancelar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnCancelar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
			this.btnCancelar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
			this.btnCancelar.Size = new System.Drawing.Size(111, 29);
			this.btnCancelar.Style = Sunny.UI.UIStyle.Red;
			this.btnCancelar.Symbol = 61453;
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Sair";
			this.btnCancelar.Click += new System.EventHandler(this.cancelarClique);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.btnSalvar.Location = new System.Drawing.Point(298, 190);
			this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
			this.btnSalvar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
			this.btnSalvar.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
			this.btnSalvar.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
			this.btnSalvar.Size = new System.Drawing.Size(111, 29);
			this.btnSalvar.Style = Sunny.UI.UIStyle.Green;
			this.btnSalvar.TabIndex = 5;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.salvarClique);
			// 
			// CDEndereco
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 231);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.txtNomeCidade);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.labPadrao);
			this.Controls.Add(this.labCidade);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.labBairro);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.txtRua);
			this.Controls.Add(this.labRua);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CDEndereco";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro / Edição de endereço(s)";
			this.Load += new System.EventHandler(this.ArranqueFormulario);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sunny.UI.UISymbolButton btnSalvar;
		private Sunny.UI.UISymbolButton btnCancelar;
		private Sunny.UI.UISymbolButton btnPesquisar;
		private System.Windows.Forms.TextBox txtNomeCidade;
		private System.Windows.Forms.TextBox txtCidade;
		private ReaLTaiizor.Controls.DungeonLabel labPadrao;
		private ReaLTaiizor.Controls.DungeonLabel labCidade;
		private ReaLTaiizor.Controls.DungeonLabel labBairro;
		private System.Windows.Forms.TextBox txtBairro;
		private ReaLTaiizor.Controls.DungeonLabel labCodigo;
		private System.Windows.Forms.TextBox txtCodigo;
		private ReaLTaiizor.Controls.DungeonLabel labRua;
		private System.Windows.Forms.TextBox txtRua;
	}
}
