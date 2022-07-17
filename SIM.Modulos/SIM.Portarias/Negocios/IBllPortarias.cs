using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sim.Portarias.Negocios
{
    public interface IBllPortarias
    {
        DataTable MostrarTodosRegistros();
        DataTable Consultar(Entidade.Portarias obj);

        Entidade.ListViewPortarias ConsultaDetalhada(Entidade.Portarias obj);

        DataTable ConsultaNumero(int valor, DateTime data);

        DataTable ConsultaID(int id);

        bool Insert(Entidade.Portarias obj);
        bool Update(Entidade.Portarias obj);
        bool Delete(Entidade.Portarias obj);
        bool InsertNewServidor(Entidade.Portarias obj);

        List<object> Servidores();

        
    }
}
