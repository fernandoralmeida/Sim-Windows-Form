namespace Sim.Portarias.Visao
{
    partial class FmEditar
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
            this.groupBoxServidor = new Gui.Controls.GroupBox(this.components);
            this.cButtonIncluir = new Gui.Controls.Button(this.components);
            this.cTextBoxServidor = new Gui.Controls.TextBox(this.components);
            this.dataGridViewServidor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new Gui.Controls.GroupBox(this.components);
            this.cButtonCancelar = new Gui.Controls.Button(this.components);
            this.cButtonGravar = new Gui.Controls.Button(this.components);
            this.groupBoxDoc = new Gui.Controls.GroupBox(this.components);
            this.cMaskTextBoxData = new Gui.Controls.MaskedTextBox(this.components);
            this.cTextBoxNumero = new Gui.Controls.TextBox(this.components);
            this.cTextBoxDescricao = new Gui.Controls.TextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClass = new Gui.Controls.ComboBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAdv = new Gui.Controls.GroupBox(this.components);
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cTextBoxIndice = new Gui.Controls.TextBox(this.components);
            this.cMaskTextBoxAtualizacao = new Gui.Controls.MaskedTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cMaskTextBoxInclusao = new Gui.Controls.MaskedTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cTextBoxPublicado = new Gui.Controls.TextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cTextBoxUrl = new Gui.Controls.TextBox(this.components);
            this.groupBoxServidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServidor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxDoc.SuspendLayout();
            this.groupBoxAdv.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxServidor
            // 
            this.groupBoxServidor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxServidor.Controls.Add(this.cButtonIncluir);
            this.groupBoxServidor.Controls.Add(this.cTextBoxServidor);
            this.groupBoxServidor.Controls.Add(this.dataGridViewServidor);
            this.groupBoxServidor.Location = new System.Drawing.Point(12, 258);
            this.groupBoxServidor.Name = "groupBoxServidor";
            this.groupBoxServidor.Size = new System.Drawing.Size(568, 197);
            this.groupBoxServidor.TabIndex = 1;
            this.groupBoxServidor.TabStop = false;
            this.groupBoxServidor.Text = "Servidor/Empregado";
            this.groupBoxServidor.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxServidor_Paint);
            // 
            // cButtonIncluir
            // 
            this.cButtonIncluir.Location = new System.Drawing.Point(448, 24);
            this.cButtonIncluir.Name = "cButtonIncluir";
            this.cButtonIncluir.Size = new System.Drawing.Size(103, 25);
            this.cButtonIncluir.TabIndex = 1;
            this.cButtonIncluir.Text = "Incluir";
            this.cButtonIncluir.UseVisualStyleBackColor = true;
            this.cButtonIncluir.Click += new System.EventHandler(this.cButtonIncluir_Click);
            // 
            // cTextBoxServidor
            // 
            this.cTextBoxServidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxServidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxServidor.CharacterCase = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBoxServidor.isLetter = false;
            this.cTextBoxServidor.isNumeric = false;
            this.cTextBoxServidor.Location = new System.Drawing.Point(12, 24);
            this.cTextBoxServidor.Multiline = false;
            this.cTextBoxServidor.Name = "cTextBoxServidor";
            this.cTextBoxServidor.PsswChar = '\0';
            this.cTextBoxServidor.Size = new System.Drawing.Size(430, 25);
            this.cTextBoxServidor.TabIndex = 0;
            this.cTextBoxServidor.TabStop = false;
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
            this.dataGridViewServidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.dataGridViewServidor.Location = new System.Drawing.Point(12, 55);
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
            this.dataGridViewServidor.Size = new System.Drawing.Size(539, 136);
            this.dataGridViewServidor.TabIndex = 2;
            this.dataGridViewServidor.TabStop = false;
            this.dataGridViewServidor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServidor_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 27.41117F;
            this.Column1.HeaderText = "Comando";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 172.5888F;
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cButtonCancelar);
            this.groupBox2.Controls.Add(this.cButtonGravar);
            this.groupBox2.Location = new System.Drawing.Point(12, 461);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comandos";
            // 
            // cButtonCancelar
            // 
            this.cButtonCancelar.Location = new System.Drawing.Point(582, 30);
            this.cButtonCancelar.Name = "cButtonCancelar";
            this.cButtonCancelar.Size = new System.Drawing.Size(181, 36);
            this.cButtonCancelar.TabIndex = 1;
            this.cButtonCancelar.Text = "Cancelar";
            this.cButtonCancelar.UseVisualStyleBackColor = true;
            this.cButtonCancelar.Click += new System.EventHandler(this.cButtonCancelar_Click);
            // 
            // cButtonGravar
            // 
            this.cButtonGravar.Location = new System.Drawing.Point(12, 30);
            this.cButtonGravar.Name = "cButtonGravar";
            this.cButtonGravar.Size = new System.Drawing.Size(564, 36);
            this.cButtonGravar.TabIndex = 0;
            this.cButtonGravar.Text = "Gravar";
            this.cButtonGravar.UseVisualStyleBackColor = true;
            this.cButtonGravar.Click += new System.EventHandler(this.cButtonGravar_Click);
            // 
            // groupBoxDoc
            // 
            this.groupBoxDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDoc.Controls.Add(this.cMaskTextBoxData);
            this.groupBoxDoc.Controls.Add(this.cTextBoxNumero);
            this.groupBoxDoc.Controls.Add(this.cTextBoxDescricao);
            this.groupBoxDoc.Controls.Add(this.label4);
            this.groupBoxDoc.Controls.Add(this.label3);
            this.groupBoxDoc.Controls.Add(this.comboBoxClass);
            this.groupBoxDoc.Controls.Add(this.label2);
            this.groupBoxDoc.Controls.Add(this.label1);
            this.groupBoxDoc.Location = new System.Drawing.Point(12, 30);
            this.groupBoxDoc.Name = "groupBoxDoc";
            this.groupBoxDoc.Size = new System.Drawing.Size(568, 222);
            this.groupBoxDoc.TabIndex = 0;
            this.groupBoxDoc.TabStop = false;
            this.groupBoxDoc.Text = "Dados Documento";
            // 
            // cMaskTextBoxData
            // 
            this.cMaskTextBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cMaskTextBoxData.Location = new System.Drawing.Point(161, 43);
            this.cMaskTextBoxData.Mascara = "00/00/0000";
            this.cMaskTextBoxData.MaskFormato = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.cMaskTextBoxData.Name = "cMaskTextBoxData";
            this.cMaskTextBoxData.Size = new System.Drawing.Size(100, 25);
            this.cMaskTextBoxData.TabIndex = 1;
            this.cMaskTextBoxData.TabStop = false;
            this.cMaskTextBoxData.Text = "  /  /";
            // 
            // cTextBoxNumero
            // 
            this.cTextBoxNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxNumero.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.cTextBoxNumero.isLetter = false;
            this.cTextBoxNumero.isNumeric = false;
            this.cTextBoxNumero.Location = new System.Drawing.Point(12, 43);
            this.cTextBoxNumero.Multiline = false;
            this.cTextBoxNumero.Name = "cTextBoxNumero";
            this.cTextBoxNumero.PsswChar = '\0';
            this.cTextBoxNumero.Size = new System.Drawing.Size(148, 25);
            this.cTextBoxNumero.TabIndex = 0;
            this.cTextBoxNumero.TabStop = false;
            // 
            // cTextBoxDescricao
            // 
            this.cTextBoxDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxDescricao.CharacterCase = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBoxDescricao.isLetter = false;
            this.cTextBoxDescricao.isNumeric = false;
            this.cTextBoxDescricao.Location = new System.Drawing.Point(12, 88);
            this.cTextBoxDescricao.Multiline = true;
            this.cTextBoxDescricao.Name = "cTextBoxDescricao";
            this.cTextBoxDescricao.PsswChar = '\0';
            this.cTextBoxDescricao.Size = new System.Drawing.Size(539, 120);
            this.cTextBoxDescricao.TabIndex = 4;
            this.cTextBoxDescricao.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Resumo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label3.Location = new System.Drawing.Point(261, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Classificação";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(262, 43);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.SelectedIndex = -1;
            this.comboBoxClass.SelectedItem = null;
            this.comboBoxClass.Size = new System.Drawing.Size(289, 25);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label2.Location = new System.Drawing.Point(160, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Portaria N.º";
            // 
            // groupBoxAdv
            // 
            this.groupBoxAdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAdv.Controls.Add(this.radioButtonNao);
            this.groupBoxAdv.Controls.Add(this.radioButtonSim);
            this.groupBoxAdv.Controls.Add(this.label11);
            this.groupBoxAdv.Controls.Add(this.label10);
            this.groupBoxAdv.Controls.Add(this.cTextBoxIndice);
            this.groupBoxAdv.Controls.Add(this.cMaskTextBoxAtualizacao);
            this.groupBoxAdv.Controls.Add(this.label9);
            this.groupBoxAdv.Controls.Add(this.cMaskTextBoxInclusao);
            this.groupBoxAdv.Controls.Add(this.label8);
            this.groupBoxAdv.Controls.Add(this.cTextBoxPublicado);
            this.groupBoxAdv.Controls.Add(this.label7);
            this.groupBoxAdv.Controls.Add(this.label5);
            this.groupBoxAdv.Controls.Add(this.cTextBoxUrl);
            this.groupBoxAdv.Location = new System.Drawing.Point(587, 30);
            this.groupBoxAdv.Name = "groupBoxAdv";
            this.groupBoxAdv.Size = new System.Drawing.Size(201, 425);
            this.groupBoxAdv.TabIndex = 2;
            this.groupBoxAdv.TabStop = false;
            this.groupBoxAdv.Text = "Info. Extras";
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(9, 284);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(46, 19);
            this.radioButtonNao.TabIndex = 5;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "NÃO";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(63, 284);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(46, 19);
            this.radioButtonSim.TabIndex = 6;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "SIM";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label11.Location = new System.Drawing.Point(6, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Desativar Registro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label10.Location = new System.Drawing.Point(7, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Indice";
            // 
            // cTextBoxIndice
            // 
            this.cTextBoxIndice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxIndice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxIndice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxIndice.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.cTextBoxIndice.Enabled = false;
            this.cTextBoxIndice.isLetter = false;
            this.cTextBoxIndice.isNumeric = false;
            this.cTextBoxIndice.Location = new System.Drawing.Point(9, 43);
            this.cTextBoxIndice.Multiline = false;
            this.cTextBoxIndice.Name = "cTextBoxIndice";
            this.cTextBoxIndice.PsswChar = '\0';
            this.cTextBoxIndice.Size = new System.Drawing.Size(185, 25);
            this.cTextBoxIndice.TabIndex = 0;
            this.cTextBoxIndice.TabStop = false;
            // 
            // cMaskTextBoxAtualizacao
            // 
            this.cMaskTextBoxAtualizacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cMaskTextBoxAtualizacao.Location = new System.Drawing.Point(9, 233);
            this.cMaskTextBoxAtualizacao.Mascara = "00/00/0000";
            this.cMaskTextBoxAtualizacao.MaskFormato = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.cMaskTextBoxAtualizacao.Name = "cMaskTextBoxAtualizacao";
            this.cMaskTextBoxAtualizacao.Size = new System.Drawing.Size(100, 25);
            this.cMaskTextBoxAtualizacao.TabIndex = 4;
            this.cMaskTextBoxAtualizacao.TabStop = false;
            this.cMaskTextBoxAtualizacao.Text = "  /  /";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label9.Location = new System.Drawing.Point(7, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ultima Atualização";
            // 
            // cMaskTextBoxInclusao
            // 
            this.cMaskTextBoxInclusao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cMaskTextBoxInclusao.Location = new System.Drawing.Point(9, 185);
            this.cMaskTextBoxInclusao.Mascara = "00/00/0000";
            this.cMaskTextBoxInclusao.MaskFormato = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.cMaskTextBoxInclusao.Name = "cMaskTextBoxInclusao";
            this.cMaskTextBoxInclusao.Size = new System.Drawing.Size(100, 25);
            this.cMaskTextBoxInclusao.TabIndex = 3;
            this.cMaskTextBoxInclusao.TabStop = false;
            this.cMaskTextBoxInclusao.Text = "  /  /";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label8.Location = new System.Drawing.Point(6, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Data Inclusão";
            // 
            // cTextBoxPublicado
            // 
            this.cTextBoxPublicado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxPublicado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxPublicado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxPublicado.CharacterCase = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBoxPublicado.isLetter = false;
            this.cTextBoxPublicado.isNumeric = false;
            this.cTextBoxPublicado.Location = new System.Drawing.Point(9, 138);
            this.cTextBoxPublicado.Multiline = false;
            this.cTextBoxPublicado.Name = "cTextBoxPublicado";
            this.cTextBoxPublicado.PsswChar = '\0';
            this.cTextBoxPublicado.Size = new System.Drawing.Size(185, 25);
            this.cTextBoxPublicado.TabIndex = 2;
            this.cTextBoxPublicado.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label7.Location = new System.Drawing.Point(7, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Publicado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Url";
            // 
            // cTextBoxUrl
            // 
            this.cTextBoxUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cTextBoxUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cTextBoxUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cTextBoxUrl.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.cTextBoxUrl.isLetter = false;
            this.cTextBoxUrl.isNumeric = false;
            this.cTextBoxUrl.Location = new System.Drawing.Point(9, 90);
            this.cTextBoxUrl.Multiline = false;
            this.cTextBoxUrl.Name = "cTextBoxUrl";
            this.cTextBoxUrl.PsswChar = '\0';
            this.cTextBoxUrl.Size = new System.Drawing.Size(185, 25);
            this.cTextBoxUrl.TabIndex = 1;
            this.cTextBoxUrl.TabStop = false;
            // 
            // FmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.groupBoxAdv);
            this.Controls.Add(this.groupBoxServidor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxDoc);
            this.MinimumSize = new System.Drawing.Size(800, 548);
            this.Name = "FmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmEditar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmEditar_FormClosed);
            this.Load += new System.EventHandler(this.FmEditar_Load);
            this.Controls.SetChildIndex(this.groupBoxDoc, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBoxServidor, 0);
            this.Controls.SetChildIndex(this.groupBoxAdv, 0);
            this.groupBoxServidor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServidor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxDoc.ResumeLayout(false);
            this.groupBoxDoc.PerformLayout();
            this.groupBoxAdv.ResumeLayout(false);
            this.groupBoxAdv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gui.Controls.Button cButtonIncluir;
        private Gui.Controls.TextBox cTextBoxServidor;
        private Gui.Controls.Button cButtonCancelar;
        private Gui.Controls.Button cButtonGravar;
        private Gui.Controls.MaskedTextBox cMaskTextBoxData;
        private Gui.Controls.TextBox cTextBoxNumero;
        private Gui.Controls.TextBox cTextBoxDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Gui.Controls.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Gui.Controls.TextBox cTextBoxUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private Gui.Controls.TextBox cTextBoxIndice;
        private Gui.Controls.MaskedTextBox cMaskTextBoxAtualizacao;
        private System.Windows.Forms.Label label9;
        private Gui.Controls.MaskedTextBox cMaskTextBoxInclusao;
        private System.Windows.Forms.Label label8;
        private Gui.Controls.TextBox cTextBoxPublicado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.Label label11;
        private Gui.Controls.GroupBox groupBoxServidor;
        private Gui.Controls.GroupBox groupBox2;
        private Gui.Controls.GroupBox groupBoxDoc;
        private Gui.Controls.GroupBox groupBoxAdv;
        private System.Windows.Forms.DataGridView dataGridViewServidor;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;


    }
}