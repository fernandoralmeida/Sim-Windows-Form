using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Sim.Legislacao.RegraN
{
    public class WebPage
    {
        // Logica Negocios
        RegraN.ILegislacao Leg = Factories.Legislacao();
        RegraN.IAcaoes Acs = Factories.AcoesED();

        // Entidades
        AcoesED eA = Factories.ENTAcaoED();
        Legislacao eL = Factories.ENTLegislacao();
                       
        StringBuilder sHTML = new StringBuilder(string.Empty);

        // variavel comtrole de impressão
        public bool Imprimir = false;

        // controle de construção html
        public bool htmlFinalizadoOK = true;

        // Cria cabeçalho pra impressão HTML
        public void HeaderHTML()
        {
            sHTML.Append(@"<div class=""pm"">PREFEITURA DO MUNICIPIO DE JAHU</div>");
            sHTML.Append(@"<div class=""fundacao"">""Fundada em 15 de Agosto de 1853""</div>");
            sHTML.Append(@"<div class=""setor"">GERÊNCIA DE RELAÇÕES INSTITUCIONAIS</div>");
            sHTML.Append(@"<div class=""secretaria"">SECRETARIA DE GOVERNO</div>");
        }

        // Construtor HTML
        public void HTML(System.Windows.Forms.WebBrowser browser, System.Data.DataTable dtable, System.ComponentModel.BackgroundWorker bgk)
        {
            // pega caminho inicial dos arquivos pdf
            string webpath = Sim.Legislacao.Properties.Settings.Default.viaHD;

            // variavel para controle do DataSet
            //int TA = Constantes.Tabela.Leg;
            //int TB = Constantes.Tabela.Acs;
            
            // inicia o dataset
            //System.Data.DataSet DS = Acs.GetAcoes(); 

            int rowsA = dtable.Rows.Count;
            //int rowsB = DS.Tables[TB].Rows.Count;

            // Limpa a stringbuilder
            sHTML.Clear();
            
            // inicia a contrução do HTML
            sHTML.Append(@"<!DOCTYPE html>");
            sHTML.AppendLine(@"<html lang=""pt-BR"">");
            sHTML.Append(@"<head>");
            sHTML.Append(string.Format(@"<title>Gerado por: {0} as {1}h{2}m{3}s</title>", Login.Autenticado.UserName, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
            sHTML.Append(@"<meta http-equiv=""Content-Type"" content=""text/html;charset=UTF-8""/>");
            sHTML.Append(@"<style type=""text/css"">");
            sHTML.Append(@"body { margin: 0px 0px 0px 0px; font-family: Consolas; font-size: small; }");
            sHTML.Append(@"a { color: #005bff; } a:hover { color: #4800ff; } a:visited:link { color: #005bff; }");
            sHTML.Append(@".cell  { padding: 5px 5px 5px 5px; border-bottom: dotted 1px #808080; }");
            sHTML.Append(@".sub-cell { text-align: justify; padding: 2px 2px 2px 2px; }");
            sHTML.Append(@".acoes { padding-left: 5px; background-color: #eeefff; }");
            sHTML.Append(@".red { color: #FF0000; } .ambar { color: #FF9900; } .green { color: #009933; }");
            sHTML.Append(@".pm { font-family: Arial; font-size:medium; text-align:right; font-style: italic; font-weight: bold; }");
            sHTML.Append(@".fundacao { font-family: Arial; font-size:small; text-align:right; font-style: italic; border-bottom: dotted 1px #808080; }");
            sHTML.Append(@".secretaria {font-family: Arial;padding-bottom: 20px; text-align: center; font-size: small; }");
            sHTML.Append(@".setor { font-family: Arial; font-size: small; padding-top: 20px; text-align: center; font-weight: bold; }");
            sHTML.Append(@"</style>");
            sHTML.Append(@"</head>");
            sHTML.Append(@"<body>");

            // imprimi cabeçalho se for impressão!
            if (Imprimir.Equals(true))
            {
                HeaderHTML();
                Imprimir = false;
            }

            sHTML.Append(string.Format(@"<div class=""cell"">Encontrado(s) [ {0} ] registro(s)!</div>", rowsA));

            // Laço pra contar os registros da Tabela Legislação
            for (int i = 0; i < rowsA; i++)
            {
                             
                string tipo = dtable.Rows[i][1].ToString();
                string numero = dtable.Rows[i][2].ToString();
                string complemento = dtable.Rows[i][3].ToString();
                string data = dtable.Rows[i][4].ToString();
                string publicacao = dtable.Rows[i][5].ToString();
                string descricao = dtable.Rows[i][6].ToString();
                string classificacao = dtable.Rows[i][7].ToString();
                string link = dtable.Rows[i][8].ToString();
                string situacao = dtable.Rows[i][9].ToString();
                string origem = dtable.Rows[i][10].ToString();
                string autor = dtable.Rows[i][11].ToString();

                string url = webpath + link.Replace(@"/",@"\");                

                string cor = string.Empty;

                // define a cor conforme a situação 
                switch (situacao)
                {
                    case "2":
                        cor = "ambar";
                        break;
                    case "3":
                        cor = "red";
                        break;
                    default:
                        cor = "green";
                        break;
                }

                sHTML.Append(@"<div class=""cell"">");
                //sHTML.Append(string.Format(@"<div class=""sub-cell""><a href=""{0}"" target=""_blank"">{1} {2}{3}/{4}</a> <span class=""{5}"">[{6}]</span></div>", url, tipo, numero, complemento, Leg.Ano(data), cor, Leg.SituacaoToString(situacao).ToLower()));
                sHTML.Append(string.Format(@"<div class=""sub-cell"">Autor: {0}</div>", autor));
                sHTML.Append(string.Format(@"<div class=""sub-cell"">{0}</div>", descricao));

                sHTML.Append(@"<div class=""sub-cell"">Histórico das Ações:</div>");
                sHTML.Append(@"<div class=""acoes"">");
                /*
                // Laço da tabela ações
                for (int x = 0; x < rowsB; x++)
                {
                    
                    string tipoOrigem = DS.Tables[TB].Rows[x][1].ToString();
                    string numeroOrigem = DS.Tables[TB].Rows[x][2].ToString();
                    string compOrigem = DS.Tables[TB].Rows[x][3].ToString();
                    string anoOrigem = DS.Tables[TB].Rows[x][4].ToString();

                    string Acaoes = DS.Tables[TB].Rows[x][5].ToString();

                    string tipoAlvo = DS.Tables[TB].Rows[x][6].ToString();
                    string numeroAlvo = DS.Tables[TB].Rows[x][7].ToString();
                    string compAlvo = DS.Tables[TB].Rows[x][8].ToString();
                    string anoAlvo = DS.Tables[TB].Rows[x][9].ToString();                   
                    /*
                    // mostra a acão que foi origem
                    if (tipoOrigem.Equals(tipo) && numeroOrigem.Equals(numero) && compOrigem.Equals(complemento))
                    {
                        string linkz = string.Format(@"{0}\{1}\{2}\{3}{4}.pdf", webpath, Leg.TipoURL(tipoAlvo), Leg.Ano(anoAlvo), numeroAlvo, compAlvo);
                        sHTML.Append(string.Format(@"<div class=""sub-cell"">=> {0} <a href=""{1}"" target=""_blank"">{2} {3}{4}/{5}</a>;</div>", Acs.Origem(Acaoes), linkz, tipoAlvo, numeroAlvo, compAlvo, Leg.Ano(anoAlvo)));
                    }
                    
                    // mostra a ação que foi alvo
                    if (tipoAlvo.Equals(tipo) && numeroAlvo.Equals(numero) && compAlvo.Equals(complemento))
                    {
                        string linkz = string.Format(@"{0}\{1}\{2}\{3}{4}.pdf", webpath, Leg.TipoURL(tipoOrigem), Leg.Ano(anoOrigem), numeroOrigem, compOrigem);
                        sHTML.Append(string.Format(@"<div class=""sub-cell"">=> {0} <a href=""{1}"" target=""_blank"">{2} {3}{4}/{5}</a>;</div>", Acs.Alvo(Acaoes), linkz, tipoOrigem, numeroOrigem, compOrigem, Leg.Ano(anoOrigem)));
                    }
                    *//*
                }
                 */               
                sHTML.Append(@"</div>");
                sHTML.Append(@"<div></div></div>");

                // reporta o progresso da construção da pagina HTML;
                int progresso = ((i + 1) * 100) / rowsA;
                bgk.ReportProgress(progresso);

                // Se a operação for cancelada
                if (bgk.CancellationPending.Equals(true))
                {                    
                    sHTML.Clear();
                    htmlFinalizadoOK = false;
                    break;
                }
                else
                    htmlFinalizadoOK = true;

            }

            // finaliza o HTML
            sHTML.Append(@"</body>");
            sHTML.Append(@"</html>");

            // define arquivo 
            string fileName = string.Format(@"{0}/{1}/sim.desktop.html", System.Windows.Forms.Application.StartupPath, "Cache");
            FileInfo fi = new FileInfo(fileName);

            // cria novo arquivo 
            using (FileStream fs = fi.Create())
            {
                Byte[] txt = new UTF8Encoding(true).GetBytes(sHTML.ToString());
                fs.Write(txt, 0, txt.Length);
                Byte[] author = new UTF8Encoding(true).GetBytes("\n" + System.Windows.Forms.Application.ProductName + ".Build." + System.Windows.Forms.Application.ProductVersion);
                fs.Write(author, 0, author.Length);
            }

            // carrega arquivo no Navegador se construção html não foi cancelada
            if (htmlFinalizadoOK.Equals(true))
                browser.Navigate(new Uri(string.Format(@"{0}/{1}/sim.desktop.html", System.Windows.Forms.Application.StartupPath, "Cache")));            
            
            // carrega string em memoria
            //webb.DocumentText = Convert.ToString(sHTML);
        }


    
    }
}
