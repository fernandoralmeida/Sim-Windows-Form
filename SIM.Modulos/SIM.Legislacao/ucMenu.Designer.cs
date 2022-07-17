namespace Sim.Legislacao
{
    partial class ucMenu
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
            this.components = new System.ComponentModel.Container();
            this.pBarMenu = new System.Windows.Forms.Panel();
            this.cButtonColor1 = new Sim.Gui.Controls.Button(this.components);
            this.cButtonColorREL = new Sim.Gui.Controls.Button(this.components);
            this.cButtonColorSCH = new Sim.Gui.Controls.Button(this.components);
            this.cButtonColorINC = new Sim.Gui.Controls.Button(this.components);
            this.cButtonColorEndMod = new Sim.Gui.Controls.Button(this.components);
            this.lblModulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pBarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBarMenu
            // 
            this.pBarMenu.BackColor = System.Drawing.Color.White;
            this.pBarMenu.Controls.Add(this.cButtonColor1);
            this.pBarMenu.Controls.Add(this.cButtonColorREL);
            this.pBarMenu.Controls.Add(this.cButtonColorSCH);
            this.pBarMenu.Controls.Add(this.cButtonColorINC);
            this.pBarMenu.Controls.Add(this.cButtonColorEndMod);
            this.pBarMenu.Controls.Add(this.lblModulo);
            this.pBarMenu.Controls.Add(this.label4);
            this.pBarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarMenu.Location = new System.Drawing.Point(0, 0);
            this.pBarMenu.Name = "pBarMenu";
            this.pBarMenu.Size = new System.Drawing.Size(978, 30);
            this.pBarMenu.TabIndex = 22;
            this.pBarMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pBarMenu_Paint);
            // 
            // cButtonColor1
            // 
            this.cButtonColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonColor1.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonColor1.Location = new System.Drawing.Point(857, 4);
            this.cButtonColor1.Name = "cButtonColor1";
            this.cButtonColor1.Size = new System.Drawing.Size(118, 22);
            this.cButtonColor1.TabIndex = 36;
            this.cButtonColor1.Text = "Configurações";
            this.cButtonColor1.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonColor1.UseVisualStyleBackColor = true;
            this.cButtonColor1.Click += new System.EventHandler(this.cButtonColor1_Click);
            // 
            // cButtonColorREL
            // 
            this.cButtonColorREL.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonColorREL.Location = new System.Drawing.Point(450, 4);
            this.cButtonColorREL.Name = "cButtonColorREL";
            this.cButtonColorREL.Size = new System.Drawing.Size(118, 22);
            this.cButtonColorREL.TabIndex = 3;
            this.cButtonColorREL.Text = "Estatísticas";
            this.cButtonColorREL.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonColorREL.UseVisualStyleBackColor = true;
            this.cButtonColorREL.Click += new System.EventHandler(this.cButtonColorREL_Click);
            // 
            // cButtonColorSCH
            // 
            this.cButtonColorSCH.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonColorSCH.Location = new System.Drawing.Point(346, 4);
            this.cButtonColorSCH.Name = "cButtonColorSCH";
            this.cButtonColorSCH.Size = new System.Drawing.Size(105, 22);
            this.cButtonColorSCH.TabIndex = 2;
            this.cButtonColorSCH.Text = "Consultas";
            this.cButtonColorSCH.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonColorSCH.UseVisualStyleBackColor = true;
            this.cButtonColorSCH.Click += new System.EventHandler(this.cButtonColorSCH_Click);
            // 
            // cButtonColorINC
            // 
            this.cButtonColorINC.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonColorINC.Location = new System.Drawing.Point(254, 4);
            this.cButtonColorINC.Name = "cButtonColorINC";
            this.cButtonColorINC.Size = new System.Drawing.Size(93, 22);
            this.cButtonColorINC.TabIndex = 0;
            this.cButtonColorINC.Text = "Incluir";
            this.cButtonColorINC.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonColorINC.UseVisualStyleBackColor = true;
            this.cButtonColorINC.Click += new System.EventHandler(this.cButtonColorINC_Click);
            // 
            // cButtonColorEndMod
            // 
            this.cButtonColorEndMod.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonColorEndMod.Location = new System.Drawing.Point(12, 4);
            this.cButtonColorEndMod.Name = "cButtonColorEndMod";
            this.cButtonColorEndMod.Size = new System.Drawing.Size(80, 22);
            this.cButtonColorEndMod.TabIndex = 35;
            this.cButtonColorEndMod.TabStop = false;
            this.cButtonColorEndMod.Text = "X Fechar";
            this.cButtonColorEndMod.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonColorEndMod.UseVisualStyleBackColor = true;
            this.cButtonColorEndMod.Click += new System.EventHandler(this.cButtonColorEndMod_Click);
            // 
            // lblModulo
            // 
            this.lblModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModulo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.ForeColor = System.Drawing.Color.White;
            this.lblModulo.Location = new System.Drawing.Point(0, 0);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(108, 29);
            this.lblModulo.TabIndex = 34;
            this.lblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(122, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "M:Legislação";
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBarMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(978, 30);
            this.Load += new System.EventHandler(this.ucMenu_Load);
            this.pBarMenu.ResumeLayout(false);
            this.pBarMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBarMenu;
        private Gui.Controls.Button cButtonColorREL;
        private Gui.Controls.Button cButtonColorSCH;
        private Gui.Controls.Button cButtonColorINC;
        private Gui.Controls.Button cButtonColorEndMod;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label label4;
        private Gui.Controls.Button cButtonColor1;
    }
}
