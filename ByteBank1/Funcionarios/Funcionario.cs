using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank1.Sistemas;

namespace ByteBank1.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; } 
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();

         public Funcionario(double salario, string cpf) {
            Salario = salario;
            CPF = cpf;

            TotalFuncionarios++;
    }

        public Funcionario(string cpf) : this(1500, cpf){}
    }

       
}
