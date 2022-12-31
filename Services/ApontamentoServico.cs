using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Poc1.Entidades;
using Poc1.Repositories;

namespace Poc1.Services
{
    public class ApontamentoServico
    {
        public readonly ApontamentoRepositorio _repositorio;

        public ApontamentoServico(ApontamentoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Apontamento Adicionar(Apontamento apontamento)
        {
            return apontamento;
        }
    }
}
