namespace Poc1.Entidades
{
    public class Fase
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Fase() { }

        public Fase(int id, string nome) 
        { 
            Id = id;
            Nome = nome;
        }
    }
}
