using MimeKit;
using MailKit.Net.Smtp;
using WebApp.IService;

namespace WebApp.Models
{
    public class EmailService:IEmailService
    {
        const string sender = "Отправитель: ";
        const string receiver = "Получатель: ";
        const string text = "Ваш код для регистрации: ";

        public async Task<int> SendEmail(string from, string to, string password, string subject)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(sender, from));
            emailMessage.To.Add(new MailboxAddress(receiver, to));
            emailMessage.Subject = subject;
            int code = Generator.GetRandom();
            emailMessage.Body = new TextPart("plain")
            {
                Text = text+code
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587);
                await client.AuthenticateAsync(from, password);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
            return code;
        }
    }

    static class Generator
    {
        public static int GetRandom()
        {
            Random rnd = new Random();
            int value = rnd.Next(1000, 10000);
            return value;
        }
    }

}
