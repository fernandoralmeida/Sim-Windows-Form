using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sim.Legislacao.RegraN
{

    // Metodos // Propriedades // Indexadores // Eventos

    public interface ILegislacao // Interface Legislação
    {
        DataTable Consulta(Legislacao obj);

        DataTable Edicao(Legislacao obj);

        string LinkURL(Legislacao obj);

        bool InsertData(Legislacao obj);
        void UpDateData(Legislacao obj);
        void DeleteData(Legislacao obj);
        void UpDateSituacao(Legislacao obj);

        int Registros();

        string SituacaoToString(string valor);

        string AtualizaSituacao(string valor);

        string TipoURL(string valor);

        string Ano(string data);

        DataTable AllData();

    }
}
