using Poc1.Data;

namespace Poc1.Repositories
{
    public class FaseRepositorio
    {
        private readonly Conexao _conexao;

        public FaseRepositorio(Conexao conexao)
        {
            _conexao = conexao;
        }
    }
}
