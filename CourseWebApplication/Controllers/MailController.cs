
using Microsoft.AspNetCore.Mvc;
using WebApp.IService;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        const string subject = "Код для регистрации в приложение";

        readonly IConfiguration configuration;

        IEmailService emailService;

        public MailController(IConfiguration configuration, IEmailService emailService)
        {
            this.configuration = configuration;
            this.emailService = emailService;
        }

        [HttpPost]
        public async Task<ActionResult<SendMessageReponse>> SendMessage(SendMessageRequest to)
        {
            string login = configuration["Data:Login"];
            string password = configuration["Data:Password"];
            int code = await emailService.SendEmail(login, to.Email, password, subject);
            return Ok(new SendMessageReponse() { Code = code });
        }
    }
}
