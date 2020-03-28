using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class FilmeRepositories {
        public static readonly List<FilmeModels> filmes = new List<FilmeModels>();

        public static List<FilmeModels> FilmesModels(){
            return filmes;
        }

        public static void AddFilme(FilmeModels Filme){
            filmes.Add(Filme);
        }

        public static int GetId(){
            return filmes.Count + 1;
        }

        public static List<FilmeModels> Filmes()
        {
            return filmes;
        }
    }
}