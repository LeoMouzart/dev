class Moto : Veiculo
{

    private string _pneu;
    private string _cor;


    public Moto(string marca, string modelo, int anoFabricacao, string pneu, string cor ) : base(marca, modelo, anoFabricacao)
    {
        this._pneu = pneu;
        this._cor = cor;
    }

       public override void Mover()
    {
        Console.WriteLine("Ran dan dan");
    }


    
    public override void FichaTecnica()
    {
        Console.WriteLine("============================\n");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano de Fabricação: {AnoFabricacao}");
        Console.WriteLine($"Fabricante dos Pneus: {_pneu}");
        Console.WriteLine($"Cor: {_cor}\n");
        Console.WriteLine("============================");
    }
}