using System;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sim.Classes
{
    public class Colors
    {

        private readonly Color c0 = Color.White;
        private readonly Color c1 = Color.Orange;
        private readonly Color c2 = Color.Silver;
        private readonly Color c3 = Color.CornflowerBlue;
        private readonly Color c4 = Color.YellowGreen;
        private readonly Color c5 = Color.Gold;
        private readonly Color c6 = Color.FromArgb(255,128, 128, 255);
        private readonly Color c7 = Color.FromArgb(255, 255, 128, 255);
        private readonly Color c8 = Color.LightSteelBlue;
        private readonly Color c9 = Color.FromArgb(255, 23, 23, 23);

        public SolidBrush mySolidBrush { get; set; }

        public Pen myPen { get; set; }
        public Pen myPenShadow { get; set; }
        public Pen myPenSubShadow { get; set; }

        public Brush myBrush { get; set; }
        public Brush FontBrush { get; set; }
        public Brush DisableFont { get; set; }

        public Color Cor { get; set; }
        public Color CorShadow { get; set; }
        public Color CorSubShadow { get; set; }
        public Color FontColor { get; set; }
        public Color WindowsColor { get; set; }

        public Colors()
        {

            if (CorAleatoria.Numero().Equals(0)) // Cor Branca
            {
                mySolidBrush = new SolidBrush(c0);
                myBrush = mySolidBrush;
                myPen = Pens.Gainsboro;
                myPenShadow = new Pen(Brushes.Silver, 1);
                myPenSubShadow = new Pen(Brushes.Gray, 1);
                Cor = c0;
                CorShadow = Color.Silver;
                CorSubShadow = Color.Gray;
                FontColor = Color.Black;
                FontBrush = Brushes.Black;
                DisableFont = Brushes.Gray;
                WindowsColor = Color.White;
            }
            else if (CorAleatoria.Numero().Equals(1)) // Laranja
            {
                mySolidBrush = new SolidBrush(c1);
                myBrush = mySolidBrush;
                myPen = new Pen(myBrush, 1);
                myPenShadow = new Pen(Brushes.Peru, 1);
                myPenSubShadow = new Pen(Brushes.DarkOrange, 1);
                Cor = c1;
                CorShadow = Color.DarkOrange;
                CorSubShadow = Color.DarkOrange;
                FontColor = Color.White;
                FontBrush = Brushes.White;
                DisableFont = Brushes.Peru;
                WindowsColor = Color.NavajoWhite;
            }

            else if (CorAleatoria.Numero().Equals(2)) // Cinza
            {
                mySolidBrush = new SolidBrush(Color.DarkGray);
                myBrush = mySolidBrush;
                myPen = new Pen(myBrush, 1);
                myPenShadow = new Pen(Brushes.DarkGray, 1);
                myPenSubShadow = new Pen(Brushes.Gray, 1);
                Cor = c2;
                CorShadow = Color.DarkGray;
                CorSubShadow = Color.Gray;
                FontColor = Color.Black;
                FontBrush = Brushes.Black;
                DisableFont = Brushes.Gray;
                WindowsColor = Color.Silver;
            }

            else if (CorAleatoria.Numero().Equals(3)) // Azul
            {
                mySolidBrush = new SolidBrush(Color.RoyalBlue);
                myBrush = mySolidBrush;
                myPen = new Pen(myBrush, 1);
                myPenShadow = new Pen(Brushes.RoyalBlue, 1);
                myPenSubShadow = new Pen(Brushes.DarkSlateBlue, 1);
                Cor = c3;
                CorShadow = Color.RoyalBlue;
                CorSubShadow = Color.DarkSlateBlue;
                FontColor = Color.White;
                FontBrush = Brushes.White;
                DisableFont = Brushes.DarkSlateBlue;
                WindowsColor = Color.CornflowerBlue;
            }

            else if (CorAleatoria.Numero().Equals(4)) // Verde
            {
                mySolidBrush = new SolidBrush(c4);
                myBrush = mySolidBrush;
                myPen = new Pen(myBrush, 1);
                myPenShadow = new Pen(Brushes.OliveDrab, 1);
                myPenSubShadow = new Pen(Brushes.DarkOliveGreen, 1);
                Cor = c4;
                CorShadow = Color.OliveDrab;
                CorSubShadow = Color.DarkOliveGreen;
                FontColor = Color.White;
                FontBrush = Brushes.White;
                DisableFont = Brushes.DarkOliveGreen;
                WindowsColor = Color.PaleGreen;
            }

            else if (CorAleatoria.Numero().Equals(5)) // Amarelo
            {
                mySolidBrush = new SolidBrush(c5);
                myBrush = mySolidBrush;
                myPen = new Pen(myBrush, 1);
                myPenShadow = new Pen(Brushes.Goldenrod, 1);
                myPenSubShadow = new Pen(Brushes.DarkGoldenrod, 1);
                Cor = c5;
                CorShadow = Color.Goldenrod;
                CorSubShadow = Color.DarkGoldenrod;
                FontColor = Color.Black;
                FontBrush = Brushes.Black;
                DisableFont = Brushes.DarkGoldenrod;
                WindowsColor = Color.Khaki;
            }

            else if (CorAleatoria.Numero().Equals(6)) // Roxo
            {
                mySolidBrush = new SolidBrush(c6);
                myBrush = mySolidBrush;
                myPen = new Pen(myBrush, 1);
                myPenShadow = new Pen(Brushes.SlateBlue, 1);
                myPenSubShadow = new Pen(Brushes.DarkSlateBlue, 1);
                Cor = c6;
                CorShadow = Color.SlateBlue;
                CorSubShadow = Color.DarkSlateBlue;
                FontColor = Color.White;
                FontBrush = Brushes.White;
                DisableFont = Brushes.DarkSlateBlue;
                WindowsColor = Color.FromArgb(255, 192, 192, 255);
            }

            else if (CorAleatoria.Numero().Equals(7)) // Rosa
            {
                mySolidBrush = new SolidBrush(c7);
                myBrush = mySolidBrush;
                myPen = new Pen(myBrush, 1);
                myPenShadow = new Pen(Brushes.Orchid, 1);
                myPenSubShadow = new Pen(Brushes.Orchid, 1);
                Cor = c7;
                CorShadow = Color.Orchid;
                CorSubShadow = Color.DarkOrchid;
                FontColor = Color.White;
                FontBrush = Brushes.White;
                DisableFont = Brushes.Orchid;
                WindowsColor = Color.FromArgb(255, 255, 192, 255);
            }

            else if (CorAleatoria.Numero().Equals(8)) // Metalico
            {
                mySolidBrush = new SolidBrush(c8);
                myBrush = mySolidBrush;
                myPen = new Pen(myBrush, 1);
                myPenShadow = new Pen(Brushes.LightSlateGray, 1);
                myPenSubShadow = new Pen(Brushes.LightSlateGray, 1);
                Cor = c8;
                CorShadow = Color.LightSlateGray;
                CorSubShadow = Color.SteelBlue;
                FontColor = Color.Black;
                FontBrush = Brushes.Black;
                DisableFont = Brushes.LightSlateGray;
                WindowsColor = Color.Lavender;
            }

            else if (CorAleatoria.Numero().Equals(9)) // Noturno
            {
                mySolidBrush = new SolidBrush(c9);
                myBrush = mySolidBrush;
                myPen = new Pen(myBrush, 1);
                myPenShadow = new Pen(Color.FromArgb(255, 13, 13, 13), 1);
                myPenSubShadow = new Pen(Color.FromArgb(255, 23, 23, 23), 1);
                Cor = c9;
                CorShadow = Color.FromArgb(255, 13, 13, 13);
                CorSubShadow = Color.FromArgb(255, 5, 5, 5);
                FontColor = Color.Silver;
                FontBrush = Brushes.Silver;
                DisableFont = Brushes.DimGray;
                WindowsColor = Color.FromArgb(255, 100, 100, 100);

            }

        }

    }

    public static class CorAleatoria
    {

        private static int numero = 0;

        public static int Numero()
        {            
            return numero;
        }

        public static void Valor(int valor)
        {
            numero = valor;
        }

    }

}
