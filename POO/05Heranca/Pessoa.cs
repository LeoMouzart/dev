class Pessoa
{
    //Atributos

    private string? _nome;
    private int _idade;

    //Construtor 

    public Pessoa(string nome, int idade)
    {
        this._nome = nome;
        this._idade =idade; 
    }


    // Metodos para apresentar os dados
    protected void ApresentarPessoa()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine($"Idade: {_idade}");
    }


}