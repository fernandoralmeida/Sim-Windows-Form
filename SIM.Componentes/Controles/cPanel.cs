using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Sim.Componentes.Controles
{
    public partial class cPanel : System.Windows.Forms.Panel
    {

        public cPanel()
        {
            InitializeComponent();
        }

        public cPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool Borda { get; set; }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Classes.ColorTheme.GetTheme();

            this.BackColor = Classes.ColorTheme.Controle;

            Brush ColorBase = Classes.ColorTheme.SolidBrush; //new SolidBrush(this.BackColor);

            e.Graphics.FillRectangle(ColorBase, 0, 0, this.Width, this.Height);

            if (Borda.Equals(true))
            {
                e.Graphics.DrawRectangle(new Pen(Classes.ColorTheme.Highlight, 1), 0, 0, this.Width - 1, this.Height - 1);
                //e.Graphics.DrawRectangle(ColorTheme.PenDark, 0, 7, this.Width - 3, this.Height - 10);
            }

            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Label)
                {
                    c.ForeColor = Classes.ColorTheme.ForeColor;
                }
            }

            base.OnPaint(e);

        }



    }
}
