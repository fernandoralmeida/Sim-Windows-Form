using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sim.Controles
{
    public partial class cButtonImage : Button
    {

        Classes.Colors SimColors = new Classes.Colors();

        int render = 0;
        bool mouseOn, focusOn;
        private string _subtext;
        Icon icone;
        Font _subfont;
        Color _pressedcolor;

        public cButtonImage()
        {
            InitializeComponent();
        }

        public cButtonImage(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public Color PressedColor
        {
            get { return _pressedcolor; }
            set { _pressedcolor = value; }
        }

        public Icon Icone
        {
            get { return icone; }
            set { this.icone = value; Invalidate(); }
        }

        public Font SubFont
        {
            get { return this._subfont; }
            set
            {
                this._subfont = value;
                Invalidate();
            }
        }

        public string SubText
        {
            get { return this._subtext; }
            set { this._subtext = value; Invalidate(); }
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

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            this.mouseOn = false;
            this.focusOn = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);

            Pen borda = SimColors.myPenShadow; // new Pen(SystemColors.ControlDark, 1);
            SolidBrush textcolor = new SolidBrush(SimColors.FontColor);

            float[] dashValues = { 1, 1, 1, 1 };

            Rectangle areaFill = new Rectangle(new Point(0, 0), this.ClientSize);
            Rectangle contorno = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Rectangle areafocus = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));
            Rectangle areaprss = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));
            LinearGradientBrush ngrad = new LinearGradientBrush(areaFill, SimColors.Cor, SimColors.Cor, LinearGradientMode.Vertical);

            if (this.Enabled.Equals(false))
            {
                ngrad = new LinearGradientBrush(areaFill, Color.Silver, Color.Silver, LinearGradientMode.Vertical);
            }

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            if (render == 0)
            {
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
            }
            else if (render == 1)
            {
                ngrad = new LinearGradientBrush(areaFill, PressedColor, PressedColor, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(ngrad, areaFill);
                Pen blackPen = new Pen(Color.DimGray, 1);
                blackPen.DashPattern = dashValues;
                e.Graphics.DrawRectangle(blackPen, areafocus);
                e.Graphics.DrawRectangle(Pens.DimGray, areaprss); //Obsoleto
                
            }

            if (this.Image != null)
                e.Graphics.DrawImage(this.Image, (this.Width - this.Image.Width) / 2, ((this.Height - this.Image.Height) / 2));
            
            if (this.Icone != null)
                e.Graphics.DrawIcon(this.Icone, (this.Width - this.Icone.Width) / 2, ((this.Height - this.Icone.Height) / 2));

            if (this.Image == null & this.Icone == null)
            {
                e.Graphics.DrawString(this.Text, this.Font, textcolor, (this.Width - e.Graphics.MeasureString(this.Text, this.Font).Width) / 2, ((this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2) - 10);
                e.Graphics.DrawString(SubText, this.SubFont, textcolor, (this.Width - e.Graphics.MeasureString(SubText, this.SubFont).Width) / 2, ((this.Height - e.Graphics.MeasureString(SubText, this.SubFont).Height) / 2) + 10);
            }
            
            e.Graphics.DrawRectangle(borda, contorno);

        }

    }
}
