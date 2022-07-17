namespace Sim.Portarias.Visao
{
    partial class FmConsultar
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
            this.panelTop = new Gui.Controls.Panel(this.components);
            this.cTextBoxKeyword = new Gui.Controls.TextBox(this.components);
            this.cTextBoxServidor = new Gui.Controls.TextBox(this.components);
            this.cTextBoxAno = new Gui.Controls.TextBox(this.components);
            this.cTextBoxNumero = new Gui.Controls.TextBox(this.components);
            this.comboBoxClass = new Gui.Controls.ComboBox(this.components);
            this.cButtonClear = new Gui.Controls.Button(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cButtonProcurar = new Gui.Controls.Button(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SegundoPlano = new System.ComponentModel.BackgroundWorker();
            this.elementHost = new System.Windows.Forms.Integration.ElementHost();
            this.dataGridPortarias = new Sim.Portarias.Visao.DataGridPortarias();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTop.Borda = false;
            this.panelTop.Controls.Add(this.cTextBoxKeyword);
            this.panelTop.Controls.Add(this.cTextBoxServidor);
            this.panelTop.Controls.Add(this.cTextBoxAno);
            this.panelTop.Controls.Add(this.cTextBoxNumero);
            this.panelTop.Controls.Add(this.comboBoxClass);
            this.panelTop.Controls.Add(this.cButtonClear);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.cButtonProcurar);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Location = new System.Drawing.Point(9, 26);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 80);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // cTextBoxKeyword
            // 
            this.cTextBoxKeyword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxKeyword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxKeyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cTextBoxKeyword.CharacterCase = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBoxKeyword.isLetter = false;
            this.cTextBoxKeyword.isNumeric = false;
            this.cTextBoxKeyword.isReadOnly = false;
            this.cTextBoxKeyword.Location = new System.Drawing.Point(73, 50);
            this.cTextBoxKeyword.Multiline = false;
            this.cTextBoxKeyword.Name = "cTextBoxKeyword";
            this.cTextBoxKeyword.PsswChar = '\0';
            this.cTextBoxKeyword.Size = new System.Drawing.Size(585, 26);
            this.cTextBoxKeyword.TabIndex = 4;
            this.cTextBoxKeyword.TabStop = false;
            // 
            // cTextBoxServidor
            // 
            this.cTextBoxServidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxServidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cTextBoxServidor.CharacterCase = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBoxServidor.isLetter = false;
            this.cTextBoxServidor.isNumeric = false;
            this.cTextBoxServidor.isReadOnly = false;
            this.cTextBoxServidor.Location = new System.Drawing.Point(345, 23);
            this.cTextBoxServidor.Multiline = false;
            this.cTextBoxServidor.Name = "cTextBoxServidor";
            this.cTextBoxServidor.PsswChar = '\0';
            this.cTextBoxServidor.Size = new System.Drawing.Size(313, 26);
            this.cTextBoxServidor.TabIndex = 3;
            this.cTextBoxServidor.TabStop = false;
            this.cTextBoxServidor.TextChanged += new System.EventHandler(this.cTextBoxServidor_TextChanged);
            // 
            // cTextBoxAno
            // 
            this.cTextBoxAno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxAno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cTextBoxAno.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.cTextBoxAno.isLetter = false;
            this.cTextBoxAno.isNumeric = true;
            this.cTextBoxAno.isReadOnly = false;
            this.cTextBoxAno.Location = new System.Drawing.Point(296, 23);
            this.cTextBoxAno.Multiline = false;
            this.cTextBoxAno.Name = "cTextBoxAno";
            this.cTextBoxAno.PsswChar = '\0';
            this.cTextBoxAno.Size = new System.Drawing.Size(48, 26);
            this.cTextBoxAno.TabIndex = 2;
            this.cTextBoxAno.TabStop = false;
            // 
            // cTextBoxNumero
            // 
            this.cTextBoxNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cTextBoxNumero.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.cTextBoxNumero.isLetter = false;
            this.cTextBoxNumero.isNumeric = true;
            this.cTextBoxNumero.isReadOnly = false;
            this.cTextBoxNumero.Location = new System.Drawing.Point(222, 23);
            this.cTextBoxNumero.Multiline = false;
            this.cTextBoxNumero.Name = "cTextBoxNumero";
            this.cTextBoxNumero.PsswChar = '\0';
            this.cTextBoxNumero.Size = new System.Drawing.Size(73, 26);
            this.cTextBoxNumero.TabIndex = 1;
            this.cTextBoxNumero.TabStop = false;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.Location = new System.Drawing.Point(11, 23);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.SelectedIndex = -1;
            this.comboBoxClass.SelectedItem = null;
            this.comboBoxClass.Size = new System.Drawing.Size(210, 26);
            this.comboBoxClass.TabIndex = 0;
            this.comboBoxClass.Text = "...";
            // 
            // cButtonClear
            // 
            this.cButtonClear.Location = new System.Drawing.Point(738, 23);
            this.cButtonClear.Name = "cButtonClear";
            this.cButtonClear.Size = new System.Drawing.Size(49, 53);
            this.cButtonClear.TabIndex = 6;
            this.cButtonClear.Text = "X";
            this.cButtonClear.UseVisualStyleBackColor = true;
            this.cButtonClear.Click += new System.EventHandler(this.cButtonClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label5.Location = new System.Drawing.Point(11, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Resumo";
            // 
            // cButtonProcurar
            // 
            this.cButtonProcurar.Location = new System.Drawing.Point(659, 23);
            this.cButtonProcurar.Name = "cButtonProcurar";
            this.cButtonProcurar.Size = new System.Drawing.Size(79, 53);
            this.cButtonProcurar.TabIndex = 5;
            this.cButtonProcurar.Text = "Buscar";
            this.cButtonProcurar.UseVisualStyleBackColor = true;
            this.cButtonProcurar.Click += new System.EventHandler(this.cButtonProcurar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label4.Location = new System.Drawing.Point(349, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Servidor/Empregado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label3.Location = new System.Drawing.Point(298, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label2.Location = new System.Drawing.Point(222, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Classificação";
            // 
            // SegundoPlano
            // 
            this.SegundoPlano.WorkerReportsProgress = true;
            this.SegundoPlano.WorkerSupportsCancellation = true;
            this.SegundoPlano.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SegundoPlano_DoWork);
            this.SegundoPlano.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SegundoPlano_ProgressChanged);
            this.SegundoPlano.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SegundoPlano_RunWorkerCompleted);
            // 
            // elementHost
            // 
            this.elementHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost.Location = new System.Drawing.Point(9, 108);
            this.elementHost.Name = "elementHost";
            this.elementHost.Size = new System.Drawing.Size(800, 482);
            this.elementHost.TabIndex = 5;
            this.elementHost.Text = "elementHost1";
            this.elementHost.Child = this.dataGridPortarias;
            // 
            // FmConsultar
            // 
            this.AcceptButton = this.cButtonProcurar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 600);
            this.Controls.Add(this.elementHost);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(776, 600);
            this.Name = "FmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmConsultar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmConsultar_FormClosed);
            this.Load += new System.EventHandler(this.FmConsultar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FmConsultar_Paint);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.elementHost, 0);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gui.Controls.Panel panelTop;
        private System.Windows.Forms.Label label5;
        private Gui.Controls.Button cButtonProcurar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Gui.Controls.Button cButtonClear;
        private System.ComponentModel.BackgroundWorker SegundoPlano;
        private Gui.Controls.ComboBox comboBoxClass;
        private Gui.Controls.TextBox cTextBoxNumero;
        private Gui.Controls.TextBox cTextBoxServidor;
        private Gui.Controls.TextBox cTextBoxAno;
        private Gui.Controls.TextBox cTextBoxKeyword;
        private System.Windows.Forms.Integration.ElementHost elementHost;
        private DataGridPortarias dataGridPortarias;
    }
}