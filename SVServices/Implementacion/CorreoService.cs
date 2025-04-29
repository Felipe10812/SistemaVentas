using Microsoft.Extensions.Configuration;
using SVServices.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace SVServices.Implementacion
{
    public class CorreoService : ICorreoService
    {
        private readonly IConfiguration _configuration;
        private readonly string _host;
        private readonly int _port;
        private readonly string _username;
        private readonly string _password;

        public CorreoService(IConfiguration configuration)
        {
            _configuration = configuration;
            _host = _configuration["Smtp:host"]!;
            _port = int.Parse(_configuration["Smtp:port"]!); // Convertir a int
            _username = _configuration["Smtp:user"]!;
            _password = _configuration["Smtp:pass"]!;
        }

        public async Task Enviar(string para, string asunto, string mensajeHTML)
        {
            // Usar `using` para manejar recursos correctamente
            using var smtp = new SmtpClient();

            // Conectar al servidor SMTP
            await smtp.ConnectAsync(_host, _port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_username, _password);

            // Crear el mensaje de correo
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_username));
            email.To.Add(MailboxAddress.Parse(para));
            email.Subject = asunto;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = mensajeHTML };

            // Enviar el correo
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}