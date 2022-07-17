using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Legislacao.Negocios
{
    public interface IRelatorios
    {
        void Gerar(Entidades.Legislacao obj, System.ComponentModel.BackgroundWorker bgwork);

        int Total();
        int TotalVig();
        int TotalAlt();
        int TotalRev();

        int Leis();
        int Decretos();
        int LeisComp();

        int LeisRev();
        int LeisAlt();
        int LeisVig();        

        int DecRev();
        int DecAlt();
        int DecVig();

        int LeisCompRev();
        int LeisCompAlt();
        int LeisCompVig();

        int LeisClass();
        int DecClass();
        int LeisCompClass();

        int LeisAutor();
        int DecAutor();
        int LeisCompAutor();

        int AutorLeg();
        int AutorExec();
        int AutorMesaDir();
        int AutorVer();

    }
}
