using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;

namespace View
{
    public class FilmeView
    {
        public static void InserirFilme()
        {
            Console.WriteLine(" sobre o filme: ");
            Console.WriteLine(" titulo: ");
            String titulo = Console.ReadLine();
            Console.WriteLine(" data de lançamento (dd/mm/yyyy): ");
            String dataLanc = Console.ReadLine();
            Console.WriteLine(" sinopse: ");
            String sinopse = Console.ReadLine();
            Console.WriteLine(" valor do filme: ");
            double valorLoc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" estoque: ");
            int estoque = Convert.ToInt32(Console.ReadLine());

            FilmeController.InserirFilme(titulo, dataLanc, sinopse, valorLoc);
        }

        public void getFilme(FilmeModels filmes)
        {
            Console.Write(filmes);
        }

        public static void ListarFilmes()
        {
            Console.WriteLine("    Filmes  ");
            FilmeController.GetFilmes().ForEach(filme => Console.WriteLine(filme));
        }

        // Consulta por LinQ
        public static void ConsultarFilme()
        {
            Console.WriteLine("Digite o ID do Filme: ");
            int idFilme = Convert.ToInt32(Console.ReadLine());

            IEnumerable query =
            from filme in FilmeController.GetFilmes()
            where filme.IdFilme == idFilme
            select filme.ToString();

            foreach (string filmes in query)
            {
                Console.WriteLine(filmes.ToString());
            }
        }
    }
}