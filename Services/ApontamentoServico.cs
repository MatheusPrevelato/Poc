using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Poc1.Entidades;
using Poc1.Repositories;
using Poc1.Repositories.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace Poc1.Services
{
    public class ApontamentoServico
    {
        public readonly IApontamentoRepositorio _repositorio;

        public ApontamentoServico(IApontamentoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(Apontamento apontamento)
        {
            _repositorio.Adicionar(apontamento);
        }

        public IEnumerable<Apontamento> Buscar(int id)
        {
            return _repositorio.BuscarPorId(id);
        }
    }
}
