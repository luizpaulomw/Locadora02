using System;
using Controllers;
using Repositories;
using System.Collections.Generic;

namespace Models
{
    public class FilmeModels
    {
    // Atributos
        public int IdFilme { get; set; }
        public String Titulo { get; set; }
        public string DataLancamento { get; set; }
        public string Sinopse { get; set; }
        public double ValorLocacaoFilme { get; set; }
        public int EstoqueFilme { get; set; }
        public int FilmeLocado { get; set; }

        public List<LocacaoModels> locacaos = new List<LocacaoModels>();

        // Construtor
        public FilmeModels (int idFilme, string titulo, string dataLancamento, string sinopse, double valorLocacaoFilme, int estoqueFilme) 
            {
                IdFilme = FilmeRepositories.GetId();
                Titulo = titulo;
                DataLancamento = dataLancamento;
                Sinopse = sinopse;
                ValorLocacaoFilme = valorLocacaoFilme;
                EstoqueFilme = estoqueFilme;
                FilmeLocado = 0;

                FilmeRepositories.filmes.Add(this);
            }

        // Retorno do Filme pelo ID
        public static FilmeModels GetFilme(int idFilme)
            {
                return FilmeRepositories.Filmes().Find (filme => filme.IdFilme == idFilme);
            }


    }
}