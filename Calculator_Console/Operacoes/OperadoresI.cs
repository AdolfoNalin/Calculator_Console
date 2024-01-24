using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console.Operacoes
{
    public class OperadoresI
    {
        public float Num1 { get; set; }
        public float Num2 { get; set; }
        public float Result { get; set; }
        
        public OperadoresI(float num1, float num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        
    }
}
