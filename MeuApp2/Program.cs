using System.IO.Pipes;

namespace MeuApp2; // Namespaces sáo divisões lógicas, 
//O ideal é ter um namespace e uma classe por arquivos.

class Program
{
    static void Main(string[] args)
    {
        string nome = "Leonardo Mouzart"; // String é uma cadeia de caracteres definida por aspas duplas
        char sexo = 'M'; // Char define apenas um caracter atribuido com aspas simples
        int idade = 31; // int trata-se de um valor inteiro positivo ou negativo
        double  altura  = 1.78; // Double é um valor decimal intermediário 

        var cidade = "São Carlos"; // Var define automaticamente o tipo a partir do valor atribuido
        var estado = "SP";
        string? bairro = null; // A atribuição com ? trasta-se de um valor nulo nullable type uma variavel vazia.

        int AnoNascimento = 2025 - 31;

        Console.WriteLine("Sua ano de nascimento é: " + AnoNascimento);
        Console.WriteLine(nome);
        Console.WriteLine(idade + " Anos");
        Console.WriteLine("Sexo: " + sexo);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine(cidade + " " + estado);
        Console.WriteLine(bairro);






    }
}
