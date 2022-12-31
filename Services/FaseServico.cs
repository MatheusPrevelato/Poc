using Poc1.Entidades;
using Poc1.Repositories;
using System.Collections.Generic;

namespace Poc1.Services
{
    // Servico que fornece uma lista de fases
    public class FaseServico
    {
        private readonly FaseRepositorio _repositorio;

        public FaseServico(FaseRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
