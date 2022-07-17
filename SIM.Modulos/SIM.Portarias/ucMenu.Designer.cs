namespace Sim.Portarias
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
            this.cButtonColorREL = new Gui.Controls.Button(this.components);
            this.cButtonColorSCH = new Gui.Controls.Button(this.components);
            this.cButtonColorINC = new Gui.Controls.Button(this.components);
            this.cButtonColorEndMod = new Gui.Controls.Button(this.components);
            this.lblModulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cButtonColor1 = new Gui.Controls.Button(this.components);
            this.cButtonColor2 = new Gui.Controls.Button(this.components);
            this.SuspendLayout();
            // 
            // cButtonColorREL
            //
            this.cButtonColorREL.Location = new System.Drawing.Point(468, 4);
            this.cButtonColorREL.Name = "cButtonColorREL";
            this.cButtonColorREL.Size = new System.Drawing.Size(108, 22);
            this.cButtonColorREL.TabIndex = 2;
            this.cButtonColorREL.Text = "Estatísticas";
            this.cButtonColorREL.UseVisualStyleBackColor = true;
            this.cButtonColorREL.Click += new System.EventHandler(this.cButtonColorREL_Click);
            // 
            // cButtonColorSCH
            // 
            this.cButtonColorSCH.Location = new System.Drawing.Point(361, 4);
            this.cButtonColorSCH.Name = "cButtonColorSCH";
            this.cButtonColorSCH.Size = new System.Drawing.Size(108, 22);
            this.cButtonColorSCH.TabIndex = 1;
            this.cButtonColorSCH.Text = "Consultar";
            this.cButtonColorSCH.UseVisualStyleBackColor = true;
            this.cButtonColorSCH.Click += new System.EventHandler(this.cButtonColorSCH_Click);
            // 
            // cButtonColorINC
            // 
            this.cButtonColorINC.Location = new System.Drawing.Point(254, 4);
            this.cButtonColorINC.Name = "cButtonColorINC";
            this.cButtonColorINC.Size = new System.Drawing.Size(108, 22);
            this.cButtonColorINC.TabIndex = 0;
            this.cButtonColorINC.Text = "Incluir";
            this.cButtonColorINC.UseVisualStyleBackColor = true;
            this.cButtonColorINC.Click += new System.EventHandler(this.cButtonColorINC_Click);
            // 
            // cButtonColorEndMod
            // 
            this.cButtonColorEndMod.Location = new System.Drawing.Point(12, 4);
            this.cButtonColorEndMod.Name = "cButtonColorEndMod";
            this.cButtonColorEndMod.Size = new System.Drawing.Size(80, 22);
            this.cButtonColorEndMod.TabIndex = 42;
            this.cButtonColorEndMod.TabStop = false;
            this.cButtonColorEndMod.Text = "X Fechar";
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
            this.lblModulo.TabIndex = 41;
            this.lblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(122, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "M:Portarias";
            // 
            // cButtonColor1
            //
            this.cButtonColor1.Location = new System.Drawing.Point(575, 4);
            this.cButtonColor1.Name = "cButtonColor1";
            this.cButtonColor1.Size = new System.Drawing.Size(88, 22);
            this.cButtonColor1.TabIndex = 48;
            this.cButtonColor1.Text = "Publicar";
            this.cButtonColor1.UseVisualStyleBackColor = true;
            // 
            // cButtonColor2
            // 
            this.cButtonColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButtonColor2.Location = new System.Drawing.Point(854, 4);
            this.cButtonColor2.Name = "cButtonColor2";
            this.cButtonColor2.Size = new System.Drawing.Size(120, 22);
            this.cButtonColor2.TabIndex = 49;
            this.cButtonColor2.Text = "Configurações";
            this.cButtonColor2.UseVisualStyleBackColor = true;
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cButtonColor2);
            this.Controls.Add(this.cButtonColor1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cButtonColorREL);
            this.Controls.Add(this.cButtonColorSCH);
            this.Controls.Add(this.cButtonColorINC);
            this.Controls.Add(this.cButtonColorEndMod);
            this.Controls.Add(this.lblModulo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(978, 30);
            this.Load += new System.EventHandler(this.ucMenu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucMenu_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gui.Controls.Button cButtonColorREL;
        private Gui.Controls.Button cButtonColorSCH;
        private Gui.Controls.Button cButtonColorINC;
        private Gui.Controls.Button cButtonColorEndMod;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label label4;
        private Gui.Controls.Button cButtonColor1;
        private Gui.Controls.Button cButtonColor2;

    }
}
