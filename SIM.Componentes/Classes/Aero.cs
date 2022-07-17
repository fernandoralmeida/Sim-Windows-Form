using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Classes
{
    public class Aero
    {
        // Desktop Windows Manager APIs
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern void DwmExtendFrameIntoClientArea(System.IntPtr hWnd, ref Margens pMargins);
        
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern void DwmIsCompositionEnabled(ref bool isEnabled);
        
        // Strutura pra margens
        public struct Margens
        {
            public int Left, Right, Top, Bottom;
        }

        //verifica se a versão do Windows tem DWM
        public static bool IsGlassEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6)
            {
                //System.Windows.Forms.MessageBox.Show("How about trying this on Vista?");
                return false;
            }

            //Check if DWM is enabled
            bool isGlassSupported = false;
            DwmIsCompositionEnabled(ref isGlassSupported);
            return isGlassSupported;
        }

        // estrutura para ativar ou desativar o efeito aero
        public struct Ativo
        {
            public const char Sim = 'S';
            public const char Nao = 'N';
        }

        public static void ExternderAero(IntPtr wHndl , int top, int left, int right, int botton) 
        {

            if (!IsGlassEnabled())
            { return; }
            
            //seta as margens
            Margens margemAero;
            margemAero.Top = top;
            margemAero.Left = left;
            margemAero.Right = right;
            margemAero.Bottom = botton;

            //extende aero conforme a margem setada
            DwmExtendFrameIntoClientArea(wHndl, ref margemAero);
        }

    }
}
