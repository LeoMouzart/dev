class Musica
{
    public string Nome {get; set;}
    public string Artista {get; set;}
    public int Duracao {get; set;}
    public bool Disponivel {get;set;}

    public string DescricaoResumida => $"A musica {Nome} pertence ao artista {Artista} ";
    




    public void FichaTecnica()
    {
        Console.WriteLine("=========================");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} minutos");
        Console.WriteLine("=========================");

        
    }
}
