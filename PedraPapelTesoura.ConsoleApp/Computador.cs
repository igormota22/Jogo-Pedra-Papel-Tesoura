using System.Security.Cryptography;

class Computador
{

    static public int opcaoJogada;

    public static void FazerJogada()
    {

        System.Console.WriteLine("Computador escolheu jogada,aperte ENTER para continuar");
        opcaoJogada = RandomNumberGenerator.GetInt32(1, 4);
        Console.ReadLine();
    }
}






