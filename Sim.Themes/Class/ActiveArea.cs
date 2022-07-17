using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Gui.Class
{
    public static class ActiveArea
    {
        public static int Topo;
        public static int Esquerdo;
        public static int Direito;
        public static int Baixo;
        public static int Largura;
        public static int Altura;

        public static System.Drawing.Point Local()
        {
            return new System.Drawing.Point(Esquerdo, Topo);
        }

        public static System.Drawing.Size Tamanho()
        {
            return new System.Drawing.Size(Largura, Altura);
        }
    }
}
