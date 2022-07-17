namespace Sim.Gui.Controls
{
    partial class ComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.ContainerControl, true);
            SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, true);
            SetStyle(System.Windows.Forms.ControlStyles.Selectable, true);
            SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(System.Windows.Forms.ControlStyles.UserMouse, true);
            SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.Selectable, true);

            components = new System.ComponentModel.Container();

            this.dplistBox = new System.Windows.Forms.ListBox();
            this.DropDownList = new System.Windows.Forms.ToolStripDropDown();
            this.DropDownListHost = new System.Windows.Forms.ToolStripControlHost(dplistBox);
            // 
            // dplistBox
            // 
            this.dplistBox.FormattingEnabled = true;
            this.dplistBox.Location = new System.Drawing.Point(0, 0);
            this.dplistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dplistBox.Name = "dplistBox";
            this.dplistBox.Size = new System.Drawing.Size(120, 96);
            this.dplistBox.TabIndex = 0;
            this.dplistBox.Font = this.Font;
            this.dplistBox.MouseMove += new System.Windows.Forms.MouseEventHandler(dplistBox_MouseMove);
            this.dplistBox.MouseClick += new System.Windows.Forms.MouseEventHandler(dplistBox_MouseClick);
            this.dplistBox.KeyDown += new System.Windows.Forms.KeyEventHandler(dplistBox_KeyDown);
            //
            // DropDownListHost
            //
            this.DropDownListHost.AutoSize = false;
            this.DropDownListHost.Padding = new System.Windows.Forms.Padding(0);
            this.DropDownListHost.Margin = new System.Windows.Forms.Padding(0);
            //
            // DropDownList
            //
            this.DropDownList.DropShadowEnabled = false;
            this.DropDownList.AutoSize = true;
            //this.DropDownList.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.DropDownList.Padding = new System.Windows.Forms.Padding(0);
            this.DropDownList.Margin = new System.Windows.Forms.Padding(0);
            this.DropDownList.Font = this.Font;
            this.DropDownList.Items.Add(DropDownListHost);
            this.DropDownList.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(DropDownList_Closing);
        }

        #endregion

        private System.Windows.Forms.ListBox dplistBox;
        private System.Windows.Forms.ToolStripDropDown DropDownList;
        private System.Windows.Forms.ToolStripControlHost DropDownListHost;
    }
}
