using Calculadora_de_Partidas_Rankeadas.models;

// Variável para verificar a opção selecionada pelo usuário.
string opcao = "";

// Instância da classe jogador e suas listas.
Jogador jogador = new Jogador();
jogador.Nome = new List<string>();
jogador.Nivel = new List<string>();
jogador.Saldo = new List<int>();

// Looping para introduzir o usuário no sistema.
do
{
    Console.Write(@"
-----------------------------------
|CALCULADORA DE PARTIDAS RANKEADAS|
-----------------------------------
|[1] Adicionar jogador            | 
|[2] Listar jogadores por nível   |
|[3] Remover jogador              |
|[4] Sair                         |
-----------------------------------
=> ");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        jogador.AdicionarJogador();
        Console.Clear();
    }
    else if (opcao == "2")
    {
        jogador.ListarJogadoresPorNivel();
        Console.Clear();
    }
    else if (opcao == "3")
    {
        jogador.RemoverJogador();
        Console.Clear();
    }
    else if (opcao == "4")
    {
        Console.Clear();
        Console.WriteLine("Fim do programa...");
    }
    else
    {
        Console.WriteLine("Opção inválida. Pressione -Enter- para continuar...");
        Console.ReadLine();
        Console.Clear();
    }
} while (opcao != "4");