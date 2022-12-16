using Microsoft.CodeAnalysis.CSharp.Syntax;
using Poc1.Models;
using System.Collections.Generic;

namespace Poc1.Services
{
    // Servico que fornece uma Lista de Atividades com Id e Nome
    public class AtividadeServico
    {
        public static List<AtividadeModel> GetAtividade()
        {
            var listaAtividades = new List<AtividadeModel>()
            {
                new AtividadeModel(){Id=1, Nome = "Biomarcadores"},
                new AtividadeModel(){Id=2, Nome = "eVendor"},
                new AtividadeModel(){Id=3, Nome = "Team Mgm System-Module Vacation"},
                new AtividadeModel(){Id=4, Nome = "Apps Training"},
                new AtividadeModel(){Id=5, Nome = "AWS PHASE 2"},
                new AtividadeModel(){Id=6, Nome = "DASO"},
                new AtividadeModel(){Id=7, Nome = "Engagement"},
                new AtividadeModel(){Id=8, Nome = "BI Training"}
            };
            return listaAtividades;
        }
    }
}
