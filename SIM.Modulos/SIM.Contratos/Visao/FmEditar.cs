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
    public partial class FmEditar : Gui.Forms.OwnedForm
    {
        public FmEditar()
        {
            InitializeComponent();
        }

        private void FmEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Classes.Formularios.EdicaoAtiva = false;
            this.Dispose();
        }
    }
}
