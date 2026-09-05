using exercicio10ao12.models;

namespace exercicio10ao12
{
    internal class TestaFigruas
    {
        static void Main(string[] args)
        {
            Circulo circulo1 = new Circulo();
            circulo1.Raio = 1;

            System.Console.WriteLine(circulo1.CalcularArea());

            Esfera esfera1 = new Esfera();
            esfera1.Raio = 2;

            System.Console.WriteLine(esfera1.CalcularVolume());


                
        }
    }
}
