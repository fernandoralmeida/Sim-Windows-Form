using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Desktop.Visao.Adm
{
    public partial class FmLogIN : Forms.cForm
    {

        LogicaNegocios.IUsuarios User = Factories.Users();
        Entidade.Usuarios EUser = Factories.EntUsers();

        public FmLogIN()
        {
            InitializeComponent();
        }

        private void FmLogOnOff_Paint(object sender, PaintEventArgs e)
        {

            //renderiza Imagem da Chave            
            e.Graphics.DrawImage(Sim.Desktop.Properties.Resources._8271_128x128, new Point(0, (this.Height - Sim.Desktop.Properties.Resources._8271_128x128.Height) / 2));

            //Desenha borda em todos os controles textbox
            /*
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Componentes.Controles.cTextBox)
                    e.Graphics.FillRectangle(myB, ctrl.Left - 1, ctrl.Top - 1, ctrl.Width + 2, ctrl.Height + 2);
            }
            */
        }

        private void FmLogOnOff_Load(object sender, EventArgs e)
        {  }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntLogOn_Click(object sender, EventArgs e)
        {
            try
            {

                EUser.Usuario = txtUser.Text;
                EUser.Senha = txtPass.Text;

                if (User.VerificarUsuario(EUser).Equals(true))              
                    this.Close();

                else
                    this.Text = string.Format("SIM.Desktop.LogIN [{0}]", User.TentativasLogIN());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SIM.Aviso");
            }
        }

        private void FmLogIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}
