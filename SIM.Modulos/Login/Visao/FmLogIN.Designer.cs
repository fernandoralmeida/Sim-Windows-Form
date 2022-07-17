namespace Login.Visao
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
            this.bntExit = new Sim.Gui.Controls.Button(this.components);
            this.bntLogOn = new Sim.Gui.Controls.Button(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextUser = new Sim.Gui.Controls.TextBox(this.components);
            this.TextPssw = new Sim.Gui.Controls.TextBox(this.components);
            this.SuspendLayout();
            // 
            // bntExit
            // 
            this.bntExit.InFocus = Sim.Gui.Controls.FocusType.No;
            this.bntExit.Location = new System.Drawing.Point(276, 148);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(66, 30);
            this.bntExit.TabIndex = 3;
            this.bntExit.Text = "X";
            this.bntExit.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // bntLogOn
            // 
            this.bntLogOn.InFocus = Sim.Gui.Controls.FocusType.No;
            this.bntLogOn.Location = new System.Drawing.Point(134, 148);
            this.bntLogOn.Name = "bntLogOn";
            this.bntLogOn.Size = new System.Drawing.Size(136, 30);
            this.bntLogOn.TabIndex = 2;
            this.bntLogOn.Text = "Ok";
            this.bntLogOn.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.bntLogOn.UseVisualStyleBackColor = true;
            this.bntLogOn.Click += new System.EventHandler(this.bntLogOn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(131, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(131, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificador";
            // 
            // TextUser
            // 
            this.TextUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.TextUser.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.TextUser.isLetter = false;
            this.TextUser.isNumeric = false;
            this.TextUser.isReadOnly = false;
            this.TextUser.Location = new System.Drawing.Point(134, 63);
            this.TextUser.Multiline = false;
            this.TextUser.Name = "TextUser";
            this.TextUser.PsswChar = '\0';
            this.TextUser.Size = new System.Drawing.Size(208, 30);
            this.TextUser.TabIndex = 0;
            this.TextUser.TabStop = false;
            // 
            // TextPssw
            // 
            this.TextPssw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextPssw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextPssw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.TextPssw.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.TextPssw.isLetter = false;
            this.TextPssw.isNumeric = false;
            this.TextPssw.isReadOnly = false;
            this.TextPssw.Location = new System.Drawing.Point(134, 112);
            this.TextPssw.Multiline = false;
            this.TextPssw.Name = "TextPssw";
            this.TextPssw.PsswChar = '*';
            this.TextPssw.Size = new System.Drawing.Size(208, 30);
            this.TextPssw.TabIndex = 1;
            this.TextPssw.TabStop = false;
            // 
            // FmLogIN
            // 
            this.AcceptButton = this.bntLogOn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(372, 210);
            this.ControlBox = false;
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntLogOn);
            this.Controls.Add(this.TextPssw);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(0, 210);
            this.Name = "FmLogIN";
            this.SideColor = true;
            this.Text = "FmLogOnOff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmLogIN_FormClosed);
            this.Load += new System.EventHandler(this.FmLogOnOff_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FmLogOnOff_Paint);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TextUser, 0);
            this.Controls.SetChildIndex(this.TextPssw, 0);
            this.Controls.SetChildIndex(this.bntLogOn, 0);
            this.Controls.SetChildIndex(this.bntExit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sim.Gui.Controls.Button bntLogOn;
        private Sim.Gui.Controls.Button bntExit;
        private Sim.Gui.Controls.TextBox TextUser;
        private Sim.Gui.Controls.TextBox TextPssw;
    }
}