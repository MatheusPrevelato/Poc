using System.ComponentModel.DataAnnotations;
using System;

namespace Poc1.Models
{
    public class ApontamentoModel
    {
        //[Key]
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public string Stream { get; set; }
        public string Atividade { get; set; }
        public string Fase { get; set; }
        public int Horas { get; set; }
        public string Observacoes { get; set; }

    }
}
