using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Sim.Gui.Controls
{
    public partial class Button : System.Windows.Forms.Button
    {
        public Button()
        {
            InitializeComponent();
        }

        public Button(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            Themes.Dynamics.SetColor();
            MouseOnHover = OnHover.Off;
            InFocus = FocusType.No;
            StateButton = ControlPressed.UnPressed;
            base.OnCreateControl();
        }

        private OnHover MouseOnHover { get; set; }

        private ControlPressed StateButton { get; set; }

        public ControlBoxType TypeControlBox { get; set; }

        public FocusType InFocus { get; set; }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            InFocus = FocusType.Yes;
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            InFocus = FocusType.No;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            
            base.OnMouseEnter(e);
            MouseOnHover = OnHover.On;
            this.BringToFront();
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseOnHover = OnHover.Off;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (mevent.Button == MouseButtons.Left)
                StateButton = ControlPressed.UnPressed;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left)
                StateButton = ControlPressed.Pressed;
            Invalidate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Pen linhaexterna = Themes.Pens.ControlDark;
            Pen linhainterna = Themes.Pens.ControlDarkDark;

            Brush font = Themes.Brushes.Font;

            Rectangle controlsize = new Rectangle(new Point(0, 0), this.ClientSize);

            Rectangle contornoexterno = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Rectangle contornointerno = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));

            Rectangle dashedarea = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));

            pevent.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Center;
            formatter.Alignment = StringAlignment.Center;

            RectangleF rectangle = new RectangleF(0, 0, this.Width, this.Height);            

            if (StateButton == ControlPressed.UnPressed)
            {

                //pevent.Graphics.FillRectangle(Themes.Gradient.Normal(controlsize), controlsize);
                Themes.StyleControl.Normal(Themes.ModeGradient.Frosted, pevent, this.ClientSize);

                if (MouseOnHover == OnHover.Off)
                {
                    if(InFocus == FocusType.Yes)
                        pevent.Graphics.DrawRectangle(Themes.Pens.DashedHighLight, dashedarea);
                }
                else
                {
                    //pevent.Graphics.FillRectangle(Themes.Gradient.OnHover(controlsize), controlsize);
                    Themes.StyleControl.OnHover(Themes.ModeGradient.Frosted, pevent, this.ClientSize);
                    Application.DoEvents();
                    //linhaexterna = Themes.Pens.ControlHighLightDarkDark;
                    linhainterna = Themes.Pens.ControlHighLightDarkDark;
                    font = Themes.Brushes.FontHighLight;
                }

                
                pevent.Graphics.DrawRectangle(linhaexterna, contornoexterno);
                pevent.Graphics.DrawRectangle(linhainterna, contornointerno);

            }
            else
            {

                //linhaexterna = Themes.Pens.ControlHighLight;
                linhainterna = Themes.Pens.ControlHighLightDark;

                font = Themes.Brushes.FontHighLight;

                //pevent.Graphics.FillRectangle(Themes.Gradient.OnPress(controlsize), controlsize);
                Themes.StyleControl.OnPress(Themes.ModeGradient.Frosted, pevent, this.ClientSize);
                pevent.Graphics.DrawRectangle(linhaexterna, contornoexterno);
                pevent.Graphics.DrawRectangle(linhainterna, contornointerno);

                rectangle = new RectangleF(0, 1, this.Width, this.Height);
            }

            
            if (this.Enabled == false)
            {
                pevent.Graphics.FillRectangle(Themes.Brushes.ControlDisable, controlsize);
                pevent.Graphics.DrawRectangle(Themes.Pens.ControlDisable, contornoexterno);
                font = Themes.Brushes.FontDisable;
            }

            pevent.Graphics.DrawString(this.Text, this.Font, font, rectangle, formatter);

        }

    }
}
