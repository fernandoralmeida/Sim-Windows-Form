using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Legislacao
{
    public partial class ucMenu : UserControl
    {

        IntPtr handleINC, handleCON, handleREL;        

        public ucMenu()
        {
            InitializeComponent();
        }

        private void cButtonColorEndMod_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ucMenu_Load(object sender, EventArgs e)
        { }

        private void cButtonColorINC_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    if (handleINC == IntPtr.Zero)
                    {
                        Form FM = null;
                        FM = new Visao.FmIncluir(Visao.Tela.ModoIncluir, null);
                        FM.Text = "Sim.Desktop.Incluir";
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

        private void cButtonColorSCH_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    if (handleCON == IntPtr.Zero)
                    {
                        Form FM = null;
                        FM = new Visao.FmConsulta();
                        FM.Text = "Sim.Desktop.Consultas";
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

        private void cButtonColorEDT_Click(object sender, EventArgs e)
        {   }

        private void cButtonColorREL_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    if (handleREL == IntPtr.Zero)
                    {
                        Form FM = null;
                        FM = new Visao.FmRelatorio();
                        FM.Text = "Sim.Desktop.Relatórios";
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

        private void cButtonColor1_Click(object sender, EventArgs e)
        {   }

        private void pBarMenu_Paint(object sender, PaintEventArgs e)
        {

            this.BackColor = Gui.Themes.Colors.ControlDark;
            pBarMenu.BackColor = Gui.Themes.Colors.ControlDark;
            lblModulo.BackColor = Gui.Themes.Colors.ControlDark;
            label4.ForeColor = Gui.Themes.Colors.Font;

        }

        private void cButtonColorUserProf_Click(object sender, EventArgs e)
        {    }

        void FormCollection(ref IntPtr hwnd)
        {
            FormCollection colecaoForms = Application.OpenForms;
            foreach(Form c in colecaoForms)
            {

                switch((int)hwnd)
                {
                    case 0:
                        hwnd = IntPtr.Zero;
                        break;

                    default:
                        break;
                }
                
            }
        }

    }
}
