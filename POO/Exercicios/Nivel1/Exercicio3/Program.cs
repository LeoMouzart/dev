namespace Exercicio3;
/*
Atividade: Criar uma Classe Produto contendo atributos:

a - Nome
b -  Valor
c - Forma de pagamento


Haverá um método publico  para retornar essas tres caracteristicas, além de um possivel desconto de 10% se o valor da venda for de pelo menos R$500 e a forma de pagamento a vista


*/



class Program
{
    static void Main(string[] args)
    {
       Produto p1 = new();

       Console.WriteLine("Digite o Nome do Produto: ");
       string pn = Console.ReadLine();

       Console.WriteLine("Digite o valor do Produto: ");
       double vp = double.Parse(Console.ReadLine());


       Console.WriteLine("Digite 1 para a Vista\nDigite 2 para boleto"); 
       int pagamento = int.Parse(Console.ReadLine()); 

       p1.Nome = pn;
       p1.Valor  =vp;
       p1.FormaDePagamento = pagamento;


        p1.Mensagem();
    }
}
