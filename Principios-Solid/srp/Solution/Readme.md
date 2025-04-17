Benefícios:
	1. Testabilidade: Cada componente pode ser testado isoladamente;
	2. Reusabilidade: PedidoCalculator pode ser usado em outros serviços;
	3. Manutenibilidade: Mudanças no email não afetam o processamento do pedido;
	4. Extensibilidade: Pode adicionar novo logger sem modificar o serviço principal;
	5. Substituibilidade: Pode trocar implementações (ex.: MySQL por MongoDB);