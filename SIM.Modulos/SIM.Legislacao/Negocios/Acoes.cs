using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sim.Legislacao.RegraN
{
    //classe ações entre documentos // implementa interface
    public class Acoes : IAcaoes
    {
        
        public DataSet GetAcoes()
        {
            throw new NotImplementedException();
        }

        public DataTable AcoesOrigem(AcoesED obj)
        {
            throw new NotImplementedException();
        }

        public DataTable AcoesAlvo(AcoesED obj)
        {
            throw new NotImplementedException();
        }

        public bool GetAlvo(AcoesED obj)
        {
            throw new NotImplementedException();
        }

        public bool IsertAcoesED(AcoesED obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAcoesED(AcoesED obj)
        {
            throw new NotImplementedException();
        }

        public string Origem(string valor)
        {
            throw new NotImplementedException();
        }

        public string Alvo(string valor)
        {
            throw new NotImplementedException();
        }
    }
}
