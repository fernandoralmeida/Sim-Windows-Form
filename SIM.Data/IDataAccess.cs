using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sim.Data
{
    public interface IDataAccess
    {
        
        void ReiniciarParametros();

        void AdicionarParametros(string parameterName, object parameterValue);

        DataTable Reader(string sqlcommandOrStoredProcedure);

        bool Writing(string sqlcommandOrStoredProcedure);

    }
}
