using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Legislacao.Entidades
{
    public class Acoes
    {
        public int Indice { get; set; }
        public string TipoOrigem { get; set; }
        public int NumeroOrigem { get; set; }
        public string ComplementoOrigem { get; set; }
        public DateTime DataOrigem { get; set; }
        public string Acao { get; set; }
        public string TipoAlvo { get; set; }
        public int NumeroAlvo { get; set; }
        public string ComplementoAlvo { get; set; }
        public DateTime DataAlvo { get; set; }
        public DateTime Incluido { get; set; }
    }
}
