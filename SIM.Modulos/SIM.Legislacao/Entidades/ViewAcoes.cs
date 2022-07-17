using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Legislacao.Entidades
{
    public class ViewAcoes
    {
        public int Indice { get; set; }
        public string Acao { get; set; }
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public DateTime Data { get; set; }
        public string Link { get; set; }    
    }
}
