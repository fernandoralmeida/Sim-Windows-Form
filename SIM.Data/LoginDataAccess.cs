using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace Sim.Data
{
    class LoginDataAccess : IDataAccess
    {

        private SqlCeParameterCollection sqlCeParameterCollection = new SqlCeCommand().Parameters;

        private SqlCeConnection Conectar()
        {
            return new SqlCeConnection(DataBasePath.sDataBase1);
        }  

        public void ReiniciarParametros()
        {
            sqlCeParameterCollection.Clear();
        }

        public void AdicionarParametros(string parameterName, object parameterValue)
        {
            sqlCeParameterCollection.Add(new SqlCeParameter(parameterName, parameterValue));
        }

        public DataTable Reader(string sqlcommandOrStoredProcedure)
        {

            SqlCeConnection sqlceConnection = Conectar();

            try
            {

                sqlceConnection.Open();

                SqlCeCommand sqlceCommand = sqlceConnection.CreateCommand();
                sqlceCommand.CommandType = CommandType.Text;
                sqlceCommand.CommandText = sqlcommandOrStoredProcedure;

                foreach (SqlCeParameter p in sqlCeParameterCollection)
                {
                    sqlceCommand.Parameters.Add(new SqlCeParameter(p.ParameterName, p.Value));
                }

                sqlceCommand.ExecuteReader();

                DataTable dt = new DataTable();

                new SqlCeDataAdapter(sqlceCommand).Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlceConnection.Close();
            }
        }

        public bool Writing(string sqlcommandOrStoredProcedure)
        {

            SqlCeConnection sqlceConnection = Conectar();

            sqlceConnection.Open();

            SqlCeTransaction ts = sqlceConnection.BeginTransaction();

            try
            {
                SqlCeCommand sqlceCommand = sqlceConnection.CreateCommand();
                sqlceCommand.CommandType = CommandType.Text;
                sqlceCommand.CommandText = sqlcommandOrStoredProcedure;

                foreach (SqlCeParameter p in sqlCeParameterCollection)
                {
                    if (p.Value.Equals(string.Empty))
                        return false;

                    sqlceCommand.Parameters.Add(new SqlCeParameter(p.ParameterName, p.Value));
                }

                sqlceCommand.ExecuteNonQuery();
                ts.Commit(CommitMode.Deferred);

                return true;
            }
            catch (Exception ex)
            {
                ts.Rollback();
                return false;
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlceConnection.Close();
            }
        }

    }
}
