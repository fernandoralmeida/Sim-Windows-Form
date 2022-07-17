namespace Sim.Forms
{
    partial class xForm
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
            this.panelT = new System.Windows.Forms.Panel();
            this.TLabel = new System.Windows.Forms.Label();
            this.cButtonWindowsEnd = new Sim.Controles.cButtonWindows(this.components);
            this.cButtonWindowsMin = new Sim.Controles.cButtonWindows(this.components);
            this.cButtonWindowsResMax = new Sim.Controles.cButtonWindows(this.components);
            this.panelT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelT
            // 
            this.panelT.Controls.Add(this.TLabel);
            this.panelT.Controls.Add(this.cButtonWindowsEnd);
            this.panelT.Controls.Add(this.cButtonWindowsMin);
            this.panelT.Controls.Add(this.cButtonWindowsResMax);
            this.panelT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelT.Location = new System.Drawing.Point(0, 0);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(472, 24);
            this.panelT.TabIndex = 3;
            this.panelT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelT_Paint);
            this.panelT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelT_MouseDown);
            // 
            // TLabel
            // 
            this.TLabel.AutoSize = true;
            this.TLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabel.ForeColor = System.Drawing.Color.Black;
            this.TLabel.Location = new System.Drawing.Point(3, 4);
            this.TLabel.Name = "TLabel";
            this.TLabel.Size = new System.Drawing.Size(91, 15);
            this.TLabel.TabIndex = 3;
            this.TLabel.Text = "SIM.MultForm";
            // 
            // cButtonWindowsEnd
            // 
            this.cButtonWindowsEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonWindowsEnd.BackColor = System.Drawing.Color.White;
            this.cButtonWindowsEnd.Location = new System.Drawing.Point(418, 0);
            this.cButtonWindowsEnd.Name = "cButtonWindowsEnd";
            this.cButtonWindowsEnd.Size = new System.Drawing.Size(50, 20);
            this.cButtonWindowsEnd.TabIndex = 0;
            this.cButtonWindowsEnd.TabStop = false;
            this.cButtonWindowsEnd.Text = "cButtonWindows1";
            this.cButtonWindowsEnd.TypeButton = Sim.Controles.cButtonWindows.buttonType.endbutton;
            this.cButtonWindowsEnd.UseVisualStyleBackColor = true;
            this.cButtonWindowsEnd.Click += new System.EventHandler(this.cButtonWindowsEnd_Click);
            // 
            // cButtonWindowsMin
            // 
            this.cButtonWindowsMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonWindowsMin.Location = new System.Drawing.Point(358, 0);
            this.cButtonWindowsMin.Name = "cButtonWindowsMin";
            this.cButtonWindowsMin.Size = new System.Drawing.Size(30, 20);
            this.cButtonWindowsMin.TabIndex = 2;
            this.cButtonWindowsMin.TabStop = false;
            this.cButtonWindowsMin.Text = "cButtonWindows3";
            this.cButtonWindowsMin.TypeButton = Sim.Controles.cButtonWindows.buttonType.minbutton;
            this.cButtonWindowsMin.UseVisualStyleBackColor = false;
            this.cButtonWindowsMin.Click += new System.EventHandler(this.cButtonWindowsMin_Click);
            // 
            // cButtonWindowsResMax
            // 
            this.cButtonWindowsResMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonWindowsResMax.Location = new System.Drawing.Point(388, 0);
            this.cButtonWindowsResMax.Name = "cButtonWindowsResMax";
            this.cButtonWindowsResMax.Size = new System.Drawing.Size(30, 20);
            this.cButtonWindowsResMax.TabIndex = 1;
            this.cButtonWindowsResMax.TabStop = false;
            this.cButtonWindowsResMax.Text = "cButtonWindows2";
            this.cButtonWindowsResMax.TypeButton = Sim.Controles.cButtonWindows.buttonType.resbutton;
            this.cButtonWindowsResMax.UseVisualStyleBackColor = false;
            this.cButtonWindowsResMax.Click += new System.EventHandler(this.cButtonWindowsResMax_Click);
            // 
            // xForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 317);
            this.ControlBox = false;
            this.Controls.Add(this.panelT);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "xForm";
            this.Load += new System.EventHandler(this.xForm_Load);
            this.TextChanged += new System.EventHandler(this.xForm_TextChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.xForm_Paint);
            this.Resize += new System.EventHandler(this.xForm_Resize);
            this.panelT.ResumeLayout(false);
            this.panelT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelT;
        private Controles.cButtonWindows cButtonWindowsEnd;
        private Controles.cButtonWindows cButtonWindowsResMax;
        private Controles.cButtonWindows cButtonWindowsMin;
        private System.Windows.Forms.Label TLabel;

    }
}