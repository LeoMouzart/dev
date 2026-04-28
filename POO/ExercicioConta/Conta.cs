
/*       
Criar uma classe que representa uma conta bancária, com um número indicador , titular , saldo e senha .
Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
Desenvolver um método da classe Conta que exibe suas informações.
*/

class ContaBancaria
{
    public int Id {get; set;}
    public string Titular {get; set;}
    public double Saldo {get; set;}
    public string Senha {get; set;}


    public string ExibirExtrato()
    {
        return $"============================|\nConta: {Id}|\nTitular: {Titular} |\nSaldo: R${Saldo:F2}|\n====================================";
        
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;

        }
        else
        {
            Console.WriteLine($"Saldo indisponível !! Impossível realizar o saque\nSaldo: R${Saldo:F2}");
        }
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine("Depósito Realizado com sucesso");
            Console.WriteLine($"Saldo atualizado: R${Saldo:F2}");
        }
    }




}