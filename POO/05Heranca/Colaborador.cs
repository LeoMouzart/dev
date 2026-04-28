class Colaborador: Pessoa
{
    private string? _cargo;
    private double _salario;


    // Método Construtor

    public Colaborador(string nome, int idade, string cargo, double salario): base(nome,idade)
    {
        
        this._cargo = cargo;
        this._salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();
    }



    // Metodos para apresentar os dados

    private void ApresentarColaborador()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Salario: {_salario}");

    }
}