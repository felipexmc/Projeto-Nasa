*** O que é Nasa?

Nasa é um programa simples para teste de movimentação de até 2 robos espaciais sendo um por vez.

*** Como funciona?

Basta preencher corretamente as informações básicas de posição e comandos de movimentação, além
de seu ponto inicial em planalto. A forma correta de preenchimento dessas três informações segue abaixo:

- Posição de Entrada no Planalto:

Aqui é permitido digitar apenas 2 números correspondentes a posição em plano cartesiano, exemplo "X,Y".
Não é necessário digitar a vírgula o programa se encarrega disto basta digitar 2 números inteiros,
sendo um para posição "X" e outro para o "Y".

OBS: É de caracter obrigatório preencher com 2 números, caso haja alguma incoerência no que foi digitado
o programa se encarrega de apagar o dado incoerente!

Exemplo de preenchimento correto: 2,2
Exemplo de dado incoerente: ,

- Posição Robô 1:

Aqui é a posição inicial que se encontra o primeiro Robô. Para o preenchimento correto é necessário
digitar dois números, seguidos de uma letra correspondente a direção que o Robô está apontado.
Não é necessário digitar a vírgula o programa se encarrega disto. As Letras só serão permitidas
no terceiro digito são elas: N(Representa Norte), W(Represente Oeste), S(Representa Sul) e E(Representa Leste).

OBS: É de caracter obrigatório preencher com 2 números e depois uma Letra correspondente(N,W,S ou E),
caso haja alguma incoerência no que foi digitado o programa se encarrega de apagar o dado incoerente!

Exemplos de preenchimento correto:

- 2,2W
- 1,3S

Exemplos de dados incoerentes:
-  ,2W
-  ,

- Movimentação Robô 1:

Aqui é preenchido com a movimentação que o primeiro Robô irá executar. Para o preenchimento correto é necessário
digitar pelo menos uma destas letras correspondentes: L, R ou M. Onde L indica um giro de 90º para esquerda,
R indica um giro de 90º para a Direita e M indica que o Robô avançara 1 quadro na direção que ele estará apontado.

Não há limite de digitos desde que o usuário digite entre as letras L, R ou M.
Exemplo de preenchimento correto: LLMRM

- Mover Robô 1:

Este botão quando clicado cálcula a nova posição do Robô 1 de acordo com os dados preenchidos e os exibe
no quadro de "Histórico de Resultados".
Este botão só executará esta ação se estes dados forem preenchidos corretamente:
- Posição de Entrada no Planalto;
- Posição Robô 1;
- Movimentação Robô 1;

OBS: o botão também poderá ser acionado digitando enter se estiver dentro de "Posição Robô 1" ou
"Movimentação Robô 1".


- Posição Robô 2:

Aqui é a posição inicial que se encontra o segundo Robô. Para o preenchimento correto é necessário
digitar dois números, seguidos de uma letra correspondente a direção que o Robô está apontado.
Não é necessário digitar a vírgula o programa se encarrega disto. As Letras só serão permitidas
no terceiro digito são elas: N(Representa Norte), W(Represente Oeste), S(Representa Sul) e E(Representa Leste).

OBS: É de caracter obrigatório preencher com 2 números e depois uma Letra correspondente(N,W,S ou E),
caso haja alguma incoerência no que foi digitado o programa se encarrega de apagar o dado incoerente!

Exemplos de preenchimento correto:

- 2,2W
- 1,3S

Exemplos de dados incoerentes:
-  ,2W
-  ,

- Movimentação Robô 2:

Aqui é preenchido com a movimentação que o segundo Robô irá executar. Para o preenchimento correto é necessário
digitar pelo menos uma destas letras correspondentes: L, R ou M. Onde L indica um giro de 90º para esquerda,
R indica um giro de 90º para a Direita e M indica que o Robô avançara 1 quadro na direção que ele estará apontado.

Não há limite de digitos desde que o usuário digite entre as letras L, R ou M.
Exemplo de preenchimento correto: LLMRM

- Mover Robô 2:

Este botão quando clicado cálcula a nova posição do Robô 2 de acordo com os dados preenchidos e os exibe
no quadro de "Histórico de Resultados".
Este botão só executará esta ação se estes dados forem preenchidos corretamente:
- Posição de Entrada no Planalto;
- Posição Robô 2;
- Movimentação Robô 2;

OBS: o botão também poderá ser acionado digitando enter se estiver dentro de "Posição Robô 2" ou
"Movimentação Robô 2".

- Histórico de Resultados:

Este é um visor que mostra o histórico dos resultados finais de movimentação de cada Robô.


*** Requirements:

O programa irá funcionar em computadores com Windows: Vista, 7 e 8 ou superior. É necessário ter o .NetFramework 4.5
instalado.