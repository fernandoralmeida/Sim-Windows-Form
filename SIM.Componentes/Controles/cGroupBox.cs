using System.ComponentModel;
using System.Drawing;
using Sim.Componentes.Classes;

namespace Sim.Componentes.Controles
{
    public partial class cGroupBox : System.Windows.Forms.GroupBox
    {

        public enum groupBoxStyle { Normal, Windows }
                
        public cGroupBox()
        {
            SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, true);
            InitializeComponent();            
        }

        public cGroupBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public groupBoxStyle GroupBoxStyle { get; set; }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Brush ColorBase = new SolidBrush(this.BackColor);
            //Brush ColorBase = ColorTheme.SolidBrushLight;

            if (Properties.Settings.Default.WindowsColor.Equals(true))
            {
                ColorTheme.PenDark = Pens.Gainsboro;
            }


            if (GroupBoxStyle.Equals(groupBoxStyle.Normal))
            {

                e.Graphics.FillRectangle(ColorBase, 0, 0, this.Width, this.Height);

                e.Graphics.DrawRectangle(ColorTheme.PenDark, 1, 8, this.Width - 3, this.Height - 10);
                //e.Graphics.DrawRectangle(ColorTheme.PenDark, 0, 7, this.Width - 3, this.Height - 10);

                e.Graphics.FillRectangle(ColorBase, 9, 0, e.Graphics.MeasureString(this.Text, this.Font).Width + 1, e.Graphics.MeasureString(this.Text, this.Font).Height);

                e.Graphics.DrawString(this.Text, this.Font, ColorTheme.SolidBrushDarkDark, new PointF(10, 0));
            }
            else
            {
                e.Graphics.FillRectangle(ColorBase, 0, 0, this.Width, this.Height);

                e.Graphics.DrawRectangle(ColorTheme.PenDark, 0, (int)e.Graphics.MeasureString(this.Text, this.Font).Height, this.Width - 1, this.Height - ((int)e.Graphics.MeasureString(this.Text, this.Font).Height)-1);
                //e.Graphics.DrawRectangle(ColorTheme.PenDark, 0, 7, this.Width - 3, this.Height - 10);

                e.Graphics.FillRectangle(ColorTheme.SolidBrushDark, 0, 1, e.Graphics.MeasureString(this.Text, this.Font).Width + 1, e.Graphics.MeasureString(this.Text, this.Font).Height-1);

                e.Graphics.DrawString(this.Text, this.Font, ColorTheme.FontBrush, new PointF(1, 0));
            }

            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Label)
                {
                    if (Sim.Componentes.Properties.Settings.Default.WindowsColor.Equals(true))
                        c.ForeColor = Color.Black;
                    else
                        c.ForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;
                }
            }

        }

    }
}
