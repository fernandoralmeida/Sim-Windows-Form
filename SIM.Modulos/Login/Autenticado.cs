using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login
{
    /// <summary>
    /// classe estatica para quardar as informações dos usuarios autenticados
    /// para acessar o sistemas e seus modulos
    /// </summary>
    public static class Autenticado
    {
        public static bool Valido = false;
        public static string UserId { get; set; }
        public static string UserPassword { get; set; }
        public static string UserName { get; set; }
        public static string UserEmail { get; set; }
        public static ListaAcessoModulos AcessoModulos;
        public static Conta Conta { get; set; }
    }

    public class ListaAcessoModulos : List<AcessoModulo> { }
        
    public class AcessoModulo
    {
        public static string MCC { get; set; }
        public static string MPO { get; set; }
        public static string MLG { get; set; }
    }

    public static class Reiniciar
    {
        public static void Autenticacao()
        {
            Autenticado.Valido = false;
            Autenticado.UserId = string.Empty;
            Autenticado.UserPassword = string.Empty;
            Autenticado.UserName = string.Empty;
            Autenticado.UserEmail = string.Empty;
            AcessoModulo.MCC = "0";
            AcessoModulo.MPO = "0";
            AcessoModulo.MLG = "0";
            Autenticado.Conta = Conta.Negado;
        }
    }

    public enum Conta
    {
        Negado,
        Basico,
        Administrador,
        Master
    }
}
