using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login.Visao
{
    public partial class FmLogIN : Sim.Gui.Forms.OwnedForm
    {

        Negocios.IUsuarios User = Negocios.Factories.Users();
        Entidade.Usuarios EUser = Negocios.Factories.EntUsers();

        public FmLogIN()
        {
            InitializeComponent();
        }

        private void FmLogOnOff_Paint(object sender, PaintEventArgs e)
        {

            //renderiza Imagem da Chave            
            e.Graphics.DrawImage(Properties.Resources._8271_128x128, new Point(0, (this.Height - Properties.Resources._8271_128x128.Height) / 2));
            //e.Graphics.DrawImage(Login.Properties.Resources._8271_128x128, new Point(0, 25));

            label1.ForeColor = Sim.Gui.Themes.Colors.Font;
            label2.ForeColor = Sim.Gui.Themes.Colors.Font;
        }

        private void FmLogOnOff_Load(object sender, EventArgs e)
        {  }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntLogOn_Click(object sender, EventArgs e)
        {

            User.AutenticarUsuario(TextUser.Text, TextPssw.Text);

            if (Autenticado.Valido.Equals(true))
            {
                this.Close();
            }
            else
            {
                this.Text = string.Format("SIM.Desktop.LogIN [{0}]", User.TentativasLogIN());
            }

        }

        private void FmLogIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}
