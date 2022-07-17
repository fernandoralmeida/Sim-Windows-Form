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
    public partial class cRadioButton : RadioButton
    {

        Color corcheck = Color.White;
        Color coruncheck = Color.White;        
        Font vfont = Control.DefaultFont;
        private string subheader;
        bool mouseOn, focusOn;

        public cRadioButton()
        {
            InitializeComponent();
        }

        public cRadioButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public Font FontSub
        {
            get { return this.vfont; }
            set
            {
                this.vfont = value;
                Invalidate();
            }
        }

        public Color ColorChek
        {
            get { return this.corcheck; }
            set
            {
                this.corcheck = value;
                Invalidate();
            }
        }

        public Color ColorUncheck
        {
            get { return coruncheck; }
            set { this.coruncheck = value; Invalidate(); }
        }

        public string TextSub
        {
            get { return this.subheader; }
            set { this.subheader = value; Invalidate(); }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            focusOn = true;
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            focusOn = false;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseOn = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseOn = false;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            Invalidate();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            Invalidate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        /*    protected override void OnCheckedChanged(EventArgs e)
            {
                base.OnCheckedChanged(e);
                if (this.Checked == true)
                    this.BringToFront();
                else
                    this.SendToBack();
            } */

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen borda = new Pen(Color.LightGray, 1);
            SolidBrush sbCheck = new SolidBrush(ColorChek);
            SolidBrush sbUncheck = new SolidBrush(ColorUncheck);

            float[] dashValues = { 1, 1, 1, 1 };

            Rectangle areaFill = new Rectangle(new Point(0, 0), this.ClientSize);
            Rectangle contorno = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Rectangle areafocus = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));
            Rectangle areaprss = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));
            Rectangle ac2 = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));
            Rectangle ac1 = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));
            LinearGradientBrush ngrad = new LinearGradientBrush(areaFill, Color.White, Color.WhiteSmoke, LinearGradientMode.Vertical);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            e.Graphics.FillRectangle(sbUncheck, areaFill);
            //e.Graphics.DrawRectangle(borda, contorno);

            if (this.Checked == false)
            {

                if (focusOn == true)
                {
                    Pen bluePen = new Pen(Color.Black, 1);
                    bluePen.DashPattern = dashValues;
                    e.Graphics.DrawRectangle(bluePen, areafocus);
                }
                if (mouseOn == true)
                {
                    Pen orangePen = new Pen(ColorChek, 1);
                    orangePen.DashPattern = dashValues;
                    e.Graphics.DrawRectangle(orangePen, areafocus);
                }

                e.Graphics.DrawString(this.Text, this.Font, Brushes.DimGray, (this.Width - e.Graphics.MeasureString(this.Text, this.Font).Width) / 2, ((this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2) - 10);
                e.Graphics.DrawString(TextSub, this.FontSub, Brushes.Gray, (this.Width - e.Graphics.MeasureString(TextSub, this.FontSub).Width) / 2, ((this.Height - e.Graphics.MeasureString(TextSub, this.FontSub).Height) / 2) + 10);

            }
            else if (this.Checked == true)
            {

                e.Graphics.FillRectangle(sbCheck, areaFill);
                e.Graphics.DrawString(this.Text, this.Font, Brushes.White, (this.Width - e.Graphics.MeasureString(this.Text, this.Font).Width) / 2, ((this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2) - 10);
                e.Graphics.DrawString(TextSub, this.FontSub, Brushes.WhiteSmoke, (this.Width - e.Graphics.MeasureString(TextSub, this.FontSub).Width) / 2, ((this.Height - e.Graphics.MeasureString(TextSub, this.FontSub).Height) / 2) + 10);
                if (sbCheck.Color.Equals(Color.White))
                    e.Graphics.DrawRectangle(Pens.Black, 2, 2, this.Width - 5, this.Height - 5);
                else
                    e.Graphics.DrawRectangle(Pens.White, 2, 2, this.Width - 5, this.Height - 5);
            }


        }

    }
}
