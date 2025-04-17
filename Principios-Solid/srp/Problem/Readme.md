Problema Detalhado: Classes com múltiplas responsabilidades se tornam frágeis e de dificeis de manter;

Problemas especificos desse código:
	1. Acoplamento Elevado: A classe conhece detalhes de validação, cálculo, persistência, logging e email;
	2. Dificuldade de Teste: Não pode testar validação sem executar todo o processo;
	3. Fragilidade: Mudanças no formato do email exigem modificar a classe de pedido;
	4. Reuso Zero: Não pode reutilizar a lógica de cálculo em outro lugar;