using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Legislacao.Negocios
{
    static class Link
    {
        internal static string Create(string tipo, string ano, int numero)
        {
            string rtipo = string.Empty;            

            switch(tipo.ToUpper())
            {
                case "LEI":
                    rtipo = "leis";
                    break;

                case "LEI COMPLEMENTAR":
                    rtipo = "leis_complementares";
                    break;

                case "DECRETO":
                    rtipo = "decretos";
                    break;
            }

            return string.Format(@"\{0}\{1}\{2}.pdf", rtipo, ano, numero);
        }
    }
}
