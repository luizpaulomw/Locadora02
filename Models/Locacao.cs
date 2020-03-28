using System;
using System.Collections.Generic;
using Controllers;
using Repositories;

namespace Models
{
    public class LocacaoModels
    {
        public int IdLocacao { get; set; }
        public ClienteModels Cliente { get; set; }
        public DateTime DtLocacao { get; set; }

        public List<FilmeModels> filmes = new List<FilmeModels>();

        public LocacaoModels(ClienteModels cliente, DateTime dtLocacao)
        {
            IdLocacao = LocacaoRepositories.GetId();
            Cliente = cliente;
            DtLocacao = dtLocacao;
            cliente.InserirLocacao(this);

            LocacaoRepositories.AdicionarLocacao(this);
        }

        public LocacaoModels(int idLocacao, ClienteModels cliente)
        {
            IdLocacao = idLocacao;
            Cliente = cliente;
        }

        public void AdicionarFilme(FilmeModels filme)
        {
            filmes.Add(filme);
        }

        public void InserirFilme(FilmeModels filme)
        {
            filmes.Add(filme);
        }


        public override string ToString()
        {
            string retorno = $"Cliente: {Cliente.Nome}" +
                $"Preço Total das Locações: {LocacaoController.GetValorTotal(filmes)}" +
                $"Data da Locacao: {DtLocacao}" +
                $"Data de Devolucao: {LocacaoController.GetDataDevolucao(this)}" +
                "   Filmes:\n";

            if (filmes.Count > 0)
            {
                filmes.ForEach(
                    filme => retorno += $"    Id: {filme.IdFilme} - " +
                    $"Nome: {filme.Titulo}\n"
                );
            }
            else
            {
                retorno += "    Não há filmes";
            }

            return retorno;
        }


        public static LocacaoModels GetLocacao(int idLocacao)
        {
            return LocacaoRepositories.Locacoes().Find(locacao => locacao.IdLocacao == idLocacao);
        }

        public static List<LocacaoModels> GetLocacao()
        {
            return LocacaoRepositories.Locacoes();
        }

    }
}