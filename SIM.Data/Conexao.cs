using System;
using System.Text;

namespace Sim.Data
{
    class Conexao
    {

        string ProvedorAtivo = string.Empty;
        string BancodeDadosAtivo = string.Empty;
        string pSecurity = @"Persist Security Info=True";

        public Conexao(string provedor, string bancodados) 
        {
            this.ProvedorAtivo = provedor;
            this.BancodeDadosAtivo = bancodados;
        }
                
        public override string ToString()
        {
            return string.Format(@"{0}{1};{2}", this.ProvedorAtivo, this.BancodeDadosAtivo, this.pSecurity); ;
        }

    }
}
