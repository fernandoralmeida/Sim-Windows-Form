using System.Drawing;
using System.Windows.Forms;

namespace Sim.Gui.Themes
{
    public enum ModeGradient { Frosted, Glass }

    public static class StyleControl
    {

        public static void Normal(ModeGradient modgrad, PaintEventArgs e, Size size)
        {
            switch (modgrad)
            {
                case ModeGradient.Frosted:
                    Gradient.Frosted.DrawButton(e, size);
                    break;
                case ModeGradient.Glass:
                    Gradient.Glass.DrawButton(e, size);
                    break;
            }
        }

        public static void OnHover(ModeGradient modgrad, PaintEventArgs e, Size size)
        {
            switch (modgrad)
            {
                case ModeGradient.Frosted:
                    Gradient.Frosted.DrawButtonOnHover(e, size);
                    break;
                case ModeGradient.Glass:
                    Gradient.Glass.DrawButtonOnHover(e, size);
                    break;
            }
        }

        public static void OnPress(ModeGradient modgrad, PaintEventArgs e, Size size)
        {
            switch (modgrad)
            {
                case ModeGradient.Frosted:
                    Gradient.Frosted.DrawButtonOnPress(e, size);
                    break;
                case ModeGradient.Glass:
                    Gradient.Glass.DrawButtonOnPress(e, size);
                    break;
            }
        }
        
    }
}
