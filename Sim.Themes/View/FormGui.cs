using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sim.Gui.View
{
    public partial class FormGui : Forms.OwnedForm
    {

        private Color ColorDestaque;
        private Color ColorBase;
        bool inverter = false;

        public FormGui()
        {
            InitializeComponent();
        }

        private void AppThemaBase(Color tema)
        {
            Properties.Settings.Default.ColorControl = tema;
            Properties.Settings.Default.Save();

            Themes.Dynamics.SetColor();

            FormCollection colecaoForms = Application.OpenForms;

            foreach (Form allForms in colecaoForms)
            {
                allForms.Refresh();
            }
        }

        private void AppThemaDestaque(Color tema)
        {
            Properties.Settings.Default.ColorHighLight = tema;
            Properties.Settings.Default.Save();

            Themes.Dynamics.SetColor();

            FormCollection colecaoForms = Application.OpenForms;

            foreach (Form allForms in colecaoForms)
            {
                allForms.Refresh();
            }
        }

        protected internal virtual void RadioButtonsDestaque(object sender, EventArgs e)
        {
            RadioButton rDB = (RadioButton)sender;

            switch (rDB.Name)
            {
                case "radioButton1":
                    ColorDestaque = radioButton1.BackColor; // Sim.Componentes.Classes.ColorTheme.Branco;
                    goto default;
                case "radioButton2":
                    ColorDestaque = radioButton2.BackColor; // Sim.Componentes.Classes.ColorTheme.Cinza;
                    goto default;
                case "radioButton3":
                    ColorDestaque = radioButton3.BackColor; // Sim.Componentes.Classes.ColorTheme.Metalico;
                    goto default;
                case "radioButton4":
                    ColorDestaque = radioButton4.BackColor; // Sim.Componentes.Classes.ColorTheme.Azul;
                    goto default;
                case "radioButton5":
                    ColorDestaque = radioButton5.BackColor; // Sim.Componentes.Classes.ColorTheme.Laranja;
                    goto default;
                case "radioButton6":
                    ColorDestaque = radioButton6.BackColor; // Sim.Componentes.Classes.ColorTheme.Roxo;
                    goto default;
                case "radioButton7":
                    ColorDestaque = radioButton7.BackColor; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                case "radioButton8":
                    ColorDestaque = radioButton8.BackColor; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                case "radioButton9":
                    ColorDestaque = radioButton9.BackColor; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                case "radioButton10":
                    ColorDestaque = radioButton10.BackColor; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                default:                   
                    AppThemaDestaque(ColorDestaque);
                    break;
            }
        }

        protected internal virtual void RadioButtonsControl(object sender, EventArgs e)
        {
            RadioButton rDB = (RadioButton)sender;

            switch (rDB.Name)
            {
                case "radioButton11":
                    ColorBase = radioButton11.BackColor; // Sim.Componentes.Classes.ColorTheme.Branco;
                    goto default;
                case "radioButton12":
                    ColorBase = radioButton12.BackColor; // Sim.Componentes.Classes.ColorTheme.Cinza;
                    goto default;
                case "radioButton13":
                    ColorBase = radioButton13.BackColor; // Sim.Componentes.Classes.ColorTheme.Metalico;
                    goto default;
                case "radioButton14":
                    ColorBase = radioButton14.BackColor; // Sim.Componentes.Classes.ColorTheme.Azul;
                    goto default;
                case "radioButton15":
                    ColorBase = radioButton15.BackColor; // Sim.Componentes.Classes.ColorTheme.Laranja;
                    goto default;
                case "radioButton16":
                    ColorBase = radioButton16.BackColor; // Sim.Componentes.Classes.ColorTheme.Roxo;
                    goto default;
                case "radioButton17":
                    ColorBase = radioButton17.BackColor; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                case "radioButton18":
                    ColorBase = radioButton18.BackColor; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                case "radioButton19":
                    ColorBase = radioButton19.BackColor; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                case "radioButton20":
                    ColorBase = radioButton20.BackColor; // Sim.Componentes.Classes.ColorTheme.Pink;
                    goto default;
                default:                   
                    AppThemaBase(ColorBase);
                    break;
            }
        }

        private void FormGui_Load(object sender, EventArgs e)
        {
            checkBoxGlass.Checked = Properties.Settings.Default.AeroGlass;
            pictureBox1.BackColor = Themes.Colors.ControlHighLight;
            pictureBox2.BackColor = Themes.Colors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            if (colorDialog.ShowDialog().Equals(DialogResult.OK))
            {
                ColorDestaque = colorDialog.Color;
                AppThemaDestaque(ColorDestaque);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            if (colorDialog.ShowDialog().Equals(DialogResult.OK))
            {
                ColorBase = colorDialog.Color;
                AppThemaBase(ColorBase);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inverter == true)
            {
                AppThemaBase(ColorDestaque);
                AppThemaDestaque(ColorBase);
                inverter = false;
            }
            else
            {
                AppThemaBase(ColorBase);
                AppThemaDestaque(ColorDestaque);
                inverter = true;
            }
        }

        private void FormGui_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.BackColor = Themes.Colors.ControlHighLight;
            pictureBox2.BackColor = Themes.Colors.Control;
        }

    }
}
