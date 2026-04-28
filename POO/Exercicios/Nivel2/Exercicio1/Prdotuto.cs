class Produto
{
    private string? _nome;
    private double _preco;

    private int _quantidade; 


    // Construtor 

    public Produto(string Nome, double Preco, int Quantidade)
    {
        this._nome = Nome;
        this._preco = Preco;
        this._quantidade = Quantidade;
    }

    public void AplicaDesconto(double percentual)
    {
        if(percentual <=0 || percentual > 100)
        {
            Console.WriteLine("Percentual Invalido");
        }
        else
        {
            double valorProduto = _preco;
            double desconto = valorProduto * (percentual / 100);
            double novoPreco = valorProduto - desconto;
            _preco = novoPreco;    
        }
        

    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {_nome}");
        Console.WriteLine($"Preço: R${_preco:F2}");
        Console.WriteLine($"Quantidade: {_quantidade}");


    } 

}


