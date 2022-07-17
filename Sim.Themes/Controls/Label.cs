using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sim.Gui.Controls
{
    public partial class Label : System.Windows.Forms.Label
    {
        public Label()
        {
            InitializeComponent();
        }

        public Label(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.ForeColor = Themes.Colors.Font;
        }
    }
}
