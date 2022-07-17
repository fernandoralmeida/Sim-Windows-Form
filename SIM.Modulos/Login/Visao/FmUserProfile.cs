using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Sim.Classes;

namespace Login.Visao
{
    public partial class FmUserProfile : Sim.Gui.Forms.OwnedForm
    {

        Negocios.IUsuarios User = Negocios.Factories.Users();
        Entidade.Usuarios EUser = Negocios.Factories.EntUsers();
        

        public FmUserProfile()
        {
            InitializeComponent();
        }

        private void FmUserProfile_Load(object sender, EventArgs e)
        {        }

        private void FmUserProfile_Shown(object sender, EventArgs e)
        {
            txtEmail.Text = Autenticado.UserEmail;
            txtMatricula.Text = Autenticado.UserId;
            txtNome.Text = Autenticado.UserName;
        }

        private void cButtonEndP_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cButtonEndU_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cButtonMail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dejesa alter seu email?", 
                "SIM.Perfil.do.Usuário", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning).Equals(DialogResult.Yes))
            {
                EUser.Email = txtEmail.Text;
                EUser.Identificador = Autenticado.UserId;
            }
        }

        private void cButtonPssw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dejesa alter seua senha?",
                "SIM.Perfil.do.Usuário",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning).Equals(DialogResult.Yes))
            {
                EUser.Senha = txtPass.Text;
                //EUser.NovaSenha = txtNPass.Text;
                EUser.Identificador = Autenticado.UserId;

                txtPass.Text = string.Empty;
                txtNPass.Text = string.Empty;
            }
        }

        private void FmUserProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        
        private void FmUserProfile_Paint(object sender, PaintEventArgs e)
        {
            //treeView1.BackColor = Sim.Componentes.Classes.ColorTheme.Controle;
        }

    }
}
