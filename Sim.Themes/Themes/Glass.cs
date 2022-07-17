using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sim.Gui.Themes
{
    public static class Glass
    {
        //*** Mouse Off
        public static LinearGradientBrush ControlI(Rectangle area)
        {
            Color Color1 = Colors.Control;
            Color Color2 = Colors.ControlDark;

            Rectangle rect1 = new Rectangle(new Point(1, 1), new Size(area.Width, (area.Height / 2)));
            Rectangle rect2 = new Rectangle(new Point(1, (area.Height / 2)), new Size(area.Width, area.Height));

            return new LinearGradientBrush(rect1, Color1, Color2, LinearGradientMode.Vertical);
        }

        public static LinearGradientBrush ControlE(Rectangle area)
        {
            Color Color1 = Colors.ControlDarkDark;
            Color Color2 = Colors.ControlDark;

            Rectangle rect1 = new Rectangle(new Point(1, 1), new Size(area.Width, (area.Height / 2)));
            Rectangle rect2 = new Rectangle(new Point(1, (area.Height / 2)), new Size(area.Width, area.Height));

            return new LinearGradientBrush(rect2, Color1, Color2, LinearGradientMode.Vertical);
        }

        //*** Mouse Hover
        public static LinearGradientBrush ControlHoverI(Rectangle area)
        {
            Color Color1 = Colors.ControlHighLight;
            Color Color2 = Colors.ControlHighLightDark;

            Rectangle rect1 = new Rectangle(new Point(1, 1), new Size(area.Width, (area.Height / 2)));
            Rectangle rect2 = new Rectangle(new Point(1, (area.Height / 2)), new Size(area.Width, area.Height));

            return new LinearGradientBrush(rect1, Color1, Color2, LinearGradientMode.Vertical);
        }

        public static LinearGradientBrush ControlHoverE(Rectangle area)
        {
            Color Color1 = Colors.ControlHighLightDarkDark;
            Color Color2 = Colors.ControlHighLightDark;

            Rectangle rect1 = new Rectangle(new Point(1, 1), new Size(area.Width, (area.Height / 2)));
            Rectangle rect2 = new Rectangle(new Point(1, (area.Height / 2)), new Size(area.Width, area.Height));

            return new LinearGradientBrush(rect2, Color1, Color2, LinearGradientMode.Vertical);
        }

        //*** Mouse Press
        public static LinearGradientBrush ControlPressI(Rectangle area)
        {
            Color Color1 = Colors.ControlDark;
            Color Color2 = Colors.ControlDark;

            Rectangle rect1 = new Rectangle(new Point(1, 1), new Size(area.Width, (area.Height / 2)));
            Rectangle rect2 = new Rectangle(new Point(1, (area.Height / 2)), new Size(area.Width, area.Height));

            return new LinearGradientBrush(rect1, Color1, Color2, LinearGradientMode.Vertical);
        }

        public static LinearGradientBrush ControlPressE(Rectangle area)
        {
            Color Color1 = Colors.ControlDark;
            Color Color2 = Colors.ControlDark;

            Rectangle rect1 = new Rectangle(new Point(1, 1), new Size(area.Width, (area.Height / 2)));
            Rectangle rect2 = new Rectangle(new Point(1, (area.Height / 2)), new Size(area.Width, area.Height));

            return new LinearGradientBrush(rect2, Color1, Color2, LinearGradientMode.Vertical);
        }
    }
}
