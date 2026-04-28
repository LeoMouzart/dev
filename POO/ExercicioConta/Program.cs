
using System.ComponentModel;

// Cadastrando o Cliente
Cliente RealizarCadastro()
{
    Console.Clear();
    Cliente novoCliente = new Cliente();

    Console.WriteLine("Digite o nome do Cliente: ");
    novoCliente.Nome = Console.ReadLine();

    
    try
    {
       Console.WriteLine("Digite o CPF do cliente: "); 
       string cpfDigitado = Console.ReadLine();
       if (cpfDigitado.Length != 11)
        {
            throw new Exception("O CPF digitado deve conter 11 digitos");
        }
        novoCliente.Cpf = cpfDigitado;

    }catch (Exception ex)
    {
        Console.WriteLine($"ERRO DE VALIDAÇÂO: {ex.Message}");
        return null;
    }

    Console.WriteLine("Digite o Email do cliente");
    string emailDigitado = Console.ReadLine();
    if (emailDigitado.Contains("@"))
    {
        Console.WriteLine("Email Válido");
        novoCliente.Email = emailDigitado;
    }
    else
    {
        Console.WriteLine("O email inválido");
    }


    Console.WriteLine("Digite o telefone do cliente: ");
    string telefoneDigitado = Console.ReadLine();

    if(telefoneDigitado.Length == 11)
    {
        Console.WriteLine("Telefone Válido");
        novoCliente.Telefone = telefoneDigitado;
    }
    else
    {
        Console.WriteLine("Telefone inválido");
    }
    Console.WriteLine("Cadastro Realizado Com Sucesso");
    return novoCliente;
    

}



Console.WriteLine("Olá bem vindo ao sistema de Cadastro Bancario");
Cliente cliente1 = RealizarCadastro();
Console.Clear();

string cartaoUsuario = cliente1.ExibirCartaoUsuario();
Console.WriteLine(cartaoUsuario);


// Criando a Conta








