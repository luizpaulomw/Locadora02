using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class ClienteRepositories {
        public static readonly List<ClienteModels> clientes = new List<ClienteModels>();

        public static List<ClienteModels> Clientes(){
            return clientes;
        }

        public static void AddCliente(ClienteModels cliente){
            clientes.Add(cliente);
        }

        public static int GetId(){
            return clientes.Count + 1;
        }
    }
}