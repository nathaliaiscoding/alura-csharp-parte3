using System;
using ByteBank1.Funcionarios;

namespace ByteBank1
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacoes gerenciador = new GerenciadorBonificacoes();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor(5000, "454.658.147-33");
            roberta.Nome = "Roberta";        
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine("Total de bonificações: R$" + gerenciador.GetTotalBonificacao());
            Console.ReadLine(); 
        }
    }
}
