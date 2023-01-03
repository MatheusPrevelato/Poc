using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Poc1.Models;
using Poc1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Poc1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApontamentoServico _apontamentoServico;
        private readonly StreamServico _streamServico;
        private readonly AtividadeServico _atividadeServico;
        private readonly FaseServico _faseServico;
        private readonly ILogger<HomeController> _logger;


        public HomeController(
            ApontamentoServico apontamentoServico,
            StreamServico streamServico,
            AtividadeServico atividadeServico,
            FaseServico faseServico,
            ILogger<HomeController> logger)
        {
            _apontamentoServico = apontamentoServico;
            _streamServico = streamServico;
            _atividadeServico = atividadeServico;
            _faseServico = faseServico;
            _logger = logger;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
