using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Sim.Portarias.Negocios
{
    internal class DataGrid
    {
        
        IBllPortarias mpo = Factories.NegociosPortarias();

        DataSet TiposXML = new DataSet();
        Sim.Classes.XmlFile XmlCtrl = new Sim.Classes.XmlFile();

        internal DataTable DTable;
        DataTable TabelaPortarias()
        {
            DTable = new DataTable();
            DataColumn dc;

            dc = new DataColumn();
            dc.ColumnName = "PDF";
            dc.DataType = typeof(string);
            DTable.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Editar";
            dc.DataType = typeof(string);
            DTable.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Nº";
            dc.DataType = typeof(Int32);
            DTable.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Data";
            dc.DataType = typeof(DateTime);
            DTable.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Tipo";
            dc.DataType = typeof(string);
            DTable.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Resumo";
            dc.DataType = typeof(string);
            DTable.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Servidor";
            dc.DataType = typeof(string);
            DTable.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "URL";
            dc.DataType = typeof(string);
            DTable.Columns.Add(dc);

            return DTable;
        }

        int tipo = 0;
        internal void Portarias(DataTable dt, System.ComponentModel.BackgroundWorker bgw)
        {
            try
            {

                TiposXML = XmlCtrl.xmlDS(Classes.XmlFile.XmlMPO.Tipos, Sim.Classes.XmlFile.xTabela.xMPO);

                int nrow = dt.Rows.Count;
                int i = 0;

                TabelaPortarias();
                DataRow dr;

                foreach (DataRow row in dt.Rows)
                {
                    dr = DTable.NewRow();
                    dr["PDF"] = "PDF";
                    dr["Editar"] = "Editar";
                    dr["Nº"] = row["Numero"];
                    dr["Data"] = Convert.ToDateTime(row["Data"]).ToShortDateString();

                    tipo = Convert.ToInt32(row["Tipo"]);

                    //dr["Tipo"] = string.Format("{0}:{1}", row["Tipo"], TiposXML.Tables[0].Rows[tipo][0]);

                    dr["Tipo"] = string.Format("{0}", TiposXML.Tables[0].Rows[tipo][0]);

                    dr["Servidor"] = row["Servidor"];
                    dr["Resumo"] = row["Resumo"];
                    dr["URL"] = row["Pdf"];
                    DTable.Rows.Add(dr);                  

                    // reporta o progresso;
                    int progresso = ((i + 1) * 100) / nrow;
                    bgw.ReportProgress(progresso);
                    i++;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {  }
        }

    }
}
