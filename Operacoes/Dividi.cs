using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Operacoes
{
    public class Dividi
    {
        #region Dividir
        public static float Dividir(float x, float y)
        {
            do
            {
                float result = 0;
                try
                {
                    result = x / y;
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Por favor, certifiquesse se todos os campos estão preenchidos corretamente!");
                    if(x == 0 && x == null)
                    {
                        x = float.Parse(Console.ReadLine());
                    }
                    else
                    {
                        y = float.Parse(Console.ReadLine());
                    }
                }
                return result;
            }
            while ((x == 0 && x == null) || (y == 0 && y == null));
        }
        #endregion
    }
}