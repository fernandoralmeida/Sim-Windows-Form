namespace Sim.Forms
{
    partial class cForm
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
            this.components = new System.ComponentModel.Container();
            this.FormTitulo = new System.Windows.Forms.Label();
            this.cButtonWindows2 = new Sim.Controles.cButtonWindows(this.components);
            this.cButtonWindows1 = new Sim.Controles.cButtonWindows(this.components);
            this.SuspendLayout();
            // 
            // FormTitulo
            // 
            this.FormTitulo.AutoSize = true;
            this.FormTitulo.BackColor = System.Drawing.Color.Transparent;
            this.FormTitulo.Location = new System.Drawing.Point(75, 6);
            this.FormTitulo.Name = "FormTitulo";
            this.FormTitulo.Size = new System.Drawing.Size(91, 15);
            this.FormTitulo.TabIndex = 1;
            this.FormTitulo.Text = "SIM.MultForm";
            // 
            // cButtonWindows2
            // 
            this.cButtonWindows2.Location = new System.Drawing.Point(35, 0);
            this.cButtonWindows2.Name = "cButtonWindows2";
            this.cButtonWindows2.Size = new System.Drawing.Size(25, 23);
            this.cButtonWindows2.TabIndex = 3;
            this.cButtonWindows2.Text = "cButtonWindows2";
            this.cButtonWindows2.TypeButton = Sim.Controles.cButtonWindows.buttonType.minbutton;
            this.cButtonWindows2.UseVisualStyleBackColor = true;
            // 
            // cButtonWindows1
            // 
            this.cButtonWindows1.Location = new System.Drawing.Point(0, 0);
            this.cButtonWindows1.Name = "cButtonWindows1";
            this.cButtonWindows1.Size = new System.Drawing.Size(35, 23);
            this.cButtonWindows1.TabIndex = 2;
            this.cButtonWindows1.Text = "cButtonWindows1";
            this.cButtonWindows1.TypeButton = Sim.Controles.cButtonWindows.buttonType.endbutton;
            this.cButtonWindows1.UseVisualStyleBackColor = true;
            // 
            // cForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.cButtonWindows2);
            this.Controls.Add(this.cButtonWindows1);
            this.Controls.Add(this.FormTitulo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.cForm_Load);
            this.TextChanged += new System.EventHandler(this.cForm_TextChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.cForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Controles.cButtonWindows cButtonWindows2;
        public Controles.cButtonWindows cButtonWindows1;
        private System.Windows.Forms.Label FormTitulo;
    }
}
