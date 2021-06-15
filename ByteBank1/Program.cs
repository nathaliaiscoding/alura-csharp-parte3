using System;
using ByteBank1.Funcionarios;

namespace ByteBank1
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacoes gerenciadorBonificacao = new GerenciadorBonificacoes();

            Funcionario carlos = new Designer("546.879.157-20");
            carlos.Nome = "Carlos";


            Funcionario roberta = new Diretor("454.658.147-33");
            roberta.Nome = "Roberta";  
                        
            
            Funcionario thalita = new GerenteDeConta("154.358.947-21");
            thalita.Nome = "Thalita";        
            

            Funcionario nathalia = new Auxiliar("154.358.947-21");
            nathalia.Nome = "Nathalia";        

            gerenciadorBonificacao.Registrar(carlos);      
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(thalita);
            gerenciadorBonificacao.Registrar(nathalia);
            
            Console.WriteLine("-----------------------");
            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine("-----------------------");
            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine("-----------------------");
            Console.WriteLine(thalita.Nome);
            Console.WriteLine(thalita.GetBonificacao());
            Console.WriteLine("-----------------------");   
            Console.WriteLine(nathalia.Nome);
            Console.WriteLine(nathalia.GetBonificacao());
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Total de bonificações: R$" + gerenciadorBonificacao.GetTotalBonificacao());
            Console.ReadLine(); 
        }
    }
}
