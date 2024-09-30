# Calculadora de Partidas Rankeadas
 Segundo desafio de projeto do bootcamp GFT Start

## Descrição
Este projeto consiste em funções que calculam o saldo de vitórias e derrotas de um jogador, classificando-o em diferentes níveis, permitindo adicionar vários jogadores e listar todos os jogadores adicionados, ordenados do nível mais alto para o mais baixo.

## Novos Métodos

### 1. Método `AdicionarJogador`
Este método solicita o nome, o número de vitórias e derrotas de um jogador, calcula o saldo de vitórias, e classifica o jogador de acordo com o saldo.

- Vitórias < 10: **Ferro**
- Vitórias entre 10 e 19: **Bronze**
- Vitórias entre 20 e 49: **Prata**
- Vitórias entre 50 e 79: **Ouro**
- Vitórias entre 80 e 89: **Diamante**
- Vitórias entre 90 e 99: **Lendário**
- Vitórias ≥ 100: **Imortal**

## Exemplo de Saída
Ao final, será exibida a seguinte mensagem para cada jogador:

O Herói {Nome} tem um saldo de {saldoVitorias} e está no nível {nivel}.

### 2. Looping para `Múltiplos Jogadores`
O programa foi colocado em um loop para permitir que múltiplos jogadores sejam adicionados sucessivamente.

### 3. `Método de Listagem`
Este método exibe todos os jogadores adicionados, ordenando-os do nível mais alto para o mais baixo.
