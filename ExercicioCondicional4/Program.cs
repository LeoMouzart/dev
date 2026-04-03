/*  
Validação de Acesso: 
Crie um programa que receba a idade de um usuário e uma variável 
booleana indicando se ele possui autorização dos pais. 
O programa deve exibir "Acesso Permitido" se a idade for maior ou igual a 18 OU se ele tiver autorização.
 Caso contrário, exiba "Acesso Negado".

*/


using System.Net.Security;

namespace ExercicioCondicional4;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Digite o seu nome ");
        string nome =  Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        bool possuiAutorizacao;

       

        if (idade >= 18)
        {
            possuiAutorizacao = true;
            Console.WriteLine($"Olá {nome}, você é maior de idade. Seja bem vindo!!");


        }
        else
        {
            Console.WriteLine($"{nome}, você necessita de uma autorização dos pais. Eles te autorizam a acessar? S/N ");
            char autorizacaoPais = char.Parse(Console.ReadLine());

            switch (autorizacaoPais)
            {
                case 's': Console.WriteLine("Acesso Concedido");break;
                case 'n': Console.WriteLine("Acesso Negado"); break;
                default: Console.WriteLine("Opção Inválida Adeus");break; 
            }

        }
        Console.WriteLine("Obrigado Por usar nosso sistema");

    }
}
