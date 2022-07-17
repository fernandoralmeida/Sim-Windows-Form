using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using PdfSharp.Forms;

namespace Sim.Componentes.Formularios
{
    public partial class newFormPDF : xFormChild
    {

        string _file = string.Empty;

        PagePreview.RenderEvent renderEvent;

        public newFormPDF(string file)
        {
            InitializeComponent();
            this.pagePreview.PageSize = PageSizeConverter.ToSize(PageSize.A4);
            _file = file;
        }
        
        void renderPDF(XGraphics gfx)
        {

            XGraphicsState state = gfx.Save();
            XRect rcImage = new XRect(this.pagePreview.PageSize);
            gfx.DrawRectangle(XBrushes.Snow, rcImage);
            gfx.DrawImage(XPdfForm.FromFile(_file), rcImage);
            gfx.Restore(state);
        }

        private void newFormPDF_Shown(object sender, EventArgs e)
        {

            PdfDocument PDFDoc = PdfReader.Open(_file, PdfDocumentOpenMode.Import);
            PdfDocument PDFNewDoc = new PdfDocument();
            
            for (int Pg = 0; Pg < PDFDoc.Pages.Count; Pg++)
            {
                PDFNewDoc.AddPage(PDFDoc.Pages[Pg]);
            }
            RenderEvent = new PagePreview.RenderEvent(renderPDF);

        }

        public PagePreview.RenderEvent RenderEvent
        {
            get { return this.renderEvent; }
            set
            {
                this.pagePreview.SetRenderEvent(value);
                this.renderEvent = value;
            }
        }

    }
}
