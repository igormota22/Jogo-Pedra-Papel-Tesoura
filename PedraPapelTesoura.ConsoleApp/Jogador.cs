class Jogador
{

    static public int opcaoJogada = 0;

    public static void FazerJogada()
    {
        System.Console.WriteLine("1 - Pedra");
        System.Console.WriteLine("2 - Papel");
        System.Console.WriteLine("3 - Tesoura");
        System.Console.Write("Escolha sua jogada: ");
        opcaoJogada = Convert.ToInt32(Console.ReadLine());

        if (opcaoJogada != 1 && opcaoJogada != 2 && opcaoJogada != 3)
        {
            System.Console.WriteLine("Escolha uma opção valida");
            Console.ReadLine();

        }
    }
}






