namespace Sim.Gui.Forms
{
    partial class OwnerForm
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
            this.ControlBoxEnd = new Sim.Gui.Controls.ControlBox(this.components);
            this.ControlBoxMin = new Sim.Gui.Controls.ControlBox(this.components);
            this.ControlBoxMax = new Sim.Gui.Controls.ControlBox(this.components);
            this.panelT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelT
            // 
            this.panelT.Controls.Add(this.TLabel);
            this.panelT.Controls.Add(this.ControlBoxEnd);
            this.panelT.Controls.Add(this.ControlBoxMin);
            this.panelT.Controls.Add(this.ControlBoxMax);
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
            this.TLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabel.ForeColor = System.Drawing.Color.Black;
            this.TLabel.Location = new System.Drawing.Point(3, 4);
            this.TLabel.Name = "TLabel";
            this.TLabel.Size = new System.Drawing.Size(91, 15);
            this.TLabel.TabIndex = 3;
            this.TLabel.Text = "SIM.MultForm";
            // 
            // ControlBoxEnd
            // 
            this.ControlBoxEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxEnd.BackColor = System.Drawing.Color.White;
            this.ControlBoxEnd.InFocus = Sim.Gui.Controls.FocusType.No;
            this.ControlBoxEnd.Location = new System.Drawing.Point(435, 0);
            this.ControlBoxEnd.Name = "ControlBoxEnd";
            this.ControlBoxEnd.Size = new System.Drawing.Size(36, 22);
            this.ControlBoxEnd.TabIndex = 0;
            this.ControlBoxEnd.TabStop = false;
            this.ControlBoxEnd.Text = "cButtonWindows1";
            this.ControlBoxEnd.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.ControlBoxEnd.UseVisualStyleBackColor = true;
            this.ControlBoxEnd.Click += new System.EventHandler(this.cButtonWindowsEnd_Click);
            // 
            // ControlBoxMin
            // 
            this.ControlBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxMin.InFocus = Sim.Gui.Controls.FocusType.No;
            this.ControlBoxMin.Location = new System.Drawing.Point(373, 0);
            this.ControlBoxMin.Name = "ControlBoxMin";
            this.ControlBoxMin.Size = new System.Drawing.Size(30, 22);
            this.ControlBoxMin.TabIndex = 2;
            this.ControlBoxMin.TabStop = false;
            this.ControlBoxMin.Text = "cButtonWindows3";
            this.ControlBoxMin.TypeControlBox = Sim.Gui.Controls.ControlBoxType.Minimize;
            this.ControlBoxMin.UseVisualStyleBackColor = false;
            this.ControlBoxMin.Click += new System.EventHandler(this.cButtonWindowsMin_Click);
            // 
            // ControlBoxMax
            // 
            this.ControlBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxMax.InFocus = Sim.Gui.Controls.FocusType.No;
            this.ControlBoxMax.Location = new System.Drawing.Point(404, 0);
            this.ControlBoxMax.Name = "ControlBoxMax";
            this.ControlBoxMax.Size = new System.Drawing.Size(30, 22);
            this.ControlBoxMax.TabIndex = 1;
            this.ControlBoxMax.TabStop = false;
            this.ControlBoxMax.Text = "cButtonWindows2";
            this.ControlBoxMax.TypeControlBox = Sim.Gui.Controls.ControlBoxType.Restore;
            this.ControlBoxMax.UseVisualStyleBackColor = false;
            this.ControlBoxMax.Click += new System.EventHandler(this.cButtonWindowsResMax_Click);
            // 
            // OwnerForm
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
            this.Name = "OwnerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "xForm";
            this.panelT.ResumeLayout(false);
            this.panelT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sim.Gui.Controls.Panel panelT;
        private Controls.ControlBox ControlBoxEnd;
        private Controls.ControlBox ControlBoxMax;
        private Controls.ControlBox ControlBoxMin;
        private System.Windows.Forms.Label TLabel;

    }
}