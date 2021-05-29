using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Website_TecSys_NetCore.Models;

namespace Website_TecSys_NetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> menus = new List<string>{"Home", "Serviços", "Portfolio", "Fale Conosco"};
            ViewBag.Menus = menus;
            return View(new Configuracoes());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Configuracoes{
        public string TeleFone = "(31) 995818197";
        public string Email = "eduardo.dias092@gmail.com";
        public string Endereco = "Rua das Sempre-vivas, 181, Sapucaia, Contagem/MG";
    }
}
