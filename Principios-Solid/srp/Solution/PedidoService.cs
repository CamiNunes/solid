using srp.Problem;

namespace srp.Solution
{
    public class PedidoService
    {
        private readonly IPedidoValidator _validator;
        private readonly IPedidoCalculador _calculador;
        private readonly IPedidoRepository _repository;
        private readonly ILoggerPedido _logger;
        private readonly INotificadorPedido _notificador;

        public PedidoService(
            IPedidoValidator validator,
            IPedidoCalculador calculador,
            IPedidoRepository repository,
            ILoggerPedido logger,
            INotificadorPedido notificador)
        {
            _validator = validator;
            _calculador = calculador;
            _repository = repository;
            _logger = logger;
            _notificador = notificador;
        }

        public void ProcessarPedido(Pedido pedido)
        {
            _validator.Validar(pedido);
            _calculador.CalcularValores(pedido);
            var pedidoId = _repository.Salvar(pedido);
            pedido.Id = pedidoId;

            _logger.Log($"Pedido {pedido.Id} processado para cliente {pedido.Cliente.Nome}");
            _notificador.NotificarCliente(pedido);
        }
    }
}
