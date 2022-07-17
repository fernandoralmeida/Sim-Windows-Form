using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Desktop.LogicaNegocios
{
    public class Usuarios : IUsuarios
    {

        Sim.Data.simDataSetTableAdapters.UsuariosTableAdapter usersDT = new Sim.Data.simDataSetTableAdapters.UsuariosTableAdapter();
        Sim.Data.simDataSet usersDS = new Sim.Data.simDataSet();

        private int tentativas = 0;
        public bool VerificarUsuario(Entidade.Usuarios obj)
        {
            bool aceito = false;
            
            if (usersDT.FillUser(usersDS.Usuarios, obj.Usuario, obj.Senha).Equals(1))
            {
                obj.Usuario = usersDS.Usuarios[0].Matricula;
                obj.Nome = usersDS.Usuarios[0].Nome;
                obj.Email = usersDS.Usuarios[0].Email;
                obj.Acesso = usersDS.Usuarios[0].Acesso;
                obj.Modulo = usersDS.Usuarios[0].Modulo;
                obj.OutroModulos = usersDS.Usuarios[0].OutrosModulos;
                Classes.Autenticacao.LogIN(obj.Usuario, obj.Nome, obj.Email, obj.Acesso, obj.Modulo, obj.OutroModulos);
                aceito = true;
            }
            else
            {
                this.tentativas += 1;

                System.Windows.Forms.MessageBox.Show("Usuário/Senha inválido!", "SIM.Desktop.LogIN", 
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);

                if (this.tentativas.Equals(4))
                    System.Windows.Forms.Application.Exit();
            }

            return aceito;
        }

        private int nusuarios = 0;
        public System.Data.DataTable GetUsers(Entidade.Usuarios obj)
        {

            System.Data.DataTable DT = new System.Data.DataTable();

            DT = usersDT.GetUserAcesso(obj.Acesso); // pega todos os usuario com acesso menor que o usuario consultante
            nusuarios = DT.Rows.Count;

            return DT;    //throw new NotImplementedException();
        }

        public bool InsertNewUser(Entidade.Usuarios obj)
        {
            //verifica se a entidades estão com valores vazios
            if (obj.Nome.Equals(string.Empty) || obj.Usuario.Equals(string.Empty))
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Verifique se todos so campos estão preenchidos corretamente!", obj.Usuario), "SIM.LogIN");
                return false;
            }
            else
            {
                int userExist = (int)usersDT.ScalarQuery(obj.Usuario); //se usuario exite, retorna valor = 1.

                if (userExist.Equals(0)) 
                {
                    usersDT.InsertQuery(obj.Nome, obj.Senha, obj.Usuario, obj.Email, obj.Acesso, obj.Modulo, obj.OutroModulos);
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Usuário [{0}] já está cadastrado", obj.Usuario), "SIM.LogIN");
                    return false;
                }
            }
        }

        public bool DeleteUser(Entidade.Usuarios obj)
        {

            int userExist = (int)usersDT.ScalarQuery(obj.Usuario);

            if (userExist.Equals(1))
            {
                usersDT.DeleteUser(obj.Usuario);
                return true;
            }
            else
                return false; //throw new NotImplementedException();
        }
        
        public bool UpDateSenha(Entidade.Usuarios obj)
        {

            int userExist = (int)usersDT.ScalarQuery(obj.Usuario);

            if (userExist.Equals(1))
            {
                int result = usersDT.UpdateSenha(obj.NovaSenha, obj.Usuario, obj.Senha);
                if (result.Equals(1))
                {
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Senha antiga incorreta", "SIM.LogIN");
                    return false;
                }                
            }
            else
                return false; //throw new NotImplementedException();

        }

        public bool UpDateEmail(Entidade.Usuarios obj)
        {

            int userExist = (int)usersDT.ScalarQuery(obj.Usuario);

            if (userExist.Equals(1))
            {
                usersDT.UpdateEmail(obj.Email, obj.Usuario);
                return true;
            }
            else
                return false; //throw new NotImplementedException();

        }

        public bool UpDateProfileUser(Entidade.Usuarios obj)
        {
            int userExist = (int)usersDT.ScalarQuery(obj.Usuario);

            if (userExist.Equals(1))
            {
                usersDT.UpdateProfileUser(obj.Modulo, obj.Acesso, obj.OutroModulos, obj.Usuario);
                return true;
            }
            else
                return false; //throw new NotImplementedException();
        }

        public bool ResetSenha(Entidade.Usuarios obj)
        {
            int userExist = (int)usersDT.ScalarQuery(obj.Usuario);

            if (userExist.Equals(1))
            {
                usersDT.ResetSenha(obj.Senha, obj.Usuario);
                return true;
            }
            else
                return false; //throw new NotImplementedException();
        }

        public int TentativasLogIN()
        {
            return tentativas;
        }

        public int NumeroUsers()
        {
            return nusuarios;
        }

    }
}
