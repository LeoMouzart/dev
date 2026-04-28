using System.Net.Http.Headers;

class Aluno
{
    public string? Nome {get; set;}
    public double N1 {get;set;}
    public double N2 {get;set;}
    public double N3 {get;set;}
    public double N4 {get;set;}

    public double Media {get;set;}

    private double CalculaMedia()
    {
        Media = (N1 + N2 + N3 + N4) / 4;
        return Media;
    }

    private string SituacaoAluno()
    {
        if(Media >= 7)
        {
            return $"APROVADO!";
        }
        else
        {
            return $"Reprovado";
        }
    }


    public void Mensagem()
    {
        Console.WriteLine($"Aluno: {Nome}\nMédia: {CalculaMedia():F2}\nSituação: {SituacaoAluno()}");
    }

}