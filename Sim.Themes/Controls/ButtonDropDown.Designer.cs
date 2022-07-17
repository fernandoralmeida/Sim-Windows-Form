namespace Sim.Gui.Controls
{
    partial class ButtonDropDown
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.ContainerControl, true);
            SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, true);
            SetStyle(System.Windows.Forms.ControlStyles.Selectable, true);
            SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(System.Windows.Forms.ControlStyles.UserMouse, true);
            SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.Selectable, true);

            components = new System.ComponentModel.Container();

            this.contextStrip = new System.Windows.Forms.ContextMenuStrip();

            //
            //ContextMenuStrip
            //
            this.contextStrip.ShowImageMargin = false;
            this.contextStrip.Font = this.Font;
            this.contextStrip.DropShadowEnabled = true;
            this.contextStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(ContextStrip_Closed);
            this.contextStrip.Paint += new System.Windows.Forms.PaintEventHandler(ContextStrip_Paint);
            this.contextStrip.LayoutCompleted += new System.EventHandler(ContextStrip_LayoutCompleted);
            
        }

        private bool mShaped;

        private void ContextStrip_LayoutCompleted(object sender, System.EventArgs e)
        {
            if (!mShaped && !DesignMode)
            {
                mShaped = true;
                System.Drawing.Drawing2D.GraphicsPath gpath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(1, 1, contextStrip.Width - 2, contextStrip.Height - 2);
                gpath.AddRectangle(rect);
                contextStrip.Region = new System.Drawing.Region(gpath);
            }
        }

        private void ContextStrip_Closed(object sender, System.Windows.Forms.ToolStripDropDownClosedEventArgs e)
        {
            MouseOnHover = OnHover.Off;
            PressState = ControlPressed.UnPressed;
            Invalidate();
        }

        private void ContextStrip_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Themes.Brushes.Control, 0, 0, contextStrip.Width, contextStrip.Height);
            e.Graphics.DrawRectangle(Themes.Pens.ControlHighLight, 1, 1, contextStrip.Width - 3, contextStrip.Height - 3);
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextStrip;

    }
}
