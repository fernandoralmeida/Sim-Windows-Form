using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Classes
{
    public static class FormulariosFilhos
    {        

        public static void Mover()
        {
            foreach (Sim.Componentes.Formularios.xFormChild owndForms in Sim.Componentes.Formularios.xFormChild.ActiveForm.OwnedForms)
            {
                if (owndForms != null)
                {

                    int e = Sim.Componentes.Classes.AreaTrabalho.Posicao.Esquerdo;
                    int t = Sim.Componentes.Classes.AreaTrabalho.Posicao.Topo;

                    int x = Sim.Componentes.Classes.AreaTrabalho.Area.Largura;
                    int y = Sim.Componentes.Classes.AreaTrabalho.Area.Altura;

                    int l = owndForms.Width;
                    int a = owndForms.Height;

                    owndForms.Location = new System.Drawing.Point(e + ((x - l) / 2), t + ((y - a) / 2));

                }
            }
        }

        public static void Dimensionar()
        {
            foreach (Sim.Componentes.Formularios.xFormChild owndForms in Sim.Componentes.Formularios.xFormChild.ActiveForm.OwnedForms)
            {
                if (owndForms != null)
                {
                    if (owndForms.FormMaximizado.Equals(true))
                    {
                        owndForms.Size = Sim.Componentes.Classes.AreaTrabalho.Tamanho();
                    }
                    Mover();
                }
            }
        }

        public static void Fechar()
        {
            foreach (System.Windows.Forms.Form owndForms in System.Windows.Forms.Form.ActiveForm.OwnedForms)
            {
                if (owndForms != null)
                {
                    owndForms.Close();
                }
            }
        }

        public static void EmFoco(IntPtr vhandle)
        {
            //pega todos os form ativos no form pai
            System.Windows.Forms.FormCollection colecaoForms = System.Windows.Forms.Application.OpenForms;

            foreach (System.Windows.Forms.Form owdForms in colecaoForms)
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
