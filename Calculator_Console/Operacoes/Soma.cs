using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console.Operacoes
{
    public class Soma : OperadoresI
    {
        public float Num1 { get; set; }
        public float Num2 { get; set; }
        public float Result { get; set; }

        public Soma(float num1, float num2) : base(num1, num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public float Somas()
        {
            
            Result = this.Num1 + this.Num2;
            return (float)this.Result;
          
        }
    }
}
