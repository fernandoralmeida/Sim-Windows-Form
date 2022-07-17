namespace Sim.Desktop.Visao.Adm
{
    partial class FmLogIN
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
            this.txtUser = new Sim.Controles.cTextBox();
            this.bntExit = new Sim.Controles.cButton(this.components);
            this.bntLogOn = new Sim.Controles.cButton(this.components);
            this.txtPass = new Sim.Controles.cTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cButtonWindows2
            // 
            this.cButtonWindows2.BackColor = System.Drawing.Color.White;
            this.cButtonWindows2.UseVisualStyleBackColor = false;
            this.cButtonWindows2.Visible = false;
            // 
            // cButtonWindows1
            // 
            this.cButtonWindows1.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Formato = Sim.Controles.cTextBox.eFormato.Normal;
            this.txtUser.Location = new System.Drawing.Point(106, 67);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(215, 23);
            this.txtUser.TabIndex = 0;
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(259, 155);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(62, 30);
            this.bntExit.TabIndex = 3;
            this.bntExit.Text = "Sair";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // bntLogOn
            // 
            this.bntLogOn.Location = new System.Drawing.Point(106, 155);
            this.bntLogOn.Name = "bntLogOn";
            this.bntLogOn.Size = new System.Drawing.Size(154, 30);
            this.bntLogOn.TabIndex = 2;
            this.bntLogOn.Text = "Entrar";
            this.bntLogOn.UseVisualStyleBackColor = true;
            this.bntLogOn.Click += new System.EventHandler(this.bntLogOn_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Formato = Sim.Controles.cTextBox.eFormato.Normal;
            this.txtPass.Location = new System.Drawing.Point(106, 115);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(215, 23);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(104, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(104, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificador";
            // 
            // FmLogIN
            // 
            this.AcceptButton = this.bntLogOn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 210);
            this.ControlBox = false;
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.bntLogOn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(350, 210);
            this.MinimumSize = new System.Drawing.Size(350, 210);
            this.Name = "FmLogIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmLogOnOff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmLogIN_FormClosed);
            this.Load += new System.EventHandler(this.FmLogOnOff_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FmLogOnOff_Paint);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPass, 0);
            this.Controls.SetChildIndex(this.bntLogOn, 0);
            this.Controls.SetChildIndex(this.txtUser, 0);
            this.Controls.SetChildIndex(this.bntExit, 0);
            this.Controls.SetChildIndex(this.cButtonWindows1, 0);
            this.Controls.SetChildIndex(this.cButtonWindows2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sim.Controles.cButton bntLogOn;
        private Sim.Controles.cButton bntExit;
        private Sim.Controles.cTextBox txtPass;
        private Sim.Controles.cTextBox txtUser;
    }
}