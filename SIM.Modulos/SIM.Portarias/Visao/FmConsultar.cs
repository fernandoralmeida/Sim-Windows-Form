using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sim.Portarias.Visao
{
    public partial class FmConsultar : Gui.Forms.OwnedForm // Sim.Componentes.Formularios.xFormChild
    {

        Negocios.IBllPortarias LP = Negocios.Instanciar.NegociosPortarias();
        Entidade.Portarias EP = Negocios.Instanciar.EntPortarias();

        Entidade.ListViewPortarias ListarPortarias = Negocios.Instanciar.ListaPortarias();
        
        public FmConsultar()
        {
            InitializeComponent();
            dataGridPortarias.AppTheme();
        }

        private void FmConsultar_FormClosed(object sender, FormClosedEventArgs e)
        {            
            this.Dispose();
        }

        private void FmConsultar_Load(object sender, EventArgs e)
        {
            Negocios.Handles.Consulta = this.Handle;

            comboBoxClass.Items.AddRange(App.Xml.Files.Listar("Portaria", "Portarias", "Tipo", "Item").ToArray());

            if (comboBoxClass.Items.Count > 0)
                comboBoxClass.SelectedIndex = 0;     
        }

        private void cButtonProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SegundoPlano.IsBusy)
                    MessageBox.Show("Pesquisa em andamento, aguarde!", "Sim.Alerta", MessageBoxButtons.OK ,MessageBoxIcon.Asterisk);
                else
                {

                    EP.Tipo = (comboBoxClass.SelectedIndex.Equals(0)) ? "%" : comboBoxClass.SelectedIndex.ToString();
                    EP.NumeroI = (cTextBoxNumero.Text.Equals(string.Empty)) ? 0 : Convert.ToInt32(cTextBoxNumero.Text);
                    EP.NumeroF = (cTextBoxNumero.Text.Equals(string.Empty)) ? 999999 : Convert.ToInt32(cTextBoxNumero.Text);
                    EP.AnoI = (cTextBoxAno.Text.Equals(string.Empty)) ? "1853" : cTextBoxAno.Text;
                    EP.AnoF = (cTextBoxAno.Text.Equals(string.Empty)) ? DateTime.Now.Year.ToString() : cTextBoxAno.Text;
                    EP.Servidor = (cTextBoxServidor.Text.Equals(string.Empty)) ? "%" : string.Format("%{0}%", cTextBoxServidor.Text);
                    EP.Resumo = (cTextBoxKeyword.Text.Equals(string.Empty)) ? "%" : string.Format("%{0}%", cTextBoxKeyword.Text);

                    SegundoPlano.RunWorkerAsync();
                }
  
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
        }
        
        private void cButtonClear_Click(object sender, EventArgs e)
        {
            comboBoxClass.SelectedIndex = 0;
            dataGridPortarias.Listar = null;
        }

        private void SegundoPlano_DoWork(object sender, DoWorkEventArgs e)
        {
            ListarPortarias = LP.ConsultaDetalhada(EP);
        }

        private void SegundoPlano_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {}

        private void SegundoPlano_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridPortarias.Listar = ListarPortarias;
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        { }

        private void FmConsultar_Paint(object sender, PaintEventArgs e)
        { }

        private void cTextBoxServidor_TextChanged(object sender, EventArgs e)
        { }

    }
}
