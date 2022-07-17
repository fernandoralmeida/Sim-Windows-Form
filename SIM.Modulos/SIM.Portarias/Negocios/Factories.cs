using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Portarias.Negocios
{
    internal class Instanciar
    {

        internal static Entidade.Portarias EntPortarias()
        {
            return new Entidade.Portarias();
        }

        public static IBllPortarias NegociosPortarias()
        {
            return new BllPortarias();
        }

        public static Entidade.ListViewPortarias ListaPortarias()
        {
            return new Entidade.ListViewPortarias();
        }
    }
}
