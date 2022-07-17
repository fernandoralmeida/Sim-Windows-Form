using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sim.Gui.Forms
{
    public partial class OwnerForm : Form
    {

        Class.MoveForm MVF = new Class.MoveForm();

        public bool FormMaximizado { get; set; }
        
        public OwnerForm()
        {
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            RestoreSize = this.ClientSize;
        }        

        public bool FormPai { get; set; }

        public Point RestoreLocation { get; set; }

        public Size RestoreSize { get; set; }

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

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            panelT.BackColor = Themes.Colors.Control;

            this.BackColor = Themes.Colors.Control;

            Rectangle rect = new Rectangle(-1, -1, this.Width, this.Height);

            if (FormMaximizado == false)
                rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            e.Graphics.DrawRectangle(Themes.Pens.ControlHighLight, rect);

            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (this.Size.Equals(Screen.PrimaryScreen.WorkingArea.Size))
                ControlBoxMax.TypeControlBox = Gui.Controls.ControlBoxType.Maximize;
            else
                ControlBoxMax.TypeControlBox = Gui.Controls.ControlBoxType.Restore;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        private void panelT_MouseDown(object sender, MouseEventArgs e)
        {
            if (ControlBoxMax.TypeControlBox == Gui.Controls.ControlBoxType.Restore)
            {
                MVF.WindosForm(this);
                RestoreLocation = new Point(this.Left, this.Top);
            }
        }

        private void panelT_Paint(object sender, PaintEventArgs e)
        {
            TLabel.ForeColor = Themes.Colors.Font;

            if (FormMaximizado == false)
            {
                e.Graphics.DrawRectangle(Themes.Pens.ControlHighLight, 0, 0, this.Width - 1, this.Height);
                ControlBoxEnd.Top = 1;
                ControlBoxMin.Top = 1;
                ControlBoxMax.Top = 1;
            }
            else
            {
                ControlBoxEnd.Top = 0;
                ControlBoxMin.Top = 0;
                ControlBoxMax.Top = 0;
            }
        }

        private void cButtonWindowsResMax_Click(object sender, EventArgs e)
        {

            if (ControlBoxMax.TypeControlBox == Gui.Controls.ControlBoxType.Restore)
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = new Point(0, 0);
                this.FormMaximizado = true;
                OwnerFormSize.Maximizado = true;
            }
            else
            {
                this.Size = RestoreSize;

                if (RestoreLocation == new Point(0, 0))
                    RestoreLocation = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2), Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);

                this.Location = RestoreLocation;
                this.FormMaximizado = false;
                OwnerFormSize.Maximizado = false;
            }
            Invalidate();
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

    internal static class OwnerFormSize
    {
        public static bool Maximizado { get; set; }
    }
}
