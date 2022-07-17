using System.ComponentModel;

namespace Sim.Componentes.Controles
{
    public partial class cDataGridView : System.Windows.Forms.DataGridView
    {
        public cDataGridView()
        {
            InitializeComponent();
            Sim.Componentes.Classes.ColorTheme.GetTheme();
        }

        public cDataGridView(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            this.ColumnHeadersDefaultCellStyle.BackColor = Sim.Componentes.Classes.ColorTheme.Controle;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;

            this.RowHeadersDefaultCellStyle.BackColor = Sim.Componentes.Classes.ColorTheme.Controle;

            this.RowsDefaultCellStyle.BackColor = Sim.Componentes.Classes.ColorTheme.WindowColor;
            this.RowsDefaultCellStyle.ForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;
            this.AlternatingRowsDefaultCellStyle.BackColor = Sim.Componentes.Classes.ColorTheme.WindowColor;
            this.AlternatingRowsDefaultCellStyle.ForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;
            
            this.RowsDefaultCellStyle.SelectionBackColor = Sim.Componentes.Classes.ColorTheme.ControleDarkDark;
            this.RowsDefaultCellStyle.SelectionForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;
            this.AlternatingRowsDefaultCellStyle.SelectionBackColor = Sim.Componentes.Classes.ColorTheme.ControleDarkDark;
            this.AlternatingRowsDefaultCellStyle.SelectionForeColor = Sim.Componentes.Classes.ColorTheme.ForeColor;

            this.GridColor = Sim.Componentes.Classes.ColorTheme.ControleLight;
            this.BackgroundColor = Sim.Componentes.Classes.ColorTheme.Controle;
            /*
            System.Drawing.Rectangle area = new System.Drawing.Rectangle(0, 0, this.Width, this.ColumnHeadersHeight);
            System.Drawing.Drawing2D.LinearGradientBrush degrade = new System.Drawing.Drawing2D.LinearGradientBrush(area, System.Drawing.Color.FromArgb(50, Sim.Componentes.Classes.ColorTheme.Controle), System.Drawing.Color.FromArgb(50, Sim.Componentes.Classes.ColorTheme.ControleDarkDark), System.Drawing.Drawing2D.LinearGradientMode.Vertical);

            if (this.RowCount > -1)
            {
                if (this.ColumnHeadersVisible.Equals(true))
                    e.Graphics.FillRectangle(degrade, area);
            }
            */
        }
    }
}
