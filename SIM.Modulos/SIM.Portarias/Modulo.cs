using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Portarias
{
    public class Modulo
    {

        public Modulo() { }

        public string Nome()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".dll";
        }

        public Version Versao()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }

        public Type Tipos()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetType();
        }

    }

    public enum ModuloAcesso { Bloqueado, Basico, Avancado }
}
