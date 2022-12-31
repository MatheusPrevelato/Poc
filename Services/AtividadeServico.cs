using Microsoft.CodeAnalysis.CSharp.Syntax;
using Poc1.Models;
using Poc1.Repositories;
using System.Collections.Generic;

namespace Poc1.Services
{
    public class AtividadeServico
    {
        public readonly AtividadeRepositorio _repositorio;

        public AtividadeServico(AtividadeRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
