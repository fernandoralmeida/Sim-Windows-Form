using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sim.Portarias.RegraN
{
    internal class Portarias : IPortarias
    {

        int nrows = 0;

        Sim.Data.IDataAccess PortariaAccess = Sim.Data.Factory.ModuloAccess();

        public DataTable GetAllData()
        {
            return PortariaAccess.Reader("");
        }

        public DataTable CosultaParam(Entidade.Portarias obj)
        {
            try
            {
                PortariaAccess.ReiniciarParametros();

                PortariaAccess.AdicionarParametros("@NumeroI", obj.NumeroI);
                PortariaAccess.AdicionarParametros("@NumeroF", obj.NumeroF);
                PortariaAccess.AdicionarParametros("@Data1", "01/01/"+ obj.AnoI);
                PortariaAccess.AdicionarParametros("@Data2", "31/12/"+obj.AnoF);
                PortariaAccess.AdicionarParametros("@Tipo", obj.Tipo);
                PortariaAccess.AdicionarParametros("@Resumo", obj.Descricao);
                PortariaAccess.AdicionarParametros("@Nome", obj.Servidor);

                return PortariaAccess.Reader(Properties.Resources.SelectByParam);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }             
        }

        public int RegistrosEncontrados()
        {
            return nrows;
        }

        public DataTable GetData4UpDate(Entidade.Portarias obj)
        {

            return PortariaAccess.Reader(""); ;
        }

        public bool UpDateQuery(Entidade.Portarias obj)
        {
            return false;
        }

        public bool InsetQuery(Entidade.Portarias obj)
        {
            return false;
            
        }

        public bool DeleteQuery(Entidade.Portarias obj)
        {
            throw new NotImplementedException();
        }

    }
}
