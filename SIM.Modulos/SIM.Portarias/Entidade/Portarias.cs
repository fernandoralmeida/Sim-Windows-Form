using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Portarias.Entidade
{
    public class Portarias
    {
        public int Indice { get; set; }
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public string Resumo { get; set; }
        public string Servidor { get; set; }
        public string Pdf { get; set; }
        public string Publicada { get; set; }
        public DateTime Cadastrado { get; set; }
        public DateTime Atualizado { get; set; }
        public bool Excluido { get; set; }

        public int NumeroI { get; set; }
        public int NumeroF { get; set; }

        public string AnoI { get; set; }
        public string AnoF { get; set; }
    }
}
