class Pessoa
{
    private string? _nome;
    private int _idade;


    public Pessoa(string nome, int idade)// Método Construtor ára que a classe não instancie um objeto com atributo vazio
    {
        this.Nome = nome ;
        this.Idade = idade;
        
        Console.WriteLine($"Olá {nome}, sua idade é {idade}");
    }

    // Encapsulamento de atributos da classe

    public string? Nome
    {
        get{return _nome;}
        set{_nome = value;}
    }

    public int Idade
    {
        get{return _idade;} 
        set
        {
            if (value > 0)
            {
                _idade = value;
            }
            else
            {
                Console.WriteLine("Impossivel Setar uma idade menor que 0");
            }
        }
    }



}