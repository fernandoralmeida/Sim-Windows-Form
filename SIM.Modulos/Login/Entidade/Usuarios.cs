using System;

namespace Login.Entidade
{
    public class Usuarios
    {

        public int Indice { get; set; }
        public string Identificador { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Conta { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Atualizado { get; set; }
        public bool Bloqueado { get; set; }
                
    }
}
