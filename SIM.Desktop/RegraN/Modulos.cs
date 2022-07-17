using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Desktop.RegraN
{
    internal class Modulos
    {
        
        internal Modulos() { }

        internal bool Ativo(string dllName)
        {
            bool result = false;

            try
            {
                System.Reflection.Assembly Asm = System.Reflection.Assembly.LoadFrom(dllName);
                result = true;
            }
            catch
            {
                result = false;
            }
            
            return result;
        }

        internal enum name { MLE, MPO, MCC }

        internal static string Name(name modulo)
        {
            string v = string.Empty;

            switch (modulo)
            {
                case name.MLE:
                    try
                    {
                        v = "Sim.Portarias.dll"; // new Legislacao.Modulo().Nome();
                    }
                    catch
                    {
                        v = "NoModulo";
                    }
                    break;

                case name.MPO:
                    try
                    {
                        v = "Sim.Contratos.dll"; // new Portarias.Modulo().Nome();
                    }
                    catch
                    {
                        v = "NoModulo";
                    }
                    break;

                case name.MCC:
                    try
                    {
                        v = "Sim.Legislacao.dll"; // new Contratos.Modulo().Nome();
                    }
                    catch
                    {
                        v = "NoModulo";
                    }
                    break;

                default:
                    break;
            }
            return v;
        }

    }
}
