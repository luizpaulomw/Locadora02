using Models;
using System;
using System.Collections.Generic;
using View;

namespace Controllers
{
    public class FilmeController
    {
        public static void addFilme(int idFilme, string titulo, string dataLanc, string sinopse, double valorLoc, int estoque)  
            {
                new FilmeModels(idFilme, titulo, dataLanc, sinopse, valorLoc, estoque);
            }

    public string GetFilme(FilmeModels filme)
        {
            string filmeValue = filme.ToString();

            return filmeValue;
        }

        public static List<FilmeModels> GetFilmes()
			{
				return FilmeModels.GetFilmes();
			}

        internal static void InserirFilme(string nome, string data_Lancamento, double valor)
        {
            throw new NotImplementedException();
        }

        internal static FilmeView GetFilme(int idFilme)
        {
            throw new NotImplementedException();
        }
    }
}