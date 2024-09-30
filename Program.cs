using Calculadora_de_Partidas_Rankeadas.models;

string opcao = "";

Jogador jogador = new Jogador();
jogador.Nome = new List<string>();
jogador.Nivel = new List<string>();
jogador.Saldo = new List<int>();

do
{
    Console.Write(@"
-----------------------------------
|CALCULADORA DE PARTIDAS RANKEADAS|
-----------------------------------
|[1] Adicionar jogador            | 
|[2] Listar jogadores por nível   |
|[3] Sair                         |
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
    else 
    {
        Console.Clear();
        Console.WriteLine("Fim do programa...");
    }
    
} while (opcao != "3");