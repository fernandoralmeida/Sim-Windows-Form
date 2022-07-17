using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;

namespace Sim.Pdf.View
{
    public partial class FormDownload : Gui.Forms.OwnedForm
    {

        bool emdownload = false;        
        bool arquivoExite = false;
        string filedownloading = string.Empty;
        string filedownloaded = string.Empty;
        IntPtr hdl = IntPtr.Zero;

        public FormDownload(string file, IntPtr handle)
        {
            InitializeComponent();

            hdl = handle;

            filedownloading = file;
            
            string url = file;
            string arquivo = url.Replace(@"/", "");

            filedownloaded = string.Format(@"{0}\{1}\{2}", Application.StartupPath, "Cache", arquivo.Remove(0, 5));         
        }

        private void FileDownload(string url)
        {
            try
            {
                emdownload = true;
                WebClient cliente = new WebClient();

                cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(FileDownloadProgress);

                cliente.DownloadFileAsync(new Uri(url), filedownloaded);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FileDownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            label1.Text = String.Format("Downloading... {0}%", e.ProgressPercentage);
            progressBar1.Valor = e.ProgressPercentage;
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            emdownload = false;
            FormPDF fm = new FormPDF(filedownloaded);
            fm.Show(Form.FromHandle(hdl));
            this.Close();
        }

        private void FormDownload_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (emdownload.Equals(true))
                e.Cancel = true;
        }

        private void FormDownload_Shown(object sender, EventArgs e)
        {

            arquivoExite = (System.IO.File.Exists(filedownloaded)) ? true : false;

            //arquivo exite ? false = download : true = mostrar
            if (arquivoExite.Equals(false))
            {
                Application.DoEvents();
                FileDownload(filedownloading);
            }
            else
            {
                filedownloaded = filedownloaded.Replace(@"/", @"\");
                FormPDF fm = new FormPDF(filedownloaded);
                fm.Show(Form.FromHandle(hdl));
                this.Close();
            }
        }
    }
}
