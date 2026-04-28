abstract class Pagamento
{
    protected double Valor {get;set;}

    public Pagamento(double valor)
    {
        Valor = valor;
    }

    public abstract void Processar();

    public void GerarRecibo()
    {
        Console.WriteLine($"Recibo de R${Valor:F2} gerado com sucesso");
    }
}