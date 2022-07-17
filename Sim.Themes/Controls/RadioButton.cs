using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Sim.Gui.Controls
{
    public partial class RadioButton : System.Windows.Forms.RadioButton
    {
        public RadioButton()
        {
            InitializeComponent();
        }

        public RadioButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private OnHover MouseOnHover { get; set; }

        private FocusType InFocus { get; set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            MouseOnHover = OnHover.Off;
            InFocus = FocusType.No;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            InFocus = FocusType.Yes;
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            InFocus = FocusType.No;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs eventargs)
        {
            base.OnMouseEnter(eventargs);
            MouseOnHover = OnHover.On;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs eventargs)
        {
            base.OnMouseLeave(eventargs);
            MouseOnHover = OnHover.Off;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (Appearance == Appearance.Button)
            {
                Pen linha = Themes.Pens.ControlDarkDark;
                Rectangle controlsize = new Rectangle(new Point(0, 0), this.ClientSize);
                Rectangle contorno = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
                Rectangle dashedarea = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));

                pevent.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                if (this.Checked == false)
                {

                    //pevent.Graphics.FillRectangle(Themes.Gradient.Normal(controlsize), controlsize);
                    Themes.StyleControl.Normal(Themes.ModeGradient.Glass, pevent, this.ClientSize);

                    if (MouseOnHover == OnHover.Off)
                    {
                        if (InFocus == FocusType.Yes)
                            pevent.Graphics.DrawRectangle(Themes.Pens.DashedHighLight, dashedarea);
                    }
                    else
                    {
                        //pevent.Graphics.FillRectangle(Themes.Gradient.OnHover(controlsize), controlsize);
                        Themes.StyleControl.OnHover(Themes.ModeGradient.Glass, pevent, this.ClientSize);
                        linha = Themes.Pens.ControlHighLightDarkDark;
                    }

                    pevent.Graphics.DrawRectangle(linha, contorno);
                    pevent.Graphics.DrawString(this.Text, this.Font, Themes.Brushes.Font, (this.Width - pevent.Graphics.MeasureString(this.Text, this.Font).Width) / 2, (this.Height - pevent.Graphics.MeasureString(this.Text, this.Font).Height) / 2);

                }
                else
                {
                    linha = Themes.Pens.ControlHighLightDarkDark;
                    pevent.Graphics.FillRectangle(Themes.SolidBrushes.ControlHighLight, controlsize);
                    pevent.Graphics.DrawRectangle(linha, contorno);
                    pevent.Graphics.DrawString(this.Text, this.Font, Themes.Brushes.FontHighLight, (this.Width - pevent.Graphics.MeasureString(this.Text, this.Font).Width) / 2, ((this.Height - pevent.Graphics.MeasureString(this.Text, this.Font).Height) / 2) + 1);
                }

                if (this.Enabled == false)
                {
                    pevent.Graphics.FillRectangle(Themes.Brushes.ControlDisable, controlsize);
                    pevent.Graphics.DrawRectangle(Themes.Pens.ControlDisable, contorno);
                    pevent.Graphics.DrawString(this.Text, this.Font, Themes.Brushes.FontDisable, (this.Width - pevent.Graphics.MeasureString(this.Text, this.Font).Width) / 2, ((this.Height - pevent.Graphics.MeasureString(this.Text, this.Font).Height) / 2) + 1);

                }
            }
        }

    }
}
