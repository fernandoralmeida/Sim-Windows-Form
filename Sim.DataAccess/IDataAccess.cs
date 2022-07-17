using System.Data;

namespace Sim.DataAccess
{
    public interface IDataAccess
    {

        void ReiniciarParametros();

        void AdicionarParametros(string parameterName, object parameterValue);

        DataTable Reader(string sqlcommandOrStoredProcedure);

        bool Writing(string sqlcommandOrStoredProcedure);

    }
}
