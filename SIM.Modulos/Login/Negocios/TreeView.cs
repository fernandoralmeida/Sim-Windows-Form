using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Login.Negocios
{
    public partial class TreeView : System.Windows.Forms.TreeView
    {

        public TreeView()
        {
            InitializeComponent();
            this.DataShow();
        }

        public TreeView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void DataShow()
        {
            var UserDataAcess = Factories.Users();
            var EntUser = Factories.EntUsers();

            //this.Nodes.AddRange(

            this.Nodes.Clear();
            try
            {
                //TreeNode pai = treeView1.Nodes.Add("Usuários");
                //TreeNode filho;

                Entidade.UserCollection uc = new Entidade.UserCollection();

                uc = UserDataAcess.UserByAcesso((int)Autenticado.AcessoSistema);

                foreach (Entidade.Usuarios user in uc)
                {
                    System.Windows.Forms.TreeNode pai = this.Nodes.Add("ID: " + user.Identificador.ToUpper());
                    //TreeNode filho;
                    //pai.Nodes.Add("Id: " + user.Usuario);
                    pai.ForeColor = System.Drawing.Color.Navy;
                    pai.Nodes.Add("Nome: " + user.Nome);
                    pai.Nodes.Add("Email: " + user.Email);
                    pai.Nodes.Add("Cadastro: " + user.Cadastro);
                    pai.Nodes.Add("Atualizado: " + user.Atualizado);
                    pai.Nodes.Add("Acesso: " + user.AcessoSistema);
                    //pai.Nodes.Add("Estado: " + user.Bloqueado);

                    if (user.Bloqueado.Equals(false))
                        pai.Nodes.Add("Estado: Ativo");
                    else
                    {
                        pai.Nodes.Add("Estado: Bloqueado");
                        pai.ForeColor = System.Drawing.Color.DarkRed;
                    }

                }

                this.ExpandAll();
            }
            catch { }
        }

        public override void Refresh()
        {
            this.DataShow();
            base.Refresh();
        }

    }
}
