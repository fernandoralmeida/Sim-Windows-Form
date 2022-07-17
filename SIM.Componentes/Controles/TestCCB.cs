using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility
{
    /// <summary>
    /// Put a combo box dropdown on any control
    /// </summary>
    public class ComboBuddy : ComboBox
    {
        /// <summary>
        /// Put a window exactly where I want
        /// </summary>
        /// <remarks>
        /// I hate to resort to unmanaged code, but I need to place the dropdown at a specific point
        /// </remarks>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        // Backing store
        private Control DropDownControlBacking;
        /// <summary>
        /// The control to which to add the ComboBuddy
        /// </summary>
        public Control DropDownControl
        {
            get { return DropDownControlBacking; }
            set
            {
                if (this.DropDownControlBacking != null)
                    this.DropDownControlBacking.KeyUp -= new KeyEventHandler(value_KeyUp);
                this.DropDownControlBacking = value;
                this.Location = new System.Drawing.Point(20, 20);
                this.Size = new System.Drawing.Size(100, 50);
                this.BackColor = System.Drawing.Color.White;
                //value.KeyUp += new KeyEventHandler(value_KeyUp);
            }
        }
        /// <summary>
        /// Free
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (this.DropDownControlBacking != null)
                this.DropDownControlBacking.KeyUp -= new KeyEventHandler(value_KeyUp);
            base.Dispose(disposing);
        }


        //Store the default width to perform check in UpdateDropDownWidth
        private int initialDropDownWidth = 0;
        /// <summary>
        /// Put a combo box dropdown on any control
        /// </summary>
        public ComboBuddy()
        {
            initialDropDownWidth = this.DropDownWidth;
            this.MaximumSize = new System.Drawing.Size(ComboInfoHelper.GetDropDownWidth(), this.MaximumSize.Height);
            Suspended = false;
            this.HandleCreated += new EventHandler(BetterComboBox_HandleCreated);
        }
        /// <summary>
        /// Dont grow
        /// </summary>
        public override System.Drawing.Size MaximumSize
        {
            get { return base.MaximumSize; }
        }
        /// <summary>
        /// Make sure big enough to accomodate all items
        /// </summary>
        /// <param name="value">New item</param>
        protected override void SetItemsCore(System.Collections.IList value)
        {
            if (Suspended) return;
            base.SetItemsCore(value);
            UpdateDropDownWidth();
        }
        /// <summary>
        /// Is suspended
        /// </summary>
        public bool Suspended { get; set; }
        /// <summary>
        /// Suspend
        /// </summary>
        public void Suspend() { Suspended = true; }
        /// <summary>
        /// Resume
        /// </summary>
        public void Resume() { Suspended = false; }
        /// <summary>
        /// Clicked, so set the selected item dependant on the control text 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDropDown(EventArgs e)
        {
            if (Suspended) return;
            if (DropDownControl != null && !string.IsNullOrEmpty(DropDownControl.Text))
            {
                int ix = this.FindString(DropDownControl.Text);
                if (ix >= 0) this.SelectedIndex = ix;
            }
            base.OnDropDown(e);
        }
        /// <summary>
        /// Item picked, update the control's text
        /// </summary>
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            if (Suspended) return;
            base.OnSelectedIndexChanged(e);
            if (DropDownControl != null && this.SelectedItem != null)
                DropDownControl.Text = (string)this.SelectedValue;
        }
        /// <summary>
        /// Update width when can
        /// </summary>
        private void BetterComboBox_HandleCreated(object sender, EventArgs e)
        {
            UpdateDropDownWidth();
        }
        /// <summary>
        /// Sets the width depending on contents
        /// </summary>
        public void UpdateDropDownWidth()
        {
            //Create a GDI+ drawing surface to measure string widths
            System.Drawing.Graphics ds = this.CreateGraphics();

            //Float to hold largest single item width
            float maxWidth = 0;

            //Iterate over each item, measuring the maximum width
            //of the DisplayMember strings
            foreach (object item in this.Items)
            {
                maxWidth = Math.Max(maxWidth, ds.MeasureString(item.ToString(), this.Font).Width);
            }

            //Add a buffer for some white space
            //around the text
            maxWidth += 30;

            //round maxWidth and cast to an int
            int newWidth = (int)Decimal.Round((decimal)maxWidth, 0);

            //If the width is bigger than the screen, ensure
            //we stay within the bounds of the screen
            if (newWidth > SystemInformation.WorkingArea.Width)
            {
                newWidth = SystemInformation.WorkingArea.Width;
            }

            //Only change the default width if it's smaller
            //than the newly calculated width
            if (newWidth > initialDropDownWidth)
            {
                this.DropDownWidth = newWidth;
            }

            //Clean up the drawing surface
            ds.Dispose();
        }
        private const int SWP_NOSIZE = 0x1;
        private const UInt32 WM_CTLCOLORLISTBOX = 0x0134;
        /// <summary>
        /// Place the drop-down under the control
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CTLCOLORLISTBOX)
            {
                System.Drawing.Point DropDownLocation =
                    (this.DropDownControl == null) ?
                        this.PointToScreen(new System.Drawing.Point(0, 0)) :
                        DropDownControl.Parent.PointToScreen(
                            new System.Drawing.Point(DropDownControl.Left, DropDownControl.Bottom));
                SetWindowPos(m.LParam,
                    IntPtr.Zero,
                    DropDownLocation.X,
                    DropDownLocation.Y,
                    0,
                    0,
                    SWP_NOSIZE);
            }

            base.WndProc(ref m);
        }
        /// <summary>
        /// List box used as drop-down
        /// </summary>
        private ListBox Lister;
        /// <summary>
        /// Create a list box to hold the drop down items
        /// </summary>
        void SetupLister()
        {
            if (this.Lister == null)
            {
                this.Lister = new ListBox();
                this.Lister.Parent = this.DropDownControl.FindForm();
                this.Lister.Click += new EventHandler(Lister_Click);
                this.Lister.SelectedIndexChanged += new EventHandler(Lister_SelectedIndexChanged);
            }
            this.Lister.Location =
                this.Lister.Parent.PointToClient(
                    this.DropDownControl.Parent.PointToScreen(
                        new System.Drawing.Point(this.DropDownControl.Left, this.DropDownControl.Bottom)));
            this.Lister.Size = new System.Drawing.Size(this.DropDownWidth, this.DropDownHeight);
        }
        /// <summary>
        /// Pressed a drop-down item
        /// </summary>
        void Lister_Click(object sender, EventArgs e)
        {
            this.Lister.Hide();
        }
        /// <summary>
        /// Arrow key used to select next or previous item
        /// </summary>
        /// <param name="aNext">true=next, else previous</param>
        private void ListerSelect(bool aNext)
        {
            if (this.Lister == null) return;
            if (this.Lister.Items.Count == 0)
            {
                this.Lister.Hide();
                return;
            }
            if (this.Lister.Items.Count == 1)
            {
                this.Lister.SelectedIndex = 0;
                return;
            }
            if (aNext && this.Lister.SelectedIndex == this.Lister.Items.Count - 1) return;
            if (!aNext && this.Lister.SelectedIndex == 0) return;
            if (this.Lister.SelectedIndex < 0)
                this.Lister.SelectedIndex = 0;
            else
                this.Lister.SelectedIndex += (aNext ? 1 : -1);
        }
        /// <summary>
        /// Gets the string value of a combo item
        /// </summary>
        /// <param name="aItem">Item to get</param>
        /// <param name="aProperty">Property to use</param>
        /// <returns>string value or string.empty</returns>
        private string ValueOf(object aItem, string aProperty)
        {
            if (aItem is string) return (string)aItem;
            var Prop = aItem.GetType().GetProperty(aProperty);
            if (Prop != null) return (string)Prop.GetValue(aItem, null);
            return string.Empty;
        }
        /// <summary>
        /// Return string if possible
        /// </summary>
        public new object SelectedValue
        {
            get { return this.SelectedItem == null ? null : ValueOf(this.SelectedItem, this.DisplayMember); }
        }
        /// <summary>
        /// Process user keystrokes
        /// </summary>
        void value_KeyUp(object sender, KeyEventArgs e)
        {
            if (Suspended) return;
            if (this.DropDownControl != null && this.AutoCompleteMode != System.Windows.Forms.AutoCompleteMode.None)
            {
                SetupLister();
                // Go away
                if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                {
                    this.Lister.Hide();
                    return;
                }
                // Move
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    ListerSelect(e.KeyCode == Keys.Down);
                    e.SuppressKeyPress = true;
                    return;
                }
                else // any other key, look for type-ahead choices
                {
                    this.Lister.Items.Clear();
                    string lText = this.DropDownControl.Text;
                    string lMember = this.DisplayMember;
                    var Query =
                        from object Item in this.Items
                        where ValueOf(Item, lMember)
                            .IndexOf(lText, StringComparison.InvariantCultureIgnoreCase) >= 0
                        orderby ValueOf(Item, lMember)
                        select ValueOf(Item, lMember);
                    // If text is 3 or more, look for contains else look for startsWith
                    this.Lister.Items.AddRange(lText.Length > 2 ? Query.ToArray() :
                        Query.Where(qV => qV.StartsWith(lText, StringComparison.InvariantCultureIgnoreCase)).ToArray());
                }
                if (this.Lister.Items.Count == 0)
                {
                    this.Lister.Hide();
                }
                else
                {
                    this.Lister.Show();
                    this.Lister.BringToFront();
                }
            }
        }
        /// <summary>
        /// Set the control text to selected item
        /// </summary>
        private void Lister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DropDownControl != null) this.DropDownControl.Text = (string)this.Lister.SelectedItem;
            // this.Lister.Hide();
        }
        /// <summary>
        /// All this to get the combo drop-down width
        /// </summary>
        internal class ComboInfoHelper
        {
            [System.Runtime.InteropServices.DllImport("user32")]
            private static extern bool GetComboBoxInfo(IntPtr hwndCombo, ref ComboBoxInfo info);

            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
            private struct RECT
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;
            }

            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
            private struct ComboBoxInfo
            {
                public int cbSize;
                public RECT rcItem;
                public RECT rcButton;
                public IntPtr stateButton;
                public IntPtr hwndCombo;
                public IntPtr hwndEdit;
                public IntPtr hwndList;
            }

            public static int GetDropDownWidth()
            {
                ComboBox cb = new ComboBox();
                int width = GetDropDownWidth(cb.Handle);
                cb.Dispose();
                return width;
            }

            public static int GetDropDownWidth(IntPtr handle)
            {
                ComboBoxInfo cbi = new ComboBoxInfo();
                cbi.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(cbi);
                GetComboBoxInfo(handle, ref cbi);
                int width = cbi.rcButton.Right - cbi.rcButton.Left;
                return width;
            }
        }
    }
}


