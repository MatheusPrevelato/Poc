using Poc1.Entidades;
using Poc1.Repositories;
using System.Collections.Generic;

namespace Poc1.Services
{
    // Serviço que fornece uma Lista de Streams com Id e Nome
    public class StreamServico
    {
        private readonly StreamRepositorio _repositorio;

        public StreamServico(StreamRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
