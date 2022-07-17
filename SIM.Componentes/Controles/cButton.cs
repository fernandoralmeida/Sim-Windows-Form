using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sim.Controles
{
    public partial class cButton : Button
    {

        enum render { Normal, Press }

        int Render = 0;
        bool mouseOn, focusOn;

        Color borda = SystemColors.ControlDark;
        Color corinicial = Color.White;
        Color corfinal = Color.Gainsboro;
        Color corpress = Color.WhiteSmoke;
        Color corfont = Color.Black;

        public cButton()
        {
            InitializeComponent();
        }

        public cButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public Color Borda
        {
            get { return borda; }
            set { borda = value; }
        }

        public Color CorInicial { get { return corinicial; } set { corinicial = value; } }

        public Color CorFinal { get { return corfinal; } set { corfinal = value; } }

        public Color cCorPress { get { return corpress; } set { corpress = value; } }

        public Color CorFont { get { return corfont; } set { corfont = value; } }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            Render = (int)render.Normal;
            focusOn = true;
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            Render = (int)render.Normal;
            focusOn = false;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Render = (int)render.Normal;
            mouseOn = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Render = (int)render.Normal;
            mouseOn = false;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Render = (int)render.Normal;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
                Render = (int)render.Press;
            Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Return)
                Render = (int)render.Press;
            Invalidate();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyValue == 13)
                Render = (int)render.Normal;
            Invalidate(); 
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen borda = new Pen(Borda, 1);
            SolidBrush letra = new SolidBrush(CorFont);

            float[] dashValues = { 1, 1, 1, 1 };

            Rectangle areaFill = new Rectangle(new Point(0, 0), this.ClientSize);
            Rectangle contorno = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Rectangle areafocus = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));
            Rectangle areaprss = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));
            LinearGradientBrush ngrad = new LinearGradientBrush(areaFill, CorInicial, CorFinal, LinearGradientMode.Vertical);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            if (Render.Equals((int)render.Normal))
            {
                ngrad = new LinearGradientBrush(areaFill, CorInicial, CorFinal, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(ngrad, areaFill);
                if (focusOn == true)
                {
                    Pen bluePen = new Pen(Color.CornflowerBlue, 1);
                    bluePen.DashPattern = dashValues;
                    e.Graphics.DrawRectangle(bluePen, areafocus);
                }
                if (mouseOn == true)
                {
                    Pen orangePen = new Pen(Color.Orange, 1);
                    orangePen.DashPattern = dashValues;
                    e.Graphics.DrawRectangle(orangePen, areafocus);
                }
                e.Graphics.DrawString(this.Text, this.Font, letra, (this.Width - e.Graphics.MeasureString(this.Text, this.Font).Width) / 2, (this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2);
            }
            else if (Render.Equals((int)render.Press))
            {
                ngrad = new LinearGradientBrush(areaFill, CorFinal, cCorPress, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(ngrad, areaFill);
                Pen blackPen = new Pen(Color.Gray, 1);
                Pen penpress = new Pen(cCorPress, 1);
                blackPen.DashPattern = dashValues;
                e.Graphics.DrawRectangle(blackPen, areafocus);
                e.Graphics.DrawRectangle(penpress, areaprss);
                e.Graphics.DrawString(this.Text, this.Font, letra, (this.Width - e.Graphics.MeasureString(this.Text, this.Font).Width) / 2, ((this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2) + 1);
            }
            
            e.Graphics.DrawRectangle(borda, contorno);

            if (this.Enabled.Equals(false))
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, areaFill);
                e.Graphics.DrawRectangle(Pens.Gainsboro, contorno);
                e.Graphics.DrawString(this.Text, this.Font, Brushes.Gray, (this.Width - e.Graphics.MeasureString(this.Text, this.Font).Width) / 2, ((this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2) + 1);
            }
        }

    }
}
