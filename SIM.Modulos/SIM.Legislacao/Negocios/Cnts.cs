using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Legislacao.RegraN
{
    public class Constantes
    {
        
        // usado pra controle de tabela no DataSet
        public struct Tabela
        {
            internal const int Leg = 0;
            internal const int Acs = 1;
        }

        // usado pra informar a ação em valor de tabela
        public struct Acao
        {
            internal const string altera = "1";
            internal const string revoga = "2";
            internal const string regulamenta = "3";
        }
        
        // usado pra informar a situação em valor de tabela
        public struct Situacao
        {
            internal const string emvigor = "1";
            internal const string alterada = "2";
            internal const string revogada = "3";
        }

        // usado pra informar a situação/ação em modo visualização
        public struct Escreva
        {
            internal const string emvigor = "Em Vigor";
            internal const string alterada = "Alterado(a)";
            internal const string revogada = "Revogado(a)";

            internal const string altera = "Altera o(a)";
            internal const string revoga = "Revoga o(a)";
            internal const string regulamenta = "Regulamenta o(a)";

            internal const string alteradapor = "Alterado(a) pelo(a)";
            internal const string revogadapor = "Revogada(a) pelo(a)";
            internal const string regulamentada = "Regulamentado(a) pelo(a)";
        }

        // usado pelo construtor de link
        public struct Tipo
        {
            internal const string leis = "leis";
            internal const string leicomps = "leis_complementares";
            internal const string decretos = "decretos";

            internal const string Lei = "Lei";
            internal const string LeiComp = "Lei Complementar";
            internal const string Decreto = "Decreto";
        }

    }
}
