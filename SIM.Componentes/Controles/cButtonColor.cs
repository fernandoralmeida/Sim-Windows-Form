using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using Sim.Componentes.Classes;

namespace Sim.Controles
{
    public partial class cButtonColor : cButton
    {

        int render = 0;
        bool mouseOn, focusOn;
        
        public Color CorNormal { get; set; }
        public Color CorSombra { get; set; }
        public Color CorPress { get; set; }
        public Pen BorPress { get; set; }
        
        public cButtonColor()
        {
            InitializeComponent();
        }

        public cButtonColor(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            render = 0;
            focusOn = true;
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            render = 0;
            focusOn = false;
            Invalidate(); 
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            render = 0;
            mouseOn = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            render = 0;
            mouseOn = false;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            render = 0;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
                render = 1;
            Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Return)
                render = 1;
            Invalidate();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyValue == 13)
                render = 0;
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

            ColorTheme.GetTheme();
 
            CorNormal = ColorTheme.Controle;// SimColors.Cor;
            CorSombra = ColorTheme.ControleDark;// SimColors.CorShadow;
            CorPress = ColorTheme.ControleDarkDark; //.CorShadow;
            BorPress = ColorTheme.PenDarkDark; // SimColors.myPenSubShadow;

            Pen borda = ColorTheme.PenDark; // SimColors.myPenShadow; //new Pen(CorSombra, 1);
            Pen borda2 = ColorTheme.PenDarkDark;

            float[] dashValues = { 1, 1, 1, 1 };

            Rectangle areaFill = new Rectangle(new Point(0, 0), this.ClientSize);
            Rectangle contorno = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Rectangle contorno2 = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));
            Rectangle areafocus = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));
            Rectangle areaprss = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));
            LinearGradientBrush ngrad = new LinearGradientBrush(areaFill, CorNormal, CorSombra, LinearGradientMode.Vertical);
            LinearGradientBrush glass = new LinearGradientBrush(areaprss, ColorTheme.Highlight, ColorTheme.HighlightShadow, LinearGradientMode.Vertical);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            if (render == 0)
            {
                e.Graphics.FillRectangle(ngrad, areaFill);
                if (focusOn == true)
                {
                    Pen bluePen = new Pen(ColorTheme.HighlightDark, 1);
                    bluePen.DashPattern = dashValues;
                    e.Graphics.DrawRectangle(bluePen, areafocus);
                }
                if (mouseOn == true)
                {
                    Pen orangePen = new Pen(ColorTheme.HighlightShadow, 1);
                    orangePen.DashPattern = dashValues;
                    e.Graphics.DrawRectangle(orangePen, areafocus);
                    e.Graphics.FillRectangle(glass, areaprss);
                    //borda = new Pen(ColorTheme.HighShadow, 1);
                    borda2 = new Pen(ColorTheme.HighlightDark, 1);
                }

                e.Graphics.DrawRectangle(borda2, contorno2);
                e.Graphics.DrawString(this.Text, this.Font, ColorTheme.FontBrush, (this.Width - e.Graphics.MeasureString(this.Text, this.Font).Width) / 2, (this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2);
            
            }
            else if (render == 1)
            {
                ngrad = new LinearGradientBrush(areaFill, CorSombra, CorNormal, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(ngrad, areaFill);
                Pen blackPen = new Pen(Color.Gray, 1);
                blackPen.DashPattern = dashValues;
                e.Graphics.DrawRectangle(blackPen, areafocus);
                e.Graphics.DrawRectangle(ColorTheme.Pen, areaprss);
                e.Graphics.DrawString(this.Text, this.Font, ColorTheme.FontBrush, (this.Width - e.Graphics.MeasureString(this.Text, this.Font).Width) / 2, ((this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2) + 1);
            }

            e.Graphics.DrawRectangle(borda, contorno);
            /*
            LinearGradientBrush ngrad2 = new LinearGradientBrush(areaFill, Color.FromArgb(75, Color.Red), Color.FromArgb(75, Color.DarkRed), LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(ngrad2, areaprss);
            */
            if (this.Enabled.Equals(false))
            {
                ngrad = new LinearGradientBrush(areaFill, CorSombra, CorSombra, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(ngrad, areaFill);
                e.Graphics.DrawRectangle(ColorTheme.PenDark, contorno);
                e.Graphics.DrawString(this.Text, this.Font, ColorTheme.DisableFont, (this.Width - e.Graphics.MeasureString(this.Text, this.Font).Width) / 2, ((this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2) + 1);
            }
            
        }

    }
}
