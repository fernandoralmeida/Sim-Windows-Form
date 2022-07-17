using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Legislacao.Entidades
{
    public class Legislacao
    {

        public int Indice { get; set; }

        public string Tipo { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public DateTime Data { get; set; }

        public DateTime Data2 { get; set; }

        public string Publicado { get; set; }

        public string Resumo { get; set; }

        public string Classificacao { get; set; }

        public string Link { get; set; }

        public string Situacao { get; set; }

        public string Origem { get; set; }

        public string Autor { get; set; }

        public DateTime Cadastro { get; set; }

        public DateTime Atualizado { get; set; }

        public bool Excluido { get; set; }

        public ListaViewAcoes ListaAcoes { get; set; }

        public string IndiceLink { get; set; }

    }
}
