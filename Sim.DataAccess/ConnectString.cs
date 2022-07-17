using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim.DataAccess
{
    class ConnectString
    {

        internal static string SimDataBase1 = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}SimDataBase1.mdb;Persist Security Info=True", Listar("Sim.Data", "Data", "Conexao", "Rede")[0]);
        internal static string SimDataBase2 = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}SimDataBase2.mdb;Persist Security Info=True", Listar("Sim.Data", "Data", "Conexao", "Rede")[0]);

        static List<string> Listar(string file, string elemento, string elementos, string item)
        {
            List<string> lista = new List<string>();
            var docxml = XDocument.Load(string.Format(@"{0}\xml\{1}.xml", System.Windows.Forms.Application.StartupPath, file));
            var items = docxml.Element(XName.Get(elemento)).Elements(XName.Get(elementos));
            var nitems = items.Select(ele => ele.Element(XName.Get(item)).Value);

            foreach (string name in nitems)
            {
                lista.Add(name);
            }

            return lista;
        }

    }
}
