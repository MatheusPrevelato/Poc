using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Poc1.Entidades;

namespace Poc1.Entidades
{
    public class Apontamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int StreamId { get; set; }
        
        public Stream Stream { get; set; }

        public int AtividadeId { get; set; }
        public Atividade Atividade { get; set; }

        public int FaseId { get; set; }
        public Fase Fase { get; set; }
        public int Horas { get; set; }
        public string Observacoes { get; set; }

        public Apontamento apontamento { get; set; }

    }
}
