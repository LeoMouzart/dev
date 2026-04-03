namespace ExercicioFOR2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite Seu nome de usuário: ");
        string nome = Console.ReadLine();

        int senhaPadrao = 1234;
        bool acessoPermitido = false;

        Console.WriteLine("Digite sua senha: ");
        int senhaUsuario = int.Parse(Console.ReadLine());


        if (senhaUsuario == senhaPadrao)
        {
            acessoPermitido = true;
        }
        else
        {
            for(int i = 1; i<=3; i++)
            {
                Console.WriteLine("Digite novamente a sua senha: ");
                senhaUsuario = int.Parse(Console.ReadLine());
                if(senhaUsuario == senhaPadrao)
                {   
                   acessoPermitido = true;
                   break;
                }
               
            }
        }
        if (acessoPermitido)
        {
            Console.WriteLine($"Olá {nome} seja bem vindo ao sistema!!!");
        }
        else
        {
            Console.WriteLine("Acesso bloqueado por excesso de tentativas.");
        }
    }
}
