using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Portarias.Entidade
{
    public class ViewPortarias
    {
        public int Indice { get; set; }
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public string Resumo { get; set; }
        public ListViewServidores Servidores { get; set; }
        public string Pdf { get; set; }
        public string Publicada { get; set; }
        public DateTime Cadastrado { get; set; }
        public DateTime Atualizado { get; set; }
        public bool Excluido { get; set; }
        public string IndiceLink { get; set; }
    }
}
