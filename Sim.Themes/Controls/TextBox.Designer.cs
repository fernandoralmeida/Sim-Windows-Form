namespace Sim.Gui.Controls
{
    partial class TextBox
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

            SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);

            this.itextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itextBox
            // 
            this.itextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.itextBox.Location = new System.Drawing.Point(0, 0);
            this.itextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itextBox.Name = "itextBox";
            this.itextBox.Size = new System.Drawing.Size(100, 20);
            this.itextBox.TabIndex = 0;
            this.itextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(itextBox_KeyPress);
            //
            //
            //
            this.Controls.Add(this.itextBox);
            this.TabStop = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itextBox;
    }
}
