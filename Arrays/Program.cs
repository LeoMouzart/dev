namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var meuArray = new int[5];

        Console.WriteLine("Digite o valor da posição 1");
        meuArray[0] = int.Parse(Console.ReadLine());


        Console.WriteLine(meuArray[0]);

    }
}
