using Microsoft.Data.SqlClient;
using srp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp.Solution
{
    public class SqlPedidoRepository : IPedidoRepository
    {
        private readonly string _connectionString;

        public SqlPedidoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Salvar(Pedido pedido)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmdPedido = new SqlCommand(
                    "INSERT INTO Pedidos (ClienteId, Data, ValorTotal, ValorImposto, ValorFinal) " +
                    "VALUES (@ClienteId, @Data, @ValorTotal, @ValorImposto, @ValorFinal); " +
                    "SELECT SCOPE_IDENTITY();", connection);

                // ... parâmetros ...

                var pedidoId = Convert.ToInt32(cmdPedido.ExecuteScalar());

                foreach (var item in pedido.Itens)
                {
                    var cmdItem = new SqlCommand(
                        "INSERT INTO PedidoItens (PedidoId, ProdutoId, Quantidade, PrecoUnitario) " +
                        "VALUES (@PedidoId, @ProdutoId, @Quantidade, @PrecoUnitario)", connection);

                    // ... parâmetros ...

                    cmdItem.ExecuteNonQuery();
                }

                return pedidoId;
            }
        }
    }

}
