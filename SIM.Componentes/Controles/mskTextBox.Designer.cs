namespace Sim.Componentes.Controles
{
    partial class mskTextBox
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
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox.TabIndex = 0;
            this.maskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // mskTextBox
            // 
            this.Controls.Add(this.maskedTextBox);
            this.TabStop = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox;
    }
}
