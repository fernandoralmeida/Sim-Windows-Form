using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sim.Classes
{
    public static class Formularios
    {

        //controla os formularios ativos
        public static bool CadastroAtivo = false;
        public static bool ConsultaAtiva = false;
        public static bool EdicaoAtiva = false;
        public static bool FormPDFAtivo = false;
        public static bool RelAtivo = false;

        /* ações possiveis */
        public enum AcaoWindow { Fechar, Restaurar, Minimizar }

        // define altura inicial e tamanho maximo dos formularios internos
        //public static int alturaInicial = 0;
        //public static int maxHeight = 0;
        //public static int aY = Screen.PrimaryScreen.WorkingArea.Height;
        //public static int cX = Screen.PrimaryScreen.WorkingArea.Width;

        /* Controla o estado das janelas ativas no Form Pai */
        /*
        public static void ControleWindow(AcaoWindow acWindow)
        {
            //pega todos os form ativos no form pai
            foreach (Form owdForms in Form.ActiveForm.OwnedForms)
            {
                if (!owdForms.Equals(null)) // verifica se valor é nulo
                {
                    switch (acWindow)
                    {
                        case AcaoWindow.Fechar:
                            owdForms.Close();
                            Formularios.CadastroAtivo = false;
                            Formularios.ConsultaAtiva = false;
                            Formularios.EdicaoAtiva = false;
                            Formularios.RelAtivo = false;
                            break;
                        case AcaoWindow.Restaurar:
                            owdForms.WindowState = FormWindowState.Normal;
                            break;
                        case AcaoWindow.Minimizar:
                            owdForms.WindowState = FormWindowState.Minimized;
                            break;
                        default:
                            break;
                    }
                }
            }
        }*/

        public static void CloseForms()
        {
            foreach (Form owndForms in Form.ActiveForm.OwnedForms)
            {
                if (owndForms != null)
                {
                    if (owndForms.Name != "FmInfo")
                        owndForms.Close();
                    
                    Formularios.CadastroAtivo = false;
                    Formularios.ConsultaAtiva = false;
                    Formularios.EdicaoAtiva = false;
                    Formularios.RelAtivo = false;
                }
            }
        }

        public static void EmFoco(IntPtr hWnd)
        {
            //pega todos os form ativos no form pai
            FormCollection colecaoForms = Application.OpenForms;

            foreach (Form owdForms in colecaoForms)
            {
                //pega o form pelo handle                
                if (owdForms.Handle.Equals(hWnd))
                {
                    owdForms.Focus();
                    owdForms.WindowState = FormWindowState.Normal;
                }               
            }
        }

    }
}
