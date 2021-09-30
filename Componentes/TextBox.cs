using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MaterialSkin;
using ReaLTaiizor;

namespace GM.Componentes {
	[DefaultEvent("TextChanged")]
	public class MinBox : Control
	{
		public int SelectionStart {
			get { return RT_TB.SelectionStart; }
			set { this.RT_TB.SelectionStart = value; }
		}
		
		public bool Focus() {
			return RT_TB.Focus();
		}
		
		public TextBox RT_TB = new TextBox();
		
		public event KeyEventHandler KeyDown {
			add {
				RT_TB.KeyDown += value;
			}
			remove {
				RT_TB.KeyDown -= value;
			}
		}
		
		public event MouseEventHandler MouseDoubleClick {
			add {
				RT_TB.MouseDoubleClick += value;
			}
			remove {
				RT_TB.MouseDoubleClick -= value;
			}
		}

		private GraphicsPath Shape;

		private int _maxchars = 32767;

		private bool _ReadOnly;

		private bool _Multiline;

		private HorizontalAlignment ALNType;

		private bool isPasswordMasked;

		private Pen P1;

		private SolidBrush B1;

		private SmoothingMode _SmoothingType = SmoothingMode.AntiAlias;

		private Color _BorderColor = Color.FromArgb(180, 180, 180);

		private Color _CustomBGColor = Color.White;
		
		private CharacterCasing _CharacterCasing = CharacterCasing.Normal;
		
		public CharacterCasing CharacterCasing {
			get {
				return this._CharacterCasing;
			}
			set {
				this._CharacterCasing = value;
				RT_TB.CharacterCasing = value;
			}
		}
		
		public CharacterCasing CharacterCas {
			get {
				return this._CharacterCasing;
			}
			set {
				this._CharacterCasing = value;
				RT_TB.CharacterCasing = value;
			}
		}
		
		public void setBackColor(Color cor) {
			this.CustomBGColor = cor;
			RT_TB.BackColor = cor;
			this.P1 = new Pen(this.BorderColor);
			this.B1 = new SolidBrush(this.CustomBGColor);
		}
		
		
		
		public event MouseEventHandler DoubleClickX { 
			add {
				RT_TB.MouseDoubleClick += value;
			}
			
			remove {
				RT_TB.MouseDoubleClick -= value;
			}
		}
		
		public event KeyEventHandler KeyDownX {
			add {
				RT_TB.KeyDown += value;
			}
			remove {
				RT_TB.KeyDown -= value;
			}
		}
		

		public HorizontalAlignment TextAlignment {
			get {
				return this.ALNType;
			}
			set {
				this.ALNType = value;
				base.Invalidate();
			}
		}

		public int MaxLength {
			get {
				return this._maxchars;
			}
			set {
				this._maxchars = value;
				this.RT_TB.MaxLength = this.MaxLength;
				base.Invalidate();
			}
		}

		public bool UseSystemPasswordChar {
			get {
				return this.isPasswordMasked;
			}
			set {
				this.RT_TB.UseSystemPasswordChar = this.UseSystemPasswordChar;
				this.isPasswordMasked = value;
				base.Invalidate();
			}
		}

		public bool ReadOnly {
			get {
				return this._ReadOnly;
			}
			set {
				this._ReadOnly = value;
				this.RT_TB.ReadOnly = value;
				this.RT_TB.BackColor = Color.White;
			}
		}
		
		public bool TabStop {
			get {
				return this.RT_TB.TabStop;
			}
			set {
				base.TabStop = value;
				this.RT_TB.TabStop = value;
			}
		}

		public bool Multiline {
			get {
				return this._Multiline;
			}
			set {
				this._Multiline = value;
				if (this.RT_TB != null) {
					this.RT_TB.Multiline = value;
					if (value) {
						this.RT_TB.Height = base.Height - 10;
						return;
					}
					base.Height = this.RT_TB.Height + 10;
				}
			}
		}

		public SmoothingMode SmoothingType {
			get {
				return this._SmoothingType;
			}
			set {
				this._SmoothingType = value;
				base.Invalidate();
			}
		}

		public Color BorderColor {
			get {
				return this._BorderColor;
			}
			set {
				this._BorderColor = value;
				base.Invalidate();
			}
		}

		public Color CustomBGColor {
			get {
				return this._CustomBGColor;
			}
			set {
				this._CustomBGColor = value;
				base.Invalidate();
			}
		}
		
		public HorizontalAlignment TextAlign {
			get {
				return RT_TB.TextAlign;
			}
			set {
				this.RT_TB.TextAlign = value;
				base.Invalidate();
			}
		}
		
		

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			this.RT_TB.Text = this.Text;
			base.Invalidate();
		}

		private void OnBaseTextChanged(object s, EventArgs e)
		{
			this.Text = this.RT_TB.Text;
		}

		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.RT_TB.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.RT_TB.Font = this.Font;
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}

		private void _OnKeyDown(object Obj, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A) {
				this.RT_TB.SelectAll();
				e.SuppressKeyPress = true;
			}
			if (e.Control && e.KeyCode == Keys.C) {
				this.RT_TB.Copy();
				e.SuppressKeyPress = true;
			}
			
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this._Multiline) {
				this.RT_TB.Height = base.Height - 10;
			}
			else {
				base.Height = this.RT_TB.Height + 10;
			}
			this.Shape = new GraphicsPath();
			GraphicsPath expr_4A = this.Shape;
			expr_4A.AddArc(0, 0, 10, 10, 180f, 90f);
			expr_4A.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			expr_4A.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			expr_4A.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			expr_4A.CloseAllFigures();
		}

		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.RT_TB.Focus();
		}

		public void AddTextBox()
		{
			TextBox expr_06 = this.RT_TB;
			expr_06.Size = new Size(base.Width - 10, 33);
			expr_06.Location = new Point(7, 5);
			expr_06.Text = string.Empty;
			expr_06.BorderStyle = BorderStyle.None;
			expr_06.TextAlign = HorizontalAlignment.Left;
			expr_06.Font = new Font("Tahoma", 11f);
			expr_06.UseSystemPasswordChar = this.UseSystemPasswordChar;
			expr_06.Multiline = false;
			this.RT_TB.KeyDown += new KeyEventHandler(this._OnKeyDown);
			this.RT_TB.TextChanged += new EventHandler(this.OnBaseTextChanged);
		}

		public MinBox()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.AddTextBox();
			base.Controls.Add(this.RT_TB);
			this.P1 = new Pen(this.BorderColor);
			this.B1 = new SolidBrush(this.CustomBGColor);
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.Black;
			this.Text = null;
			this.Font = new Font("Tahoma", 11f);
			base.Size = new Size(110, 33);
			this.DoubleBuffered = true;
		}
		

		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics expr_1F = Graphics.FromImage(bitmap);
			expr_1F.SmoothingMode = this.SmoothingType;
			TextBox expr_31 = this.RT_TB;
			expr_31.Width = base.Width - 10;
			expr_31.TextAlign = this.TextAlignment;
			expr_31.UseSystemPasswordChar = this.UseSystemPasswordChar;
			expr_1F.Clear(this.BackColor);
			expr_1F.FillPath(this.B1, this.Shape);
			expr_1F.DrawPath(this.P1, this.Shape);
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			expr_1F.Dispose();
			bitmap.Dispose();
		}
	}
	
	public class MinComboBox : ComboBox {
		private int _StartIndex;
		private Color _HoverSelectionColor;
		private Color _ColorA = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
		private Color _ColorB = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
		private Color _ColorC = Color.FromArgb(242, 241, 240);
		private Color _ColorD = Color.FromArgb(253, 252, 252);
		private Color _ColorE = Color.WhiteSmoke;
		private Color _ColorF = Color.FromArgb(180, 180, 180);
		private Color _ColorG = Color.FromArgb(180, 180, 180);
		private Color _ColorH = Color.White;
		private Color _ColorI = Color.WhiteSmoke;
		
		public int StartIndex {
			get {
				return this._StartIndex;
			}
			set {
				this._StartIndex = value;
				try {
					base.SelectedIndex = value;
				}
				catch { }
				base.Invalidate();
			}
		}
		
		public Color HoverSelectionColor {
			get {
				return this._HoverSelectionColor;
			}
			set {
				this._HoverSelectionColor = value;
				base.Invalidate();
			}
		}
		
		public Color ColorA {
			get {
				return this._ColorA;
			}
			set {
				this._ColorA = value;
			}
		}
		
		public Color ColorB {
			get {
				return this._ColorB;
			}
			set
			{
				this._ColorB = value;
			}
		}
		
		public Color ColorC {
			get {
				return this._ColorC;
			}
			set {
				this._ColorC = value;
			}
		}
		
		public Color ColorD {
			get {
				return this._ColorD;
			}
			set {
				this._ColorD = value;
			}
		}
		
		public Color ColorE {
			get {
				return this._ColorE;
			}
			set {
				this._ColorE = value;
			}
		}
		
		public Color ColorF {
			get {
				return this._ColorF;
			}
			set {
				this._ColorF = value;
			}
		}
		
		public Color ColorG {
			get {
				return this._ColorG;
			}
			set {
				this._ColorG = value;
			}
		}
		
		public Color ColorH {
			get {
				return this._ColorH;
			}
			set {
				this._ColorH = value;
			}
		}
		
		public Color ColorI {
			get {
				return this._ColorI;
			}
			set {
				this._ColorI = value;
			}
		}
		
		protected override void OnDrawItem(DrawItemEventArgs e) {
			base.OnDrawItem(e);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(e.Bounds, this._ColorA, this._ColorB, 90f);
			if (Convert.ToInt32(e.State & DrawItemState.Selected) == 1) {
				if (e.Index != -1) {
					e.Graphics.FillRectangle(linearGradientBrush, e.Bounds);
					e.Graphics.DrawString(base.GetItemText(base.Items[e.Index]), e.Font, Brushes.WhiteSmoke, e.Bounds);
				}
			} else {
				if (e.Index != -1) {
					e.Graphics.FillRectangle(new SolidBrush(this._ColorC), e.Bounds);
					e.Graphics.DrawString(base.GetItemText(base.Items[e.Index]), e.Font, Brushes.DimGray, e.Bounds);
				}
			}
			linearGradientBrush.Dispose();
		}
		
		protected override void OnLostFocus(EventArgs e) {
			base.OnLostFocus(e);
			base.SuspendLayout();
			base.Update();
			base.ResumeLayout();
		}
		
		protected override void OnPaintBackground(PaintEventArgs e) {
			base.OnPaintBackground(e);
		}
		
		protected override void OnResize(EventArgs e) {
			base.OnResize(e);
			if (!this.Focused) {
				base.SelectionLength = 0;
			}
		}
		public MinComboBox() {
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.Selectable, false);
			base.DrawMode = DrawMode.OwnerDrawFixed;
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			this.BackColor = MaterialSkinManager.Instance.GetApplicationBackgroundColor();
			this.ForeColor = Color.Black;
			base.Size = new Size(135, 29);
			base.ItemHeight = 20;
			base.DropDownHeight = 100;
			this.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
			this.Cursor = Cursors.Hand;
		}
		
		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			e.Graphics.Clear(base.Parent.BackColor);
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			GraphicsPath graphicsPath = RoundRectangle.RoundRect(0, 0, base.Width - 1, base.Height - 1, 5);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, this._ColorD, this._ColorE, 90f);
			e.Graphics.SetClip(graphicsPath);
			e.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			e.Graphics.ResetClip();
			e.Graphics.DrawPath(new Pen(this._ColorF), graphicsPath);
			e.Graphics.DrawString(this.Text, new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), new SolidBrush(this.ForeColor), new Rectangle(3, 0, base.Width - 20, base.Height), new StringFormat
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Near
			});
			e.Graphics.DrawString("6", new Font("Marlett", 13f, FontStyle.Regular), new SolidBrush(this._ColorG), new Rectangle(3, 0, base.Width - 4, base.Height), new StringFormat
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Far
			});
			e.Graphics.DrawLine(new Pen(this._ColorH), base.Width - 24, 4, base.Width - 24, base.Height - 5);
			e.Graphics.DrawLine(new Pen(this._ColorI), base.Width - 25, 4, base.Width - 25, base.Height - 5);
			graphicsPath.Dispose();
			linearGradientBrush.Dispose();
		}
	}
}
