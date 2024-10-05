using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_de_Partidas_Rankeadas.models
{
    public class Jogador
    {
        // Propriedades de lista da classe Jogador.
        public List<string> Nome { get; set; }
        public List<int> Saldo { get; set; }
        public List<string> Nivel { get; set; }

        // Métodos da classe Jogador.
        public void AdicionarJogador()
        {

            string nivelJogador = "";

            static int SaldoJogador(int vitorias, int derrotas)
            {
                int saldo = vitorias - derrotas;
                return saldo;
            }

            Console.Write("Digite o nome do jogador: ");
            string nomeJogador = Console.ReadLine();
            Nome.Add(nomeJogador);

            Console.WriteLine();

            Console.Write("Digite a quantidade de vitórias: ");
            int vitoriasDoJogador = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de derrotas: ");
            int derrotasDoJogador = Convert.ToInt32(Console.ReadLine());

            int saldoJogador = SaldoJogador(vitoriasDoJogador, derrotasDoJogador);

            Saldo.Add(saldoJogador);

            Console.WriteLine();

            if (saldoJogador < 10)
            {
                Nivel.Add("Ferro");
                nivelJogador = "Ferro";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 10 && saldoJogador < 20)
            {
                Nivel.Add("Bronze");
                nivelJogador = "Bronze";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 20 && saldoJogador < 50)
            {
                Nivel.Add("Prata");
                nivelJogador = "Prata";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 50 && saldoJogador < 80)
            {
                Nivel.Add("Ouro");
                nivelJogador = "Ouro";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 80 && saldoJogador < 90)
            {
                Nivel.Add("Diamante");
                nivelJogador = "Diamante";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 90 && saldoJogador < 100)
            {
                Nivel.Add("Lendário");
                nivelJogador = "Lendário";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else
            {
                Nivel.Add("Imortal");
                nivelJogador = "Imortal";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione -Enter- para continuar...");
            Console.ReadLine();
        }
        public void RemoverJogador()
        {
            Console.Write("Digite o nome do jogador que você quer remover: ");
            string jogadorRemovido = Console.ReadLine();

            Nome.Remove(jogadorRemovido);
            
            Console.WriteLine($"Jogador {jogadorRemovido} foi removido.");
            Console.WriteLine();
            Console.WriteLine("Pressione -Enter- para continuar...");
            Console.ReadLine();
        }
        public void ListarJogadoresPorNivel()
        {
            int saldoOrdenacao = 0;
            string nomeOrdenacao = "";
            string nivelOrdenacao = "";

            Console.WriteLine(@"
========================================
|        Listagem De Jogadores         |
========================================");

            for (int cont = 0; cont < Nome.Count - 1; cont++)
            {
                for (int cont2 = cont + 1; cont2 < Nome.Count; cont2++)
                {
                    if (Saldo[cont] < Saldo[cont2])
                    {
                        saldoOrdenacao = Saldo[cont2];
                        Saldo[cont2] = Saldo[cont];
                        Saldo[cont] = saldoOrdenacao;

                        nomeOrdenacao = Nome[cont2];
                        Nome[cont2] = Nome[cont];
                        Nome[cont] = nomeOrdenacao;

                        nivelOrdenacao = Nivel[cont2];
                        Nivel[cont2] = Nivel[cont];
                        Nivel[cont] = nivelOrdenacao;
                    }
                }
            }

            Console.WriteLine("{0,-5} | {1, -10} | {2, -10} | {3, -10}", "ID", "Nome", "Saldo", "Nivel");
            Console.WriteLine(new string('-', 40));

            for (int cont = 0; cont < Nome.Count; cont++)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-10}", cont + 1, Nome[cont], Saldo[cont], Nivel[cont]);
            }

            Console.WriteLine();
            Console.WriteLine("Pressione -Enter- para continuar...");
            Console.ReadLine();
        }
    }
}