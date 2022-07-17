using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Sim.Gui.Controls
{
    public partial class MaskedTextBox : Control
    {
        public MaskedTextBox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        public MaskedTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        
        #region Propriedades

        private FocusType InFocus { get; set; }



        public MaskFormat MaskFormato
        {
            get { return imaskedTextBox.TextMaskFormat; }
            set { imaskedTextBox.TextMaskFormat = value; }
        }

        public string Mascara
        {
            get { return imaskedTextBox.Mask; }
            set { imaskedTextBox.Mask = value; }
        }

        public override string Text
        {
            get
            {
                return imaskedTextBox.Text;
            }
            set
            {
                imaskedTextBox.Text = value;
            }
        }

        public DateTime ToDate
        {
            get
            {
                DateTime value;
                if (!DateTime.TryParse(imaskedTextBox.Text, out value))
                {
                    imaskedTextBox.Text = DateTime.Today.ToShortDateString();
                }
                return Convert.ToDateTime(imaskedTextBox.Text);
            }
            set { imaskedTextBox.Text = value.ToString("dd/MM/yyyy"); }
        }

        #endregion

        #region Overrides

        protected override void OnCreateControl()
        {
            Themes.Dynamics.SetColor();
            InFocus = FocusType.No;
            base.OnCreateControl();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            imaskedTextBox.Focus();
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

        protected override void OnPaint(PaintEventArgs e)
        {

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

            int y;
            y = ((this.Height - imaskedTextBox.Height) / 2) + 1;
            imaskedTextBox.Location = new Point(5, y);
            imaskedTextBox.Width = this.Width - 10;
            imaskedTextBox.ForeColor = Themes.Colors.Font;
            imaskedTextBox.BackColor = this.BackColor;

            base.OnPaint(e);
        }

        #endregion

    }
}
