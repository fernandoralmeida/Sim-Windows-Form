using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Desktop.Visao.Adm
{
    public partial class FmInfo : Form
    {
        // Informa sobre PC // OS // Aplicativo        
        Classes.AppMonitoring infoApp = new Classes.AppMonitoring();
        
        public FmInfo()
        {
            InitializeComponent();
        }

        private void FmInfo_Load(object sender, EventArgs e)
        {            
            this.Text = "SIM.Info.Sistema";
            timerP.Enabled = true;
            labelI.Text = infoApp.PcOsInfo();

            FileBox.DataSource = Classes.Modulos.ModulosExistentes(Application.StartupPath);
            
            int botton = Screen.PrimaryScreen.WorkingArea.Height;

            this.Location = new Point(0, (botton-this.Height));
        }

        private void timerP_Tick(object sender, EventArgs e)
        {
            labelM.Text = infoApp.AppInfo();
        }

        private void FmInfo_Shown(object sender, EventArgs e)
        {
            timerM.Enabled = true;
        }

        //int relogio = 0;
        private void timerM_Tick(object sender, EventArgs e)
        {

        }
    }
}
