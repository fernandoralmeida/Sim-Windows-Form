using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login.Negocios
{
    public class Factories
    {
        public static IUsuarios Users()
        {
            return new Usuarios();
        }

        public static Entidade.Usuarios EntUsers()
        {
            return new Entidade.Usuarios();
        }
    }
}
