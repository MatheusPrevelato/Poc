using Poc1.Data;

namespace Poc1.Repositories
{
    public class StreamRepositorio
    {
        private readonly Conexao _conexao;

        public StreamRepositorio(Conexao conexao)
        {
            _conexao = conexao;
        }
    }
}
