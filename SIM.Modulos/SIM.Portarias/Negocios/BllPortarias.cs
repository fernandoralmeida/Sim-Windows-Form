using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Sim.Portarias.Entidade;

namespace Sim.Portarias.Negocios
{
    class BllPortarias : IBllPortarias
    {

        Sim.DataAccess.IDataAccess AcessoDados = Sim.DataAccess.Instancia.ModuloAccess();

        public DataTable MostrarTodosRegistros()
        {
            try
            {
                return AcessoDados.Reader(Properties.Resources.SelectAllReg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Consultar(Entidade.Portarias obj)
        {
            try
            {
                AcessoDados.ReiniciarParametros();

                AcessoDados.AdicionarParametros("@NumeroI", obj.NumeroI);
                AcessoDados.AdicionarParametros("@NumeroF", obj.NumeroF);
                AcessoDados.AdicionarParametros("@Data1", "01/01/" + obj.AnoI);
                AcessoDados.AdicionarParametros("@Data2", "31/12/" + obj.AnoF);
                AcessoDados.AdicionarParametros("@Tipo", obj.Tipo);
                AcessoDados.AdicionarParametros("@Resumo", obj.Resumo);
                AcessoDados.AdicionarParametros("@Nome", obj.Servidor);

                return AcessoDados.Reader(Properties.Resources.SelectByParam);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }    
        }

        public bool Insert(Entidade.Portarias obj)
        {
            try
            {

                AcessoDados.ReiniciarParametros();

                AcessoDados.AdicionarParametros("@Numero", obj.Numero);
                AcessoDados.AdicionarParametros("@Data", obj.Data);
                AcessoDados.AdicionarParametros("@Tipo", obj.Tipo);
                AcessoDados.AdicionarParametros("@Resumo", obj.Resumo);
                AcessoDados.AdicionarParametros("@Servidor", obj.Servidor);
                AcessoDados.AdicionarParametros("@Link", obj.Pdf);
                AcessoDados.AdicionarParametros("@Publicado", obj.Publicada);
                AcessoDados.AdicionarParametros("@Cadastro", obj.Cadastrado.ToShortDateString());
                AcessoDados.AdicionarParametros("@Atualizado", obj.Atualizado.ToShortDateString());
                AcessoDados.AdicionarParametros("@Excluido", obj.Excluido);

                DataTable dt = AcessoDados.Reader(Properties.Resources.SelectByNumber);

                if (dt.Rows.Count > 0)
                    return false;
                
                return AcessoDados.Writing(Properties.Resources.InsertQuery);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(Entidade.Portarias obj)
        {

            string sqlCommand = @"UPDATE Portarias SET Numero = @Numero, Data = @Data, Tipo = @Tipo, Resumo = @Resumo, Servidor = @Servidor, Link = @Link, Publicado = @Publicado, Cadastro = @Cadastro, Atualizado = @Atualizado, Excluido = @Excluido WHERE (Indice = @Original_Indice)";
            try
            {

                AcessoDados.ReiniciarParametros();

                AcessoDados.AdicionarParametros("@Numero", obj.Numero);
                AcessoDados.AdicionarParametros("@Data", obj.Data);
                AcessoDados.AdicionarParametros("@Tipo", obj.Tipo);
                AcessoDados.AdicionarParametros("@Resumo", obj.Resumo);
                AcessoDados.AdicionarParametros("@Servidor", obj.Servidor);
                AcessoDados.AdicionarParametros("@Link", obj.Pdf);
                AcessoDados.AdicionarParametros("@Publicado", obj.Publicada);
                AcessoDados.AdicionarParametros("@Cadastro", obj.Cadastrado);
                AcessoDados.AdicionarParametros("@Atualizado", obj.Atualizado);
                AcessoDados.AdicionarParametros("@Excluido", obj.Excluido);

                AcessoDados.AdicionarParametros("@Original_Indice", obj.Indice);

                return AcessoDados.Writing(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(Entidade.Portarias obj)
        {
            try
            {
                return AcessoDados.Writing(Properties.Resources.DeleteQuery);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<object> Servidores()
        {
            try
            {
                DataTable dt = AcessoDados.Reader(Properties.Resources.SelectServidores);

                List<object> listagenerica = new List<object>();

                foreach (DataRow dr in dt.Rows)
                {
                    listagenerica.Add(dr[0].ToString());
                }

                return listagenerica;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public bool InsertNewServidor(Entidade.Portarias obj)
        {
            try
            {

                AcessoDados.ReiniciarParametros();

                AcessoDados.AdicionarParametros("@Servidor", obj.Servidor);
                AcessoDados.AdicionarParametros(@"Inserido", obj.Cadastrado.ToShortDateString());
                AcessoDados.AdicionarParametros("@Bloqueado", obj.Excluido);

                return AcessoDados.Writing(Properties.Resources.InsertNewServidor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public DataTable ConsultaNumero(int valor, DateTime data)
        {
            try
            {
                AcessoDados.ReiniciarParametros();

                AcessoDados.AdicionarParametros("@Numero", valor);
                AcessoDados.AdicionarParametros("@Data", data);

                return AcessoDados.Reader(Properties.Resources.SelectByNumber);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }   
        }

        int tipo = 0;
        public ListViewPortarias ConsultaDetalhada(Entidade.Portarias obj)
        {
            try
            {
                AcessoDados.ReiniciarParametros();
                /*
                DataSet TiposXML = new DataSet();
                Sim.Classes.XmlFile XmlCtrl = new Sim.Classes.XmlFile();

                TiposXML = XmlCtrl.xmlDS(Classes.XmlFile.XmlMPO.Tipos, Sim.Classes.XmlFile.xTabela.xMPO);
                */

                List<string> tipos = new List<string>();

                tipos = App.Xml.Files.Listar("Portaria", "Portarias", "Tipo", "Item");

                AcessoDados.AdicionarParametros("@NumeroI", obj.NumeroI);
                AcessoDados.AdicionarParametros("@NumeroF", obj.NumeroF);
                AcessoDados.AdicionarParametros("@Data1", "01/01/" + obj.AnoI);
                AcessoDados.AdicionarParametros("@Data2", "31/12/" + obj.AnoF);
                AcessoDados.AdicionarParametros("@Tipo", obj.Tipo);
                AcessoDados.AdicionarParametros("@Resumo", obj.Resumo);
                AcessoDados.AdicionarParametros("@Nome", obj.Servidor);

                var listagenerica = new Entidade.ListViewPortarias();
                
                foreach (DataRow dr in AcessoDados.Reader(Properties.Resources.SelectByParam).Rows)
                {
                    var listaportarias = new Entidade.ViewPortarias();

                    listaportarias.Indice = (int)dr["Indice"];
                    listaportarias.IndiceLink = dr["Indice"].ToString();
                    listaportarias.Numero = (int)dr["Numero"];
                    listaportarias.Data = (DateTime)dr["Data"];

                    tipo = Convert.ToInt32(dr["Tipo"]);

                    //dr["Tipo"] = string.Format("{0}:{1}", row["Tipo"], TiposXML.Tables[0].Rows[tipo][0]);

                    listaportarias.Tipo = string.Format("{0}", tipos[tipo]); //TiposXML.Tables[0].Rows[tipo][0]);

                    //listaportarias.Tipo = (string)dr["Tipo"];
                    listaportarias.Resumo = (string)dr["Resumo"];
                    listaportarias.Pdf = (string)dr["Link"];
                    listaportarias.Publicada = (string)dr["Publicado"];
                    listaportarias.Cadastrado = (DateTime)dr["Cadastro"];
                    listaportarias.Atualizado = (DateTime)dr["Atualizado"];
                    listaportarias.Excluido = (bool)dr["Excluido"];

                    string[] linha = dr["Servidor"].ToString().Split(';');

                    var ls = new Entidade.ListViewServidores();

                    foreach (string l in linha)
                    {
                        var listanome = new Entidade.ViewServidores();
                        listanome.Servidor = l.ToString();
                        ls.Add(listanome);
                    }

                    listaportarias.Servidores = ls;

                    listagenerica.Add(listaportarias);
                                 
                }

                return listagenerica;
                //throw new NotImplementedException(); //AcessoDados.Reader(Properties.Resources.SelectByParam);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ConsultaID(int id)
        {

            string sqlCommand = @"SELECT * FROM Portarias WHERE (Indice = @Indice AND Excluido = 0)";

            try
            {
                AcessoDados.ReiniciarParametros();
                AcessoDados.AdicionarParametros("@Indice", id);

                return AcessoDados.Reader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
