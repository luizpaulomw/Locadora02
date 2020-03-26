using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;

namespace View {
    public class ClienteView {
  
        public static void InserirCliente () {
            Console.WriteLine (" sobre o cliente: ");
            Console.WriteLine (" nome: ");
            String nome = Console.ReadLine ();
            Console.WriteLine (" data de nascimento (dd/mm/yyyy): ");
            String sDtNasc = Console.ReadLine ();
            Console.WriteLine ("Informe o C.P.F.: ");
            String cpf = Console.ReadLine ();
            Console.WriteLine (" dias para devolução: ");
            int qtdDias = Convert.ToInt32 (Console.ReadLine ());

            ClienteController.InserirCliente(nome, sDtNasc, cpf, qtdDias);
        }

        public static void ListarClientes () {
            Console.WriteLine ("Lista de Clientes: ");
            ClienteController.GetClientes().ForEach (
                cliente => Console.WriteLine (cliente.ToString (true)));
        }

        
        public static void ListarClientesLINQ(){
            Console.WriteLine("Digite o id de um cliente: ");
            int idCliente = Convert.ToInt32(Console.ReadLine());
            IEnumerable query =
             from cliente in ClienteController.GetClientes()
                where cliente.IdCliente == idCliente
                select cliente.Nome;

                foreach(string cliente in query){
                    Console.WriteLine(cliente);
                }
        }

        public static void ConsultarCliente () {
            Cliente cliente;

          
            do {
                Console.WriteLine ("Informe o cliente que deseja consultar: ");
                int idCliente = Convert.ToInt32 (Console.ReadLine ());
                cliente = null; 

             
                try {
                    cliente = ClienteController.GetCliente(idCliente);
                    if (cliente == null) {
                        Console.WriteLine ("Cliente não localizado .");
                    }
                } catch {
                    Console.WriteLine (" favor digitar outro id.");
                }
            } while (cliente == null);
            Console.WriteLine (cliente.ToString ());
        }

        
        public static void Importar () {
            ClienteController.Importar ();
            Console.WriteLine("CONCLUÍDA COM SUCESSO");
        }
    }
}