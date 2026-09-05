using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício2ao6.models
{
    public class Ingresso
    {
        public string nomeDoshow; /// Importante para estar ciente sobre qual show está se falando.
        public double preco; /// Essencial para manipular o preço dos ingressos daquele show.
        public int quantidadeDisponivel; /// Indispensável para controle do número de ingressos disponíveis.

        public Ingresso(string nomeDoshow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoshow = nomeDoshow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        public void AlterarPreco(double NovoPreco)
        {
            this.preco = NovoPreco;
        }

        public void AlterarQuantidade(int NovaQuantidade)
        {
            this.quantidadeDisponivel = NovaQuantidade;
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine("Nome do Show: " + nomeDoshow);
            System.Console.WriteLine("Preço: " + preco);
            System.Console.WriteLine("Quantidade disponível: " +  quantidadeDisponivel);
        }


        public String Getnome()
        {
            return nomeDoshow;
        }

        public Double Getpreco()
        {
            return preco;
        }

        public int GetquantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        public void SetnomeDoshow(string nomeDoshow)
        {
            this.nomeDoshow= nomeDoshow;
        }

        public void Setpreco(double preco)
        {
            this.preco = preco;
        }

        public void SetquantidadeDisponivel( int quantidadeDisponivel)
        {
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

    }
}
