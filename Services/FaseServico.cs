using Poc1.Entidades;
using Poc1.Repositories;
using Poc1.Repositories.Interfaces;
using System.Collections.Generic;

namespace Poc1.Services
{
    // Servico que fornece uma lista de fases
    public class FaseServico
    {
        private readonly IFaseRepositorio _repositorio;

        public FaseServico(IFaseRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Fase> BuscarFases()
        {
            return _repositorio.BuscarFases();
        }
    }
}
