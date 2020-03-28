using System;
using Models;
using System.Collections.Generic;
using View;

namespace Controllers
{
    public class LocacaoController
    {
        public static LocacaoModels InserirLocacao(ClienteModels cliente)
        {
            return new LocacaoModels (cliente, DateTime.Now);
        }

        public static void InserirFilme(  LocacaoModels locacao, FilmeModels filme)
        {
            locacao.InserirFilme(filme);
        }

        public static double GetValorTotal(List<FilmeModels> filmes)
        {
            double ValorTotal = 0;

            foreach (FilmeModels filme in filmes)
            {
                ValorTotal += filme.ValorLocacaoFilme;
            }

            return Math.Round(ValorTotal, 2);
        }

        public static double GetQtdFilmes(LocacaoModels locacao)
        {
            return locacao.filmes.Count;
        }

        public static string GetDataDevolucao(DateTime Data)
        {
            //Data.AddDays(ClienteModels.Dias);
            return Data.ToString().Substring(0, 10);
        }

        public static List<LocacaoModels> GetLocacao()
        {
            return LocacaoModels.GetLocacao();
        }

        internal static LocacaoView InserirLocacao(ClienteView cliente)
        {
            throw new NotImplementedException();
        }

        public static LocacaoModels GetLocacao(int idLocacao)
        {
            return LocacaoModels.GetLocacao(idLocacao);
        }

        internal static object GetDataDevolucao(LocacaoModels locacao)
        {
            throw new NotImplementedException();
        }

        internal static void InserirFilme(LocacaoView locacao)
        {
            throw new NotImplementedException();
        }

        public static LocacaoModels addLocacao(int idLocacao, ClienteModels cliente)
        {
            return new LocacaoModels(idLocacao, cliente);
        }
    }
}