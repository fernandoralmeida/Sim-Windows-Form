using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sim.Gui.Controls
{
    public partial class StripItem : ToolStripMenuItem
    {
        public StripItem()
        {
            InitializeComponent();
            MouseOnHover = OnHover.Off;
            PressState = ControlPressed.UnPressed;
        }

        public StripItem(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        
        private OnHover MouseOnHover { get; set; }

        private ControlPressed PressState { get; set; }

        protected override void OnMouseEnter(EventArgs e)
        {
            MouseOnHover = OnHover.On;
            base.OnMouseHover(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            PressState = ControlPressed.Pressed;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseOnHover = OnHover.Off;
            PressState = ControlPressed.UnPressed;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Brush font = Themes.Brushes.Font;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Center;
            //formatter.Alignment = StringAlignment.Center;
            RectangleF rectangle = new RectangleF(5, 0, this.Width, this.Height);
            
            if (MouseOnHover==OnHover.Off)
            {
                e.Graphics.FillRectangle(Themes.Brushes.Control, rect);
            }
            else
            {

                if(PressState == ControlPressed.UnPressed)
                    e.Graphics.FillRectangle(Themes.Brushes.ControlHighLight, rect);
                else
                    e.Graphics.FillRectangle(Themes.Brushes.ControlHighLightDark, rect);
                                
                font = Themes.Brushes.FontHighLight;
            }

            e.Graphics.DrawLine(Themes.Pens.ControlHighLight, 1, 0, 1, this.Height);
            e.Graphics.DrawLine(Themes.Pens.ControlHighLight, this.Width - 1, 0, this.Width - 1, this.Height);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            e.Graphics.DrawString(this.Text, this.Font, font, rectangle, formatter);
        }
        

    }
    
    public class StripSeparator : ToolStripSeparator
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Themes.Brushes.Control, 0, 0, this.Width, this.Height);
            e.Graphics.DrawLine(Themes.Pens.ControlDarkDark, 5, 2, this.Width - 7, 2);
            e.Graphics.DrawLine(Themes.Pens.ControlLight, 5, 3, this.Width - 7, 3);
        }
    }
    
}
