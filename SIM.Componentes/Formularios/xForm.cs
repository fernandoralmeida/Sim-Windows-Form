using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sim.Forms
{
    public partial class xForm : Form
    {

        Sim.Classes.MoveForm MVF = new Sim.Classes.MoveForm();
        //Sim.Classes.Colors mColors = new Sim.Classes.Colors();

        public bool FormMaximizado { get; set; }
        
        public xForm()
        {
            InitializeComponent();
            RestoreSize = this.ClientSize;
        }        

        public bool FormPai { get; set; }

        public Point RestoreLocation { get; set; }

        public Size RestoreSize { get; set; }

        //private bool FormMaximizado = true;
        
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        

        private void xForm_Paint(object sender, PaintEventArgs e)
        {
            if (FormPai.Equals(false))
            {
                this.BackColor = Componentes.Classes.ColorTheme.Controle;
            }
            if (FormMaximizado == false)
                e.Graphics.DrawRectangle(new Pen(Componentes.Classes.ColorTheme.Highlight, 1), 0, 0, this.Width - 1, this.Height - 1);
        }

        private void panelT_MouseDown(object sender, MouseEventArgs e)
        {
            if (cButtonWindowsResMax.TypeButton.Equals(Sim.Controles.cButtonWindows.buttonType.resbutton))
            {
                MVF.WindosForm(this);
                RestoreLocation = new Point(this.Left, this.Top);
            }
        }

        private void xForm_TextChanged(object sender, EventArgs e)
        {
            TLabel.Text = this.Text;
        }

        private void panelT_Paint(object sender, PaintEventArgs e)
        {
            TLabel.ForeColor = Componentes.Classes.ColorTheme.ForeColor;
            panelT.BackColor = Componentes.Classes.ColorTheme.Controle;
            if (FormMaximizado == false)
            {
                e.Graphics.DrawRectangle(new Pen(Componentes.Classes.ColorTheme.Highlight, 1), 0, 0, this.Width - 1, this.Height);
                cButtonWindowsEnd.Top = 1;
                cButtonWindowsMin.Top = 1;
                cButtonWindowsResMax.Top = 1;
            }
            else
            {
                cButtonWindowsEnd.Top = 0;
                cButtonWindowsMin.Top = 0;
                cButtonWindowsResMax.Top = 0;
            }
        }

        private void xForm_Load(object sender, EventArgs e)
        {

            if (this.Size.Equals(Screen.PrimaryScreen.WorkingArea.Size))
                cButtonWindowsResMax.TypeButton = Sim.Controles.cButtonWindows.buttonType.maxbutton;
            else
                cButtonWindowsResMax.TypeButton = Sim.Controles.cButtonWindows.buttonType.resbutton;
        }

        private void xForm_Resize(object sender, EventArgs e)
        {             

        }

        private void cButtonWindowsResMax_Click(object sender, EventArgs e)
        {

            if (cButtonWindowsResMax.TypeButton.Equals(Sim.Controles.cButtonWindows.buttonType.resbutton))
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = new Point(0, 0);
                this.FormMaximizado = true;
                xFormSize.Maximizado = true;
            }
            else
            {
                this.Size = RestoreSize;
                this.Location = RestoreLocation;
                this.FormMaximizado = false;
                xFormSize.Maximizado = false;
            }
            this.Refresh();
        }

        private void cButtonWindowsEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cButtonWindowsMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }

    internal static class xFormSize
    {
        public static bool Maximizado { get; set; }
    }
}
