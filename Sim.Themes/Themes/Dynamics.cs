using System.Drawing;

namespace Sim.Gui.Themes
{
    public static class Dynamics
    {
        public static void SetColor()
        {
            byte red = Properties.Settings.Default.ColorControl.R;
            byte green = Properties.Settings.Default.ColorControl.G;
            byte blue = Properties.Settings.Default.ColorControl.B;

            byte dred = Properties.Settings.Default.ColorHighLight.R;
            byte dgreen = Properties.Settings.Default.ColorHighLight.G;
            byte dblue = Properties.Settings.Default.ColorHighLight.B;

            if (red == 0 && green == 0 && blue == 0)
            {
                Colors.Control = ColorVariant(255, red, green, blue, 0, 0);
                Colors.ControlLight = ColorVariant(255, red, green, blue, 30, 0);
                Colors.ControlLightLight = ColorVariant(255, red, green, blue, 40, 0);
                Colors.ControlDark = ColorVariant(255, red, green, blue, 20, 0);
                Colors.ControlDarkDark = ColorVariant(255, red, green, blue, 10, 0);
                Colors.ControlHighLight = ColorVariant(255, dred, dgreen, dblue, 70, 0);
                Colors.ControlHighLightDark = ColorVariant(255, dred, dgreen, dblue, 60, 0);
                Colors.ControlHighLightDarkDark = ColorVariant(255, dred, dgreen, dblue, 50, 0);
                Colors.ControlDisable = ColorVariant(255, red, green, blue, 20, 0);
                Colors.FontDisable = ColorVariant(255, red, green, blue, 50, 0);
                Colors.Font = FontVariant(red, green, blue);
            }
            else
            {
                Colors.Control = ColorVariant(255, red, green, blue, 0, 0);
                Colors.ControlLight = ColorVariant(255, red, green, blue, 20, 0);
                Colors.ControlLightLight = ColorVariant(255, red, green, blue, 40, 0);
                Colors.ControlDark = ColorVariant(255, red, green, blue, 0, 20);
                Colors.ControlDarkDark = ColorVariant(255, red, green, blue, 0, 40);
                Colors.ControlHighLight = ColorVariant(255, dred, dgreen, dblue, 10, 0);
                Colors.ControlHighLightDark = ColorVariant(255, dred, dgreen, dblue, 0, 30);
                Colors.ControlHighLightDarkDark = ColorVariant(255, dred, dgreen, dblue, 0, 70);
                Colors.ControlDisable = ColorVariant(255, red, green, blue, 0, 40);
                Colors.FontDisable = ColorVariant(255, red, green, blue, 0, 50);
                Colors.Font = FontVariant(red, green, blue);
            }
            
            SolidBrushes.Control = new SolidBrush(Colors.Control);
            SolidBrushes.ControlLight = new SolidBrush(Colors.ControlLight);
            SolidBrushes.ControlLightLight = new SolidBrush(Colors.ControlLightLight);
            SolidBrushes.ControlDark = new SolidBrush(Colors.ControlDark);
            SolidBrushes.ControlDarkDark = new SolidBrush(Colors.ControlDarkDark);
            SolidBrushes.ControlHighLight = new SolidBrush(Colors.ControlHighLight);
            SolidBrushes.ControlHighLightDark = new SolidBrush(Colors.ControlHighLightDark);
            SolidBrushes.ControlHighLightDarkDark = new SolidBrush(Colors.ControlHighLightDarkDark);
            SolidBrushes.ControlDisable = new SolidBrush(Colors.ControlDisable);

            Brushes.Control = SolidBrushes.Control;
            Brushes.ControlLight = SolidBrushes.ControlLight;
            Brushes.ControlLightLight = SolidBrushes.ControlLightLight;
            Brushes.ControlHighLight = SolidBrushes.ControlHighLight;
            Brushes.ControlHighLightDark = SolidBrushes.ControlHighLightDark;
            Brushes.ControlHighLightDarkDark = SolidBrushes.ControlHighLightDarkDark;
            Brushes.ControlDark = SolidBrushes.ControlDark;
            Brushes.ControlDarkDark = SolidBrushes.ControlDarkDark;
            Brushes.ControlDisable = SolidBrushes.ControlDisable;
            Brushes.Font = new SolidBrush(Colors.Font);
            Brushes.FontHighLight = new SolidBrush(FontVariant(dred, dgreen, dblue));
            Brushes.FontDisable = new SolidBrush(Colors.FontDisable);

            Pens.Control = new Pen(Brushes.Control, 1);
            Pens.ControlLight = new Pen(Brushes.ControlLight, 1);
            Pens.ControlLightLight = new Pen(Brushes.ControlLightLight, 1);
            Pens.ControlDark = new Pen(Brushes.ControlDark, 1);
            Pens.ControlDarkDark = new Pen(Brushes.ControlDarkDark, 1);
            Pens.ControlDisable = new Pen(Brushes.ControlDisable, 1);
            Pens.ControlHighLight = new Pen(Brushes.ControlHighLight, 1);
            Pens.ControlHighLightDark = new Pen(Brushes.ControlHighLightDark, 1);
            Pens.ControlHighLightDarkDark = new Pen(Brushes.ControlHighLightDarkDark, 1);
            Pens.DashedHighLight = new Pen(Brushes.ControlHighLight, 1);
            Pens.DashedHighLightDark = new Pen(Brushes.ControlHighLightDark, 1);
            Pens.DashedHighLightDarkDark = new Pen(Brushes.ControlHighLightDarkDark, 1);
            Pens.Font = new Pen(Brushes.Font, 1);
            Pens.FontHighlight = new Pen(Brushes.FontHighLight, 1);

        }

        private static Color ColorVariant(byte alpha, byte red, byte green, byte blue, byte light, byte dark)
        {

            try
            {

                int newred = red - dark + light;
                int newgreen = green - dark + light;
                int newblue = blue - dark + light;

                if (newred < 0) { newred = 0; }
                if (newred > 255) { newred = 255; }

                if (newgreen < 0) { newgreen = 0; }
                if (newgreen > 255) { newgreen = 255; }

                if (newblue < 0) { newblue = 0; }
                if (newblue > 255) { newblue = 255; }

                return Color.FromArgb(alpha, (byte)newred, (byte)newgreen, (byte)newblue);

            }
            catch (System.Exception ex)
            {
                return Color.White;
                throw new System.Exception(ex.Message);
            }
        }

        private static Color FontVariant(byte r, byte g, byte b)
        {

            int v = r + g + b;

            byte red = r;
            byte green = g;
            byte blue = b;

            if (v > 500)
            { red = 0; green = 0; blue = 0; }
            else
            { red = 255; green = 255; blue = 255; }

            return Color.FromArgb(255, red, green, blue);

        }
    }
}
