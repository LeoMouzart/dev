using System.Runtime.InteropServices;

namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var meuArray = new int[5];


        for(var i =0; i < meuArray.Length; i++)
        {
            
        Console.WriteLine($"Digite o valor da posição {i}");
        meuArray[i] = int.Parse(Console.ReadLine());
        }


        for(var i =0; i<meuArray.Length; i++)
        {
            Console.WriteLine($"Posição {i}: {meuArray[i]} ");
        }



        var total = meuArray.Sum();
        Console.WriteLine($"A soma dos valores é: {total}");

    }
}
