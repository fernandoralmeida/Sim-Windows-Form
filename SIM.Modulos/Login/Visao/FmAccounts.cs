using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login.Visao
{
    public partial class FmAccounts : Sim.Gui.Forms.OwnedForm
    {

        public FmAccounts()
        {
            InitializeComponent();
            flexDataGrid2.AppTheme();
        }

        private void FmAccounts_Load(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void cButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cButtonNewUser_Click(object sender, EventArgs e)
        {
            FmNewUser FM = new FmNewUser(AcaoNaTela.Incluir, null);
            FM.Text = "SIM.Desktop.Novo Usuário";
            FM.ShowDialog();
            AtualizarDados();

        }

        private void AtualizarDados() { flexDataGrid2.ListarUsuarios(); }

    }
}
