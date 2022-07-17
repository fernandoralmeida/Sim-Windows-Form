using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Contratos.Visao
{
    public partial class FmIncluir : Gui.Forms.OwnedForm
    {
        public FmIncluir()
        {
            InitializeComponent();
        }

        private void FmIncluir_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Classes.Formularios.CadastroAtivo = false;
            this.Dispose();
        }
    }
}
