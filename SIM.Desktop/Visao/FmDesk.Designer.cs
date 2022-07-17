namespace Sim.Desktop.Visao
{
    partial class FmDesk
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBarMenu = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pModulo = new System.Windows.Forms.Panel();
            this.cLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LayoutModulos = new System.Windows.Forms.TableLayoutPanel();
            this.labelLinha = new System.Windows.Forms.Label();
            this.timerA = new System.Windows.Forms.Timer(this.components);
            this.panelSYS = new System.Windows.Forms.Panel();
            this.cLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxSIM = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.buttonDropDown = new Sim.Gui.Controls.ButtonDropDown(this.components);
            this.pModulo.SuspendLayout();
            this.panelSYS.SuspendLayout();
            this.panelWorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBarMenu
            // 
            this.pBarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarMenu.Location = new System.Drawing.Point(0, 0);
            this.pBarMenu.Name = "pBarMenu";
            this.pBarMenu.Size = new System.Drawing.Size(978, 30);
            this.pBarMenu.TabIndex = 21;
            this.pBarMenu.Visible = false;
            this.pBarMenu.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pBarMenu_ControlRemoved);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "SIM.Informação";
            // 
            // pModulo
            // 
            this.pModulo.Controls.Add(this.cLabel1);
            this.pModulo.Controls.Add(this.label3);
            this.pModulo.Controls.Add(this.LayoutModulos);
            this.pModulo.Controls.Add(this.labelLinha);
            this.pModulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pModulo.Location = new System.Drawing.Point(0, 30);
            this.pModulo.Name = "pModulo";
            this.pModulo.Size = new System.Drawing.Size(978, 138);
            this.pModulo.TabIndex = 1;
            // 
            // cLabel1
            // 
            this.cLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cLabel1.AutoSize = true;
            this.cLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.cLabel1.Location = new System.Drawing.Point(423, 14);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(133, 15);
            this.cLabel1.TabIndex = 3;
            this.cLabel1.Text = "Modulos Instalados";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(114, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(750, 1);
            this.label3.TabIndex = 5;
            // 
            // LayoutModulos
            // 
            this.LayoutModulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LayoutModulos.ColumnCount = 3;
            this.LayoutModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutModulos.Location = new System.Drawing.Point(114, 34);
            this.LayoutModulos.Name = "LayoutModulos";
            this.LayoutModulos.RowCount = 1;
            this.LayoutModulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutModulos.Size = new System.Drawing.Size(750, 90);
            this.LayoutModulos.TabIndex = 2;
            this.LayoutModulos.TabStop = true;
            // 
            // labelLinha
            // 
            this.labelLinha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLinha.BackColor = System.Drawing.Color.Black;
            this.labelLinha.Location = new System.Drawing.Point(114, 22);
            this.labelLinha.Name = "labelLinha";
            this.labelLinha.Size = new System.Drawing.Size(750, 1);
            this.labelLinha.TabIndex = 4;
            // 
            // timerA
            // 
            this.timerA.Tick += new System.EventHandler(this.timerA_Tick);
            // 
            // panelSYS
            // 
            this.panelSYS.Controls.Add(this.cLabel2);
            this.panelSYS.Controls.Add(this.label4);
            this.panelSYS.Controls.Add(this.listBoxSIM);
            this.panelSYS.Controls.Add(this.label5);
            this.panelSYS.Controls.Add(this.label2);
            this.panelSYS.Controls.Add(this.label1);
            this.panelSYS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSYS.Location = new System.Drawing.Point(0, 297);
            this.panelSYS.Name = "panelSYS";
            this.panelSYS.Size = new System.Drawing.Size(978, 398);
            this.panelSYS.TabIndex = 23;
            this.panelSYS.Visible = false;
            // 
            // cLabel2
            // 
            this.cLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cLabel2.AutoSize = true;
            this.cLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.cLabel2.Location = new System.Drawing.Point(423, 140);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Size = new System.Drawing.Size(133, 15);
            this.cLabel2.TabIndex = 6;
            this.cLabel2.Text = "Modulos Instalados";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(955, 1);
            this.label4.TabIndex = 8;
            // 
            // listBoxSIM
            // 
            this.listBoxSIM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSIM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxSIM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSIM.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSIM.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxSIM.FormattingEnabled = true;
            this.listBoxSIM.ItemHeight = 14;
            this.listBoxSIM.Location = new System.Drawing.Point(11, 163);
            this.listBoxSIM.Name = "listBoxSIM";
            this.listBoxSIM.Size = new System.Drawing.Size(956, 224);
            this.listBoxSIM.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(955, 1);
            this.label5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWorkArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelWorkArea.Controls.Add(this.pModulo);
            this.panelWorkArea.Controls.Add(this.panelSYS);
            this.panelWorkArea.Controls.Add(this.pBarMenu);
            this.panelWorkArea.Location = new System.Drawing.Point(1, 24);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(978, 695);
            this.panelWorkArea.TabIndex = 28;
            // 
            // buttonDropDown
            // 
            this.buttonDropDown.InFocus = Sim.Gui.Controls.FocusType.No;
            this.buttonDropDown.Location = new System.Drawing.Point(130, 2);
            this.buttonDropDown.Name = "buttonDropDown";
            this.buttonDropDown.Size = new System.Drawing.Size(53, 20);
            this.buttonDropDown.TabIndex = 29;
            this.buttonDropDown.Text = "...";
            // 
            // FmDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(980, 720);
            this.Controls.Add(this.buttonDropDown);
            this.Controls.Add(this.panelWorkArea);
            this.FormPai = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FmDesk";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SIM.Desktop.Beta";
            this.Activated += new System.EventHandler(this.FmDesk_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmDesk_FormClosed);
            this.Load += new System.EventHandler(this.FmDesk_Load);
            this.Shown += new System.EventHandler(this.FmDesk_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FmDesk_Paint);
            this.Move += new System.EventHandler(this.FmDesk_Move);
            this.Resize += new System.EventHandler(this.FmDesk_Resize);
            this.Controls.SetChildIndex(this.panelWorkArea, 0);
            this.Controls.SetChildIndex(this.buttonDropDown, 0);
            this.pModulo.ResumeLayout(false);
            this.pModulo.PerformLayout();
            this.panelSYS.ResumeLayout(false);
            this.panelSYS.PerformLayout();
            this.panelWorkArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pBarMenu;
        private System.Windows.Forms.Panel pModulo;
        private System.Windows.Forms.TableLayoutPanel LayoutModulos;
        private System.Windows.Forms.Label cLabel1;
        private System.Windows.Forms.Timer timerA;
        private System.Windows.Forms.Panel panelSYS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLinha;
        private System.Windows.Forms.Panel panelWorkArea;
        private System.Windows.Forms.Label cLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxSIM;
        private System.Windows.Forms.Label label5;
        private Gui.Controls.ButtonDropDown buttonDropDown;
    }
}

