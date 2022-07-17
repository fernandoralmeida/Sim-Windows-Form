namespace Sim.Forms.cPDFView
{
    partial class PDFViewer
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
            this.components = new System.ComponentModel.Container();
            this.PageNumeric = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new Sim.Componentes.Controles.cPanel(this.components);
            this.cButtonPrint = new Sim.Controles.cButtonColor(this.components);
            this.cButtonBCK = new Sim.Controles.cButtonColor(this.components);
            this.cButtonNXT = new Sim.Controles.cButtonColor(this.components);
            this.cBSecon = new Sim.Controles.cButtonColor(this.components);
            this.cBPrim = new Sim.Controles.cButtonColor(this.components);
            this.lblTotalPag = new System.Windows.Forms.Label();
            this.pageViewer1 = new Sim.Forms.cPDFView.PageViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageNumeric
            // 
            this.PageNumeric.AutoSize = true;
            this.PageNumeric.BackColor = System.Drawing.Color.White;
            this.PageNumeric.Location = new System.Drawing.Point(264, 6);
            this.PageNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageNumeric.Name = "PageNumeric";
            this.PageNumeric.Size = new System.Drawing.Size(64, 23);
            this.PageNumeric.TabIndex = 5;
            this.PageNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageNumeric.Visible = false;
            this.PageNumeric.ValueChanged += new System.EventHandler(this.PageNumeric_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.PageNumeric);
            this.panel2.Controls.Add(this.pageViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 485);
            this.panel2.TabIndex = 10;
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
            this.panel1.Location = new System.Drawing.Point(36, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 31);
            this.panel1.TabIndex = 9;
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
            this.cButtonPrint.Click += new System.EventHandler(this.cButtonPrint_Click);
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
            this.cButtonBCK.Click += new System.EventHandler(this.cButtonBCK_Click);
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
            this.cButtonNXT.Click += new System.EventHandler(this.cButtonNXT_Click);
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
            this.cBSecon.Click += new System.EventHandler(this.cBSecon_Click);
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
            this.cBPrim.Click += new System.EventHandler(this.cBPrim_Click);
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
            // pageViewer1
            // 
            this.pageViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pageViewer1.BorderColor = System.Drawing.Color.Black;
            this.pageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewer1.DrawBorder = false;
            this.pageViewer1.DrawShadow = true;
            this.pageViewer1.Location = new System.Drawing.Point(0, 0);
            this.pageViewer1.Margin = new System.Windows.Forms.Padding(12);
            this.pageViewer1.Name = "pageViewer1";
            this.pageViewer1.PageColor = System.Drawing.SystemColors.ButtonFace;
            this.pageViewer1.PageSize = new System.Drawing.Size(0, 0);
            this.pageViewer1.PaintMethod = Sim.Forms.cPDFView.PageViewer.DoubleBufferMethod.BuiltInOptimizedDoubleBuffer;
            this.pageViewer1.ScrollPosition = new System.Drawing.Point(-12, -12);
            this.pageViewer1.Size = new System.Drawing.Size(331, 485);
            this.pageViewer1.TabIndex = 0;
            this.pageViewer1.NextPage += new Sim.Forms.cPDFView.PageViewer.MovePageHandler(this.pageViewer1_NextPage);
            this.pageViewer1.PreviousPage += new Sim.Forms.cPDFView.PageViewer.MovePageHandler(this.pageViewer1_PreviousPage);
            this.pageViewer1.PaintControl += new Sim.Forms.cPDFView.PageViewer.PaintControlHandler(this.pageViewer1_PaintControl);
            // 
            // PDFViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PDFViewer";
            this.Size = new System.Drawing.Size(331, 485);
            this.Resize += new System.EventHandler(this.PDFViewer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PageNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private PageViewer pageViewer1;
        private Controles.cButtonColor cBSecon;
        private Controles.cButtonColor cBPrim;
        private System.Windows.Forms.NumericUpDown PageNumeric;
        private System.Windows.Forms.Label lblTotalPag;

        #endregion
        private Controles.cButtonColor cButtonBCK;
        private Controles.cButtonColor cButtonNXT;
        private Componentes.Controles.cPanel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controles.cButtonColor cButtonPrint;
    }
}
