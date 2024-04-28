using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Operacoes
{
    public class Subtrair
    {
        #region Subtracao
        public static float Subtracao(float x, float y)
        {
            do
            {
                float result = 0;
                try
                {
                    result = x - y;
                
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Por favor, verifique os valores adicionados!");
                    if(x == 0 || x == null)
                    {
                        x = float.Parse(Console.ReadLine());
                    }
                    else
                    {
                        y = float.Parse(Console.ReadLine());
                    }
                }
                return result;
            } while ((x == 0 && x == null) || (y == 0 || y == null));
        }
        #endregion
    }
}