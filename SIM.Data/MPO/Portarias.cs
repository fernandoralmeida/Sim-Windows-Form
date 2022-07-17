using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Text;

namespace Sim.Data.MPO
{
    public class Portarias
    {

        Comandos Executar = new Comandos();

        //public Portarias() { }

        public override string ToString()
        {
            return "Portarias";
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
                return Executar.Escrita(cmdCollection[2]);
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
                return Executar.Escrita(cmdCollection[3]);
            }
            catch
            {
                return false;
            }
            finally { }
        }

        public void DeleteQuery()
        {

            try
            {
                InitCommandCollection();
                Executar.Escrita(cmdCollection[3]);
            }
            catch { }
            finally { }
        }

        public DataTable GetAllData()
        {
            try
            {
                InitCommandCollection();
                return Executar.Leitura(this.cmdCollection[0]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            { }
        }

        public DataTable GetDataByParam()
        {
            try
            {
                InitCommandCollection();
                return Executar.Leitura(this.cmdCollection[1]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { }
        }

        public DataTable GetData4UpDate()
        {
            try
            {
                InitCommandCollection();
                return Executar.Leitura(this.cmdCollection[4]);                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { }
        }

        private SqlCeCommand[] cmdCollection;

        public int NumeroI { get; set; }
        public int NumeroF { get; set; }
        public DateTime DataI { get; set; }
        public DateTime DataF { get; set; }
        public string Classificacao { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }

        public int Numero { get; set; }
        public DateTime Data { get; set; }

        public string Url { get; set; }
        public string Publicada { get; set; }
        public DateTime Inclusao { get; set; }
        public DateTime Atualizacao { get; set; }
        public bool Excluido { get; set; }

        public int Indice { get; set; }

        //Inicia a coleção de Comandos SQL
        private void InitCommandCollection()
        {
            //Define quantos comandos irá ter a coleção
            this.cmdCollection = new SqlCeCommand[5];

            this.cmdCollection[0] = new SqlCeCommand();
            this.cmdCollection[0].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[0].CommandText = "SELECT * FROM Portarias ORDER BY Data DESC";
            this.cmdCollection[0].CommandType = CommandType.Text;

            this.cmdCollection[1] = new SqlCeCommand();
            this.cmdCollection[1].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[1].CommandText = @"SELECT Atualizacao, Data, Descricao, Excluido, Inclusao, Indice, Numero, Publicada, Servidor, Tipo, Url FROM Portarias WHERE (Excluido = 0) AND ((Numero BETWEEN @NumeroI AND @NumeroF) AND (Data BETWEEN @Data1 AND @Data2) AND (Tipo LIKE @Classficacao) AND (Descricao LIKE @Descricao) AND (Servidor LIKE @Nome)) ORDER BY Data, Numero";
            this.cmdCollection[1].CommandType = CommandType.Text;
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@NumeroI", NumeroI));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@NumeroF", NumeroF));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Data1", DataI.ToShortDateString()));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Data2", DataF.ToShortDateString()));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Classficacao", Classificacao));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Descricao", Descricao));
            this.cmdCollection[1].Parameters.Add(new SqlCeParameter("@Nome", Nome));

            this.cmdCollection[2] = new SqlCeCommand();
            this.cmdCollection[2].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[2].CommandText = "INSERT INTO [Portarias] ([Numero], [Data], [Tipo], [Descricao], [Servidor], [Url]" +
                ", [Publicada], [Inclusao], [Atualizacao], [Excluido]) VALUES (@Numero, @Data, @T" +
                "ipo, @Descricao, @Servidor, @Url, @Publicada, @Inclusao, @Atualizacao, @Excluido)";
            this.cmdCollection[2].CommandType = CommandType.Text;
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Numero", Numero));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Data", Data.ToShortDateString()));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Tipo", Classificacao));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Descricao", Descricao));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Servidor", Nome));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Url", Url));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Publicada", Publicada));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Inclusao", Inclusao));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Atualizacao", Atualizacao));
            this.cmdCollection[2].Parameters.Add(new SqlCeParameter("@Excluido", Excluido));

            this.cmdCollection[3] = new SqlCeCommand();
            this.cmdCollection[3].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[3].CommandText = @"UPDATE [Portarias] SET [Numero] = @Numero, [Data] = @Data, [Tipo] = @Tipo, [Descricao] = @Descricao, [Servidor] = @Servidor, [Url] = @Url, [Publicada] = @Publicada, [Inclusao] = @Inclusao, [Atualizacao] = @Atualizacao, [Excluido] = @Excluido WHERE (([Indice] = @Original_Indice))";
            this.cmdCollection[3].CommandType = CommandType.Text;
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Numero", Numero));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Data", Data.ToShortDateString()));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Tipo", Classificacao));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Descricao", Descricao));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Servidor", Nome));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Url", Url));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Publicada", Publicada));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Inclusao", Inclusao));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Atualizacao", Atualizacao));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Excluido", Excluido));
            this.cmdCollection[3].Parameters.Add(new SqlCeParameter("@Original_Indice", Indice));

            this.cmdCollection[4] = new SqlCeCommand();
            this.cmdCollection[4].Connection = new SqlCeConnection(ConectString());
            this.cmdCollection[4].CommandText = "SELECT * FROM Portarias WHERE (Excluido = 0) AND ((Numero = @Numero) AND (Data = @Data))";
            this.cmdCollection[4].CommandType = CommandType.Text;
            this.cmdCollection[4].Parameters.Add(new SqlCeParameter("@Numero", Numero));
            this.cmdCollection[4].Parameters.Add(new SqlCeParameter("@Data", Data.ToShortDateString()));
        }

    }
}
