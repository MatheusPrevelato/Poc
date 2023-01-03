namespace Poc1.Entidades
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Atividade() { }
        
        public Atividade(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
