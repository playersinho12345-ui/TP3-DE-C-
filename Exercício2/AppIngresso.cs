using Exercício2ao6.models;

namespace Exercício2ao6
{
    internal class AppIngresso
    {
        static void Main(string[] args)
        {
            Ingresso Gorillaz = new Ingresso(
                "Gorillaz Insane Show",
                9000.0,
                300
                );

            Gorillaz.AlterarQuantidade(30);
            Gorillaz.AlterarPreco(50);

            Gorillaz.Setpreco(2000);
            Gorillaz.SetnomeDoshow("Gorillaz");
            Gorillaz.SetquantidadeDisponivel(500);

            System.Console.WriteLine(Gorillaz.Getnome());
            System.Console.WriteLine(Gorillaz.Getpreco());
            System.Console.WriteLine(Gorillaz.GetquantidadeDisponivel());
        }
    }
}
