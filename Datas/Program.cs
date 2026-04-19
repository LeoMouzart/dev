namespace Datas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //var data = DateTime.DaysInMonth(2007,8);
        //Console.WriteLine(data);

        var dataAtual = new DateTime(2026,04,19,08,19,12); // Ano // Mês // Dia
        //Console.WriteLine(dataAtual.Day);
        //Console.WriteLine(dataAtual.Month);
        //Console.WriteLine(dataAtual.Year);
        //Console.WriteLine(dataAtual.DayOfYear);
        //Console.WriteLine(dataAtual);

        var diasAno = 365;

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o dia do seu aniversário: ");
        int dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o mês do seu aniversário: ");
        int mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Ano do seu Nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        var dataNascimento = new DateTime(anoNascimento, mes, dia);
        Console.WriteLine(dataNascimento);


        Console.WriteLine($"Dados Do Usuário: \nNome: {nome}\n Dia De Nascimento {dataNascimento.Day}\nMês do Nascimento: {dataNascimento.Month}\nAno Nascimento: {dataNascimento.Year}");

        if (dataAtual.Day == dataNascimento.Day && dataAtual.Month == dataNascimento.Month)
        {
            Console.WriteLine($"Parabééééns {nome}!!! Hoje é seu aniversário ");
        }
        else
        {
            Console.WriteLine($"{nome} Hoje não é seu aniversário. Faltam {diasAno - dataNascimento.DayOfYear} Dias para o seu aniversário!!");
        }
    }
}
