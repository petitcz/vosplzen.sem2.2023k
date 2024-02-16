using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace vosplzen.sem2._2023k.Services
{
    public class EmailSender : IEmailSender
    {
        ILogger<EmailSender> _log;

        public EmailSender(ILogger<EmailSender> log)
        {
            _log = log;
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            foreach (var recipient in to.Split(';'))
            {
                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress("{email from}");
                    mail.To.Add(recipient);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;


                    try
                    {
                        using (var smtp = new SmtpClient("smtp.forpsi.cz", 587))
                        {
                            smtp.Credentials = new NetworkCredential("{uz.jmeno}", "{heslo}");
                            smtp.EnableSsl = true;
                            await smtp.SendMailAsync(mail);
                        }
                    }
                    catch (Exception ex)
                    {
                        _log.LogError(ex.Message, ex);
                    }

                }

            }
        }
    }
}
