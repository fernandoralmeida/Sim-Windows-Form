namespace Sim.Legislacao.Visao
{
    partial class FmRelatorio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonGerar = new Sim.Gui.Controls.Button(this.components);
            this.comboBoxTipo = new Sim.Gui.Controls.ComboBox(this.components);
            this.maskedTextBox1 = new Sim.Gui.Controls.MaskedTextBox(this.components);
            this.progressBar1 = new Sim.Gui.Controls.ProgressBar(this.components);
            this.maskedTextBox2 = new Sim.Gui.Controls.MaskedTextBox(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxSituacao = new Sim.Gui.Controls.ComboBox(this.components);
            this.comboBoxOrigem = new Sim.Gui.Controls.ComboBox(this.components);
            this.comboBoxAutor = new Sim.Gui.Controls.ComboBox(this.components);
            this.buttonReset = new Sim.Gui.Controls.Button(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new Sim.Gui.Controls.Label(this.components);
            this.buttonPrint = new Sim.Gui.Controls.Button(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // buttonGerar
            // 
            this.buttonGerar.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonGerar.Location = new System.Drawing.Point(727, 31);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(83, 23);
            this.buttonGerar.TabIndex = 5;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.InFocus = Sim.Gui.Controls.FocusType.No;
            this.comboBoxTipo.Location = new System.Drawing.Point(4, 31);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.SelectedIndex = -1;
            this.comboBoxTipo.SelectedItem = null;
            this.comboBoxTipo.Size = new System.Drawing.Size(157, 23);
            this.comboBoxTipo.TabIndex = 6;
            this.comboBoxTipo.Text = "comboBoxTipo";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(557, 31);
            this.maskedTextBox1.Mascara = "";
            this.maskedTextBox1.MaskFormato = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(84, 23);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.TabStop = false;
            this.maskedTextBox1.Text = "15/08/1853";
            this.maskedTextBox1.ToDate = new System.DateTime(1853, 8, 15, 0, 0, 0, 0);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(4, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.PercentYN = false;
            this.progressBar1.Size = new System.Drawing.Size(835, 10);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Text = "progressBar1";
            this.progressBar1.Valor = 0;
            this.progressBar1.ValorMaximo = 100;
            this.progressBar1.ValorMinimo = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.maskedTextBox2.Location = new System.Drawing.Point(642, 31);
            this.maskedTextBox2.Mascara = "";
            this.maskedTextBox2.MaskFormato = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(84, 23);
            this.maskedTextBox2.TabIndex = 11;
            this.maskedTextBox2.TabStop = false;
            this.maskedTextBox2.Text = "03/10/2015";
            this.maskedTextBox2.ToDate = new System.DateTime(2015, 10, 3, 0, 0, 0, 0);
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(291, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(547, 461);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 461);
            this.textBox1.TabIndex = 13;
            // 
            // comboBoxSituacao
            // 
            this.comboBoxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSituacao.InFocus = Sim.Gui.Controls.FocusType.No;
            this.comboBoxSituacao.Location = new System.Drawing.Point(162, 31);
            this.comboBoxSituacao.Name = "comboBoxSituacao";
            this.comboBoxSituacao.SelectedIndex = -1;
            this.comboBoxSituacao.SelectedItem = null;
            this.comboBoxSituacao.Size = new System.Drawing.Size(99, 23);
            this.comboBoxSituacao.TabIndex = 15;
            this.comboBoxSituacao.Text = "comboBoxSituacao";
            // 
            // comboBoxOrigem
            // 
            this.comboBoxOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigem.InFocus = Sim.Gui.Controls.FocusType.No;
            this.comboBoxOrigem.Location = new System.Drawing.Point(262, 31);
            this.comboBoxOrigem.Name = "comboBoxOrigem";
            this.comboBoxOrigem.SelectedIndex = -1;
            this.comboBoxOrigem.SelectedItem = null;
            this.comboBoxOrigem.Size = new System.Drawing.Size(136, 23);
            this.comboBoxOrigem.TabIndex = 16;
            this.comboBoxOrigem.Text = "comboBoxOrigem";
            // 
            // comboBoxAutor
            // 
            this.comboBoxAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutor.Enabled = false;
            this.comboBoxAutor.InFocus = Sim.Gui.Controls.FocusType.No;
            this.comboBoxAutor.Location = new System.Drawing.Point(399, 31);
            this.comboBoxAutor.Name = "comboBoxAutor";
            this.comboBoxAutor.SelectedIndex = -1;
            this.comboBoxAutor.SelectedItem = null;
            this.comboBoxAutor.Size = new System.Drawing.Size(157, 23);
            this.comboBoxAutor.TabIndex = 17;
            this.comboBoxAutor.Text = "comboBoxAutor";
            // 
            // buttonReset
            // 
            this.buttonReset.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonReset.Location = new System.Drawing.Point(811, 31);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(29, 23);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "X";
            this.buttonReset.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24821F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75179F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 467);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(5, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "...";
            // 
            // buttonPrint
            // 
            this.buttonPrint.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonPrint.Location = new System.Drawing.Point(727, 65);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(113, 23);
            this.buttonPrint.TabIndex = 21;
            this.buttonPrint.Text = "Imprimir";
            this.buttonPrint.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // FmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 559);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.comboBoxAutor);
            this.Controls.Add(this.comboBoxOrigem);
            this.Controls.Add(this.comboBoxSituacao);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.buttonGerar);
            this.Name = "FmRelatorio";
            this.Text = "Sim.Estatísticas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmRelatorio_FormClosed);
            this.Load += new System.EventHandler(this.FmRelatorio_Load);
            this.Shown += new System.EventHandler(this.FmRelatorio_Shown);
            this.Controls.SetChildIndex(this.buttonGerar, 0);
            this.Controls.SetChildIndex(this.comboBoxTipo, 0);
            this.Controls.SetChildIndex(this.maskedTextBox1, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.Controls.SetChildIndex(this.maskedTextBox2, 0);
            this.Controls.SetChildIndex(this.comboBoxSituacao, 0);
            this.Controls.SetChildIndex(this.comboBoxOrigem, 0);
            this.Controls.SetChildIndex(this.comboBoxAutor, 0);
            this.Controls.SetChildIndex(this.buttonReset, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonPrint, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Gui.Controls.Button buttonGerar;
        private Gui.Controls.ComboBox comboBoxTipo;
        private Gui.Controls.MaskedTextBox maskedTextBox1;
        private Gui.Controls.ProgressBar progressBar1;
        private Gui.Controls.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private Gui.Controls.ComboBox comboBoxSituacao;
        private Gui.Controls.ComboBox comboBoxOrigem;
        private Gui.Controls.ComboBox comboBoxAutor;
        private Gui.Controls.Button buttonReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Gui.Controls.Label label1;
        private Gui.Controls.Button buttonPrint;
    }
}