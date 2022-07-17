using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Sim.Gui.Controls
{
    public partial class Panel : System.Windows.Forms.Panel
    {
        public Panel()
        {
            InitializeComponent();
        }

        public Panel(IContainer container)
        {
            container.Add(this);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ContainerControl, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            InitializeComponent();
        }

        public bool Borda { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {

            this.BackColor = Themes.Colors.Control;

            Brush ColorBase = Themes.SolidBrushes.Control; //new SolidBrush(this.BackColor);

            e.Graphics.FillRectangle(ColorBase, 0, 0, this.Width, this.Height);

            if (Borda.Equals(true))
            {
                e.Graphics.DrawRectangle(Themes.Pens.ControlHighLight, 0, 0, this.Width - 1, this.Height - 1);
                //e.Graphics.DrawRectangle(ColorTheme.PenDark, 0, 7, this.Width - 3, this.Height - 10);
            }

            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Label)
                {
                    c.ForeColor = Themes.Colors.Font;
                }
            }

            base.OnPaint(e);
        }
    }
}
