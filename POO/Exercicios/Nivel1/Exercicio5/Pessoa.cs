class Pessoa
{
    private string? _nome;
    private int _idade;

    private string? _cidade;


    // Método Construtor
    public Pessoa(string nome, int idade, string cidade)
    {
        this._nome = nome;
        this._idade = idade;
        this._cidade = cidade;

        Mensagem();

    }

    // Encapsulamento de atributos privados

    public string? Nome
    {
        get{return _nome;}
        set{_nome = value;}
    }

    public string? Cidade
    {
        get{return _cidade;}
        set{_cidade = value;}
    }

    public int Idade
    {
        get{return _idade;}
        set
        {
            if(value > 0)
            {
                _idade = value;
            }
        }
    }

    // Método privado mensagem
    private void Mensagem()
    {
        Console.WriteLine($"Meu nome é {Nome} tenho {Idade} anos e mora em {Cidade}");
    }


}