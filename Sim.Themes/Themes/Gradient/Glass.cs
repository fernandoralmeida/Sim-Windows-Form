using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Sim.Gui.Themes.Gradient
{

    internal static class Glass
    {

        // Desenha controle no estilo "VIDRO"

        internal static void DrawButton(PaintEventArgs e, Size size)
        {
            Color cor1 = Colors.Control; // Cor inicial da parte superior do controle
            Color cor2 = Colors.ControlDarkDark; // Cor final da parte Superior do controle
            Color cor3 = Colors.ControlDarkDark; // Cor inicial da parte inferior do controle
            Color cor4 = Colors.ControlDark; // Cor final da parte inferior do controle				

            // Divide a area em duas partes, A e B, ou parte superior e inferior
            Rectangle rect1 = new Rectangle(new Point(0, 0), new Size(size.Width, (size.Height)));
            Rectangle rect2 = new Rectangle(new Point(0, size.Height / 2), new Size(size.Width, size.Height / 2));

            LinearGradientBrush gradientTop = new LinearGradientBrush(rect1, cor1, cor2, LinearGradientMode.Vertical);
            LinearGradientBrush gradientBotton = new LinearGradientBrush(rect2, cor3, cor4, LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(gradientTop, rect1);
            e.Graphics.FillRectangle(gradientBotton, rect2);
        }

        internal static void DrawButtonOnHover(PaintEventArgs e, Size size)
        {
            Color cor1 = Colors.ControlHighLight;
            Color cor2 = Colors.ControlHighLightDarkDark;
            Color cor3 = Colors.ControlHighLightDarkDark;
            Color cor4 = Colors.ControlHighLightDark;

            Rectangle rect1 = new Rectangle(new Point(0, 0), new Size(size.Width, (size.Height)));
            Rectangle rect2 = new Rectangle(new Point(0, (size.Height / 2)), new Size(size.Width, size.Height / 2));
            
            LinearGradientBrush gradientTop = new LinearGradientBrush(rect1, cor1, cor2, LinearGradientMode.Vertical);
            LinearGradientBrush gradientBotton = new LinearGradientBrush(rect2, cor3, cor4, LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(gradientTop, rect1);
            e.Graphics.FillRectangle(gradientBotton, rect2);
        }

        internal static void DrawButtonOnPress(PaintEventArgs e, Size size)
        {
            Color cor1 = Colors.ControlHighLight;
            Color cor2 = Colors.ControlHighLightDark;
            Color cor3 = Colors.ControlHighLightDarkDark;
            Color cor4 = Colors.ControlHighLightDark;

            //Rectangle rect1 = new Rectangle(new Point(0, 0), new Size(size.Width, (size.Height / 2)));
            //Rectangle rect2 = new Rectangle(new Point(0, (size.Height / 2)), new Size(size.Width, size.Height / 2));  
            Rectangle rect3 = new Rectangle(new Point(0, 0), new Size(size.Width, size.Height));

            //LinearGradientBrush gradientTop = new LinearGradientBrush(rect1, cor3, cor2, LinearGradientMode.Vertical);
            //LinearGradientBrush gradientBotton = new LinearGradientBrush(rect2, cor2, cor2, LinearGradientMode.Vertical);
            LinearGradientBrush ngrad = new LinearGradientBrush(rect3, cor3, cor2, LinearGradientMode.Vertical);

            //e.Graphics.FillRectangle(gradientTop, rect1);
            //e.Graphics.FillRectangle(gradientBotton, rect2);

            e.Graphics.FillRectangle(ngrad, rect3);
        }

    }
}
