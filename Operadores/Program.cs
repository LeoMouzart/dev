using System.ComponentModel;

namespace Operadores;

class Program
{
    static void Main(string[] args)
    {
        int idade = 18;
        bool habilitacao = true;

        if (idade >= 18 && habilitacao == true)
        {
            Console.WriteLine("Pode dirigir");
        }else
        {
            Console.WriteLine("Não pode dirigir");
        }



    }
}
