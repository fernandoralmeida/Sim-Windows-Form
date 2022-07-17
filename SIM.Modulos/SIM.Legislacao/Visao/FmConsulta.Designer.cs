namespace Sim.Legislacao.Visao
{
    partial class FmConsulta
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
            this.topPainel = new Sim.Gui.Controls.Panel(this.components);
            this.cLabelTextBoxAutor = new Sim.Gui.Controls.TextBox(this.components);
            this.cLabelTextBoxNumero = new Sim.Gui.Controls.TextBox(this.components);
            this.cComboBoxSituacao = new Sim.Gui.Controls.ComboBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cComboBoxOrigem = new Sim.Gui.Controls.ComboBox(this.components);
            this.cComboBoxClassificado = new Sim.Gui.Controls.ComboBox(this.components);
            this.cComboBoxTipo = new Sim.Gui.Controls.ComboBox(this.components);
            this.cProgressBar1 = new Sim.Gui.Controls.ProgressBar(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cLabel2 = new Sim.Gui.Controls.Label(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cLabel1 = new Sim.Gui.Controls.Label(this.components);
            this.mskTextBoxData1 = new Sim.Gui.Controls.MaskedTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTextBoxData2 = new Sim.Gui.Controls.MaskedTextBox(this.components);
            this.cButtonColorPrint = new Sim.Gui.Controls.Button(this.components);
            this.cLabelRetornoConsulta = new Sim.Gui.Controls.Label(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cButtonColor3 = new Sim.Gui.Controls.Button(this.components);
            this.cButtonPesquisa = new Sim.Gui.Controls.Button(this.components);
            this.cButtonImageToPDF = new Sim.Gui.Controls.Button(this.components);
            this.cButtonImageToImp = new Sim.Gui.Controls.Button(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioButtonSimples = new System.Windows.Forms.RadioButton();
            this.radioButtonDetalhe = new System.Windows.Forms.RadioButton();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.flexDataGrid1 = new Sim.Legislacao.Visao.FlexDataGrid();
            this.topPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPainel
            // 
            this.topPainel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPainel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.topPainel.Borda = false;
            this.topPainel.Controls.Add(this.cLabelTextBoxAutor);
            this.topPainel.Controls.Add(this.cLabelTextBoxNumero);
            this.topPainel.Controls.Add(this.cComboBoxSituacao);
            this.topPainel.Controls.Add(this.label6);
            this.topPainel.Controls.Add(this.cComboBoxOrigem);
            this.topPainel.Controls.Add(this.cComboBoxClassificado);
            this.topPainel.Controls.Add(this.cComboBoxTipo);
            this.topPainel.Controls.Add(this.cProgressBar1);
            this.topPainel.Controls.Add(this.label5);
            this.topPainel.Controls.Add(this.cLabel2);
            this.topPainel.Controls.Add(this.label4);
            this.topPainel.Controls.Add(this.cLabel1);
            this.topPainel.Controls.Add(this.mskTextBoxData1);
            this.topPainel.Controls.Add(this.label1);
            this.topPainel.Controls.Add(this.label2);
            this.topPainel.Controls.Add(this.mskTextBoxData2);
            this.topPainel.Controls.Add(this.cButtonColorPrint);
            this.topPainel.Controls.Add(this.cLabelRetornoConsulta);
            this.topPainel.Controls.Add(this.label3);
            this.topPainel.Controls.Add(this.cButtonColor3);
            this.topPainel.Controls.Add(this.cButtonPesquisa);
            this.topPainel.Location = new System.Drawing.Point(5, 25);
            this.topPainel.Name = "topPainel";
            this.topPainel.Size = new System.Drawing.Size(939, 97);
            this.topPainel.TabIndex = 2;
            // 
            // cLabelTextBoxAutor
            // 
            this.cLabelTextBoxAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabelTextBoxAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cLabelTextBoxAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cLabelTextBoxAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cLabelTextBoxAutor.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.cLabelTextBoxAutor.isLetter = false;
            this.cLabelTextBoxAutor.isNumeric = false;
            this.cLabelTextBoxAutor.isReadOnly = false;
            this.cLabelTextBoxAutor.Location = new System.Drawing.Point(785, 25);
            this.cLabelTextBoxAutor.Margin = new System.Windows.Forms.Padding(1);
            this.cLabelTextBoxAutor.Multiline = false;
            this.cLabelTextBoxAutor.Name = "cLabelTextBoxAutor";
            this.cLabelTextBoxAutor.PsswChar = '\0';
            this.cLabelTextBoxAutor.Size = new System.Drawing.Size(148, 27);
            this.cLabelTextBoxAutor.TabIndex = 5;
            this.cLabelTextBoxAutor.TabStop = false;
            // 
            // cLabelTextBoxNumero
            // 
            this.cLabelTextBoxNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabelTextBoxNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cLabelTextBoxNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cLabelTextBoxNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cLabelTextBoxNumero.CharacterCase = System.Windows.Forms.CharacterCasing.Normal;
            this.cLabelTextBoxNumero.isLetter = false;
            this.cLabelTextBoxNumero.isNumeric = false;
            this.cLabelTextBoxNumero.isReadOnly = false;
            this.cLabelTextBoxNumero.Location = new System.Drawing.Point(638, 25);
            this.cLabelTextBoxNumero.Margin = new System.Windows.Forms.Padding(1);
            this.cLabelTextBoxNumero.Multiline = false;
            this.cLabelTextBoxNumero.Name = "cLabelTextBoxNumero";
            this.cLabelTextBoxNumero.PsswChar = '\0';
            this.cLabelTextBoxNumero.Size = new System.Drawing.Size(147, 27);
            this.cLabelTextBoxNumero.TabIndex = 4;
            this.cLabelTextBoxNumero.TabStop = false;
            // 
            // cComboBoxSituacao
            // 
            this.cComboBoxSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cComboBoxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cComboBoxSituacao.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cComboBoxSituacao.Location = new System.Drawing.Point(412, 25);
            this.cComboBoxSituacao.Margin = new System.Windows.Forms.Padding(1);
            this.cComboBoxSituacao.Name = "cComboBoxSituacao";
            this.cComboBoxSituacao.SelectedIndex = -1;
            this.cComboBoxSituacao.SelectedItem = null;
            this.cComboBoxSituacao.Size = new System.Drawing.Size(108, 27);
            this.cComboBoxSituacao.TabIndex = 2;
            this.cComboBoxSituacao.Text = "...";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(783, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "Autor";
            // 
            // cComboBoxOrigem
            // 
            this.cComboBoxOrigem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cComboBoxOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cComboBoxOrigem.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cComboBoxOrigem.Location = new System.Drawing.Point(520, 25);
            this.cComboBoxOrigem.Margin = new System.Windows.Forms.Padding(1);
            this.cComboBoxOrigem.Name = "cComboBoxOrigem";
            this.cComboBoxOrigem.SelectedIndex = -1;
            this.cComboBoxOrigem.SelectedItem = null;
            this.cComboBoxOrigem.Size = new System.Drawing.Size(118, 27);
            this.cComboBoxOrigem.TabIndex = 3;
            this.cComboBoxOrigem.Text = "...";
            // 
            // cComboBoxClassificado
            // 
            this.cComboBoxClassificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cComboBoxClassificado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cComboBoxClassificado.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cComboBoxClassificado.Location = new System.Drawing.Point(164, 25);
            this.cComboBoxClassificado.Margin = new System.Windows.Forms.Padding(1);
            this.cComboBoxClassificado.Name = "cComboBoxClassificado";
            this.cComboBoxClassificado.SelectedIndex = -1;
            this.cComboBoxClassificado.SelectedItem = null;
            this.cComboBoxClassificado.Size = new System.Drawing.Size(248, 27);
            this.cComboBoxClassificado.TabIndex = 1;
            this.cComboBoxClassificado.Text = "...";
            // 
            // cComboBoxTipo
            // 
            this.cComboBoxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cComboBoxTipo.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cComboBoxTipo.Location = new System.Drawing.Point(6, 25);
            this.cComboBoxTipo.Margin = new System.Windows.Forms.Padding(1);
            this.cComboBoxTipo.Name = "cComboBoxTipo";
            this.cComboBoxTipo.SelectedIndex = -1;
            this.cComboBoxTipo.SelectedItem = null;
            this.cComboBoxTipo.Size = new System.Drawing.Size(158, 27);
            this.cComboBoxTipo.TabIndex = 0;
            this.cComboBoxTipo.Text = "...";
            this.cComboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.cComboBoxTipo_SelectedIndexChanged);
            // 
            // cProgressBar1
            // 
            this.cProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cProgressBar1.Location = new System.Drawing.Point(3, 91);
            this.cProgressBar1.Name = "cProgressBar1";
            this.cProgressBar1.PercentYN = false;
            this.cProgressBar1.Size = new System.Drawing.Size(933, 2);
            this.cProgressBar1.TabIndex = 64;
            this.cProgressBar1.Text = "cProgressBar1";
            this.cProgressBar1.Valor = 0;
            this.cProgressBar1.ValorMaximo = 100;
            this.cProgressBar1.ValorMinimo = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(637, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Resumo/Assunto";
            // 
            // cLabel2
            // 
            this.cLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabel2.AutoSize = true;
            this.cLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cLabel2.Location = new System.Drawing.Point(392, 67);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Size = new System.Drawing.Size(56, 15);
            this.cLabel2.TabIndex = 63;
            this.cLabel2.Text = "Periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(521, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "Origem";
            // 
            // cLabel1
            // 
            this.cLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabel1.AutoSize = true;
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cLabel1.Location = new System.Drawing.Point(537, 67);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(21, 15);
            this.cLabel1.TabIndex = 62;
            this.cLabel1.Text = "<>";
            // 
            // mskTextBoxData1
            // 
            this.mskTextBoxData1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskTextBoxData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.mskTextBoxData1.Location = new System.Drawing.Point(454, 61);
            this.mskTextBoxData1.Mascara = "00/00/0000";
            this.mskTextBoxData1.MaskFormato = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskTextBoxData1.Name = "mskTextBoxData1";
            this.mskTextBoxData1.Size = new System.Drawing.Size(80, 26);
            this.mskTextBoxData1.TabIndex = 6;
            this.mskTextBoxData1.TabStop = false;
            this.mskTextBoxData1.Text = "15/08/1853";
            this.mskTextBoxData1.ToDate = new System.DateTime(1853, 8, 15, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Classificacao";
            // 
            // mskTextBoxData2
            // 
            this.mskTextBoxData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskTextBoxData2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.mskTextBoxData2.Location = new System.Drawing.Point(560, 61);
            this.mskTextBoxData2.Mascara = "00/00/0000";
            this.mskTextBoxData2.MaskFormato = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskTextBoxData2.Name = "mskTextBoxData2";
            this.mskTextBoxData2.Size = new System.Drawing.Size(80, 26);
            this.mskTextBoxData2.TabIndex = 7;
            this.mskTextBoxData2.TabStop = false;
            this.mskTextBoxData2.Text = "19/08/2015";
            this.mskTextBoxData2.ToDate = new System.DateTime(2015, 8, 19, 0, 0, 0, 0);
            // 
            // cButtonColorPrint
            // 
            this.cButtonColorPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonColorPrint.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonColorPrint.Location = new System.Drawing.Point(821, 61);
            this.cButtonColorPrint.Name = "cButtonColorPrint";
            this.cButtonColorPrint.Size = new System.Drawing.Size(111, 26);
            this.cButtonColorPrint.TabIndex = 10;
            this.cButtonColorPrint.Text = "Imprimir";
            this.cButtonColorPrint.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonColorPrint.UseVisualStyleBackColor = true;
            this.cButtonColorPrint.Click += new System.EventHandler(this.cButtonColorPrint_Click);
            // 
            // cLabelRetornoConsulta
            // 
            this.cLabelRetornoConsulta.AutoSize = true;
            this.cLabelRetornoConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cLabelRetornoConsulta.Location = new System.Drawing.Point(6, 67);
            this.cLabelRetornoConsulta.Name = "cLabelRetornoConsulta";
            this.cLabelRetornoConsulta.Size = new System.Drawing.Size(28, 15);
            this.cLabelRetornoConsulta.TabIndex = 58;
            this.cLabelRetornoConsulta.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(411, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Situação";
            // 
            // cButtonColor3
            // 
            this.cButtonColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonColor3.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonColor3.Location = new System.Drawing.Point(764, 61);
            this.cButtonColor3.Name = "cButtonColor3";
            this.cButtonColor3.Size = new System.Drawing.Size(57, 26);
            this.cButtonColor3.TabIndex = 9;
            this.cButtonColor3.Text = "Limpar";
            this.cButtonColor3.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonColor3.UseVisualStyleBackColor = true;
            this.cButtonColor3.Click += new System.EventHandler(this.cButtonLimpar_Click);
            // 
            // cButtonPesquisa
            // 
            this.cButtonPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonPesquisa.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonPesquisa.Location = new System.Drawing.Point(646, 61);
            this.cButtonPesquisa.Name = "cButtonPesquisa";
            this.cButtonPesquisa.Size = new System.Drawing.Size(118, 26);
            this.cButtonPesquisa.TabIndex = 8;
            this.cButtonPesquisa.Text = "Consultar";
            this.cButtonPesquisa.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonPesquisa.UseVisualStyleBackColor = true;
            this.cButtonPesquisa.Click += new System.EventHandler(this.cButtonPesquisa_Click);
            // 
            // cButtonImageToPDF
            // 
            this.cButtonImageToPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonImageToPDF.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonImageToPDF.Location = new System.Drawing.Point(846, 578);
            this.cButtonImageToPDF.Name = "cButtonImageToPDF";
            this.cButtonImageToPDF.Size = new System.Drawing.Size(72, 41);
            this.cButtonImageToPDF.TabIndex = 2;
            this.cButtonImageToPDF.Text = "PDF";
            this.cButtonImageToPDF.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonImageToPDF.UseVisualStyleBackColor = true;
            this.cButtonImageToPDF.Visible = false;
            this.cButtonImageToPDF.Click += new System.EventHandler(this.cButtonImageToPDF_Click);
            // 
            // cButtonImageToImp
            // 
            this.cButtonImageToImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonImageToImp.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonImageToImp.Location = new System.Drawing.Point(846, 538);
            this.cButtonImageToImp.Name = "cButtonImageToImp";
            this.cButtonImageToImp.Size = new System.Drawing.Size(72, 41);
            this.cButtonImageToImp.TabIndex = 0;
            this.cButtonImageToImp.Text = "Imp";
            this.cButtonImageToImp.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonImageToImp.UseVisualStyleBackColor = true;
            this.cButtonImageToImp.Visible = false;
            this.cButtonImageToImp.Click += new System.EventHandler(this.cButtonImage1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // radioButtonSimples
            // 
            this.radioButtonSimples.AutoSize = true;
            this.radioButtonSimples.Location = new System.Drawing.Point(169, 3);
            this.radioButtonSimples.Name = "radioButtonSimples";
            this.radioButtonSimples.Size = new System.Drawing.Size(74, 19);
            this.radioButtonSimples.TabIndex = 0;
            this.radioButtonSimples.Text = "Simples";
            this.radioButtonSimples.UseVisualStyleBackColor = true;
            this.radioButtonSimples.CheckedChanged += new System.EventHandler(this.radioButtonSimples_CheckedChanged);
            // 
            // radioButtonDetalhe
            // 
            this.radioButtonDetalhe.AutoSize = true;
            this.radioButtonDetalhe.Location = new System.Drawing.Point(253, 3);
            this.radioButtonDetalhe.Name = "radioButtonDetalhe";
            this.radioButtonDetalhe.Size = new System.Drawing.Size(88, 19);
            this.radioButtonDetalhe.TabIndex = 1;
            this.radioButtonDetalhe.Text = "Detalhada";
            this.radioButtonDetalhe.UseVisualStyleBackColor = false;
            this.radioButtonDetalhe.CheckedChanged += new System.EventHandler(this.radioButtonDetalhe_CheckedChanged);
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Location = new System.Drawing.Point(5, 124);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(939, 520);
            this.elementHost1.TabIndex = 5;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.flexDataGrid1;
            // 
            // FmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.radioButtonDetalhe);
            this.Controls.Add(this.radioButtonSimples);
            this.Controls.Add(this.cButtonImageToImp);
            this.Controls.Add(this.cButtonImageToPDF);
            this.Controls.Add(this.topPainel);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "FmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmConsulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmConsulta_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConsulta_FormClosed);
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.Shown += new System.EventHandler(this.FormConsulta_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FmConsulta_Paint);
            this.Controls.SetChildIndex(this.topPainel, 0);
            this.Controls.SetChildIndex(this.cButtonImageToPDF, 0);
            this.Controls.SetChildIndex(this.cButtonImageToImp, 0);
            this.Controls.SetChildIndex(this.radioButtonSimples, 0);
            this.Controls.SetChildIndex(this.radioButtonDetalhe, 0);
            this.Controls.SetChildIndex(this.elementHost1, 0);
            this.topPainel.ResumeLayout(false);
            this.topPainel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gui.Controls.Panel topPainel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Gui.Controls.Button cButtonImageToImp;
        private Gui.Controls.Button cButtonImageToPDF;
        private Gui.Controls.ComboBox cComboBoxTipo;
        private System.Windows.Forms.Label label1;
        private Gui.Controls.Button cButtonPesquisa;
        private Gui.Controls.Button cButtonColor3;
        private Gui.Controls.ComboBox cComboBoxSituacao;
        private Gui.Controls.ComboBox cComboBoxOrigem;
        private Gui.Controls.TextBox cLabelTextBoxAutor;
        private Gui.Controls.TextBox cLabelTextBoxNumero;
        private Gui.Controls.ComboBox cComboBoxClassificado;
        private System.Windows.Forms.RadioButton radioButtonSimples;
        private System.Windows.Forms.RadioButton radioButtonDetalhe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Gui.Controls.Label cLabelRetornoConsulta;
        private Gui.Controls.Button cButtonColorPrint;
        private Gui.Controls.Label cLabel2;
        private Gui.Controls.Label cLabel1;
        private Gui.Controls.MaskedTextBox mskTextBoxData1;
        private Gui.Controls.MaskedTextBox mskTextBoxData2;
        private Gui.Controls.ProgressBar cProgressBar1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private FlexDataGrid flexDataGrid1;
    }
}