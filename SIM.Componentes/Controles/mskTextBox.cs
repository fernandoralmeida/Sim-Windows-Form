using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Sim.Componentes.Controles
{
    public partial class mskTextBox : Control
    {

        #region Variaveis

        bool inFocus = false;
        
        #endregion

        #region Construtor
        public mskTextBox()
        {
            SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
            Sim.Componentes.Classes.ColorTheme.GetTheme();
            InitializeComponent();
        }

        public mskTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion


        #region Propriedades

        public MaskFormat MaskFormato
        {
            get { return maskedTextBox.TextMaskFormat; }
            set { maskedTextBox.TextMaskFormat = value; }
        }

        public string Mascara
        {
            get { return maskedTextBox.Mask; }
            set { maskedTextBox.Mask = value; }
        }

        public override string Text
        {
            get
            {
                return maskedTextBox.Text;
            }
            set
            {
                maskedTextBox.Text = value;
            }
        }

        public DateTime ToDate
        {
            get
            {
                DateTime value;
                if (!DateTime.TryParse(maskedTextBox.Text, out value))
                {
                    maskedTextBox.Text = DateTime.Today.ToShortDateString();
                }
                return Convert.ToDateTime(maskedTextBox.Text);
            }
            set { maskedTextBox.Text = value.ToString("dd/MM/yyyy"); }
        }

        #endregion

        #region Overrides

        protected override void OnEnter(EventArgs e)
        {
            this.inFocus = true;
            base.OnEnter(e);
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            this.inFocus = false;
            base.OnLeave(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            float[] dashValues = { 1.0F, 1.0F, 1.0F, 1.0F };
            Rectangle areafocus = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));

            e.Graphics.DrawRectangle(Classes.ColorTheme.PenLight, 0, 0, this.Width - 1, this.Height - 1);
            e.Graphics.DrawRectangle(Classes.ColorTheme.PenDarkDark, 1, 1, this.Width - 3, this.Height - 3);
            this.BackColor = Classes.ColorTheme.ControleDark;

            if (this.inFocus.Equals(true))
            {
                Pen bluePen = new Pen(Classes.ColorTheme.HighlightDark, 1);
                bluePen.DashPattern = dashValues;
                e.Graphics.DrawRectangle(bluePen, areafocus);
                e.Graphics.DrawRectangle(new Pen(Classes.ColorTheme.Highlight, 1), 1, 1, this.Width - 3, this.Height - 3);
            }
            
            int y;
            y = ((this.Height - maskedTextBox.Height) / 2) + 1;
            maskedTextBox.Location = new Point(5, y);
            maskedTextBox.Width = this.Width - 10;
            maskedTextBox.ForeColor = Classes.ColorTheme.ForeColor;
            maskedTextBox.BackColor = this.BackColor;

            base.OnPaint(e);
        }

        #endregion

    }
}
