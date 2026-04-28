using System.Data;

namespace _02Encapsulamento;

class Program
{
    static void Main(string[] args)
    {
        //Objeto Aluno
        Aluno aluno1 = new();

        Console.WriteLine("Digite a idade do aluno: ");
        int idd = int.Parse(Console.ReadLine());

        aluno1.Idade  = idd;

        Console.WriteLine(aluno1.Idade);
    }
}
