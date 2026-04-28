class Aluno 
{
    // 1ª Maneira de implementar o get e set

    private string? _nome;
    private double _media;
    private int _idade;

    //Getters & Setters
    public string? Nome
    {
        get {return _nome; }
        set {_nome = value; }
    }

    public double Media
    {
        get{return _media;}
        set{
            if(value >= 0 && value<= 10)
            {
                _media = value;   
            }
            }
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
                Console.WriteLine("Impossível atribuir uma idade menor que zero");
            }
        }
    }
    

}