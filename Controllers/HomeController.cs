using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Website_TecSys_NetCore.Data;
using Website_TecSys_NetCore.Models;

namespace Website_TecSys_NetCore.Controllers
{
    public class HomeController : Controller
    {   
        private readonly TecsysDbContext _context;
        public HomeController(TecsysDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            List<string> menus = new List<string>{"Home", "Serviços", "Portfolio", "Fale Conosco"};
            ViewBag.Menus = menus;
            var list = _context.Configuracoes.ToList();
            var dictionaryConfig = list.ToDictionary(x => x.Chave.ToLower(), y => y.Valor);
            ConfiguracoesModel configs = new ConfiguracoesModel();

            configs.Telefone = dictionaryConfig["telefone"];
            configs.Email = dictionaryConfig["email"];
            configs.Endereco = dictionaryConfig["endereco"];
            
            return View(configs);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
