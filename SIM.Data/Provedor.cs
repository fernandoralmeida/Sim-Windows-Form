using System;
using System.Text;

namespace Sim.Data
{
    class Provedor
    {
        static public readonly string OleDB = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Data\";
        //static public readonly string OleDB = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\192.168.1.243\Relacoes Institucionais\Sim.Data\";
        static public readonly string SqlCE = @"Data Source=|DataDirectory|\Data\";
        //static public readonly string SqlCE = @"Data Source=\\192.168.1.243\Relacoes Institucionais\Sim.Data\";
        static public readonly string OleBDSqlCE = @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;Data Source=|DataDirectory|\Data\";
    }
}
