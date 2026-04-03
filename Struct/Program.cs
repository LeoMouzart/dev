using System.Net.Http.Headers;

namespace Struct;

class Program
{
    static void Main(string[] args)
    {
        var mouse = CadastrarProduto();
        

    }


    static Produto CadastrarProduto()
    {
        Produto p = new Produto();

        Console.WriteLine("Digite o ID do produto: ");
        int id = int.Parse(Console.ReadLine());
        p.Id = id;

        Console.WriteLine("Digite o nome do Produto: ");
        string nome = Console.ReadLine();
        p.Nome = nome;

        Console.WriteLine("Digite o preco do produto:  ");
        double preco = double.Parse(Console.ReadLine());
        p.Preco = preco;

        return p;



    }
}

struct Produto{

    public Produto(int id, string nome, double preco, ETipoProduto tipo)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Tipo = tipo;

    }
    public int Id;
    public string Nome;
    public double Preco;

    public  ETipoProduto Tipo;

    public double PrecoEmDolar(double dolar)
    {
        return Preco * dolar;
    } 
}

enum ETipoProduto
{
    Produto = 1,
    Servico = 2
}
