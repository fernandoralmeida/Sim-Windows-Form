using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sim.Legislacao.RegraN
{
    // Interface AçõesED //// Metodos // Propriedades // Indexadores // Eventos
    public interface IAcaoes 
    {
        DataSet GetAcoes();

        DataTable AcoesOrigem(AcoesED obj);

        DataTable AcoesAlvo(AcoesED obj);

        bool GetAlvo(AcoesED obj);
        
        bool IsertAcoesED(AcoesED obj);

        bool DeleteAcoesED(AcoesED obj);

        string Origem(string valor);

        string Alvo(string valor);
    }
}
