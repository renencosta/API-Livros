using ProjetoLivros.Context;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//dotnet ef migrations add Initial
//dotnet ef database update
builder.Services.AddDbContext<LivrosContext>();

app.Run();
