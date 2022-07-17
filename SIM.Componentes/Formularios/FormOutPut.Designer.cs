namespace Sim.Componentes.Formularios
{
    partial class FormOutPut
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
            this.listBoxOutPut = new System.Windows.Forms.ListBox();
            this.cButtonColor1 = new Sim.Controles.cButtonColor(this.components);
            this.SuspendLayout();
            // 
            // listBoxOutPut
            // 
            this.listBoxOutPut.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOutPut.FormattingEnabled = true;
            this.listBoxOutPut.ItemHeight = 14;
            this.listBoxOutPut.Location = new System.Drawing.Point(9, 34);
            this.listBoxOutPut.Name = "listBoxOutPut";
            this.listBoxOutPut.Size = new System.Drawing.Size(454, 270);
            this.listBoxOutPut.TabIndex = 4;
            // 
            // cButtonColor1
            // 
            this.cButtonColor1.Borda = System.Drawing.SystemColors.ControlDark;
            this.cButtonColor1.cCorPress = System.Drawing.Color.WhiteSmoke;
            this.cButtonColor1.CorFinal = System.Drawing.Color.Gainsboro;
            this.cButtonColor1.CorFont = System.Drawing.Color.Black;
            this.cButtonColor1.CorInicial = System.Drawing.Color.White;
            this.cButtonColor1.CorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cButtonColor1.CorPress = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.cButtonColor1.CorSombra = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cButtonColor1.Location = new System.Drawing.Point(362, 312);
            this.cButtonColor1.Name = "cButtonColor1";
            this.cButtonColor1.Size = new System.Drawing.Size(101, 23);
            this.cButtonColor1.TabIndex = 5;
            this.cButtonColor1.Text = "Reset";
            this.cButtonColor1.UseVisualStyleBackColor = true;
            this.cButtonColor1.Click += new System.EventHandler(this.cButtonColor1_Click);
            // 
            // FormOutPut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 342);
            this.Controls.Add(this.cButtonColor1);
            this.Controls.Add(this.listBoxOutPut);
            this.Name = "FormOutPut";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.listBoxOutPut, 0);
            this.Controls.SetChildIndex(this.cButtonColor1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOutPut;
        private Sim.Controles.cButtonColor cButtonColor1;
    }
}