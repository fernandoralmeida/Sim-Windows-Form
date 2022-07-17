using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sim.Legislacao.RegraN
{
    public class Legislacao : ILegislacao // Business Logic Layer Legislação // implementando Interface ILegislação
    {

        Sim.Data.IDataAccess LegislacaoAccess = Sim.Data.Factory.ModuloAccess();

        public DataTable Consulta(ELegislacao obj)
        {
            try
            {
                LegislacaoAccess.ReiniciarParametros();

                LegislacaoAccess.AdicionarParametros("@Tipo", obj.Tipo);
                LegislacaoAccess.AdicionarParametros("@N1", obj.Numero);
                LegislacaoAccess.AdicionarParametros("@N2", obj.NumeroFinal);
                LegislacaoAccess.AdicionarParametros("@Data1", obj.Data);
                LegislacaoAccess.AdicionarParametros("@Data2", obj.DataFinal);
                LegislacaoAccess.AdicionarParametros("@Resumo", obj.Decricao);
                LegislacaoAccess.AdicionarParametros("@Classificado", obj.Classificacao);
                LegislacaoAccess.AdicionarParametros("@Situacao", obj.Situacao);
                LegislacaoAccess.AdicionarParametros("@Origem", obj.Origem);
                LegislacaoAccess.AdicionarParametros("@Autor", obj.Autor);

               return LegislacaoAccess.Reader(Properties.Resources.SelectByParam);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Edicao(ELegislacao obj)
        {
            throw new NotImplementedException();
        }

        public string LinkURL(ELegislacao obj)
        {
            throw new NotImplementedException();
        }

        public bool InsertData(ELegislacao obj)
        {
            throw new NotImplementedException();
        }

        public void UpDateData(ELegislacao obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(ELegislacao obj)
        {
            throw new NotImplementedException();
        }

        public void UpDateSituacao(ELegislacao obj)
        {
            throw new NotImplementedException();
        }

        public int Registros()
        {
            throw new NotImplementedException();
        }

        public string SituacaoToString(string valor)
        {
            throw new NotImplementedException();
        }

        public string AtualizaSituacao(string valor)
        {
            throw new NotImplementedException();
        }

        public string TipoURL(string valor)
        {
            throw new NotImplementedException();
        }

        public string Ano(string data)
        {
            throw new NotImplementedException();
        }

        public DataTable AllData()
        {
            try
            {
                LegislacaoAccess.ReiniciarParametros();
                return LegislacaoAccess.Reader(Properties.Resources.SelectAllData);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Consulta(Legislacao obj)
        {
            throw new NotImplementedException();
        }

        public DataTable Edicao(Legislacao obj)
        {
            throw new NotImplementedException();
        }

        public string LinkURL(Legislacao obj)
        {
            throw new NotImplementedException();
        }

        public bool InsertData(Legislacao obj)
        {
            throw new NotImplementedException();
        }

        public void UpDateData(Legislacao obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Legislacao obj)
        {
            throw new NotImplementedException();
        }

        public void UpDateSituacao(Legislacao obj)
        {
            throw new NotImplementedException();
        }
    }
}
