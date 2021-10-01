
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
			this.txtCodigo = new GM.Componentes.MinBox();
			this.labCodigo = new ReaLTaiizor.Controls.DungeonLabel();
			this.cbxFamilia = new GM.Componentes.MinComboBox();
			this.labFamilia = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtValor = new GM.Componentes.MinBox();
			this.labValor = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtDescricao = new GM.Componentes.MinBox();
			this.labDescricao = new ReaLTaiizor.Controls.DungeonLabel();
			this.cbxSituacao = new GM.Componentes.MinComboBox();
			this.labSituacao = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtUnidade = new GM.Componentes.MinBox();
			this.labUnidade = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtCodBarra = new GM.Componentes.MinBox();
			this.labCodBarra = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
			this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigo.CharacterCas = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigo.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtCodigo.ForeColor = System.Drawing.Color.Black;
			this.txtCodigo.Location = new System.Drawing.Point(105, 75);
			this.txtCodigo.MaxLength = 20;
			this.txtCodigo.Multiline = false;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = false;
			this.txtCodigo.SelectionStart = 0;
			this.txtCodigo.Size = new System.Drawing.Size(141, 28);
			this.txtCodigo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigo.TabIndex = 0;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.UseSystemPasswordChar = false;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCodigo.Location = new System.Drawing.Point(12, 75);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(85, 23);
			this.labCodigo.TabIndex = 29;
			this.labCodigo.Text = "Código :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxFamilia
			// 
			this.cbxFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxFamilia.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxFamilia.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxFamilia.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxFamilia.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxFamilia.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxFamilia.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxFamilia.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxFamilia.ColorH = System.Drawing.Color.White;
			this.cbxFamilia.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxFamilia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxFamilia.DropDownHeight = 100;
			this.cbxFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxFamilia.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbxFamilia.ForeColor = System.Drawing.Color.Black;
			this.cbxFamilia.FormattingEnabled = true;
			this.cbxFamilia.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxFamilia.IntegralHeight = false;
			this.cbxFamilia.ItemHeight = 20;
			this.cbxFamilia.Location = new System.Drawing.Point(105, 143);
			this.cbxFamilia.Name = "cbxFamilia";
			this.cbxFamilia.Size = new System.Drawing.Size(224, 26);
			this.cbxFamilia.StartIndex = 0;
			this.cbxFamilia.TabIndex = 2;
			// 
			// labFamilia
			// 
			this.labFamilia.BackColor = System.Drawing.Color.Transparent;
			this.labFamilia.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labFamilia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labFamilia.Location = new System.Drawing.Point(12, 143);
			this.labFamilia.Name = "labFamilia";
			this.labFamilia.Size = new System.Drawing.Size(85, 24);
			this.labFamilia.TabIndex = 27;
			this.labFamilia.Text = "Família :";
			this.labFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtValor
			// 
			this.txtValor.BackColor = System.Drawing.Color.Transparent;
			this.txtValor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtValor.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValor.CustomBGColor = System.Drawing.Color.White;
			this.txtValor.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtValor.ForeColor = System.Drawing.Color.Black;
			this.txtValor.Location = new System.Drawing.Point(105, 209);
			this.txtValor.MaxLength = 15;
			this.txtValor.Multiline = false;
			this.txtValor.Name = "txtValor";
			this.txtValor.ReadOnly = false;
			this.txtValor.SelectionStart = 0;
			this.txtValor.Size = new System.Drawing.Size(225, 28);
			this.txtValor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtValor.TabIndex = 5;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValor.UseSystemPasswordChar = false;
			// 
			// labValor
			// 
			this.labValor.BackColor = System.Drawing.Color.Transparent;
			this.labValor.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labValor.Location = new System.Drawing.Point(1, 209);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(96, 23);
			this.labValor.TabIndex = 26;
			this.labValor.Text = "Valor Unit. (R$) :";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.Transparent;
			this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDescricao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CustomBGColor = System.Drawing.Color.White;
			this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtDescricao.ForeColor = System.Drawing.Color.Black;
			this.txtDescricao.Location = new System.Drawing.Point(105, 109);
			this.txtDescricao.MaxLength = 100;
			this.txtDescricao.Multiline = false;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.ReadOnly = false;
			this.txtDescricao.SelectionStart = 0;
			this.txtDescricao.Size = new System.Drawing.Size(365, 28);
			this.txtDescricao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDescricao.TabIndex = 1;
			this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.UseSystemPasswordChar = false;
			// 
			// labDescricao
			// 
			this.labDescricao.BackColor = System.Drawing.Color.Transparent;
			this.labDescricao.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labDescricao.Location = new System.Drawing.Point(12, 109);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(85, 23);
			this.labDescricao.TabIndex = 25;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSituacao
			// 
			this.cbxSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxSituacao.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSituacao.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxSituacao.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxSituacao.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxSituacao.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxSituacao.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSituacao.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxSituacao.ColorH = System.Drawing.Color.White;
			this.cbxSituacao.ColorI = System.Drawing.Color.Transparent;
			this.cbxSituacao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxSituacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxSituacao.DropDownHeight = 100;
			this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSituacao.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbxSituacao.ForeColor = System.Drawing.Color.Black;
			this.cbxSituacao.FormattingEnabled = true;
			this.cbxSituacao.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxSituacao.IntegralHeight = false;
			this.cbxSituacao.ItemHeight = 20;
			this.cbxSituacao.Items.AddRange(new object[] {
									"SUSPENSO",
									"ATIVO"});
			this.cbxSituacao.Location = new System.Drawing.Point(219, 175);
			this.cbxSituacao.Name = "cbxSituacao";
			this.cbxSituacao.Size = new System.Drawing.Size(111, 26);
			this.cbxSituacao.StartIndex = 0;
			this.cbxSituacao.TabIndex = 4;
			// 
			// labSituacao
			// 
			this.labSituacao.BackColor = System.Drawing.Color.Transparent;
			this.labSituacao.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSituacao.Location = new System.Drawing.Point(126, 175);
			this.labSituacao.Name = "labSituacao";
			this.labSituacao.Size = new System.Drawing.Size(85, 24);
			this.labSituacao.TabIndex = 31;
			this.labSituacao.Text = "Situação :";
			this.labSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUnidade
			// 
			this.txtUnidade.BackColor = System.Drawing.Color.Transparent;
			this.txtUnidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtUnidade.CharacterCas = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUnidade.CustomBGColor = System.Drawing.Color.White;
			this.txtUnidade.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtUnidade.ForeColor = System.Drawing.Color.Black;
			this.txtUnidade.Location = new System.Drawing.Point(105, 175);
			this.txtUnidade.MaxLength = 2;
			this.txtUnidade.Multiline = false;
			this.txtUnidade.Name = "txtUnidade";
			this.txtUnidade.ReadOnly = false;
			this.txtUnidade.SelectionStart = 0;
			this.txtUnidade.Size = new System.Drawing.Size(42, 28);
			this.txtUnidade.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtUnidade.TabIndex = 3;
			this.txtUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUnidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUnidade.UseSystemPasswordChar = false;
			// 
			// labUnidade
			// 
			this.labUnidade.BackColor = System.Drawing.Color.Transparent;
			this.labUnidade.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labUnidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labUnidade.Location = new System.Drawing.Point(12, 175);
			this.labUnidade.Name = "labUnidade";
			this.labUnidade.Size = new System.Drawing.Size(85, 23);
			this.labUnidade.TabIndex = 33;
			this.labUnidade.Text = "Unidade :";
			this.labUnidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodBarra
			// 
			this.txtCodBarra.BackColor = System.Drawing.Color.Transparent;
			this.txtCodBarra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodBarra.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodBarra.CustomBGColor = System.Drawing.Color.White;
			this.txtCodBarra.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtCodBarra.ForeColor = System.Drawing.Color.Black;
			this.txtCodBarra.Location = new System.Drawing.Point(105, 243);
			this.txtCodBarra.MaxLength = 200;
			this.txtCodBarra.Multiline = true;
			this.txtCodBarra.Name = "txtCodBarra";
			this.txtCodBarra.ReadOnly = false;
			this.txtCodBarra.SelectionStart = 0;
			this.txtCodBarra.Size = new System.Drawing.Size(365, 83);
			this.txtCodBarra.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodBarra.TabIndex = 6;
			this.txtCodBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodBarra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodBarra.UseSystemPasswordChar = false;
			// 
			// labCodBarra
			// 
			this.labCodBarra.BackColor = System.Drawing.Color.Transparent;
			this.labCodBarra.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labCodBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labCodBarra.Location = new System.Drawing.Point(1, 243);
			this.labCodBarra.Name = "labCodBarra";
			this.labCodBarra.Size = new System.Drawing.Size(97, 23);
			this.labCodBarra.TabIndex = 35;
			this.labCodBarra.Text = "Cod. Barras :";
			this.labCodBarra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(278, 332);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(93, 31);
			this.btnCancelar.TabIndex = 63;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(377, 332);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(93, 31);
			this.btnSalvar.TabIndex = 62;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// CDProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 375);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtCodBarra);
			this.Controls.Add(this.labCodBarra);
			this.Controls.Add(this.txtUnidade);
			this.Controls.Add(this.labUnidade);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.cbxFamilia);
			this.Controls.Add(this.labFamilia);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.labValor);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
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
		}
		private ReaLTaiizor.Controls.DungeonLabel labCodBarra;
		private GM.Componentes.MinBox txtCodBarra;
		private ReaLTaiizor.Controls.DungeonLabel labUnidade;
		private GM.Componentes.MinBox txtUnidade;
		private ReaLTaiizor.Controls.DungeonLabel labSituacao;
		private GM.Componentes.MinComboBox cbxSituacao;
		private ReaLTaiizor.Controls.DungeonLabel labDescricao;
		private GM.Componentes.MinBox txtDescricao;
		private ReaLTaiizor.Controls.DungeonLabel labValor;
		private GM.Componentes.MinBox txtValor;
		private ReaLTaiizor.Controls.DungeonLabel labFamilia;
		private GM.Componentes.MinComboBox cbxFamilia;
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private ReaLTaiizor.Controls.DungeonLabel labCodigo;
		private GM.Componentes.MinBox txtCodigo;
	}
}
