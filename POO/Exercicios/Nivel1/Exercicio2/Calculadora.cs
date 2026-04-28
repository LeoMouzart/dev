class Calculadora
{       
    public static double Somar(double a, double b)
    {
        return a + b;
    }


    public static double subtrair(double a, double b)
    {
        return a - b;
    }


    public static double multiplicar (double a, double b)
    {
        return a + b;


    }


    public static double Dividir(double a, double b)


    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Impossivel Realizar uma divisão por 0");
            return 0;
        }
        
    }
}