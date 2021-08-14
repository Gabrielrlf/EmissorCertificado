using Cadastro.Core.Application.Organizadores;
using Emissao.Core.Application.Certificados;
using EventoCertificado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EventoCertificado.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicoEvento _servicoEvento;
        private readonly IServicoCertificado _servicoCertificado;
        public HomeController(IServicoEvento servicoEvento, IServicoCertificado servicoCertificado, ILogger<HomeController> logger)
        {
            _logger = logger;
            _servicoEvento = servicoEvento;
            _servicoCertificado = servicoCertificado;
        }

        public IActionResult Index(Guid id, string cpf)
        {
            var evento = _servicoEvento.RecuperarEvento(new Cadastro.Core.Domain.Model.Eventos.EventoId(id));
            var certificado = _servicoCertificado.EmitirCertificado(new Emissao.Core.Application.Domain.Model.Certificados.EventoId(id), cpf);
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
