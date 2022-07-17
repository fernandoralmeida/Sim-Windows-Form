using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Contratos.Visao
{
    public partial class FmConsultar : Gui.Forms.OwnedForm
    {
        public FmConsultar()
        {
            InitializeComponent();
        }

        private void FmConsultar_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Classes.Formularios.ConsultaAtiva = false;
            this.Dispose();
        }
    }
}
