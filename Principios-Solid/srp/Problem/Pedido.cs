using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp.Problem
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public decimal ValorTotal { get; private set; }
        public decimal ValorImposto { get; set; }
        public decimal ValorFinal { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<PedidoItem> Itens { get; set; } = new List<PedidoItem>();
        public StatusPedido Status { get; set; } = StatusPedido.EmProcessamento;

        // Método para adicionar itens ao pedido
        public void AdicionarItem(Produto produto, int quantidade)
        {
            var item = new PedidoItem
            {
                Produto = produto,
                Quantidade = quantidade,
                PrecoUnitario = produto.Preco
            };

            Itens.Add(item);
            ValorTotal += item.ValorTotal;
        }

        // Método para remover itens do pedido
        public void RemoverItem(int produtoId)
        {
            var item = Itens.FirstOrDefault(i => i.ProdutoId == produtoId);
            if (item != null)
            {
                ValorTotal -= item.ValorTotal;
                Itens.Remove(item);
            }
        }

        // Método para calcular o valor total
        public void CalcularTotal()
        {
            ValorTotal = Itens.Sum(i => i.ValorTotal);
        }
    }
}
