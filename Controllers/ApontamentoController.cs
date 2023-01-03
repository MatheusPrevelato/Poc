using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using Poc1.Data;
using Poc1.Entidades;
using Poc1.Models;
using Poc1.Repositories;
using Poc1.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Poc1.Controllers
{
    public class ApontamentoController : Controller
    {
        private readonly ApontamentoServico _apontamentoServico;
        private readonly StreamServico _streamServico;
        private readonly AtividadeServico _atividadeServico;
        private readonly FaseServico _faseServico;


        public ApontamentoController(
            ApontamentoServico apontamentoServico,
            StreamServico streamServico,
            AtividadeServico atividadeServico,
            FaseServico faseServico)
        {
            _apontamentoServico = apontamentoServico;
            _streamServico = streamServico;
            _atividadeServico = atividadeServico;
            _faseServico = faseServico;
        }

        [NonAction]
        public void CarregarStreams()
        {
            IEnumerable<Stream> streams = _streamServico.BuscarStreams();
            ViewBag.Streams = streams;
        }

        [NonAction]
        public void CarregarAtividades()
        {
            IEnumerable<Atividade> atividades = _atividadeServico.BuscarAtividades();
            ViewBag.Atividades = atividades;
        }

        [NonAction]
        public void CarregarFases()
        {
            IEnumerable<Fase> fases = _faseServico.BuscarFases();
            ViewBag.Fases = fases;
        }

        [NonAction]
        public void CarregarApontamentos(int id, int streamId, int atividadeId, int faseId, int horas, string observacoes)
        {
            IEnumerable<Apontamento> apontamentos = _apontamentoServico.Buscar(id);
            ViewBag.Apontamentos = apontamentos;
        }

        [NonAction]
        public void CarregarHorariosApontamentos()
        {
            var horariosApontamentos = new[]
            {
                new {Horario = "01:00"},
                new {Horario = "02:00"},
                new {Horario = "03:00"},
                new {Horario = "04:00"},
                new {Horario = "05:00"},
                new {Horario = "06:00"},
                new {Horario = "07:00"},
                new {Horario = "08:00"}
            };
            ViewBag.HorariosApontamentos = horariosApontamentos;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Consultar(Apontamento model)
        {
            CarregarApontamentos(model.Id, model.StreamId, model.AtividadeId, model.FaseId, model.Horas, model.Observacoes);
            //IEnumerable<Apontamento> apontamentos = _apontamentoServico.Buscar(model.Id);
            return View(model);
        }


        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
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
