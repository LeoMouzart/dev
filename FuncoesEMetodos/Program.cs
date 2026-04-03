namespace FuncoesEMetodos;

class Program
{
    static void Main(string[] args)
    {
        
        int iniciar ;

        
        do
        {
             Console.WriteLine("Digite um numero: ");
            double n1 = double.Parse(Console.ReadLine());

        
            Console.WriteLine("Digite um numero: ");
            double n2 = double.Parse(Console.ReadLine());

        
            double resultado = CalculaNumero(n1, n2);

            Console.WriteLine($"O Resultado é: {resultado}");

            VerificaResultado(resultado);
            Console.WriteLine("Deseja iniciar a calculadora? ");
            iniciar = int.Parse(Console.ReadLine());

        }while (iniciar !=0);
        
        
       

    }

    static double CalculaNumero(double n1, double n2)
    {
        Console.WriteLine("\nDigite um operador para calculo: +, - , * , /");
        string operador = Console.ReadLine();

        
        switch (operador)
        {
            case "+": 
                return n1 + n2;   
            case "-":
                return n1 - n2;
            case "*":
                return n1* n2;
            case "/":
                if (n2 == 0)
                {
                    Console.WriteLine("Erro Divisão por zero não é permitido!!");
                    return 0;
                }
                return n1 / n2;
            default: Console.WriteLine("Operador Invalido");
            return 0;
             
        }
    }
    

    
    static void VerificaResultado (double resultado)
    {
        if (resultado > 0)
        {
            Console.WriteLine("O resultado é positivo!!");
        }
        else
        {
            Console.WriteLine("Resultado é negativo");
        }
    }


}
