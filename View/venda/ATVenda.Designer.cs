
namespace GM.View.venda
{
	partial class ATVenda
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATVenda));
			this.txtData = new GM.Componentes.MinBox();
			this.labData = new System.Windows.Forms.Label();
			this.txtTotal = new GM.Componentes.MinBox();
			this.labTotal = new System.Windows.Forms.Label();
			this.txtCondicao = new GM.Componentes.MinBox();
			this.labCondicao = new System.Windows.Forms.Label();
			this.txtCodigo = new GM.Componentes.MinBox();
			this.labCodigo = new System.Windows.Forms.Label();
			this.txtSede = new GM.Componentes.MinBox();
			this.labSede = new System.Windows.Forms.Label();
			this.txtCliente = new GM.Componentes.MinBox();
			this.labCliente = new System.Windows.Forms.Label();
			this.Col03 = new System.Windows.Forms.ColumnHeader();
			this.Col02 = new System.Windows.Forms.ColumnHeader();
			this.Col01 = new System.Windows.Forms.ColumnHeader();
			this.Col04 = new System.Windows.Forms.ColumnHeader();
			this.ColT3 = new System.Windows.Forms.ColumnHeader();
			this.listaPagamentos = new System.Windows.Forms.ListView();
			this.ColT1 = new System.Windows.Forms.ColumnHeader();
			this.ColT2 = new System.Windows.Forms.ColumnHeader();
			this.listaProdutos = new System.Windows.Forms.ListView();
			this.ColEstoq = new System.Windows.Forms.ColumnHeader();
			this.btnEntrada = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// txtData
			// 
			this.txtData.BackColor = System.Drawing.Color.White;
			this.txtData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtData.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtData.CustomBGColor = System.Drawing.Color.White;
			this.txtData.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtData.ForeColor = System.Drawing.Color.Black;
			this.txtData.Location = new System.Drawing.Point(452, 377);
			this.txtData.MaxLength = 32767;
			this.txtData.Multiline = false;
			this.txtData.Name = "txtData";
			this.txtData.ReadOnly = true;
			this.txtData.SelectionStart = 0;
			this.txtData.Size = new System.Drawing.Size(175, 28);
			this.txtData.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtData.TabIndex = 59;
			this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtData.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtData.UseSystemPasswordChar = false;
			// 
			// labData
			// 
			this.labData.BackColor = System.Drawing.Color.Transparent;
			this.labData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labData.Location = new System.Drawing.Point(345, 377);
			this.labData.Name = "labData";
			this.labData.Size = new System.Drawing.Size(101, 25);
			this.labData.TabIndex = 58;
			this.labData.Text = "Data Emissão :";
			this.labData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTotal
			// 
			this.txtTotal.BackColor = System.Drawing.Color.White;
			this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtTotal.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtTotal.CustomBGColor = System.Drawing.Color.White;
			this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtTotal.ForeColor = System.Drawing.Color.Black;
			this.txtTotal.Location = new System.Drawing.Point(452, 343);
			this.txtTotal.MaxLength = 32767;
			this.txtTotal.Multiline = false;
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.SelectionStart = 0;
			this.txtTotal.Size = new System.Drawing.Size(175, 28);
			this.txtTotal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtTotal.TabIndex = 57;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtTotal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtTotal.UseSystemPasswordChar = false;
			// 
			// labTotal
			// 
			this.labTotal.BackColor = System.Drawing.Color.Transparent;
			this.labTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTotal.Location = new System.Drawing.Point(345, 343);
			this.labTotal.Name = "labTotal";
			this.labTotal.Size = new System.Drawing.Size(101, 25);
			this.labTotal.TabIndex = 56;
			this.labTotal.Text = "Total (R$) :";
			this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCondicao
			// 
			this.txtCondicao.BackColor = System.Drawing.Color.White;
			this.txtCondicao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCondicao.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCondicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCondicao.CustomBGColor = System.Drawing.Color.White;
			this.txtCondicao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCondicao.ForeColor = System.Drawing.Color.Black;
			this.txtCondicao.Location = new System.Drawing.Point(108, 106);
			this.txtCondicao.MaxLength = 32767;
			this.txtCondicao.Multiline = false;
			this.txtCondicao.Name = "txtCondicao";
			this.txtCondicao.ReadOnly = true;
			this.txtCondicao.SelectionStart = 0;
			this.txtCondicao.Size = new System.Drawing.Size(285, 28);
			this.txtCondicao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCondicao.TabIndex = 54;
			this.txtCondicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCondicao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCondicao.UseSystemPasswordChar = false;
			// 
			// labCondicao
			// 
			this.labCondicao.BackColor = System.Drawing.Color.Transparent;
			this.labCondicao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCondicao.Location = new System.Drawing.Point(29, 106);
			this.labCondicao.Name = "labCondicao";
			this.labCondicao.Size = new System.Drawing.Size(73, 25);
			this.labCondicao.TabIndex = 55;
			this.labCondicao.Text = "Condição :";
			this.labCondicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.White;
			this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCodigo.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCodigo.CustomBGColor = System.Drawing.Color.White;
			this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCodigo.ForeColor = System.Drawing.Color.Black;
			this.txtCodigo.Location = new System.Drawing.Point(108, 72);
			this.txtCodigo.MaxLength = 32767;
			this.txtCodigo.Multiline = false;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = true;
			this.txtCodigo.SelectionStart = 0;
			this.txtCodigo.Size = new System.Drawing.Size(94, 28);
			this.txtCodigo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCodigo.TabIndex = 52;
			this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCodigo.UseSystemPasswordChar = false;
			// 
			// labCodigo
			// 
			this.labCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCodigo.Location = new System.Drawing.Point(12, 72);
			this.labCodigo.Name = "labCodigo";
			this.labCodigo.Size = new System.Drawing.Size(90, 25);
			this.labCodigo.TabIndex = 53;
			this.labCodigo.Text = "Pedido :";
			this.labCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSede
			// 
			this.txtSede.BackColor = System.Drawing.Color.White;
			this.txtSede.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtSede.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSede.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSede.CustomBGColor = System.Drawing.Color.White;
			this.txtSede.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSede.ForeColor = System.Drawing.Color.Black;
			this.txtSede.Location = new System.Drawing.Point(452, 106);
			this.txtSede.MaxLength = 32767;
			this.txtSede.Multiline = false;
			this.txtSede.Name = "txtSede";
			this.txtSede.ReadOnly = true;
			this.txtSede.SelectionStart = 0;
			this.txtSede.Size = new System.Drawing.Size(175, 28);
			this.txtSede.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtSede.TabIndex = 51;
			this.txtSede.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSede.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSede.UseSystemPasswordChar = false;
			// 
			// labSede
			// 
			this.labSede.BackColor = System.Drawing.Color.Transparent;
			this.labSede.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSede.Location = new System.Drawing.Point(399, 106);
			this.labSede.Name = "labSede";
			this.labSede.Size = new System.Drawing.Size(47, 28);
			this.labSede.TabIndex = 50;
			this.labSede.Text = "Sede :";
			this.labSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCliente
			// 
			this.txtCliente.BackColor = System.Drawing.Color.White;
			this.txtCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtCliente.CharacterCas = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCliente.CustomBGColor = System.Drawing.Color.White;
			this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtCliente.ForeColor = System.Drawing.Color.Black;
			this.txtCliente.Location = new System.Drawing.Point(304, 72);
			this.txtCliente.MaxLength = 32767;
			this.txtCliente.Multiline = false;
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.ReadOnly = true;
			this.txtCliente.SelectionStart = 0;
			this.txtCliente.Size = new System.Drawing.Size(323, 28);
			this.txtCliente.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.txtCliente.TabIndex = 48;
			this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCliente.UseSystemPasswordChar = false;
			// 
			// labCliente
			// 
			this.labCliente.BackColor = System.Drawing.Color.Transparent;
			this.labCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCliente.Location = new System.Drawing.Point(208, 72);
			this.labCliente.Name = "labCliente";
			this.labCliente.Size = new System.Drawing.Size(90, 25);
			this.labCliente.TabIndex = 49;
			this.labCliente.Text = "Cliente :";
			this.labCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Col03
			// 
			this.Col03.DisplayIndex = 3;
			this.Col03.Text = "Valor Unitário (R$)";
			this.Col03.Width = 110;
			// 
			// Col02
			// 
			this.Col02.DisplayIndex = 2;
			this.Col02.Text = "Produto";
			this.Col02.Width = 250;
			// 
			// Col01
			// 
			this.Col01.Text = "Quantidade";
			this.Col01.Width = 75;
			// 
			// Col04
			// 
			this.Col04.DisplayIndex = 4;
			this.Col04.Text = "Valor total (R$)";
			this.Col04.Width = 125;
			// 
			// ColT3
			// 
			this.ColT3.Text = "P/";
			this.ColT3.Width = 30;
			// 
			// listaPagamentos
			// 
			this.listaPagamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ColT1,
									this.ColT2,
									this.ColT3});
			this.listaPagamentos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaPagamentos.FullRowSelect = true;
			this.listaPagamentos.GridLines = true;
			this.listaPagamentos.Location = new System.Drawing.Point(12, 343);
			this.listaPagamentos.Name = "listaPagamentos";
			this.listaPagamentos.Size = new System.Drawing.Size(234, 182);
			this.listaPagamentos.TabIndex = 46;
			this.listaPagamentos.UseCompatibleStateImageBehavior = false;
			this.listaPagamentos.View = System.Windows.Forms.View.Details;
			// 
			// ColT1
			// 
			this.ColT1.Text = "Vencimento";
			this.ColT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColT1.Width = 80;
			// 
			// ColT2
			// 
			this.ColT2.Text = "Valor Parcela (R$)";
			this.ColT2.Width = 110;
			// 
			// listaProdutos
			// 
			this.listaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Col01,
									this.Col02,
									this.Col03,
									this.Col04,
									this.ColEstoq});
			this.listaProdutos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaProdutos.FullRowSelect = true;
			this.listaProdutos.GridLines = true;
			this.listaProdutos.Location = new System.Drawing.Point(12, 140);
			this.listaProdutos.Name = "listaProdutos";
			this.listaProdutos.Size = new System.Drawing.Size(615, 197);
			this.listaProdutos.TabIndex = 45;
			this.listaProdutos.UseCompatibleStateImageBehavior = false;
			this.listaProdutos.View = System.Windows.Forms.View.Details;
			// 
			// ColEstoq
			// 
			this.ColEstoq.DisplayIndex = 1;
			this.ColEstoq.Text = "Estoque";
			// 
			// btnEntrada
			// 
			this.btnEntrada.Depth = 0;
			this.btnEntrada.Location = new System.Drawing.Point(369, 471);
			this.btnEntrada.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnEntrada.Name = "btnEntrada";
			this.btnEntrada.Primary = true;
			this.btnEntrada.Size = new System.Drawing.Size(258, 51);
			this.btnEntrada.TabIndex = 60;
			this.btnEntrada.Text = "DAR ENTRADA NO ESTOQUE \nE GERAR PAGAMENTOS";
			this.btnEntrada.UseVisualStyleBackColor = true;
			this.btnEntrada.Click += new System.EventHandler(this.atenderClique);
			// 
			// ATVenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 534);
			this.Controls.Add(this.btnEntrada);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.labData);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.labTotal);
			this.Controls.Add(this.txtCondicao);
			this.Controls.Add(this.labCondicao);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.labCodigo);
			this.Controls.Add(this.txtSede);
			this.Controls.Add(this.labSede);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.labCliente);
			this.Controls.Add(this.listaPagamentos);
			this.Controls.Add(this.listaProdutos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ATVenda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atender Venda";
			this.Load += new System.EventHandler(this.arranqueFormulario);
			this.ResumeLayout(false);
		}
		private MaterialSkin.Controls.MaterialRaisedButton btnEntrada;
		private System.Windows.Forms.ColumnHeader ColEstoq;
		private System.Windows.Forms.ListView listaProdutos;
		private System.Windows.Forms.ColumnHeader ColT2;
		private System.Windows.Forms.ColumnHeader ColT1;
		private System.Windows.Forms.ListView listaPagamentos;
		private System.Windows.Forms.ColumnHeader ColT3;
		private System.Windows.Forms.ColumnHeader Col04;
		private System.Windows.Forms.ColumnHeader Col01;
		private System.Windows.Forms.ColumnHeader Col02;
		private System.Windows.Forms.ColumnHeader Col03;
		private System.Windows.Forms.Label labCliente;
		private GM.Componentes.MinBox txtCliente;
		private System.Windows.Forms.Label labSede;
		private GM.Componentes.MinBox txtSede;
		private System.Windows.Forms.Label labCodigo;
		private GM.Componentes.MinBox txtCodigo;
		private System.Windows.Forms.Label labCondicao;
		private GM.Componentes.MinBox txtCondicao;
		private System.Windows.Forms.Label labTotal;
		private GM.Componentes.MinBox txtTotal;
		private System.Windows.Forms.Label labData;
		private GM.Componentes.MinBox txtData;
	}
}
