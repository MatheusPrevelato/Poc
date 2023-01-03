using Microsoft.CodeAnalysis.CSharp.Syntax;
using Poc1.Entidades;
using Poc1.Models;
using Poc1.Repositories;
using Poc1.Repositories.Interfaces;
using System.Collections.Generic;

namespace Poc1.Services
{
    public class AtividadeServico
    {
        public readonly IAtividadeRepositorio _repositorio;

        public AtividadeServico(IAtividadeRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Atividade> BuscarAtividades()
        {
            return _repositorio.BuscarAtividades();
        }
    }
}
