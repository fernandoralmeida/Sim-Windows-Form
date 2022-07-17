using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sim.Gui.Controls
{
    public partial class GroupBox : System.Windows.Forms.GroupBox
    {
        public GroupBox()
        {
            InitializeComponent();
        }

        public GroupBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public GroupBoxType TypeGroupBox { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;


            if (TypeGroupBox == GroupBoxType.Default)
            {

                e.Graphics.FillRectangle(Themes.SolidBrushes.Control, 0, 0, this.Width, this.Height);

                e.Graphics.DrawRectangle(Themes.Pens.ControlDark, 1, 8, this.Width - 3, this.Height - 10);
                //e.Graphics.DrawRectangle(ColorTheme.PenDark, 0, 7, this.Width - 3, this.Height - 10);

                e.Graphics.FillRectangle(Themes.SolidBrushes.Control, 9, 0, e.Graphics.MeasureString(this.Text, this.Font).Width + 1, e.Graphics.MeasureString(this.Text, this.Font).Height);

                e.Graphics.DrawString(this.Text, this.Font, Themes.Brushes.Font, new PointF(10, 0));
            }
            else
            {
                e.Graphics.FillRectangle(Themes.SolidBrushes.Control, 0, 0, this.Width, this.Height);

                e.Graphics.DrawRectangle(Themes.Pens.ControlDark, 0, (int)e.Graphics.MeasureString(this.Text, this.Font).Height, this.Width - 1, this.Height - ((int)e.Graphics.MeasureString(this.Text, this.Font).Height) - 1);
                //e.Graphics.DrawRectangle(ColorTheme.PenDark, 0, 7, this.Width - 3, this.Height - 10);

                e.Graphics.FillRectangle(Themes.SolidBrushes.ControlDark, 0, 1, e.Graphics.MeasureString(this.Text, this.Font).Width + 1, e.Graphics.MeasureString(this.Text, this.Font).Height - 1);

                e.Graphics.DrawString(this.Text, this.Font, Themes.Brushes.Font, new PointF(1, 0));
            }

            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Label)
                {
                    c.ForeColor = Themes.Colors.Font;
                }
            }

        }
    }
}
