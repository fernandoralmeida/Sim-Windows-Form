using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login.Visao
{
    /// <summary>
    /// Interaction logic for FlexDataGrid.xaml
    /// </summary>
    public partial class FlexDataGrid : UserControl
    {
        public FlexDataGrid()
        {
            InitializeComponent();
            //Sim.Componentes.Classes.ColorTheme.GetTheme();
            SolidColorBrush mbrush = new SolidColorBrush(Color.FromArgb(255, Sim.Gui.Themes.Colors.ControlHighLight.R, Sim.Gui.Themes.Colors.ControlHighLight.G, Sim.Gui.Themes.Colors.ControlHighLight.B));
            flexgrid.BorderBrush = mbrush;
        }

        public void AppTheme()
        {
            Sim.Gui.Wpf.ThemeManager.ApplyTheme(this, "Resources");
        }

        public void ListarUsuarios()
        {
            var mdata = new Negocios.Usuarios();
            flexgrid.AutoGenerateColumns = false;
            flexgrid.ItemsSource = mdata.UserByAcesso((int)Login.Autenticado.Conta);
        }
        
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            var obj = Negocios.Factories.EntUsers();

            obj.Identificador = e.Uri.ToString();

            FmNewUser FM = new FmNewUser(AcaoNaTela.Alterar, obj);
            FM.Text = "SIM.Desktop.Editar Usuário";
            FM.ShowDialog();
        }

        private void Hyperlink_RequestNavigate_1(object sender, RequestNavigateEventArgs e)
        {
            var rPw = Negocios.Factories.Users();

            try
            {

                string id_alvo = e.Uri.ToString(); 

                if (System.Windows.Forms.MessageBox.Show(string.Format("Deseja reiniciar a SENHA de {0}", id_alvo), "Sim.Alerta", System.Windows.Forms.MessageBoxButtons.YesNo).Equals(System.Windows.Forms.DialogResult.Yes))
                {

                    string value = "";

                    if (Dialog.InputBox("Digite sua senha para prosseguir", ":", ref value) == System.Windows.Forms.DialogResult.OK)
                    {
                        rPw.ResetSenha(Autenticado.UserId, value, id_alvo);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            { ListarUsuarios(); }
        }

        private void Hyperlink_RequestNavigate_2(object sender, RequestNavigateEventArgs e)
        {
            var b = Negocios.Factories.Users();

            try
            {
                string id_alvo = e.Uri.ToString();

                if (System.Windows.Forms.MessageBox.Show(string.Format("Deseja bloquear {0}", id_alvo), "Sim.Alerta", System.Windows.Forms.MessageBoxButtons.YesNo).Equals(System.Windows.Forms.DialogResult.Yes))
                {

                    string value = "";

                    if (Dialog.InputBox("Digite sua senha para prosseguir:", "Digite sua senha para prosseguir:", ref value) == System.Windows.Forms.DialogResult.OK)
                    {
                        b.BlockUser(Autenticado.UserId, value, id_alvo);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            { ListarUsuarios(); }
        }

        private void Hyperlink_RequestNavigate_3(object sender, RequestNavigateEventArgs e)
        {

        }
    }
}
