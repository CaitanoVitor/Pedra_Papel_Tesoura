using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        const int ESCOLHA_PEDRA = 1;
        const int ESCOLHA_PAPEL = 2;
        const int ESCOLHA_TESOURA = 3;

        while (true)
        {
            int escolhaDoJogador;
            do
            {
                Console.Clear();

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Pedra, Papel, Tesoura");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1 - Pedra");
                Console.WriteLine("2 - Papel");
                Console.WriteLine("3 - Tesoura");
                Console.WriteLine("-----------------------------");
                Console.Write("Digite uma opção válida: ");

                string? strescolhaDoJogador = Console.ReadLine();

                if (strescolhaDoJogador == "1" || strescolhaDoJogador == "2" || strescolhaDoJogador == "3")
                {
                    escolhaDoJogador = Convert.ToInt32(strescolhaDoJogador);
                    break;
                }
            } while (true);

            int escolhaDoComputador = RandomNumberGenerator.GetInt32(1, 4);

            if (escolhaDoJogador == escolhaDoComputador)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Empate");
                Console.WriteLine("-----------------------------");
            }
            else if (escolhaDoJogador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("-----------------------------");
                Console.Write("PAPEL VS ");

                if (escolhaDoComputador == ESCOLHA_PEDRA)
                {
                    Console.WriteLine("PEDRA");
                    Console.WriteLine("O JOGADOR foi o vencedor!");
                }
                else if (escolhaDoComputador == ESCOLHA_TESOURA)
                {
                    Console.WriteLine("TESOURA");
                    Console.WriteLine("O COMPUTADOR foi o vencedor ");
                }
            }
            else if (escolhaDoJogador == ESCOLHA_PEDRA)
            {
                Console.WriteLine("-----------------------------");
                Console.Write("PEDRA VS ");

                if (escolhaDoComputador == ESCOLHA_PAPEL)
                {
                    Console.WriteLine("PAPEL");
                    Console.WriteLine("O COMPUTADOR foi o vencedor!");
                }
                else if (escolhaDoComputador == ESCOLHA_TESOURA)
                {
                    Console.WriteLine("TESOURA");
                    Console.WriteLine("O JOGADOR foi o vencedor ");
                }
            }
            else if (escolhaDoJogador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("-----------------------------");
                Console.Write("TESOURA VS ");

                if (escolhaDoComputador == ESCOLHA_PEDRA)
                {
                    Console.WriteLine("PEDRA");
                    Console.WriteLine("O COMPUTADOR foi o vencedor!");
                }
                else if (escolhaDoComputador == ESCOLHA_PAPEL)
                {
                    Console.WriteLine("PAPEL");
                    Console.WriteLine("O JOGADOR foi o vencedor ");
                }
            }


            Console.WriteLine("-----------------------------");

            Console.Write("Deseja continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
            {
                break;
            }

        }
    }
}

