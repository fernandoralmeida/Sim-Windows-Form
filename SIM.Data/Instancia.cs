using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Data
{
    public class Instancia
    {

        public static IDataAccess ModuloAccess()
        {
            return new ModulosDataAccess();
        }

        public static IDataAccess LoginAccess()
        {
            return new LoginDataAccess();
        }

    }
}
