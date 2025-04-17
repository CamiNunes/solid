using srp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

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
