namespace Sim.Desktop.Visao
{
    partial class FmLoad
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cProgressBar1 = new Gui.Controls.ProgressBar(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cProgressBar1
            // 
            this.cProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.cProgressBar1.Name = "cProgressBar1";
            this.cProgressBar1.PercentYN = false;
            this.cProgressBar1.Size = new System.Drawing.Size(100, 15);
            this.cProgressBar1.TabIndex = 1;
            this.cProgressBar1.Text = "cProgressBar1";
            this.cProgressBar1.Valor = 0;
            this.cProgressBar1.ValorMaximo = 100;
            this.cProgressBar1.ValorMinimo = 0;
            // 
            // FmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(125, 39);
            this.Controls.Add(this.cProgressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmLoad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmLoad";
            this.Load += new System.EventHandler(this.FmLoad_Load);
            this.Shown += new System.EventHandler(this.FmLoad_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Gui.Controls.ProgressBar cProgressBar1;
    }
}