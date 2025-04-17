using srp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
