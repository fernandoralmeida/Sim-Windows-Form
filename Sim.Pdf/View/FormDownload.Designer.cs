namespace Sim.Pdf.View
{
    partial class FormDownload
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
            this.progressBar1 = new Sim.Gui.Controls.ProgressBar(this.components);
            this.label1 = new Sim.Gui.Controls.Label(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 113);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.PercentYN = false;
            this.progressBar1.Size = new System.Drawing.Size(356, 15);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Text = "progressBar1";
            this.progressBar1.Valor = 0;
            this.progressBar1.ValorMaximo = 100;
            this.progressBar1.ValorMinimo = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Downloading...";
            // 
            // FormDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDownload";
            this.Text = "FormDownload";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDownload_FormClosing);
            this.Shown += new System.EventHandler(this.FormDownload_Shown);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gui.Controls.ProgressBar progressBar1;
        private Gui.Controls.Label label1;
    }
}