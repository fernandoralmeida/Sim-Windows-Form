using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sim.Classes
{
    public static class Arquivos
    {
        public static string[] GetFiles(string pathfile)
        {
            return Directory.GetFiles(pathfile, "*.*", SearchOption.AllDirectories);
        }
    }
}
