namespace ExercicioCondicional2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o dia da semana");
        int dia = int.Parse(Console.ReadLine());

        switch(dia)
        {
            case 1: Console.WriteLine ($"Dia {dia}: Hoje é Domingo"); break;
            case 2: Console.WriteLine ($"Dia {dia}: Hoje é Segunda Feira"); break;
            case 3: Console.WriteLine ($"Dia {dia}: Hoje é Terça Feira"); break;
            case 4: Console.WriteLine ($"Dia {dia}: Hoje é Quarta-Feira"); break;
            case 5: Console.WriteLine ($"Dia {dia}: Hoje é Quinta-Feira"); break;
            case 6: Console.WriteLine ($"Dia {dia}: Hoje é Sexta-Feira"); break;
            case 7: Console.WriteLine ($"Dia {dia}: Hoje é Sabado"); break;
            default: Console.WriteLine ($"Dia {dia}: Não existe no calendário!!"); break;
        }
    }
}
