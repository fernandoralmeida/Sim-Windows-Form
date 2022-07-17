using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Classes
{
    public class OwnedForms
    {
        
        public int Topo;
        public int Esquerdo;
        
        public System.Drawing.Point Local()
        {
            return new System.Drawing.Point(Esquerdo, Topo);
        }
        
        public int Comprimento;
        public int Largura;

        public System.Drawing.Size Tamanho()
        {
            return new System.Drawing.Size(Comprimento, Largura);
        }

    }
}
