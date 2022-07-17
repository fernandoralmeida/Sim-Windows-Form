using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sim.Classes;

namespace Sim.Legislacao.Visao
{
    public partial class FmEdicao : Sim.Componentes.Formularios.xFormChild // Form // Sim.Forms.xForm //
    {


        //nova instancia xml
        XmlFile ctrl = new XmlFile();

       // Sim.Classes.Colors mColors = new Sim.Classes.Colors();

        public FmEdicao()
        {
            InitializeComponent();
            /*
            Classes.Aero.ExternderAero(this.Handle, panelTop.Height - label2.Height, 0, 0, 0);
            //efeito aero no painel
            if (Aero.IsGlassEnabled().Equals(true))
            {
                Color c = Color.FromArgb(255, 221, 220, 220);
                this.TransparencyKey = c;
                panelTop.BackColor = c;
            }*/
            //this.BackColor = mColors.Cor;
        }

        private void FormEdicao_Load(object sender, EventArgs e)
        {
            
            //carrega o combobox com os dados do arquivo xml
            //ctrl.ComboXML(comboFiltro, XmlFile.XmlMLG.TiposDoc);
            //RegraN.LerXML.ToComboBox(comboFiltro, "Legislacao");

            comboFiltro.Items.AddRange(new Sim.Componentes.Classes.Xml().Listar("Legislacao", "BaseDados", "TiposDoc", "Item").ToArray());

            ctrl.ComboXML(cmbTipo, XmlFile.XmlMLG.TiposDoc);
            ctrl.ComboXML(cmbOrigem, XmlFile.XmlMLG.OrigemDoc);
            ctrl.ComboXML(cmbAutor, XmlFile.XmlMLG.AutorLegislativo);
            ctrl.ComboXML(cmbAcaoED, XmlFile.XmlMLG.AcoesED);
            ctrl.ComboXML(cmbTipoAlvo, XmlFile.XmlMLG.TiposDoc);      
            //inicia painel edicao desativado
            PainelEdicaoAtivo(false);

            if (comboFiltro.Items.Count > 0)
                comboFiltro.SelectedIndex = 0;


            
            //tableLayoutPanel1.BackColor = this.BackColor;
            //label2.BackColor = mColors.Cor;
            //prepara o datagridview
            dataGridView.BackgroundColor = this.BackColor;
            FormatGrid(dataGridView, 0);
        }

        #region Pesquisa

        private void FiltrarDados()
        {
            //verifica se txtfiltro está vazio
            txtFiltro.Text = (txtFiltro.Text.Equals(string.Empty)) ? "0" : txtFiltro.Text;
            /*
            //atribui valores a entidade ELegislacao
            ELeg.Tipo = (comboFiltro.Text.Equals("...")) ? "%" : comboFiltro.Text;
            ELeg.Numero = (txtFiltro.Text.Equals(string.Empty)) ? 0 : Convert.ToInt32(txtFiltro.Text); // Convert.ToInt32(txtFiltro.Text);
            ELeg.NumeroFinal = (txtFiltro.Text.Equals(string.Empty)) ? 99999 : Convert.ToInt32(txtFiltro.Text); 
            ELeg.Complemento = "%"; // (txtComplemento.Text.Equals(string.Empty)) ? "%" : txtComplemento.Text;
            ELeg.Decricao = "%";
            ELeg.Data = Convert.ToDateTime("01/01/1853");
            ELeg.DataFinal = DateTime.Now;
            ELeg.Classificacao = "%";
            ELeg.Situacao = "%";
            ELeg.Origem = "%";
            ELeg.Autor = "%";
            */
            //preenche o datagridview
            //dataGridView.DataSource = LegislacaoBLL.Consulta(ELeg);
            //pega a quantidade de registro retornado
            label2.Text = string.Format("Resultado: {0} registro(s) encontrado(s)", dataGridView.RowCount);
            //se texto for 0 modifica para vazio
            txtFiltro.Text = (txtFiltro.Text.Equals("0")) ? string.Empty : txtFiltro.Text;
            FormatGrid(dataGridView, dataGridView.RowCount);
        }
        
        private void cButtonFiltro_Click(object sender, EventArgs e)
        {
            FiltrarDados();
        }

        private void FormEdicao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Classes.Formularios.EdicaoAtiva = false;
            this.Dispose();
        }

        private void cButtonLimpar_Click(object sender, System.EventArgs e)
        {
            Controles.Limpar.Todos(this.panelTop);
            comboFiltro.SelectedIndex = 0;
            dataGridView.DataSource = null;
            FormatGrid(dataGridView, 0);
            label2.Text = string.Format("...", 0);
            comboFiltro.Focus();
        }
        
        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex.Equals(0))
                    {
                        //Classes.Transportar.Url(string.Format(@"{0}{1}", Sim.Legislacao.Properties.Settings.Default.viaWEB, (string)(dataGridView.Rows[e.RowIndex].Cells[10].Value)));
                        Forms.FormPDF FmPDF = new Forms.FormPDF();
                        //MessageBox.Show(string.Format(@"{0}{1}", Sim.Legislacao.Properties.Settings.Default.viaHD, (string)(dataGridView.Rows[e.RowIndex].Cells[10].Value)));
                        FmPDF.InNetWorkFile(string.Format(@"{0}{1}", Sim.Legislacao.Properties.Settings.Default.viaHD, (string)(dataGridView.Rows[e.RowIndex].Cells[10].Value)));
                        FmPDF.Show(this);
                    }

                    if (e.ColumnIndex == 1)
                    {
                        PainelEdicaoAtivo(true);
                        EnviarDadosParaControles(e.RowIndex);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Edição

        private void EnviarDadosParaControles(int rowindex)
        {
            DateTime dtime;

            labelID.Text = dataGridView.Rows[rowindex].Cells[2].Value.ToString();
            cmbTipo.Text = dataGridView.Rows[rowindex].Cells[3].Value.ToString();
            txtNumero.Text = dataGridView.Rows[rowindex].Cells[4].Value.ToString();
            txtComplemento.Text = dataGridView.Rows[rowindex].Cells[5].Value.ToString(); ;
            dtime = Convert.ToDateTime(dataGridView.Rows[rowindex].Cells[6].Value.ToString());
            txtData.Text = dtime.ToShortDateString();
            txtPublicacao.Text = dataGridView.Rows[rowindex].Cells[7].Value.ToString();
            txtResumoEmenta.Text = dataGridView.Rows[rowindex].Cells[8].Value.ToString();
            cmbClassificação.SelectedIndex = Convert.ToInt32(dataGridView.Rows[rowindex].Cells[9].Value);
            txtURL.Text = dataGridView.Rows[rowindex].Cells[10].Value.ToString();
            labelsituacao.Text = dataGridView.Rows[rowindex].Cells[11].Value.ToString();
            cmbOrigem.SelectedIndex = Convert.ToInt32(dataGridView.Rows[rowindex].Cells[12].Value);
            txtAutor.Text = dataGridView.Rows[rowindex].Cells[13].Value.ToString();
            /*
            EAcao.TipoOrigem = cmbTipo.Text;
            EAcao.NumeroOrigem = Convert.ToInt32(txtNumero.Text);
            EAcao.ComplementoOrigem = "%";
            dataGridViewAcao.DataSource = AcoesBLL.AcoesOrigem(EAcao);
            */
            //Componentes.Classes.Transportar.Url(string.Format(@"{0}{1}", SIM.Legislacao.Properties.Settings.Default.viaWEB, txtURL.Text));

        }

        private void cButtonCancel_Click(object sender, EventArgs e)
        {
            PainelEdicaoAtivo(false);
        }
         
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // carrega o arquivo xml no combobox classificação conforme o tipo de documento (lei, decreto, lei complementar)
            if (cmbTipo.SelectedIndex.Equals(0))
                ctrl.ComboXML(cmbClassificação, XmlFile.XmlMLG.Limpar);

            else if (cmbTipo.SelectedIndex.Equals(3))
                ctrl.ComboXML(cmbClassificação, XmlFile.XmlMLG.DecretoClassificacao);

            else
                ctrl.ComboXML(cmbClassificação, XmlFile.XmlMLG.LeisClassificacao);
        }

        private void cButtonIncluirSituacao_Click(object sender, EventArgs e)
        {
            if (!(cmbAcaoED.SelectedIndex.Equals(0) || cmbTipoAlvo.SelectedIndex.Equals(0) || txtAlvo.Text.Equals(string.Empty)))
            {
                // atribui valores a entidade EAcao
                /*
                EAcao.TipoOrigem = cmbTipo.Text;
                EAcao.NumeroOrigem = Convert.ToInt32(txtNumero.Text);
                EAcao.ComplementoOrigem = txtComplemento.Text;
                EAcao.DataOrigem = Convert.ToDateTime(txtData.Text);
                EAcao.AcaoED = cmbAcaoED.SelectedIndex.ToString();
                EAcao.TipoAlvo = cmbTipoAlvo.Text;
                EAcao.NumeroAlvo = Convert.ToInt32(txtAlvo.Text);
                EAcao.ComplementoAlvo = cTextBoxCompAlvo.Text;
                
                AcoesBLL.GetAlvo(EAcao);

                if (AcoesBLL.IsertAcoesED(EAcao).Equals(true)) // inseri dados na tabela AçãoED
                {
                    dataGridViewAcao.DataSource = AcoesBLL.AcoesOrigem(EAcao); // atualiza o datagridview
                    
                    // atribui valores a entidade ELegislacao
                    ELeg.Tipo = EAcao.TipoAlvo;
                    ELeg.Numero = EAcao.NumeroAlvo;
                    ELeg.Complemento = EAcao.ComplementoAlvo;

                    // Atualiza a situação do documento alvo da ação
                    ELeg.Situacao = LegislacaoBLL.AtualizaSituacao(EAcao.AcaoED);
                    //MessageBox.Show(ELeg.Tipo + ELeg.Numero + ELeg.Complemento + ELeg.Situacao);
                    LegislacaoBLL.UpDateSituacao(ELeg);

                    txtAlvo.Text = string.Empty;
                    txtAlvo.Focus();
                }
                 * */
            }
        }

        private void dgViewStatusAcao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                /*
                //exclui ação e atualiza o datagridview
                if (MessageBox.Show("Deseja mesmo 'Excluir' esta ação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                {
                    EAcao.Indice = Convert.ToInt32(dataGridViewAcao.Rows[e.RowIndex].Cells[1].Value);
                    AcoesBLL.DeleteAcoesED(EAcao);
                    dataGridViewAcao.DataSource = AcoesBLL.AcoesOrigem(EAcao);
                }
                 * */
            }
        }

        private void cButtonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                //atribui valores a entidade ELegislação
                ELeg.Indice = Convert.ToInt32(labelID.Text);
                ELeg.Tipo = cmbTipo.Text;
                ELeg.Numero = Convert.ToInt32(txtNumero.Text);
                ELeg.Complemento = txtComplemento.Text;
                ELeg.Data = Convert.ToDateTime(txtData.Text);
                ELeg.Publicacao = txtPublicacao.Text;
                ELeg.Decricao = txtResumoEmenta.Text;
                ELeg.Classificacao = cmbClassificação.SelectedIndex.ToString();
                ELeg.LinkURL = txtURL.Text;
                ELeg.Situacao = labelsituacao.Text;
                //ELeg.Acao = cmbAcaoED.SelectedIndex.ToString();
                ELeg.Origem = cmbOrigem.SelectedIndex.ToString();
                ELeg.Autor = txtAutor.Text;
                ELeg.Atualizado = DateTime.Now;
                //envia entidade legislacao
                LegislacaoBLL.UpDateData(ELeg);
                 * */
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                MessageBox.Show("Dados atualizados com sucesso!");
                PainelEdicaoAtivo(false);
                FiltrarDados();
            }
        }

        private void cmbOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigem.SelectedIndex.Equals(1))
                txtAutor.Text = cmbOrigem.Text;
            else               
                txtAutor.Text = string.Empty;

            if (cmbAutor.Items.Count > 0)
                cmbAutor.SelectedIndex = 0;
        }

        private void cmbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAutor.SelectedIndex.Equals(1))
                txtAutor.Text = cmbAutor.Text;
            else
                txtAutor.Text = string.Empty;
        }

        #endregion

        private void PainelEdicaoAtivo(bool valor)
        {
            if (valor.Equals(true))
            {
                tableLayoutPanel1.ColumnStyles[0].Width = 0; // Coluna 0 oculta
                tableLayoutPanel1.ColumnStyles[1].Width = 100; // Coluna 1 visivel
                panelEdicao.Visible = true;
                panelTop.Enabled = false;
                panelGrid.Visible = false;
            }
            else
            {
                tableLayoutPanel1.ColumnStyles[1].Width = 0; // coluna 1 oculta
                tableLayoutPanel1.ColumnStyles[0].Width = 100; // coluna 0 visivel
                cmbTipoAlvo.SelectedIndex = 0;
                cmbAcaoED.SelectedIndex = 0;
                panelTop.Enabled = true;
                panelGrid.Visible = true;
                panelEdicao.Visible = false;
            }
        }

        private void FormatGrid(DataGridView dgv, int valor)
        {
            if (dgv.Rows.Count.Equals(0))
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    dgv.Columns[i].Visible = false;
                }
            }
            else
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    dgv.Columns[i].Visible = true;
                }
                dataGridView.Columns[2].Visible = false;
                dataGridView.Columns[15].Visible = false;
            }
        }

        private void FmEdicao_Resize(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            panelTop.BackColor = Sim.Componentes.Classes.ColorTheme.Controle;
            foreach (Control l in panelTop.Controls)
            {
                if (l is Label)
                {
                    l.ForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;
                }
            }
            label2.BackColor = Sim.Componentes.Classes.ColorTheme.Controle;
        }
    }
}
