class Jogo
{
    public static void ExecutarPartida()
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
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("---------------------------");
        System.Console.WriteLine("PEDRA,PAPEL,TESOURA");
        System.Console.WriteLine("---------------------------");
        Console.ForegroundColor = ConsoleColor.White;

    }

    private static void CompararJogadas(int opcaoJogadaJogador, int opcaoJogadaComputador)
    {
        const int escolhaPedra = 1;
        const int escolhaPapel = 2;
        const int escolhaTesoura = 3;

        string? escolhaJogador = "";
        string? escolhaComputador = "";

        if (opcaoJogadaJogador == escolhaPedra)
        {
            escolhaJogador = "Pedra";
        }
        else if (opcaoJogadaJogador == escolhaPapel)
        {
            escolhaJogador = "Papel";
        }
        else if (opcaoJogadaJogador == escolhaTesoura)
        {
            escolhaJogador = "Tesoura";
        }


        if (opcaoJogadaComputador == escolhaPedra)
        {
            escolhaComputador = "Pedra";
        }
        else if (opcaoJogadaComputador == escolhaPapel)
        {
            escolhaComputador = "Papel";
        }
        else if (opcaoJogadaComputador == escolhaTesoura)
        {
            escolhaComputador = "Tesoura";
        }

        if (opcaoJogadaJogador == opcaoJogadaComputador)
        {
            System.Console.Write("O jogador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaJogador);
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            System.Console.Write("O computador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaComputador);
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine();

            System.Console.WriteLine("Empate");

        }
        else if (opcaoJogadaJogador == escolhaPedra && opcaoJogadaComputador == escolhaPapel)
        {
            System.Console.Write("O jogador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaJogador);
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            System.Console.Write("O computador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaComputador);
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine();

            System.Console.WriteLine("Jogador Perdeu");
        }
        else if (opcaoJogadaJogador == escolhaPedra && opcaoJogadaComputador == escolhaTesoura)
        {
            System.Console.Write("O jogador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaJogador);
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            System.Console.Write("O computador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaComputador);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine();

            System.Console.WriteLine("Jogador Venceu");
        }
        else if (opcaoJogadaJogador == escolhaPapel && opcaoJogadaComputador == escolhaTesoura)
        {
            System.Console.Write("O jogador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaJogador);
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            System.Console.Write("O computador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaComputador);
            Console.ForegroundColor = ConsoleColor.Red;

            System.Console.WriteLine();
            System.Console.WriteLine("Jogador Perdeu");
        }
        else if (opcaoJogadaJogador == escolhaPapel && opcaoJogadaComputador == escolhaPedra)
        {
            System.Console.Write("O jogador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaJogador);
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            System.Console.Write("O computador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaComputador);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine();

            System.Console.WriteLine("Jogador Venceu");
        }
        else if (opcaoJogadaJogador == escolhaTesoura && opcaoJogadaComputador == escolhaPedra)
        {
            System.Console.Write("O jogador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaJogador);
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            System.Console.Write("O computador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaComputador);
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine();

            System.Console.WriteLine("Jogador Perdeu");
        }
        else if (opcaoJogadaJogador == escolhaTesoura && opcaoJogadaComputador == escolhaPapel)
        {
            System.Console.Write("O jogador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaJogador);
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            System.Console.Write("O computador jogou ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(escolhaComputador);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine();

            System.Console.WriteLine($"Jogador Venceu ");
        }


    }

    private static bool JogarNovamente()
    {
        System.Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.Write("Deseja jogar novamente? (");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.Write("s");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.Write("/");
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.Write("N");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine(")");

        string? desejaJogarNovamente = Console.ReadLine()?.ToUpper();


        if (desejaJogarNovamente != "S")
        {
            return false;
        }
        return true;
    }
}







