
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
			this.txtRua = new GM.Componentes.MinBox();
			this.labRua = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtCodigo = new GM.Componentes.MinBox();
			this.labCodigo = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtBairro = new GM.Componentes.MinBox();
			this.labBairro = new ReaLTaiizor.Controls.DungeonLabel();
			this.labCidade = new ReaLTaiizor.Controls.DungeonLabel();
			this.labPadrao = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtCidade = new GM.Componentes.MinBox();
			this.txtNomeCidade = new GM.Componentes.MinBox();
			this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// txtRua
			// 
			this.txtRua.BackColor = System.Drawing.Color.Transparent;
			this.txtRua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtRua.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtRua.CustomBGColor = System.Drawing.Color.White;
			this.txtRua.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRua.ForeColor = System.Drawing.Color.Black;
			this.txtRua.Location = new System.Drawing.Point(92, 108);
			this.txtRua.MaxLength = 70;
			this.txtRua.Multiline = false;
			this.txtRua.Name = "txtRua";
			this.txtRua.ReadOnly = false;
			this.txtRua.SelectionStart = 0;
			this.txtRua.Size = new System.Drawing.Size(323, 26);
			this.txtRua.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtRua.TabIndex = 1;
			this.txtRua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtRua.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtRua.UseSystemPasswordChar = false;
			// 
			// labRua
			// 
			this.labRua.BackColor = System.Drawing.Color.Transparent;
			this.labRua.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.labRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labRua.Location = new System.Drawing.Point(13, 108);
			this.labRua.Name = "labRua";
			this.labRua.Size = new System.Drawing.Size(73, 20);
			this.labRua.TabIndex = 31;
			this.labRua.Text = "Rua :";
			this.labRua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
			this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigo.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.ForeColor = System.Drawing.Color.Black;
			this.txtCodigo.Location = new System.Drawing.Point(92, 76);
			this.txtCodigo.MaxLength = 70;
			this.txtCodigo.Multiline = false;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = false;
			this.txtCodigo.SelectionStart = 0;
			this.txtCodigo.Size = new System.Drawing.Size(83, 26);
			this.txtCodigo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigo.TabIndex = 0;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.UseSystemPasswordChar = false;
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
			this.txtBairro.BackColor = System.Drawing.Color.Transparent;
			this.txtBairro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtBairro.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtBairro.CustomBGColor = System.Drawing.Color.White;
			this.txtBairro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.ForeColor = System.Drawing.Color.Black;
			this.txtBairro.Location = new System.Drawing.Point(92, 140);
			this.txtBairro.MaxLength = 70;
			this.txtBairro.Multiline = false;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.ReadOnly = false;
			this.txtBairro.SelectionStart = 0;
			this.txtBairro.Size = new System.Drawing.Size(128, 26);
			this.txtBairro.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtBairro.TabIndex = 2;
			this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtBairro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtBairro.UseSystemPasswordChar = false;
			// 
			// labBairro
			// 
			this.labBairro.BackColor = System.Drawing.Color.Transparent;
			this.labBairro.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.labBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labBairro.Location = new System.Drawing.Point(13, 140);
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
			this.labCidade.Location = new System.Drawing.Point(13, 172);
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
			this.txtCidade.BackColor = System.Drawing.Color.Transparent;
			this.txtCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCidade.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCidade.CustomBGColor = System.Drawing.Color.White;
			this.txtCidade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.ForeColor = System.Drawing.Color.Black;
			this.txtCidade.Location = new System.Drawing.Point(92, 172);
			this.txtCidade.MaxLength = 70;
			this.txtCidade.Multiline = false;
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.ReadOnly = false;
			this.txtCidade.SelectionStart = 0;
			this.txtCidade.Size = new System.Drawing.Size(83, 26);
			this.txtCidade.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCidade.TabIndex = 3;
			this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCidade.UseSystemPasswordChar = false;
			this.txtCidade.TextChanged += new System.EventHandler(this.maskNumber);
			this.txtCidade.Leave += new System.EventHandler(this.buscaCidade);
			// 
			// txtNomeCidade
			// 
			this.txtNomeCidade.BackColor = System.Drawing.Color.Transparent;
			this.txtNomeCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtNomeCidade.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNomeCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNomeCidade.CustomBGColor = System.Drawing.Color.White;
			this.txtNomeCidade.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.txtNomeCidade.ForeColor = System.Drawing.Color.Black;
			this.txtNomeCidade.Location = new System.Drawing.Point(259, 172);
			this.txtNomeCidade.MaxLength = 70;
			this.txtNomeCidade.Multiline = false;
			this.txtNomeCidade.Name = "txtNomeCidade";
			this.txtNomeCidade.ReadOnly = true;
			this.txtNomeCidade.SelectionStart = 0;
			this.txtNomeCidade.Size = new System.Drawing.Size(156, 26);
			this.txtNomeCidade.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNomeCidade.TabIndex = 39;
			this.txtNomeCidade.TabStop = false;
			this.txtNomeCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNomeCidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNomeCidade.UseSystemPasswordChar = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Depth = 0;
			this.btnBuscar.Location = new System.Drawing.Point(181, 172);
			this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Primary = true;
			this.btnBuscar.Size = new System.Drawing.Size(72, 26);
			this.btnBuscar.TabIndex = 57;
			this.btnBuscar.Text = "buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.pesquisarClique);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(322, 216);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(93, 26);
			this.btnSalvar.TabIndex = 58;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.salvarClique);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(223, 216);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(93, 26);
			this.btnCancelar.TabIndex = 59;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.cancelarClique);
			// 
			// CDEndereco
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 254);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnBuscar);
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
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
		private GM.Componentes.MinBox txtNomeCidade;
		private GM.Componentes.MinBox txtCidade;
		private ReaLTaiizor.Controls.DungeonLabel labPadrao;
		private ReaLTaiizor.Controls.DungeonLabel labCidade;
		private ReaLTaiizor.Controls.DungeonLabel labBairro;
		private GM.Componentes.MinBox txtBairro;
		private ReaLTaiizor.Controls.DungeonLabel labCodigo;
		private GM.Componentes.MinBox txtCodigo;
		private ReaLTaiizor.Controls.DungeonLabel labRua;
		private GM.Componentes.MinBox txtRua;
	}
}
