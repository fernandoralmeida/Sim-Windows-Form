using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;

namespace Sim.Classes
{
    public class Autenticacao // Visivel a todos os projetos
    {

        private static string usuario;
        private static string nome;
        private static string email;
        private static int modulo;
        private static int acesso = -1; //Inicia como Negado
                
        public static void LogIN(string puser, string pnome, string pemail, int pacesso, int pmodulo, int poutrosmodulos)
        { 
            usuario = puser;
            nome = pnome;
            acesso = pacesso;
            modulo = pmodulo;
            email = pemail; 
        }

        public static void LogOUT()
        {
            usuario = string.Empty;
            email = string.Empty;
            modulo = 0; 
            acesso = -1;
            nome = string.Empty;
        }

        public static int GetAcesso()
        { 
            return acesso;
        }

        public static int GetModulo()
        {
            return modulo;
        }
        
        public static string GetNome()
        {
            return nome;
        }

        public static string GetUsuario()
        {
            return usuario;
        }

        public static string GetEmail()
        {
            return email;
        }

        public static string SetEmail(string valor)
        {
            email = valor;
            return valor;
        }

    }
}
