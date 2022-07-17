using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sim.Portarias.RegraN
{
    internal class Servidores : IServidores
    {

        //int nrows = 0;

        Sim.Data.MPO.Servidores MPO = new Data.MPO.Servidores();
        DataGrid mDataGrid = new DataGrid();

        public DataTable GetServidorName()
        {
            return MPO.GetServidores();
        }

        public DataTable GetData4Param(Entidade.Servidores obj)
        {
            MPO.Portaria = obj.Portaria;
            MPO.Data = obj.Data;
            
            mDataGrid.Servidores(MPO.GetDataByParam());

            return mDataGrid.DTable;
        }
        
        public bool UpDateQuery(Entidade.Servidores obj)
        {
            MPO.Portaria = obj.Portaria;
            MPO.Data = obj.Data;
            MPO.Servidor = obj.Servidor;
            MPO.Indice = obj.Indice;

            return MPO.UpdateQuery();
        }

        public bool InsertQuery(Entidade.Servidores obj)
        {
            MPO.Portaria = obj.Portaria;
            MPO.Data = obj.Data;
            MPO.Servidor = obj.Servidor;

            return MPO.InsertQuery();
            //throw new NotImplementedException();
        }

        public bool DeleteQuery(Entidade.Servidores obj)
        {
            MPO.Indice = obj.Indice;
            return MPO.DeleteQuery();
        }
    }
}
