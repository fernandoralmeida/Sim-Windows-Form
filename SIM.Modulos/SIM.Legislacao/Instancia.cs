using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Legislacao
{
    public class Instancia
    {
        public static Negocios.IRegras RegrasNegocios()
        {
            return new Negocios.Regras();
        }

        public static Entidades.Acoes Acoes()
        {
            return new Entidades.Acoes();
        }
        
        public static Entidades.ViewAcoes ViewAcoes()
        {
            return new Entidades.ViewAcoes();
        }

        public static Entidades.ListaAcoes ListaAcoes()
        {
            return new Entidades.ListaAcoes();
        }

        public static Entidades.ListaViewAcoes ListaViewAcoes()
        {
            return new Entidades.ListaViewAcoes();
        }

        public static Entidades.Legislacao Legislacao()
        {
            return new Entidades.Legislacao();
        }

        public static Entidades.ListaLegislacao ListaLegislacao()
        {
            return new Entidades.ListaLegislacao();
        }

        public static Negocios.IRelatorios Relatorios()
        {
            return new Negocios.Relatorios();
        }
    }
}
