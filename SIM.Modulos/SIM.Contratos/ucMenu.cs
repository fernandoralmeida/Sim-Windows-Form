using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Contratos
{
    public partial class ucMenu : UserControl
    {

        //private static IntPtr handleINC, handleEDT, handleCON, handleREL;

        //Classes.Colors MyColors = new Classes.Colors();

        public ucMenu()
        {
            InitializeComponent();
        }

        private void ucMenu_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Sim.Gui.Themes.Colors.ControlDark;
            lblModulo.BackColor = Sim.Gui.Themes.Colors.ControlDark;
            label4.ForeColor = Sim.Gui.Themes.Colors.Font;
            //e.Graphics.DrawLine(SystemPens.ControlDark, 0, 0, this.Width, 0);

            // ***** Desenha Triangulo *****
            /*
            SolidBrush cBrush = new SolidBrush(lblModulo.BackColor); // Cor
            System.Drawing.Drawing2D.FillMode nF = System.Drawing.Drawing2D.FillMode.Alternate; // Modo preenchimento

            PointF point1 = new PointF(108.0F, 20.0F); // Ponto inicial (60,20)
            PointF point2 = new PointF(118.0F, 30.0F); // Ponta do triangulo (70,30)
            PointF point3 = new PointF(108.0F, 40.0F); // Ponto final (60,40)

            PointF[] poly = { point1, point2, point3 };
            
            e.Graphics.FillPolygon(cBrush, poly, nF); // Triangulo
            // ******************************
            

            e.Graphics.DrawLine(ColorTheme.PenDark, 0, this.Height - 1, this.Width, this.Height - 1);
            */
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {

        }

        private void cButtonColorEndMod_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
