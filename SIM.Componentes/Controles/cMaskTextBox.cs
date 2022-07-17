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
    public partial class cMaskTextBox : MaskedTextBox
    {
        
        public void Limpar()
        {
            this.Text = string.Empty;
            this.Refresh();
        }
        
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.SelectAll();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.LightYellow;
            this.SelectAll();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            float[] dashValues = { 1, 1, 1, 1 };


            Rectangle areaFill = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
            LinearGradientBrush ngrad = new LinearGradientBrush(areaFill, Color.White, Color.White, LinearGradientMode.Vertical);

            Rectangle area0 = new Rectangle(new Point(0, 0), new Size((this.Width - 1), (this.Height - 1))); // coordenadas para desenhar a borda do controle
            Rectangle area1 = new Rectangle(new Point(1, 1), new Size((this.Width - 3), (this.Height - 3))); // area1, area2 e area3, definem a borda interna com efeito degradê
            Rectangle area2 = new Rectangle(new Point(2, 2), new Size((this.Width - 5), (this.Height - 5)));
            Rectangle area3 = new Rectangle(new Point(3, 3), new Size((this.Width - 7), (this.Height - 7)));

            if (this.Focused == false)
            {
                e.Graphics.FillRectangle(ngrad, areaFill);
            }
            if (this.Focused == true)
            {
                e.Graphics.FillRectangle(ngrad, areaFill); // desenhe fundo
                e.Graphics.DrawRectangle(Pens.Gainsboro, area1);
                e.Graphics.DrawRectangle(Pens.WhiteSmoke, area2);
                e.Graphics.DrawRectangle(Pens.White, area3);

                /*Pen bluePen = new Pen(Color.CornflowerBlue, 1);
                bluePen.DashPattern = dashValues;
                e.Graphics.DrawRectangle(bluePen, area2);*/

            }
                        
        }

    }
    
}
