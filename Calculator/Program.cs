using System.Data;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {

        Menu();
        

    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("\nQual a Operação deseja executar");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("Selecione uma opção: ");
        Console.WriteLine("Digite uma opção: ");
        short opcao = short.Parse(Console.ReadLine());


        switch (opcao)
        {
            case 1: Soma();break;
            case 2: Subtracao(); break;
            case 3: Divisao();break;
            case 4: Multiplicacao();break;
            case 0: System.Environment.Exit(0);break;
            default: Menu();break;
        }



    }

    static void Soma()

    {
        Console.Clear(); // Função built-in que linpa a tela
        Console.WriteLine("\nPrimeiro Valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = valor1 + valor2;

        Console.WriteLine($"O resultado da soma é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("\nDigite o primeiro Valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o segundo Valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = valor1 - valor2;

        Console.WriteLine($"O resultado é:  {resultado}");
        Console.ReadKey();
        Menu();
    }


    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("\nDigite o primeiro Valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o segundo Valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");


        

        if (valor2 == 0)
        {
            Console.WriteLine("Impossivel dividir qualquer número por 0");
            Console.ReadKey();
            Menu();
        }
        else
        {
            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado é:  {resultado}");
            Console.ReadKey();
        }
        Menu();

        
        
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("\nDigite o primeiro Valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o segundo Valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = valor1 * valor2;

        Console.WriteLine($"O resultado é:  {resultado}");
        Console.ReadKey();
        Menu();
    }



}
