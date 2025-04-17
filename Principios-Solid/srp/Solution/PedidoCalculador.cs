using srp.Problem;

namespace srp.Solution
{
    public class PedidoCalculador : IPedidoCalculador
    {
        public void CalcularValores(Pedido pedido)
        {
            decimal taxaImposto = pedido.Cliente.EhIsentoImposto ? 0 : 0.1m;
            pedido.ValorImposto = pedido.ValorTotal * taxaImposto;
            pedido.ValorFinal = pedido.ValorTotal + pedido.ValorImposto;
        }
    }
}
