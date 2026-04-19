namespace ComparacaoString;

class Program
{
    static void Main(string[] args)
    {
        /*var texto = "Leonardo";

        if (texto.CompareTo("Leo") == 0)
        {
            Console.WriteLine("A palavra Existe");
        }
        else
        {
            Console.WriteLine("A palavra não existe");
        }*/

        // ===========================================

        //var frase = "O rato roeu a roupa do rei de roma";

        //Console.WriteLine(texto.StartsWith("o"));
        //Console.WriteLine(texto.EndsWith("a"));
        //Console.WriteLine(texto.StartsWith("O"));
        //Console.WriteLine(texto.EndsWith("A"));


        var senhaCriada = "admin123@";
        var usuario = "leonardo";

        /*Console.WriteLine("Digite a senha fornecida pela empresa");
        var senhaDigitada = Console.ReadLine();

        if (senhaDigitada.Equals(senhaCriada)){
            Console.WriteLine("Acesso Permitido");
        }else
        {
            Console.WriteLine("Acesso Negado");
        }*/

        Console.WriteLine("Digite seu usuário: ");
        var usuarioNovo = Console.ReadLine();

        if (usuarioNovo.Equals(usuario, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Acesso Permitido");
        }
    }
}
