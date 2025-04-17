using srp.Problem;

namespace srp.Solution
{
    public class PedidoValidator : IPedidoValidator
    {
        public void Validar(Pedido pedido)
        {
            if (pedido == null)
                throw new ArgumentNullException(nameof(pedido));

            if (pedido.Itens == null || !pedido.Itens.Any())
                throw new InvalidOperationException("Pedido sem itens");

            if (pedido.Cliente == null)
                throw new InvalidOperationException("Cliente não informado");

            if (pedido.ValorTotal <= 0)
                throw new InvalidOperationException("Valor total inválido");
        }
    }
}
