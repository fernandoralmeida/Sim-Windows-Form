using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Sim.Forms
{
    public partial class cForm : Form
    {
        
        //Formulario base pra todos os Formularios

        Sim.Classes.MoveForm MVF = new Sim.Classes.MoveForm();
        //Sim.Classes.Colors mColors = new Sim.Classes.Colors();

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

        public cForm()
        {
            InitializeComponent();
        }

        public cForm(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void cForm_Paint(object sender, PaintEventArgs e)
        {

            Componentes.Classes.ColorTheme.GetTheme();

            e.Graphics.FillRectangle(new SolidBrush(Sim.Componentes.Classes.ColorTheme.Controle), 0, 0, this.Width, this.Height);
            e.Graphics.FillRectangle(new SolidBrush(Sim.Componentes.Classes.ColorTheme.Highlight), 0, 0, 60, this.Height);
            //e.Graphics.DrawRectangle(mColors.myPen, 0, 0, this.Width - 1, this.Height - 1);
                        
            e.Graphics.DrawLine(Componentes.Classes.ColorTheme.PenDarkDark, 75, 25, (this.Width - 10), 25);
            e.Graphics.DrawLine(Componentes.Classes.ColorTheme.PenLight, 75, 26, (this.Width - 10), 26);
            //e.Graphics.DrawLine(Pens.WhiteSmoke, 75, 27, (this.Width - 10), 27);

            FormTitulo.ForeColor = Componentes.Classes.ColorTheme.ForeColor;

        }

        private void cForm_TextChanged(object sender, EventArgs e)
        {
            FormTitulo.Text = this.Text;
        }

        private void cForm_MouseDown(object sender, MouseEventArgs e)
        {
            MVF.WindosForm(this);
        }

        private void cForm_Load(object sender, EventArgs e)
        {
            cButtonWindows2.BackColor = Sim.Componentes.Classes.ColorTheme.Controle;
        }
        
    }
}
