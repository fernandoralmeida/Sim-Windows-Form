using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Portarias
{
    public partial class ucMenu : UserControl
    {

        private static IntPtr handleINC, handleCON, handleREL; //handleEDT;
        
        public ucMenu()
        {
            InitializeComponent();
        }

        private void ucMenu_Paint(object sender, PaintEventArgs e)
        {

            this.BackColor = Gui.Themes.Colors.ControlDark; //ColorTheme.ControleDark;
            lblModulo.BackColor = Gui.Themes.Colors.ControlDark;
            label4.ForeColor = Gui.Themes.Colors.Font;
            //e.Graphics.DrawLine(SystemPens.ControlDark, 0, 0, this.Width, 0);

            // ***** Desenha Triangulo *****
            SolidBrush cBrush = new SolidBrush(lblModulo.BackColor); // Cor
            System.Drawing.Drawing2D.FillMode nF = System.Drawing.Drawing2D.FillMode.Alternate; // Modo preenchimento

            PointF point1 = new PointF(108.0F, 20.0F); // Ponto inicial (60,20)
            PointF point2 = new PointF(118.0F, 30.0F); // Ponta do triangulo (70,30)
            PointF point3 = new PointF(108.0F, 40.0F); // Ponto final (60,40)

            PointF[] poly = { point1, point2, point3 };

            e.Graphics.FillPolygon(cBrush, poly, nF); // Triangulo
            // ******************************

            e.Graphics.DrawLine(Gui.Themes.Pens.ControlDark, 0, this.Height - 1, this.Width, this.Height - 1);
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {

        }

        private void cButtonColorINC_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {

                    if (handleINC == IntPtr.Zero)
                    {
                        Form FM = null;
                        FM = new Visao.FmIncluir();
                        FM.Text = "SIM.Desktop.Incluir";
                        FM.Show(Form.ActiveForm);
                        handleINC = FM.Handle;
                    }
                    else
                    {
                        FromHandle(handleINC).Focus();
                    }
                }
                catch
                {
                    handleINC = IntPtr.Zero;
                }
            } while (handleINC == IntPtr.Zero);
        }

        private void cButtonColorEDT_Click(object sender, EventArgs e)
        {

        }

        private void cButtonColorSCH_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    if (handleCON == IntPtr.Zero)
                    {
                        Form FM = null;
                        FM = new Visao.FmConsultar();
                        FM.Text = "SIM.Desktop.Consultas";
                        FM.Show(Form.ActiveForm);
                        handleCON = FM.Handle;
                    }
                    else
                    {
                        FromHandle(handleCON).Focus();
                    }
                }
                catch
                {
                    handleCON = IntPtr.Zero;
                }
            } while (handleCON == IntPtr.Zero);
        }

        private void cButtonColorREL_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    if (handleREL == IntPtr.Zero)
                    {
                        Form FM = null;
                        FM = new Visao.FmRel();
                        FM.Text = "SIM.Desktop.Relatórios";
                        FM.Show(Form.ActiveForm);
                        handleREL = FM.Handle;
                    }
                    else
                    {
                        FromHandle(handleREL).Focus();
                    }
                }
                catch
                {
                    handleREL = IntPtr.Zero;
                }
            } while (handleREL == IntPtr.Zero);
        }

        private void cButtonColorEndMod_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
