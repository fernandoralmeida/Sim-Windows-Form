using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sim.Controles
{
    public partial class cLabelTextBox : Control
    {

        #region Variaveis
        
        bool inFocus = false;
        char psswchar;

        #endregion

        #region Contrutor

        public cLabelTextBox()
        {            
            
            InitializeComponent();
            SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
        }

        public cLabelTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        #endregion

        #region Propriedades

        public bool isReadOnly
        {
            get { return textBox.ReadOnly; }
            set { textBox.ReadOnly = value; }
        }
        public bool isLetter { get; set; }

        public bool isNumeric
        {
            get;
            set;
        }

        public char PsswChar
        {
            get { return psswchar; }
            set { psswchar = value; textBox.PasswordChar = psswchar; }
        }
        
        public CharacterCasing CharacterCase
        {
            get { return textBox.CharacterCasing; }
            set
            {
                textBox.CharacterCasing = value;
            }
        }

        public override string Text
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }

        public bool Multiline
        {
            get { return textBox.Multiline; }
            set { textBox.Multiline = value; Invalidate(); }
        }

        public AutoCompleteMode AutoCompleteMode
        {
            get { return textBox.AutoCompleteMode; }
            set { textBox.AutoCompleteMode = value; }
        }

        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return textBox.AutoCompleteCustomSource; }
            set { textBox.AutoCompleteCustomSource = value; }
        }

        public AutoCompleteSource AutoCompleteSource
        {
            get { return textBox.AutoCompleteSource; }
            set { textBox.AutoCompleteSource = value; }
        }

        #endregion

        #region Overrides

        public void FocusText()
        {
            textBox.Focus();
        }

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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            Componentes.Classes.ColorTheme.GetTheme();

            float[] dashValues = { 1.0F, 1.0F, 1.0F, 1.0F };
            Rectangle areafocus = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));

            e.Graphics.DrawRectangle(Sim.Componentes.Classes.ColorTheme.PenLight, 0, 0, this.Width - 1, this.Height - 1);
            e.Graphics.DrawRectangle(Sim.Componentes.Classes.ColorTheme.PenDarkDark, 1, 1, this.Width - 3, this.Height - 3);
            this.BackColor = Sim.Componentes.Classes.ColorTheme.ControleDark;
            
            if (this.inFocus.Equals(true))
            {
                Pen bluePen = new Pen(Componentes.Classes.ColorTheme.HighlightDark, 1);
                bluePen.DashPattern = dashValues;
                e.Graphics.DrawRectangle(bluePen, areafocus);
                e.Graphics.DrawRectangle(new Pen(Componentes.Classes.ColorTheme.Highlight, 1), 1, 1, this.Width - 3, this.Height - 3);
            }
            
            //#Desenha_TextBox:
            int x = 5, y = 0;

            if (Multiline.Equals(false))
            {
                y = ((this.Height - textBox.Height) / 2) + 1;
                textBox.Location = new Point(x, y);
                textBox.Width = this.Width - 10;
            }
            else
            {
                y = 5;
                textBox.Location = new Point(x, y);
                textBox.Size = new Size(this.Width - 10, this.Height - 10);
            }
                        
            textBox.ForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;
            textBox.BackColor = this.BackColor;
            //#Fim
            base.OnPaint(e);
        }

        #endregion

        #region Eventos textbox

        private void textBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (isNumeric.Equals(true))
            {
                if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }

            if (isLetter.Equals(true))
            {
                if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar)))
                    e.Handled = true;
            }

        }

        /*
        private void textBox_TextChanged(object sender, System.EventArgs e)
        {
            this.Text = textBox.Text;
        }
        */
        #endregion

    }
}
