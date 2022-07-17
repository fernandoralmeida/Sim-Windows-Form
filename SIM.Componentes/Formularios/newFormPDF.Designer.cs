namespace Sim.Componentes.Formularios
{
    partial class newFormPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newFormPDF));
            this.pagePreview = new PdfSharp.Forms.PagePreview();
            this.panel1 = new Sim.Componentes.Controles.cPanel(this.components);
            this.cButtonPrint = new Sim.Controles.cButtonColor(this.components);
            this.cButtonBCK = new Sim.Controles.cButtonColor(this.components);
            this.cButtonNXT = new Sim.Controles.cButtonColor(this.components);
            this.cBSecon = new Sim.Controles.cButtonColor(this.components);
            this.cBPrim = new Sim.Controles.cButtonColor(this.components);
            this.lblTotalPag = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagePreview
            // 
            this.pagePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagePreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pagePreview.DesktopColor = System.Drawing.SystemColors.ControlDark;
            this.pagePreview.Location = new System.Drawing.Point(9, 29);
            this.pagePreview.Name = "pagePreview";
            this.pagePreview.PageColor = System.Drawing.Color.GhostWhite;
            this.pagePreview.PageSize = ((PdfSharp.Drawing.XSize)(resources.GetObject("pagePreview.PageSize")));
            this.pagePreview.PageSizeF = new System.Drawing.Size(595, 842);
            this.pagePreview.Size = new System.Drawing.Size(401, 550);
            this.pagePreview.TabIndex = 5;
            this.pagePreview.ZoomPercent = 46;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Borda = true;
            this.panel1.Controls.Add(this.cButtonPrint);
            this.panel1.Controls.Add(this.cButtonBCK);
            this.panel1.Controls.Add(this.cButtonNXT);
            this.panel1.Controls.Add(this.cBSecon);
            this.panel1.Controls.Add(this.cBPrim);
            this.panel1.Controls.Add(this.lblTotalPag);
            this.panel1.Location = new System.Drawing.Point(81, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 31);
            this.panel1.TabIndex = 10;
            // 
            // cButtonPrint
            // 
            this.cButtonPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cButtonPrint.Borda = System.Drawing.SystemColors.ControlDark;
            this.cButtonPrint.cCorPress = System.Drawing.Color.WhiteSmoke;
            this.cButtonPrint.CorFinal = System.Drawing.Color.Gainsboro;
            this.cButtonPrint.CorFont = System.Drawing.Color.Black;
            this.cButtonPrint.CorInicial = System.Drawing.Color.White;
            this.cButtonPrint.CorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cButtonPrint.CorPress = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.cButtonPrint.CorSombra = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cButtonPrint.Location = new System.Drawing.Point(174, 3);
            this.cButtonPrint.Name = "cButtonPrint";
            this.cButtonPrint.Size = new System.Drawing.Size(81, 25);
            this.cButtonPrint.TabIndex = 9;
            this.cButtonPrint.Text = "Imprimir";
            this.cButtonPrint.UseVisualStyleBackColor = true;
            // 
            // cButtonBCK
            // 
            this.cButtonBCK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cButtonBCK.Borda = System.Drawing.SystemColors.ControlDark;
            this.cButtonBCK.cCorPress = System.Drawing.Color.WhiteSmoke;
            this.cButtonBCK.CorFinal = System.Drawing.Color.Gainsboro;
            this.cButtonBCK.CorFont = System.Drawing.Color.Black;
            this.cButtonBCK.CorInicial = System.Drawing.Color.White;
            this.cButtonBCK.CorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cButtonBCK.CorPress = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.cButtonBCK.CorSombra = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cButtonBCK.Location = new System.Drawing.Point(32, 3);
            this.cButtonBCK.Name = "cButtonBCK";
            this.cButtonBCK.Size = new System.Drawing.Size(30, 25);
            this.cButtonBCK.TabIndex = 7;
            this.cButtonBCK.Text = "<";
            this.cButtonBCK.UseVisualStyleBackColor = true;
            // 
            // cButtonNXT
            // 
            this.cButtonNXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cButtonNXT.Borda = System.Drawing.SystemColors.ControlDark;
            this.cButtonNXT.cCorPress = System.Drawing.Color.WhiteSmoke;
            this.cButtonNXT.CorFinal = System.Drawing.Color.Gainsboro;
            this.cButtonNXT.CorFont = System.Drawing.Color.Black;
            this.cButtonNXT.CorInicial = System.Drawing.Color.White;
            this.cButtonNXT.CorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cButtonNXT.CorPress = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.cButtonNXT.CorSombra = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cButtonNXT.Location = new System.Drawing.Point(116, 3);
            this.cButtonNXT.Name = "cButtonNXT";
            this.cButtonNXT.Size = new System.Drawing.Size(30, 25);
            this.cButtonNXT.TabIndex = 8;
            this.cButtonNXT.Text = ">";
            this.cButtonNXT.UseVisualStyleBackColor = true;
            // 
            // cBSecon
            // 
            this.cBSecon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBSecon.Borda = System.Drawing.SystemColors.ControlDark;
            this.cBSecon.cCorPress = System.Drawing.Color.WhiteSmoke;
            this.cBSecon.CorFinal = System.Drawing.Color.Gainsboro;
            this.cBSecon.CorFont = System.Drawing.Color.Black;
            this.cBSecon.CorInicial = System.Drawing.Color.White;
            this.cBSecon.CorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cBSecon.CorPress = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.cBSecon.CorSombra = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cBSecon.Location = new System.Drawing.Point(145, 3);
            this.cBSecon.Name = "cBSecon";
            this.cBSecon.Size = new System.Drawing.Size(30, 25);
            this.cBSecon.TabIndex = 2;
            this.cBSecon.Text = ">>";
            this.cBSecon.UseVisualStyleBackColor = true;
            // 
            // cBPrim
            // 
            this.cBPrim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBPrim.Borda = System.Drawing.SystemColors.ControlDark;
            this.cBPrim.cCorPress = System.Drawing.Color.WhiteSmoke;
            this.cBPrim.CorFinal = System.Drawing.Color.Gainsboro;
            this.cBPrim.CorFont = System.Drawing.Color.Black;
            this.cBPrim.CorInicial = System.Drawing.Color.White;
            this.cBPrim.CorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cBPrim.CorPress = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.cBPrim.CorSombra = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cBPrim.Location = new System.Drawing.Point(3, 3);
            this.cBPrim.Name = "cBPrim";
            this.cBPrim.Size = new System.Drawing.Size(30, 25);
            this.cBPrim.TabIndex = 3;
            this.cBPrim.Text = "<<";
            this.cBPrim.UseVisualStyleBackColor = true;
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblTotalPag.Location = new System.Drawing.Point(61, 8);
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(56, 16);
            this.lblTotalPag.TabIndex = 6;
            this.lblTotalPag.Text = "0/0";
            this.lblTotalPag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newFormPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pagePreview);
            this.Name = "newFormPDF";
            this.Text = "newFormPDF";
            this.Shown += new System.EventHandler(this.newFormPDF_Shown);
            this.Controls.SetChildIndex(this.pagePreview, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PdfSharp.Forms.PagePreview pagePreview;
        private Controles.cPanel panel1;
        private Sim.Controles.cButtonColor cButtonPrint;
        private Sim.Controles.cButtonColor cButtonBCK;
        private Sim.Controles.cButtonColor cButtonNXT;
        private Sim.Controles.cButtonColor cBSecon;
        private Sim.Controles.cButtonColor cBPrim;
        private System.Windows.Forms.Label lblTotalPag;
    }
}