using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sim.Gui.Themes.Gradient
{
    internal static class Frosted
    {
        //
        //***** Desenha controles no estilo "FOSCO"
        //

        internal static void DrawButton(PaintEventArgs e, Size size)
        {
            Color cor1 = Colors.Control; // Cor inicial da parte superior do controle
            Color cor2 = Colors.ControlDark; // Cor final da parte Superior do controle		

            // Divide a area em duas partes, A e B, ou parte superior e inferior
            Rectangle rect = new Rectangle(new Point(1, 1), new Size(size.Width, size.Height ));

            LinearGradientBrush gradient = new LinearGradientBrush(rect, cor1, cor2, LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(gradient, rect);
        }

        internal static void DrawButtonOnHover(PaintEventArgs e, Size size)
        {
            Color cor1 = Colors.ControlHighLight;
            Color cor2 = Colors.ControlHighLightDark;

            Rectangle rect = new Rectangle(new Point(1, 1), new Size(size.Width, size.Height));

            LinearGradientBrush gradient = new LinearGradientBrush(rect, cor1, cor2, LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(gradient, rect);
        }

        internal static void DrawButtonOnPress(PaintEventArgs e, Size size)
        {
            Color cor1 = Colors.ControlHighLightDarkDark;
            Color cor2 = Colors.ControlHighLightDark;

            Rectangle rect = new Rectangle(new Point(1, 1), new Size(size.Width, size.Height));

            LinearGradientBrush gradient = new LinearGradientBrush(rect, cor1, cor2, LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(gradient, rect);
        }
    }
}
