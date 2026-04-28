/*

Crie um sistema simples de cadastro de produtos para uma loja. O programa deve representar um produto com suas características e permitir operações básicas sobre ele.

Requisitos
Crie uma classe Produto com os atributos: Nome, Preco e Quantidade
Os atributos devem ser encapsulados usando propriedades com get e set
Implemente um construtor que inicializa todos os atributos
Crie o método ExibirDetalhes() que imprime as informações do produto formatadas
Crie o método AplicarDesconto(double percentual) que reduz o preço proporcionalmente
No Main, instancie ao menos 2 produtos e demonstre os métodos

*/


namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new("Celular LG", 1899.99, 12);
        Produto p2 = new("Computador Desktop Positivo", 3599.89, 12);


        p1.AplicaDesconto(-2);
        p1.ExibirDetalhes();


        p2.AplicaDesconto(150);
        p2.ExibirDetalhes();
    }
}
