class Veiculo
{
    protected string? Marca;
    protected string? Modelo;
    protected int AnoFabricacao;


    public Veiculo(string marca, string modelo, int anoFabricacao)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.AnoFabricacao = anoFabricacao;
    }


    public virtual void Mover()
    {
        Console.WriteLine("Veiculo Desconhecido");
    }


    public virtual void FichaTecnica()
    {
        Console.WriteLine("============================");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano de Fabricação: {AnoFabricacao}");
        Console.WriteLine("============================");

    }
}