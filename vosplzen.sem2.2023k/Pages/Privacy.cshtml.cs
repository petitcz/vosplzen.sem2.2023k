using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vosplzen.sem2._2023k.Services;

namespace vosplzen.sem2._2023k.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Hangfire.BackgroundJob.Enqueue<EmailSender>(x => x.SendEmailAsync("pbohac@windowslive.com","body","body"));

        }
    }
}