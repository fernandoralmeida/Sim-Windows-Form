using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sim.App.Dir
{
    public static class Folders
    {
        public static string dirDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string dirPDF = "Sim.Desktop.PDFs";
        public static string dirCache = "Cache";

        public static void CriarPasta(string _caminho, string _pasta)
        {

            DirectoryInfo pasta = new DirectoryInfo(string.Format(@"{0}\{1}", _caminho, _pasta));

            if (!Directory.Exists(pasta.FullName))
            {
                Directory.CreateDirectory(pasta.FullName);
            }

        }
    }
}
