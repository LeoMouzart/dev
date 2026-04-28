namespace _04Estatico;

class Program
{
    static void Main(string[] args)
    {
        //Consultando valor do atributo
       Console.WriteLine($"O numero atribuido é {Calculadora.numero}");
        // Realizando a soma com o metodo estatico
       Calculadora.Soma(100,200);
    }
}
