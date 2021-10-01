
namespace GM.View.produto
{
	partial class CDFamilia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDFamilia));
			this.txtNome = new GM.Componentes.MinBox();
			this.labNome = new ReaLTaiizor.Controls.DungeonLabel();
			this.txtDescricao = new GM.Componentes.MinBox();
			this.labDescricao = new ReaLTaiizor.Controls.DungeonLabel();
			this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.Transparent;
			this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtNome.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNome.CustomBGColor = System.Drawing.Color.White;
			this.txtNome.Font = new System.Drawing.Font("Tahoma", 11F);
			this.txtNome.ForeColor = System.Drawing.Color.Black;
			this.txtNome.Location = new System.Drawing.Point(91, 70);
			this.txtNome.MaxLength = 70;
			this.txtNome.Multiline = false;
			this.txtNome.Name = "txtNome";
			this.txtNome.ReadOnly = false;
			this.txtNome.SelectionStart = 0;
			this.txtNome.Size = new System.Drawing.Size(277, 28);
			this.txtNome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtNome.TabIndex = 17;
			this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNome.UseSystemPasswordChar = false;
			// 
			// labNome
			// 
			this.labNome.BackColor = System.Drawing.Color.Transparent;
			this.labNome.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labNome.Location = new System.Drawing.Point(12, 70);
			this.labNome.Name = "labNome";
			this.labNome.Size = new System.Drawing.Size(73, 20);
			this.labNome.TabIndex = 24;
			this.labNome.Text = "Nome :";
			this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.txtDescricao.Location = new System.Drawing.Point(91, 104);
			this.txtDescricao.MaxLength = 200;
			this.txtDescricao.Multiline = true;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.ReadOnly = false;
			this.txtDescricao.SelectionStart = 0;
			this.txtDescricao.Size = new System.Drawing.Size(277, 68);
			this.txtDescricao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtDescricao.TabIndex = 18;
			this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDescricao.UseSystemPasswordChar = false;
			// 
			// labDescricao
			// 
			this.labDescricao.BackColor = System.Drawing.Color.Transparent;
			this.labDescricao.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.labDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.labDescricao.Location = new System.Drawing.Point(12, 104);
			this.labDescricao.Name = "labDescricao";
			this.labDescricao.Size = new System.Drawing.Size(73, 20);
			this.labDescricao.TabIndex = 21;
			this.labDescricao.Text = "Descrição :";
			this.labDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Depth = 0;
			this.btnCancelar.Location = new System.Drawing.Point(176, 178);
			this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Primary = true;
			this.btnCancelar.Size = new System.Drawing.Size(93, 31);
			this.btnCancelar.TabIndex = 61;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.sairClique);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Depth = 0;
			this.btnSalvar.Location = new System.Drawing.Point(275, 178);
			this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Primary = true;
			this.btnSalvar.Size = new System.Drawing.Size(93, 31);
			this.btnSalvar.TabIndex = 60;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.salvarClique);
			// 
			// CDFamilia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 221);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.labNome);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.labDescricao);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "CDFamilia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro / Edição de Família";
			this.Load += new System.EventHandler(this.Arranque);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
		private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
		private ReaLTaiizor.Controls.DungeonLabel labDescricao;
		private GM.Componentes.MinBox txtDescricao;
		private ReaLTaiizor.Controls.DungeonLabel labNome;
		private GM.Componentes.MinBox txtNome;
	}
}
