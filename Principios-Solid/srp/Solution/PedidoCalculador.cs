using srp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
