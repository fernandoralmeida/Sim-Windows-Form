using System;
using System.Collections.Generic;
using System.Data;

namespace Login.Negocios
{
    public interface IUsuarios
    {
        void AutenticarUsuario(string userid, string senha);

        Entidade.UserCollection UserByAcesso(int useracesso);

        void InsertNewUser(Entidade.Usuarios obj);

        Entidade.UserCollection SelectUser(string iduser);

        void DeleteUser(string adminid, string adminpw, string userid);

        void UpDateProfileUser(string userid, string senha, Entidade.Usuarios obj);

        void ResetSenha(string adminid, string adminpw, string userid);

        void BlockUser(string adminID, string adminPW, string userID);

        int TentativasLogIN();

        Entidade.UserCollection AllUser();
    }
}
