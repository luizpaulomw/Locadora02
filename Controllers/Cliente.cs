using System;
using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class ClienteController
    {
        public static void CadastraCliente(int IdCliente, string nome, string DtNasc, string cpf, int DiasDevol)
        {
            DateTime Data_Nascimento;
            try
            {
                Data_Nascimento = Convert.ToDateTime(DtNasc);
            }
            catch
            {
                Console.WriteLine("Formato inválido de data, será utilizada a data atual pra cadastro");
                Data_Nascimento = DateTime.Now;
            }

            new ClienteModels (IdCliente, nome, Data_Nascimento, cpf, DiasDevol);
        }

        internal static void InserirCliente(string nome, string sDtNasc, string cpf, int qtdDias)
        {
            throw new NotImplementedException();
        }

        public static int GetQtdFilmes(ClienteModels cliente)
        {
            int qtdFilmes = 0;

            cliente.Locacoes.ForEach(
                locacao => qtdFilmes += locacao.filmes.Count
            );

            return qtdFilmes;
        }

        public static ClienteModels GetCliente(int idCliente)
        {
            return ClienteModels.GetCliente(idCliente);
        }

        public static List<ClienteModels> GetClientes()
        {
            return ClienteModels.GetClientes();
        }

        public static void Importar()
        {
            ClienteModels.Importar();
        }
    }
}