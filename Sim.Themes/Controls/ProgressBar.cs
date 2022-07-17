using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Sim.Gui.Controls
{
    public partial class ProgressBar : Control
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        public ProgressBar(IContainer container)
        {
            container.Add(this);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }

        int nvalor = 0, minvalor = 0, maxvalor = 100;
        int valorwidth = 0;
        string npercent;
        bool vpercent = false;

        public bool PercentYN
        {
            get { return vpercent; }
            set { vpercent = value; Invalidate(); }
        }

        public int Valor
        {
            get { return nvalor; }
            set
            {
                nvalor = value;
                if (nvalor > 100) { nvalor = 100; }
                if (nvalor < 0) { nvalor = 0; }
                if (PercentYN == true)
                    npercent = Convert.ToString((Valor * 100) / ValorMaximo) + "%";
                valorwidth = ((this.Width) * nvalor) / 100;
                Invalidate();
            }
        }

        public int ValorMinimo
        {
            get { return minvalor; }
            set { minvalor = value; Invalidate(); }

        }

        public int ValorMaximo
        {
            get { return maxvalor; }
            set { maxvalor = value; Invalidate(); }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Themes.Dynamics.SetColor();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);            

            int x = this.Width;
            int y = this.Height;

            SolidBrush cfundo = Themes.SolidBrushes.Control;
            SolidBrush cpgbar = Themes.SolidBrushes.ControlHighLight;

            if (Valor > 0)
            {
                cfundo = Themes.SolidBrushes.ControlDark;
            }

            e.Graphics.FillRectangle(cfundo, new Rectangle(new Point(0, 0), new Size(x, y)));
            e.Graphics.FillRectangle(cpgbar, new Rectangle(new Point(0, 0), new Size(valorwidth, y)));

            /*
            Pen cborda = new Pen(Componentes.Classes.ColorTheme.Controle, 1);

            SolidBrush cfundo = Componentes.Classes.ColorTheme.SolidBrush;
            SolidBrush cpgbar = new SolidBrush(Componentes.Classes.ColorTheme.Highlight);
            SolidBrush cfont = new SolidBrush(Componentes.Classes.ColorTheme.ForeColor);

            Rectangle area0 = new Rectangle(new Point(0, 0), new Size(x, y));
            Rectangle areaborda = new Rectangle(new Point(0, 0), new Size(x - 1, y - 1));
            Rectangle pgbar = new Rectangle(new Point(2, 2), new Size(valorwidth - 4, y - 4));

            e.Graphics.FillRectangle(cfundo, area0);
            e.Graphics.FillRectangle(cpgbar, pgbar);
            e.Graphics.DrawRectangle(cborda, areaborda);
            */
            /*if (Valor < ((x + 50) / 2))
                cfont = new SolidBrush(ControleColor);
            else
                cfont = new SolidBrush(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            if (PercentYN == true)
                e.Graphics.DrawString(npercent, this.Font, cfont, (this.Width - e.Graphics.MeasureString(npercent, this.Font).Width) / 2, (this.Height - e.Graphics.MeasureString(npercent, this.Font).Height) / 2);
                */
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

    }
}
