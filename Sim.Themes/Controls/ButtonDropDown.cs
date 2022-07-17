using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace Sim.Gui.Controls
{
    public partial class ButtonDropDown : Control
    {
        public ButtonDropDown()
        {
            InitializeComponent();
        }

        public ButtonDropDown(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private OnHover MouseOnHover { get; set; }

        private ControlPressed PressState { get; set; }

        public FocusType InFocus { get; set; }

        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }

            set
            {
                base.AutoSize = value;
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        public ToolStripItemCollection Items
        {
            get { return contextStrip.Items; }
            set { this.Items = value; }
        }

        protected override void OnCreateControl()
        {
            Themes.Dynamics.SetColor();
            MouseOnHover = OnHover.Off;
            InFocus = FocusType.No;
            PressState = ControlPressed.UnPressed;
            base.OnCreateControl();
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

        protected override void OnMouseEnter(EventArgs e)
        {
            MouseOnHover = OnHover.On;
            base.OnMouseEnter(e);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            MouseOnHover = OnHover.Off;
            base.OnMouseLeave(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {

            if (e.Button.Equals(MouseButtons.Left))
            {

                if (PressState == ControlPressed.Pressed)
                {
                    PressState = ControlPressed.UnPressed;
                    contextStrip.Close();
                }
                else
                {
                    PressState = ControlPressed.Pressed;
                    contextStrip.Show(this, new Point(-1, this.Height-1), ToolStripDropDownDirection.BelowRight);
                }
            }

            //this.IsDroppedDown = true;
            base.OnMouseDown(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen linhaexterna = Themes.Pens.ControlDark;
            Pen linhainterna = Themes.Pens.ControlDarkDark;

            Brush colorfont = Themes.Brushes.Font;

            Rectangle controlsize = new Rectangle(new Point(0, 0), this.ClientSize);

            Rectangle contornoexterno = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Rectangle contornointerno = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));

            Rectangle toggle = new Rectangle(new Point(this.Width - 27, 3), new Size(24, this.Height - 6));
            Rectangle dashedarea = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));

            //LinearGradientBrush gradient = Themes.Gradient.Normal(controlsize);
            //Themes.Style.Control(Themes.ModeGradient.Glass, pevent, this.ClientSize);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            e.Graphics.DrawRectangle(linhainterna, contornointerno);
            e.Graphics.DrawRectangle(linhaexterna, contornoexterno);

            if (PressState == ControlPressed.UnPressed)
            {

                //pevent.Graphics.FillRectangle(Themes.Gradient.Normal(controlsize), controlsize);
                Themes.StyleControl.Normal(Themes.ModeGradient.Frosted, e, this.ClientSize);

                if (MouseOnHover == OnHover.Off)
                {
                    if (InFocus == FocusType.Yes)
                        e.Graphics.DrawRectangle(Themes.Pens.DashedHighLight, dashedarea);
                }
                else
                {
                    //gradient = Themes.Gradient.OnHover(controlsize);
                    //pevent.Graphics.FillRectangle(Themes.Gradient.OnHover(controlsize), controlsize);
                    Themes.StyleControl.OnHover(Themes.ModeGradient.Frosted, e, this.ClientSize);
                    //linhaexterna = Themes.Pens.ControlLight;
                    linhainterna = Themes.Pens.ControlHighLightDarkDark;
                    colorfont = Themes.Brushes.FontHighLight;
                }

                e.Graphics.DrawRectangle(linhaexterna, contornoexterno);
                e.Graphics.DrawRectangle(linhainterna, contornointerno);

            }
            else
            {
                linhainterna = Themes.Pens.ControlHighLight;
                //gradient = Themes.Gradient.OnPress(controlsize);
                //pevent.Graphics.FillRectangle(Themes.Gradient.OnPress(controlsize), controlsize);
                e.Graphics.FillRectangle(Themes.Brushes.ControlHighLight, controlsize);
                //Themes.StyleControl.OnPress(Themes.ModeGradient.Frosted, e, this.ClientSize);
                colorfont = Themes.Brushes.FontHighLight;
                e.Graphics.DrawRectangle(linhainterna, contornoexterno);

            }


            if (this.Enabled == false)
            {
                e.Graphics.FillRectangle(Themes.Brushes.ControlDisable, controlsize);
                e.Graphics.DrawRectangle(Themes.Pens.ControlDisable, contornoexterno);
                colorfont = Themes.Brushes.FontDisable;
            }

            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Center;

            RectangleF rectangle = new RectangleF(4, 0, this.Width, this.Height);

            if (e.Graphics.MeasureString(this.Text, this.Font).Width < this.Width - 20)
            {
                e.Graphics.DrawString(this.Text, this.Font, colorfont, rectangle, formatter);
            }
            else
            {
                float top = (this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2;
                rectangle = new RectangleF(4, top, this.Width - 25, e.Graphics.MeasureString(this.Text, this.Font).Height);
                e.Graphics.DrawString(this.Text, this.Font, colorfont, rectangle, formatter);
            }

            //pevent.Graphics.FillRectangle(gradient, toggle);

            // ***** Desenha Triangulo *****
            System.Drawing.Drawing2D.FillMode nF = System.Drawing.Drawing2D.FillMode.Alternate; // Modo preenchimento

            PointF point1 = new PointF((float)this.Width - 20.0F, ((float)this.Height / 2) - 3.0F); // Ponto inicial (60,20)
            PointF point2 = new PointF((float)this.Width - 15.0F, ((float)this.Height / 2) + 3.0F); // Ponta do triangulo (70,30)
            PointF point3 = new PointF((float)this.Width - 09.0F, ((float)this.Height / 2) - 3.0F); // Ponto final (60,40)

            PointF[] poly = { point1, point2, point3 };

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillPolygon(colorfont, poly, nF); // Triangulo
            // ******************************

            //e.Graphics.DrawRectangle(linhainterna, contornointerno);
            //e.Graphics.DrawRectangle(linhaexterna, contornoexterno);
            
                        
            base.OnPaint(e);

            if (AutoSize == true)
            {
                float tamanho = e.Graphics.MeasureString(this.Text, this.Font).Width;
                this.Width = 25 + Convert.ToInt32(tamanho);
            }

        }


    }
}
