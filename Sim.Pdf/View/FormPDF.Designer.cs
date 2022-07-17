namespace Sim.Pdf.View
{
    partial class FormPDF
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPDF));
            this.pagePreview = new PdfSharp.Forms.PagePreview();
            this.buttonFirst = new Sim.Gui.Controls.Button(this.components);
            this.buttonPrevious = new Sim.Gui.Controls.Button(this.components);
            this.buttonNext = new Sim.Gui.Controls.Button(this.components);
            this.buttonLast = new Sim.Gui.Controls.Button(this.components);
            this.buttonPrint = new Sim.Gui.Controls.Button(this.components);
            this.SuspendLayout();
            // 
            // pagePreview
            // 
            this.pagePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagePreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pagePreview.DesktopColor = System.Drawing.SystemColors.ControlDark;
            this.pagePreview.Location = new System.Drawing.Point(2, 53);
            this.pagePreview.Name = "pagePreview";
            this.pagePreview.PageColor = System.Drawing.Color.White;
            this.pagePreview.PageSize = ((PdfSharp.Drawing.XSize)(resources.GetObject("pagePreview.PageSize")));
            this.pagePreview.PageSizeF = new System.Drawing.Size(595, 842);
            this.pagePreview.ShowScrollbars = false;
            this.pagePreview.Size = new System.Drawing.Size(412, 575);
            this.pagePreview.TabIndex = 5;
            this.pagePreview.ZoomPercent = 50;
            // 
            // buttonFirst
            // 
            this.buttonFirst.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonFirst.Location = new System.Drawing.Point(7, 26);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(30, 25);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonPrevious.Location = new System.Drawing.Point(37, 26);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(30, 25);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonNext.Location = new System.Drawing.Point(67, 26);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(30, 25);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonLast.Location = new System.Drawing.Point(97, 26);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(30, 25);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = ">>";
            this.buttonLast.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonPrint.Location = new System.Drawing.Point(320, 26);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(90, 25);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Imprimir";
            this.buttonPrint.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // FormPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 630);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pagePreview);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Name = "FormPDF";
            this.Text = "FormPDF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPDF_FormClosing);
            this.Load += new System.EventHandler(this.FormPDF_Load);
            this.Shown += new System.EventHandler(this.FormPDF_Shown);
            this.Controls.SetChildIndex(this.buttonFirst, 0);
            this.Controls.SetChildIndex(this.buttonPrevious, 0);
            this.Controls.SetChildIndex(this.pagePreview, 0);
            this.Controls.SetChildIndex(this.buttonNext, 0);
            this.Controls.SetChildIndex(this.buttonLast, 0);
            this.Controls.SetChildIndex(this.buttonPrint, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private PdfSharp.Forms.PagePreview pagePreview;
        private Gui.Controls.Button buttonPrint;
        private Gui.Controls.Button buttonLast;
        private Gui.Controls.Button buttonNext;
        private Gui.Controls.Button buttonPrevious;
        private Gui.Controls.Button buttonFirst;
    }
}