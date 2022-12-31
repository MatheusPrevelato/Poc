using Poc1.Data;

namespace Poc1.Repositories
{
    public class AtividadeRepositorio
    {
        private readonly Conexao _conexao;

        public AtividadeRepositorio(Conexao conexao)
        {
            _conexao = conexao;
        }
    }
}
