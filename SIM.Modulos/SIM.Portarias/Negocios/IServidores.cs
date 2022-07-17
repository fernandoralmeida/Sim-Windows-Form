using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sim.Portarias.RegraN
{
    internal interface IServidores
    {

        DataTable GetServidorName();
        DataTable GetData4Param(Entidade.Servidores obj);

        bool UpDateQuery(Entidade.Servidores obj);
        bool InsertQuery(Entidade.Servidores obj);
        bool DeleteQuery(Entidade.Servidores obj);

    }
}
