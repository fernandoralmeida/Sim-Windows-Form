using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;

namespace Sim.Legislacao.Negocios
{
    class PrintRel
    {

        public Entidades.ListaLegislacao Lista { get; set; }

        int nrow = 0;
        int paginaN = 0;
        public void DrawPage(object sender, PrintPageEventArgs e)
        {
            string papel = e.PageSettings.PaperSize.PaperName;
            int linha = 170;
            int linhaHeight = 0;
            int lineResumoMultiplicador = 0;
            int lineResumoWidth = 0;
            int lineResumoHeight = 0;            
            int margemEsq = 40;
            int margemSup = 30;
            int margemDir = 40;
            int margemInf = 40;
            int PageWidth = (e.PageBounds.Size.Width - (margemEsq + margemDir));
            int PageHeigth = (e.PageBounds.Size.Height - (margemSup + margemInf));
            Pen caneta = Pens.Black;
            Pen traco = Pens.Silver;

            float[] dashValues = { 1, 2, 1, 2 };
            Pen dashedpen = new Pen(Color.Black, 1);
            dashedpen.DashPattern = dashValues;

            Brush p1 = Brushes.Black;
            Brush p2 = Brushes.Blue;
            Brush p3 = Brushes.Red;
            Font FonteTitulo = new Font("Arial", 12, FontStyle.Bold);
            Font FonteSec = new Font("Arial", 11, FontStyle.Regular);
            Font FonteHead = new Font("Arial", 9, FontStyle.Regular);
            Font FonteColuna = new Font("Arial", 10);
            Font FonteRodape = new Font("Arial", 8);
            Font FonteNormal = new Font("Arial", 8.5F);
            Font FonteResumo = new Font("Arial", 7, FontStyle.Italic);
            Font FonteRelTipo = new Font("Arial", 10, FontStyle.Bold);

            string Titulo = @"PREFEITURA MUNICIPAL DE JAHU";
            string Promo = @"'Fundada em 15 de Agosto de 1853'";
            string Secretaria = @"SECRETARIA DE GOVERNO";
            string Departamento = @"GERÊNCIA DE RELAÇÕES INSTITUCIONAIS";

            e.Graphics.DrawString(Titulo, FonteTitulo, p1, margemEsq + PageWidth - e.Graphics.MeasureString(Titulo, FonteTitulo).Width , 20);
            e.Graphics.DrawString(Promo, FonteRodape, p1, margemEsq + PageWidth - e.Graphics.MeasureString(Promo, FonteRodape).Width, 40);
            
            //e.Graphics.DrawLine(traco, margemEsq, 70, PageWidth + margemDir, 70);

            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Center;
            formatter.Alignment = StringAlignment.Center;
            RectangleF rectangle = new RectangleF(margemEsq, 100, PageWidth, e.Graphics.MeasureString(Secretaria, FonteHead).Height);
            e.Graphics.DrawString(string.Format("{0}, {1}.", Secretaria, Departamento), FonteHead, p1, rectangle, formatter);

            e.Graphics.DrawString("RELAÇÃO DE LEIS E DECRETOS", FonteResumo, p1, margemEsq, 150);

            StringBuilder sb = new StringBuilder();

            while ((linha + margemInf) < (PageHeigth - margemInf) && nrow < Lista.Count)
            {               

                sb.AppendLine(string.Format("{0} {1}/{2} :: {3}", Lista[nrow].Tipo, Lista[nrow].Numero, Lista[nrow].Data.ToString("yyyy"), Lista[nrow].Situacao));
                sb.AppendLine(string.Format("AUTOR: {0}", Lista[nrow].Autor));                          
                sb.AppendLine(Lista[nrow].Resumo);

                lineResumoWidth = (int)e.Graphics.MeasureString(Lista[nrow].Resumo, FonteNormal).Width;
                

                if (lineResumoWidth > PageWidth)
                {

                    lineResumoHeight = (int)e.Graphics.MeasureString(Lista[nrow].Resumo, FonteNormal).Height;

                    if (lineResumoHeight > e.Graphics.MeasureString(Lista[nrow].Tipo, FonteNormal).Height)
                    {
                        lineResumoMultiplicador = lineResumoWidth / PageWidth;
                        lineResumoHeight = (int)e.Graphics.MeasureString(Lista[nrow].Resumo, FonteNormal).Height + (int)(e.Graphics.MeasureString(Lista[nrow].Tipo, FonteNormal).Height * lineResumoMultiplicador);
                    }
                    else
                    {
                        lineResumoMultiplicador = lineResumoWidth / PageWidth;
                        lineResumoHeight = ((int)e.Graphics.MeasureString(Lista[nrow].Resumo, FonteNormal).Height * (int)lineResumoMultiplicador);
                    }
                    
                    lineResumoWidth = 0;
                    lineResumoMultiplicador = 0;
                }
                

                foreach (Entidades.ViewAcoes va in Lista[nrow].ListaAcoes)
                {
                    sb.AppendLine(string.Format("({0} {1} {2}/{3})", va.Acao, va.Tipo, va.Numero, va.Data.ToString("yyyy")));
                }

                StringFormat texto = new StringFormat();
                texto.Alignment = StringAlignment.Near;
                RectangleF areaTexto = new RectangleF(margemEsq, linha, PageWidth, e.Graphics.MeasureString(sb.ToString(), FonteNormal).Height + lineResumoHeight);

                linhaHeight = (int)areaTexto.Height;

                if ((linha + 10 + linhaHeight) < PageHeigth)
                { 
                    e.Graphics.DrawLine(dashedpen, margemEsq, linha - 10, PageWidth + margemDir, linha - 10);
                    e.Graphics.DrawString(sb.ToString(), FonteNormal, p1, areaTexto, texto);
                    nrow++;
                }

                linha += linhaHeight + 20;
                lineResumoHeight = 0;
                sb.Clear();
            }

            paginaN++;
            string paginanumero = "Pag. " + paginaN.ToString();
            e.Graphics.DrawLine(dashedpen, margemEsq, PageHeigth - 5, PageWidth + margemDir, PageHeigth - 5);
            e.Graphics.DrawString(DateTime.Now.ToString() + " " + Login.Autenticado.UserName + " " + System.Windows.Forms.Application.ProductName + ".Build." + System.Windows.Forms.Application.ProductVersion, FonteRodape, Brushes.Black, margemEsq, PageHeigth);
            e.Graphics.DrawString(paginanumero, FonteRodape, Brushes.Black, margemEsq + PageWidth - e.Graphics.MeasureString(paginanumero, FonteRodape).Width, PageHeigth);

            if (nrow < Lista.Count)
                e.HasMorePages = true;
            else
            {
                e.HasMorePages = false;
                nrow = 0;
                paginaN = 0;
            }
            
        }
    }
}
