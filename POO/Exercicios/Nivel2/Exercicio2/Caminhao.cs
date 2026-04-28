class Caminhao : Veiculo
{

    private int _kmRodados;
    private string _cor;


    public Caminhao(string marca, string modelo, int anoFabricacao, int kmrodados, string cor ) : base(marca, modelo, anoFabricacao)
    {
        this._kmRodados = kmrodados;
        this._cor = cor;
    }

       public override void Mover()
    {
        Console.WriteLine("Fuooooooon");
    }


    
    public override void FichaTecnica()
    {
        Console.WriteLine("============================\n");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano de Fabricação: {AnoFabricacao}");
        Console.WriteLine($"Km Rodados: {_kmRodados} KM");
        Console.WriteLine($"Cor: {_cor}\n");
        Console.WriteLine("============================");
    }
}