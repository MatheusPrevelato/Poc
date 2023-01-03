using Poc1.Entidades;
using System.Collections.Generic;

namespace Poc1.Repositories.Interfaces
{
    public interface IApontamentoRepositorio
    {
        void Adicionar(Apontamento apontamento);

        IEnumerable<Apontamento> BuscarPorId(int id);
    }
}
