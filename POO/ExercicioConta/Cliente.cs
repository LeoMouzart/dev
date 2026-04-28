
class Cliente
{
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Email {get; set; }
    public string Telefone{get;set;}


  public void AtualizarEmail(string novoEmail)
    {
        if (novoEmail.Contains("@")) // Validação básica
        {
            this.Email = novoEmail; 
        }
        else 
        {
            Console.WriteLine("Erro: E-mail inválido!");
        }
    }

    public void AtualizarTelefone(string novoTelefone)
    {
        if (novoTelefone.Length == 12)
        {
            this.Telefone = novoTelefone;
        }
        else
        {
            Console.WriteLine("Telefone invalido");
        }
    }


    public string ExibirCartaoUsuario()
    {
        return $"Nome: {Nome}\nCPF: {Cpf}\nEmail: {Email}\n Telefone: {Telefone}"; 
    }

    
}