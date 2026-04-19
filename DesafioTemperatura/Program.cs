using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace DesafioTemperatura;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var temperaturas = new double[7];
        double total = 0;
        
        
       for (var i = 0;i< temperaturas.Length; i++)
        {
            Console.WriteLine($"Digite a temperatura do {i+1}º dia da Semana: ");
            temperaturas[i] = double.Parse(Console.ReadLine());

            total += temperaturas[i];

            Console.WriteLine($"A soma até o momento é: {total:F2}");

        }

        var soma = temperaturas.Sum();
        var media = soma / temperaturas.Length;
        var maior = temperaturas.Max();
        var menor = temperaturas.Min();


        RelatorioTemperaturas(media,maior,menor);
    }

    static void RelatorioTemperaturas (double media, double maior, double menor)
    {
        Console.WriteLine("------------------- Relatorio Semanal ---------------------");
        Console.WriteLine($"Maior Temperatura: {maior:F2}ºC\nMenor Temperatura {menor:F2}ºC\nMédia de Temperatura: {media:F2}ºC");
        Console.WriteLine("--------------------------------------------------------------------");

    }
}
