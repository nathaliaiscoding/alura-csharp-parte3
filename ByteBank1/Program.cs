using System;
using ByteBank1.Funcionarios;
using ByteBank1.Sistemas;

namespace ByteBank1
{
    class Program
    {

        public static void UsarSistema() {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("454.658.147-33");
            roberta.Nome = "Roberta";  
            roberta.Senha = "123";

            GerenteDeConta thalita = new GerenteDeConta("154.358.947-21");
            thalita.Nome = "Thalita";   
            thalita.Senha = "abc" ;

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(thalita, "acb");
        
    }

        static void Main(string[] args)
        {                      
/*          GerenciadorBonificacoes gerenciadorBonificacao = new GerenciadorBonificacoes();

            Funcionario carlos = new Designer("546.879.157-20");
            carlos.Nome = "Carlos";                        
            
            Auxiliar nathalia = new Auxiliar("154.358.947-21");
            nathalia.Nome = "Nathalia";              

            gerenciadorBonificacao.Registrar(carlos);      
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(thalita);
            gerenciadorBonificacao.Registrar(nathalia);
            
            Console.WriteLine("Total de bonificações: R$" + gerenciadorBonificacao.GetTotalBonificacao());
  */         UsarSistema();
             Console.ReadLine(); 
        }
    }   
}
