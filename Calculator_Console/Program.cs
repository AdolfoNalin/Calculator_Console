using Calculator_Console.Operacoes;

char resp;
Console.WriteLine("Olá, seja bem vindo a Calculadora!");
do
{

    Console.WriteLine("Digite o primeiro valor que deseja calcular!");
    float num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor que deseja calcular!");
    float num2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o operador que faça o calcular!");
    char op = Char.Parse(Console.ReadLine());

    switch (op)
    {
        case '+':
            Soma soma = new Soma(num1, num2);
            Console.WriteLine($"O resultado da soma é: {soma.Somas()}");
            break;
        case '-':
            Subtracao sub = new Subtracao(num1, num2);
            Console.WriteLine($"O resultado da Subtração é: {sub.Subtrair()}");
            break;
        case '*':
            Multiplicacao mult = new Multiplicacao(num1, num2);
            Console.WriteLine($"O resultado da Multiplicação é: {mult.Multiplicar()}");
            break;
        case '/':
            Divisao div = new Divisao(num1, num2);
            Console.WriteLine($"O resultado da Divisão é: {div.Dividir()}");
            break;
        default:
            Console.WriteLine("Digite um dos valores correspondendes 'x' para multiplicação; '/' para dividir; '-' para subtrair; '+' para somar");
            op = Char.Parse(Console.ReadLine());
            break;
    }

    Console.WriteLine("Deseja realizar outro calculo? S Para 'Sim' e N para 'Não'");
    resp = Char.Parse(Console.ReadLine());
} while (resp == 'S' || resp == 's');