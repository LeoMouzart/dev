namespace Conversao;

class Program
{
    static void Main(string[] args)
    {

        int inteiro = 100;
        float real = 25.5f;


       inteiro = Convert.ToInt32(real);

       Console.WriteLine(inteiro);

    }
}
