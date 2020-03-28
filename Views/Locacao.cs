using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace View
{
    public class LocacaoView
    {
        public static void InserirLocacao()
        {
            List<ClienteModels> clientes = ClienteController.GetClientes();
            List<FilmeModels> filmes = FilmeController.GetFilmes();


            int idCliente = 0;

            Console.WriteLine("\nDigite o ID Cliente:");
            idCliente = Convert.ToInt32(Console.ReadLine());

            if (idCliente <= 5)
            {
                ClienteModels cliente = clientes.Find(cliente => cliente.IdCliente == idCliente);

                LocacaoModels locacao = LocacaoController.addLocacao(1, cliente);

                int idFilme = 0;

                // Eqto IdFilme não for ZERO continua adicionando Locação                           
                do
                {
                    Console.WriteLine("\nDigite o ID Filme: ");
                    Console.WriteLine("DIGITE ZERO (0) P/ FINALIZAR!");
                    idFilme = Convert.ToInt32(Console.ReadLine());

                    if (idFilme != 0)
                    {
                        FilmeModels filme = filmes.Find(filme => filme.IdFilme == idFilme);

                        locacao.AdicionarFilme(filme);
                    }
                } while (idFilme != 0);
            }
        }

        public static void ConsultarLocacao()
        {
            Console.WriteLine("Digite o ID da Locação: ");
            int idLocacao = Convert.ToInt32(Console.ReadLine());

            IEnumerable query =
            from locacao in LocacaoController.GetLocacao()
            where locacao.IdLocacao == idLocacao
            select locacao.ToString();

            foreach (string locacoes in query)
            {
                Console.WriteLine(locacoes.ToString());
            }
        }
    }
}