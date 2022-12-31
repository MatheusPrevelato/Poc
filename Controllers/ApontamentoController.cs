using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using Poc1.Data;
using Poc1.Entidades;
using Poc1.Repositories;
using Poc1.Services;
using System;
using System.Linq;

namespace Poc1.Controllers
{
    public class ApontamentoController : Controller
    {
        private readonly ApontamentoServico _apontamentoServico;

        public ApontamentoController (ApontamentoServico apontamentoServico)
        {
            _apontamentoServico = apontamentoServico;
        }
        public IActionResult Index()
        {   
            return View();
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return null;
        }

        [HttpPost]
        public IActionResult Adicionar(Apontamento apontamento)
        {         
            try
            {
                _apontamentoServico.Adicionar(apontamento);
                TempData["MensagemSucesso"] = "Apontamento realizado com sucesso";
                return RedirectToAction("Adicionar");
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Não foi possível realizar o apontamento. Detalhe do erro: {e.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
