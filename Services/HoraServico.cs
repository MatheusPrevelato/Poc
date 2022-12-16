using Poc1.Models;
using System.Collections.Generic;

namespace Poc1.Services
{
    // Servico que fornece uma lista de horas
    public class HoraServico
    {
        public static List<HoraModel> GetHora()
        {
            var listaHoras = new List<HoraModel>()
            {
                new HoraModel(){Id=1, Quantidade = "01:00"},
                new HoraModel(){Id=2, Quantidade = "02:00"},
                new HoraModel(){Id=3, Quantidade = "03:00"},
                new HoraModel(){Id=4, Quantidade = "04:00"},
                new HoraModel(){Id=5, Quantidade = "05:00"},
                new HoraModel(){Id=6, Quantidade = "06:00"},
                new HoraModel(){Id=7, Quantidade = "07:00"},
                new HoraModel(){Id=8, Quantidade = "08:00"}
            };
            return listaHoras;
        }
    }
}
