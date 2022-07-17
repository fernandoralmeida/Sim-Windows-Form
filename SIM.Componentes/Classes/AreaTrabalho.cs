using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Componentes.Classes
{
    public static class AreaTrabalho
    {
        
        public struct Posicao
        {
            public static int Topo;
            public static int Esquerdo;
            public static int Direito;
            public static int Baixo;
        }

        public static System.Drawing.Point Local()
        {
            return new System.Drawing.Point(Posicao.Esquerdo, Posicao.Topo);
        }

        public struct Area
        {
            public static int Largura;
            public static int Altura;
        }

        public static System.Drawing.Size Tamanho()
        {
            return new System.Drawing.Size(Area.Largura, Area.Altura);
        }
        
    }
}
