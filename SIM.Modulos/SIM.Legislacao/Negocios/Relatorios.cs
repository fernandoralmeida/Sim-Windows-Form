using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sim.Legislacao.Negocios
{
    class Relatorios : IRelatorios
    {

        int progresso;

        int total;

        int leis;
        int decretos;
        int leiscomp;

        int leisrev;
        int leisalt;
        int leisvig;

        int decrev;
        int decalt;
        int decvig;

        int leiscomprev;
        int leiscompalt;
        int leiscompvig;

        int leisclass;
        int decclass;
        int leiscompclass;

        int leisautor;
        int decautor;
        int leiscompautor;

        int autorleg;
        int autorexec;
        int autormesadir;
        int autorver;

        void resetContadores()
        {
            progresso = 0;

            total = 0;

            leis = 0;
            decretos = 0;
            leiscomp = 0;

            leisrev = 0;
            leisalt = 0;
            leisvig = 0;

            decrev = 0;
            decalt = 0;
            decvig = 0;

            leiscomprev = 0;
            leiscompalt = 0;
            leiscompvig = 0;

            leisclass = 0;
            decclass = 0;
            leiscompclass = 0;

            leisautor = 0;
            decautor = 0;
            leiscompautor = 0;

            autorleg = 0;
            autorexec = 0;
            autormesadir = 0;
            autorver = 0;
        }

        public int DecAlt()
        {
            return decalt;
        }

        public int DecAutor()
        {
            return decautor;
        }

        public int DecClass()
        {
            return decclass;
        }

        public int Decretos()
        {
            return decretos;
        }

        public int DecRev()
        {
            return decrev;
        }

        public int DecVig()
        {
            return decvig;
        }

        public void Gerar(Entidades.Legislacao obj, System.ComponentModel.BackgroundWorker bgwork)
        {

            resetContadores();

            string sqlcommand= @"SELECT  * FROM Legislacao
WHERE(Tipo LIKE @Tipo)
AND(Data BETWEEN @Data1 AND @Data2)
AND(Resumo LIKE '%' + @Resumo + '%')
AND(Classificado LIKE @Classificado)
AND(Situacao LIKE @Situacao)
AND(Origem LIKE @Origem)
AND(Autor LIKE '%' + @Autor + '%') AND(Excluido = 0)
ORDER BY Data DESC, Numero DESC";

            var dataAccess = DataAccess.Instancia.ModuloAccess();

            try
            {
                dataAccess.AdicionarParametros("@Tipo", obj.Tipo);
                dataAccess.AdicionarParametros("@Data1", obj.Data);
                dataAccess.AdicionarParametros("@Data2", obj.Data2);
                dataAccess.AdicionarParametros("@Resumo", obj.Resumo);
                dataAccess.AdicionarParametros("@Classificado", obj.Classificacao);
                dataAccess.AdicionarParametros("@Situacao", obj.Situacao);
                dataAccess.AdicionarParametros("@Origem", obj.Origem);
                dataAccess.AdicionarParametros("@Autor", obj.Autor);


                List<string> leisClassificacao = new List<string>();
                List<string> decretosClassificacao = new List<string>();

                decretosClassificacao = App.Xml.Files.Listar("Legislacao", "BaseDados", "DecretosClassificacao", "Item");
                leisClassificacao = App.Xml.Files.Listar("Legislacao", "BaseDados", "LeisClassificacao", "Item");

                int vtotal = 0;

                foreach (DataRow leg in dataAccess.Reader(sqlcommand).Rows)
                {
                    
                    vtotal = leg.Table.Rows.Count;

                    total++;

                    var legislacao = new Entidades.Legislacao();

                    legislacao.Indice = (int)leg["Indice"];
                    legislacao.IndiceLink = leg["Indice"].ToString();
                    legislacao.Tipo = leg["Tipo"].ToString();
                    
                    legislacao.Numero = (int)leg["Numero"];
                    legislacao.Complemento = leg["Complemento"].ToString();
                    legislacao.Data = (DateTime)leg["Data"];
                    legislacao.Publicado = leg["Publicado"].ToString();
                    legislacao.Resumo = leg["Resumo"].ToString();
                    legislacao.Classificacao = leg["Classificado"].ToString();
                    legislacao.Link = leg["Link"].ToString();

                    //legislacao.Situacao = new Situacao().Autal((int)leg["Situacao"]);

                    legislacao.Situacao = leg["Situacao"].ToString();

                    legislacao.Origem = leg["Origem"].ToString();
                    legislacao.Autor = leg["Autor"].ToString();
                    legislacao.Cadastro = (DateTime)leg["Cadastro"];
                    legislacao.Atualizado = (DateTime)leg["Atualizado"];
                    legislacao.Excluido = (bool)leg["Excluido"];


                    switch(legislacao.Tipo)
                    {
                        case "LEI":
                            leis++;
                            if (legislacao.Situacao == 1.ToString()) { leisvig++; }

                            if (legislacao.Situacao == 2.ToString()) { leisalt++; }

                            if (legislacao.Situacao == 3.ToString()) { leisrev++; }

                            if (legislacao.Origem == 1.ToString()) { autorexec++; }

                            if (legislacao.Origem == 2.ToString())
                            {
                                autorleg++;
                                if (legislacao.Autor.ToLower() == "mesa diretora")
                                    autormesadir++;
                                else
                                    autorver++;
                            }

                            for (int i = 0; i < leisClassificacao.Count; i++)
                            {
                                if (legislacao.Classificacao == i.ToString())
                                {
                                    leisclass++;
                                }
                            }                           

                            break;

                        case "LEI COMPLEMENTAR":
                            leiscomp++;
                            if (legislacao.Situacao == 1.ToString()) { leiscompvig++; }

                            if (legislacao.Situacao == 2.ToString()) { leiscompalt++; }

                            if (legislacao.Situacao == 3.ToString()) { leiscomprev++; }

                            if (legislacao.Origem == 1.ToString()) { autorexec++; }

                            if (legislacao.Origem == 2.ToString())
                            {
                                autorleg++;
                                if (legislacao.Autor.ToLower() == "mesa diretora")
                                    autormesadir++;
                                else
                                    autorver++;
                            }

                            for (int i = 0; i < leisClassificacao.Count; i++)
                            {
                                if (legislacao.Classificacao == i.ToString())
                                {
                                    leiscompclass++;
                                }
                            }

                            break;

                        case "DECRETO":
                            decretos++;

                            if (legislacao.Situacao == 1.ToString()) { decvig++; }

                            if (legislacao.Situacao == 2.ToString()) { decalt++; }

                            if (legislacao.Situacao == 3.ToString()) { decrev++; }

                            if (legislacao.Origem == 1.ToString()) { autorexec++; }

                            for (int i = 0; i < decretosClassificacao.Count; i++)
                            {
                                if (legislacao.Classificacao == i.ToString())
                                {
                                    decclass++;
                                }
                            }

                            break;
                    }                    

                }

                if (vtotal > 0)
                {
                    progresso = ((total + 1) * 100) / vtotal;
                    bgwork.ReportProgress(progresso);
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Leis()
        {
            return leis;
        }

        public int LeisAlt()
        {
            return leisalt;
        }

        public int LeisAutor()
        {
            return leisautor;
        }

        public int LeisClass()
        {
           return leisclass;
        }

        public int LeisComp()
        {
            return leiscomp;
        }

        public int LeisCompAlt()
        {
            return leiscompalt;
        }

        public int LeisCompAutor()
        {
            return leiscompautor;
        }

        public int LeisCompClass()
        {
            return leiscompclass;
        }

        public int LeisCompRev()
        {
            return leiscomprev;
        }

        public int LeisCompVig()
        {
            return leiscompvig;
        }

        public int LeisRev()
        {
            return leisrev;
        }

        public int LeisVig()
        {
            return leisvig;
        }

        public int Total()
        {
            return total;
        }

        public int TotalVig()
        {
            return leisvig + leiscompvig + decvig;
        }

        public int TotalAlt()
        {
            return leisalt + decalt + leiscompalt;
        }

        public int TotalRev()
        {
            return leisrev + decrev + leiscomprev;
        }

        public int AutorLeg()
        {
            return autorleg;
        }

        public int AutorExec()
        {
            return autorexec;
        }

        public int AutorMesaDir()
        {
            return autormesadir;
        }

        public int AutorVer()
        {
            return autorver;
        }
    }
}
