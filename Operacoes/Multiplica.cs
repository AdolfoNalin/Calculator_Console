using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Calculator.Operacoes
{
    public class Multiplica
    {
        #region Multiplicacao
        public static float Multiplicar(float x, float y)
        {
            do
            {
                float result = 0;
                try
                {
                    result = x * y;
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor, verifique se todos os campos estão todos preenchitos de forma correta!");
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
            } while ((x == 0 && x == null) || (x == 0 && x == null));
        }
        #endregion
    }
}