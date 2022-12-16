using Poc1.Models;
using System.Collections.Generic;

namespace Poc1.Services
{
    // Servico que fornece uma lista de fases
    public class FaseServico
    {
        public static List<FaseModel> GetFase()
        {
            var listaFases = new List<FaseModel>()
            {
                new FaseModel(){Id=1, Nome = "To do"},
                new FaseModel(){Id=2, Nome = "Doing"},
                new FaseModel(){Id=3, Nome = "Done"}
            };
            return listaFases;
        }
    }
}
