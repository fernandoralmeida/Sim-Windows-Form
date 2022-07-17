using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;


namespace Sim.Gui.Controls
{

    public partial class ControlBox : System.Windows.Forms.Button
    {

        ControlBoxIcons DrawIcon = new ControlBoxIcons();

        public ControlBox()
        {
            InitializeComponent();
        }

        public ControlBox(IContainer container)
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
            StateButton = ControlPressed.UnPressed;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            StateButton = ControlPressed.Pressed;
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button == MouseButtons.Left)
            {                
                switch(TypeControlBox)
                {
                    case ControlBoxType.Maximize:
                        TypeControlBox = ControlBoxType.Restore;
                        break;

                    case ControlBoxType.Restore:
                        TypeControlBox = ControlBoxType.Maximize;
                        break;
                }
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Brush controlcolor = Themes.Brushes.Control;

            Pen coloricon = Themes.Pens.Font;

            Rectangle areaFill = new Rectangle(new Point(0, 0), this.ClientSize);

            if (StateButton == ControlPressed.UnPressed)
            {

                if ( MouseOnHover == OnHover.On)
                {
                    if (TypeControlBox == ControlBoxType.End)
                    {
                        controlcolor = Brushes.Crimson;
                        coloricon = Pens.White;
                    }
                    else
                    {
                        controlcolor = Themes.Brushes.ControlHighLight;
                        coloricon = Themes.Pens.FontHighlight;
                    }
                }
                else
                {
                    controlcolor = Themes.Brushes.Control;
                }
            }
            else if (StateButton == ControlPressed.Pressed)
            {
                if (TypeControlBox == ControlBoxType.End)
                {
                    controlcolor = Brushes.Brown;
                    coloricon = Pens.White;
                }
                else
                {
                    controlcolor = Themes.Brushes.ControlHighLightDark;
                    coloricon = Themes.Pens.FontHighlight;
                }
            }

            pevent.Graphics.FillRectangle(controlcolor, areaFill);
            
            switch (TypeControlBox)
            {
                case ControlBoxType.Maximize:
                    DrawIcon.ResIcon(pevent, this.Size, coloricon);
                    break;
                case ControlBoxType.Minimize:
                    DrawIcon.MinIcon(pevent, this.Size, coloricon);
                    break;
                case ControlBoxType.Restore:
                    DrawIcon.MaxIcon(pevent, this.Size, coloricon);
                    break;
                case ControlBoxType.EndOwned:
                    DrawIcon.EndIcon(pevent, this.Size, coloricon);
                    break;
                case ControlBoxType.End:
                    DrawIcon.EndIcon(pevent, this.Size, coloricon);
                    break;
                default:
                    break;
            }
            
        }

    }

    internal class ControlBoxIcons
    {

        internal void EndIcon(PaintEventArgs e, Size size, Pen pen)
        {

            //System.Drawing.Drawing2D.FillMode nF = System.Drawing.Drawing2D.FillMode.Alternate; // Modo preenchimento

            PointF point1 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) - 5.0F); // Ponto inicial (60,20)
            PointF point2 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2) + 5.0F);

            PointF point3 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) + 5.0F);
            PointF point4 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2) - 5.0F);

            PointF[] polyI = { point1, point2 };
            PointF[] polyII = { point3, point4 };

            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPolygon(pen, polyI); 
            e.Graphics.DrawPolygon(pen, polyII); 

        }

        internal void ResIcon(PaintEventArgs e, Size size, Pen pen)
        {
            
            //System.Drawing.Drawing2D.FillMode nF = System.Drawing.Drawing2D.FillMode.Alternate; // Modo preenchimento

            PointF point1 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) - 3.0F); // Ponto inicial (60,20)
            PointF point2 = new PointF(((float)size.Width / 2) + 3.0F, ((float)size.Height / 2) - 3.0F); // Ponta do triangulo (70,30)

            PointF point3 = new PointF(((float)size.Width / 2) + 3.0F, ((float)size.Height / 2) - 3.0F); // Ponto final (60,40)
            PointF point4 = new PointF(((float)size.Width / 2) + 3.0F, ((float)size.Height / 2) + 5.0F); // Ponto final (60,40)

            PointF point5 = new PointF(((float)size.Width / 2) + 3.0F, ((float)size.Height / 2) + 5.0F); // Ponto inicial (60,20)
            PointF point6 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) + 5.0F); // Ponta do triangulo (70,30)

            PointF point7 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) + 5.0F); // Ponto final (60,40)
            PointF point8 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) - 3.0F); // Ponto final (60,40)

            PointF[] poly = { point1, point2, point3, point4, point5, point6, point7, point8 };

            PointF point9 = new PointF(((float)size.Width / 2) - 3.0F, ((float)size.Height / 2) - 5.0F); // Ponto inicial (60,20)
            PointF point10 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2) - 5.0F); // Ponta do triangulo (70,30)

            PointF point11 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2) - 5.0F); // Ponto final (60,40)
            PointF point12 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2) + 3.0F); // Ponto final (60,40)

            PointF[] polyII = { point9, point10, point11, point12 };

            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPolygon(pen, poly); 
            e.Graphics.DrawLines(pen, polyII);            
                
        }

        internal void MaxIcon(PaintEventArgs e, Size size, Pen pen)
        {

            //System.Drawing.Drawing2D.FillMode nF = System.Drawing.Drawing2D.FillMode.Alternate; // Modo preenchimento

            PointF point1 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) - 5.0F); // Ponto inicial (60,20)
            PointF point2 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2) - 5.0F); // Ponta do triangulo (70,30)

            PointF point3 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2) - 5.0F); // Ponto final (60,40)
            PointF point4 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2) + 5.0F); // Ponto final (60,40)

            PointF point5 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2) + 5.0F); // Ponto inicial (60,20)
            PointF point6 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) + 5.0F); // Ponta do triangulo (70,30)

            PointF point7 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) + 5.0F); // Ponto final (60,40)
            PointF point8 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2) - 5.0F); // Ponto final (60,40)

            PointF[] poly = { point1, point2, point3, point4, point5, point6, point7, point8 };

            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPolygon(pen, poly); 
            
        }

        internal void MinIcon(PaintEventArgs e, Size size, Pen pen)
        {

            //System.Drawing.Drawing2D.FillMode nF = System.Drawing.Drawing2D.FillMode.Alternate; // Modo preenchimento

            PointF point1 = new PointF(((float)size.Width / 2) - 5.0F, ((float)size.Height / 2)); // Ponto inicial (60,20)
            PointF point2 = new PointF(((float)size.Width / 2) + 5.0F, ((float)size.Height / 2)); // Ponta do triangulo (70,30)
            //PointF point3 = new PointF((float)area.Width - 09.0F, ((float)area.Height / 2) - 3.0F); // Ponto final (60,40)

            PointF[] poly = { point1, point2 };

            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            e.Graphics.DrawPolygon(pen, poly);

        }

    }

}
