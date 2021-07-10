using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website_TecSys_NetCore.Application.Models;

namespace Website_TecSys_NetCore.Application.Interfaces
{
    public interface IEmailService
    {
        void SendEmailAsync(ContactFormModel contactModel);
    }
}
