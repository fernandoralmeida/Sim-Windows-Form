using System;
using System.Collections.Generic;
using System.Text;
using Sim.Classes;
using System.Windows.Forms;

namespace Sim.Desktop.LogicaNegocios
{
    public class SeletorModulo
    {

        public enum Modulo { Reset, MLG, MCC, MPO }

        public static int ModuloAtivo
        { get; set; }

        public static void AtivarModulo(Modulo select)
        {
            ModuloAtivo = (int)select;
        }

        private static IntPtr handleINC;
        public static void MDsIncluir(Form form, int valor)
        {
            if (Formularios.CadastroAtivo.Equals(false))
            {
                Form FM = null;
                switch (valor)
                {
                    case (int)Modulo.Reset:
                        MessageBox.Show("Escolha um Modulo primeiro", "SIM.Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case (int)Modulo.MLG:
                        FM = FactoryMDs.MLGIncluir();
                        goto default;

                    case (int)Modulo.MCC:
                        FM = FactoryMDs.MCCIncluir();
                        goto default;

                    case (int)Modulo.MPO:
                        FM = FactoryMDs.MPOIncluir();
                        goto default;

                    default:
                        FM.Text = "SIM.Desktop.Incluir";
                        FM.Show(form);
                        handleINC = FM.Handle;
                        Formularios.CadastroAtivo = true;
                        break;
                }
            }
            else
            {
                Formularios.EmFoco(handleINC);
            }
        }

        private static IntPtr handleEDT;
        public static void MDsEditar(Form form, int valor)
        {
            if (Formularios.EdicaoAtiva.Equals(false))
            {
                Form FM = null;
                switch (valor)
                {
                    case (int)Modulo.Reset:
                        MessageBox.Show("Escolha um Modulo primeiro", "SIM.Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case (int)Modulo.MLG:
                        FM = FactoryMDs.MLGEditar();
                        goto default;

                    case (int)Modulo.MCC:
                        FM = FactoryMDs.MCCEditar();
                        goto default;

                    case (int)Modulo.MPO:
                        FM = FactoryMDs.MPOConsultar();
                        goto default;

                    default:
                        FM.Text = "SIM.Desktop.Gerenciar";
                        FM.Show(form);
                        handleEDT = FM.Handle;
                        Formularios.EdicaoAtiva = true;
                        break;
                }
            }
            else
            {
                Formularios.EmFoco(handleEDT);
            }
        }

        private static IntPtr handleSCH;
        public static void MDsConsultar(Form form, int valor)
        {
            if (Formularios.ConsultaAtiva.Equals(false))
            {
                Form FM = null;
                switch (valor)
                {
                    case (int)Modulo.Reset:
                        MessageBox.Show("Escolha um Modulo primeiro", "SIM.Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                        
                    case (int)Modulo.MLG:
                        FM = FactoryMDs.MLGConsultar();
                        goto default;
                        
                    case (int)Modulo.MCC:
                        FM = FactoryMDs.MCCConsultar();
                        goto default;
                        
                    case (int)Modulo.MPO:
                        FM = FactoryMDs.MPOConsultar();
                        goto default;

                    default:
                        FM.Text = "SIM.Desktop.Consultar";
                        FM.Show(form);
                        handleSCH = FM.Handle;
                        Formularios.ConsultaAtiva = true;
                        break;
                }
            }
            else
            {
                Formularios.EmFoco(handleSCH);
            }
        }

        private static IntPtr handleREL;
        public static void MDsRelatorio(Form form, int valor)
        {
            if (Formularios.RelAtivo.Equals(false))
            {
                Form FM = null;
                switch (valor)
                {
                    case (int)Modulo.Reset:
                        MessageBox.Show("Escolha um Modulo primeiro", "SIM.Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case (int)Modulo.MLG:
                        FM = FactoryMDs.MLGRelatorio();
                        goto default;

                    case (int)Modulo.MCC:
                        FM = FactoryMDs.MCCRelatorios();
                        goto default;

                    case (int)Modulo.MPO:
                        FM = FactoryMDs.MPORelatorios();
                        goto default;

                    default:
                        FM.Text = "SIM.Desktop.Consultar";
                        FM.Show(form);
                        handleREL = FM.Handle;
                        Formularios.RelAtivo = true;
                        break;
                }
            }
            else
            {
                Formularios.EmFoco(handleREL);
            }
        }
   
    }

    public class FactoryMDs
    {
        public static Form MLGIncluir()
        {
            return new Sim.Legislacao.Visao.FmIncluir();
        }

        public static Form MLGEditar()
        {
            return new Sim.Legislacao.Visao.FmEdicao();
        }

        public static Form MLGConsultar()
        {
            return new Sim.Legislacao.Visao.FmConsulta();
        }

        public static Form MLGRelatorio()
        {
            return new Sim.Legislacao.Visao.FmRelatorio();
        }

        // ************* Portarias *****************

        public static Form MPOIncluir()
        {
            return new Sim.Portarias.Visao.FmIncluir();
        }

        public static Form MPOEditar()
        {
            return new Sim.Portarias.Visao.FmEditar();
        }

        public static Form MPOConsultar()
        {
            return new Sim.Portarias.Visao.FmConsultar();
        }

        public static Form MPORelatorios()
        { return new Sim.Portarias.Visao.FmRel(); }

        //************** Contratos *****************
        public static Form MCCIncluir()
        {
            return new Sim.Contratos.Visao.FmIncluir();
        }

        public static Form MCCEditar()
        {
            return new Sim.Contratos.Visao.FmEditar();
        }

        public static Form MCCConsultar()
        {
            return new Sim.Contratos.Visao.FmConsultar();
        }

        public static Form MCCRelatorios()
        {
            return new Sim.Contratos.Visao.FmConsultar();
        }

    }

}
