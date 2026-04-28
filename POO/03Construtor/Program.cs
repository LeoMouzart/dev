namespace _03Construtor;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new("João Lucas", 11);
        Pessoa p2 = new("Leonardo Mouzart", 32);


        Console.WriteLine(p2);
        Console.WriteLine(p1);
    }
}
