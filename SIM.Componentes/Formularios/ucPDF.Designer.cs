namespace Sim.Forms
{
    partial class ucPDF
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
            this.panelDownload = new System.Windows.Forms.Panel();
            this.labelpercent = new System.Windows.Forms.Label();
            this.labelmsg = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.PDFViewer = new Sim.Forms.cPDFView.PDFViewer();
            this.panelDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDownload
            // 
            this.panelDownload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDownload.BackColor = System.Drawing.Color.White;
            this.panelDownload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDownload.Controls.Add(this.labelpercent);
            this.panelDownload.Controls.Add(this.labelmsg);
            this.panelDownload.Controls.Add(this.progressBarDownload);
            this.panelDownload.Location = new System.Drawing.Point(56, 264);
            this.panelDownload.Name = "panelDownload";
            this.panelDownload.Size = new System.Drawing.Size(278, 42);
            this.panelDownload.TabIndex = 2;
            // 
            // labelpercent
            // 
            this.labelpercent.AutoSize = true;
            this.labelpercent.Location = new System.Drawing.Point(169, 3);
            this.labelpercent.Name = "labelpercent";
            this.labelpercent.Size = new System.Drawing.Size(35, 15);
            this.labelpercent.TabIndex = 2;
            this.labelpercent.Text = "{0}%";
            // 
            // labelmsg
            // 
            this.labelmsg.AutoSize = true;
            this.labelmsg.Location = new System.Drawing.Point(58, 3);
            this.labelmsg.Name = "labelmsg";
            this.labelmsg.Size = new System.Drawing.Size(105, 15);
            this.labelmsg.TabIndex = 1;
            this.labelmsg.Text = "Downloading...";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(3, 21);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(270, 16);
            this.progressBarDownload.TabIndex = 0;
            // 
            // PDFViewer
            // 
            this.PDFViewer.BackColor = System.Drawing.Color.White;
            this.PDFViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDFViewer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDFViewer.Location = new System.Drawing.Point(0, 0);
            this.PDFViewer.Name = "PDFViewer";
            this.PDFViewer.PDFsPath = "";
            this.PDFViewer.Size = new System.Drawing.Size(390, 571);
            this.PDFViewer.TabIndex = 3;
            // 
            // ucPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDownload);
            this.Controls.Add(this.PDFViewer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucPDF";
            this.Size = new System.Drawing.Size(390, 571);
            this.panelDownload.ResumeLayout(false);
            this.panelDownload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDownload;
        private System.Windows.Forms.Label labelpercent;
        private System.Windows.Forms.Label labelmsg;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private cPDFView.PDFViewer PDFViewer;

    }
}
