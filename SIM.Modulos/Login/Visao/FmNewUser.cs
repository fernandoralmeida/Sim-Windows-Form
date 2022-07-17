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
    public partial class FmNewUser : Sim.Gui.Forms.OwnedForm
    {

        Negocios.IUsuarios User = Negocios.Factories.Users();
        Entidade.Usuarios EUser = Negocios.Factories.EntUsers();

        AcaoNaTela acaoSelecionada;

        public FmNewUser(AcaoNaTela acaonatela, Entidade.Usuarios obj)
        {
            InitializeComponent();

            string[] macesso = new string[] { "Bloqueado", "Básico", "Avançado" };

            string[] conta = new string[] { "...", "Comum", "Administrador", "Master" };

            cComboBoxAcesso.Items.AddRange(conta.ToArray());
            cComboBoxM1.Items.AddRange(macesso.ToArray());
            cComboBoxM2.Items.AddRange(macesso.ToArray());
            cComboBoxM3.Items.AddRange(macesso.ToArray());

            if (acaonatela == AcaoNaTela.Alterar)
            {
                var usuario = User.SelectUser(obj.Identificador);

                foreach (Entidade.Usuarios uc in usuario)
                {
                    cTextBoxIdentificador.Text = uc.Identificador;
                    cTextBoxNome.Text = uc.Nome;
                    cTextBoxEmail.Text = uc.Email;
                    cComboBoxAcesso.SelectedIndex = uc.Conta;
                }
                cTextBoxEmail.Enabled = false;
                cTextBoxIdentificador.Enabled = false;
                cTextBoxNome.Enabled = false;

                acaoSelecionada = acaonatela;
            }
        }

        private void FmNewUser_Load(object sender, EventArgs e)
        {
            if(Autenticado.Conta <= Conta.Administrador)
            {
                cComboBoxAcesso.Items.Remove("Administrador");
                cComboBoxAcesso.Items.Remove("Master");
            }

            if (acaoSelecionada == AcaoNaTela.Incluir)
            {
                cComboBoxAcesso.SelectedIndex = 0;
                cComboBoxM1.SelectedIndex = 0;
                cComboBoxM2.SelectedIndex = 0;
                cComboBoxM3.SelectedIndex = 0;
            }
        }

        private void cButtonEnd_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cButtonGravar_Click(object sender, EventArgs e)
        {
            try
            {

                EUser.Identificador = cTextBoxIdentificador.Text;
                EUser.Senha = cTextBoxIdentificador.Text.ToLower();
                EUser.Nome = cTextBoxNome.Text;
                EUser.Email = cTextBoxEmail.Text;
                EUser.Conta = cComboBoxAcesso.SelectedIndex;
                EUser.Cadastro = DateTime.Now;
                EUser.Atualizado = DateTime.Now;
                EUser.Bloqueado = false;

                User.InsertNewUser(EUser);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Sim.Controles.Limpar.Todos(groupBox2);
                cTextBoxIdentificador.Focus();
            }
        }

        private void FmNewUser_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Orange, 0, 0, 60, this.Height);
            //e.Graphics.DrawRectangle(Pens.Gainsboro, 0, 0, this.Width - 1, this.Height - 1);
        }

    }
}
