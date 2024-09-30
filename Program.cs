using Calculadora_de_Partidas_Rankeadas.models;

string opcao = "";

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

    Jogador jogador = new Jogador();
    jogador.Nome = new List<string>();
    jogador.Saldo = new List<int>();

    if (opcao == "1")
    {
        jogador.AdicionarJogador();
    }
    else if (opcao == "2")
    {
        jogador.ListarJogadoresPorNivel();
    }
    else if (opcao == "3")
    {
        //RemoverJogador();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Fim do programa...");
    }

    //Console.Clear();
} while (opcao != "4");