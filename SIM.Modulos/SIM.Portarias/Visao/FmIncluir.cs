using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sim.Portarias.Visao
{
    public partial class FmIncluir : Gui.Forms.OwnedForm
    {
        
        Negocios.IBllPortarias DataAccess = Negocios.Instanciar.NegociosPortarias();
        Entidade.Portarias Portaria = Negocios.Instanciar.EntPortarias();
         
        public FmIncluir()
        {
            InitializeComponent();
            dataGridViewServidor.Columns[0].Width = 65;
        }

        private void FmIncluir_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        
        private void FmIncluir_Load(object sender, EventArgs e)
        {
            comboBoxClass.Items.AddRange(App.Xml.Files.Listar("Portaria", "Portarias", "Tipo", "Item").ToArray());

            AutoCompleteStringCollection Colecao = new AutoCompleteStringCollection();
            DataAccess.Servidores().ForEach(u => Colecao.Add(u.ToString()));
            cTextBoxServidor.AutoCompleteCustomSource = Colecao;
            dataGridViewServidor.BackgroundColor = this.BackColor;
        }

        private void cButtonIncluir_Click(object sender, EventArgs e)
        {
            dataGridViewServidor.Rows.Add("", cTextBoxServidor.Text);
            cTextBoxServidor.Text = string.Empty;
            cTextBoxServidor.Focus();
        }

        private void dataGridViewServidor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0) && e.RowIndex > -1)
                dataGridViewServidor.Rows.RemoveAt(e.RowIndex);

            dataGridViewServidor.Refresh();            
        }

        private void cButtonGravar_Click(object sender, EventArgs e)
        {
            bool gravado = false;
            try
            {

                Portaria.Numero = Convert.ToInt32(cTextBoxNumero.Text);
                Portaria.Data = cMaskTextBoxData.ToDate;
                Portaria.Tipo = comboBoxClass.SelectedIndex.ToString();
                Portaria.Resumo = cTextBoxDescricao.Text;

                Portaria.Pdf = string.Format(@"{0}\{1}.pdf", cMaskTextBoxData.ToDate.Year, Portaria.Numero);
                Portaria.Publicada = "0";
                Portaria.Cadastrado = DateTime.Now;
                Portaria.Atualizado = DateTime.Now;
                Portaria.Excluido = false;

                StringBuilder nnomes = new StringBuilder(string.Empty);

                foreach (DataGridViewRow rw in dataGridViewServidor.Rows)
                {
                    Portaria.Excluido = false;
                    Portaria.Servidor = rw.Cells[1].Value.ToString();

                    DataAccess.InsertNewServidor(Portaria);
                    nnomes.Append(string.Format("{0};", rw.Cells[1].Value));
                }

                if (nnomes.Length > 1)
                    Portaria.Servidor = nnomes.Remove(nnomes.Length - 1, 1).ToString();

                gravado = DataAccess.Insert(Portaria);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sim.Alerta");
            }

            if (gravado.Equals(true))
            {
                dataGridViewServidor.Rows.Clear();
                cTextBoxNumero.Text = string.Empty;
                cMaskTextBoxData.Text = string.Empty;
                comboBoxClass.SelectedIndex = 0;
                cTextBoxDescricao.Text = string.Empty;
                cTextBoxNumero.Focus();                
            }
                
        }

        private void cButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FmIncluir_Paint(object sender, PaintEventArgs e)
        {
            dataGridViewServidor.BackgroundColor = this.BackColor;
            dataGridViewServidor.GridColor = Gui.Themes.Colors.ControlDark;
        }

    }
}
