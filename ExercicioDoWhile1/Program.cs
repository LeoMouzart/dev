namespace ExercicioDoWhile1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Crie sua senha numérica: ");
        int senhaCriada = int.Parse(Console.ReadLine());
        
        
        
        
        do
        {
            Console.WriteLine("Digite sua senha: ");
            int senhaUsuario = int.Parse(Console.ReadLine());   

        }while(senhaUsuario != senhaCriada);
    }
}
