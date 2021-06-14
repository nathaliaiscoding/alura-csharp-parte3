using System;
using ByteBank1.Funcionarios;

namespace ByteBank1
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacoes gerenciador = new GerenciadorBonificacoes();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.147-33";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine("Total de bonificações: R$" + gerenciador.GetTotalBonificacao());
            Console.ReadLine(); 
        }
    }
}
