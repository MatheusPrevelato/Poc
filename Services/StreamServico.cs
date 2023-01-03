using Poc1.Entidades;
using Poc1.Repositories;
using Poc1.Repositories.Interfaces;
using System.Collections.Generic;

namespace Poc1.Services
{
    // Serviço que fornece uma Lista de Streams com Id e Nome
    public class StreamServico
    {
        private readonly IStreamRepositorio _repositorio;

        public StreamServico(IStreamRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Stream> BuscarStreams()
        {
            return _repositorio.BuscarStreams();
        }
    }
}
