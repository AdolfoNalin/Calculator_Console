using System;
using System.Data;
using Calculator.Menu;
using Calculator.Operacoes;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            do
            {

                Menu.Menu menu = new Menu.Menu();
                valor = menu.MenuOpeSim();

                if (valor == 0)
                {
                    break;
                }

                List<float> list = menu.ValiMenu(valor);

                float x = list[0];
                float y = list[1];

                switch((MenuE.MenuE)valor)
                {
                    case MenuE.MenuE.Soma:
                        Console.WriteLine($"O resultado é: {Soma.Somar(x,y)}");
                        break;
                    case MenuE.MenuE.Divir:
                        Console.WriteLine($"O resultado é: {Dividi.Dividir(x,y)}");
                        break;
                    case MenuE.MenuE.Sub:
                        Console.WriteLine($"o resultado é: {Subtrair.Subtracao(x,y)}");
                        break;
                    case MenuE.MenuE.Mult:
                        Console.WriteLine($"O resultado é: {Multiplica.Multiplicar(x,y)}");
                        break;
                    default:
                    Console.WriteLine("Por favor, digite um valor válido!");
                    break;
                }
                menu.NewConosole();
            }
            while((MenuE.MenuE) valor != MenuE.MenuE.sair);
        }
    }
}
