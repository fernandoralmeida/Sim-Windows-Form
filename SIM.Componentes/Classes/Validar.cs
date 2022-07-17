using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Componentes.Classes
{
    public class Validar
    {
        public string vString(string valor)
        {
            if (valor.Equals(string.Empty))
            {
                throw new Exception("Cadeia de caracteres está em um formato incorreto!");
            }
            else
                return valor;
        }

        public DateTime vDate(string valor)
        {
            try
            {
                return Convert.ToDateTime(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int vNumero(string valor)
        {
            try
            {
                return Convert.ToInt32(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
