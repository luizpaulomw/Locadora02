
using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;

namespace View {
    public class LocacaoView {
    
        public static void InserirLocacao () {
            Console.WriteLine ("Informações sobre a locação: ");
            Cliente cliente;
            FilmeView filme;

           
            do {
                Console.WriteLine ("Informe o id do cliente: ");
                int idCliente = Convert.ToInt32 (Console.ReadLine ());
                cliente = null;

        
                try {
                    cliente = ClienteController.GetCliente(idCliente);
                    if (cliente == null) {
                        Console.WriteLine ("Cliente não localizado, favor digitar outro id.");
                    }
                } catch {
                    Console.WriteLine ("Cliente não localizado, favor digitar outro id.");
                }

            } while (cliente == null);

           
            LocacaoView locacao = LocacaoController.InserirLocacao(cliente);

           
            int filmOpt = 0;
            do {
                Console.WriteLine ("Informe o id do filme alugado: ");
                int idFilme = Convert.ToInt32 (Console.ReadLine ());
                filme = null; 

            
                try {
                    filme = FilmeController.GetFilme(idFilme);
                    if (filme == null) { 
                        Console.WriteLine ("Filme não localizado, favor digitar outro id.");
                    }
                } catch {
                    Console.WriteLine ("Filme não localizado, favor digitar outro id.");
                }

                if (filme != null) {
                    
                    LocacaoController.InserirFilme (LocacaoModels,);
                    Console.WriteLine ("Deseja informar outro filme? " +
                        "Informar 1 para Não ou qualquer outro valor para Sim.");
                    filmOpt = Convert.ToInt32 (Console.ReadLine ());
                }
            } while (filmOpt != 1);
        }

   
        public static void ConsultarLocacao () {
            LocacaoView locacao;

            do {
                Console.WriteLine ("Informe a locacao que deseja consultar: ");
                int idLocacao = Convert.ToInt32 (Console.ReadLine ());
                locacao = null;

                try {
                    locacao = LocacaoController.GetLocacao(idLocacao);
                    if (locacao == null) { 
                        Console.WriteLine ("Locação não localizada, favor digitar outro id.");
                    }
                } catch {
                    Console.WriteLine ("Locação não localizada, favor digitar outro id.");
                }
            } while (locacao == null);
            Console.WriteLine (locacao.ToString ());
        }
    }
}