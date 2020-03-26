using System;
using Models;
using System.Collections.Generic;

namespace Controllers {
    public class ClienteController { 

      
        public static void CadastraCliente(
            string nome,
            string DtNasc,
            string cpf,
            int Dias
        ) {
            DateTime Data_Nascimento;
            try {
                Data_Nascimento = Convert.ToDateTime (DtNasc);
            } catch {
                Console.WriteLine ("Formato inválido de data, será utilizada a data atual pra cadastro");
                Data_Nascimento = DateTime.Now;
            }

            new Cliente (
                nome,
                Data_Nascimento,
                cpf,
                Dias
            );

        }

        internal static void InserirCliente(string nome, string sDtNasc, string cpf, int qtdDias)
        {
            throw new NotImplementedException();
        }

        public static int GetQtdFilmes (Cliente cliente) {
            int qtdFilmes = 0;

            cliente.Locacoes.ForEach (
                locacao => qtdFilmes += locacao.Filmes.Count
            );

            return qtdFilmes;
        }

     
        public static Cliente GetCliente (int idCliente){
            return Cliente.GetCliente(idCliente);
        }

      
        public static List<Cliente> GetClientes (){
            return Cliente.GetClientes();
        }

      
        public static void Importar () {
            Cliente.Importar();
        }
    }
}