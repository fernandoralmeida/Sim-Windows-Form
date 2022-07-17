using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace Sim.Desktop.Visao
{
    public partial class FmLoad : Form
    {
        public FmLoad()
        {
            InitializeComponent();
        }

        private void FmLoad_Load(object sender, EventArgs e)
        { }

        private void FmLoad_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int progresso = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(1);
            progresso += 5;
            cProgressBar1.Valor = progresso;
            if (cProgressBar1.Valor.Equals(100))
            {
                timer1.Enabled = false;
                this.Dispose();
                GC.Collect();
            }
        }
    }
}
