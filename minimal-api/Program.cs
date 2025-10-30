using minimal_api.Dominio.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO longinDTO) =>
{
    if(longinDTO.email == "adm@teste.com" && longinDTO.senha == "123456")
    {
        return Results.Ok("Login realizado com sucesso!");
    } else
    {
        return Results.Unauthorized();
    }
});

app.Run();



