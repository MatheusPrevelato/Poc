namespace Poc1.Models
{
    public class FaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // Relacao entre as tabelas Fases e Apontamentos (1 para 1)
        public ApontamentoModel Apontamento { get; set; }
    }
}
