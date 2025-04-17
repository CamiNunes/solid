using srp.Problem;
using System.Net.Mail;

namespace srp.Solution
{
    public class EmailNotificadorPedido : INotificadorPedido
    {
        public void NotificarCliente(Pedido pedido)
        {
            var smtpClient = new SmtpClient("smtp.company.com");
            var mailMessage = new MailMessage
            {
                From = new MailAddress("noreply@company.com"),
                Subject = "Seu pedido foi processado",
                Body = $"Prezado {pedido.Cliente.Nome}, seu pedido #{pedido.Id} foi processado."
            };
            mailMessage.To.Add(pedido.Cliente.Email);

            smtpClient.Send(mailMessage);
        }
    }
}
