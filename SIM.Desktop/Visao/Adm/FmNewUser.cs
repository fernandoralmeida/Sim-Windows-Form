using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Desktop.Visao.Adm
{
    public partial class FmNewUser : Forms.cForm
    {
        LogicaNegocios.IUsuarios User = Factories.Users();
        Entidade.Usuarios EUser = Factories.EntUsers();

        public FmNewUser()
        {
            InitializeComponent();
        }

        private void FmNewUser_Load(object sender, EventArgs e)
        {
            if (Classes.Autenticacao.GetAcesso() == Classes.Acesso.Intermediario)
            {
                cmbAcesso.Items.Remove("Intermediario");
                cmbAcesso.Items.Remove("Administrador");
                cmbAcesso.Items.Remove("Master");
                cmbModulo.Items.Remove("MCC - Modulo Contratos e Convênios");
                cmbModulo.Items.Remove("MPO - Modulo Portarias");
            }

            if (Classes.Autenticacao.GetAcesso() == Classes.Acesso.Administrador)
            {
                cmbAcesso.Items.Remove("Administrador");
                cmbAcesso.Items.Remove("Master");
                cmbModulo.Items.Remove("MCC - Modulo Contratos e Convênios");
                cmbModulo.Items.Remove("MPO - Modulo Portarias");
            }
            cmbAcesso.SelectedIndex = 0;
            cmbModulo.SelectedIndex = 0;
            cmbOutrosModulos.SelectedIndex = 0;
        }

        private void cButtonEnd_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cButtonGravar_Click(object sender, EventArgs e)
        {
            try
            {

                EUser.Nome = txtNome.Text;
                EUser.Usuario = txtMatricula.Text;
                EUser.Senha = txtMatricula.Text;
                EUser.Email = txtEmail.Text;
                EUser.Acesso = cmbAcesso.SelectedIndex;
                EUser.Modulo = cmbModulo.SelectedIndex;
                EUser.OutroModulos = 0;

                if (User.InsertNewUser(EUser).Equals(true))
                {
                    MessageBox.Show(string.Format("Usuário '{0}' registrado com sucesso!", txtMatricula.Text));
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { txtMatricula.Focus(); }
        }

        private void FmNewUser_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Orange, 0, 0, 60, this.Height);
            //e.Graphics.DrawRectangle(Pens.Gainsboro, 0, 0, this.Width - 1, this.Height - 1);
        }

    }
}
