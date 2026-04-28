class Produto
{
    public string? Nome {get; set;}
    public double Valor {get; set;}

    public int FormaDePagamento {get; set;}

    public void Mensagem()
    {
        double valorProduto= Valor;
        if (valorProduto>= 500 && FormaDePagamento == 1)
        {
            double desconto = Valor * 0.1;
            valorProduto -= desconto;
        }
        else
        {
            valorProduto = Valor;
        }

        Console.WriteLine($"Produto: {Nome}\nValor: {valorProduto}");


       
    }
}