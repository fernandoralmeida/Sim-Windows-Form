using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Componentes.Formularios
{
    public partial class FormOutPut : Sim.Forms.xForm
    {

        public FormOutPut()
        {
            InitializeComponent();
        }

        public void OutPut(string message)
        {
            listBoxOutPut.Items.Add(message);
            if (listBoxOutPut.Items.Count > 0)
                listBoxOutPut.SelectedIndex = listBoxOutPut.Items.Count - 1;
        }

        private void cButtonColor1_Click(object sender, EventArgs e)
        {
            listBoxOutPut.Items.Clear();
        }

    }
}
