using Poc1.Entidades;
using System.Collections.Generic;

namespace Poc1.Repositories.Interfaces
{
    public interface IAtividadeRepositorio
    {
        public List<Atividade> BuscarAtividades();
    }
}
