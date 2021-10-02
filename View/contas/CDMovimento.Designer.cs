
namespace GM.View.contas
{
	partial class CDMovimento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDMovimento));
			this.cbxTipo = new GM.Componentes.MinComboBox();
			this.labTipo = new System.Windows.Forms.Label();
			this.labDescricao = new System.Windows.Forms.Label();
			this.txtDescricao = new GM.Componentes.MinBox();
			this.txtValor = new GM.Componentes.MinBox();
			this.labValor = new System.Windows.Forms.Label();
			this.txtData = new GM.Componentes.MinBox();
			this.labData = new System.Windows.Forms.Label();
			this.labSaldo = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// cbxTipo
			// 
			this.cbxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cbxTipo.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxTipo.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.cbxTipo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.cbxTipo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.cbxTipo.ColorE = System.Drawing.Color.WhiteSmoke;
			this.cbxTipo.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxTipo.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.cbxTipo.ColorH = System.Drawing.Color.White;
			this.cbxTipo.ColorI = System.Drawing.Color.WhiteSmoke;
			this.cbxTipo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbxTipo.DropDownHeight = 100;
			this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxTipo.ForeColor = System.Drawing.Color.Black;
			this.cbxTipo.FormattingEnabled = true;
			this.cbxTipo.HoverSelectionColor = System.Drawing.Color.Empty;
			this.cbxTipo.IntegralHeight = false;
			this.cbxTipo.ItemHeight = 20;
			this.cbxTipo.Items.AddRange(new object[] {
									"Entrada",
									"Saída"});
			this.cbxTipo.Location = new System.Drawing.Point(91, 106);
			this.cbxTipo.Name = "cbxTipo";
			this.cbxTipo.Size = new System.Drawing.Size(118, 26);
			this.cbxTipo.StartIndex = 0;
			this.cbxTipo.TabIndex = 1;
			this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.mudarTipo);
			// 
			// labTipo
			// 
			this.labTipo.BackColor = System.Drawing.Color.Transparent;
			this.labTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTipo.Location = new System.Drawing.Point(12, 106);
			this.labTipo.Name = "labTipo";
			this.labTipo.Size = new System.Drawing.Size(73, 23);
			this.labTipo.TabIndex = 1;
			this.labTipo.Text = "Tipo :";
			this.labTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labDescricao
			// 
			this.labDescricao.BackColor = System.Drawing.Color.Transparent;
			this.labDescricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDescricao.Location = new System.Drawing.Point(12, 138);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(73, 23);
			this.labDescricao.TabIndex = 3;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescricao
			// 
			this.txtDescricao.BackColor = System.Drawing.Color.Transparent;
			this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtDescricao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescricao.CustomBGColor = System.Drawing.Color.White;
			this.txtDescricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescricao.ForeColor = System.Drawing.Color.Black;
			this.txtDescricao.Location = new System.Drawing.Point(91, 138);
			this.txtDescricao.MaxLength = 50;
			this.txtDescricao.Multiline = false;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.ReadOnly = false;
			this.txtDescricao.SelectionStart = 0;
			this.txtDescricao.Size = new System.Drawing.Size(206, 26);
			this.txtDescricao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDescricao.TabIndex = 2;
			this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.UseSystemPasswordChar = false;
			// 
			// txtValor
			// 
			this.txtValor.BackColor = System.Drawing.Color.Transparent;
			this.txtValor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtValor.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValor.CustomBGColor = System.Drawing.Color.White;
			this.txtValor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor.ForeColor = System.Drawing.Color.Black;
			this.txtValor.Location = new System.Drawing.Point(91, 170);
			this.txtValor.MaxLength = 50;
			this.txtValor.Multiline = false;
			this.txtValor.Name = "txtValor";
			this.txtValor.ReadOnly = false;
			this.txtValor.SelectionStart = 0;
			this.txtValor.Size = new System.Drawing.Size(140, 26);
			this.txtValor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtValor.TabIndex = 3;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValor.UseSystemPasswordChar = false;
			this.txtValor.TextChanged += new System.EventHandler(this.maskMoney);
			// 
			// labValor
			// 
			this.labValor.BackColor = System.Drawing.Color.Transparent;
			this.labValor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labValor.Location = new System.Drawing.Point(12, 170);
			this.labValor.Name = "labValor";
			this.labValor.Size = new System.Drawing.Size(73, 23);
			this.labValor.TabIndex = 5;
			this.labValor.Text = "Valor (R$) :";
			this.labValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtData
			// 
			this.txtData.BackColor = System.Drawing.Color.Transparent;
			this.txtData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtData.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtData.CustomBGColor = System.Drawing.Color.White;
			this.txtData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtData.ForeColor = System.Drawing.Color.Black;
			this.txtData.Location = new System.Drawing.Point(91, 74);
			this.txtData.MaxLength = 50;
			this.txtData.Multiline = false;
			this.txtData.Name = "txtData";
			this.txtData.ReadOnly = false;
			this.txtData.SelectionStart = 0;
			this.txtData.Size = new System.Drawing.Size(140, 26);
			this.txtData.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtData.TabIndex = 0;
			this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtData.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtData.UseSystemPasswordChar = false;
			this.txtData.TextChanged += new System.EventHandler(this.maskData);
			this.txtData.Leave += new System.EventHandler(this.maskDataLeave);
			// 
			// labData
			// 
			this.labData.BackColor = System.Drawing.Color.Transparent;
			this.labData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labData.Location = new System.Drawing.Point(12, 74);
			this.labData.Name = "labData";
			this.labData.Size = new System.Drawing.Size(73, 23);
			this.labData.TabIndex = 7;
			this.labData.Text = "Data :";
			this.labData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labSaldo
			// 
			this.labSaldo.BackColor = System.Drawing.Color.Transparent;
			this.labSaldo.Font = new System.Drawing.Font("Calibri", 12F);
			this.labSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labSaldo.Location = new System.Drawing.Point(12, 201);
			this.labSaldo.Name = "labSaldo";
			this.labSaldo.Size = new System.Drawing.Size(285, 42);
			this.labSaldo.TabIndex = 27;
			this.labSaldo.Text = "Saldo : ";
			this.labSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(105, 246);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(93, 35);
			this.btnCancelar.TabIndex = 61;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.cliqueSair);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(204, 246);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(93, 35);
			this.btnSalvar.TabIndex = 60;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.cliqueSalvar);
			// 
			// CDMovimento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 293);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.labSaldo);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.labData);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.labValor);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
			this.Controls.Add(this.labTipo);
			this.Controls.Add(this.cbxTipo);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "CDMovimento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de movimentação de conta";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.detectaTecla);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private ReaLTaiizor.Controls.DungeonLabel labSaldo;
		private System.Windows.Forms.Label labData;
		private GM.Componentes.MinBox txtData;
		private System.Windows.Forms.Label labValor;
		private GM.Componentes.MinBox txtValor;
		private GM.Componentes.MinBox txtDescricao;
		private System.Windows.Forms.Label labDescricao;
		private System.Windows.Forms.Label labTipo;
		private GM.Componentes.MinComboBox cbxTipo;
	}
}
