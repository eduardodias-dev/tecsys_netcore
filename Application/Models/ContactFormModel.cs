using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Website_TecSys_NetCore.Application.Models
{
    public class ContactFormModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; } = "";
        public string Message { get; set; }
    }
}
