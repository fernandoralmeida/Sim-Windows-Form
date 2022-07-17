using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sim.Desktop.Visao
{
    public partial class FmDesk : Sim.Gui.Forms.OwnerForm // Sim.Forms.xForm
    {
          
        bool IniciandoSistema = true;

        private IntPtr hdlcontrol = IntPtr.Zero;

        App.Sys.Monitoring infoApp = new App.Sys.Monitoring();
        
        public FmDesk()
        {            
            InitializeComponent();

            this.RestoreSize = this.Size;

            this.Icon = Properties.Resources.SIM_Desktop_Icon_New;

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            FormMaximizado = true;

            AtivarAreaTrabalho();
        }
               
        private void FmDesk_Load(object sender, EventArgs e)
        {
                                              
            //Verifica se pastas existem e criam-nas se necessário
            App.Dir.Folders.CriarPasta(App.Dir.Folders.dirDesktop, App.Dir.Folders.dirPDF);
            App.Dir.Folders.CriarPasta(Application.StartupPath, App.Dir.Folders.dirCache);

            //Reseta os Modulos
            ModuloAtivado(false);
            VerificarModulos();

            RegraN.HandleF.FmDeskHandle = this.Handle;

            panelWorkArea.Left = 0;
            panelWorkArea.Width = this.Width;
            panelWorkArea.Height = panelWorkArea.Height;
            //AtivarAreaTrabalho();


            //StripMenu**************

            Gui.Controls.StripItem tsConfig = new Gui.Controls.StripItem();
            tsConfig.Text = "Configurações";
            tsConfig.Font = this.Font;
            tsConfig.Click += new EventHandler(TsConfig_Click);

            ToolStripMenuItem tsUserProfile = new Gui.Controls.StripItem();
            tsUserProfile.Text = "Perfil do Usuário";
            tsUserProfile.Font = this.Font;
            tsUserProfile.Click += new EventHandler(TsUserProfile_Click);

            ToolStripMenuItem tsUserAccounts = new Gui.Controls.StripItem();
            tsUserAccounts.Text = "Contas de Usuários";
            tsUserAccounts.Font = this.Font;
            tsUserAccounts.Click += new EventHandler(TsUserAccounts_Click);

            ToolStripSeparator tsSeparator = new Gui.Controls.StripSeparator();

            ToolStripMenuItem tsLogOut = new Gui.Controls.StripItem();
            tsLogOut.Text = "Trocar Usuário";
            tsLogOut.Font = this.Font;
            tsLogOut.Click +=new EventHandler(TsLogOut_Click);
            //End StripMenu************

            buttonDropDown.Items.AddRange(new ToolStripItem[] { tsConfig, tsUserProfile, tsUserAccounts, tsSeparator, tsLogOut });
            buttonDropDown.AutoSize = true;

        }

        private void TsLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente efetuar LogOUT?", "SIM.Alerta", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {

                buttonDropDown.Visible = false;

                RegraN.Forms.CloseForms();

                if (pBarMenu.Controls.Contains(UserControl.FromHandle(hdlcontrol)))
                {
                    pBarMenu.Controls.Remove(UserControl.FromHandle(hdlcontrol));
                    UserControl.FromHandle(hdlcontrol).Dispose();
                }

                foreach (Form owdForms in Form.ActiveForm.OwnedForms)
                {
                    owdForms.Close();
                }

                panelSYS.Visible = false;
                timerA.Enabled = false;
                pModulo.Visible = false;

                Login.Reiniciar.Autenticacao();

                Visao.FmLoad FM = new Visao.FmLoad();
                FM.ShowDialog();

                Form FML = new Login.Visao.FmLogIN();
                FML.Text = "SIM.Desktop.LogIN";
                FML.ShowDialog(this);
                Monitoramento();

                //cButtonID.Visible = true;
                pModulo.Visible = true;
            }
        }

        private void TsUserAccounts_Click(object sender, EventArgs e)
        {
            var FM = new Login.Visao.FmAccounts();
            FM.Text = "SIM.Desktop.Contas";
            FM.ShowDialog();
        }

        private void TsUserProfile_Click(object sender, EventArgs e)
        {
            Login.Visao.FmUserProfile FM = new Login.Visao.FmUserProfile();
            FM.Text = "SIM.Desktop.Perfil";
            FM.ShowDialog();
        }

        private void TsConfig_Click(object sender, EventArgs e)
        {
            var FM = new Gui.View.FormGui();
            FM.Text = "SIM.Desktop.Temas";
            FM.ShowDialog();
        }

        private void FmDesk_Resize(object sender, EventArgs e)
        {

            AtivarAreaTrabalho();
            if (IniciandoSistema.Equals(false))
                Sim.Gui.Class.OwnedForm.ReResize(); //Sim.Classes.FormulariosFilhos.Dimensionar();

            if (FormMaximizado == false)
            {
                FormMaximizado = true;
            }
            else
            {
                FormMaximizado = false;
            }
        }

        private void FmDesk_Shown(object sender, EventArgs e)
        {
            if (IniciandoSistema.Equals(true))
            {
                Login.Visao.FmLogIN FM = new Login.Visao.FmLogIN();
                FM.Text = "SIM.Desktop.LogIN";
                FM.ShowDialog(this);
                IniciandoSistema = false;
                Monitoramento();
                pModulo.Visible = true;
            }
        }

        private void FmDesk_Activated(object sender, EventArgs e)
        {
            buttonDropDown.Visible = Login.Autenticado.Valido.Equals(true) ? true : false;
            buttonDropDown.Text = Login.Autenticado.UserName;
        }

        private void FmDesk_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                App.Dir.Files Arquivos = new App.Dir.Files();
                Arquivos.Del(string.Format(@"{0}\Cache\", Application.StartupPath));
            }
            catch
            { }
            finally
            {
                GC.Collect();
            }            
        }
       
        //inverte os paineis
        private void ModuloAtivado(bool valor)
        {
            if (valor.Equals(false))
            {
                if (IniciandoSistema.Equals(true))
                    pModulo.Visible = false;
                else
                    pModulo.Visible = true;
            }
            else
            {
                pModulo.Visible = false;                
            }
        }

        private void Monitoramento()
        {
            try
            {
                if (Login.Autenticado.Conta.Equals(Login.Conta.Master))
                {
                    //ativa monitoramento                
                    AppDomain.MonitoringIsEnabled = true;
                    label1.Text = infoApp.OsInfo();
                    listBoxSIM.DataSource = App.Dir.Files.Listar(Application.StartupPath);
                    timerA.Enabled = true;
                    panelSYS.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void VerificarModulos()
        {
            try
            {
                if (new RegraN.Modulos().Ativo(RegraN.Modulos.Name(RegraN.Modulos.name.MPO)).Equals(true))
                    buttonMPO();

                if (new RegraN.Modulos().Ativo(RegraN.Modulos.Name(RegraN.Modulos.name.MLE)).Equals(true))
                    buttonMLG();

                if (new RegraN.Modulos().Ativo(RegraN.Modulos.Name(RegraN.Modulos.name.MCC)).Equals(true))
                    buttonMCC();
            }
            catch { }
        }

        private void timerA_Tick(object sender, EventArgs e)
        {
            label2.Text = infoApp.AppInfo();
        }

        private void pBarMenu_ControlRemoved(object sender, ControlEventArgs e)
        {
            RegraN.Forms.CloseForms();
            pModulo.Visible = true;
            pBarMenu.Visible = false;
        }

        private void perfilDoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.Visao.FmUserProfile FM = new Login.Visao.FmUserProfile();
            FM.Text = "SIM.Desktop.Perfil do Usuário";
            FM.ShowDialog();
        }

        private void FmDesk_Move(object sender, EventArgs e)
        {
            AtivarAreaTrabalho();
            Gui.Class.OwnedForm.Location();
        }

        private void AtivarAreaTrabalho()
        {
            Gui.Class.ActiveArea.Topo = this.Top + 24 + pBarMenu.Height;
            Gui.Class.ActiveArea.Esquerdo = this.Left;
            Gui.Class.ActiveArea.Largura = this.Width;
            Gui.Class.ActiveArea.Altura = this.Height - (24 + pBarMenu.Height);


            if ( FormMaximizado == true)
            {
                Gui.Class.ActiveArea.Esquerdo = 1;
                Gui.Class.ActiveArea.Largura = this.Width - 2;
                Gui.Class.ActiveArea.Altura = this.Height - (24 + pBarMenu.Height) -1;
                //panelWorkArea.Top = 24;
                panelWorkArea.Left = 0;
                panelWorkArea.Width = this.Width;
                panelWorkArea.Height = panelWorkArea.Height + 1;
            }
            else
            {
                panelWorkArea.Left = 1;
                panelWorkArea.Width = this.Width - 2;
                panelWorkArea.Height = this.Height - 25;
                //panelWorkArea.Top = 24;

            }

            Invalidate();
        }

        private void buttonMLG()
        {
            Gui.Controls.Button MLG = new Gui.Controls.Button();
            MLG.Text = "MLG :: Modulo Legislação";
            MLG.Name = "MLG";
            CallButton(MLG);
            MLG.Click += new System.EventHandler(this.MLG_Click);
        }

        private void buttonMPO()
        {
            Gui.Controls.Button MPO = new Gui.Controls.Button();
            MPO.Text = "MPO :: Modulo Portarias";
            MPO.Name = "MPO";
            CallButton(MPO);
            MPO.Click += new System.EventHandler(this.MPO_Click);
        }

        private void buttonMCC()
        {
            Gui.Controls.Button MCC = new Gui.Controls.Button();
            MCC.Text = "MCC :: Modulo Contratos & Convênios";
            MCC.Name = "MCC";
            CallButton(MCC);
            MCC.Click += new System.EventHandler(this.MCC_Click);
        }

        private void CallButton(Control ctrl)
        {
            ctrl.Dock = DockStyle.Fill;
            ctrl.Font = new System.Drawing.Font("Consolas", 
                8.25F, System.Drawing.FontStyle.Regular, 
                System.Drawing.GraphicsUnit.Point, 
                ((byte)(0)));

            if (this.LayoutModulos.Controls.Count.Equals(0))
                this.LayoutModulos.Controls.Add(ctrl, 0, 0);

            else if (this.LayoutModulos.Controls.Count.Equals(1))
                this.LayoutModulos.Controls.Add(ctrl, 1, 0);

            else if (this.LayoutModulos.Controls.Count.Equals(2))
                this.LayoutModulos.Controls.Add(ctrl, 2, 0);
        }

        private void MLG_Click(object sender, EventArgs e)
        {
            Legislacao.ucMenu ucMLG = new Legislacao.ucMenu();
            CallUC(ucMLG);
        }

        private void MPO_Click(object sender, EventArgs e)
        {
            Portarias.ucMenu ucMPO = new Portarias.ucMenu();
            CallUC(ucMPO);
        }

        private void MCC_Click(object sender, EventArgs e)
        {
            Contratos.ucMenu ucMCC = new Contratos.ucMenu();
            CallUC(ucMCC);
        }

        private void CallUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pBarMenu.Controls.Add(uc);
            hdlcontrol = uc.Handle;
            pModulo.Visible = false;
            pBarMenu.Visible = true;
        }
        
        private void FmDesk_Paint(object sender, PaintEventArgs e)
        {
            //pBarMenu.BackColor = ColorTheme.Controle;
        }

    }
}
