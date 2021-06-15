using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank1.Sistemas;

namespace ByteBank1.Funcionarios
{
    public class Diretor : Autenticavel
    {
   
        public Diretor(string cpf) : base(5000, cpf) {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
