using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using Poc1.Data;
using Poc1.Models;
using Poc1.Repositories;
using System;

namespace Poc1.Controllers
{
    public class ApontamentoController : Controller
    {
        private readonly IApontamentoRepositorio _apontamentoRepositorio;

        public ApontamentoController (IApontamentoRepositorio apontamentoRepositorio)
        {
            _apontamentoRepositorio = apontamentoRepositorio;
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(ApontamentoModel apontamento)
        {         
            try
            {
                _apontamentoRepositorio.Adicionar(apontamento);
                return View("Index");
                
                //if (ModelState.IsValid)
                //{
                //    _apontamentoRepositorio.Adicionar(apontamento);
                //    TempData["MensagemSucesso"] = "Apontamento realizado com sucesso";
                //    return RedirectToAction("Criar");
                //}
                //return View("Index");
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Não foi possível realizar o apontamento. Detalhe do erro: {e.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
