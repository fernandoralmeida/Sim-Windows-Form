using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sim.Classes;

namespace Sim.Desktop.Visao.Adm
{
    public partial class FmUserProfile : Forms.cForm
    {
        
        LogicaNegocios.IUsuarios User = Factories.Users();
        Entidade.Usuarios EUser = Factories.EntUsers();

        Colors myColors = new Colors();

        public FmUserProfile()
        {
            InitializeComponent();
        }

        private void FmUserProfile_Load(object sender, EventArgs e)
        {
            if (Autenticacao.GetAcesso() == Acesso.Comum)
            {
                tabControl1.TabPages.Remove(TabPageProfileUsers);
            }

            if (Autenticacao.GetAcesso() == Acesso.Intermediario)
            {

                if (TabPageProfileUsers == null)
                    tabControl1.TabPages.Add(TabPageProfileUsers);

                cmbAcessoG.Enabled = false;
                cmbModuloG.Enabled = false;
                cButtonExcUSer.Enabled = false;
                cButtonResSenha.Enabled = false;
                cButtonGravarAlt.Enabled = false;
                dgvUsers.Visible = false;

            }

            if (Autenticacao.GetAcesso() == Acesso.Administrador)
            {

                if (TabPageProfileUsers == null)
                    tabControl1.TabPages.Add(TabPageProfileUsers);
                
                cmbAcessoG.Items.Remove("Master");
            }

            if (Autenticacao.GetAcesso() == Acesso.Master)
            {
                if (TabPageProfileUsers == null)
                    tabControl1.TabPages.Add(TabPageProfileUsers);
            }
            this.TabPagePersonalProfile.Select();

            checkBoxAero.Checked = (Properties.Settings.Default.Aero.Equals(Aero.Ativo.Sim)) ? true : false;
            cRadioW.Checked = (Properties.Settings.Default.Theme.Equals(0)) ? true : false;
            cRadioO.Checked = (Properties.Settings.Default.Theme.Equals(1)) ? true : false;
            cRadioS.Checked = (Properties.Settings.Default.Theme.Equals(2)) ? true : false;
            cRadioB.Checked = (Properties.Settings.Default.Theme.Equals(3)) ? true : false;
            cRadioG.Checked = (Properties.Settings.Default.Theme.Equals(4)) ? true : false;
        }

        private void FmUserProfile_Shown(object sender, EventArgs e)
        {
            txtEmail.Text =Autenticacao.GetEmail();
            txtMatricula.Text = Autenticacao.GetUsuario();
            txtNome.Text = Autenticacao.GetNome();
            if (Autenticacao.GetAcesso() > Acesso.Intermediario)
            {
                AtualizarDados();
            }
            tabControl1.Visible = true;
        }
        
        private void dgvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvUsers.RowCount > 0 && e.RowIndex > -1)
            {
                txtMatriculaG.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNomeG.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEmailG.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbAcessoG.SelectedIndex = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[4].Value);
                cmbModuloG.SelectedIndex = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[5].Value);
                cmbOutrosModulos.SelectedIndex = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[6].Value);
            }
        }

        private void cButtonNewUser_Click(object sender, EventArgs e)
        {
            FmNewUser FM = new FmNewUser();
            FM.Text = "SIM.Desktop.NovoUsuário";
            tabControl1.Visible = false;
            this.BackColor = Color.Gainsboro;
            FM.ShowDialog(this);
            this.BackColor = Color.White;
            AtualizarDados();
            tabControl1.Visible = true;
        }

        private void cButtonEndP_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cButtonEndU_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cButtonGravarAlt_Click(object sender, EventArgs e)
        {

            EUser.Acesso = cmbAcessoG.SelectedIndex;
            EUser.Modulo = cmbModuloG.SelectedIndex;
            EUser.OutroModulos = cmbOutrosModulos.SelectedIndex;
            EUser.Usuario = txtMatriculaG.Text;
           
            if (User.UpDateProfileUser(EUser).Equals(true))
                MessageBox.Show("Sucesso");
            else
                MessageBox.Show("Falha");

            AtualizarDados();
        }

        private void cButtonExcUSer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Excluir Usuário?",
                "SIM.Perfil.do.Usuário",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning).Equals(DialogResult.Yes))
            {
                EUser.Usuario = txtMatriculaG.Text;
                if (User.DeleteUser(EUser).Equals(true))
                    MessageBox.Show("Usuário Excluído", "SIM.Perfil.do.Usuário");

                AtualizarDados();
            }
        }

        private void cButtonResSenha_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reiniciar senha?",
                "SIM.Perfil.do.Usuário",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning).Equals(DialogResult.Yes))
            {
                EUser.Senha = txtMatriculaG.Text;
                EUser.Usuario = txtMatriculaG.Text;
                if (User.ResetSenha(EUser).Equals(true))
                    MessageBox.Show("Senha reiniciada", "SIM.Perfil.do.Usuário");

                AtualizarDados();
            }
        }

        private void cButtonMail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dejesa alter seu email?", 
                "SIM.Perfil.do.Usuário", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning).Equals(DialogResult.Yes))
            {
                EUser.Email = txtEmail.Text;
                EUser.Usuario = Autenticacao.GetUsuario();
                if (User.UpDateEmail(EUser).Equals(true))
                {
                    Autenticacao.SetEmail(EUser.Email);
                    MessageBox.Show("Email alterado!", "SIM.Perfil.do.Usuário");
                }

                AtualizarDados();
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
                EUser.NovaSenha = txtNPass.Text;
                EUser.Usuario = Autenticacao.GetUsuario();
                if (User.UpDateSenha(EUser).Equals(true))
                    MessageBox.Show("Senha alterada!", "SIM.Perfil.do.Usuário");

                txtPass.Text = string.Empty;
                txtNPass.Text = string.Empty;
                AtualizarDados();
            }
        }

        private void AtualizarDados()
        {
            EUser.Acesso = Autenticacao.GetAcesso();
            dgvUsers.DataSource = User.GetUsers(EUser);
            dataGrid();
        }

        private void dataGrid()
        {
            if (Autenticacao.GetAcesso() > Acesso.Intermediario)
            {                
                dgvUsers.Columns[0].Visible = false;
                dgvUsers.Columns[2].Visible = false;
                dgvUsers.Columns[3].Visible = false;
                dgvUsers.Columns[4].Visible = false;
                dgvUsers.Columns[5].Visible = false;
                dgvUsers.Columns[6].Visible = false;
            }

        }

        private void FmUserProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void checkBoxAero_CheckedChanged(object sender, EventArgs e)
        {

            switch (checkBoxAero.Checked)
            {
                case true:
                    Properties.Settings.Default.Aero = Aero.Ativo.Sim;
                    goto default;

                case false:
                    Properties.Settings.Default.Aero = Aero.Ativo.Nao;
                    goto default;

                default:
                    Properties.Settings.Default.Save();
                    break;
            }

        }

        protected internal virtual void RadioButtons(object sender, EventArgs e)
        {
            RadioButton rDB = (RadioButton)sender;

            switch (rDB.Name)
            {
                case "cRadioW":
                    Properties.Settings.Default.Theme = 0;
                    goto default;
                case "cRadioO":
                    Properties.Settings.Default.Theme = 1;
                    goto default;
                case "cRadioS":
                    Properties.Settings.Default.Theme = 2;
                    goto default;
                case "cRadioB":
                    Properties.Settings.Default.Theme = 3;
                    goto default;
                case "cRadioG":
                    Properties.Settings.Default.Theme = 4;
                    goto default;
                case "cRadioY":
                    Properties.Settings.Default.Theme = 5;
                    goto default;
                default:
                    Properties.Settings.Default.Save();                    
                    break;
            }
        }

        void AtualizarThema(int valor)
        {
            Classes.CorAleatoria.Valor(valor);
            FormCollection colecao = Application.OpenForms;
            foreach (Form cfm in colecao)
            {
                cfm.Refresh();
            }
        }

        private void cbuttonApTheme_Click(object sender, EventArgs e)
        {
            Classes.CorAleatoria.Valor(Sim.Desktop.Properties.Settings.Default.Theme);

            //FormCollection colecaoForms = Application.OpenForms;
            /*
            foreach (Form allForms in colecaoForms)
            {

                allForms.Dispose();
                //pega o form pelo handle                
                //if (allForms.Handle.Equals(Logica.HandleF.FmDeskHandle))
                //{
                    //allForms.Refresh();
                //}
            }
            */
            
            if (MessageBox.Show("Reiniciar Sistema pra ativar o novo thema?", "Sim.Alerta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information).Equals(DialogResult.Yes))
                Application.Restart();
            
        }
       
    }
}
