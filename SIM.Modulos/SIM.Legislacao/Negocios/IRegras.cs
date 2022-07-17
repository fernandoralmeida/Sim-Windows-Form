using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Sim.Legislacao.Entidades;

namespace Sim.Legislacao.Negocios
{
    public interface IRegras
    {
        ListaLegislacao Consultar(TipoConsulta Tipo, Entidades.Legislacao obj, System.ComponentModel.BackgroundWorker bgwork);

        bool Insert(Entidades.Legislacao obj, ListaAcoes lista);

        bool Update(Entidades.Legislacao obj);

        bool Delete(Entidades.Legislacao obj);

        int ContadorLeis();
        int ContadorDecretos();
        int ContadorLeisComplementares();
        int ContadorRegistros();
        
        List<string> DocValidos(string tipo, int numero, string complemento);

        ListaLegislacao ListaParaEdicao(Entidades.Legislacao obj);

        ListaViewAcoes InsertAcao(Acoes obj);

        bool DelAcao(Acoes obj);
    }
}
