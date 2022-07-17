using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sim.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /***** Executar somente uma instancia da aplicação ******/
            /*
            string appName = Application.ProductName;
            System.Threading.Mutex mutex = null;

            try
            {
                mutex = System.Threading.Mutex.OpenExisting(appName);
            }
            catch (System.Threading.WaitHandleCannotBeOpenedException)
            { }

            if (mutex == null)
            {
                mutex = new System.Threading.Mutex(true, appName);
            }
            else
            {
                return;
            }
            /***** FIM ******/
 
            
            //Sim.Componentes.Classes.ColorTheme.GetTheme();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form FM = new Visao.FmDesk();
            Application.Run(FM);

            /*
            while (FM.IsHandleCreated.Equals(true))
                Application.DoEvents();
            
            CoFreeUnusedLibraries();
            */
        }
                
        //Libera livrarias sem uso
        /*
        [System.Runtime.InteropServices.DllImport("ole32.dll")]
        static extern void CoFreeUnusedLibraries();
        */
        
    }
}
