using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sim.Legislacao.Visao
{
    public partial class FmIncluir : Gui.Forms.OwnedForm
    {

        Negocios.IRegras Regras = Instancia.RegrasNegocios();

        Entidades.ListaAcoes ListaDeAcoes = Instancia.ListaAcoes();
        Entidades.ListaLegislacao ListarAlterar = Instancia.ListaLegislacao();        

        string tipoURL = string.Empty;
        string numeroURL = string.Empty;
        string anoURL = string.Empty;
        string compURL = string.Empty;

        Tela ModoOperacao;

        public FmIncluir(Tela tela, Entidades.ListaLegislacao lista)
        {
            InitializeComponent();

            cmbTipo.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "TiposDoc", "Item").ToArray());

            cmbOrigem.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "OrigemDoc", "Item").ToArray());

            cmbAcaoED.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "AcoesED", "Item").ToArray());

            cmbTipoAlvo.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "TiposDoc", "Item").ToArray());

            cmbSituacao.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "SituacaoAD", "Item").ToArray());
            

            if (tela == Tela.ModoIncluir)
            {
                mskTextBoxCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                mskTextBoxAtualizado.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cmbSituacao.SelectedIndex = 1;
                checkBoxRegAtivo.Checked = false;
                GrupoBoxON(false);
                ModoOperacao = Tela.ModoIncluir;
            }

            if (tela == Tela.ModoAlterar)
            {
                GrupoBoxON(true);
                ListarAlterar = lista;
                ModoOperacao = Tela.ModoAlterar;
                //Formularios.EdicaoAtiva = true;
            }

        }

        private void FormIncluir_Load(object sender, EventArgs e)
        {
            //Arquivos arqFiles = new Arquivos();

            cmbPDF.Items.AddRange(App.Dir.Files.GetFiles(string.Format(@"{0}\{1}", App.Dir.Folders.dirDesktop, App.Dir.Folders.dirPDF)));

            if (cmbPDF.Items.Count > -1)
                cmbPDF.SelectedIndex = 0;

            if(ModoOperacao == Tela.ModoAlterar)
            {

                foreach(Entidades.Legislacao leg in ListarAlterar)
                {
                    cLabelTextBoxIndice.Text = leg.Indice.ToString();

                    if (leg.Tipo == "LEI")
                        cmbTipo.SelectedIndex = 1;

                    if (leg.Tipo == "LEI COMPLEMENTAR")
                        cmbTipo.SelectedIndex = 2;

                    if (leg.Tipo == "DECRETO")
                        cmbTipo.SelectedIndex = 3;

                    //MessageBox.Show(leg.Tipo + leg.Numero + leg.Complemento);

                    txtNumero.Text = leg.Numero.ToString();
                    txtData.Text = leg.Data.ToString("dd/MM/yyyy");
                    txtComplemento.Text = leg.Complemento;
                    txtPublicacao.Text = leg.Publicado;
                    txtResumoEmenta.Text = leg.Resumo;
                    txtURL.Text = leg.Link;
                    cmbClassificação.SelectedIndex = Convert.ToInt32(leg.Classificacao);
                    cmbOrigem.SelectedIndex = Convert.ToInt32(leg.Origem);
                    txtAutor.Text = leg.Autor;
                    mskTextBoxCadastro.Text = leg.Cadastro.ToString("dd/MM/yyyy");
                    mskTextBoxAtualizado.Text= leg.Atualizado.ToString("dd/MM/yyyy");
                    checkBoxRegAtivo.Checked = leg.Excluido;
                    cmbSituacao.SelectedIndex = Convert.ToInt32(leg.Situacao);

                    //dataGridViewAcao.DataSource = leg.ListaAcoes;
                    
                    foreach (Entidades.ViewAcoes acaoexecutada in leg.ListaAcoes)
                    {

                        DataGridViewLinkCell linkCell = new DataGridViewLinkCell();                                               
                        linkCell.Value = acaoexecutada.Indice.ToString();
                        linkCell.UseColumnTextForLinkValue = false;

                        dataGridViewAcao.Rows.Add(acaoexecutada.Indice.ToString(), acaoexecutada.Acao, acaoexecutada.Tipo, acaoexecutada.Numero, acaoexecutada.Complemento, acaoexecutada.Data);
                    }
                    
                   //dataGridViewAcao.DataSource = leg.ListaAcoes;
                }

            }
        }

        private void cButtonCancel_Click(object sender, EventArgs e)
        {
            if (ModoOperacao == Tela.ModoAlterar)
                this.Close();

            if (!HDL.Equals(IntPtr.Zero))
            {
                Form.FromHandle(HDL).Dispose(); //fecha o formulario pelo Handle
                HDL = IntPtr.Zero; //reinicia a variavel handle
            }
            GrupoBoxON(false);       
        }

        private void FormIncluir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Regras = null;
            this.Dispose();
            GC.SuppressFinalize(this);
            GC.Collect();
        }
        
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbClassificação.Items.Clear();
                //carrega o combobox classificao, conforme a opção do combobox tipo
                if (cmbTipo.SelectedIndex.Equals(0))
                    cmbClassificação.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "Limpar", "Item").ToArray());//  XmlFile.XmlMLG.Limpar);

                else if (cmbTipo.SelectedIndex.Equals(3))
                    cmbClassificação.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "DecretosClassificacao", "Item").ToArray());

                else
                    cmbClassificação.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "LeisClassificacao", "Item").ToArray());

                //atribui valor a tipoURL

                if (cmbTipo.Text == "LEI")
                    tipoURL = "leis";

                if (cmbTipo.Text == "DECRETO")
                    tipoURL = "decretos";

                if (cmbTipo.Text == "LEI COMPLEMENTAR")
                    tipoURL = "leis_complementares";

                cmbClassificação.SelectedIndex = 0;
                txtURL.Text = string.Format("/{0}/{1}/{2}{3}.pdf", tipoURL, anoURL, numeroURL, compURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAutor.Items.Clear();
            //carrega o combobox autor conforme a opção escolhida no combobox origem
            if (cmbOrigem.SelectedIndex < 2)
            {
                cmbAutor.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "Limpar", "Item").ToArray());
                //atribui valor ao txtautor conforme opção do combobox origem                
            }
            else if (cmbOrigem.SelectedIndex.Equals(2))
            {
                cmbAutor.Items.AddRange(App.Xml.Files.Listar("Legislacao", "BaseDados", "AutorLegislativo", "Item").ToArray());
            }

            cmbAutor.SelectedIndex = 0;
            txtAutor.Text = cmbOrigem.Text;
        }

        private void cmbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAutor.SelectedIndex < 2)
                //atribui valor ao txtautor conforme opção do combobox autor
                txtAutor.Text = (cmbAutor.SelectedIndex.Equals(0)) ? string.Empty : cmbAutor.Text;
            else
                txtAutor.Text = string.Empty;
        }

        private void cButtonIncluirSituacao_Click(object sender, EventArgs e)
        {

            if (ModoOperacao == Tela.ModoAlterar)
            {

                var Acoes = Instancia.Acoes();

                try
                {
                    Acoes.TipoOrigem = cmbTipo.Text;
                    Acoes.NumeroOrigem = Convert.ToInt32(txtNumero.Text);
                    Acoes.ComplementoOrigem = txtComplemento.Text;
                    Acoes.DataOrigem = Convert.ToDateTime(txtData.Text);
                }
                catch (Exception ex) { throw new Exception(ex.Message); }

                List<string> docvalidos = Regras.DocValidos(cmbTipoAlvo.Text, Convert.ToInt32(txtNumeroAlvo.Text), txtCompAlvo.Text);

                if (docvalidos.Count == 0)
                {
                    MessageBox.Show("Documento não encontrado.");
                    return;
                }

                Acoes.Acao = cmbAcaoED.SelectedIndex.ToString();

                //MessageBox.Show(Acoes.Acao);

                Acoes.TipoAlvo = docvalidos[0];
                Acoes.NumeroAlvo = Convert.ToInt32(docvalidos[1]);
                Acoes.ComplementoAlvo = docvalidos[2];
                Acoes.DataAlvo = Convert.ToDateTime(docvalidos[3]);
                Acoes.Incluido = DateTime.Now;

                //MessageBox.Show(Acoes.DataAlvo.ToShortDateString());
                //Regras.InsertAcao(Acoes);

                foreach (Entidades.ViewAcoes acaoexecutada in Regras.InsertAcao(Acoes))
                {
                    /*
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    linkCell.Value = acaoexecutada.Indice.ToString();
                    linkCell.UseColumnTextForLinkValue = false;
                    */
                    dataGridViewAcao.Rows.Add(acaoexecutada.Indice.ToString(), acaoexecutada.Acao, acaoexecutada.Tipo, acaoexecutada.Numero, acaoexecutada.Complemento, acaoexecutada.Data);
                }

                //dataGridViewAcao.Rows.Add("Excluir", string.Format("{0} >", cmbAcaoED.Text), docvalidos[0], docvalidos[1], docvalidos[2], docvalidos[3]);
                
                txtNumeroAlvo.Text = string.Empty;
                txtCompAlvo.Text = string.Empty;

                return;
            }
            //adiciona ação ao datagridview
            if (!txtNumeroAlvo.Text.Equals(string.Empty))
            {
                var Acoes = Instancia.Acoes();

                try
                {
                    Acoes.TipoOrigem = cmbTipo.Text;
                    Acoes.NumeroOrigem = Convert.ToInt32(txtNumero.Text);
                    Acoes.ComplementoOrigem = txtComplemento.Text;
                    Acoes.DataOrigem = Convert.ToDateTime(txtData.Text);
                }
                catch(Exception ex) { throw new Exception(ex.Message); }

                List<string> docvalidos = Regras.DocValidos(cmbTipoAlvo.Text, Convert.ToInt32(txtNumeroAlvo.Text), txtCompAlvo.Text);

                if (docvalidos.Count == 0)
                {
                    MessageBox.Show("Documento não encontrado.");
                    return;
                }
                
                Acoes.Acao = cmbAcaoED.SelectedIndex.ToString();

                //MessageBox.Show(Acoes.Acao);

                Acoes.TipoAlvo = docvalidos[0];
                Acoes.NumeroAlvo = Convert.ToInt32(docvalidos[1]);
                Acoes.ComplementoAlvo = docvalidos[2];
                Acoes.DataAlvo = Convert.ToDateTime(docvalidos[3]);
                Acoes.Incluido = DateTime.Now;

                dataGridViewAcao.Rows.Add("Excluir", string.Format("{0}-{1}", Acoes.Acao, cmbAcaoED.Text), Acoes.TipoAlvo, Acoes.NumeroAlvo, Acoes.ComplementoAlvo, Acoes.DataAlvo);
                
                ListaDeAcoes.Add(Acoes);

                txtNumeroAlvo.Text = string.Empty;
                txtCompAlvo.Text = string.Empty;
            }
        }

        private IntPtr HDL = IntPtr.Zero; //inicia com valor 0
        private void cButtonAdd_Click(object sender, EventArgs e)
        {
            //se combobox vazio
            if (cmbPDF.Items.Count > 0)
            {
                if (HDL.Equals(IntPtr.Zero)) // handle 0 = form desativado
                {
                    Pdf.View.FormPDF FmPDF = new Pdf.View.FormPDF(cmbPDF.Text);
                    //Sim.Componentes.Formularios.newFormPDF myPDF = new Componentes.Formularios.newFormPDF(cmbPDF.Text);
                    FmPDF.ControlBox = false;                    
                    FmPDF.Show(this);
                    //myPDF.ControlBox = false;
                    //myPDF.Show(this);
                    this.Focus();
                    FmPDF.Top = this.Top;
                    FmPDF.Left = this.Left - FmPDF.Width - 5;
                    FmPDF.Height = this.Height;
                    HDL = FmPDF.Handle;
                }
                GrupoBoxON(true);
                cmbTipo.Focus();
            }
            else
            {
                MessageBox.Show("Não há documentos digitalizados para cadastro");
            }
        }

        private void cButtonGravar_Click(object sender, EventArgs e)
        {
            var Leg = Instancia.Legislacao();
            bool retorno = false;

            try
            {
                if (ModoOperacao == Tela.ModoAlterar)
                    Leg.Indice = Convert.ToInt32(cLabelTextBoxIndice.Text);             

                Leg.Tipo = cmbTipo.Text;
                Leg.Numero = Convert.ToInt32(txtNumero.Text);
                Leg.Complemento = txtComplemento.Text;
                Leg.Data = Convert.ToDateTime(txtData.Text);
                Leg.Publicado = txtPublicacao.Text;
                Leg.Resumo = txtResumoEmenta.Text;
                Leg.Classificacao = cmbClassificação.SelectedIndex.ToString();
                Leg.Link = txtURL.Text;
                Leg.Situacao = cmbSituacao.SelectedIndex.ToString();
                Leg.Origem = cmbOrigem.SelectedIndex.ToString();
                Leg.Autor = txtAutor.Text;
                Leg.Cadastro = Convert.ToDateTime(mskTextBoxCadastro.Text);
                Leg.Atualizado = Convert.ToDateTime(mskTextBoxAtualizado.Text);
                Leg.Excluido = checkBoxRegAtivo.Checked ? true : false;
            }
            catch(Exception ex) { throw new Exception(ex.Message); }

            if (ModoOperacao == Tela.ModoAlterar)
                retorno = Regras.Update(Leg);
            else
                retorno = Regras.Insert(Leg, ListaDeAcoes);

            if (retorno == true)
            {
                if (ModoOperacao == Tela.ModoAlterar)
                    this.Close();

                GrupoBoxON(false);
            }
            else
                MessageBox.Show("Erro!");

        }

        // oculta ou mostra os GroupBox
        private void GrupoBoxON(bool valor)
        {
            if (valor.Equals(true))
            {
                groupBoxDOC.Visible = true;
                groupBoxAED.Visible = true;
                groupBoxCMD.Visible = true;
                cGroupBoxInfo.Visible = true;
                panelTop.Enabled = false;
            }
            else
            {

                if (HDL != IntPtr.Zero)
                {
                    Form.FromHandle(HDL).Dispose(); //fecha o formulario pelo Handle
                    HDL = IntPtr.Zero; //reinicia a variavel handle
                }
                
                dataGridViewAcao.Rows.Clear();
                groupBoxDOC.Visible = false;
                groupBoxAED.Visible = false;
                groupBoxCMD.Visible = false;
                cGroupBoxInfo.Visible = false;

                cmbTipo.SelectedIndex = 0;
                cmbSituacao.SelectedIndex = 1;
                cmbClassificação.SelectedIndex = -1;
                cmbOrigem.SelectedIndex = 0;
                cmbAutor.SelectedIndex = 0;
                cmbAcaoED.SelectedIndex = 0;
                cmbTipoAlvo.SelectedIndex = 0;

                txtNumero.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                txtData.Text = string.Empty;
                txtPublicacao.Text = string.Empty;
                txtResumoEmenta.Text = string.Empty;
                txtAutor.Text = string.Empty;
                txtCompAlvo.Text = string.Empty;
                txtNumeroAlvo.Text = string.Empty;

                cLabelTextBoxIndice.Text = string.Empty;
                txtURL.Text = "...";
                mskTextBoxCadastro.ToDate = DateTime.Now;
                mskTextBoxAtualizado.ToDate = DateTime.Now;

                checkBoxRegAtivo.Checked = false;

                ListaDeAcoes.Clear();
                ListarAlterar.Clear();

                cmbPDF.Items.Remove(cmbPDF.SelectedIndex);

                panelTop.Enabled = true;
                
            }
            groupBoxDOC.Focus();
            cmbTipo.Focus();
        }

        private void FmIncluir_Move(object sender, EventArgs e)
        {
            if (HDL != IntPtr.Zero)
            {
                Form.FromHandle(HDL).Top = this.Top;
                Form.FromHandle(HDL).Left = this.Left - Form.FromHandle(HDL).Width - 5;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            numeroURL = txtNumero.Text;
            txtURL.Text = string.Format("/{0}/{1}/{2}{3}.pdf", tipoURL, anoURL, numeroURL, compURL);
        }

        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            compURL = txtComplemento.Text;
            txtURL.Text = string.Format("/{0}/{1}/{2}{3}.pdf", tipoURL, anoURL, numeroURL, compURL);
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            if (txtData.Text.Length > 9)
            {
                anoURL = txtData.Text.Remove(0, 6);
                txtURL.Text = string.Format("/{0}/{1}/{2}{3}.pdf", tipoURL, anoURL, numeroURL, compURL);
            }
        }

        ///*
        /// Mododo Alterar
        /// 
        
        private void MostrarDados()
        {

        }

        private void dataGridViewAcao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ModoOperacao == Tela.ModoAlterar)
            {

                if (e.ColumnIndex == 0 && e.RowIndex > -1)
                {
                    var Acao = new Entidades.Acoes();
                    Acao.Indice = Convert.ToInt32(dataGridViewAcao.CurrentCell.Value.ToString());
                    Acao.TipoAlvo = dataGridViewAcao.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Acao.NumeroAlvo = Convert.ToInt32(dataGridViewAcao.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Acao.ComplementoAlvo = dataGridViewAcao.Rows[e.RowIndex].Cells[4].Value.ToString();
                    Acao.DataAlvo = Convert.ToDateTime(dataGridViewAcao.Rows[e.RowIndex].Cells[5].Value.ToString());
                    if ( Regras.DelAcao(Acao) == true)
                        dataGridViewAcao.Rows.RemoveAt(e.RowIndex);
                }

                dataGridViewAcao.Refresh();
                return;
            }

            //remove ação do datagridview
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                dataGridViewAcao.Rows.RemoveAt(e.RowIndex);
                ListaDeAcoes.RemoveAt(e.RowIndex);
            }

            dataGridViewAcao.Refresh();
        }
    }
}
