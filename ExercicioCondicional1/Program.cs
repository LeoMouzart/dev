namespace ExercicioCondicional1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade > 0 && idade <= 12)
        {
            Console.WriteLine($"{nome} é uma criança, sua idade é {idade} anos");
        }else if (idade > 12 && idade <= 17)
        {
            Console.WriteLine($"{nome} é adoslecente, sua idade é {idade} anos");
        }else if(idade > 17 && idade <= 59)
        {
            Console.WriteLine($"{nome} é adulto, sua idade é {idade} anos");
        }
        else
        {
            Console.WriteLine($"{nome} é idoso, sua idade é {idade} anos");
        }
    }
}
