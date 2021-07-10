using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Website_TecSys_NetCore.Application.Interfaces;
using Website_TecSys_NetCore.Application.Models;

namespace Website_TecSys_NetCore.Application.Services
{
    public class EmailService : IEmailService
    {
        private readonly SmtpClient _smtpClient;
        private readonly EmailConfig _emailConfig;
        public EmailService()
        {
            _emailConfig = new EmailConfig
            {
                ToAddress = "eduardo.dias092@gmail.com",
                MailServerAddress = "smtp.gmail.com",
                MailServerPort = "587",
                UserAddress = "eduardo.dias092@gmail.com",
                UserPassword = "Tirano19@"
            };

            _smtpClient = ConfigureSmtpClient(_emailConfig);
        }
        public void SendEmailAsync(ContactFormModel contactModel)
        {
            var emailMessage = new MailMessage();

            emailMessage.From = new MailAddress(contactModel.Email, contactModel.Name);
            emailMessage.To.Add(new MailAddress(_emailConfig.ToAddress, "eu"));
            emailMessage.Subject = contactModel.Subject;
            emailMessage.IsBodyHtml = true;
            emailMessage.Body = contactModel.Message ;

            using (_smtpClient)
            {
                _smtpClient.Send(emailMessage);
                _smtpClient.SendCompleted += (sender, e) =>
                {
                    if (e.Error != null)
                        Console.WriteLine("Enviado com sucesso");
                    else
                        Console.WriteLine($"Erro ao enviar mensagem: {e.Error.Message}");
                };
            }
        }

        public class EmailConfig
        {
            public string ToAddress { get; set; }

            public string LocalDomain { get; set; }

            public string MailServerAddress { get; set; }
            public string MailServerPort { get; set; }

            public string UserAddress { get; set; }
            public string UserPassword { get; set; }
        }

        public SmtpClient ConfigureSmtpClient(EmailConfig config) {
            return new SmtpClient
            {
                Host = config.MailServerAddress,
                Port = int.Parse(config.MailServerPort),
                EnableSsl = true,
                Credentials = new NetworkCredential(config.UserAddress, config.UserPassword)
            };
        }
    }
}
