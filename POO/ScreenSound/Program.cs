namespace ScreenSound;

class Program
{
    static void Main(string[] args)
    {
        Musica  musica1 = new Musica();

        musica1.Nome = "Obras de Poeta";
        musica1.Artista = "Chitãozinho & Xororó";
        musica1.Duracao = 3;
        musica1.Disponivel = true;
        

        // --------------------------------------------------------------------------------------//

        Musica musica2 = new Musica();

        musica2.Nome = "Leave Before You Love me";
        musica2.Artista =  "Jonas Brothers";
        musica2.Duracao = 3;
        musica2.Disponivel = false;

       


        Console.Clear();
        Console.WriteLine(musica1.DescricaoResumida);


        
    }
}


