using Poc1.Models;
using System.Collections.Generic;

namespace Poc1.Services
{
    // Serviço que fornece uma Lista de Streams com Id e Nome
    public class StreamServico
    {
        public static List<StreamModel> GetStream()
        {
            var listaStreams = new List<StreamModel>()
            {
                new StreamModel(){Id=1, Nome="ABSENCE"},
                new StreamModel(){Id=2, Nome="APPS"},
                new StreamModel(){Id=3, Nome="BI"}
            };
            return listaStreams;
        }
    }
}
