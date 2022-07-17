using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Login.Negocios
{
    class Usuarios : IUsuarios
    {
        
        private int tentativas = 0;

        public void AutenticarUsuario(string userid, string senha)
        {

            Sim.DataAccess.IDataAccess loginDB = Sim.DataAccess.Instancia.LoginAccess();

            try
            {

                loginDB.ReiniciarParametros();

                loginDB.AdicionarParametros("@ID", userid);
                loginDB.AdicionarParametros("@Senha", senha);

                DataTable dt = loginDB.Reader(Properties.Resources.SelectUserLogin);
                                
                if (!dt.Rows.Count.Equals(1))
                {
                    this.tentativas += 1;

                    System.Windows.Forms.MessageBox.Show("Usuário/Senha inválido!", "SIM.Desktop.LogIN",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);

                    if (this.tentativas.Equals(4))
                        System.Windows.Forms.Application.Exit();

                    return;
                }

                // valida usuario
                foreach (DataRow dr in dt.Rows)
                {
                    Autenticado.UserId = dr["Identificador"].ToString();
                    Autenticado.UserPassword = dr["Senha"].ToString();
                    Autenticado.UserName = dr["Nome"].ToString();
                    Autenticado.UserEmail = dr["Email"].ToString();

                    object acesso;

                    switch ((int)dr["Conta"])
                    {
                        case (int)Conta.Master:
                            acesso = Conta.Master;
                            break;
                        case (int)Conta.Administrador:
                            acesso = Conta.Administrador;
                            break;
                        case (int)Conta.Basico:
                            acesso = Conta.Basico;
                            break;
                        default:
                            acesso = Conta.Negado;
                            break;
                    }

                    Autenticado.Conta = (Conta)acesso;

                    Autenticado.Valido = true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        /// <summary>
        /// (@Identificador, @Senha, @Nome, @Email, @Conta, @Cadastro, @Atualizado, @Bloqueado)
        /// </summary>
        /// <param name="obj"></param>
        public void InsertNewUser(Entidade.Usuarios obj)
        {
            Sim.DataAccess.IDataAccess loginDB = Sim.DataAccess.Instancia.LoginAccess();

            loginDB.ReiniciarParametros();

            loginDB.AdicionarParametros("@Identificador", obj.Identificador);
            loginDB.AdicionarParametros("@Senha", obj.Senha);
            loginDB.AdicionarParametros("@Nome", obj.Nome);
            loginDB.AdicionarParametros("@Email", obj.Email);
            loginDB.AdicionarParametros("@Conta", obj.Conta);
            loginDB.AdicionarParametros("@Cadastro", obj.Cadastro.ToShortDateString());
            loginDB.AdicionarParametros("@Atualizado", obj.Atualizado.ToShortDateString());
            loginDB.AdicionarParametros("@Bloqueado", obj.Bloqueado);

            if (loginDB.Writing(Properties.Resources.InsertUser).Equals(true))
            {
                System.Windows.Forms.MessageBox.Show("Novo usuario incluído com sucesso", "SIM.Alerta",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);

            }
            else
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Usuário {0} ja cadastro!", obj.Identificador), "SIM.Alerta",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }

        public int TentativasLogIN()
        {
            return tentativas;
        }

        public Entidade.UserCollection UserByAcesso(int useracesso)
        {

            Sim.DataAccess.IDataAccess loginDB = Sim.DataAccess.Instancia.LoginAccess();

            try
            {

                Entidade.UserCollection userCollection = new Entidade.UserCollection();

                loginDB.AdicionarParametros("@Conta", useracesso);

                System.Data.DataTable dt = loginDB.Reader(Login.Properties.Resources.SelectUserByAcesso);

                foreach (System.Data.DataRow dr in dt.Rows)
                {
                    Entidade.Usuarios usuarios = new Entidade.Usuarios();

                    usuarios.Identificador = dr["Identificador"].ToString();
                    usuarios.Nome = dr["Nome"].ToString();
                    usuarios.Email = dr["Email"].ToString();
                    usuarios.Conta = (int)dr["Conta"];
                    usuarios.Cadastro = (DateTime)dr["Cadastro"];
                    usuarios.Atualizado = (DateTime)dr["Atualizado"];
                    usuarios.Bloqueado = (bool)dr["Bloqueado"];

                    userCollection.Add(usuarios);
                }

                return userCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidade.UserCollection AllUser()
        {

            Sim.DataAccess.IDataAccess loginDB = Sim.DataAccess.Instancia.LoginAccess();

            Entidade.UserCollection userCollection = new Entidade.UserCollection();

            System.Data.DataTable dt = loginDB.Reader(Login.Properties.Resources.SelectAllUsers);

            foreach (System.Data.DataRow dr in dt.Rows)
            {
                Entidade.Usuarios usuarios = new Entidade.Usuarios();

                usuarios.Identificador = dr["Identificador"].ToString();
                usuarios.Nome = dr["Nome"].ToString();
                usuarios.Email = dr["Email"].ToString();
                usuarios.Conta = (int)dr["Conta"];
                usuarios.Cadastro = (DateTime)dr["Cadastro"];
                usuarios.Atualizado = (DateTime)dr["Atualizado"];
                usuarios.Bloqueado = (bool)dr["Bloqueado"];

                userCollection.Add(usuarios);
            }

            return userCollection;
        }

        public void DeleteUser(string adminid, string adminpw, string userid)
        {

            Sim.DataAccess.IDataAccess loginDB = Sim.DataAccess.Instancia.LoginAccess();

            try
            {

                loginDB.ReiniciarParametros();

                loginDB.AdicionarParametros("@ID", adminid);
                loginDB.AdicionarParametros("@Senha", adminpw);

                if (loginDB.Reader(Properties.Resources.SelectUserLogin).Rows.Count.Equals(1))
                {

                    loginDB.ReiniciarParametros();

                    loginDB.AdicionarParametros("@ID", userid);

                    loginDB.Writing(Properties.Resources.DeleteUser);

                    System.Windows.Forms.MessageBox.Show(string.Format("Usuário [{0}] excluido!", userid));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpDateProfileUser(string userid, string senha, Entidade.Usuarios obj)
        {

            Sim.DataAccess.IDataAccess loginDB = Sim.DataAccess.Instancia.LoginAccess();

            string updateProfile = "UPDATE Account SET Senha = @Senha, Nome = @Nome, Email = @Email, Atualizado = @Atualizado WHERE (Identificador = @ID)";

            try
            {

                loginDB.ReiniciarParametros();

                loginDB.AdicionarParametros("@ID", userid);
                loginDB.AdicionarParametros("@Senha", senha);

                if (loginDB.Reader(Properties.Resources.SelectUserLogin).Rows.Count.Equals(1))
                {
                    loginDB.ReiniciarParametros();

                    loginDB.AdicionarParametros("@Senha", obj.Senha);
                    loginDB.AdicionarParametros("@Nome", obj.Nome);                    
                    loginDB.AdicionarParametros("@Email", obj.Email);                    
                    loginDB.AdicionarParametros("@Atualizado", obj.Atualizado.ToShortDateString());
                    loginDB.AdicionarParametros("@ID", obj.Identificador);

                    loginDB.Writing(updateProfile);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ResetSenha(string adminid, string adminpw, string userid)
        {

            Sim.DataAccess.IDataAccess loginDB = Sim.DataAccess.Instancia.LoginAccess();

            string resetPW = "UPDATE Account SET Senha = @Senha WHERE (Identificador = @ID)";

            try
            {

                loginDB.ReiniciarParametros();

                loginDB.AdicionarParametros("@ID", adminid);
                loginDB.AdicionarParametros("@Senha", adminpw);

                if (loginDB.Reader(Properties.Resources.SelectUserLogin).Rows.Count.Equals(1))
                {

                    loginDB.ReiniciarParametros();
                    
                    loginDB.AdicionarParametros("@Senha", userid);
                    loginDB.AdicionarParametros("@ID", userid);

                    loginDB.Writing(resetPW);

                    System.Windows.Forms.MessageBox.Show(string.Format("Senha [{0}] reiniciada!", userid));
                }
                else
                    System.Windows.Forms.MessageBox.Show("Não foi possivel reiniciar a senha!");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void BlockUser(string adminID, string adminPW, string userID)
        {

            Sim.DataAccess.IDataAccess loginDB = Sim.DataAccess.Instancia.LoginAccess();

            string blockUser = "UPDATE Account SET Bloqueado = @Bloqueado WHERE (Identificador = @ID)";

            try
            {

                loginDB.ReiniciarParametros();

                loginDB.AdicionarParametros("@ID", adminID);
                loginDB.AdicionarParametros("@Senha", adminPW);

                if (loginDB.Reader(Properties.Resources.SelectUserLogin).Rows.Count.Equals(1))
                {

                    loginDB.ReiniciarParametros();


                    loginDB.AdicionarParametros("@Bloqueado", true);
                    loginDB.AdicionarParametros("@ID", userID);

                    if (loginDB.Writing(blockUser).Equals(true))
                        System.Windows.Forms.MessageBox.Show(string.Format("Usuário [{0}] bloqueado!", userID));
                }
                else
                    System.Windows.Forms.MessageBox.Show("Não foi possível bloquear o usuário!");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidade.UserCollection SelectUser(string iduser)
        {

            Sim.DataAccess.IDataAccess loginDB = Sim.DataAccess.Instancia.LoginAccess();

            try
            {

                string selecUser = "SELECT Indice, Identificador, Senha, Nome, Email, Conta, Cadastro, Atualizado, Bloqueado FROM Account WHERE (Identificador = @ID)";
                
                Entidade.UserCollection userCollection = new Entidade.UserCollection();

                loginDB.AdicionarParametros("@ID", iduser);

                System.Data.DataTable dt = loginDB.Reader(selecUser);

                foreach (System.Data.DataRow dr in dt.Rows)
                {
                    Entidade.Usuarios usuarios = new Entidade.Usuarios();

                    usuarios.Identificador = dr["Identificador"].ToString();
                    usuarios.Nome = dr["Nome"].ToString();
                    usuarios.Email = dr["Email"].ToString();
                    usuarios.Conta = (int)dr["Conta"];
                    usuarios.Cadastro = (DateTime)dr["Cadastro"];
                    usuarios.Atualizado = (DateTime)dr["Atualizado"];
                    usuarios.Bloqueado = (bool)dr["Bloqueado"];

                    userCollection.Add(usuarios);
                }

                return userCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
