using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Legislacao.Negocios
{

    public enum AcoesExercidas { Altera = 1, Revoga = 2, Regulamenta = 3 }

    public enum AcoesRecebidas { Alterada = 1, Revodado = 2, Regulamentado = 3 }

    class TipoAcoes
    {
        public string Exercidas(int valor)
        {
            string retornar = string.Empty;

            switch (valor)
            {
                case (int)AcoesExercidas.Altera:
                    retornar = "Altera";
                    break;
                case (int)AcoesExercidas.Revoga:
                    retornar = "Revoga";
                    break;
                case (int)AcoesExercidas.Regulamenta:
                    retornar = "Regulamenta";
                    break;
            }
            return string.Format("{0}", retornar);
        }

        public string Recebidas(int valor)
        {
            string retornar = string.Empty;

            switch (valor)
            {
                case (int)AcoesExercidas.Altera:
                    retornar = "Alterado por";
                    break;
                case (int)AcoesExercidas.Revoga:
                    retornar = "Revogado por";
                    break;
                case (int)AcoesExercidas.Regulamenta:
                    retornar = "Regulamentado por";
                    break;
            }
            return string.Format("{0}", retornar);
        }
    }
    
}
