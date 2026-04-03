using System.Data;
using System.Threading;
namespace StopWach;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Thread.Sleep(500);
        Console.WriteLine("=====================Cronômetro Vida Maneira====================");
        Thread.Sleep(500);
        Console.WriteLine("S - Segundos");
        Thread.Sleep(500);
        Console.WriteLine("M- Minutos");
        Thread.Sleep(500);
        Console.WriteLine("0 - SAIR");
        Thread.Sleep(500);
        Console.WriteLine("Quanto tempo deseja contar? ");
        string data = Console.ReadLine().ToLower(); // Converte o valor digitado para minusculo.
        char type = char.Parse(data.Substring(data.Length-1,1));
        int time = int.Parse(data.Substring(0, data.Length -1));

        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;
        
        if (time == 0)
            System.Environment.Exit(0);

        Start(time * multiplier);

    }


    static void Start(int time)
    {
        
        int currentTime = time;
        while (currentTime >= 0)
        {
            Console.Clear();
            Console.WriteLine(currentTime);
            currentTime --;
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Temporizador finalizado....");
        Thread.Sleep(2500);
        Menu();
    }
}
