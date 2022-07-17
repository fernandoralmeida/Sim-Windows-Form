using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sim.Componentes.Formularios
{
    public partial class xFormChild : Form
    {

        Sim.Classes.MoveForm MVF = new Sim.Classes.MoveForm();

        public xFormChild()
        {
            Classes.ColorTheme.GetTheme();
            SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }

        public bool FormMaximizado { get; set; }
        
        /*
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
        */

        Size oldSize;
        Point oldLocation;
        private void xFormChild_Load(object sender, EventArgs e)
        {
            this.oldSize = this.Size;
            this.oldLocation = this.Location;

            if (this.MinimizeBox.Equals(false))
                cButtonWindowsMin.Visible = false;

            if (this.MaximizeBox.Equals(false))
                cButtonWindowsResMax.Visible = false;

        }

        private void xFormChild_Paint(object sender, PaintEventArgs e)
        {


            this.BackColor = Componentes.Classes.ColorTheme.Controle;

            TLabel.ForeColor = Componentes.Classes.ColorTheme.ForeColor;

            if (FormMaximizado.Equals(false))
            {
                //e.Graphics.DrawRectangle(new Pen(Componentes.Classes.ColorTheme.Highlight, 8), 0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(new Pen(Componentes.Classes.ColorTheme.Highlight, 1), 0, 0, this.Width - 1, this.Height - 1);
                //e.Graphics.DrawRectangle(Componentes.Classes.ColorTheme.PenDarkDark, 4, 24, this.Width - 10, this.Height - 30);
            }
            
        }

        private void cButtonWindowsEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cButtonWindowsResMax_Click(object sender, EventArgs e)
        {
            if (cButtonWindowsResMax.TypeButton.Equals(Sim.Controles.cButtonWindows.buttonType.resbutton))
            {
                this.Size = Sim.Componentes.Classes.AreaTrabalho.Tamanho();
                this.Location = Sim.Componentes.Classes.AreaTrabalho.Local();

                if (Forms.xFormSize.Maximizado == false)
                {
                    this.Left = Classes.AreaTrabalho.Local().X + 1;
                    this.Height = Classes.AreaTrabalho.Tamanho().Height - 1;
                    this.Width = Classes.AreaTrabalho.Tamanho().Width - 2;
                }

                this.FormMaximizado = true;
            }
            else
            {
                this.Size = this.oldSize;
                this.Location = this.oldLocation;
                this.FormMaximizado = false;
            }
        }

        private void cButtonWindowsMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelT_MouseDown(object sender, MouseEventArgs e)
        {
            if (cButtonWindowsResMax.TypeButton.Equals(Sim.Controles.cButtonWindows.buttonType.resbutton))
            {
                this.MVF.WindosForm(this);
                this.oldLocation = new Point(this.Left, this.Top);
            }
        }

        private void xFormChild_TextChanged(object sender, EventArgs e)
        {
            TLabel.Text = this.Text;
        }

        private void panelT_Paint(object sender, PaintEventArgs e)
        {

            //panelT.BackColor = Componentes.Classes.ColorTheme.TitleBar;
            
            //e.Graphics.DrawRectangle(new Pen(Componentes.Classes.ColorTheme.SolidBrushDark, 8), 0, 0, this.Width - 1, this.Height - 1);
            
            if (FormMaximizado.Equals(false))
            {
                e.Graphics.DrawRectangle(new Pen(Componentes.Classes.ColorTheme.Highlight, 1), 0, 0, this.Width - 1, this.Height);
                //e.Graphics.DrawRectangle(Componentes.Classes.ColorTheme.PenDarkDark, 4, 24, this.Width - 10, this.Height - 27);
            }
            
            
        }

    }
}
