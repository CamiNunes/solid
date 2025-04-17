using Microsoft.Data.SqlClient;
using srp.Problem;
using System.Net.Mail;

public class PedidoService
{
    private readonly string _connectionString;

    public PedidoService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void ProcessarPedido(Pedido pedido)
    {
        // 1. Validação complexa
        if (pedido == null)
            throw new ArgumentNullException(nameof(pedido));

        if (pedido.Itens == null || !pedido.Itens.Any())
            throw new InvalidOperationException("Pedido sem itens");

        if (pedido.Cliente == null)
            throw new InvalidOperationException("Cliente não informado");

        if (pedido.ValorTotal <= 0)
            throw new InvalidOperationException("Valor total inválido");

        // 2. Cálculo de impostos
        decimal taxaImposto = 0.1m; // 10%
        if (pedido.Cliente.EhIsentoImposto)
            taxaImposto = 0;

        pedido.ValorImposto = pedido.ValorTotal * taxaImposto;
        pedido.ValorFinal = pedido.ValorTotal + pedido.ValorImposto;

        // 3. Persistência no banco
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            // Inserir pedido
            var cmdPedido = new SqlCommand(
                "INSERT INTO Pedidos (ClienteId, Data, ValorTotal, ValorImposto, ValorFinal) " +
                "VALUES (@ClienteId, @Data, @ValorTotal, @ValorImposto, @ValorFinal); " +
                "SELECT SCOPE_IDENTITY();", connection);

            // ... parâmetros do comando ...

            var pedidoId = Convert.ToInt32(cmdPedido.ExecuteScalar());
            pedido.Id = pedidoId;

            // Inserir itens
            foreach (var item in pedido.Itens)
            {
                var cmdItem = new SqlCommand(
                    "INSERT INTO PedidoItens (PedidoId, ProdutoId, Quantidade, PrecoUnitario) " +
                    "VALUES (@PedidoId, @ProdutoId, @Quantidade, @PrecoUnitario)", connection);

                // ... parâmetros do comando ...

                cmdItem.ExecuteNonQuery();
            }
        }

        // 4. Geração de log
        File.AppendAllText("pedidos.log",
            $"[{DateTime.Now}] Pedido {pedido.Id} processado para cliente {pedido.Cliente.Nome}\n");

        // 5. Notificação por e-mail
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