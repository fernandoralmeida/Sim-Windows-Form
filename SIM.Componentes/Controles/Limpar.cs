using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sim.Controles
{
    public static class Limpar
    {
        public static void Todos(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                /*
                if (c is cTextBox)
                    c.Text = string.Empty;
                    */

                if (c is ComboBox)
                    c.Text = "...";

                if (c is Sim.Componentes.Controles.mskTextBox)
                    c.Text = string.Empty;

                if (c is Sim.Componentes.Controles.cComboBox)
                    c.Text = "...";

                if (c is Sim.Controles.cLabelTextBox)
                    c.Text = string.Empty;
                /*
                if (c is cMaskTextBox)
                    c.Text = string.Empty;
                    */
            }
        }
    }
}
