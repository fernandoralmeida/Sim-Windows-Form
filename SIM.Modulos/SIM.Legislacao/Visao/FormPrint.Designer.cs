namespace Sim.Legislacao.Visao
{
    partial class FormPrint
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
            this.buttonPrint = new Sim.Gui.Controls.Button(this.components);
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.buttonF = new Sim.Gui.Controls.Button(this.components);
            this.buttonP = new Sim.Gui.Controls.Button(this.components);
            this.buttonN = new Sim.Gui.Controls.Button(this.components);
            this.buttonL = new Sim.Gui.Controls.Button(this.components);
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonPrint.Location = new System.Drawing.Point(330, 31);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(85, 23);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Imprimir";
            this.buttonPrint.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Location = new System.Drawing.Point(1, 59);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(419, 592);
            this.printPreviewControl1.TabIndex = 7;
            this.printPreviewControl1.UseAntiAlias = true;
            this.printPreviewControl1.Zoom = 0.5D;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            // 
            // buttonF
            // 
            this.buttonF.Enabled = false;
            this.buttonF.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonF.Location = new System.Drawing.Point(6, 30);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(34, 23);
            this.buttonF.TabIndex = 8;
            this.buttonF.Text = "<<";
            this.buttonF.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // buttonP
            // 
            this.buttonP.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonP.Location = new System.Drawing.Point(41, 30);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(35, 23);
            this.buttonP.TabIndex = 9;
            this.buttonP.Text = "<";
            this.buttonP.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonN
            // 
            this.buttonN.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonN.Location = new System.Drawing.Point(77, 30);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(35, 23);
            this.buttonN.TabIndex = 10;
            this.buttonN.Text = ">";
            this.buttonN.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonL
            // 
            this.buttonL.Enabled = false;
            this.buttonL.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonL.Location = new System.Drawing.Point(113, 30);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(36, 23);
            this.buttonL.TabIndex = 11;
            this.buttonL.Text = ">>";
            this.buttonL.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 652);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.buttonPrint);
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrint_FormClosed);
            this.Load += new System.EventHandler(this.FormPrint_Load);
            this.ResizeEnd += new System.EventHandler(this.FormPrint_ResizeEnd);
            this.Controls.SetChildIndex(this.buttonPrint, 0);
            this.Controls.SetChildIndex(this.printPreviewControl1, 0);
            this.Controls.SetChildIndex(this.buttonF, 0);
            this.Controls.SetChildIndex(this.buttonP, 0);
            this.Controls.SetChildIndex(this.buttonN, 0);
            this.Controls.SetChildIndex(this.buttonL, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Gui.Controls.Button buttonPrint;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Gui.Controls.Button buttonF;
        private Gui.Controls.Button buttonP;
        private Gui.Controls.Button buttonN;
        private Gui.Controls.Button buttonL;
    }
}