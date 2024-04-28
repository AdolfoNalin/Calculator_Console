using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Calculator.Menu
{
    public class Menu
    {
        public int MenuOpeSim()
        {
            Console.WriteLine("Escolha uma opção 1-Somar, 2-Dividir, 3-Subtrção, 4-Multiplicar, 0-Sair");
            int valor= int.Parse(Console.ReadLine());

            return valor;
        }

        public List<float> ValiMenu(int valor)
        {
            List<float> list = new List<float>();
            if(valor >= 1 && valor <= 4)
            {
                float x,y;
                Console.WriteLine("Qual é o primeiro valor?");
                x = float.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o segundo valor?");
                y = float.Parse(Console.ReadLine());

                list.Add(x);
                list.Add(y);

            }
            
            return list;
        }

        public void NewConosole()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}