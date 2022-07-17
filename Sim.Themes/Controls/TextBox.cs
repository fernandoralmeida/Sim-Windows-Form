using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;


namespace Sim.Gui.Controls
{
    public partial class TextBox : Control
    {

        char psswchar;

        public TextBox()
        {
            InitializeComponent();
        }

        public TextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region Propriedades

        private FocusType InFocus { get; set; }

        public bool isReadOnly
        {
            get { return itextBox.ReadOnly; }
            set { itextBox.ReadOnly = value; }
        }
        public bool isLetter { get; set; }

        public bool isNumeric
        {
            get;
            set;
        }

        public char PsswChar
        {
            get { return psswchar; }
            set { psswchar = value; itextBox.PasswordChar = psswchar; }
        }

        public CharacterCasing CharacterCase
        {
            get { return itextBox.CharacterCasing; }
            set
            {
                itextBox.CharacterCasing = value;
            }
        }

        public override string Text
        {
            get
            {
                return itextBox.Text;
            }
            set
            {
                itextBox.Text = value;
            }
        }

        public bool Multiline
        {
            get { return itextBox.Multiline; }
            set { itextBox.Multiline = value; if (Multiline == true) { itextBox.ScrollBars = ScrollBars.Vertical; } Invalidate(); }
        }

        public AutoCompleteMode AutoCompleteMode
        {
            get { return itextBox.AutoCompleteMode; }
            set { itextBox.AutoCompleteMode = value; }
        }

        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return itextBox.AutoCompleteCustomSource; }
            set { itextBox.AutoCompleteCustomSource = value; }
        }

        public AutoCompleteSource AutoCompleteSource
        {
            get { return itextBox.AutoCompleteSource; }
            set { itextBox.AutoCompleteSource = value; }
        }

        #endregion

        #region Overrides Protected

        protected override void OnCreateControl()
        {
            Themes.Dynamics.SetColor();
            InFocus = FocusType.No;
            base.OnCreateControl();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            itextBox.Focus();
        }

        protected override void OnEnter(EventArgs e)
        {
            InFocus = FocusType.Yes;
            base.OnEnter(e);
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            InFocus = FocusType.No;
            base.OnLeave(e);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);

            this.BackColor = Themes.Colors.ControlDark;

            Rectangle contornoexterno = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Rectangle contornointerno = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));

            if (InFocus == FocusType.Yes)
            {
                e.Graphics.DrawRectangle(Themes.Pens.ControlDark, contornoexterno);
                e.Graphics.DrawRectangle(Themes.Pens.ControlHighLight, contornointerno);
            }
            else
            {
                e.Graphics.DrawRectangle(Themes.Pens.ControlDark, contornoexterno);
                e.Graphics.DrawRectangle(Themes.Pens.ControlDarkDark, contornointerno);
            }

            //*** Posiciona TextBox:
            int x = 5, y = 0;

            if (Multiline.Equals(false))
            {
                y = ((this.Height - itextBox.Height) / 2) + 1;
                itextBox.Location = new Point(x, y);
                itextBox.Width = this.Width - 10;
            }
            else
            {
                y = 5;
                itextBox.Location = new Point(x, y);
                itextBox.Size = new Size(this.Width - 10, this.Height - 10);
            }

            itextBox.ForeColor = Themes.Colors.Font;
            itextBox.BackColor = this.BackColor;

            if (this.Enabled == false)
                itextBox.ForeColor = Themes.Colors.FontDisable;            

        }

        #endregion

        #region Eventos textbox

        private void itextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (isNumeric.Equals(true))
            {
                if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }

            if (isLetter.Equals(true))
            {
                if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar)))
                    e.Handled = true;
            }

        }
        
        #endregion

    }
}
