using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;

namespace Sim.Legislacao.Xml
{
    static class XmlFile
    {
        public static List<string> Listar(string file, string elemento, string elementos, string item)
        {
            List<string> lista = new List<string>();
            var docxml = XDocument.Load(string.Format(@"{0}\Xml\{1}.xml", System.Windows.Forms.Application.StartupPath, file));
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
