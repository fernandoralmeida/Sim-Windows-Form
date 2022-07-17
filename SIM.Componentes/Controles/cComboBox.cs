using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using Sim.Componentes.Classes;

namespace Sim.Componentes.Controles
{
    [LookupBindingPropertiesAttribute("DataSource", "DisplayMember", "ValueMember", "SelectedValue")]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public partial class cComboBox : System.Windows.Forms.ListControl
    {

        [Category("Behavior"), Description("Occurs when the SelectedIndex property changes.")]
        public event EventHandler SelectedIndexChanged;

        #region Variaveis

        private int selectedindex = -1;
        private bool isdroppedDown = false;
        private ComboBoxStyle dropDownStyle = ComboBoxStyle.DropDownList;

        bool mouseHover = false;
        bool IsFocus = false;
        bool Pressed = false;

        #endregion

        #region Construtores

        public cComboBox()
        {
            InitializeComponent();
        }

        public cComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public ListBox.ObjectCollection Items
        {
            get { return dplistBox.Items; }
        }

        #endregion

        #region Propriedades

        public new object DataSource
        {
            get { return base.DataSource; }
            set
            {
                dplistBox.DataSource = value;
                base.DataSource = value;
                OnDataSourceChanged(System.EventArgs.Empty);
            }
        }
        
        public ComboBoxStyle DropDownStyle
        {
            get { return dropDownStyle; }
            set
            {
                dropDownStyle = value;
                Invalidate(true);
            }
        }

        private bool IsDroppedDown
        {
            get { return isdroppedDown; }
            set
            {
                isdroppedDown = value;
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        #endregion

        #region Overrides

        protected override void OnEnter(EventArgs e)
        {
            this.IsFocus = true;
            base.OnEnter(e);
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            this.IsFocus = false;
            base.OnLeave(e);
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.mouseHover = true;
            base.OnMouseEnter(e);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.mouseHover = false;
            base.OnMouseLeave(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            DropDownListHost.Font = this.Font;
            DropDownListHost.Width = this.Width;

            if (e.Button.Equals(MouseButtons.Left))
            {

                if (this.Pressed.Equals(true))
                {
                    this.Pressed = false;
                    DropDownList.Close();
                }
                else
                {
                    this.Pressed = true;
                    this.dplistBox.Height = dplistBox.PreferredHeight + 5;
                    //this.DropDownList.Width = dplistBox.Width;
                    //this.DropDownList.Height = dplistBox.Height;
                    DropDownList.Show(this, new Point(0, this.Height), ToolStripDropDownDirection.BelowRight);
                }
            }

            //this.IsDroppedDown = true;
            base.OnMouseDown(e);
            this.Refresh();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            //this.Pressed = false;
            base.OnMouseUp(e);
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {                
                if (dplistBox.Items.Count > 0)
                {
                    SelectedIndex += 1;
                }
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                if (dplistBox.Items.Count > 0)
                {
                    if (SelectedIndex > 0)
                        SelectedIndex -= 1;
                }
            }
            e.SuppressKeyPress = false;
            base.OnKeyDown(e);
            Invalidate();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            this.SelectedIndex = 0;
            base.OnDataSourceChanged(e);
        }

        protected override void OnDisplayMemberChanged(EventArgs e)
        {
            dplistBox.DisplayMember = this.DisplayMember;
            this.SelectedIndex = this.SelectedIndex;
            base.OnDisplayMemberChanged(e);
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {            
            if (SelectedIndexChanged != null)
                SelectedIndexChanged(this, e);

            base.OnSelectedIndexChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {


            float[] dashValues = { 1.0F, 1.0F, 1.0F, 1.0F };
            Rectangle areafocus = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));
            Rectangle fulltoggle = new Rectangle(new Point(3, 3), new Size(this.Width - 6, this.Height - 6));
            Rectangle toggle = new Rectangle(new Point(this.Width - 27, 3), new Size(24, this.Height - 6));

            System.Drawing.Drawing2D.LinearGradientBrush ngrad = new System.Drawing.Drawing2D.LinearGradientBrush(fulltoggle, ColorTheme.ControleLight, ColorTheme.Controle, System.Drawing.Drawing2D.LinearGradientMode.Vertical);

            Pen penContorno = ColorTheme.PenLight;
            Pen penContornoInterno = ColorTheme.PenDarkDark;

            if (this.Pressed.Equals(false))
            {
                if (this.IsFocus.Equals(true))
                {
                    Pen bluePen = new Pen(ColorTheme.HighlightDark, 1);
                    bluePen.DashPattern = dashValues;
                    e.Graphics.DrawRectangle(bluePen, areafocus);
                }
                if (this.mouseHover.Equals(true))
                {
                    //Pen bluePen = new Pen(ColorTheme.Highlight, 1);
                    //bluePen.DashPattern = dashValues;
                    //e.Graphics.DrawRectangle(bluePen, areafocus);
                    e.Graphics.FillRectangle(Brushes.White, fulltoggle);
                    ngrad = new System.Drawing.Drawing2D.LinearGradientBrush(fulltoggle, Color.FromArgb(255, ColorTheme.Highlight), Color.FromArgb(255, ColorTheme.HighlightShadow), System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                    penContornoInterno = new Pen(new SolidBrush(ColorTheme.HighlightDark), 1);
                    penContorno = new Pen(new SolidBrush(ColorTheme.ControleLightLight), 1);
                    //e.Graphics.DrawRectangle(new Pen(new SolidBrush(ColorTheme.HighlightDark), 1), 1, 1, this.Width - 3, this.Height - 3);
                }
            }
            else
            {

                ngrad = new System.Drawing.Drawing2D.LinearGradientBrush(fulltoggle, ColorTheme.ControleDark, ColorTheme.ControleDark, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            
                Pen bluePen = new Pen(Color.Black, 1);
                bluePen.DashPattern = dashValues;
                e.Graphics.DrawRectangle(bluePen, areafocus);
            }

            // togglebuttom
            e.Graphics.FillRectangle(ngrad, fulltoggle);        
            
            // texto
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            e.Graphics.DrawString(this.Text, this.Font, ColorTheme.FontBrush, 4, ((this.Height - e.Graphics.MeasureString(this.Text, this.Font).Height) / 2) + 0);

            // **** Contorno ***** //
            e.Graphics.DrawRectangle(penContorno, 0, 0, this.Width - 1, this.Height - 1);
            e.Graphics.DrawRectangle(penContornoInterno, 1, 1, this.Width - 3, this.Height - 3);

            this.BackColor = ColorTheme.ControleDark;

            // ***** Toggle ***** //
            e.Graphics.FillRectangle(ngrad, toggle);

            // ***** Desenha Triangulo *****
            System.Drawing.Drawing2D.FillMode nF = System.Drawing.Drawing2D.FillMode.Alternate; // Modo preenchimento

            PointF point1 = new PointF((float)this.Width - 20.0F, ((float)this.Height / 2) - 3.0F); // Ponto inicial (60,20)
            PointF point2 = new PointF((float)this.Width - 15.0F, ((float)this.Height / 2) + 3.0F); // Ponta do triangulo (70,30)
            PointF point3 = new PointF((float)this.Width - 09.0F, ((float)this.Height / 2) - 3.0F); // Ponto final (60,40)

            PointF[] poly = { point1, point2, point3 };

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillPolygon(ColorTheme.FontBrush, poly, nF); // Triangulo
            // ******************************

            base.OnPaint(e);
        }

        #endregion

        #region Overrides ListControl

        public override int SelectedIndex
        {
            get
            {
                return selectedindex;
            }
            set
            {
                if (dplistBox != null)
                {
                    if (dplistBox.Items.Count.Equals(0))
                        return;

                    if ((this.DataSource != null) && value >= -1)
                        return;

                    if (value <= (dplistBox.Items.Count - 1) && value >= -1)
                    {
                        dplistBox.SelectedIndex = value;
                        selectedindex = value;
                        this.Text = dplistBox.GetItemText(dplistBox.SelectedItem);
                        OnSelectedIndexChanged(EventArgs.Empty);                        
                    }
                }
                Invalidate();
            }
        }

        public object SelectedItem
        {
            get { return dplistBox.SelectedItem; }
            set
            {
                dplistBox.SelectedItem = value;
                this.SelectedIndex = dplistBox.SelectedIndex;
            }
        }

        public new object SelectedValue
        {
            get { return base.SelectedValue; }
            set
            {
                base.SelectedValue = value;
            }
        }

        protected override void RefreshItems()
        {
            base.RefreshItems();
        }

        protected override void RefreshItem(int index)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        protected override void SetItemCore(int index, object value)
        {
            base.SetItemCore(index, value);
        }
        
        protected override void SetItemsCore(System.Collections.IList items)
        {
            throw new Exception("The method or operation is not implemented.");
            //base.SetItemsCore(Items);
        }

        #endregion

        #region Eventos ListBox

        private void dplistBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            for (int i = 0; i < (dplistBox.Items.Count); i++)
            {
                if (dplistBox.GetItemRectangle(i).Contains(dplistBox.PointToClient(MousePosition)))
                {
                    dplistBox.SelectedIndex = i;
                    return;
                }
            }
        }

        private void dplistBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.SelectedIndex = dplistBox.SelectedIndex;
            DropDownList.Close();
            this.Pressed = false;
            Invalidate();
        }
        
        private void dplistBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Tab))
            {
                this.SelectedIndex = dplistBox.SelectedIndex;
                DropDownList.Close();
                this.Pressed = false;
                Invalidate();
            }
        }

        #endregion

        #region Evento ListBoxHost

        private void DropDownList_Closing(object sender, System.Windows.Forms.ToolStripDropDownClosingEventArgs e)
        {
            this.Pressed = false;
            Invalidate();
        }

        #endregion

    }
}
