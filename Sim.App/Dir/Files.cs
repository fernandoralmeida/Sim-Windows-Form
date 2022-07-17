using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sim.App.Dir
{
    public class Files
    {
        public static string[] GetFiles(string pathfile)
        {
            return Directory.GetFiles(pathfile, "*.*", SearchOption.AllDirectories);
        }

        public static List<string> Listar(string diretorio)
        {
            var nfiles = Directory.GetFiles(diretorio, "*.*", SearchOption.AllDirectories);
            return nfiles.ToList();
        }

        public void Del(string pathfile)
        {
            // verifica se o caminho exite
            if (Directory.Exists(pathfile))
            {
                string[] nfiles = Directory.GetFiles(pathfile);

                //deleta um arquivo de cada vez
                foreach (string files in nfiles)
                {
                    string arquivo = Path.GetFullPath(files);
                    File.Delete(arquivo);
                }

            }
        }
    }
}
