using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Portarias.Visao
{
    public partial class FmEditar : Gui.Forms.OwnedForm
    {

        Negocios.IBllPortarias LP = Negocios.Instanciar.NegociosPortarias();
        Entidade.Portarias EP = Negocios.Instanciar.EntPortarias();

        public FmEditar(Entidade.Portarias obj)
        {
            InitializeComponent();
            comboBoxClass.Items.AddRange(App.Xml.Files.Listar("Portaria", "Portarias", "Tipo", "Item").ToArray());
            showdata(obj);
        }

        private void FmEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void FmEditar_Load(object sender, EventArgs e)
        {            
            dataGridViewServidor.BackgroundColor = this.BackColor;
            AutoCompleteStringCollection Colecao = new AutoCompleteStringCollection();
            LP.Servidores().ForEach(u => Colecao.Add(u.ToString()));
            cTextBoxServidor.AutoCompleteCustomSource = Colecao;
        }

        private void showdata(Entidade.Portarias obj)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = LP.ConsultaID(obj.Indice);

                if (dt.Rows.Count > 1)
                    MessageBox.Show("Registro Duplicado! Desative um dos registros.", "Sim.Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (DataRow row in dt.Rows)
                {
                    cTextBoxIndice.Text = row["Indice"].ToString();
                    cTextBoxNumero.Text = row["Numero"].ToString();                   

                    cMaskTextBoxData.Text = Convert.ToDateTime(row["Data"].ToString()).ToString("dd/MM/yyyy"); 
                    
                    comboBoxClass.SelectedIndex = Convert.ToInt32(row["Tipo"].ToString());

                    cTextBoxDescricao.Text = (string)row["Resumo"];
                    
                    string[] linha = row["Servidor"].ToString().Split(';');

                    foreach (string l in linha)
                    {
                        dataGridViewServidor.Rows.Add("Excluir", l.ToString());
                    }
                    
                    cTextBoxUrl.Text = (string)row["Link"];
                    cTextBoxPublicado.Text = (string)row["Publicado"];

                    cMaskTextBoxInclusao.Text = Convert.ToDateTime(row["Cadastro"].ToString()).ToString("dd/MM/yyyy");
                    cMaskTextBoxAtualizacao.Text = Convert.ToDateTime(row["Atualizado"].ToString()).ToString("dd/MM/yyyy");

                    if (row["Excluido"].Equals(false))
                        radioButtonNao.Checked = true;
                    else
                        radioButtonSim.Checked = true;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private string DataForXP(string valor)
        {

            string[] sdata = valor.Split(new char[] { '/', ' ' });

            try
            {                

                if (sdata[0].Length.Equals(1))
                    sdata[0] = "0" + sdata[0];

                if (sdata[1].Length.Equals(1))
                    sdata[1] = "0" + sdata[1];
            }
            catch
            {  }

            return string.Format("{0}{1}{2}", sdata[0], sdata[1], sdata[2]);
        }

        private void cButtonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                EP.Indice = Convert.ToInt32(cTextBoxIndice.Text);
                EP.Numero = Convert.ToInt32(cTextBoxNumero.Text);
                EP.Data = Convert.ToDateTime(cMaskTextBoxData.Text);
                EP.Tipo = comboBoxClass.SelectedIndex.ToString();
                EP.Resumo = cTextBoxDescricao.Text;

                StringBuilder nnomes = new StringBuilder(string.Empty);

                foreach (DataGridViewRow rw in dataGridViewServidor.Rows)
                {

                    try
                    {

                        EP.Excluido = false;
                        EP.Servidor = rw.Cells[1].Value.ToString();

                        LP.InsertNewServidor(EP);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        nnomes.Append(string.Format("{0};", rw.Cells[1].Value));
                    }
                }

                if (nnomes.Length > 1)
                    EP.Servidor = nnomes.Remove(nnomes.Length - 1, 1).ToString();
                else
                    EP.Servidor = string.Empty;

                EP.Pdf = cTextBoxUrl.Text;
                EP.Publicada = cTextBoxPublicado.Text;
                EP.Cadastrado = Convert.ToDateTime(cMaskTextBoxInclusao.Text);
                EP.Atualizado = Convert.ToDateTime(cMaskTextBoxAtualizacao.Text);
                EP.Excluido = radioButtonSim.Checked;

                if (LP.Update(EP).Equals(true))
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cButtonIncluir_Click(object sender, EventArgs e)
        {
            dataGridViewServidor.Rows.Add("Excluir", cTextBoxServidor.Text);
            cTextBoxServidor.Text = string.Empty;
        }

        private void dataGridViewServidor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0) && e.RowIndex > -1)
            {
                dataGridViewServidor.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void groupBoxServidor_Paint(object sender, PaintEventArgs e)
        {
            dataGridViewServidor.BackgroundColor = groupBoxServidor.BackColor;
        }

    }
}
