using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Desktop.Entidade
{
    public class Usuarios
    {        
        public int Indice { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public int Acesso { get; set; }
        public int Modulo { get; set; }
        public int OutroModulos { get; set; }

        public string NovaSenha { get; set; }

        public Usuarios() { }

        public Usuarios(int id) { this.Indice = id; }

        public Usuarios(string nome, string senha, string usuario, string email, int acesso, int modulo, int outrosmodulos)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Usuario = usuario;
            this.Email = email;
            this.Acesso = acesso;
            this.Modulo = modulo;
            this.OutroModulos = outrosmodulos;
        }

        public Usuarios(int indice, string nome, string senha, string usuario, string email, int acesso, int modulo, int outrosmodulos)
            : this(nome, senha, usuario, email, acesso, modulo, outrosmodulos)
        {
            this.Indice = indice;
        }

        /*
        public Usuarios(string novasenha, string nome, string senha, string usuario, string email, int acesso, int modulo, int outrosmodulos)
            : this(nome, senha, usuario, email, acesso, modulo, outrosmodulos)
        {
            this.NovaSenha = novasenha;
        }
         * */
    }
}
