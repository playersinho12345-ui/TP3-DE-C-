using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio6ao9.models
{
    public class Matricula
    {
        public String NomeDoAluno;
        public String Curso;
        public int NumeroMatricula;
        public String Situacao; /// Trancado / Ativa / Conluída
        public String DataInicial; /// (DD/MM/YYYY)


        public void Trancar()
        {
            this.Situacao = "Trancado";
        }

        public void Reativar()
        {
            this.Situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine(NomeDoAluno);
            System.Console.WriteLine(Curso);
            System.Console.WriteLine(NumeroMatricula);
            System.Console.WriteLine(Situacao);
            System.Console.WriteLine(DataInicial);

        }




    }
}
