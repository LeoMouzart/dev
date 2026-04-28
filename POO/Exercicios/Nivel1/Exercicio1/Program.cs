namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new();

        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua Idade: ");
        int idade = int.Parse(Console.ReadLine());


        pessoa1.Nome = nome;

        pessoa1.Idade = idade;

        pessoa1.Apresentar();
    }
}
