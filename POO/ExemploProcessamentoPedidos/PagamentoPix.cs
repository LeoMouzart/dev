class PagamentoPix : Pagamento 
{
    public PagamentoPix(double valor): base(valor){}

    public override void Processar()
    {
        Console.WriteLine("Gerando QR Code Pix");
        Console.WriteLine($"Aguardando a tranferência de valor {Valor}");
    }
}