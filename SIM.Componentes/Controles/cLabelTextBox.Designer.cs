namespace Sim.Controles
{
    partial class cLabelTextBox
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 13);
            this.textBox.TabIndex = 0;
            //this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBox_KeyPress);
            //this.textBox.TextChanged += new System.EventHandler(textBox_TextChanged);
            // 
            // cLabelTextBox
            // 
            this.Controls.Add(this.textBox);
            this.TabStop = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.TextBox textBox;

    }
}
