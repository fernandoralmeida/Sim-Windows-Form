using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Text;

namespace Sim.Data.MPO
{
    public class Servidores
    {
        Comandos dbComando = new Comandos();

        //public Servidores() { }
        
        public override string ToString()
        {
            return "Servidores";
        }

        public string ConectString() //Retorna a string de conexão
        {
            return new Conexao(Provedor.SqlCE, BasedeDados.MPO).ToString();
        }

        public bool InsertQuery()
        {
            try
            {
                InitCommandCollection();
                return dbComando.Escrita(cmdCollection[2]);
            }
            catch
            {
                return false;
            }
            finally { }
        }

        public bool UpdateQuery()
        {
            try
            {
                InitCommandCollection();
                return dbComando.Escrita(cmdCollection[3]);
            }
            catch
            {
                return false;
            }
            finally { }
        }

        public bool DeleteQuery()
        {
            try
            {
                InitCommandCollection();
                return dbComando.Escrita(cmdCollection[5]);
            }
            catch
            {
                return false;
            }
            finally { }
        }

        public DataTable GetDataByParam()
        {
            try
            {
                InitCommandCollection();
                return dbComando.Leitura(this.cmdCollection[4]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { }
        }

        public DataTable GetServidores()
        {
            try
            {
                InitCommandCollection();
                return dbComando.Leitura(this.cmdCollection[0]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { }
        }

        private SqlCeCommand[] cmdCollection;

        public int Indice { get; set; }
        public int Portaria { get; set; }
        public DateTime Data { get; set; }
        public string Servidor { get; set; }

        //Inicia a coleção de Comandos SQL
        private void InitCommandCollection()
        {
            //Define quantos comandos irá ter a coleção
            this.cmdCollection = new SqlCeCommand[6];

            this.cmdCollection[0] = new SqlCeCommand();
            this.cmdCollection[0].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[0].CommandText = "SELECT Servidor FROM Servidores";
            this.cmdCollection[0].CommandType = CommandType.Text;            

            this.cmdCollection[1] = new SqlCeCommand();
            this.cmdCollection[1].Connection = new SqlCeConnection(ConectString());
            /*
            this.cmdCollection[1].CommandText = @"SELECT Atualizacao, Data, Descricao, Excluido, Inclusao, Indice, Numero, Publicada, Servidor, Tipo, Url FROM Portarias WHERE (Excluido = 0) AND ((Numero BETWEEN @NumeroI AND @NumeroF) AND (Data BETWEEN @Data1 AND @Data2) AND (Tipo LIKE @Classficacao) AND (Descricao LIKE @Descricao) AND (Servidor LIKE @Nome)) ORDER BY Data, Numero";
            this.cmdCollection[1].CommandType = CommandType.Text;
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@NumeroI", NumeroI));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@NumeroF", NumeroF));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Data1", DataI.ToShortDateString()));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Data2", DataF.ToShortDateString()));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Classficacao", Classificacao));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Descricao", Descricao));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Nome", Nome));*/

            this.cmdCollection[2] = new SqlCeCommand();
            this.cmdCollection[2].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[2].CommandText = "INSERT INTO [Servidores] ([Portaria], [Data], [Servidor]) VALUES (@Portaria, @Data, @Servidor)";
            this.cmdCollection[2].CommandType = CommandType.Text;
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Portaria", Portaria));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Data", Data.ToShortDateString()));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Servidor", Servidor));

            this.cmdCollection[3] = new SqlCeCommand();
            this.cmdCollection[3].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[3].CommandText = "UPDATE [Servidores] SET [Portaria] = @Portaria, [Data] = @Data, [Servidor] = @Ser" +
                "vidor WHERE (([Indice] = @Original_Indice))"; 
            this.cmdCollection[3].CommandType = CommandType.Text;
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Portaria", Portaria));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Data", Data.ToShortDateString()));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Servidor", Servidor));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Original_Indice", Indice));

            this.cmdCollection[4] = new SqlCeCommand();
            this.cmdCollection[4].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[4].CommandText = "SELECT * FROM Servidores WHERE ((Portaria = @Numero) AND (Data = @Data))";
            this.cmdCollection[4].CommandType = CommandType.Text;
            this.cmdCollection[4].Parameters.Add(new SqlCeParameter("@Numero", Portaria));
            this.cmdCollection[4].Parameters.Add(new SqlCeParameter("@Data", Data.ToShortDateString()));

            this.cmdCollection[5] = new SqlCeCommand();
            this.cmdCollection[5].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[5].CommandText = "DELETE FROM [Servidores] WHERE (Indice = @Indice)";
            this.cmdCollection[5].CommandType = CommandType.Text;
            this.cmdCollection[5].Parameters.Add(new SqlCeParameter("@Indice", Indice));
        }

    }
    
}
