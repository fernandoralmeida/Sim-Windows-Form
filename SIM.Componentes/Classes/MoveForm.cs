using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Sim.Classes
{
    public class MoveForm
    {
        
        //API Windows, Mover Form sem Borda
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MoveForm()
        {  }

        public void WindosForm(System.Windows.Forms.Form FM)
        {
            if (Sim.Componentes.Properties.Settings.Default.Aero.Equals(true))
                FM.Opacity = 0.8;
            ReleaseCapture();
            SendMessage(FM.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            FM.Opacity = 1;
        }
    }
}
