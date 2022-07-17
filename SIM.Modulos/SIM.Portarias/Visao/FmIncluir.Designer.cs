namespace Sim.Portarias.Visao
{
    partial class FmIncluir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cButtonGravar = new Gui.Controls.Button(this.components);
            this.groupBoxDoc = new Gui.Controls.GroupBox(this.components);
            this.cMaskTextBoxData = new Gui.Controls.MaskedTextBox(this.components);
            this.cTextBoxDescricao = new Gui.Controls.TextBox(this.components);
            this.comboBoxClass = new Gui.Controls.ComboBox(this.components);
            this.cTextBoxNumero = new Gui.Controls.TextBox(this.components);
            this.groupBox2 = new Gui.Controls.GroupBox(this.components);
            this.cButtonCancelar = new Gui.Controls.Button(this.components);
            this.groupBoxServidor = new Gui.Controls.GroupBox(this.components);
            this.cTextBoxServidor = new Gui.Controls.TextBox(this.components);
            this.cButtonIncluir = new Gui.Controls.Button(this.components);
            this.dataGridViewServidor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDoc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxServidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServidor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Portaria N.º";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label2.Location = new System.Drawing.Point(145, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label3.Location = new System.Drawing.Point(231, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Classificação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Resumo";
            // 
            // cButtonGravar
            // 
            this.cButtonGravar.Location = new System.Drawing.Point(14, 29);
            this.cButtonGravar.Name = "cButtonGravar";
            this.cButtonGravar.Size = new System.Drawing.Size(179, 36);
            this.cButtonGravar.TabIndex = 0;
            this.cButtonGravar.Text = "Gravar";
            this.cButtonGravar.UseVisualStyleBackColor = true;
            this.cButtonGravar.Click += new System.EventHandler(this.cButtonGravar_Click);
            // 
            // groupBoxDoc
            // 
            this.groupBoxDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDoc.Controls.Add(this.cMaskTextBoxData);
            this.groupBoxDoc.Controls.Add(this.cTextBoxDescricao);
            this.groupBoxDoc.Controls.Add(this.comboBoxClass);
            this.groupBoxDoc.Controls.Add(this.cTextBoxNumero);
            this.groupBoxDoc.Controls.Add(this.label4);
            this.groupBoxDoc.Controls.Add(this.label3);
            this.groupBoxDoc.Controls.Add(this.label2);
            this.groupBoxDoc.Controls.Add(this.label1);
            this.groupBoxDoc.Location = new System.Drawing.Point(12, 39);
            this.groupBoxDoc.Name = "groupBoxDoc";
            this.groupBoxDoc.Size = new System.Drawing.Size(465, 384);
            this.groupBoxDoc.TabIndex = 0;
            this.groupBoxDoc.TabStop = false;
            this.groupBoxDoc.Text = "Dados do Documento";
            // 
            // cMaskTextBoxData
            // 
            this.cMaskTextBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cMaskTextBoxData.Location = new System.Drawing.Point(146, 43);
            this.cMaskTextBoxData.Mascara = "00/00/0000";
            this.cMaskTextBoxData.MaskFormato = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.cMaskTextBoxData.Name = "cMaskTextBoxData";
            this.cMaskTextBoxData.Size = new System.Drawing.Size(86, 30);
            this.cMaskTextBoxData.TabIndex = 1;
            this.cMaskTextBoxData.TabStop = false;
            this.cMaskTextBoxData.Text = "  /  /";
            // 
            // cTextBoxDescricao
            // 
            this.cTextBoxDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cTextBoxDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cTextBoxDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxDescricao.CharacterCase = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBoxDescricao.isNumeric = false;
            this.cTextBoxDescricao.Location = new System.Drawing.Point(7, 102);
            this.cTextBoxDescricao.Multiline = true;
            this.cTextBoxDescricao.Name = "cTextBoxDescricao";
            this.cTextBoxDescricao.PsswChar = '\0';
            this.cTextBoxDescricao.Size = new System.Drawing.Size(451, 275);
            this.cTextBoxDescricao.TabIndex = 4;
            this.cTextBoxDescricao.TabStop = false;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.Location = new System.Drawing.Point(232, 43);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.SelectedIndex = -1;
            this.comboBoxClass.SelectedItem = null;
            this.comboBoxClass.Size = new System.Drawing.Size(226, 30);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.Text = "...";
            // 
            // cTextBoxNumero
            // 
            this.cTextBoxNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cTextBoxNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cTextBoxNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxNumero.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.cTextBoxNumero.isNumeric = true;
            this.cTextBoxNumero.Location = new System.Drawing.Point(7, 43);
            this.cTextBoxNumero.Multiline = false;
            this.cTextBoxNumero.Name = "cTextBoxNumero";
            this.cTextBoxNumero.PsswChar = '\0';
            this.cTextBoxNumero.Size = new System.Drawing.Size(139, 30);
            this.cTextBoxNumero.TabIndex = 0;
            this.cTextBoxNumero.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cButtonCancelar);
            this.groupBox2.Controls.Add(this.cButtonGravar);
            this.groupBox2.Location = new System.Drawing.Point(482, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comandos";
            // 
            // cButtonCancelar
            // 
            this.cButtonCancelar.Location = new System.Drawing.Point(194, 29);
            this.cButtonCancelar.Name = "cButtonCancelar";
            this.cButtonCancelar.Size = new System.Drawing.Size(111, 36);
            this.cButtonCancelar.TabIndex = 1;
            this.cButtonCancelar.Text = "Cancelar";
            this.cButtonCancelar.UseVisualStyleBackColor = true;
            this.cButtonCancelar.Click += new System.EventHandler(this.cButtonCancelar_Click);
            // 
            // groupBoxServidor
            // 
            this.groupBoxServidor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxServidor.Controls.Add(this.cTextBoxServidor);
            this.groupBoxServidor.Controls.Add(this.cButtonIncluir);
            this.groupBoxServidor.Controls.Add(this.dataGridViewServidor);
            this.groupBoxServidor.Location = new System.Drawing.Point(482, 39);
            this.groupBoxServidor.Name = "groupBoxServidor";
            this.groupBoxServidor.Size = new System.Drawing.Size(320, 303);
            this.groupBoxServidor.TabIndex = 1;
            this.groupBoxServidor.TabStop = false;
            this.groupBoxServidor.Text = "Servidor/Empregado";
            // 
            // cTextBoxServidor
            // 
            this.cTextBoxServidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxServidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxServidor.CharacterCase = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBoxServidor.isNumeric = false;
            this.cTextBoxServidor.Location = new System.Drawing.Point(7, 24);
            this.cTextBoxServidor.Multiline = false;
            this.cTextBoxServidor.Name = "cTextBoxServidor";
            this.cTextBoxServidor.PsswChar = '\0';
            this.cTextBoxServidor.Size = new System.Drawing.Size(247, 30);
            this.cTextBoxServidor.TabIndex = 0;
            this.cTextBoxServidor.TabStop = false;
            // 
            // cButtonIncluir
            // 
            this.cButtonIncluir.Location = new System.Drawing.Point(255, 24);
            this.cButtonIncluir.Name = "cButtonIncluir";
            this.cButtonIncluir.Size = new System.Drawing.Size(58, 30);
            this.cButtonIncluir.TabIndex = 1;
            this.cButtonIncluir.Text = "Inc.";
            this.cButtonIncluir.UseVisualStyleBackColor = true;
            this.cButtonIncluir.Click += new System.EventHandler(this.cButtonIncluir_Click);
            // 
            // dataGridViewServidor
            // 
            this.dataGridViewServidor.AllowUserToAddRows = false;
            this.dataGridViewServidor.AllowUserToDeleteRows = false;
            this.dataGridViewServidor.AllowUserToResizeColumns = false;
            this.dataGridViewServidor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.dataGridViewServidor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServidor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServidor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dataGridViewServidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewServidor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServidor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewServidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServidor.ColumnHeadersVisible = false;
            this.dataGridViewServidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServidor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewServidor.EnableHeadersVisualStyles = false;
            this.dataGridViewServidor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewServidor.Location = new System.Drawing.Point(7, 60);
            this.dataGridViewServidor.Name = "dataGridViewServidor";
            this.dataGridViewServidor.ReadOnly = true;
            this.dataGridViewServidor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServidor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewServidor.RowHeadersVisible = false;
            this.dataGridViewServidor.RowHeadersWidth = 20;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.dataGridViewServidor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewServidor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServidor.Size = new System.Drawing.Size(307, 237);
            this.dataGridViewServidor.TabIndex = 2;
            this.dataGridViewServidor.TabStop = false;
            this.dataGridViewServidor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServidor_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cmd";
            this.Column1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = "Excluir";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FmIncluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(815, 435);
            this.Controls.Add(this.groupBoxServidor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxDoc);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(815, 435);
            this.Name = "FmIncluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmIncluir_FormClosed);
            this.Load += new System.EventHandler(this.FmIncluir_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FmIncluir_Paint);
            this.Controls.SetChildIndex(this.groupBoxDoc, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBoxServidor, 0);
            this.groupBoxDoc.ResumeLayout(false);
            this.groupBoxDoc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxServidor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServidor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Gui.Controls.Button cButtonGravar;
        private Gui.Controls.Button cButtonCancelar;
        private Gui.Controls.Button cButtonIncluir;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Gui.Controls.GroupBox groupBoxDoc;
        private Gui.Controls.GroupBox groupBox2;
        private Gui.Controls.GroupBox groupBoxServidor;
        private System.Windows.Forms.DataGridView dataGridViewServidor;
        private Gui.Controls.TextBox cTextBoxNumero;
        private Gui.Controls.ComboBox comboBoxClass;
        private Gui.Controls.TextBox cTextBoxDescricao;
        private Gui.Controls.MaskedTextBox cMaskTextBoxData;
        private Gui.Controls.TextBox cTextBoxServidor;

    }
}
