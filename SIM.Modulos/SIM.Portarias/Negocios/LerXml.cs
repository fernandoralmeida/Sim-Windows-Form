using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;

namespace Sim.Portarias.RegraN
{
    internal static class LerXML
    {
        public static void ToComboBox(Sim.Componentes.Controles.cComboBox controle, string file)
        {
            controle.Items.Clear();
            var docxml = XDocument.Load(string.Format(@"{0}\Xml\{1}.xml", System.Windows.Forms.Application.StartupPath, file));
            var items = docxml.Element(XName.Get("Portarias")).Elements(XName.Get("Tipo"));
            var nitems = items.Select(ele => ele.Element(XName.Get("Item")).Value);

            foreach (string name in nitems)
            {
                controle.Items.Add(name);
            }
        }
    }
}
