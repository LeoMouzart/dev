using System.Reflection;

namespace ExercicioCondicional3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do Cliente: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o valor da compra: ");
        double valorCompra = double.Parse(Console.ReadLine());

        double desconto = 0;
        double valorTotal = 0;

        if (valorCompra <= 100)
        {
            desconto = valorCompra * 0.05;
            valorTotal = valorCompra - desconto;
        } else if (valorCompra  > 100 && valorCompra <= 500)
        {
            desconto = valorCompra * 0.1;
            valorTotal = valorCompra - desconto;
        }
        else
        {
             desconto = valorCompra * 0.15;
             valorTotal = valorCompra - desconto;
        }

        Console.WriteLine($"Nome do Cliente: {nome} \nValor compra: R${valorCompra:F2} \nValor Desconto: R${desconto:F2} \nValor Total: R${valorTotal:F2}");
    }
}
