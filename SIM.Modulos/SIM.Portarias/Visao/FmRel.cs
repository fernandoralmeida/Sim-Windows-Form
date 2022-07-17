using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Portarias.Visao
{
    public partial class FmRel :  Gui.Forms.OwnedForm
    {
        public FmRel()
        {
            InitializeComponent();
        }

        private void FmRel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void FmRel_Load(object sender, EventArgs e)
        {
            var mpo = Negocios.Instanciar.NegociosPortarias();
            cDataGridView1.DataSource = mpo.MostrarTodosRegistros(); 
            this.Text += " [" + cDataGridView1.RowCount + "]";
        }
        
    }
}
