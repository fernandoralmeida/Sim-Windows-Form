namespace Sim.Componentes.Formularios
{
    partial class xFormChild
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
            this.panelT.Size = new System.Drawing.Size(466, 24);
            this.panelT.TabIndex = 4;
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
            this.cButtonWindowsEnd.Location = new System.Drawing.Point(440, 1);
            this.cButtonWindowsEnd.Name = "cButtonWindowsEnd";
            this.cButtonWindowsEnd.Size = new System.Drawing.Size(25, 22);
            this.cButtonWindowsEnd.TabIndex = 0;
            this.cButtonWindowsEnd.TabStop = false;
            this.cButtonWindowsEnd.Text = "cButtonWindowsEnd";
            this.cButtonWindowsEnd.TypeButton = Sim.Controles.cButtonWindows.buttonType.endbuttonchild;
            this.cButtonWindowsEnd.UseVisualStyleBackColor = true;
            this.cButtonWindowsEnd.Click += new System.EventHandler(this.cButtonWindowsEnd_Click);
            // 
            // cButtonWindowsMin
            // 
            this.cButtonWindowsMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonWindowsMin.Location = new System.Drawing.Point(388, 1);
            this.cButtonWindowsMin.Name = "cButtonWindowsMin";
            this.cButtonWindowsMin.Size = new System.Drawing.Size(25, 22);
            this.cButtonWindowsMin.TabIndex = 2;
            this.cButtonWindowsMin.TabStop = false;
            this.cButtonWindowsMin.Text = "cButtonWindowsMin";
            this.cButtonWindowsMin.TypeButton = Sim.Controles.cButtonWindows.buttonType.minbutton;
            this.cButtonWindowsMin.UseVisualStyleBackColor = false;
            this.cButtonWindowsMin.Click += new System.EventHandler(this.cButtonWindowsMin_Click);
            // 
            // cButtonWindowsResMax
            // 
            this.cButtonWindowsResMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonWindowsResMax.Location = new System.Drawing.Point(414, 1);
            this.cButtonWindowsResMax.Name = "cButtonWindowsResMax";
            this.cButtonWindowsResMax.Size = new System.Drawing.Size(25, 22);
            this.cButtonWindowsResMax.TabIndex = 1;
            this.cButtonWindowsResMax.TabStop = false;
            this.cButtonWindowsResMax.Text = "cButtonWindowsResMax";
            this.cButtonWindowsResMax.TypeButton = Sim.Controles.cButtonWindows.buttonType.resbutton;
            this.cButtonWindowsResMax.UseVisualStyleBackColor = false;
            this.cButtonWindowsResMax.Click += new System.EventHandler(this.cButtonWindowsResMax_Click);
            // 
            // xFormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 317);
            this.Controls.Add(this.panelT);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xFormChild";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "xFormChild";
            this.Load += new System.EventHandler(this.xFormChild_Load);
            this.TextChanged += new System.EventHandler(this.xFormChild_TextChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.xFormChild_Paint);
            this.panelT.ResumeLayout(false);
            this.panelT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelT;
        private System.Windows.Forms.Label TLabel;
        private Sim.Controles.cButtonWindows cButtonWindowsEnd;
        private Sim.Controles.cButtonWindows cButtonWindowsMin;
        private Sim.Controles.cButtonWindows cButtonWindowsResMax;
    }
}