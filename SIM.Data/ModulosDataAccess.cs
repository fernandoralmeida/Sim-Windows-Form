using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Text;

namespace Sim.Data
{
    class ModulosDataAccess : IDataAccess
    {

        /*
         * 
        var dtUser = new DataTable();
        dt.Columns.Add("ID",typeof(int));
        dt.Columns.Add("Name",typeof(string));
        List<User> userList = new List<User>(); //This will be filled with values
        userList.ForEach(u => dtUser.Rows.Add(u.ID,u.Name));
         * 
         */
        
        private SqlCeParameterCollection sqlCeParameterCollection = new SqlCeCommand().Parameters;

        private SqlCeConnection Conectar()
        {
            return new SqlCeConnection(DataBasePath.sDataBase2);
        }    

        // Limpa coleção de parametros
        public void ReiniciarParametros()
        {
            sqlCeParameterCollection.Clear();
        }

        // Inicia Coleção de Parametros
        public void AdicionarParametros(string parameterName, object parameterValue)
        {
            sqlCeParameterCollection.Add(new SqlCeParameter(parameterName, parameterValue));
        }

        // Lê registros do Banco de Dados - retorna tabela
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

                sqlceCommand.ExecuteScalar();

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

        // Persistencia - Inserir, Alterar, Exluir - retorna sim/não
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
