namespace Login.Visao
{
    partial class FmAccounts
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
            this.cButtonNewUser = new Sim.Gui.Controls.Button(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.flexDataGrid2 = new Login.Visao.FlexDataGrid();
            this.SuspendLayout();
            // 
            // cButtonNewUser
            // 
            this.cButtonNewUser.InFocus = Sim.Gui.Controls.FocusType.No;
            this.cButtonNewUser.Location = new System.Drawing.Point(12, 30);
            this.cButtonNewUser.Name = "cButtonNewUser";
            this.cButtonNewUser.Size = new System.Drawing.Size(151, 23);
            this.cButtonNewUser.TabIndex = 0;
            this.cButtonNewUser.Text = "Novo Usuário";
            this.cButtonNewUser.TypeControlBox = Sim.Gui.Controls.ControlBoxType.End;
            this.cButtonNewUser.UseVisualStyleBackColor = true;
            this.cButtonNewUser.Click += new System.EventHandler(this.cButtonNewUser_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 58);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(568, 331);
            this.elementHost1.TabIndex = 5;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.flexDataGrid2;
            // 
            // FmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 401);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.cButtonNewUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmAccounts";
            this.Text = "Sim.Contas de Usuários";
            this.Load += new System.EventHandler(this.FmAccounts_Load);
            this.Controls.SetChildIndex(this.cButtonNewUser, 0);
            this.Controls.SetChildIndex(this.elementHost1, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Sim.Gui.Controls.Button cButtonNewUser;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private FlexDataGrid flexDataGrid2;
    }
}