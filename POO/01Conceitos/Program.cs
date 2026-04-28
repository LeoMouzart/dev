namespace _01Conceitos;

class Program
{
    static void Main(string[] args)
    {
        //Instanciando  Objetos
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Idade = 16;
        pessoa1.Nome = "Leonardo Mouzart";
        //pessoa1.Apresentacao();

        //Exemplo 2
        Pessoa pessoa2 = new();
        pessoa2.Nome = "João Lucas";

        //Exemplo 3 
        Pessoa pessoa3 = new()
        {
            Nome ="Maria do Carmo",
            Idade = 59
        };

        string retorno = pessoa3.VerificarIdade();
        Console.WriteLine(retorno);



    }
}
