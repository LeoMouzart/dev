class Pessoa
{
    private string? _nome;
    private int _idade;


    public string? Nome
    {
        get{return _nome;}
        set{_nome = value;}

    }

    public int Idade
    {
        get
        {
            return _idade;
        }

        set
        {
            if (value >0)
            {
                _idade = value;
            }
            else
            {
                Console.WriteLine("Impossivel Cadastrar uma idade menor que 0");
            }
        }
    }

    public void  Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
    }

}