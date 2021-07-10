using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website_TecSys_NetCore.Application.Interfaces;
using Website_TecSys_NetCore.Application.Models;

namespace Website_TecSys_NetCore.Controllers
{
    public class ContactController : Controller
    {
        private readonly IEmailService _emailService;
        public ContactController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactFormModel model)
        {
            try
            {
                _emailService.SendEmailAsync(model);

                return Json("Email Enviado com sucesso!");
            }catch(Exception e)
            {
                return BadRequest("Erro ao tentar enviar o email de contato");
            }
        }
    }
}
