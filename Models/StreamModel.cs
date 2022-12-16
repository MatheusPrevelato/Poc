using System.Collections.Generic;

namespace Poc1.Models
{
    public class StreamModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // relação entre as tabelas Streams e Atividades (1 para muitos)
        public List<AtividadeModel> Atividades { get; set; }

        // relação entre as tabelas Streams e Apontamentos (1 para 1)
        public ApontamentoModel Apontamento { get; set; }
    }
}
