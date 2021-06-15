using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank1.Funcionarios;

namespace ByteBank1.Sistemas
{
   
   public class SistemaInterno {

       public bool Logar(Autenticavel funcionario, string senha) {
           bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Seja bem-vindo(a) ao Sistema!");
                return true;
            } else {
                Console.WriteLine("Senha incorreta.");
                return false;
            }

       }


   }
       
}
