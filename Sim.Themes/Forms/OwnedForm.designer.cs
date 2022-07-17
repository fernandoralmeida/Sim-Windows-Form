namespace Sim.Gui.Forms
{
    partial class OwnedForm
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
            this.panelT = new Sim.Gui.Controls.Panel(this.components);
            this.TLabel = new System.Windows.Forms.Label();
            this.cButtonWindowsMin = new Sim.Gui.Controls.ControlBox(this.components);
            this.cButtonWindowsEnd = new Sim.Gui.Controls.ControlBox(this.components);
            this.cButtonWindowsResMax = new Sim.Gui.Controls.ControlBox(this.components);
            this.panelT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelT
            // 
            this.panelT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelT.Borda = false;
            this.panelT.Controls.Add(this.TLabel);
            this.panelT.Controls.Add(this.cButtonWindowsMin);
            this.panelT.Controls.Add(this.cButtonWindowsEnd);
            this.panelT.Controls.Add(this.cButtonWindowsResMax);
            this.panelT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelT.Location = new System.Drawing.Point(0, 0);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(450, 25);
            this.panelT.TabIndex = 4;
            this.panelT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelT_Paint);
            this.panelT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelT_MouseDown);
            // 
            // TLabel
            // 
            this.TLabel.AutoSize = true;
            this.TLabel.BackColor = System.Drawing.Color.Transparent;
            this.TLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TLabel.Location = new System.Drawing.Point(5, 5);
            this.TLabel.Name = "TLabel";
            this.TLabel.Size = new System.Drawing.Size(91, 15);
            this.TLabel.TabIndex = 3;
            this.TLabel.Text = "SIM.MultForm";
            // 
            // cButtonWindowsMin
            // 
            this.cButtonWindowsMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonWindowsMin.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonWindowsMin.Location = new System.Drawing.Point(361, 1);
            this.cButtonWindowsMin.Name = "cButtonWindowsMin";
            this.cButtonWindowsMin.Size = new System.Drawing.Size(26, 22);
            this.cButtonWindowsMin.TabIndex = 2;
            this.cButtonWindowsMin.TabStop = false;
            this.cButtonWindowsMin.Text = "cButtonWindowsMin";
            this.cButtonWindowsMin.TypeControlBox = Sim.Gui.Controls.ControlBoxType.Minimize;
            this.cButtonWindowsMin.UseVisualStyleBackColor = false;
            this.cButtonWindowsMin.Click += new System.EventHandler(this.cButtonWindowsMin_Click);
            // 
            // cButtonWindowsEnd
            // 
            this.cButtonWindowsEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonWindowsEnd.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonWindowsEnd.Location = new System.Drawing.Point(419, 1);
            this.cButtonWindowsEnd.Name = "cButtonWindowsEnd";
            this.cButtonWindowsEnd.Size = new System.Drawing.Size(30, 22);
            this.cButtonWindowsEnd.TabIndex = 0;
            this.cButtonWindowsEnd.TabStop = false;
            this.cButtonWindowsEnd.Text = "cButtonWindowsEnd";
            this.cButtonWindowsEnd.TypeControlBox = Sim.Gui.Controls.ControlBoxType.EndOwned;
            this.cButtonWindowsEnd.UseVisualStyleBackColor = true;
            this.cButtonWindowsEnd.Click += new System.EventHandler(this.cButtonWindowsEnd_Click);
            // 
            // cButtonWindowsResMax
            // 
            this.cButtonWindowsResMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonWindowsResMax.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonWindowsResMax.Location = new System.Drawing.Point(390, 1);
            this.cButtonWindowsResMax.Name = "cButtonWindowsResMax";
            this.cButtonWindowsResMax.Size = new System.Drawing.Size(26, 22);
            this.cButtonWindowsResMax.TabIndex = 1;
            this.cButtonWindowsResMax.TabStop = false;
            this.cButtonWindowsResMax.Text = "cButtonWindowsResMax";
            this.cButtonWindowsResMax.TypeControlBox = Sim.Gui.Controls.ControlBoxType.Restore;
            this.cButtonWindowsResMax.UseVisualStyleBackColor = false;
            this.cButtonWindowsResMax.Click += new System.EventHandler(this.cButtonWindowsResMax_Click);
            // 
            // OwnedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.panelT);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnedForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "xFormChild";
            this.panelT.ResumeLayout(false);
            this.panelT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TLabel;
        private Controls.ControlBox cButtonWindowsEnd;
        private Controls.ControlBox cButtonWindowsMin;
        private Controls.ControlBox cButtonWindowsResMax;
        private Controls.Panel panelT;
    }
}