# language: pt-BR 

Funcionalidade: Realizar Pedido
	Para garantir que um pedido possar ser criado corretamente
	Como usuário da aplicação
	Eu quero adicionar itens e calcular o valor total do pedido

	Cenário: Criar Pedido Válido
		Dado que eu tenha um novo pedido
		Quando eu adicionar um item com quantidade 3 e preço unitário de 40
		Então o valor total do pedido deve ser 120

	Cenário: Pedido com Item de Quantidade Zero
		Dado que eu tenha um novo pedido
		Quando eu adicionar um item com quantidade 0 e preço unitário de 50
		Então o pedido deve ser considerado inválido

	Cenário: Pedido com Frete Grátis
		Dado que eu tenha um novo pedido
		Quando eu adicionar um item com quantidade 6 e preço unitário de 100
		Então o frete deve ser grátis