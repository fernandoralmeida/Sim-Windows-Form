using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Desktop.Visao
{
    public partial class FmUI : Sim.Componentes.Formularios.xFormChild
    {

        private Color ColorDestaque;
        private Color ColorBase;

        public FmUI()
        {
            InitializeComponent();
        }

        private void AppThemaBase(System.Drawing.Color tema)
        {
            Sim.Componentes.Properties.Settings.Default.Tema = tema;
            Sim.Componentes.Properties.Settings.Default.Save();

            Sim.Componentes.Classes.ColorTheme.GetTheme();

            FormCollection colecaoForms = Application.OpenForms;

            foreach (Form allForms in colecaoForms)
            {
                allForms.Refresh();
            }
        }

        private void AppThemaDestaque(System.Drawing.Color tema)
        {
            Sim.Componentes.Properties.Settings.Default.TemaDestaque = tema;
            Sim.Componentes.Properties.Settings.Default.Save();

            Sim.Componentes.Classes.ColorTheme.GetTheme();

            FormCollection colecaoForms = Application.OpenForms;
            
            foreach (Form allForms in colecaoForms)
            {
                allForms.Refresh();
            }
        }

        private void FmUI_Load(object sender, EventArgs e)
        {
            this.ColorDestaque = Sim.Componentes.Properties.Settings.Default.TemaDestaque;
            this.ColorBase = Sim.Componentes.Properties.Settings.Default.Tema;

            checkBoxAero.Checked = Sim.Componentes.Properties.Settings.Default.Aero;
            checkBoxWindow.Checked = Sim.Componentes.Properties.Settings.Default.WindowsColor;

            foreach (Sim.Controles.cRadioButton crb in cGroupBoxDestaque.Controls)
            {
                if (crb is Sim.Controles.cRadioButton)
                {
                    crb.Checked = (crb.BackColor.Equals(Sim.Componentes.Properties.Settings.Default.TemaDestaque)) ? true : false;
                }
            }

            foreach (Sim.Controles.cRadioButton crb in cGroupBoxBase.Controls)
            {
                if (crb is Sim.Controles.cRadioButton)
                {
                    crb.Checked = (crb.BackColor.Equals(Sim.Componentes.Properties.Settings.Default.Tema)) ? true : false;
                }
            }
        }

        private void checkBoxAero_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxAero.Checked)
            {
                case true:
                    Sim.Componentes.Properties.Settings.Default.Aero = true;
                    goto default;

                case false:
                    Sim.Componentes.Properties.Settings.Default.Aero = false;
                    goto default;

                default:
                    Sim.Componentes.Properties.Settings.Default.Save();
                    break;
            }
        }

        private void checkBoxWindow_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxWindow.Checked)
            {
                case true:
                    Sim.Componentes.Properties.Settings.Default.WindowsColor = true;
                    goto default;

                case false:
                    Sim.Componentes.Properties.Settings.Default.WindowsColor = false;
                    goto default;

                default:
                    Sim.Componentes.Properties.Settings.Default.Save();
                    AppThemaBase(ColorBase);
                    break;
            }
        }

        private void cButtonColorDestaque_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog().Equals(DialogResult.OK))
            {
                ColorDestaque = colorDialog.Color;
                AppThemaDestaque(ColorDestaque);
            }
        }

        private void cButtonColorBase_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog().Equals(DialogResult.OK))
            {
                ColorBase = colorDialog.Color;
                AppThemaBase(ColorBase);
            }
        }

        protected internal virtual void RadioButtonsBase(object sender, EventArgs e)
        {
            RadioButton rDB = (RadioButton)sender;

            switch (rDB.Name)
            {
                case "cRadioB1":
                    ColorBase = cRadioB1.ColorChek; // Sim.Componentes.Classes.ColorTheme.Branco;
                    goto default;
                case "cRadioB2":
                    ColorBase = cRadioB2.ColorChek; // Sim.Componentes.Classes.ColorTheme.Cinza;
                    goto default;
                case "cRadioB3":
                    ColorBase = cRadioB3.ColorChek; // Sim.Componentes.Classes.ColorTheme.Metalico;
                    goto default;
                case "cRadioB4":
                    ColorBase = cRadioB4.ColorChek; // Sim.Componentes.Classes.ColorTheme.Azul;
                    goto default;
                case "cRadioB5":
                    ColorBase = cRadioB5.ColorChek; // Sim.Componentes.Classes.ColorTheme.Laranja;
                    goto default;
                case "cRadioB6":
                    ColorBase = cRadioB6.ColorChek; // Sim.Componentes.Classes.ColorTheme.Roxo;
                    goto default;
                case "cRadioB7":
                    ColorBase = cRadioB7.ColorChek; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                default:
                    //Sim.Componentes.Properties.Settings.Default.Save();                    
                    AppThemaBase(ColorBase);
                    break;
            }
        }

        protected internal virtual void RadioButtonsDestaque(object sender, EventArgs e)
        {
            RadioButton rDB = (RadioButton)sender;

            switch (rDB.Name)
            {
                case "cRadioD1":
                    ColorDestaque = cRadioD1.ColorChek; // Sim.Componentes.Classes.ColorTheme.Branco;
                    goto default;
                case "cRadioD2":
                    ColorDestaque = cRadioD2.ColorChek; // Sim.Componentes.Classes.ColorTheme.Cinza;
                    goto default;
                case "cRadioD3":
                    ColorDestaque = cRadioD3.ColorChek; // Sim.Componentes.Classes.ColorTheme.Metalico;
                    goto default;
                case "cRadioD4":
                    ColorDestaque = cRadioD4.ColorChek; // Sim.Componentes.Classes.ColorTheme.Azul;
                    goto default;
                case "cRadioD5":
                    ColorDestaque = cRadioD5.ColorChek; // Sim.Componentes.Classes.ColorTheme.Laranja;
                    goto default;
                case "cRadioD6":
                    ColorDestaque = cRadioD6.ColorChek; // Sim.Componentes.Classes.ColorTheme.Roxo;
                    goto default;
                case "cRadioD7":
                    ColorDestaque = cRadioD7.ColorChek; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                default:
                    //Sim.Componentes.Properties.Settings.Default.Save();                    
                    AppThemaDestaque(ColorDestaque);
                    break;
            }
        }

        private void checkBoxInverter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInverter.Checked.Equals(true))
            {
                AppThemaBase(ColorDestaque);
                AppThemaDestaque(ColorBase);
            }
            else
            {
                AppThemaBase(ColorBase);
                AppThemaDestaque(ColorDestaque);
            }
        }

        private void FmUI_Paint(object sender, PaintEventArgs e)
        {
            checkBoxAero.ForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;
            checkBoxWindow.ForeColor= Sim.Componentes.Classes.ColorTheme.ForeColor;
            checkBoxInverter.ForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;
        }
    }
}
