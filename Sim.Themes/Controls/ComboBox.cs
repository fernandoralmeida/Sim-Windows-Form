using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Sim.Gui.Controls
{
    [LookupBindingPropertiesAttribute("DataSource", "DisplayMember", "ValueMember", "SelectedValue")]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public partial class ComboBox : ListControl
    {

        [Category("Behavior"), Description("Occurs when the SelectedIndex property changes.")]
        public event EventHandler SelectedIndexChanged;

        #region Variaveis

        private int selectedindex = -1;
        private bool isdroppedDown = false;
        private ComboBoxStyle dropDownStyle = ComboBoxStyle.DropDownList;

        #endregion

        #region Construtores

        public ComboBox()
        {
            InitializeComponent();
        }

        public ComboBox(IContainer container)
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

        private OnHover MouseOnHover { get; set; }

        private ControlPressed PressState { get; set; }

        public FocusType InFocus { get; set; }

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

        protected override void OnCreateControl()
        {
            Themes.Dynamics.SetColor();
            MouseOnHover = OnHover.Off;
            InFocus = FocusType.No;
            PressState = ControlPressed.UnPressed;
            base.OnCreateControl();
        }

        protected override void OnEnter(EventArgs e)
        {
            InFocus = FocusType.Yes;
            base.OnEnter(e);
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            InFocus = FocusType.No;
            base.OnLeave(e);
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            MouseOnHover = OnHover.On;
            base.OnMouseEnter(e);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            MouseOnHover = OnHover.Off;
            base.OnMouseLeave(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            DropDownListHost.Font = this.Font;
            DropDownListHost.Width = this.Width;

            if (e.Button.Equals(MouseButtons.Left))
            {

                if (PressState == ControlPressed.Pressed)
                {
                    PressState = ControlPressed.UnPressed;
                    DropDownList.Close();
                }
                else
                {
                    PressState = ControlPressed.Pressed;
                    this.dplistBox.Height = dplistBox.PreferredHeight + 5;
                    //this.DropDownList.Width = dplistBox.Width;
                    //this.DropDownList.Height = dplistBox.Height;
                    DropDownList.Show(this, new Point(0, this.Height), ToolStripDropDownDirection.BelowRight);
                }
            }

            //this.IsDroppedDown = true;
            base.OnMouseDown(e);
            Invalidate();
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

        protected override void OnPaint(PaintEventArgs pevent)
        {
            
            Pen linhaexterna = Themes.Pens.ControlDark;
            Pen linhainterna = Themes.Pens.ControlDarkDark;

            Brush colorfont = Themes.Brushes.Font;

            Rectangle controlsize = new Rectangle(new Point(0, 0), this.ClientSize);

            Rectangle contornoexterno = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Rectangle contornointerno = new Rectangle(new Point(1, 1), new Size(this.Width - 3, this.Height - 3));

            Rectangle toggle = new Rectangle(new Point(this.Width - 27, 3), new Size(24, this.Height - 6));
            Rectangle dashedarea = new Rectangle(new Point(2, 2), new Size(this.Width - 5, this.Height - 5));

            //LinearGradientBrush gradient = Themes.Gradient.Normal(controlsize);
            //Themes.Style.Control(Themes.ModeGradient.Glass, pevent, this.ClientSize);

            pevent.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            if (PressState == ControlPressed.UnPressed)
            {

                //pevent.Graphics.FillRectangle(Themes.Gradient.Normal(controlsize), controlsize);
                Themes.StyleControl.Normal(Themes.ModeGradient.Frosted, pevent, this.ClientSize);

                if (MouseOnHover == OnHover.Off)
                {
                    if (InFocus == FocusType.Yes)
                        pevent.Graphics.DrawRectangle(Themes.Pens.DashedHighLight, dashedarea);
                }
                else
                {
                    //gradient = Themes.Gradient.OnHover(controlsize);
                    //pevent.Graphics.FillRectangle(Themes.Gradient.OnHover(controlsize), controlsize);
                    Themes.StyleControl.OnHover(Themes.ModeGradient.Frosted, pevent, this.ClientSize);
                    //linhaexterna = Themes.Pens.ControlLight;
                    linhainterna = Themes.Pens.ControlHighLightDarkDark;
                    colorfont = Themes.Brushes.FontHighLight;
                }

                pevent.Graphics.DrawRectangle(linhaexterna, contornoexterno);
                pevent.Graphics.DrawRectangle(linhainterna, contornointerno);

            }
            else
            {
                linhainterna = Themes.Pens.ControlHighLight;
                //gradient = Themes.Gradient.OnPress(controlsize);
                //pevent.Graphics.FillRectangle(Themes.Gradient.OnPress(controlsize), controlsize);
                Themes.StyleControl.OnPress(Themes.ModeGradient.Frosted, pevent, this.ClientSize);
                colorfont = Themes.Brushes.FontHighLight;

            }


            if (this.Enabled == false)
            {
                pevent.Graphics.FillRectangle(Themes.Brushes.ControlDisable, controlsize);
                pevent.Graphics.DrawRectangle(Themes.Pens.ControlDisable, contornoexterno);
                colorfont = Themes.Brushes.FontDisable;
            }

            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Center;

            RectangleF rectangle = new RectangleF(4, 0, this.Width, this.Height);

            if (pevent.Graphics.MeasureString(this.Text, this.Font).Width < this.Width - 20)
            {
                pevent.Graphics.DrawString(this.Text, this.Font, colorfont, rectangle, formatter);
            }
            else
            {
                float top = (this.Height - pevent.Graphics.MeasureString(this.Text, this.Font).Height) / 2;
                rectangle = new RectangleF(4, top, this.Width - 25, pevent.Graphics.MeasureString(this.Text, this.Font).Height);
                pevent.Graphics.DrawString(this.Text, this.Font, colorfont, rectangle, formatter);
            }
            
            //pevent.Graphics.FillRectangle(gradient, toggle);

            // ***** Desenha Triangulo *****
            System.Drawing.Drawing2D.FillMode nF = System.Drawing.Drawing2D.FillMode.Alternate; // Modo preenchimento

            PointF point1 = new PointF((float)this.Width - 20.0F, ((float)this.Height / 2) - 3.0F); // Ponto inicial (60,20)
            PointF point2 = new PointF((float)this.Width - 15.0F, ((float)this.Height / 2) + 3.0F); // Ponta do triangulo (70,30)
            PointF point3 = new PointF((float)this.Width - 09.0F, ((float)this.Height / 2) - 3.0F); // Ponto final (60,40)

            PointF[] poly = { point1, point2, point3 };

            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pevent.Graphics.FillPolygon(colorfont, poly, nF); // Triangulo
            // ******************************

            pevent.Graphics.DrawRectangle(linhainterna, contornointerno);
            pevent.Graphics.DrawRectangle(linhaexterna, contornoexterno);

            base.OnPaint(pevent);
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
            PressState = ControlPressed.UnPressed;
            Invalidate();
        }

        private void dplistBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Tab))
            {
                this.SelectedIndex = dplistBox.SelectedIndex;
                DropDownList.Close();
                PressState = ControlPressed.UnPressed;
                Invalidate();
            }
        }

        #endregion

        #region Evento ListBoxHost

        private void DropDownList_Closing(object sender, System.Windows.Forms.ToolStripDropDownClosingEventArgs e)
        {
            PressState = ControlPressed.UnPressed;
            Invalidate();
        }

        #endregion

    }
}
