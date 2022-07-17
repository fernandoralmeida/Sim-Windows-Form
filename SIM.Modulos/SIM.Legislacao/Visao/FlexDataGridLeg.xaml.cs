using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sim.Legislacao.Visao
{
    /// <summary>
    /// Interaction logic for FlexDataGrid.xaml
    /// </summary>
    public partial class FlexDataGrid : UserControl
    {
        
        public FlexDataGrid()
        {
            InitializeComponent();
        }

        public void AppTheme()
        {
            Gui.Wpf.ThemeManager.ApplyTheme(this, "Resources");
        }

        public Entidades.ListaLegislacao Listar
        {
            get { return null; }
            set
            {
                flexgrid.ItemsSource = value;
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            //Sim.Componentes.Classes.ColorTheme.GetTheme();
            SolidColorBrush mbrush = new SolidColorBrush(Color.FromArgb(255, Gui.Themes.Colors.ControlHighLight.R, Gui.Themes.Colors.ControlHighLight.G, Gui.Themes.Colors.ControlHighLight.B));
            flexgrid.BorderBrush = mbrush;

            this.Background = Brushes.White;
            base.OnRender(drawingContext);
        }

        public void PrintGrid()
        {
            PrintDialog Printdlg = new PrintDialog();
            if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
            {
                Size pageSize = new Size(Printdlg.PrintableAreaWidth, Printdlg.PrintableAreaHeight);
                // sizing of the element.
                flexgrid.Measure(pageSize);
                flexgrid.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
                Printdlg.PrintVisual(flexgrid, "Legislação");
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Pdf.View.FormPDF fmp = new Pdf.View.FormPDF(
                string.Format(@"{0}{1}",
                Properties.Settings.Default.viaHD, e.Uri.ToString()));
            fmp.Text = "Sim.PDFViwer";

            fmp.Show(System.Windows.Forms.Form.FromHandle(Negocios.Handles.Consulta));                                 
        }

        private void Hyperlink_RequestNavigate_Edit(object sender, RequestNavigateEventArgs e)
        {
            var dataDB = Instancia.RegrasNegocios();
            var legObj = Instancia.Legislacao();
            int codigo = Convert.ToInt32(e.Uri.ToString());
            legObj.Indice = codigo;
            FmIncluir FM = new FmIncluir(Tela.ModoAlterar, dataDB.ListaParaEdicao(legObj));
            FM.ShowDialog(System.Windows.Forms.Form.FromHandle(Negocios.Handles.Consulta));
        }

        /*
        private void Hyperlink_RequestNavigate_1(object sender, RequestNavigateEventArgs e)
        {
            Pdf.View.FormPDF fmp = new Pdf.View.FormPDF(
               string.Format(@"{0}{1}",
               Properties.Settings.Default.viaHD, e.Uri.ToString()));
            fmp.Text = "Sim.PDFViwer";

            fmp.Show(System.Windows.Forms.Form.FromHandle(Negocios.Handles.Consulta));
        }
        */
    }
}
