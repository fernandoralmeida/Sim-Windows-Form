using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Sim.Legislacao.Visao
{
    public partial class FormPrint : Gui.Forms.OwnedForm
    {

        public FormPrint(PrintDocument docprint)
        {
            InitializeComponent();
            printPreviewControl1.Document = docprint;    
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Sim.PrintPreview");
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.Document = printPreviewControl1.Document;
                printPreviewControl1.Document.Print();
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            printPreviewControl1.StartPage = 0;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            printPreviewControl1.StartPage = 0;
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            if (printPreviewControl1.StartPage != 0)
                printPreviewControl1.StartPage--;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            printPreviewControl1.StartPage++;
        }

        private void FormPrint_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        private void FormPrint_ResizeEnd(object sender, EventArgs e)
        {
            printPreviewControl1.Zoom = 1;
        }
    }
}
