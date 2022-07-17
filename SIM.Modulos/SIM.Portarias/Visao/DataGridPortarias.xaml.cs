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

namespace Sim.Portarias.Visao
{
    /// <summary>
    /// Interaction logic for DataGridPortarias.xaml
    /// </summary>
    public partial class DataGridPortarias : UserControl
    {
        public DataGridPortarias()
        {
            InitializeComponent();
            SolidColorBrush mbrush = new SolidColorBrush(Color.FromArgb(255, Gui.Themes.Colors.ControlHighLight.R, Gui.Themes.Colors.ControlHighLight.G, Gui.Themes.Colors.ControlHighLight.B));
            dataGridPortarias.BorderBrush = mbrush;
        }

        public void AppTheme()
        {
            Sim.Gui.Wpf.ThemeManager.ApplyTheme(this, "Resources");
        }

        public Entidade.ListViewPortarias Listar
        {
            get { return null; }
            set
            {
                dataGridPortarias.ItemsSource = value;
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            //Forms.FormPDF fm = new Forms.FormPDF();

            string link = string.Format(@"{0}{1}", Properties.Settings.Default.caminhoPDF, e.Uri.ToString());

            Pdf.View.FormPDF fm = new Pdf.View.FormPDF(link.Replace("/",@"\"));

            fm.Show(System.Windows.Forms.Form.FromHandle(Negocios.Handles.Consulta));
        }

        private void Hyperlink_RequestNavigate_Edit(object sender, RequestNavigateEventArgs e)
        {
            Entidade.Portarias EP = Negocios.Instanciar.EntPortarias();

            EP.Indice = Convert.ToInt32(e.Uri.ToString());

            Visao.FmEditar FM = new Visao.FmEditar(EP);
            FM.Text = "Sim.Dektop.Editar";
            FM.ShowDialog();
        }
    }
}
