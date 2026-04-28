Console.WriteLine("Digite um número : ");
double n1 = double.Parse(Console.ReadLine());


Console.WriteLine("Digite um número : ");
double n2 = double.Parse(Console.ReadLine());


Console.WriteLine("Digite:\n1 - SOMA\n2 - SUBTRAÇÃO\n3 - MULTIPLICAÇÃO\n4 - DIVISÃO : ");
double opcao = int.Parse(Console.ReadLine());


double resultado;


switch (opcao)
{
    case 1: resultado = Calculadora.Somar(n1,n2);
    Console.WriteLine($"Resultado: {resultado:F2}");
    break;

    case 2: resultado = Calculadora.subtrair(n1,n2);
    Console.WriteLine($"Resultado: {resultado:F2}") ;
    break;

    case 3: resultado = Calculadora.multiplicar(n1,n2);
    Console.WriteLine($"Resultado: {resultado:F2}") ;
    break;
    
    case 4: resultado = Calculadora.Dividir(n1,n2);
    Console.WriteLine($"Resultado: {resultado:F2}"); 
    break;
}


