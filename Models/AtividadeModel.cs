namespace Poc1.Models
{
    public class AtividadeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // relacionamento entre Atividade e Stream
        public StreamModel Stream { get; set; }
    }
}
