namespace InterpolacaoString;

class Program
{
    static void Main(string[] args)
    {
        var price = 10.2;
        
        var texto = string.Format("O preço do produto é {0} apenas na promoção", price);

        var texto2 = $"O preço do produto é {price}, só na promoção";

        Console.WriteLine(texto);
        Console.WriteLine(texto2);

    }
}
