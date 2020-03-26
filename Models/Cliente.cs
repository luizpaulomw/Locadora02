using System;
using System.Collections.Generic;
using Repositories;
using Controllers;

namespace Models {
    public class Cliente {
       
 
        public int IdCliente { get; set; }
        
        public string Nome { get; set; }
 
        public DateTime DtNasc { get; set; }
  
        public string Cpf { get; set; }
       
        public int Dias { get; set; }
      
        public List<Locacao> Locacoes { get; set; }

        
        public Cliente (string nome, DateTime dtNasc, string cpf, int dias) {
            IdCliente = RepositoryCliente.GetId();
            Nome = nome;
            DtNasc = dtNasc;
            Cpf = cpf;
            Dias = dias;
            Locacoes = new List<Locacao> ();

            RepositoryCliente.AddCliente(this);
        }
        
        
       
        public void InserirLocacao (Locacao locacao) {
            Locacoes.Add (locacao);
        }

        
        public static Cliente GetCliente(int idCliente){
            return RepositoryCliente.Clientes().Find (cliente => cliente.IdCliente == idCliente);
        }

   
        public static List<Cliente> GetClientes(){
            return RepositoryCliente.Clientes();
        }

       
        public string ToString (bool simple = false) {
            if (simple) {
                string retorno = $"Id: {IdCliente} - Nome: {Nome}\n" +
                    "   Locações: \n";
                if (Locacoes.Count > 0) {
                    Locacoes.ForEach (
                        locacao => retorno += $"    Id: {locacao.IdLocacao} - " +
                        $"Data: {locacao.DtLocacao} - " +
                        $"Data de Devolução: {LocacaoController.GetDataDevolucao(locacao)}\n"
                    );
                } else {
                    retorno += "    Não há locações";
                }

                return retorno;
            }

            string dtNasc = this.DtNasc.ToString("dd/MM/yyyy");

            return $"Nome: {Nome}\n" +
                $"Data de Nasciment: {dtNasc}\n" +
                $"Qtd de Filmes: {ClienteController.GetQtdFilmes(this)}";
        }

    
        public static void Importar(){
            Cliente cliente;
            Locacao locacao;

            cliente = new Cliente (
                "Pedro Pereira",
                new DateTime (1953, 5, 4),
                "987.546.254.11",
                6
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now.AddDays (-5)
            );
            locacao.InserirFilme (Filme.GetFilme(1));
            locacao.InserirFilme (Filme.GetFilme(3));
            
            cliente = new Cliente (
                "Eduarda Santos ",
                new DateTime (1988, 1, 2),
                "889.578.542.21",
                8
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now.AddDays (-8)
            );
            locacao.InserirFilme (Filme.GetFilme(5));
            locacao.InserirFilme (Filme.GetFilme(8));
            
            cliente = new Cliente (
                " Joana Aparecida",
                new DateTime (1985, 12, 7),
                "897.412.547.88",
                2
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now.AddDays (-10)
            );
            locacao.InserirFilme (Filme.GetFilme(2));
            
            cliente = new Cliente (
                "Carol Araújo",
                new DateTime (1985, 07, 25),
                "698.458.741.20",
                5
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now.AddDays (-20)
            );
            locacao.InserirFilme (Filme.GetFilme(4));
            locacao.InserirFilme (Filme.GetFilme(9));

            locacao = new Locacao (
                cliente,
                DateTime.Now
            );
            locacao.InserirFilme (Filme.GetFilme(1));
            
            cliente = new Cliente (
                "Diana medeiros ",
                new DateTime (1856, 05, 4),
                "568.487.956.25",
                15
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now
            );
            locacao.InserirFilme (Filme.GetFilme(6));
            locacao.InserirFilme (Filme.GetFilme(7));
            locacao.InserirFilme (Filme.GetFilme(8));
        }

    }
}