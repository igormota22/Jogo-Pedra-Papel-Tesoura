using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabecalho();

            int jogadaJogador = FazerJogadaJogador();
            int jogadaComputador = FazerJogadaComputador();

            CompararJogadas(jogadaJogador, jogadaComputador);

            System.Console.WriteLine();

            if (!JogarNovamente())
            {
                break;
            }
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("PEDRA,PAPEL,TESOURA");
            System.Console.WriteLine("---------------------------");

        }
    }

    public static int FazerJogadaJogador()
    {
        System.Console.WriteLine("1 - Pedra");
        System.Console.WriteLine("2 - Papel");
        System.Console.WriteLine("3 - Tesoura");
        System.Console.Write("Escolha sua jogada: ");
        int opcaoJogadaJogador = Convert.ToInt32(Console.ReadLine());

        if (opcaoJogadaJogador != 1 && opcaoJogadaJogador != 2 && opcaoJogadaJogador != 3)
        {
            System.Console.WriteLine("Escolha uma opção valida");
            Console.ReadLine();

        }
        return opcaoJogadaJogador;
    }

    public static int FazerJogadaComputador()
    {

        System.Console.WriteLine("Computador escolheu jogada,aperte ENTER para continuar");
        int opcaoJogadaComputador = RandomNumberGenerator.GetInt32(1, 4);
        Console.ReadLine();


        return opcaoJogadaComputador;
    }

    public static void CompararJogadas(int opcaoJogadaJogador, int opcaoJogadaComputador)
    {
        string? escolhaJogador = "";
        string? escolhaComputador = "";

        if (opcaoJogadaJogador == 1)
        {
            escolhaJogador = "Pedra";
        }
        else if (opcaoJogadaJogador == 2)
        {
            escolhaJogador = "Papel";
        }
        else if (opcaoJogadaJogador == 3)
        {
            escolhaJogador = "Tesoura";
        }


        if (opcaoJogadaComputador == 1)
        {
            escolhaComputador = "Pedra";
        }
        else if (opcaoJogadaComputador == 2)
        {
            escolhaComputador = "Papel";
        }
        else if (opcaoJogadaComputador == 3)
        {
            escolhaComputador = "Tesoura";
        }

        if (opcaoJogadaJogador == opcaoJogadaComputador)
        {
            System.Console.WriteLine($"O jogador jogou {escolhaJogador}");
            System.Console.WriteLine($"O compuatdor jogou {escolhaComputador}");
            System.Console.WriteLine("Empate");

        }
        else if (opcaoJogadaJogador == 1 && opcaoJogadaComputador == 2)
        {
            System.Console.WriteLine($"O jogador jogou {escolhaJogador}");
            System.Console.WriteLine($"O computador jogou {escolhaComputador}");
            System.Console.WriteLine("Jogador Perdeu");
        }
        else if (opcaoJogadaJogador == 1 && opcaoJogadaComputador == 3)
        {
            System.Console.WriteLine($"O jogador jogou {escolhaJogador}");
            System.Console.WriteLine($"O computador jogou {escolhaComputador}");
            System.Console.WriteLine("Jogador Venceu");
        }
        else if (opcaoJogadaJogador == 2 && opcaoJogadaComputador == 3)
        {
            System.Console.WriteLine($"O jogador jogou {escolhaJogador}");
            System.Console.WriteLine($"O computador jogou {escolhaComputador}");
            System.Console.WriteLine("Jogador Perdeu");
        }
        else if (opcaoJogadaJogador == 2 && opcaoJogadaComputador == 1)
        {
            System.Console.WriteLine($"O jogador jogou {escolhaJogador}");
            System.Console.WriteLine($"O computador jogou {escolhaComputador}");
            System.Console.WriteLine("Jogador Venceu");
        }
        else if (opcaoJogadaJogador == 3 && opcaoJogadaComputador == 1)
        {
            System.Console.WriteLine($"O jogador jogou {escolhaJogador}");
            System.Console.WriteLine($"O computador jogou {escolhaComputador}");
            System.Console.WriteLine("Jogador Perdeu");
        }
        else if (opcaoJogadaJogador == 3 && opcaoJogadaComputador == 2)
        {
            System.Console.WriteLine($"O jogador jogou {escolhaJogador}");
            System.Console.WriteLine($"O computador jogou {escolhaComputador}");
            System.Console.WriteLine("Jogador Venceu");
        }

    }

    public static bool JogarNovamente()
    {
        System.Console.WriteLine("Deseja jogar novamente? (s/N)");
        string? desejaJogarNovamente = Console.ReadLine()?.ToUpper();


        if (desejaJogarNovamente != "S")
        {
            return false;
        }
        return true;
    }
}






