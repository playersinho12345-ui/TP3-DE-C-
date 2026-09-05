using exercicio6ao9.models;

namespace exercicio6ao9
{
    internal class TestaMatricula
    {
        static void Main(string[] args)
        {
            Matricula pedro1234 = new Matricula();

            pedro1234.NomeDoAluno = "Pedro Alberto";
            pedro1234.NumeroMatricula = 1;
            pedro1234.Curso = "Engenharia de Software";
            pedro1234.Situacao = "Concluída";
            pedro1234.DataInicial = "13/09/2000";


            pedro1234.Trancar();
            pedro1234.ExibirInformacoes();
            System.Console.WriteLine("");
            pedro1234.Reativar();
            pedro1234.ExibirInformacoes();
        }
    }
}
