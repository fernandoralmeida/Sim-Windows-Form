using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Sim.Classes
{
    public static class Modulos
    {

        const string modulo1 = "SIM.Modulo.001.dll";
        const string modulo2 = "SIM.Modulo.002.dll";
        const string modulo3 = "SIM.Modulo.003.dll";

        public static bool Legislacao { get; set; }
        public static bool Contratos { get; set; }
        public static bool Portarias { get; set; }
                
        public static string[] ModulosExistentes(string path)
        {

            Legislacao = false;
            Contratos = false;
            Portarias = false;

            string[] files = Directory.GetFiles(path);
            string[] valor = new string[3];
            int i = 0;

            foreach (string file in files)
            {
                FileInfo FI = new FileInfo(file);
                if (File.Exists(FI.FullName))
                {

                    if (FI.Name.Equals(modulo1) ||
                        FI.Name.Equals(modulo2) ||
                        FI.Name.Equals(modulo3))
                    {
                        switch (FI.Name)
                        {
                            case modulo1:
                                Legislacao = true;
                                break;
                            case modulo2:
                                Contratos = true;
                                break;
                            case modulo3:
                                Portarias = true;
                                break;
                            default:
                                break;
                        }
                        valor[i] = FI.Name;
                        i += 1;
                    }     
                }
            }
            return valor;
        }

    }
}
