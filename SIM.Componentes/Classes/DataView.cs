using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Classes
{
    public class DataView
    {

        public DataView() { }

        public void DataGrid(System.Windows.Forms.DataGridView dgview, System.Data.DataSet dset, string webpath)
        {
            StringBuilder xDoc = new StringBuilder(string.Empty);

            dgview.Rows.Clear();

            int rows = dset.Tables[1].Rows.Count;

            for (int i = 0; i < rows; i++)
            {

                string tipo = dset.Tables[1].Rows[i][1].ToString();
                string numero = dset.Tables[1].Rows[i][2].ToString();
                string complemento = dset.Tables[1].Rows[i][3].ToString();
                string data = dset.Tables[1].Rows[i][4].ToString();
                string publicacao = dset.Tables[1].Rows[i][5].ToString();
                string descricao = dset.Tables[1].Rows[i][6].ToString();
                string classificacao = dset.Tables[1].Rows[i][7].ToString();
                string link = dset.Tables[1].Rows[i][8].ToString();
                string situacao = dset.Tables[1].Rows[i][9].ToString();
                string acao = dset.Tables[1].Rows[i][10].ToString();
                string origem = dset.Tables[1].Rows[i][11].ToString();
                string autor = dset.Tables[1].Rows[i][12].ToString();

                DateTime DT = Convert.ToDateTime(data);
                string ano = DT.ToShortDateString();

                ano = ano.Remove(0, 6);

                switch (situacao)
                {
                    case "1":
                        situacao = "Em vigor";
                        break;
                    case "2":
                        situacao = "Alterada";
                        break;
                    case "3":
                        situacao = "Revogada";
                        break;
                    default:
                        break;
                }

                xDoc.Append(string.Format(@"{0} {1}/{2}", tipo, numero, ano));
                xDoc.Append(Environment.NewLine);
                xDoc.Append(Environment.NewLine);
                xDoc.Append(string.Format(@"Autor: {0}", autor));
                xDoc.Append(Environment.NewLine);
                xDoc.Append(string.Format(@"Situação: {0}", situacao));
                xDoc.Append(Environment.NewLine);
                xDoc.Append(Environment.NewLine);
                xDoc.Append(string.Format(@"{0}", descricao));

                string nRow = xDoc.ToString();

                xDoc.Clear();

                dgview.Rows.Add("", nRow);

            }

        }
    }
}
