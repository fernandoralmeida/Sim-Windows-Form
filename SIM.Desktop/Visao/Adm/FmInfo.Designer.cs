namespace Sim.Desktop.Visao.Adm
{
    partial class FmInfo
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
            this.labelI = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.timerP = new System.Windows.Forms.Timer(this.components);
            this.FileBox = new System.Windows.Forms.ListBox();
            this.groupBoxM = new System.Windows.Forms.GroupBox();
            this.timerM = new System.Windows.Forms.Timer(this.components);
            this.groupBoxM.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.ForeColor = System.Drawing.Color.Gray;
            this.labelI.Location = new System.Drawing.Point(12, 10);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(28, 14);
            this.labelI.TabIndex = 15;
            this.labelI.Text = "...";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.ForeColor = System.Drawing.Color.Gray;
            this.labelM.Location = new System.Drawing.Point(12, 43);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(28, 14);
            this.labelM.TabIndex = 16;
            this.labelM.Text = "...";
            // 
            // timerP
            // 
            this.timerP.Enabled = true;
            this.timerP.Tick += new System.EventHandler(this.timerP_Tick);
            // 
            // FileBox
            // 
            this.FileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.FileBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileBox.ForeColor = System.Drawing.Color.DimGray;
            this.FileBox.FormattingEnabled = true;
            this.FileBox.ItemHeight = 14;
            this.FileBox.Location = new System.Drawing.Point(15, 24);
            this.FileBox.Name = "FileBox";
            this.FileBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.FileBox.Size = new System.Drawing.Size(293, 56);
            this.FileBox.TabIndex = 17;
            // 
            // groupBoxM
            // 
            this.groupBoxM.Controls.Add(this.FileBox);
            this.groupBoxM.ForeColor = System.Drawing.Color.Gray;
            this.groupBoxM.Location = new System.Drawing.Point(2, 146);
            this.groupBoxM.Name = "groupBoxM";
            this.groupBoxM.Size = new System.Drawing.Size(322, 94);
            this.groupBoxM.TabIndex = 18;
            this.groupBoxM.TabStop = false;
            this.groupBoxM.Text = "Modulos Instalados";
            // 
            // FmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(327, 244);
            this.Controls.Add(this.groupBoxM);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.labelM);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmInfo";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FmInfo";
            this.Load += new System.EventHandler(this.FmInfo_Load);
            this.Shown += new System.EventHandler(this.FmInfo_Shown);
            this.groupBoxM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Timer timerP;
        private System.Windows.Forms.ListBox FileBox;
        private System.Windows.Forms.GroupBox groupBoxM;
        private System.Windows.Forms.Timer timerM;
    }
}