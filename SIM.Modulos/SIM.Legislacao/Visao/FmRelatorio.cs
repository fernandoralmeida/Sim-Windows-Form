using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace Sim.Legislacao.Visao
{
    public partial class FmRelatorio : Gui.Forms.OwnedForm
    {

        Entidades.ListaLegislacao listaLegislacao = Instancia.ListaLegislacao();
        Entidades.Legislacao legislacao = Instancia.Legislacao();

        Negocios.IRelatorios Rel = Instancia.Relatorios();

        public object LegDA { get; private set; }

        public FmRelatorio()
        {
            InitializeComponent();
        }

        private void FmRelatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            listaLegislacao = null;
            legislacao = null;
            this.Dispose();
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        private void FmRelatorio_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "15/08/1853";
            maskedTextBox2.ToDate = DateTime.Now;
            comboBoxTipo.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "TiposDoc", "Item").ToArray());
            comboBoxSituacao.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "SituacaoAD", "Item").ToArray());
            comboBoxOrigem.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "OrigemDoc", "Item").ToArray());
            comboBoxAutor.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "AutorLegislativo", "Item").ToArray());
            comboBoxTipo.SelectedIndex = 0;
            comboBoxSituacao.SelectedIndex = 0;
            comboBoxOrigem.SelectedIndex = 0;
            comboBoxAutor.SelectedIndex = 0;
        }

        private void FmRelatorio_Shown(object sender, EventArgs e)
        {
            maskedTextBox2.ToDate = DateTime.Now;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {            
            Rel.Gerar(legislacao, backgroundWorker);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Valor = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChartCreate();
            progressBar1.Valor = 0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Total Documentos = {0}", Rel.Total()));
            sb.AppendLine(string.Format("---------------------------------"));
            sb.AppendLine(string.Format("Leis = {0}",Rel.Leis()));
            sb.AppendLine(string.Format("Decretos = {0}", Rel.Decretos()));
            sb.AppendLine(string.Format("Leis Complementares = {0}", Rel.LeisComp()));
            sb.AppendLine(string.Format("---------------------------------"));
            sb.AppendLine(string.Format("Documentos Alterados = {0}", Rel.TotalAlt()));
            sb.AppendLine(string.Format("Leis = {0}", Rel.LeisAlt()));
            sb.AppendLine(string.Format("Decretos = {0}", Rel.DecAlt()));
            sb.AppendLine(string.Format("Leis Complementares = {0}", Rel.LeisCompAlt()));
            sb.AppendLine(string.Format("---------------------------------"));
            sb.AppendLine(string.Format("Documentos Revogados = {0}", Rel.TotalRev()));
            sb.AppendLine(string.Format("Leis = {0}", Rel.LeisRev()));
            sb.AppendLine(string.Format("Decretos = {0}", Rel.DecRev()));
            sb.AppendLine(string.Format("Leis Complementares = {0}", Rel.LeisCompRev()));
            sb.AppendLine(string.Format("---------------------------------"));
            sb.AppendLine(string.Format("Origem do Executivo = {0}", Rel.AutorExec()));
            sb.AppendLine(string.Format("---------------------------------"));
            sb.AppendLine(string.Format("Origem do Legislativo = {0}", Rel.AutorLeg()));
            sb.AppendLine(string.Format("Mesa Diretora = {0}", Rel.AutorMesaDir()));
            sb.AppendLine(string.Format("Vereadores = {0}", Rel.AutorVer()));

            label1.Text = string.Format("Estatísticas referente : {0} : {1} : {2} : {3} <> {4}", comboBoxTipo.Text, comboBoxSituacao.Text, comboBoxOrigem.Text , maskedTextBox1.Text, maskedTextBox2.Text);

            textBox1.Text = sb.ToString();
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            legislacao.Tipo = (comboBoxTipo.Text.Equals("...")) ? "%" : comboBoxTipo.Text;
            legislacao.Data = maskedTextBox1.ToDate;
            legislacao.Data2 = maskedTextBox2.ToDate;
            legislacao.Resumo = "%";
            legislacao.Classificacao = "%";
            legislacao.Situacao = (comboBoxSituacao.Text.Equals("...")) ? "%" : comboBoxSituacao.SelectedIndex.ToString();
            legislacao.Autor = (comboBoxAutor.Text.Equals("...")) ? "%" : comboBoxAutor.Text;
            legislacao.Origem = (comboBoxOrigem.Text.Equals("...")) ? "%" : comboBoxOrigem.SelectedIndex.ToString();
            backgroundWorker.RunWorkerAsync();
        }

        void ChartCreate()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            var chartarea0 = new ChartArea { Name = "Total" };
            var chartarea1 = new ChartArea { Name = "Vigor" };
            var chartarea2 = new ChartArea { Name = "Alterada" };
            var chartarea3 = new ChartArea { Name = "Revogada" };

            var series1 = new Series
            {
                Name = "Series1",
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                LegendText = "Leis",
                IsValueShownAsLabel = true,
                ChartArea = "Total",
                ChartType = SeriesChartType.Column
            };

            var series2 = new Series
            {
                Name = "Series2",
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                LegendText = "Leis Complemetares",
                IsValueShownAsLabel = true,
                ChartArea = "Total",
                ChartType = SeriesChartType.Column
            };

            var series3 = new Series
            {
                Name = "Series3",
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                LegendText = "Decretos",
                IsValueShownAsLabel = true,
                ChartArea = "Total",
                ChartType = SeriesChartType.Column
            };

            var series4 = new Series
            {
                Name = "Series4",
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                LegendText = "Leis Alteradas",
                IsValueShownAsLabel = true,
                ChartArea = "Alterada",
                ChartType = SeriesChartType.Column
            };

            var series5 = new Series
            {
                Name = "Series5",
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                LegendText = "Lc Alteradas",
                IsValueShownAsLabel = true,
                ChartArea = "Alterada",
                ChartType = SeriesChartType.Column
            };

            var series6 = new Series
            {
                Name = "Series6",
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                LegendText = "Decretos Alterados",
                IsValueShownAsLabel = true,
                ChartArea = "Alterada",
                ChartType = SeriesChartType.Column
            };

            var series7 = new Series
            {
                Name = "Series7",
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                LegendText = "Leis Revogadas",
                IsValueShownAsLabel = true,
                ChartArea = "Revogada",
                ChartType = SeriesChartType.Column
            };

            var series8 = new Series
            {
                Name = "Series8",
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                LegendText = "Lc Revogadas",
                IsValueShownAsLabel = true,
                ChartArea = "Revogada",
                ChartType = SeriesChartType.Column
            };

            var series9 = new Series
            {
                Name = "Series9",
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                LegendText = "Decretos Revogados",
                IsValueShownAsLabel = true,
                ChartArea = "Revogada",
                ChartType = SeriesChartType.Column
            };

            chart1.ChartAreas.Add(chartarea0);
            chart1.ChartAreas.Add(chartarea2);
            chart1.ChartAreas.Add(chartarea3);

            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);

            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);

            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);

            series1.Points.AddXY(Rel.Total(), Rel.Leis());
            series2.Points.AddXY(Rel.Total(), Rel.LeisComp());
            series3.Points.AddXY(Rel.Total(), Rel.Decretos());                        

            series4.Points.AddXY(Rel.TotalAlt(), Rel.LeisAlt());
            series5.Points.AddXY(Rel.TotalAlt(), Rel.LeisCompAlt());
            series6.Points.AddXY(Rel.TotalAlt(), Rel.DecAlt());

            series7.Points.AddXY(Rel.TotalRev(), Rel.LeisRev());
            series8.Points.AddXY(Rel.TotalRev(), Rel.LeisCompRev());
            series9.Points.AddXY(Rel.TotalRev(), Rel.DecRev());

            chart1.Invalidate();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            comboBoxTipo.SelectedIndex = 0;
            comboBoxSituacao.SelectedIndex = 0;
            comboBoxOrigem.SelectedIndex = 0;
            comboBoxAutor.SelectedIndex = 0;
            maskedTextBox1.Text = "15/08/1853";
            maskedTextBox2.ToDate = DateTime.Now;
            textBox1.Text = string.Empty;
            label1.Text = "...";
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {            
            FormPrint fmp = new FormPrint(chart1.Printing.PrintDocument);
            fmp.Show(this);
        }
    }
}