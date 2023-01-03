using System.Collections.Generic;

namespace Poc1.Entidades
{
    public class Stream
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int AtividadeId { get; set; }

        public Stream()
        {

        }

        public Stream(int id, string nome, int atividadeId)
        {
            Id = id;
            Nome = nome;
            AtividadeId = atividadeId;
        }
    }
}
