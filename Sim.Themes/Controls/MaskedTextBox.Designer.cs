namespace Sim.Gui.Controls
{
    partial class MaskedTextBox
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
            this.imaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // imaskedTextBox
            // 
            this.imaskedTextBox.Location = new System.Drawing.Point(0, 0);
            this.imaskedTextBox.Name = "imaskedTextBox";
            this.imaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.imaskedTextBox.TabIndex = 0;
            this.imaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResumeLayout(false);
            //
            //
            //
            this.Controls.Add(this.imaskedTextBox);
            this.TabStop = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox imaskedTextBox;
    }
}
