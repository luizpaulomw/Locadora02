using System;
using View;

namespace csharp_mvc_blockbuster
{
    class Program
    {
     
        static void Main (string[] args) {
            Console.WriteLine ();
            int opt = 0;
            do {
             
             
                Console.WriteLine ("| Digite a opção desejada |");
                Console.WriteLine ("| 1 - Cadastrar Cliente   |");
                Console.WriteLine ("| 2 - Cadastrar Filme     |");
                Console.WriteLine ("| 3 - Cadastrar Locação   |");
                Console.WriteLine ("| 4 - Consultar Cliente   |");
                Console.WriteLine ("| 5 - Consultar Filme     |");
                Console.WriteLine ("| 6 - Consultar Locação   |");
                Console.WriteLine ("| 0 - Sair                |");
               

                try {
                    opt = Convert.ToInt32 (Console.ReadLine ());
                } catch {
                    Console.WriteLine ("Opção inválida");
                    opt = 150;
                }

         
                switch (opt) {
                    case 1:
                        ClienteView.InserirCliente ();
                        break;
                    case 2:
                        FilmeView.InserirFilme ();
                        break;
                    case 3:
                        LocacaoView.InserirLocacao ();
                        break;
                
                    case 4:
                        ClienteView.ConsultarCliente ();
                        break;
                
                    case 5:
                        FilmeView.ConsultarFilme ();
                        break;
                    case 6:
                        LocacaoView.ConsultarLocacao ();
                        break;
                  
                }
            } while (opt != 0);

        }
    }
}
