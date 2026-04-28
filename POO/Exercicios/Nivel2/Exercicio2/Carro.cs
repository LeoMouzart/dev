using System.Security.Cryptography.X509Certificates;

class Carro : Veiculo 
{
    private int _kmRodados;
    private int _numeroPortas;



    public Carro(string marca, string modelo, int anoFabricacao, int kmrodados, int numeroPortas) : base(marca, modelo, anoFabricacao)
    {
        
        this._kmRodados = kmrodados;
        this._numeroPortas = numeroPortas;

    }

    public override void Mover()
    {
        Console.WriteLine("Vruuuuuuuuuuuuuuuuum");
    }


    public override void FichaTecnica()
    {
        Console.WriteLine("============================\n");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano de Fabricação: {AnoFabricacao}");
        Console.WriteLine($"Km Rodados: {_kmRodados} KM");
        Console.WriteLine($"Numero de Portas: {_numeroPortas}\n");
        Console.WriteLine("============================");
    }
}