using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Desktop.LogicaNegocios
{
    public interface IUsuarios // Metodos // Propriedades // Indexadores // Eventos
    {
        
        bool VerificarUsuario(Entidade.Usuarios obj);        

        System.Data.DataTable GetUsers(Entidade.Usuarios obj);

        bool InsertNewUser(Entidade.Usuarios obj);
        
        bool DeleteUser(Entidade.Usuarios obj);

        bool UpDateSenha(Entidade.Usuarios obj);

        bool UpDateEmail(Entidade.Usuarios obj);

        bool UpDateProfileUser(Entidade.Usuarios obj);

        bool ResetSenha(Entidade.Usuarios obj);

        int TentativasLogIN();

        int NumeroUsers();

    }
}
