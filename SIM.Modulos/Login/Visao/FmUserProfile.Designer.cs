namespace Login.Visao
{
    partial class FmUserProfile
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
            this.label12 = new System.Windows.Forms.Label();
            this.cButtonPssw = new Sim.Gui.Controls.Button(this.components);
            this.cButtonMail = new Sim.Gui.Controls.Button(this.components);
            this.txtMatricula = new Sim.Gui.Controls.TextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNPass = new Sim.Gui.Controls.TextBox(this.components);
            this.txtPass = new Sim.Gui.Controls.TextBox(this.components);
            this.txtEmail = new Sim.Gui.Controls.TextBox(this.components);
            this.txtNome = new Sim.Gui.Controls.TextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cGroupBoxUser = new Sim.Gui.Controls.GroupBox(this.components);
            this.cGroupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(11, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nome";
            // 
            // cButtonPssw
            // 
            this.cButtonPssw.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonPssw.Location = new System.Drawing.Point(14, 326);
            this.cButtonPssw.Name = "cButtonPssw";
            this.cButtonPssw.Size = new System.Drawing.Size(309, 33);
            this.cButtonPssw.TabIndex = 6;
            this.cButtonPssw.Text = "Alterar Senha";
            this.cButtonPssw.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonPssw.UseVisualStyleBackColor = true;
            this.cButtonPssw.Click += new System.EventHandler(this.cButtonPssw_Click);
            // 
            // cButtonMail
            // 
            this.cButtonMail.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonMail.Location = new System.Drawing.Point(14, 160);
            this.cButtonMail.Name = "cButtonMail";
            this.cButtonMail.Size = new System.Drawing.Size(309, 33);
            this.cButtonMail.TabIndex = 3;
            this.cButtonMail.Text = "Alterar Email";
            this.cButtonMail.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonMail.UseVisualStyleBackColor = true;
            this.cButtonMail.Click += new System.EventHandler(this.cButtonMail_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtMatricula.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatricula.isLetter = false;
            this.txtMatricula.isNumeric = false;
            this.txtMatricula.isReadOnly = true;
            this.txtMatricula.Location = new System.Drawing.Point(14, 37);
            this.txtMatricula.Multiline = false;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PsswChar = '\0';
            this.txtMatricula.Size = new System.Drawing.Size(309, 25);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(11, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Identificador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(11, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha Nova";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(11, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha Antiga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // txtNPass
            // 
            this.txtNPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNPass.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNPass.isLetter = false;
            this.txtNPass.isNumeric = false;
            this.txtNPass.isReadOnly = false;
            this.txtNPass.Location = new System.Drawing.Point(14, 295);
            this.txtNPass.Multiline = false;
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.PsswChar = '*';
            this.txtNPass.Size = new System.Drawing.Size(309, 25);
            this.txtNPass.TabIndex = 5;
            this.txtNPass.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtPass.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.isLetter = false;
            this.txtPass.isNumeric = false;
            this.txtPass.isReadOnly = false;
            this.txtPass.Location = new System.Drawing.Point(14, 249);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.PsswChar = '*';
            this.txtPass.Size = new System.Drawing.Size(309, 25);
            this.txtPass.TabIndex = 4;
            this.txtPass.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtEmail.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.isLetter = false;
            this.txtEmail.isNumeric = false;
            this.txtEmail.isReadOnly = false;
            this.txtEmail.Location = new System.Drawing.Point(14, 129);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PsswChar = '\0';
            this.txtEmail.Size = new System.Drawing.Size(309, 25);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNome.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.isLetter = false;
            this.txtNome.isNumeric = false;
            this.txtNome.isReadOnly = true;
            this.txtNome.Location = new System.Drawing.Point(14, 83);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.PsswChar = '\0';
            this.txtNome.Size = new System.Drawing.Size(309, 25);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // cGroupBoxUser
            // 
            this.cGroupBoxUser.Controls.Add(this.label5);
            this.cGroupBoxUser.Controls.Add(this.txtPass);
            this.cGroupBoxUser.Controls.Add(this.label12);
            this.cGroupBoxUser.Controls.Add(this.txtNPass);
            this.cGroupBoxUser.Controls.Add(this.txtEmail);
            this.cGroupBoxUser.Controls.Add(this.cButtonPssw);
            this.cGroupBoxUser.Controls.Add(this.label2);
            this.cGroupBoxUser.Controls.Add(this.txtNome);
            this.cGroupBoxUser.Controls.Add(this.cButtonMail);
            this.cGroupBoxUser.Controls.Add(this.label3);
            this.cGroupBoxUser.Controls.Add(this.txtMatricula);
            this.cGroupBoxUser.Controls.Add(this.label4);
            this.cGroupBoxUser.Location = new System.Drawing.Point(12, 30);
            this.cGroupBoxUser.Name = "cGroupBoxUser";
            this.cGroupBoxUser.Size = new System.Drawing.Size(336, 374);
            this.cGroupBoxUser.TabIndex = 20;
            this.cGroupBoxUser.TabStop = false;
            this.cGroupBoxUser.Text = "Informações Pessoais";
            this.cGroupBoxUser.TypeGroupBox = Sim.Gui.Controls.GroupBoxType.Window;
            // 
            // FmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(363, 420);
            this.Controls.Add(this.cGroupBoxUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmUserProfile";
            this.Text = "FmUserProfile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmUserProfile_FormClosed);
            this.Load += new System.EventHandler(this.FmUserProfile_Load);
            this.Shown += new System.EventHandler(this.FmUserProfile_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FmUserProfile_Paint);
            this.Controls.SetChildIndex(this.cGroupBoxUser, 0);
            this.cGroupBoxUser.ResumeLayout(false);
            this.cGroupBoxUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sim.Gui.Controls.TextBox txtMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sim.Gui.Controls.TextBox txtNPass;
        private Sim.Gui.Controls.TextBox txtPass;
        private Sim.Gui.Controls.TextBox txtEmail;
        private Sim.Gui.Controls.TextBox txtNome;
        private Sim.Gui.Controls.Button cButtonPssw;
        private Sim.Gui.Controls.Button cButtonMail;
        private System.Windows.Forms.Label label12;
        private Sim.Gui.Controls.GroupBox cGroupBoxUser;
    }
}