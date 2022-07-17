using System;
using System.Linq;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Forms;
using PdfSharp.Pdf;
using System.Drawing;
using System.Drawing.Printing;

namespace Sim.Pdf.View
{
    public partial class FormPDF : Gui.Forms.OwnedForm
    {

        int pages = 0;
        int currentpage = 0;
        string _file = string.Empty;

        PagePreview.RenderEvent renderEvent;

        MemoryManagement mm = new MemoryManagement();

        public PagePreview.RenderEvent RenderEvent
        {
            get { return this.renderEvent; }
            set
            {
                this.pagePreview.SetRenderEvent(value);
                this.renderEvent = value;
            }
        }
        
        public FormPDF(string file)
        {
            InitializeComponent();
            this.pagePreview.PageSize = PageSizeConverter.ToSize(PageSize.A4);
            _file = file;
        }

        void ImagenStream(XGraphics gfx)
        {
            XGraphicsState state = gfx.Save();
            XRect recImage = new XRect(PageSizeConverter.ToSize(PageSize.A4));
            gfx.DrawRectangle(XBrushes.White, recImage);
            gfx.DrawImage(XImage.FromGdiPlusImage(ShowPDF(_file)), recImage);
            gfx.Restore();
        }

        Image ShowPDF(string filename)
        {
            try {

                IntPtr ctx = NativeMethods.NewContext();
                IntPtr stm = NativeMethods.OpenFile(ctx, filename);
                IntPtr doc = NativeMethods.OpenDocumentStream(ctx, stm);
                int pg = NativeMethods.CountPages(doc);

                pages = pg;

                IntPtr p = NativeMethods.LoadPage(doc, currentpage);
                Rectangle b = new Rectangle();
                NativeMethods.BoundPage(doc, p, ref b);

                Bitmap bmp = Render.Page(ctx, doc, p, b);
                Image img = Image.FromHbitmap(bmp.GetHbitmap());
                
                bmp.Dispose();
                bmp = null;

                NativeMethods.FreePage(doc, p);
                NativeMethods.CloseDocument(doc);
                NativeMethods.CloseStream(stm);
                NativeMethods.FreeContext(ctx);
                
                this.Text = string.Format("Sim.PDFViwer {0}/{1}", currentpage + 1, pg);

                return img;
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("{0}\n{1}", ex.Message, filename) , "Sim.PDFViewer");
                this.Close();
                return null;                
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        void MakePdf()
        {
            try {

                string dirDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string filename = string.Format(@"{0}\sim{1}.pdf", dirDesktop, RandomString(10));
                PdfDocument document = new PdfDocument(filename);
                document.Info.Creator = "Sim.PDF";
                PdfPage page = document.AddPage();
                page.Size = PageSize.A4;
                XGraphics gfx = XGraphics.FromPdfPage(page);

                if (renderEvent != null)
                    renderEvent(gfx);

                document.Close();
                System.Diagnostics.Process.Start(filename);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sim.PDFViwer");
            }
        }

        private void FormPDF_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            RenderEvent = new PagePreview.RenderEvent(ImagenStream);            
            pagePreview.Invalidate();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            if (currentpage != 0)
            {
                currentpage = 0;
                RenderEvent = new PagePreview.RenderEvent(ImagenStream);
                pagePreview.Invalidate();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {

            if(currentpage > 0)
            {
                currentpage--;
                RenderEvent = new PagePreview.RenderEvent(ImagenStream);
                pagePreview.Invalidate();
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
           if (currentpage < (pages - 1))
            {                
                currentpage++;
                RenderEvent = new PagePreview.RenderEvent(ImagenStream);
                pagePreview.Invalidate();
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (currentpage != pages - 1)
            {
                currentpage = pages - 1;
                RenderEvent = new PagePreview.RenderEvent(ImagenStream);
                pagePreview.Invalidate();
            }
        }

        private void FormPDF_FormClosing(object sender, FormClosingEventArgs e)
        {            
            this.Dispose();
            pagePreview = null;
            mm.FlushMemory();      
        }

        private void FormPDF_Load(object sender, EventArgs e)
        {
            this.Text = "Sim.PDFViwer";
            //pagePreview.DesktopColor = Gui.Themes.Colors.Control;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(_file);
            /*
            PrintDialog pdlg = new PrintDialog();
            pdlg.PrinterSettings = new PrinterSettings();

            if (pdlg.ShowDialog() == DialogResult.OK)
            {
                Printer.SendFileToPrinter(pdlg.PrinterSettings.PrinterName, _file);
                Printer.SendToSpool(this.Handle, _file);
            }
            */
        }
    }
}
