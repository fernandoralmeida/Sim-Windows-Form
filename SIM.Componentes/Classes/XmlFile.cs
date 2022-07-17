using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;

namespace Sim.Classes
{
    public class XmlFile
    {

        public enum XmlMLG
        {
            TiposDoc = 0,
            SituacaoAD = 1,
            AcoesED = 2,
            OrigemDoc = 3,
            AutorLegislativo = 4,
            DecretoClassificacao = 5,
            LeisClassificacao = 6,
            Limpar = 7
        }

        public DataSet xmlDS(XmlMPO valor, string xarquivo)
        {

            DataSet ds = new DataSet();

            try
            {
                ds.ReadXml(string.Format(@"{0}\Xml\{1}.xml", Application.StartupPath, xarquivo));
                int i = ds.Tables[Convert.ToInt32(valor)].Rows.Count;
            }
            catch { }
            finally { }

            return ds;
        }

        public DataTable xmlDT(XmlMLG valor)
        {

            DataSet DS = new DataSet();
            DataTable DT = new DataTable();

            try
            {
                DS.ReadXml(string.Format(@"{0}\Xml\Legislacao.xml", Application.StartupPath));
                DT = DS.Tables[Convert.ToInt32(valor)];  
            }
            catch { DT = null; }
            finally { DS = null; }

            return DT;
        }
               
        public void ComboXML(ComboBox controle, XmlMLG numero)
        {
            DataSet xmlDS = new DataSet();
            try 
            {                 
                xmlDS.ReadXml(string.Format(@"{0}\Xml\Legislacao.xml", Application.StartupPath));
                controle.DataSource = xmlDS.Tables[Convert.ToInt32(numero)];
                controle.DisplayMember = "Item";
                controle.ValueMember = "Valor";
            }
            catch /*(Exception ex)*/ { /*MessageBox.Show(ex.Message);*/ }
            finally { xmlDS = null; }
        }

        public struct xTabela { public const string xMLG = "Legislacao"; public const string xMPO = "Portaria"; }

        public enum XmlMPO { Tipos = 0 }

        public void CarregarXML(ComboBox controle, XmlMPO valor, string xarquivo)
        {
            DataSet xmlDS = new DataSet();
            try
            {
                xmlDS.ReadXml(string.Format(@"{0}\Xml\{1}.xml", Application.StartupPath, xarquivo));
                controle.DataSource = xmlDS.Tables[Convert.ToInt32(valor)];
                controle.DisplayMember = "Item";
                controle.ValueMember = "Valor";

            }
            catch { }
            finally { xmlDS = null; }
        }

        public void CarregarCBBox(Sim.Componentes.Controles.cComboBox controle, XmlMPO valor, string xarquivo)
        {
            DataSet xmlDS = new DataSet();
            try
            {
                xmlDS.ReadXml(string.Format(@"{0}\Xml\{1}.xml", Application.StartupPath, xarquivo));
                controle.DataSource = xmlDS.Tables[Convert.ToInt32(valor)];
                controle.DisplayMember = "Item";
                controle.ValueMember = "Valor";
            }
            catch { }
            finally { xmlDS = null; }
        }

        public void Valores(Sim.Componentes.Controles.cComboBox controle, string xarquivo)
        {

            var docxml = XDocument.Load(string.Format(@"{0}\Xml\{1}.xml", Application.StartupPath, xarquivo));
            var items = docxml.Element(XName.Get("Portarias")).Elements(XName.Get("Tipo"));
            var nitems = items.Select(ele => ele.Element(XName.Get("Item")).Value);

            foreach (string name in nitems)
            {
                controle.Items.Add(name);
            }
        }

        public List<string> Listar(string file)
        {
            List<string> listar = new List<string>();

            var docxml = XDocument.Load(string.Format(@"{0}\Xml\{1}.xml", Application.StartupPath, file));
            var items = docxml.Element(XName.Get("Portarias")).Elements(XName.Get("Tipo"));
            var nitems = items.Select(ele => ele.Element(XName.Get("Item")).Value);

            foreach (string name in nitems)
            {
                listar.Add(name);
            }

            System.Windows.Forms.MessageBox.Show(listar.ToList().ToString());

            return listar;
        }
        
    }
}
