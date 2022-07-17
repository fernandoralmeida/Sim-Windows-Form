using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Sim.Componentes.Classes
{
    public static class ColorTheme
    {

        private static Color Branco = Color.FromArgb(255, 245, 245, 245);
        private static Color Cinza = Color.FromArgb(255, 192, 192, 192);
        private static Color Metalico = Color.FromArgb(255, 176, 196, 220);
        private static Color Azul = Color.FromArgb(255, 10, 90, 195);
        private static Color Laranja = Color.FromArgb(255, 220, 87, 46);
        private static Color Roxo = Color.FromArgb(255, 100, 62, 191);
        private static Color Pink = Color.FromArgb(255, 167, 0, 174);
        private static Color Acqua = Color.FromArgb(255, 0, 160, 177);
        private static Color Dark = Color.FromArgb(255, 80, 80, 80);
        private static Color Amarelo = Color.FromArgb(255, Color.Gold);

        public static SolidBrush SolidBrush { get; set; }
        public static SolidBrush SolidBrushDark { get; set; }
        public static SolidBrush SolidBrushDarkDark { get; set; }
        public static SolidBrush SolidBrushLight { get; set; }
        public static SolidBrush SolidBrushLightLight { get; set; }

        public static Pen Pen { get; set; }
        public static Pen PenDark { get; set; }
        public static Pen PenDarkDark { get; set; }
        public static Pen PenLight { get; set; }
        public static Pen PenLightLight { get; set; }

        public static Brush Brush { get; set; }
        public static Brush BrushDark { get; set; }
        public static Brush BrushDarkDark { get; set; }
        public static Brush BrushLight { get; set; }
        public static Brush BrushLightLight { get; set; }

        public static Brush FontBrush { get; set; }
        public static Brush DisableFont { get; set; }

        public static Color ControleLight { get; set; }
        public static Color ControleLightLight { get; set; }
        public static Color Controle { get; set; }
        public static Color ControleDark { get; set; }
        public static Color ControleDarkDark { get; set; }
        public static Color ForeColor { get; set; }
        public static Color TitleColor { get; set; }
        public static Color WindowColor { get; set; }

        public static Color Highlight { get; set; }
        public static Color HighlightShadow { get; set; }
        public static Color HighlightDark { get; set; }

        public static Color TitleBar { get; set; }
        public static SolidBrush BorderForm { get; set; }

        public static void GetTheme()
        {
            byte red = Properties.Settings.Default.Tema.R;
            byte green = Properties.Settings.Default.Tema.G;
            byte blue = Properties.Settings.Default.Tema.B;

            byte RDestaque = Properties.Settings.Default.TemaDestaque.R;
            byte GDestaque = Properties.Settings.Default.TemaDestaque.G;
            byte BDestaque = Properties.Settings.Default.TemaDestaque.B;

            //if (red == null || green == null || blue == null) { red = 220; green = 220; blue = 220; }

            if (red == 0 && green == 0 && blue == 0)
            {

                SolidBrush = new SolidBrush(CorVariavel(0, 0, red, green, blue));
                SolidBrushDark = new SolidBrush(CorVariavel(10, 0, red, green, blue));
                SolidBrushDarkDark = new SolidBrush(CorVariavel(20, 0, red, green, blue));
                SolidBrushLight = new SolidBrush(CorVariavel(30, 0, red, green, blue));
                SolidBrushLightLight = new SolidBrush(CorVariavel(40, 0, red, green, blue));

                Pen = new Pen(SolidBrush, 1);
                PenDark = new Pen(SolidBrushDark, 1);
                PenDarkDark = new Pen(SolidBrushDarkDark, 1);
                PenLight = new Pen(SolidBrushLight, 1);
                PenLightLight = new Pen(SolidBrushLightLight, 1);

                Brush = SolidBrush;
                BrushDark = SolidBrushDark;
                BrushDarkDark = SolidBrushDarkDark;
                BrushLight = SolidBrushLight;
                BrushLightLight = SolidBrushLightLight;

                TitleBar = CorVariavel(10, 0, red, green, blue);
                BorderForm = new SolidBrush(CorVariavel(20, 0, red, green, blue));

                Controle = CorVariavel(0, 0, red, green, blue);
                ControleDark = CorVariavel(10, 0, red, green, blue);
                ControleDarkDark = CorVariavel(20, 0, red, green, blue);
                ControleLight = CorVariavel(30, 0, red, green, blue);
                ControleLightLight = CorVariavel(40, 0, red, green, blue);

                WindowColor = CorVariavel(5, 0, red, green, blue); ;

                ForeColor = FontColor(red, green, blue);
                FontBrush = new SolidBrush(FontColor(red, green, blue));
                DisableFont = new SolidBrush(CorVariavel(50, 0, red, green, blue));

                Highlight = CorVariavel(20, 0, RDestaque, GDestaque, BDestaque);
                HighlightShadow = CorVariavel(30, 0, RDestaque, GDestaque, BDestaque);
                HighlightDark = CorVariavel(40, 0, RDestaque, GDestaque, BDestaque);
            }
            else
            {
                SolidBrush = new SolidBrush(CorVariavel(0, 0, red, green, blue));
                SolidBrushDark = new SolidBrush(CorVariavel(0, 20, red, green, blue));
                SolidBrushDarkDark = new SolidBrush(CorVariavel(0, 40, red, green, blue));
                SolidBrushLight = new SolidBrush(CorVariavel(20, 0, red, green, blue));
                SolidBrushLightLight = new SolidBrush(CorVariavel(40, 0, red, green, blue));

                Pen = new Pen(SolidBrush, 1);
                PenDark = new Pen(SolidBrushDark, 1);
                PenDarkDark = new Pen(SolidBrushDarkDark, 1);
                PenLight = new Pen(SolidBrushLight, 1);
                PenLightLight = new Pen(SolidBrushLightLight, 1);

                Brush = SolidBrush;
                BrushDark = SolidBrushDark;
                BrushDarkDark = SolidBrushDarkDark;
                BrushLight = SolidBrushLight;
                BrushLightLight = SolidBrushLightLight;

                TitleBar = CorVariavel(0, 20, red, green, blue);
                BorderForm = new SolidBrush(CorVariavel(0, 20, red, green, blue));

                Controle = CorVariavel(0, 0, red, green, blue);
                ControleDark = CorVariavel(0, 20, red, green, blue);
                ControleDarkDark = CorVariavel(0, 40, red, green, blue);
                ControleLight = CorVariavel(20, 0, red, green, blue);
                ControleLightLight = CorVariavel(40, 0, red, green, blue);

                WindowColor = CorVariavel(0, 20, red, green, blue); ;

                ForeColor = FontColor(red, green, blue);
                FontBrush = new SolidBrush(FontColor(red, green, blue));
                DisableFont = new SolidBrush(CorVariavel(0, 50, red, green, blue));

                Highlight = CorVariavel(20, 0, RDestaque, GDestaque, BDestaque);
                HighlightShadow = CorVariavel(0, 20, RDestaque, GDestaque, BDestaque);
                HighlightDark = CorVariavel(0, 40, RDestaque, GDestaque, BDestaque);
            }
        }

        private static Color CorVariavel(byte mais, byte menos, byte r, byte g, byte b)
        {

            Color rtn = Color.White;

            try
            {

                if (r.Equals(null) || g.Equals(null) || b.Equals(null))
                {
                    r = 255; g = 255; b = 255;
                }

                if (mais.Equals(null)) { mais = 0; }

                if (menos.Equals(null)) { menos = 0; }

                int red = r + mais - menos;
                int green = g + mais - menos;
                int blue = b + mais - menos;

                if (red < 0) { red = 0; }
                if (red > 255) { red = 255; }

                if (green < 0) { green = 0; }
                if (green > 255) { green = 255; }

                if (blue < 0) { blue = 0; }
                if (blue > 255) { blue = 255; }

                rtn = Color.FromArgb(255, (byte)red, (byte)green, (byte)blue);

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "SIM.Alerta");
            }

            return rtn;

        }

        private static Color FontColor(byte r, byte g, byte b)
        {

            int v = r + g + b;

            byte red = r;
            byte green = g;
            byte blue = b;

            /*
            if (r > 150 && g > 150 && b > 50)
            {
                red = 5; green = 5; blue = 5;
            }
            else
            {
                if (b < 50)
                { red = 5; green = 5; blue = 5; }
                else
                { red = 255; green = 255; blue = 255; }
            }
            
            if (r.Equals(0) && g.Equals(0) && b.Equals(0))
            { red = 255; green = 255; blue = 255; }
            */

            if (v > 500)
            { red = 5; green = 5; blue = 5; }
            else
            { red = 255; green = 255; blue = 255; }

            return Color.FromArgb(255, red, green, blue);

        }

        private static string ColorValue()
        {

            byte r = Sim.Componentes.Properties.Settings.Default.Tema.R;
            byte g = Sim.Componentes.Properties.Settings.Default.Tema.G;
            byte b = Sim.Componentes.Properties.Settings.Default.Tema.B;

            int total = r + g + b;

            return string.Format("Color R:{0} G:{1} B:{2} :: {3}", r, g, b, total);

        }

    }


}
