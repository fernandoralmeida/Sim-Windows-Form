using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Legislacao.Negocios
{
    public enum TipoSituacao { EmVigor = 1, Alterada = 2, Revogada = 3 }

    class Situacao
    {
        public string Autal(int valor)
        {
            string retornar = string.Empty;

            switch (valor)
            {
                case (int)TipoSituacao.EmVigor:
                    retornar = "EM VIGOR";
                    break;
                case (int)TipoSituacao.Alterada:
                    retornar = "ALTERADO";
                    break;
                case (int)TipoSituacao.Revogada:
                    retornar = "REVOGADO";
                    break;
            }
            return retornar;
        }
    }

}
