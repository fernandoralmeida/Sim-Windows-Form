using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Sim.Forms
{
    public partial class FormPDF : Sim.Gui.Forms.OwnedForm
    {
        public FormPDF()
        {
            InitializeComponent();
        }

        bool arquivoExite = false;
        bool emdownload = false;
        string fileTmp = string.Empty;
        string urlAtiva = string.Empty;

        private void PDFViewer_Load(object sender, EventArgs e)
        {  }

        private void FormPDF_Shown(object sender, EventArgs e)
        {
            //arquivo exite ? false = download : true = mostrar
            if (arquivoExite.Equals(false))
            {
                Application.DoEvents();
                FileDownload(urlAtiva); //chama o download do arquivo
                //MessageBox.Show(string.Format(@"Arquivo ""{0}"" não encontrado!", fileTmp), "Sim.Alerta");
            }
            else
            {
                panel1.Visible = false; // oculta painel de download
                fileTmp = fileTmp.Replace(@"/", @"\");
                //MessageBox.Show(fileTmp);
                Application.DoEvents();
                pdfViewer.PDFsPath = fileTmp;
                //webBrowser.Url = new Uri(fileTmp);
            }
        }
        
        private void FileDownload(string url)
        {
            try
            {
                emdownload = true;
                pdfViewer.Enabled = false;
                WebClient cliente = new WebClient();

                cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(FileDownloadProgress);

                //System.Net.HttpWebRequest Conexao;            

                cliente.DownloadFileAsync(new Uri(url), fileTmp);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void FileDownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            label2.Text = String.Format("{0}%", e.ProgressPercentage);
            progressBarDownload.Value = e.ProgressPercentage;
            //cProgressBar1.Valor = (cProgressBar1.Width * e.ProgressPercentage) / 100;
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            pdfViewer.Enabled = true;
            pdfViewer.PDFsPath = fileTmp;
            //webBrowser.Url = new Uri(fileTmp);
            panel1.Visible = false;
            emdownload = false;
        }

        private void FormPDF_FormClosed(object sender, FormClosedEventArgs e)
        {
            pdfViewer.Dispose();
            this.Dispose();
        }

        public void InHDFile(string valor) // para arquivos no HD
        {
            fileTmp = valor;
            arquivoExite = (System.IO.File.Exists(fileTmp)) ? true : false;
        }

        public void InNetWorkFile(string valor)
        {
            fileTmp = valor;
            //arquivoExite = (System.IO.File.Exists(fileTmp)) ? true : false;
            arquivoExite = true;
        }

        public void InURLFile(string valor) // para arquivos via URL
        {
            urlAtiva = valor;
            string url = valor;
            string arquivo = url.Replace(@"/", "");
            arquivo = arquivo.Remove(0, 5);
            fileTmp = string.Format(@"{0}\{1}\{2}", Application.StartupPath, Classes.Diretorios.dirCache, arquivo);
            arquivoExite = (System.IO.File.Exists(fileTmp)) ? true : false;
        }

        private void FormPDF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (emdownload.Equals(true))
                e.Cancel = true;

            if (this.ControlBox.Equals(false))
            {
                e.Cancel = true;
            }
        }

    }
}
