using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Sim.Gui.Controls
{
    public partial class DataGridView : Component
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        public DataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
