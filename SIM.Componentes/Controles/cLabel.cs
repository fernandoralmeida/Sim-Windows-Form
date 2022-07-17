using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
//using System.Diagnostics;
//using System.Linq;
using System.Text;

namespace Sim.Controles
{
    public partial class cLabel :  System.Windows.Forms.Label
    {
        public cLabel()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }

        public cLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private string rotulo;
        public string Rotulo 
        { 
            get 
            {
                return this.rotulo;
            }

            set
            {
                this.rotulo = value;
                Invalidate();
            }
            
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

            e.Graphics.DrawString(this.Rotulo, this.Font, Brushes.Black, (this.Width - e.Graphics.MeasureString(this.Rotulo, this.Font).Width) / 2, (this.Height - e.Graphics.MeasureString(this.Rotulo, this.Font).Height) / 2);
           
        }

    }
}
