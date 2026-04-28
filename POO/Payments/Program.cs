namespace Payments;

class Program
{
    static void Main(string[] args)
    {
        PagamentoBoleto pagamentoBoleto = new();

        pagamentoBoleto.Vencimento = DateTime.Now;


        Console.WriteLine(pagamentoBoleto.Vencimento);
    }
}
