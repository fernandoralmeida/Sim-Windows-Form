using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Sim.Componentes.Controles
{
    public partial class progressBar : ProgressBar
    {

        #region Construtores

        public progressBar()
        {
            InitializeComponent();
        }

        public progressBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #endregion

        #region Overrides

        protected override void OnPaint(PaintEventArgs e)
        {

            int x = this.Width;
            int y = this.Height;

            Pen cborda = Sim.Componentes.Classes.ColorTheme.PenDark;

            SolidBrush cfundo = Sim.Componentes.Classes.ColorTheme.SolidBrush;
            SolidBrush cpgbar = Sim.Componentes.Classes.ColorTheme.SolidBrushDark;
            //SolidBrush cfont = new SolidBrush(this.ForeColor);

            Rectangle area0 = new Rectangle(new Point(0, 0), new Size(x, y));
            Rectangle areaborda = new Rectangle(new Point(0, 0), new Size(x - 1, y - 1));
            Rectangle pgbar = new Rectangle(new Point(2, 2), new Size(Value - 4, y - 4));

            e.Graphics.FillRectangle(cfundo, area0);
            e.Graphics.FillRectangle(cpgbar, pgbar);
            e.Graphics.DrawRectangle(cborda, areaborda);

            base.OnPaint(e);
        }

        #endregion


    }
}
