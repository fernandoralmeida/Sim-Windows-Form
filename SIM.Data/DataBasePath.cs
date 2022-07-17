using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Data
{
    class DataBasePath
    {
        //private static string sDataBase1 = @"Data Source=\\192.168.1.243\Relacoes Institucionais\Sim.Data\sDatabase1.sdf;Persist Security Info=True";
        //private static string sDataBase2 = @"Data Source=\\192.168.1.243\Relacoes Institucionais\Sim.Data\sDatabase2.sdf;Persist Security Info=True";

        internal static string sDataBase1 = @"Data Source=|DataDirectory|\Data\sDatabase1.sdf;Persist Security Info=True";
        internal static string sDataBase2 = @"Data Source=|DataDirectory|\Data\sDatabase2.sdf;Persist Security Info=True";
    }
}
