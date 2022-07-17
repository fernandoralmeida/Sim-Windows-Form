using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Legislacao.RegraN
{
    public class Factories
    {
        public static ILegislacao Legislacao()
        {
            //retorna uma instancia Legislacao
            return new Legislacao();
        }

        public static ELegislacao ENTLegislacao()
        {
            //retorna instancia da entidade legislacao
            return new ELegislacao();
        }

        public static IAcaoes AcoesED()
        {
            //retorna uma instancia açõesED
            return new Acoes();
        }

        public static AcoesED ENTAcaoED()
        {
            return new AcoesED();
        }

        public static WebPage PageHTML()
        {
            return new WebPage();
        }
       // public Factories() { }        
    }
}
