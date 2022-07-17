using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Classes
{
    public class Acesso
    {
        public const int Negado = -1;
        public const int Comum = 0;
        public const int Intermediario = 1;
        public const int Administrador = 2;
        public const int Master = 3;

        public static string Nivel(int valor) 
        {
            string vAcesso = null;

            if (valor.Equals(Acesso.Comum))
                vAcesso = "Comum";

            if (valor == Acesso.Intermediario)
                vAcesso = "Intermediário";

            if (valor == Acesso.Administrador)
                vAcesso = "Administrador";

            if (valor == Acesso.Master)
                vAcesso = "Master";

            return vAcesso;
        }

    }
}
