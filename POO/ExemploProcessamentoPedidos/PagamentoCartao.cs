class PagamentoCartao : Pagamento
{
    private string NumeroCartao;
    public PagamentoCartao(double valor, string numero) : base(valor)
    {
        NumeroCartao = numero;
    }

    public override void Processar()
    {
        Console.WriteLine($"Validando cartão: {NumeroCartao}");
        Console.WriteLine($"Debitando R$ {Valor} via Operadora Cartão");
    }
}