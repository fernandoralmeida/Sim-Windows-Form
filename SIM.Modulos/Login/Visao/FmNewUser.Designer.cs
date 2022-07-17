namespace Login.Visao
{
    partial class FmNewUser
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new Sim.Gui.Controls.GroupBox(this.components);
            this.cTextBoxEmail = new Sim.Gui.Controls.TextBox(this.components);
            this.cTextBoxNome = new Sim.Gui.Controls.TextBox(this.components);
            this.cTextBoxIdentificador = new Sim.Gui.Controls.TextBox(this.components);
            this.cComboBoxAcesso = new Sim.Gui.Controls.ComboBox(this.components);
            this.groupBox3 = new Sim.Gui.Controls.GroupBox(this.components);
            this.cButtonGravar = new Sim.Gui.Controls.Button(this.components);
            this.cButtonEnd = new Sim.Gui.Controls.Button(this.components);
            this.cGroupBox1 = new Sim.Gui.Controls.GroupBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cComboBoxM3 = new Sim.Gui.Controls.ComboBox(this.components);
            this.cComboBoxM2 = new Sim.Gui.Controls.ComboBox(this.components);
            this.cComboBoxM1 = new Sim.Gui.Controls.ComboBox(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.cGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(19, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Identificador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cTextBoxEmail);
            this.groupBox2.Controls.Add(this.cTextBoxNome);
            this.groupBox2.Controls.Add(this.cTextBoxIdentificador);
            this.groupBox2.Controls.Add(this.cComboBoxAcesso);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 233);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info. Usuário";
            this.groupBox2.TypeGroupBox = Sim.Gui.Controls.GroupBoxType.Window;
            // 
            // cTextBoxEmail
            // 
            this.cTextBoxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxEmail.CharacterCase = System.Windows.Forms.CharacterCasing.Lower;
            this.cTextBoxEmail.isLetter = false;
            this.cTextBoxEmail.isNumeric = false;
            this.cTextBoxEmail.isReadOnly = false;
            this.cTextBoxEmail.Location = new System.Drawing.Point(22, 137);
            this.cTextBoxEmail.Multiline = false;
            this.cTextBoxEmail.Name = "cTextBoxEmail";
            this.cTextBoxEmail.PsswChar = '\0';
            this.cTextBoxEmail.Size = new System.Drawing.Size(290, 25);
            this.cTextBoxEmail.TabIndex = 2;
            this.cTextBoxEmail.TabStop = false;
            // 
            // cTextBoxNome
            // 
            this.cTextBoxNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxNome.CharacterCase = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBoxNome.isLetter = false;
            this.cTextBoxNome.isNumeric = false;
            this.cTextBoxNome.isReadOnly = false;
            this.cTextBoxNome.Location = new System.Drawing.Point(20, 91);
            this.cTextBoxNome.Multiline = false;
            this.cTextBoxNome.Name = "cTextBoxNome";
            this.cTextBoxNome.PsswChar = '\0';
            this.cTextBoxNome.Size = new System.Drawing.Size(292, 25);
            this.cTextBoxNome.TabIndex = 1;
            this.cTextBoxNome.TabStop = false;
            // 
            // cTextBoxIdentificador
            // 
            this.cTextBoxIdentificador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxIdentificador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxIdentificador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxIdentificador.CharacterCase = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBoxIdentificador.isLetter = true;
            this.cTextBoxIdentificador.isNumeric = false;
            this.cTextBoxIdentificador.isReadOnly = false;
            this.cTextBoxIdentificador.Location = new System.Drawing.Point(20, 45);
            this.cTextBoxIdentificador.Multiline = false;
            this.cTextBoxIdentificador.Name = "cTextBoxIdentificador";
            this.cTextBoxIdentificador.PsswChar = '\0';
            this.cTextBoxIdentificador.Size = new System.Drawing.Size(292, 25);
            this.cTextBoxIdentificador.TabIndex = 0;
            this.cTextBoxIdentificador.TabStop = false;
            // 
            // cComboBoxAcesso
            // 
            this.cComboBoxAcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cComboBoxAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cComboBoxAcesso.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cComboBoxAcesso.Location = new System.Drawing.Point(20, 183);
            this.cComboBoxAcesso.Name = "cComboBoxAcesso";
            this.cComboBoxAcesso.SelectedIndex = -1;
            this.cComboBoxAcesso.SelectedItem = null;
            this.cComboBoxAcesso.Size = new System.Drawing.Size(292, 27);
            this.cComboBoxAcesso.TabIndex = 3;
            this.cComboBoxAcesso.Text = "...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cButtonGravar);
            this.groupBox3.Controls.Add(this.cButtonEnd);
            this.groupBox3.Location = new System.Drawing.Point(12, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 76);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comando";
            this.groupBox3.TypeGroupBox = Sim.Gui.Controls.GroupBoxType.Window;
            // 
            // cButtonGravar
            // 
            this.cButtonGravar.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonGravar.Location = new System.Drawing.Point(10, 27);
            this.cButtonGravar.Name = "cButtonGravar";
            this.cButtonGravar.Size = new System.Drawing.Size(206, 40);
            this.cButtonGravar.TabIndex = 0;
            this.cButtonGravar.Text = "Gravar";
            this.cButtonGravar.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonGravar.UseVisualStyleBackColor = true;
            this.cButtonGravar.Click += new System.EventHandler(this.cButtonGravar_Click);
            // 
            // cButtonEnd
            // 
            this.cButtonEnd.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonEnd.Location = new System.Drawing.Point(224, 27);
            this.cButtonEnd.Name = "cButtonEnd";
            this.cButtonEnd.Size = new System.Drawing.Size(116, 40);
            this.cButtonEnd.TabIndex = 1;
            this.cButtonEnd.Text = "Cancelar";
            this.cButtonEnd.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonEnd.UseVisualStyleBackColor = true;
            this.cButtonEnd.Click += new System.EventHandler(this.cButtonEnd_Click);
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.Controls.Add(this.label7);
            this.cGroupBox1.Controls.Add(this.label6);
            this.cGroupBox1.Controls.Add(this.label4);
            this.cGroupBox1.Controls.Add(this.cComboBoxM3);
            this.cGroupBox1.Controls.Add(this.cComboBoxM2);
            this.cGroupBox1.Controls.Add(this.cComboBoxM1);
            this.cGroupBox1.Location = new System.Drawing.Point(369, 30);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(256, 315);
            this.cGroupBox1.TabIndex = 5;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Acesso aos Modulos";
            this.cGroupBox1.TypeGroupBox = Sim.Gui.Controls.GroupBoxType.Window;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Convênios e Contratos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Portarias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Legislação";
            // 
            // cComboBoxM3
            // 
            this.cComboBoxM3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cComboBoxM3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cComboBoxM3.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cComboBoxM3.Location = new System.Drawing.Point(6, 140);
            this.cComboBoxM3.Name = "cComboBoxM3";
            this.cComboBoxM3.SelectedIndex = -1;
            this.cComboBoxM3.SelectedItem = null;
            this.cComboBoxM3.Size = new System.Drawing.Size(244, 27);
            this.cComboBoxM3.TabIndex = 6;
            this.cComboBoxM3.Text = "...";
            // 
            // cComboBoxM2
            // 
            this.cComboBoxM2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cComboBoxM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cComboBoxM2.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cComboBoxM2.Location = new System.Drawing.Point(6, 92);
            this.cComboBoxM2.Name = "cComboBoxM2";
            this.cComboBoxM2.SelectedIndex = -1;
            this.cComboBoxM2.SelectedItem = null;
            this.cComboBoxM2.Size = new System.Drawing.Size(244, 27);
            this.cComboBoxM2.TabIndex = 5;
            this.cComboBoxM2.Text = "...";
            // 
            // cComboBoxM1
            // 
            this.cComboBoxM1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cComboBoxM1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cComboBoxM1.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cComboBoxM1.Location = new System.Drawing.Point(6, 45);
            this.cComboBoxM1.Name = "cComboBoxM1";
            this.cComboBoxM1.SelectedIndex = -1;
            this.cComboBoxM1.SelectedItem = null;
            this.cComboBoxM1.Size = new System.Drawing.Size(244, 27);
            this.cComboBoxM1.TabIndex = 4;
            this.cComboBoxM1.Text = "...";
            // 
            // FmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(637, 357);
            this.Controls.Add(this.cGroupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmNewUser";
            this.Text = "FmNewUser";
            this.Load += new System.EventHandler(this.FmNewUser_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.cGroupBox1, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sim.Gui.Controls.Button cButtonEnd;
        private Sim.Gui.Controls.Button cButtonGravar;
        private Sim.Gui.Controls.GroupBox groupBox2;
        private Sim.Gui.Controls.GroupBox groupBox3;
        private Sim.Gui.Controls.TextBox cTextBoxEmail;
        private Sim.Gui.Controls.TextBox cTextBoxNome;
        private Sim.Gui.Controls.TextBox cTextBoxIdentificador;
        private Sim.Gui.Controls.ComboBox cComboBoxAcesso;
        private Sim.Gui.Controls.GroupBox cGroupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Sim.Gui.Controls.ComboBox cComboBoxM3;
        private Sim.Gui.Controls.ComboBox cComboBoxM2;
        private Sim.Gui.Controls.ComboBox cComboBoxM1;

    }
}