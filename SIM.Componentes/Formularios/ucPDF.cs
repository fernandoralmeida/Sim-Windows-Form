using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
//using System.Data;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Sim.Forms
{
    public partial class ucPDF : UserControl
    {

        bool arquivoExite = false;
        string fileTmp = string.Empty;

        public ucPDF()
        {
            InitializeComponent();
        }

        public void VerificarArquivo()
        {
            string url = Classes.Transportar.UrlAtiva();
            PDFViewer.PDFsPath = string.Empty;
            PDFViewer.Refresh();
            string arquivo = url.Replace(@"/", "");
            arquivo = arquivo.Remove(0, 5);
            fileTmp = string.Format(@"{0}\{1}\{2}", Application.StartupPath, Classes.Diretorios.dirCache, arquivo);
            arquivoExite = (System.IO.File.Exists(fileTmp)) ? true : false;
            
            //se arquivo exites, mostre, se não, iniciar download
            if (arquivoExite.Equals(true))
            {
                panelDownload.Visible = false;
                PDFViewer.PDFsPath = fileTmp;
            }
            else
            {
                panelDownload.Visible = true;
                Application.DoEvents();
                FileDownload(Classes.Transportar.UrlAtiva());
            }
        }

        private void FileDownload(string url)
        {
            PDFViewer.Enabled = false;
            WebClient cliente = new WebClient();

            cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(FileDownloadProgress);

            cliente.DownloadFileAsync(new Uri(url), fileTmp);
        }

        private void FileDownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            labelpercent.Text = String.Format("{0}%", e.ProgressPercentage);
            progressBarDownload.Value = e.ProgressPercentage;            //throw new NotImplementedException();
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            PDFViewer.Enabled = true;
            PDFViewer.PDFsPath = fileTmp;
            panelDownload.Visible = false;
            progressBarDownload.Value = 0;//throw new NotImplementedException();
        }

    }
}
