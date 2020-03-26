using System;
using Models;

namespace Controllers {
    public class LocacaoController {

       
        public static Locacao InserirLocacao(
            Cliente cliente
        ){
            return new Locacao(cliente, DateTime.Now); 
        }

        
        public static void InserirFilme(
            Locacao locacao,
            Filme filme
        ){
            locacao.InserirFilme(filme);
        }

        
        public static double GetValorTotal (Locacao locacao) {
            double valorTotal = 0;

            locacao.Filmes.ForEach (
                filme => valorTotal += filme.Valor
            );
            return valorTotal;
        }

               public static double GetQtdFilmes (Locacao locacao) {
            return locacao.Filmes.Count;
        }

               public static DateTime GetDataDevolucao (Locacao locacao) {
            return locacao.DtLocacao.AddDays (locacao.Cliente.Dias);
        }

       
        public static Locacao GetLocacao (int idLocacao){
            return Locacao.GetLocacao(idLocacao);
        }
    }
}