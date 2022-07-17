namespace Sim.Forms.cPDFView
{
    partial class PageViewer
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
            this.hsb = new System.Windows.Forms.HScrollBar();
            this.vsb = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // hsb
            // 
            this.hsb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hsb.Location = new System.Drawing.Point(0, 402);
            this.hsb.Name = "hsb";
            this.hsb.Size = new System.Drawing.Size(344, 17);
            this.hsb.TabIndex = 0;
            this.hsb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsb_Scroll);
            this.hsb.Resize += new System.EventHandler(this.vsb_Resize);
            // 
            // vsb
            // 
            this.vsb.Dock = System.Windows.Forms.DockStyle.Right;
            this.vsb.Location = new System.Drawing.Point(344, 0);
            this.vsb.Name = "vsb";
            this.vsb.Size = new System.Drawing.Size(17, 419);
            this.vsb.TabIndex = 1;
            this.vsb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            this.vsb.Resize += new System.EventHandler(this.vsb_Resize);
            // 
            // PageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.hsb);
            this.Controls.Add(this.vsb);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "PageViewer";
            this.Size = new System.Drawing.Size(361, 419);
            this.MarginChanged += new System.EventHandler(this.DoubleBufferControl_MarginChanged);
            this.Resize += new System.EventHandler(this.DoubleBufferControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
