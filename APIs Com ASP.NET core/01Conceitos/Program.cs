
namespace _01Conceitos;

public class Program
{
    public static void Main(string[] args)
    {
       // Cria e configura o objeto `WebApplicationBuilder`, que é usado para configurar os serviços e o pipeline de solicitação HTTP.
var builder = WebApplication.CreateBuilder(args);

// Configura os serviços necessários para a aplicação. 
// `AddControllers` adiciona suporte para controllers MVC, o que permite criar endpoints de API e renderizar views.
builder.Services.AddControllers();

// Constrói o objeto `WebApplication` com base nas configurações fornecidas e no contêiner de serviços configurado.
var app = builder.Build();

// Mapeia os controllers para os endpoints disponíveis na aplicação.
// Isso faz com que os controllers sejam acessíveis através das rotas definidas nas suas classes de controller.
app.MapControllers();

// Inicia a aplicação e começa a escutar as solicitações HTTP.
app.Run();
    }
}
