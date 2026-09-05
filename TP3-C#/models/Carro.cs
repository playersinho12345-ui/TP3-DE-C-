using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_C_.models
{
    public class Carro /// Classe criada para criar a entidade que representa "Carro".
    {
        public String modelo; /// Ambos são atributos relacionados à classe Carro.
        public String nome;

        public void exibirInformacoes() /// Método criado para exibir as informações do carro
        {
            System.Console.WriteLine("Modelo: " + modelo);
            System.Console.WriteLine("Nome: " + nome);
        }
    }
}

