using System;
using System.Collections.Generic;
using System.Data;
using Sim.Legislacao.Entidades;

namespace Sim.Legislacao.Negocios
{
    class Regras : IRegras
    {

        int cont_lei = 0;
        int cont_dec = 0;
        int cont_lc = 0;
        int cont_reg = 0;
        int progresso = 0;

        /// <summary>
        /// Grava dados na tabela "legislacao", "legislacaoacoes"
        /// verifica e altera a situacao do documento alvo da acao.
        /// </summary>
        /// <param name="obj">objeto contendo dados para gravar na tabela legislacao</param>
        /// <param name="lista">lista de objeto contendo as acoes para tabela legislacaoacoes</param>
        /// <returns>se gravar, retorna true</returns>
        public bool Insert(Entidades.Legislacao obj, ListaAcoes lista)
        {

            string sqlcommand = @"INSERT INTO [Legislacao] ([Tipo], [Numero], [Complemento], [Data], [Publicado], [Resumo], [Classificado], [Link], [Situacao], [Origem], [Autor], [Cadastro], [Atualizado], [Excluido]) VALUES (@Tipo, @Numero, @Complemento, @Data, @Publicado, @Resumo, @Classificado, @Link, @Situacao, @Origem, @Autor, @Cadastro, @Atualizado, @Excluido)";

            Sim.DataAccess.IDataAccess AcessarDados = Sim.DataAccess.Instancia.ModuloAccess();

            try
            {
                AcessarDados.ReiniciarParametros();
                AcessarDados.AdicionarParametros("@Tipo", obj.Tipo);
                AcessarDados.AdicionarParametros("@Numeo", obj.Numero);
                AcessarDados.AdicionarParametros("@Complemento", obj.Complemento);
                AcessarDados.AdicionarParametros("@Data", obj.Data);
                AcessarDados.AdicionarParametros("@Publicado", obj.Publicado);
                AcessarDados.AdicionarParametros("@Resumo", obj.Resumo);
                AcessarDados.AdicionarParametros("@Classificado", obj.Classificacao);
                AcessarDados.AdicionarParametros("@Link", obj.Link);
                AcessarDados.AdicionarParametros("@Situacao", obj.Situacao);
                AcessarDados.AdicionarParametros("@Origem", obj.Origem);
                AcessarDados.AdicionarParametros("@Autor", obj.Autor);
                AcessarDados.AdicionarParametros("@Cadastro", obj.Cadastro);
                AcessarDados.AdicionarParametros("@Atualizado", obj.Cadastro);
                AcessarDados.AdicionarParametros("@Excluido", obj.Excluido);

                //checa se ja existe registro com as informações do obj.
                if (AcessarDados.Reader(Properties.Resources.SelectSimples).Rows.Count > 0)
                    return false;


                DataAccess.IDataAccess AcoesDados = DataAccess.Instancia.ModuloAccess();
                string sqlcommandAcoes = @"INSERT INTO [LegislacaoAcoes] ([TipoOrigem], [NumeroOrigem], [ComplementoOrigem], [DataOrigem], [AcaoExecutada], [TipoAlvo], [NumeroAlvo], [ComplementoAlvo], [DataAlvo], [Inserido]) VALUES (@TipoOrigem, @NumeroOrigem, @CompOrigem, @DataOrigem, @Acao, @TipoAlvo, @NumeroAlvo, @CompAlvo, @DataAlvo, @Inserido)";

                //lista as acoes para serem gravados
                foreach (Entidades.Acoes acoes in lista)
                {
                    AcoesDados.ReiniciarParametros();

                    AcoesDados.AdicionarParametros("@TipoOrigem", acoes.TipoOrigem);
                    AcoesDados.AdicionarParametros("@NumeroOrigem", acoes.NumeroOrigem);
                    AcoesDados.AdicionarParametros("@CompOrigem", acoes.ComplementoOrigem);
                    AcoesDados.AdicionarParametros("@DataOrigem", acoes.DataOrigem.ToShortDateString());
                    AcoesDados.AdicionarParametros("@Acao", acoes.Acao);
                    AcoesDados.AdicionarParametros("@TipoAlvo", acoes.TipoAlvo);
                    AcoesDados.AdicionarParametros("@NumeroAlvo", acoes.NumeroAlvo);
                    AcoesDados.AdicionarParametros("@CompAlvo", acoes.ComplementoAlvo);
                    AcoesDados.AdicionarParametros("@DataAlvo", acoes.DataAlvo.ToShortDateString());
                    AcoesDados.AdicionarParametros("@Inserido", acoes.Incluido.ToShortDateString());

                    if (AcoesDados.Writing(sqlcommandAcoes) == false)
                        return false;

                    //checa a acao e altera a situacao do documento alvo
                    var upSituacao = DataAccess.Instancia.ModuloAccess();

                    string novaSituacao = acoes.Acao;

                    string sqlcommandalUpdateAlvo = @"UPDATE [Legislacao] SET [Situacao] = @Situacao WHERE (Tipo = @TipoAlvo) AND (Numero = @NumeroAlvo) AND (Complemento = @CompAlvo) AND (Data = @DataAlvo)";

                    switch(acoes.Acao)
                    {
                        case "1":
                            novaSituacao = "2";
                            break;

                        case "2":
                            novaSituacao = "3";
                            break;
                    }

                    upSituacao.ReiniciarParametros();

                    upSituacao.AdicionarParametros("@Situacao", novaSituacao);
                    upSituacao.AdicionarParametros("@TipoAlvo", acoes.TipoAlvo);
                    upSituacao.AdicionarParametros("@NumeroAlvo", acoes.NumeroAlvo);
                    upSituacao.AdicionarParametros("@CompAlvo", acoes.ComplementoAlvo);
                    upSituacao.AdicionarParametros("@DataAlvo", acoes.DataAlvo.ToShortDateString());

                    upSituacao.Writing(sqlcommandalUpdateAlvo);

                }

                return AcessarDados.Writing(sqlcommand);

                

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
            finally
            {
                AcessarDados = null;                
            }

        }

        /// <summary>
        /// Altera as Informações do document.
        /// </summary>
        /// <param name="obj">obj que contem as informações para serem alteradas</param>
        /// <returns>true ou false</returns>
        public bool Update(Entidades.Legislacao obj)
        {
            string sqlcommand = @"UPDATE [Legislacao] SET [Tipo] = @Tipo, [Numero] = @Numero, [Complemento] = @Complemento, [Data] = @Data, [Publicado] = @Publicado, [Resumo] = @Resumo, [Classificado] = @Classificado, [Link] = @Link, [Situacao] = @Situacao, [Origem] = @Origem, [Autor] = @Autor, [Cadastro] = @Cadastro, [Atualizado] = @Atualizado,  [Excluido] = @Excluido WHERE ([Indice] = @Original_Indice)";

            DataAccess.IDataAccess AcessarDados = Sim.DataAccess.Instancia.ModuloAccess();

            try
            {
                AcessarDados.ReiniciarParametros();
                AcessarDados.AdicionarParametros("@Tipo", obj.Tipo);
                AcessarDados.AdicionarParametros("@Numeo", obj.Numero);
                AcessarDados.AdicionarParametros("@Complemento", obj.Complemento);
                AcessarDados.AdicionarParametros("@Data", obj.Data);
                AcessarDados.AdicionarParametros("@Publicado", obj.Publicado);
                AcessarDados.AdicionarParametros("@Resumo", obj.Resumo);
                AcessarDados.AdicionarParametros("@Classificado", obj.Classificacao);
                AcessarDados.AdicionarParametros("@Link", obj.Link);
                AcessarDados.AdicionarParametros("@Situacao", obj.Situacao);
                AcessarDados.AdicionarParametros("@Origem", obj.Origem);
                AcessarDados.AdicionarParametros("@Autor", obj.Autor);
                AcessarDados.AdicionarParametros("@Cadastro", obj.Cadastro);
                AcessarDados.AdicionarParametros("@Atualizado", obj.Cadastro);
                AcessarDados.AdicionarParametros("@Excluido", obj.Excluido);

                AcessarDados.AdicionarParametros("@Original_Indice", obj.Indice);

                return AcessarDados.Writing(sqlcommand);

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
            finally
            {
                AcessarDados = null;
            }
        }

        public bool Delete(Entidades.Legislacao obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Consulta banco de dados em segundo plano conforme a tipo escolhido, e as informações passadas pelo obj, 
        /// </summary>
        /// <param name="Tipo">Consulta Simples ou Detalhada</param>
        /// <param name="obj">objeto que contem as informações para realizar as consultas</param>
        /// <param name="bgwork">componente BackgroundWorker</param>
        /// <returns>Lista</returns>
        public ListaLegislacao Consultar(TipoConsulta Tipo, Entidades.Legislacao obj, System.ComponentModel.BackgroundWorker bgwork)
        {
            var dataAccess = DataAccess.Instancia.ModuloAccess();
            try
            {
                cont_lei = 0;
                cont_dec = 0;
                cont_lc = 0;
                cont_reg = 0;                

                string SqlCommand = string.Empty;

                switch (Tipo)
                {
                    case TipoConsulta.SemFiltro:
                        SqlCommand = Properties.Resources.SelectSemFiltro;
                        break;
                    case TipoConsulta.Simples:
                        dataAccess.ReiniciarParametros();
                        dataAccess.AdicionarParametros("@Tipo", obj.Tipo);
                        dataAccess.AdicionarParametros("@Numero", obj.Numero);
                        dataAccess.AdicionarParametros("@Complemento", obj.Complemento);
                        SqlCommand = Properties.Resources.SelectSimples;
                        break;
                    case TipoConsulta.Detalhada:
                        dataAccess.ReiniciarParametros();
                        dataAccess.AdicionarParametros("@Tipo", obj.Tipo);
                        dataAccess.AdicionarParametros("@Data1", obj.Data);
                        dataAccess.AdicionarParametros("@Data2", obj.Data2);
                        dataAccess.AdicionarParametros("@Resumo", obj.Resumo);
                        dataAccess.AdicionarParametros("@Classificado", obj.Classificacao);
                        dataAccess.AdicionarParametros("@Situacao", obj.Situacao);
                        dataAccess.AdicionarParametros("@Origem", obj.Origem);
                        dataAccess.AdicionarParametros("@Autor", obj.Autor);
                        SqlCommand = Properties.Resources.SelectDetalhado;
                        break;
                }

                var Acoes = dataAccess.Reader(Properties.Resources.AcoesSemFiltro);

                int vreg = dataAccess.Reader(SqlCommand).Rows.Count;

                var lista = new Entidades.ListaLegislacao();

                foreach (DataRow leg in dataAccess.Reader(SqlCommand).Rows)
                {
                    var legislacao = new Entidades.Legislacao();

                    cont_reg += 1;

                    legislacao.Indice = (int)leg["Indice"];
                    legislacao.IndiceLink = leg["Indice"].ToString();
                    legislacao.Tipo = leg["Tipo"].ToString();

                    if (legislacao.Tipo.Equals("LEI")) { cont_lei += 1; }
                    if (legislacao.Tipo.Equals("LEI COMPLEMENTAR")) { cont_lc += 1; }
                    if (legislacao.Tipo.Equals("DECRETO")) { cont_dec += 1; }

                    legislacao.Numero = (int)leg["Numero"];
                    legislacao.Complemento = leg["Complemento"].ToString();
                    legislacao.Data = (DateTime)leg["Data"];
                    legislacao.Publicado = leg["Publicado"].ToString();
                    legislacao.Resumo = leg["Resumo"].ToString();
                    legislacao.Classificacao = leg["Classificado"].ToString();

                    legislacao.Link = Link.Create(legislacao.Tipo, legislacao.Data.ToString("yyyy"), legislacao.Numero);
                    //legislacao.Link = leg["Link"].ToString();
                    
                    legislacao.Situacao = new Situacao().Autal((int)leg["Situacao"]);

                    legislacao.Origem = leg["Origem"].ToString();
                    legislacao.Autor = leg["Autor"].ToString();
                    legislacao.Cadastro = (DateTime)leg["Cadastro"];
                    legislacao.Atualizado = (DateTime)leg["Atualizado"];
                    legislacao.Excluido = (bool)leg["Excluido"];
                    

                    var listaAcoes = new Entidades.ListaViewAcoes();

                    foreach (DataRow aed in Acoes.Rows)
                    {

                        if ((int)aed["NumeroAlvo"] == legislacao.Numero &&
                            aed["TipoAlvo"].ToString().ToLower() == legislacao.Tipo.ToLower() &&
                            aed["ComplementoAlvo"].ToString().ToLower() == legislacao.Complemento.ToLower())
                        {
                            var acoes = new Entidades.ViewAcoes();
                            acoes.Tipo = aed["TipoOrigem"].ToString();
                            acoes.Numero = (int)aed["NumeroOrigem"];
                            acoes.Complemento = aed["ComplementoOrigem"].ToString();
                            acoes.Data = (DateTime)aed["DataOrigem"];
                            acoes.Acao = new TipoAcoes().Recebidas((int)(aed["AcaoExecutada"]));
                            acoes.Link = Link.Create(acoes.Tipo, acoes.Data.ToString("yyyy"), acoes.Numero);
                            listaAcoes.Add(acoes);
                        }

                        if ((int)aed["NumeroOrigem"] == legislacao.Numero &&
                            aed["TipoOrigem"].ToString().ToLower() == legislacao.Tipo.ToLower() &&
                            aed["ComplementoOrigem"].ToString().ToLower() == legislacao.Complemento.ToLower())
                        {
                            var acoes = new Entidades.ViewAcoes();
                            acoes.Tipo = aed["TipoAlvo"].ToString();
                            acoes.Numero = (int)aed["NumeroAlvo"];
                            acoes.Complemento = aed["ComplementoAlvo"].ToString();
                            acoes.Data = (DateTime)aed["DataAlvo"];
                            acoes.Acao = new TipoAcoes().Exercidas((int)(aed["AcaoExecutada"]));
                            acoes.Link = Link.Create(acoes.Tipo, acoes.Data.ToString("yyyy"), acoes.Numero);
                            listaAcoes.Add(acoes);
                        }
                    }

                    progresso = ((cont_reg + 1) * 100) / vreg;
                    bgwork.ReportProgress(progresso);

                    legislacao.ListaAcoes = listaAcoes;

                    lista.Add(legislacao);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataAccess = null;
            }
        }

        public int ContadorLeis()
        {
            return cont_lei;
        }

        public int ContadorDecretos()
        {
            return cont_dec;
        }

        public int ContadorLeisComplementares()
        {
            return cont_lc;
        }

        public int ContadorRegistros()
        {
            return cont_reg;
        }

        /// <summary>
        /// Verifica se documento alvo de uma acao existe no banco de dados Legislacao
        /// </summary>
        /// <param name="tipo">Lei, Decreto ou Lei Complementar</param>
        /// <param name="numero">999</param>
        /// <param name="complemento">A, B, C, etc...</param>
        /// <returns>Lista</returns>
        public List<string> DocValidos(string tipo, int numero, string complemento)
        {
            string sqlcommand = @"SELECT Tipo, Numero, Complemento, Data FROM Legislacao WHERE (Tipo LIKE @Tipo) AND (Numero = @Numero) AND (Complemento LIKE @Comp) AND (Excluido = 0)";
            var dataAccess = DataAccess.Instancia.ModuloAccess();
            try
            {
                dataAccess.ReiniciarParametros();

                dataAccess.AdicionarParametros("@Tipo", tipo);
                dataAccess.AdicionarParametros("@Numero", numero);
                dataAccess.AdicionarParametros("@Comp", complemento);

                List<string> lista = new List<string> { };

                foreach (DataRow dr in dataAccess.Reader(sqlcommand).Rows)
                {
                    lista.Add(dr["Tipo"].ToString());
                    lista.Add(dr["Numero"].ToString());
                    lista.Add(dr["Complemento"].ToString());
                    lista.Add(dr["Data"].ToString());
                }

                return lista;

            }
            catch(Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
            finally
            {
                dataAccess = null;
            }
        }

        /// <summary>
        /// Gera lista com dados a serem Alterados.
        /// </summary>
        /// <param name="obj">objeto que contem parametros pra gerar a lista</param>
        /// <returns>Lista</returns>
        public ListaLegislacao ListaParaEdicao(Entidades.Legislacao obj)
        {

            var dataLegis = DataAccess.Instancia.ModuloAccess();
            var dataAcoes = DataAccess.Instancia.ModuloAccess();

            try
            {                

                string sqlCommand = @"SELECT * FROM Legislacao WHERE (Indice = @Indice) AND (Excluido = 0)";
                string sqlCommandAcoes = @"SELECT * FROM LegislacaoAcoes WHERE(TipoOrigem LIKE @Tipo) AND (NumeroOrigem = @Numero) AND (ComplementoOrigem LIKE @Comp)";

                dataLegis.ReiniciarParametros();
                dataLegis.AdicionarParametros("@Indice", obj.Indice);                

                //System.Windows.Forms.MessageBox.Show(obj.Tipo + obj.Numero + obj.Complemento);

                var lista = new ListaLegislacao();

                foreach (DataRow leg in dataLegis.Reader(sqlCommand).Rows)
                {
                    var legislacao = new Entidades.Legislacao();
                    
                    legislacao.Indice = (int)leg["Indice"];
                    legislacao.Tipo = leg["Tipo"].ToString();
                    legislacao.Numero = (int)leg["Numero"];
                    legislacao.Complemento = leg["Complemento"].ToString();
                    legislacao.Data = (DateTime)leg["Data"];
                    legislacao.Publicado = leg["Publicado"].ToString();
                    legislacao.Resumo = leg["Resumo"].ToString();
                    legislacao.Classificacao = leg["Classificado"].ToString();
                    legislacao.Link = leg["Link"].ToString();
                    legislacao.Situacao = leg["Situacao"].ToString();
                    legislacao.Origem = leg["Origem"].ToString();
                    legislacao.Autor = leg["Autor"].ToString();
                    legislacao.Cadastro = (DateTime)leg["Cadastro"];
                    legislacao.Atualizado = (DateTime)leg["Atualizado"];
                    legislacao.Excluido = (bool)leg["Excluido"];

                    dataAcoes.ReiniciarParametros();
                    dataAcoes.AdicionarParametros("@Tipo", legislacao.Tipo);
                    dataAcoes.AdicionarParametros("@Numero", legislacao.Numero);
                    dataAcoes.AdicionarParametros("@Comp", legislacao.Complemento);

                    var listaAcoes = new ListaViewAcoes();                    

                    foreach (DataRow ac in dataAcoes.Reader(sqlCommandAcoes).Rows)
                    {
                        var acoes = new ViewAcoes();
                        acoes.Indice = (int)ac["Indice"];
                        acoes.Tipo = ac["TipoAlvo"].ToString();
                        acoes.Numero = (int)ac["NumeroAlvo"];
                        acoes.Complemento = ac["ComplementoAlvo"].ToString();
                        acoes.Data = (DateTime)ac["DataAlvo"];
                        acoes.Acao = new TipoAcoes().Exercidas((int)(ac["AcaoExecutada"]));
                        listaAcoes.Add(acoes);
                    }

                    legislacao.ListaAcoes = listaAcoes;

                    lista.Add(legislacao);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataLegis = null;
                dataAcoes = null;
            }
        }

        /// <summary>
        /// Grava uma nova acao na tabela ligislacaoacoes
        /// Altera a situação do documento alvo da ação
        /// </summary>
        /// <param name="obj">objeto para serem gravados</param>
        /// <returns> Retorna Lista com o ultimo registro da tabela legislacao</returns>
        public ListaViewAcoes InsertAcao(Acoes obj)
        {

            DataAccess.IDataAccess AcoesDados = DataAccess.Instancia.ModuloAccess();

            try
            {
                string sqlcommandAcoes = @"INSERT INTO [LegislacaoAcoes] ([TipoOrigem], [NumeroOrigem], [ComplementoOrigem], [DataOrigem], [AcaoExecutada], [TipoAlvo], [NumeroAlvo], [ComplementoAlvo], [DataAlvo], [Inserido]) VALUES (@TipoOrigem, @NumeroOrigem, @CompOrigem, @DataOrigem, @Acao, @TipoAlvo, @NumeroAlvo, @CompAlvo, @DataAlvo, @Inserido)";

                AcoesDados.ReiniciarParametros();

                AcoesDados.AdicionarParametros("@TipoOrigem", obj.TipoOrigem);
                AcoesDados.AdicionarParametros("@NumeroOrigem", obj.NumeroOrigem);
                AcoesDados.AdicionarParametros("@CompOrigem", obj.ComplementoOrigem);
                AcoesDados.AdicionarParametros("@DataOrigem", obj.DataOrigem.ToShortDateString());
                AcoesDados.AdicionarParametros("@Acao", obj.Acao);
                AcoesDados.AdicionarParametros("@TipoAlvo", obj.TipoAlvo);
                AcoesDados.AdicionarParametros("@NumeroAlvo", obj.NumeroAlvo);
                AcoesDados.AdicionarParametros("@CompAlvo", obj.ComplementoAlvo);
                AcoesDados.AdicionarParametros("@DataAlvo", obj.DataAlvo.ToShortDateString());
                AcoesDados.AdicionarParametros("@Inserido", obj.Incluido.ToShortDateString());


                var upSituacao = DataAccess.Instancia.ModuloAccess();

                string novaSituacao = obj.Acao;

                string sqlcommandalUpdateAlvo = @"UPDATE [Legislacao] SET [Situacao] = @Situacao WHERE (Tipo = @TipoAlvo) AND (Numero = @NumeroAlvo) AND (Complemento = @CompAlvo) AND (Data = @DataAlvo)";

                switch (obj.Acao)
                {
                    case "1":
                        novaSituacao = "2";
                        break;

                    case "2":
                        novaSituacao = "3";
                        break;
                }

                upSituacao.ReiniciarParametros();

                upSituacao.AdicionarParametros("@Situacao", novaSituacao);
                upSituacao.AdicionarParametros("@TipoAlvo", obj.TipoAlvo);
                upSituacao.AdicionarParametros("@NumeroAlvo", obj.NumeroAlvo);
                upSituacao.AdicionarParametros("@CompAlvo", obj.ComplementoAlvo);
                upSituacao.AdicionarParametros("@DataAlvo", obj.DataAlvo.ToShortDateString());

                upSituacao.Writing(sqlcommandalUpdateAlvo);

                AcoesDados.Writing(sqlcommandAcoes);

                string sqlreturn = @"SELECT TOP 1 Indice, TipoAlvo, NumeroAlvo, ComplementoAlvo, DataAlvo, AcaoExecutada FROM LegislacaoAcoes ORDER BY Indice DESC";
                AcoesDados.ReiniciarParametros();

                var listaAcoes = new ListaViewAcoes();

                foreach (DataRow ac in AcoesDados.Reader(sqlreturn).Rows)
                {
                    var acoes = new ViewAcoes();
                    acoes.Indice = (int)ac["Indice"];
                    acoes.Tipo = ac["TipoAlvo"].ToString();
                    acoes.Numero = (int)ac["NumeroAlvo"];
                    acoes.Complemento = ac["ComplementoAlvo"].ToString();
                    acoes.Data = (DateTime)ac["DataAlvo"];
                    acoes.Acao = new TipoAcoes().Exercidas((int)(ac["AcaoExecutada"]));
                    listaAcoes.Add(acoes);
                }

                return listaAcoes;
            }
            catch(Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
            finally
            {
                AcoesDados = null;
            }        
        }

        /// <summary>
        /// Apaga uma ação da tabela legislacaoacoes
        /// verifica o objeto alvo da ação a ser apagada na tabela legislacaoacoes
        /// se tiver somente uma (1) acao sofrida, altera a situacao na tabela legislacao,
        /// se tivser mais de uma (1), mantem a situacao do documento alvo na tabela legislacao.
        /// </summary>
        /// <param name="obj">objeto acoes</param>
        /// <returns>true ou false</returns>
        public bool DelAcao(Acoes obj)
        {
            string sqlcommand = @"DELETE FROM LegislacaoAcoes WHERE (Indice = @Indice)";

            DataAccess.IDataAccess AcoesDados = DataAccess.Instancia.ModuloAccess();

            try
            {               

                var upSituacao = DataAccess.Instancia.ModuloAccess();

                string novaSituacao = obj.Acao;

                string sqlcommandRollbackSituacao= @"SELECT * FROM LegislacaoAcoes WHERE (TipoAlvo = @TipoAlvo) AND (NumeroAlvo = @NumeroAlvo) AND (ComplementoAlvo = @CompAlvo) AND (DataAlvo = @DataAlvo)";

                upSituacao.ReiniciarParametros();

                upSituacao.AdicionarParametros("@TipoAlvo", obj.TipoAlvo);
                upSituacao.AdicionarParametros("@NumeroAlvo", obj.NumeroAlvo);
                upSituacao.AdicionarParametros("@CompAlvo", obj.ComplementoAlvo);
                upSituacao.AdicionarParametros("@DataAlvo", obj.DataAlvo.ToShortDateString());

                if (upSituacao.Reader(sqlcommandRollbackSituacao).Rows.Count == 1)
                {
                    novaSituacao = "1";

                    string sqlcommandUpdateSituacao = @"UPDATE [Legislacao] SET [Situacao] = @Situacao WHERE (Tipo = @TipoAlvo) AND (Numero = @NumeroAlvo) AND (Complemento = @CompAlvo) AND (Data = @DataAlvo)";

                    upSituacao.ReiniciarParametros();

                    upSituacao.AdicionarParametros("@Situacao", novaSituacao);
                    upSituacao.AdicionarParametros("@TipoAlvo", obj.TipoAlvo);
                    upSituacao.AdicionarParametros("@NumeroAlvo", obj.NumeroAlvo);
                    upSituacao.AdicionarParametros("@CompAlvo", obj.ComplementoAlvo);
                    upSituacao.AdicionarParametros("@DataAlvo", obj.DataAlvo.ToShortDateString());

                    upSituacao.Writing(sqlcommandUpdateSituacao);
                }

                AcoesDados.ReiniciarParametros();

                AcoesDados.AdicionarParametros("@Indice", obj.Indice);

                return AcoesDados.Writing(sqlcommand);
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
            finally
            {
                AcoesDados = null;
            }
        }
    }
}
