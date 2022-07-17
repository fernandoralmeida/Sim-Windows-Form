using System;
using System.IO;
using System.Security.Permissions;

namespace Sim.Pdf
{
    
    class ExportPdf
    {

        public string foldername = string.Empty;

        public int indiceCount = 0;

        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        public bool ToBitmap(string file_pdf_name)
        {

            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            try {

                FileInfo fi = new FileInfo(file_pdf_name);

                foldername = fi.Name.Remove(fi.Name.Length - 4, 4);

                //System.Windows.Forms.MessageBox.Show(filename);

                DirectoryInfo newpasta = new DirectoryInfo(string.Format(@"Cache\{0}\", foldername));

                if (!Directory.Exists(newpasta.FullName))
                {
                    Directory.CreateDirectory(newpasta.FullName);
                }

                //System.Windows.Forms.MessageBox.Show(foldername + " " + file_pdf_name);

                IntPtr ctx = NativeMethods.NewContext(); // Creates the context
                IntPtr stm = NativeMethods.OpenFile(ctx, file_pdf_name);// string.Format(@"Cache\{0}.pdf", filename)); // opens file test.pdf as a stream
                IntPtr doc = NativeMethods.OpenDocumentStream(ctx, stm); // opens the document
                int pn = NativeMethods.CountPages(doc); indiceCount = pn; // gets the number of pages in the document
                for (int i = 0; i < pn; i++)
                { // iterate through each pages
                  //Console.WriteLine("Rendering page " + (i + 1));
                    IntPtr p = NativeMethods.LoadPage(doc, i); // loads the page (first page number is 0)
                    Rectangle b = new Rectangle();
                    NativeMethods.BoundPage(doc, p, ref b); // gets the page size

                    using (var bmp = Render.Page(ctx, doc, p, b))
                    { // renders the page and converts the result to Bitmap
                      //Console.WriteLine("Saving picture: " + (i + 1) + ".png");
                      //imglist.Add(Image.FromHbitmap(bmp.GetHbitmap()));
                        bmp.Save(string.Format(@"Cache\{0}\{1}.png", foldername, i + 1)); // saves the bitmap to a file
                    }
                    NativeMethods.FreePage(doc, p); // releases the resources consumed by the page
                }
                NativeMethods.CloseDocument(doc); // releases the resources
                NativeMethods.CloseStream(stm);
                NativeMethods.FreeContext(ctx);
                //Console.WriteLine("Program finished. Press any key to quit.");
                //Console.ReadKey(true);
                //this.Text = string.Format("{0} paginas", imglist.Count);
                //throw new Exception();
                return true;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Sim.PDFViwer");
                return false;
            }
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception args = (Exception)e.ExceptionObject;
            string m = "I/O Error : " + args.Message;
            string mm = string.Format("Runtime terminating: {0}", e.IsTerminating);
            System.Windows.Forms.MessageBox.Show(m + "\n" + mm);
        }

    }
}
