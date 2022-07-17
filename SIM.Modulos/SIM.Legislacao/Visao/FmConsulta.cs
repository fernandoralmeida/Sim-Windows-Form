using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sim.Legislacao.Visao
{
    public partial class FmConsulta : Gui.Forms.OwnedForm
    {
        //negocios

        Entidades.ListaLegislacao listaLegislacao = new Entidades.ListaLegislacao();
        Entidades.Legislacao legislacao = new Entidades.Legislacao();
        Negocios.Regras LegDA = new Negocios.Regras(); 

        //prepara a impressao
        bool imprimir = false;
        Point LocalInicialTextBoxNumero = new Point(0, 0);

        public FmConsulta()
        {
            InitializeComponent();
            flexDataGrid1.AppTheme();
            Negocios.Handles.Consulta = this.Handle;
            LocalInicialTextBoxNumero = cLabelTextBoxNumero.Location;
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            cComboBoxTipo.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "TiposDoc", "Item").ToArray());
            cComboBoxSituacao.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "SituacaoAD", "Item").ToArray());
            cComboBoxOrigem.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "OrigemDoc", "Item").ToArray());
            mskTextBoxData2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FormConsulta_Shown(object sender, EventArgs e)
        {
            radioButtonDetalhe.Checked = Properties.Settings.Default.ConsultaDetalhada;
            radioButtonSimples.Checked = Properties.Settings.Default.ConsultaSimples;
        }

        private void FmConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            // impede o fechamento do Formulario, se o backgroundworker estiver ocupado
            if (backgroundWorker1.IsBusy)
            {
                e.Cancel = true;
            }
        }

        private void FormConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            listaLegislacao = null;
            legislacao = null;
            LegDA = null;
            this.Dispose();
            GC.SuppressFinalize(this);
            GC.Collect();
        }     
                       
        private void cButtonLimpar_Click(object sender, EventArgs e)
        {
            //Controles.Limpar.Todos(this.topPainel);
            imprimir = false;
            flexDataGrid1.Listar = null;
            cLabelTextBoxNumero.Text = string.Empty;
            cLabelTextBoxAutor.Text = string.Empty;
            cComboBoxTipo.SelectedIndex = 0;
            cComboBoxClassificado.SelectedIndex = 0;
            cComboBoxSituacao.SelectedIndex = 0;
            cComboBoxOrigem.SelectedIndex = 0;
            cComboBoxTipo.Focus();
            mskTextBoxData1.Text = "15/08/1853";
            mskTextBoxData2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cLabelRetornoConsulta.Text = "...";
        }

        private void cButtonPesquisa_Click(object sender, EventArgs e)
        {
            imprimir = false;
            IniciarPesquisa();
            cButtonImageToImp.Enabled = false;
        }

        private void IniciarPesquisa()
        {
            if (!backgroundWorker1.IsBusy)
            {

                try
                {
                    flexDataGrid1.Listar = null;
                    legislacao.Tipo = (cComboBoxTipo.Text.Equals("...")) ? "%" : cComboBoxTipo.Text;

                    if (cLabelTextBoxNumero.isNumeric.Equals(true))
                        legislacao.Numero = Convert.ToInt32(cLabelTextBoxNumero.Text);

                    legislacao.Data = mskTextBoxData1.ToDate;
                    legislacao.Data2 = mskTextBoxData2.ToDate;

                    legislacao.Complemento = "%";
                    legislacao.Classificacao = (cComboBoxClassificado.Text.Equals("...")) ? "%" : cComboBoxClassificado.SelectedIndex.ToString();
                    legislacao.Situacao = (cComboBoxSituacao.Text.Equals("...")) ? "%" : cComboBoxSituacao.SelectedIndex.ToString();
                    legislacao.Origem = (cComboBoxOrigem.Text.Equals("...")) ? "%" : cComboBoxOrigem.SelectedIndex.ToString();
                    legislacao.Resumo = (cLabelTextBoxNumero.Text.Equals(string.Empty)) ? "%" : cLabelTextBoxNumero.Text;
                    legislacao.Autor = (cLabelTextBoxAutor.Text.Equals(string.Empty)) ? "%" : cLabelTextBoxAutor.Text;
                    
                    topPainel.Enabled = false;

                    cLabelRetornoConsulta.Text = "...";

                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sim.Alerta");
                }                
                
            }
            else
                MessageBox.Show("Sua consulta está sendo processada, aguarde!", "SIM.Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string aviso = string.Empty;

                // muda o aviso conforme condição: impressão ou consulta
                if (imprimir.Equals(true))
                    aviso = "Preparando Impressão... Aguarde!";
                else
                    aviso = "Pesquisando... Aguarde! ";

                // cria pagina de processo apenas pra efeito visual
                //Navegador.DocumentText = @"<html><body style=""font-family: Consolas; font-size: 8pt;""><center>"+ aviso + @"<p /><img src=""" + Application.StartupPath + @"\Img\loading.gif"" style=""border: 0px solid""></img></center></body></html>";

                // inicia o construtor HTML
                //PaginaHTML.HTML(Navegador, LegislacaoBLL.Consulta(ELeg), backgroundWorker1);

                if (radioButtonSimples.Checked.Equals(true))
                {
                    listaLegislacao = LegDA.Consultar(Negocios.TipoConsulta.Simples, legislacao, backgroundWorker1);
                }
                else
                {
                    listaLegislacao = LegDA.Consultar(Negocios.TipoConsulta.Detalhada, legislacao, backgroundWorker1);
                }
                
            }
            catch (Exception ex)
            {
                // reseta o controlador de impressão
                imprimir = false;
                //PaginaHTML.Imprimir = false;  
                e.Cancel = true;
                MessageBox.Show(ex.Message, "SIM.Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {   
            // atualiza a barra de progresso
            cProgressBar1.Valor = e.ProgressPercentage;           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            cButtonImageToImp.Enabled = true;
            flexDataGrid1.Listar = listaLegislacao;

            cLabelRetornoConsulta.Text = string.Format("Ocorrências = {0}, L = {1}, LC = {2}, D = {3}.", LegDA.ContadorRegistros(), LegDA.ContadorLeis(), LegDA.ContadorLeisComplementares(), LegDA.ContadorDecretos());
            topPainel.Enabled = true;
            cProgressBar1.Valor = 0;
        }
        
        private void cButtonImage1_Click(object sender, EventArgs e)
        {        }

        private void cButtonImageToPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento", "SIM.Alera", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void cComboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cComboBoxClassificado.Items.Clear();
            //carrega o combobox classificacao, conforme a opção do combobox tipo
            if (cComboBoxTipo.SelectedIndex.Equals(0))
                cComboBoxClassificado.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "Limpar", "Item").ToArray());//  XmlFile.XmlMLG.Limpar);

            else if (cComboBoxTipo.SelectedIndex.Equals(3))
                cComboBoxClassificado.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "DecretosClassificacao", "Item").ToArray());

            else
                cComboBoxClassificado.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "LeisClassificacao", "Item").ToArray());
        }

        private void FmConsulta_Paint(object sender, PaintEventArgs e)
        {
            radioButtonSimples.ForeColor = Gui.Themes.Colors.Font;
            radioButtonDetalhe.ForeColor = Gui.Themes.Colors.Font;
            label1.ForeColor = Gui.Themes.Colors.Font;
            label2.ForeColor= Gui.Themes.Colors.Font;
            label3.ForeColor= Gui.Themes.Colors.Font;
            label4.ForeColor= Gui.Themes.Colors.Font;
            label5.ForeColor= Gui.Themes.Colors.Font;
            label6.ForeColor= Gui.Themes.Colors.Font;
        }

        private void radioButtonSimples_CheckedChanged(object sender, EventArgs e)
        {
            cLabelTextBoxNumero.isNumeric = true;
            label2.Text = "Numero";
            Properties.Settings.Default.ConsultaSimples = true;
            Properties.Settings.Default.ConsultaDetalhada = false;
            Properties.Settings.Default.Save();
            cComboBoxClassificado.Visible = false;
            cComboBoxOrigem.Visible = false;
            cComboBoxSituacao.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            cLabel1.Visible = false;
            cLabel2.Visible = false;
            cLabelTextBoxAutor.Visible = false;
            mskTextBoxData1.Visible = false;
            mskTextBoxData2.Visible = false;
            cLabelTextBoxNumero.Location = cComboBoxClassificado.Location;
            cLabelTextBoxNumero.Text = string.Empty;
        }

        private void radioButtonDetalhe_CheckedChanged(object sender, EventArgs e)
        {
            cLabelTextBoxNumero.isNumeric = false;
            label2.Text = "Classificação";
            Properties.Settings.Default.ConsultaDetalhada = true;
            Properties.Settings.Default.ConsultaSimples = false;
            Properties.Settings.Default.Save();
            cComboBoxClassificado.Visible = true;
            cComboBoxOrigem.Visible = true;
            cComboBoxSituacao.Visible = true;
            cLabel1.Visible = true;
            cLabel2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            cLabelTextBoxAutor.Visible = true;
            mskTextBoxData1.Visible = true;
            mskTextBoxData2.Visible = true;
            cLabelTextBoxNumero.Location = LocalInicialTextBoxNumero;
        }

        private void cButtonColorPrint_Click(object sender, EventArgs e)
        {

            Negocios.PrintRel previewPage = new Negocios.PrintRel();
            previewPage.Lista = listaLegislacao;

            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();            
            pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(previewPage.DrawPage);

            FormPrint fmp = new FormPrint(pd);            
            fmp.Show(this);

        }

    }
}
