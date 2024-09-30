using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_de_Partidas_Rankeadas.models
{
    public class Jogador
    {
        public List<string> Nome { get; set; }
        public List<int> Saldo { get; set; }

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

            Console.Write("Digite a quantidade de vitórias: ");
            int vitoriasDoJogador = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de derrotas: ");
            int derrotasDoJogador = Convert.ToInt32(Console.ReadLine());

            int saldoJogador = SaldoJogador(vitoriasDoJogador, derrotasDoJogador);

            Saldo.Add(saldoJogador);

            if (saldoJogador < 10)
            {
                nivelJogador = "Ferro";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 10 && saldoJogador < 20)
            {
                nivelJogador = "Bronze";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 20 && saldoJogador < 50)
            {
                nivelJogador = "Prata";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 50 && saldoJogador < 80)
            {
                nivelJogador = "Ouro";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 80 && saldoJogador < 90)
            {
                nivelJogador = "Diamante";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else if (saldoJogador >= 90 && saldoJogador < 100)
            {
                nivelJogador = "Lendário";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
            else
            {
                nivelJogador = "Imortal";
                Console.WriteLine($"{nomeJogador} tem de saldo de {saldoJogador} está no nível {nivelJogador}");
            }
        }

        public void ListarJogadoresPorNivel()
        {
            Console.WriteLine(@$"
================
|Nome   |Saldo |
================");
            for (int cont = 0; cont < Nome.Count; cont++)
            {
                Console.WriteLine($"|{Nome[cont]}\t|{Saldo[cont]}       |");
            }
            Console.WriteLine("================");
        }
    }
}