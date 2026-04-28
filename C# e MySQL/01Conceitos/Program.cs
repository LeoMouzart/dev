namespace _01Conceitos;

class Program
{
    static void Main(string[] args)
    {
       // Objeto conexao 
       Conexao c = new();


       // Instanciar um objeto pessoa

       PessoaSQL p = new(c.ObterConexao());

       
    }
}
