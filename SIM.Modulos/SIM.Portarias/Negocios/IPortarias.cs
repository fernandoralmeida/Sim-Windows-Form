using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sim.Portarias.RegraN
{
    internal interface IPortarias
    {

        DataTable GetAllData();

        DataTable CosultaParam(Entidade.Portarias Obj);

        int RegistrosEncontrados();

        DataTable GetData4UpDate(Entidade.Portarias obj);

        bool UpDateQuery(Entidade.Portarias obj);
        bool InsetQuery(Entidade.Portarias obj);
        bool DeleteQuery(Entidade.Portarias obj);

    }
}
