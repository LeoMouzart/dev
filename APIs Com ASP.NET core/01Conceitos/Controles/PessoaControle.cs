using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("pessoa")]
public class PessoaControle : ControllerBase
{
    [HttpGet]
    public string MinhaPrimeiraRota()
    {
        return "Atualizando rota";
    }

    [HttpPost]
    public Pessoa ManipularModeloPessoa([FromBody] Pessoa p)
    {
        return p;
    }

}