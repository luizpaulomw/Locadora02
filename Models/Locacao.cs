using System;
using System.Collections.Generic;
using System.Linq;
using Controllers;
using Repositories;

namespace Models {
    public class LocacaoModels {
      
        public int IdLocacao { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DtLocacao { get; set; }
        public List<FilmeModels> Filmes { get; set; }

        public Locacao (Cliente cliente, DateTime dtLocacao) {
            IdLocacao = RepositoryLocacao.GetId();
            Cliente = cliente;
            DtLocacao = dtLocacao;
            Filmes = new List<FilmeModels> ();
            cliente.InserirLocacao (this);

            RepositoryLocacao.AddLocacao (this);
        }

                public void InserirFilme (FilmeModels filme) {
            Filmes.Add (filme);
            filme.SetarLocacao (this);
        }

       
        public override string ToString () {
            string valor = LocacaoController.GetValorTotal(this).ToString("C2");
            string retorno = $"Cliente: {Cliente.Nome}" +
                $"Data da Locacao: {DtLocacao}" +
                $"Valor: {valor}\n" +
                $"Data de Devolucao: {LocacaoController.GetDataDevolucao(this)}" +
                "   Filmes:\n";

            if (Filmes.Count > 0) {
                Filmes.ForEach (
                    filme => retorno += $"    Id: {filme.IdFilme} - " +
                    $"Nome: {filme.NomeFilme}\n"
                );
            } else {
                retorno += "    Não há filmes";
            }

            return retorno;
        }

       
        public static LocacaoModels GetLocacao(int idLocacao){
            return RepositoryLocacao.Locacoes().Find (locacao => locacao.IdLocacao == idLocacao);
        }

    }
}