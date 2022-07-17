using System;
using System.Windows.Forms;

namespace Sim.Gui.Class
{
    public static class OwnedForm
    {

        public static void Location()
        {
            foreach (Forms.OwnedForm owndForms in Form.ActiveForm.OwnedForms)
            {
                if (owndForms != null)
                {

                    int e = ActiveArea.Esquerdo;
                    int t = ActiveArea.Topo;

                    int x = ActiveArea.Largura;
                    int y = ActiveArea.Altura;

                    int l = owndForms.Width;
                    int a = owndForms.Height;

                    owndForms.Location = new System.Drawing.Point(e + ((x - l) / 2), t + ((y - a) / 2));

                }
            }
        }

        public static void ReResize()
        {
            foreach (Forms.OwnedForm owndForms in Form.ActiveForm.OwnedForms)
            {
                if (owndForms != null)
                {
                    if (owndForms.FormMaximizado.Equals(true))
                    {
                        owndForms.Size = ActiveArea.Tamanho();
                    }
                    Location();
                }
            }
        }

        public static void Close()
        {
            foreach (Form owndForms in Form.ActiveForm.OwnedForms)
            {
                if (owndForms != null)
                {
                    owndForms.Close();
                }
            }
        }

        public static void InFocus(IntPtr vhandle)
        {
            //pega todos os form ativos no form pai
            FormCollection colecaoForms = Application.OpenForms;

            foreach (Form owdForms in colecaoForms)
            {
                //pega o form pelo handle                
                if (owdForms.Handle.Equals(vhandle))
                {
                    owdForms.Focus();
                    owdForms.WindowState = System.Windows.Forms.FormWindowState.Normal;
                }
            }
        }
    }
}

