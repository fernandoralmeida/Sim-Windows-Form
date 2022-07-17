namespace Sim.Desktop.Visao.Adm
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
            this.cmbOutrosModulos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAcesso = new System.Windows.Forms.ComboBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNome = new Sim.Controles.cTextBox();
            this.txtMatricula = new Sim.Controles.cTextBox();
            this.txtEmail = new Sim.Controles.cTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cButtonGravar = new Sim.Controles.cButton(this.components);
            this.cButtonEnd = new Sim.Controles.cButton(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cButtonWindows2
            // 
            this.cButtonWindows2.BackColor = System.Drawing.Color.White;
            this.cButtonWindows2.Enabled = false;
            this.cButtonWindows2.UseVisualStyleBackColor = false;
            // 
            // cmbOutrosModulos
            // 
            this.cmbOutrosModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutrosModulos.FormattingEnabled = true;
            this.cmbOutrosModulos.Items.AddRange(new object[] {
            "Consulta",
            "Inclusão e Alteração",
            "Controle Total"});
            this.cmbOutrosModulos.Location = new System.Drawing.Point(184, 172);
            this.cmbOutrosModulos.Name = "cmbOutrosModulos";
            this.cmbOutrosModulos.Size = new System.Drawing.Size(250, 23);
            this.cmbOutrosModulos.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Acessar outros Modulos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nivel de Acesso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Modulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Identificador";
            // 
            // cmbAcesso
            // 
            this.cmbAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcesso.FormattingEnabled = true;
            this.cmbAcesso.Items.AddRange(new object[] {
            "Comum",
            "Intermediario",
            "Administrador",
            "Master"});
            this.cmbAcesso.Location = new System.Drawing.Point(142, 143);
            this.cmbAcesso.Name = "cmbAcesso";
            this.cmbAcesso.Size = new System.Drawing.Size(292, 23);
            this.cmbAcesso.TabIndex = 4;
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Items.AddRange(new object[] {
            "MPO - Modulo Portarias",
            "MLG - Modulo Leis e Decretos",
            "MCC - Modulo Contratos e Convênios"});
            this.cmbModulo.Location = new System.Drawing.Point(142, 114);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(292, 23);
            this.cmbModulo.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtMatricula);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.cmbOutrosModulos);
            this.groupBox2.Controls.Add(this.cmbModulo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbAcesso);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(71, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 214);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info. Usuário";
            // 
            // txtNome
            // 
            this.txtNome.Formato = Sim.Controles.cTextBox.eFormato.Normal;
            this.txtNome.Location = new System.Drawing.Point(142, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(292, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Formato = Sim.Controles.cTextBox.eFormato.Normal;
            this.txtMatricula.Location = new System.Drawing.Point(142, 27);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(292, 23);
            this.txtMatricula.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Formato = Sim.Controles.cTextBox.eFormato.Normal;
            this.txtEmail.Location = new System.Drawing.Point(142, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cButtonGravar);
            this.groupBox3.Controls.Add(this.cButtonEnd);
            this.groupBox3.Location = new System.Drawing.Point(71, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 76);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comando";
            // 
            // cButtonGravar
            // 
            this.cButtonGravar.Location = new System.Drawing.Point(142, 22);
            this.cButtonGravar.Name = "cButtonGravar";
            this.cButtonGravar.Size = new System.Drawing.Size(170, 40);
            this.cButtonGravar.TabIndex = 0;
            this.cButtonGravar.Text = "Gravar";
            this.cButtonGravar.UseVisualStyleBackColor = true;
            this.cButtonGravar.Click += new System.EventHandler(this.cButtonGravar_Click);
            // 
            // cButtonEnd
            // 
            this.cButtonEnd.Location = new System.Drawing.Point(318, 22);
            this.cButtonEnd.Name = "cButtonEnd";
            this.cButtonEnd.Size = new System.Drawing.Size(116, 40);
            this.cButtonEnd.TabIndex = 1;
            this.cButtonEnd.Text = "Cancelar";
            this.cButtonEnd.UseVisualStyleBackColor = true;
            this.cButtonEnd.Click += new System.EventHandler(this.cButtonEnd_Click);
            // 
            // FmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 340);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FmNewUser";
            this.Text = "FmNewUser";
            this.Load += new System.EventHandler(this.FmNewUser_Load);
            this.Controls.SetChildIndex(this.cButtonWindows1, 0);
            this.Controls.SetChildIndex(this.cButtonWindows2, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOutrosModulos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAcesso;
        private System.Windows.Forms.ComboBox cmbModulo;
        private Sim.Controles.cTextBox txtEmail;
        private Sim.Controles.cTextBox txtMatricula;
        private Sim.Controles.cTextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sim.Controles.cButton cButtonEnd;
        private Sim.Controles.cButton cButtonGravar;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}