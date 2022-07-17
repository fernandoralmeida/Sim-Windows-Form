using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sim.Classes
{
    public static class Diretorios
    {

        public static string dirDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string dirPDF = "SIM.Desktop.PDF";
        public static string dirCache = "Cache";

        public static void CriarPasta(string _caminho, string _pasta)
        {

            DirectoryInfo PastaPDF = new DirectoryInfo(string.Format(@"{0}\{1}", _caminho, _pasta));

            if (!System.IO.Directory.Exists(PastaPDF.FullName))
            {
                System.IO.Directory.CreateDirectory(PastaPDF.FullName);
            }

        }

    }
}
