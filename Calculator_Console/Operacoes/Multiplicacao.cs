using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console.Operacoes
{
    public class Multiplicacao : OperadoresI
    {
        public Multiplicacao(float num1, float num2) : base(num1,num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public float Multiplicar()
        {
            Result = this.Num1 * this.Num2;
            return Result;
        }
    }
}
