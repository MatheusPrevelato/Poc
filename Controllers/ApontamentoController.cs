﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using Poc1.Data;
using Poc1.Models;
using Poc1.Repositories;
using Poc1.Services;
using System;
using System.Linq;

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
            ViewBag.Streams = StreamServico.GetStream().Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() }).ToList();
            ViewBag.Atividades = AtividadeServico.GetAtividade().Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() }).ToList();
            ViewBag.Fases = FaseServico.GetFase().Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() }).ToList();
            ViewBag.Horas = HoraServico.GetHora().Select(c => new SelectListItem() { Text = c.Quantidade, Value = c.Id.ToString() }).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(ApontamentoModel apontamento)
        {         
            try
            {
                _apontamentoRepositorio.Adicionar(apontamento);
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
