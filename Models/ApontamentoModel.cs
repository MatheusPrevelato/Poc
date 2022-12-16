using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Poc1.Models
{
    public class ApontamentoModel
    {
        //[Key]
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public int StreamId { get; set; }
        // relacionamento entre as tabelas Apontamentos e Streams (1 para muitos)
        public List<StreamModel> Streams { get; set; }
        
        public int AtividadeId { get; set; }
        
        public string FaseId { get; set; }
        // relacionamento entre as tabelas Apontamentos e Fases (1 para muitos)
        public List<FaseModel> Fases { get; set; }
        public int Horas { get; set; }
        public string Observacoes { get; set; }

    }
}
