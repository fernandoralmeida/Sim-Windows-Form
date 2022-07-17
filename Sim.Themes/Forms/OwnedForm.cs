using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Sim.Gui.Forms
{
    public partial class OwnedForm : Form
    {

        Class.MoveForm MVF = new Class.MoveForm();

        public OwnedForm()
        {
            InitializeComponent();
        }

        public bool FormMaximizado { get; set; }
        
        Size oldSize;
        Point oldLocation;

        public bool SideColor { get; set; }

        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
                TLabel.Text = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {            

            this.oldSize = this.Size;
            this.oldLocation = this.Location;

            if (this.MinimizeBox.Equals(false))
                cButtonWindowsMin.Visible = false;

            if (this.MaximizeBox.Equals(false))
                cButtonWindowsResMax.Visible = false;

            if (ControlBox == false)
            {
                cButtonWindowsEnd.Visible = false;
                cButtonWindowsResMax.Visible = false;
                cButtonWindowsMin.Visible = false;
            }

            base.OnLoad(e);         

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (cButtonWindowsResMax.TypeControlBox == Gui.Controls.ControlBoxType.Restore)
            {
                this.MVF.WindosForm(this);
                this.oldLocation = new Point(this.Left, this.Top);
            }
            base.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {            

            this.BackColor = Themes.Colors.Control;

            TLabel.ForeColor = Themes.Colors.Font;

            if (SideColor == true)
            {
                Rectangle rect = new Rectangle(new Point(0, 25), new Size(60, this.Height - 25));
                LinearGradientBrush gradient = new LinearGradientBrush(rect, Themes.Colors.Control, Themes.Colors.ControlHighLight, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(gradient, 0, 25, 60, this.Height - 25);
            }

            if (FormMaximizado.Equals(false))
            {
                //e.Graphics.DrawRectangle(new Pen(Componentes.Classes.ColorTheme.Highlight, 8), 0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(Themes.Pens.ControlHighLight, 0, 0, this.Width - 1, this.Height - 1);
                //e.Graphics.DrawRectangle(Componentes.Classes.ColorTheme.PenDarkDark, 4, 24, this.Width - 10, this.Height - 30);
            }
            
            base.OnPaint(e);
        }

        private void cButtonWindowsEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cButtonWindowsResMax_Click(object sender, EventArgs e)
        {
            if (cButtonWindowsResMax.TypeControlBox == Gui.Controls.ControlBoxType.Restore)
            {
                this.Size = Class.ActiveArea.Tamanho();
                this.Location = Class.ActiveArea.Local();

                if (Forms.OwnerFormSize.Maximizado == false)
                {
                    this.Left = Class.ActiveArea.Local().X + 1;
                    this.Height = Class.ActiveArea.Tamanho().Height - 1;
                    this.Width = Class.ActiveArea.Tamanho().Width - 2;
                }

                this.FormMaximizado = true;
            }
            else
            {
                this.Size = this.oldSize;
                this.Location = this.oldLocation;
                this.FormMaximizado = false;
            }
            this.Refresh();
        }

        private void cButtonWindowsMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void panelT_Paint(object sender, PaintEventArgs e)
        {
            if (FormMaximizado == false)
                e.Graphics.DrawRectangle(Themes.Pens.ControlHighLight, 0, 0, panelT.Width - 1, panelT.Height);
        }

        private void panelT_MouseDown(object sender, MouseEventArgs e)
        {
            if (cButtonWindowsResMax.TypeControlBox == Gui.Controls.ControlBoxType.Restore)
            {
                this.MVF.WindosForm(this);
                this.oldLocation = new Point(this.Left, this.Top);
            }
        }
    }
}
