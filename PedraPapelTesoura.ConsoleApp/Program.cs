class Program
{
    static void Main(string[] args)
    {


        ExecutarPartida();

    }

    static void ExecutarPartida()
    {
        while (true)
        {
            ExibirCabecalho();

            Jogador.FazerJogada();
            Computador.FazerJogada();

            Console.Clear();

            CompararJogadas(Jogador.opcaoJogada, Computador.opcaoJogada);

            if (!JogarNovamente())
            {
                break;
            }
        }
    }

    private static void ExibirCabecalho()
    {
        Console.Clear();
        System.Console.WriteLine("---------------------------");
        System.Console.WriteLine("PEDRA,PAPEL,TESOURA");
        System.Console.WriteLine("---------------------------");

    }

    private static void CompararJogadas(int opcaoJogadaJogador, int opcaoJogadaComputador)
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

    private static bool JogarNovamente()
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






