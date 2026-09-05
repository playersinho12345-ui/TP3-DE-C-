using TP3_C_.models;

namespace TP3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro jeep = new Carro();
            jeep.modelo = "Jeep";
            jeep.nome = "Jeep Wrangler";
            jeep.exibirInformacoes();
        }
    }
}
