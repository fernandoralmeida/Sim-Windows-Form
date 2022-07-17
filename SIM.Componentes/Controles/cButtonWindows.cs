using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using Sim.Componentes.Classes;

namespace Sim.Controles
{
    public partial class cButtonWindows : Button
    {

        int render = 0;
        bool mouseOn;
        buttonType vtypebutton;
        
        public cButtonWindows()
        {
            InitializeComponent();            
        }

        public cButtonWindows(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public enum buttonType
        {
            endbutton = 0,
            maxbutton = 1,
            minbutton = 2,
            resbutton = 3,
            endbuttonchild = 4
        }

        public buttonType TypeButton
        {
            get { return vtypebutton;  }
            set 
            { 
                vtypebutton = value;
                Invalidate();
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            render = 0;
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            render = 0;
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

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);            

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {               
                if (TypeButton == buttonType.resbutton)
                {
                    TypeButton = buttonType.maxbutton;
                }
                else if (TypeButton.Equals(buttonType.maxbutton))
                {
                    TypeButton = buttonType.resbutton;
                }
            }

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

            Brush areabrush = ColorTheme.Brush;
            Image imgbutton = null;

            Rectangle areaFill = new Rectangle(new Point(0, 0), this.ClientSize);

            if (render == 0)
            {
                         
                if (mouseOn == true)
                {
                    if (TypeButton == buttonType.endbutton)
                        areabrush = Brushes.Red;
                    else
                    {
                        areabrush = new SolidBrush(ColorTheme.Highlight);
                    }
                }
                else
                {
                    if (TypeButton == buttonType.endbutton)
                        areabrush = Brushes.Crimson;
                    else
                        areabrush = new SolidBrush(this.BackColor); // ColorTheme.SolidBrush;
                }
            }
            else if (render == 1)
            {
                if (TypeButton == buttonType.endbutton)
                    areabrush = Brushes.Brown;
                else
                {
                    areabrush = new SolidBrush(ColorTheme.HighlightShadow);// ColorTheme.SolidBrushDarkDark;
                }
            }

            if (TypeButton.Equals(buttonType.endbutton))
                imgbutton = Sim.Componentes.Properties.Resources.end;

            if (ColorTheme.Controle.R > 200 || ColorTheme.Controle.G > 200 || ColorTheme.Controle.B > 200 )
            {
                switch (TypeButton)
                {
                    case buttonType.resbutton:
                        imgbutton = Sim.Componentes.Properties.Resources.res_black;
                        break;
                    case buttonType.minbutton:
                        imgbutton = Sim.Componentes.Properties.Resources.min_black;
                        break;
                    case buttonType.maxbutton:
                        imgbutton = Sim.Componentes.Properties.Resources.max_black;
                        break;
                    case buttonType.endbuttonchild:
                        imgbutton = Sim.Componentes.Properties.Resources.end_black;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (TypeButton)
                {
                    case buttonType.resbutton:
                        imgbutton = Sim.Componentes.Properties.Resources.res;
                        break;
                    case buttonType.minbutton:
                        imgbutton = Sim.Componentes.Properties.Resources.min;
                        break;
                    case buttonType.maxbutton:
                        imgbutton = Sim.Componentes.Properties.Resources.max;
                        break;
                    case buttonType.endbuttonchild:
                        imgbutton = Sim.Componentes.Properties.Resources.end;
                        break;
                    default:
                        break;
                }
            }
            
            e.Graphics.FillRectangle(areabrush, areaFill);

            e.Graphics.DrawImage(imgbutton, (this.Width - imgbutton.Width) / 2, (this.Height - imgbutton.Height) / 2, 19, 19);              

        }

    }
}
