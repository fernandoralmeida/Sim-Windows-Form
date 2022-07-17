using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDFLibNet;
using System.Runtime.InteropServices;
using System.Drawing.Printing;

namespace Sim.Forms.cPDFView
{
    public partial class PDFViewer : UserControl
    {

        public delegate void RenderNotifyInvoker(int page, bool isCurrent);

        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        public static PDFViewer Instance;
        
        PDFWrapper _pdfDoc = null;
        public PDFViewer()
        {
            InitializeComponent();

            //FitHeight();
            pageViewer1.PageSize = new Size(pageViewer1.Width, (int)(pageViewer1.Width * 11 / 8.5));
            //pageViewer1.PageSize = new Size(pageViewer1.Width, pageViewer1.Height);
            //pageViewer1.PageSize = new Size(pageViewer1.Width, (int)(pageViewer1.Width));
            pageViewer1.Visible = true;
            Instance = this;
        }

        #region LOAD PDF FILE
        string _pdfpath = string.Empty;
        public string PDFsPath
        {
            get { return _pdfpath; }
            set
            {
                _pdfpath = value;
                if (_pdfpath != string.Empty)
                {
                    OpenPDFs();
                    PageNumeric.Value = 1;
                    lblTotalPag.Text = string.Format("{0}/{1} Pag.", "1", _pdfDoc.PageCount.ToString());
                }
            }
        }

        private void OpenPDFs()
        {
            try
            {
                if (_pdfDoc != null)
                {
                    _pdfDoc.Dispose();
                    _pdfDoc = null;
                }

                //MessageBox.Show(PDFsPath);
                System.IO.FileInfo FI = new System.IO.FileInfo(PDFsPath);

                _pdfDoc = new PDFLibNet.PDFWrapper();

                int ts = Environment.TickCount;

                if (LoadFile(FI.FullName, _pdfDoc))
                {
                    _pdfDoc.CurrentPage = 1;
                    _pdfDoc.FitToHeight(pageViewer1.Handle);
                    _pdfDoc.RenderPage(pageViewer1.Handle);
                    Render();
                    PageNumeric.Maximum = _pdfDoc.PageCount;
                }
            }
            catch { }
            finally
            { GC.Collect(); }
        }

        public bool LoadStream(System.IO.Stream fileStream)
        {
            if (_pdfDoc != null)
            {
                _pdfDoc.Dispose();
                _pdfDoc = null;
            }

            _pdfDoc = new PDFWrapper();
            _pdfDoc.RenderNotifyFinished += new RenderNotifyFinishedHandler(_pdfDoc_RenderNotifyFinished);
            _pdfDoc.PDFLoadCompeted += new PDFLoadCompletedHandler(_pdfDoc_PDFLoadCompeted);
            _pdfDoc.PDFLoadBegin += new PDFLoadBeginHandler(_pdfDoc_PDFLoadBegin);

            try
            {
                if (fs != null)
                {
                    fs.Close();
                    fs = null;
                }

                bool bRet = _pdfDoc.LoadPDF(fileStream);

                return bRet;
            }
            catch (System.Security.SecurityException ex)
            {

                //bool bRet = _pdfDoc.LoadPDF(fileStream);             

                MessageBox.Show(ex.Message);
                //panel1.Enabled = false;
                return false;

            }

        }

        public bool ShowStream(System.IO.Stream fileStream)
        {
            if (LoadStream(fileStream))
            {

                _pdfDoc.CurrentPage = 1;

                _pdfDoc.FitToWidth(pageViewer1.Handle);
                _pdfDoc.RenderPage(pageViewer1.Handle);

                Render();

                PDFPage pg = _pdfDoc.Pages[1];

            }

            return false;
        }

        System.IO.FileStream fs = null;
        private bool LoadFile(string filename, PDFLibNet.PDFWrapper pdfDoc)
        {
            try
            {
                if (fs != null)
                {
                    fs.Close();
                    fs = null;
                }

                bool bRet = pdfDoc.LoadPDF(filename);
                return bRet;
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("PDF Protegido");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0} \n {1}", ex.Message, filename));
                //fecha o form se der erro de leitura
                panel1.Visible = false;
                //Form.ActiveForm.Close();
                return false;
            }
        }
        #endregion

        private void Render()
        {
            if (_pdfDoc != null)
            {
                pageViewer1.PageSize = new Size(_pdfDoc.PageWidth, _pdfDoc.PageHeight);
                pageViewer1.Refresh();
            }
        }

        private void FitWidth()
        {
            if (_pdfDoc != null && _pdfDoc.CurrentPage > 0)
            {
                using (PictureBox p = new PictureBox())
                {
                    p.Width = pageViewer1.ClientSize.Width;
                    _pdfDoc.FitToWidth(p.Handle);
                }
                _pdfDoc.RenderFinished -= new RenderFinishedHandler(_pdfDoc_RenderFinished);
                _pdfDoc.RenderFinished += new RenderFinishedHandler(_pdfDoc_RenderFinished);

                _pdfDoc.RenderPageThread(pageViewer1.Handle, true);
            }
        }

        private void FitHeight()
        {
            if (_pdfDoc != null && _pdfDoc.CurrentPage > 0)
            {
                using (PictureBox p = new PictureBox())
                {
                    p.Height = pageViewer1.ClientSize.Height;
                    _pdfDoc.FitToHeight(p.Handle);
                }
                _pdfDoc.RenderFinished -= new RenderFinishedHandler(_pdfDoc_RenderFinished);
                _pdfDoc.RenderFinished += new RenderFinishedHandler(_pdfDoc_RenderFinished);
                _pdfDoc.RenderPageThread(pageViewer1.Handle, false);
            }
        }

        private void pageViewer1_PaintControl(object sender, Rectangle view, Point location, Graphics g)
        {
            if (_pdfDoc != null)
            {
                Size sF = new Size(view.Right, view.Bottom);
                Rectangle r = new Rectangle(location, sF);
                _pdfDoc.ClientBounds = r;
                _pdfDoc.CurrentX = view.X;
                _pdfDoc.CurrentY = view.Y;
                _pdfDoc.DrawPageHDC(g.GetHdc());
                g.ReleaseHdc();
            }
        }

        private void PDFViewer_Resize(object sender, EventArgs e)
        {
            if (_pdfDoc != null)
            {
                //OpenPDFs();
                //PageNumeric.Value = 1;
                //_pdfDoc.CurrentPage = 0;
                //_pdfDoc.CurrentPage = Convert.ToInt32(PageNumeric.Value);
                _pdfDoc.RenderPage(pageViewer1.Handle);
                Render();
                //Invalidate();
            }
        }

        void _pdfDoc_RenderFinished()
        {
            try
            {
                pageViewer1.Refresh(); //Invoke(new frmExportSWF.FinishedInvoker(Render));
            }
            catch (Exception) { }
        }

        void _pdfDoc_PDFLoadBegin()
        {
            UpdateParamsUI(false);

            Resize -= new EventHandler(PDFViewer_Resize);
            //FormClosing -= new FormClosingEventHandler(frmPDFViewer_FormClosing);

            Gma.UserActivityMonitor.HookManager.MouseDown -= new MouseEventHandler(HookManager_MouseDown);
            Gma.UserActivityMonitor.HookManager.MouseUp -= new MouseEventHandler(HookManager_MouseUp);
            Gma.UserActivityMonitor.HookManager.MouseMove -= new MouseEventHandler(HookManager_MouseMove);

        }

        void _pdfDoc_PDFLoadCompeted()
        {
            //tvwOutline.BeforeExpand += new TreeViewCancelEventHandler(tvwOutline_BeforeExpand);
            //tvwOutline.NodeMouseClick += new TreeNodeMouseClickEventHandler(tvwOutline_NodeMouseClick);
            Resize += new EventHandler(PDFViewer_Resize);
            //FormClosing += new FormClosingEventHandler(frmPDFViewer_FormClosing);

            Gma.UserActivityMonitor.HookManager.MouseDown += new MouseEventHandler(HookManager_MouseDown);
            Gma.UserActivityMonitor.HookManager.MouseUp += new MouseEventHandler(HookManager_MouseUp);
            Gma.UserActivityMonitor.HookManager.MouseMove += new MouseEventHandler(HookManager_MouseMove);

            UpdateParamsUI();
        }

        void RenderNotifyFinished(int page, bool isCurrent)
        {
            if (!_pdfDoc.IsBusy)
                MessageBox.Show(_pdfDoc.Pages[_pdfDoc.CurrentPage].Text);
        }

        void _pdfDoc_RenderNotifyFinished(int page, bool bSuccesss)
        {
            Invoke(new RenderNotifyInvoker(RenderNotifyFinished), page, bSuccesss);
        }

        private void UpdateParamsUI()
        {
            UpdateParamsUI(true);
        }
        private void UpdateParamsUI(bool enabled)
        {
            //tsbAntialias.Enabled = _pdfDoc != null && enabled;
            //tsbVectorAntialias.Enabled = _pdfDoc != null && enabled;
            PDFLibNet.xPDFParams.Antialias = true;
            PDFLibNet.xPDFParams.VectorAntialias = true;
        }

        #region Mouse Scrolling/Navigation Private Fields
        public enum CursorStatus
        {
            Select,
            Move,
            Zoom,
            Snapshot
        }

        Rectangle EmptyRectangle = new Rectangle(-1, -1, 0, 0);
        CursorStatus _cursorStatus = CursorStatus.Move;
        Point _pointStart = Point.Empty;
        Point _pointCurrent = Point.Empty;

        Point _bMouseCapturedStart = Point.Empty;
        bool _bMouseCaptured = false;
        //int _pointX = 0;
        //int _pointY = 0;
        #endregion

        private CursorStatus getCursorStatus(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                return CursorStatus.Move;
            }
            return _cursorStatus;
        }
        private bool IsActive
        {
            get
            {
                return GetForegroundWindow() == this.Handle.ToInt32();
            }
        }
        private bool MouseInPage(Point p)
        {
            if (IsActive)
            {
                return pageViewer1.MouseInPage(p);
            }
            return false;
        }

        void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            Point pos = pageViewer1.PointToClient(e.Location);
            if (_pdfDoc != null)
            {
                if (MouseInPage(pos) && _bMouseCaptured)
                {
                    //Handled by the control
                }
                else if (MouseInPage(pos))
                {
                    //Check if we have the pointer on a link
                    if (getCursorStatus(e) == CursorStatus.Move)
                    {
                        PDFLibNet.PageLink link = SearchLink(e.Location);
                        if (link != null)
                        {
                            pageViewer1.Cursor = Cursors.Hand;
                        }
                        else
                        {
                            pos = pageViewer1.PointUserToPage(pos);
                            if (!_pdfDoc.IsBusy && _pdfDoc.Pages.Count > 0 &&
                                _pdfDoc.Pages[_pdfDoc.CurrentPage].HasText(pos.X, pos.Y))
                            {
                                /*if (_pdfDoc.Pages[_pdfDoc.CurrentPage].ImagesCount > 0)
                                {
                                    Image img = _pdfDoc.Pages[_pdfDoc.CurrentPage].GetImage(0);
                                    img.Save("C:\\image_extracted_0.jpg");
                                }*/

                                /*img = _pdfDoc.Pages[_pdfDoc.CurrentPage].GetImage(1);
                                img.Save("C:\\image_extracted_1.jpg");
                                img = _pdfDoc.Pages[_pdfDoc.CurrentPage].GetImage(2);
                                img.Save("C:\\image_extracted_2.jpg");*/

                                pageViewer1.Cursor = Cursors.IBeam;
                            }
                            else
                                pageViewer1.Cursor = Cursors.Default;
                        }
                    }
                }
            }
            _pointCurrent = e.Location; //Update current Point
        }

        private PDFLibNet.PageLink SearchLink(Point location)
        {
            if (_pdfDoc != null)
            {
                Point p = pageViewer1.PointToClient(location);
                List<PageLink> links = _pdfDoc.GetLinks(_pdfDoc.CurrentPage);
                if (links != null)
                {
                    //Search for a link
                    foreach (PDFLibNet.PageLink pl in links)
                    {
                        //Convert coordinates
                        Point p1 = Point.Ceiling(_pdfDoc.PointUserToDev(new PointF(pl.Bounds.Left, pl.Bounds.Top)));
                        Point p2 = Point.Ceiling(_pdfDoc.PointUserToDev(new PointF(pl.Bounds.Right, pl.Bounds.Bottom)));
                        Rectangle linkLoc = new Rectangle(p1.X, p1.Y, p2.X - p1.X, p1.Y - p2.Y);
                        //Translate
                        linkLoc.Offset(-pageViewer1.CurrentView.X, -pageViewer1.CurrentView.Y);
                        linkLoc.Offset(pageViewer1.PageBounds.X, pageViewer1.PageBounds.Y);
                        linkLoc.Offset(0, p2.Y - p1.Y);
                        if (linkLoc.Contains(p))
                            //Link found!
                            return pl;
                    }
                }
            }
            return null;
        }

        void HookManager_MouseUp(object sender, MouseEventArgs e)
        {
            Point pos = pageViewer1.PointToClient(e.Location);
            if (_pdfDoc != null && MouseInPage(pos) && _bMouseCaptured)
            {
                switch (getCursorStatus(e))
                {
                    case CursorStatus.Move:

                        break;
                    case CursorStatus.Zoom:
                        if (!_pointCurrent.Equals(EmptyRectangle))
                        {
                            if (e.Button == MouseButtons.Left && _pdfDoc != null)
                                _pdfDoc.ZoomIN();
                            else if (e.Button == MouseButtons.Right && _pdfDoc != null)
                                _pdfDoc.ZoomOut();
                        }
                        else
                        {
                            //Zoom on rectangle

                        }
                        break;
                }
                pageViewer1.Cursor = Cursors.Default;
            }
            ReleaseRubberFrame();
            _bMouseCaptured = false;
        }

        void HookManager_MouseDown(object sender, MouseEventArgs e)
        {
            Point pos = pageViewer1.PointToClient(e.Location);
            if (_pdfDoc != null && MouseInPage(pos) && e.Button == MouseButtons.Left)
            {
                PDFLibNet.PageLink link = SearchLink(e.Location);
                if (link != null)
                {
                    switch (link.Action.Kind)
                    {
                        case LinkActionKind.actionGoTo:

                            PDFLibNet.PageLinkGoTo plgo = (link.Action as PDFLibNet.PageLinkGoTo);
                            if (plgo.Destination != null)
                            {
                                _pdfDoc.CurrentPage = plgo.Destination.Page;
                                PointF loc = _pdfDoc.PointUserToDev(new PointF((float)plgo.Destination.Left, (float)plgo.Destination.Top));
                                if (plgo.Destination.ChangeTop)
                                    ScrolltoTop((int)loc.Y);
                                else
                                    ScrolltoTop(0);
                                _pdfDoc.RenderPage(pageViewer1.Handle);
                                Render();
                            }
                            else if (plgo.DestinationName != null)
                            {

                            }
                            break;
                        case LinkActionKind.actionURI:
                            PDFLibNet.PageLinkURI uri = (link.Action as PDFLibNet.PageLinkURI);
                            if (MessageBox.Show("Ejecutar aplicación externa?" + Environment.NewLine + uri.URL, Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                System.Diagnostics.Process p = new System.Diagnostics.Process();
                                p.StartInfo.FileName = GetDefaultBrowserPath();
                                p.StartInfo.Arguments = uri.URL;
                                p.Start();
                            }
                            break;
                    }
                }
                else
                {
                    _pointCurrent = e.Location;
                    _pointStart = e.Location;
                    _bMouseCaptured = true;
                }
            }
        }

        private void ScrolltoTop(int y)
        {
            Point dr = this.pageViewer1.ScrollPosition;
            if (_pdfDoc.PageHeight > pageViewer1.Height)
                dr.Y = y;
            pageViewer1.ScrollPosition = dr;
        }

        #region Rubber Frame
        Point EmptyPoint = new Point(-1, -1);
        Point _lastPoint = new Point(-1, -1);
        private void DrawRubberFrame()
        {

            if (!_lastPoint.Equals(EmptyPoint) ||
                (_bMouseCaptured && !_pointCurrent.Equals(EmptyPoint))
            )

                if (!_lastPoint.Equals(EmptyPoint))
                {
                    ReleaseRubberFrame();
                }
            _lastPoint = _pointCurrent;
            DrawRubberFrame(_pointStart, _pointCurrent);

        }
        private void ReleaseRubberFrame()
        {
            if (!_lastPoint.Equals(EmptyPoint))
            {
                DrawRubberFrame(_pointStart, _lastPoint);
            }
            _lastPoint = EmptyPoint;
        }
        private void DrawRubberFrame(Point p1, Point p2)
        {
            Rectangle rc = new Rectangle();

            // Convert the points to screen coordinates.
            //p1 = PointToScreen(p1);
            //p2 = PointToScreen(p2);
            // Normalize the rectangle.
            if (p1.X < p2.X)
            {
                rc.X = p1.X;
                rc.Width = p2.X - p1.X;
            }
            else
            {
                rc.X = p2.X;
                rc.Width = p1.X - p2.X;
            }
            if (p1.Y < p2.Y)
            {
                rc.Y = p1.Y;
                rc.Height = p2.Y - p1.Y;
            }
            else
            {
                rc.Y = p2.Y;
                rc.Height = p1.Y - p2.Y;
            }
            // Draw the reversible frame.
            ControlPaint.DrawReversibleFrame(rc,
                            Color.Gray, FrameStyle.Dashed);

        }
        #endregion
        private static string GetDefaultBrowserPath()
        {
            string key = @"htmlfile\shell\open\command";
            Microsoft.Win32.RegistryKey registryKey =
            Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key, false);
            // get default browser path
            return ((string)registryKey.GetValue(null, null)).Split('"')[1];

        }

        private bool pageViewer1_NextPage(object sender)
        {
            if (_pdfDoc.CurrentPage < _pdfDoc.PageCount)
            {
                _pdfDoc.NextPage();
                _pdfDoc.RenderPage(pageViewer1.Handle);
                Render();
                return true;
            }

            return false;
        }

        private bool pageViewer1_PreviousPage(object sender)
        {
            if (_pdfDoc.CurrentPage > 1)
            {
                _pdfDoc.PreviousPage();
                _pdfDoc.RenderPage(pageViewer1.Handle);
                Render();
                return true;
            }
            //return default(bool);
            return false;
        }

        private void PageNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (_pdfDoc != null)
            {
                _pdfDoc.CurrentPage = Convert.ToInt32(PageNumeric.Value);
                _pdfDoc.RenderPage(pageViewer1.Handle);
                Render();
                lblTotalPag.Text = string.Format("{0}/{1}", PageNumeric.Value, PageNumeric.Maximum);
            }
        }

        private void cBSecon_Click(object sender, EventArgs e)
        {
            if (_pdfDoc != null)
            {
                _pdfDoc.CurrentPage = _pdfDoc.PageCount;
                _pdfDoc.RenderPage(pageViewer1.Handle);
                Render();
                PageNumeric.Value = _pdfDoc.PageCount;                
            }
        }

        private void cBPrim_Click(object sender, EventArgs e)
        {
            if (_pdfDoc != null)
            {
                _pdfDoc.CurrentPage = 1;
                _pdfDoc.RenderPage(pageViewer1.Handle);
                Render();
                PageNumeric.Value = 1;
            }
        }

        private void cButtonBCK_Click(object sender, EventArgs e)
        {
            //pagina > pagina inicial ? pagina - 1 : pagina inicial
            PageNumeric.Value = (PageNumeric.Value > 1) ? PageNumeric.Value -= 1 : 1;
        }

        private void cButtonNXT_Click(object sender, EventArgs e)
        {
            //pagina < ultima pagina ? pagina + 1 : ultima pagina
            PageNumeric.Value = (PageNumeric.Value < PageNumeric.Maximum) ? PageNumeric.Value += 1 : PageNumeric.Maximum;
        }
         
        private void cButtonPrint_Click(object sender, EventArgs e)
        {
            
            //Imprimir arquivo
            PrintDialog pDialog = new PrintDialog();
            pDialog.PrinterSettings = new PrinterSettings();

            if (pDialog.ShowDialog(this).Equals(DialogResult.OK))
            {
                Classes.RawPrinterHelper.SendFileToPrinter(pDialog.PrinterSettings.PrinterName, PDFsPath);
            }        

        }

    }
}
