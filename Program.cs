using ProjetoLivros.Context;
using ProjetoLivros.Interfaces;
using ProjetoLivros.Repositories;

var builder = WebApplication.CreateBuilder(args);

//avisa que a aplicação usa controllers
builder.Services.AddControllers();

//adiciono o Gerador de Swagger
builder.Services.AddSwaggerGen();

//dotnet ef migrations add Initial
//dotnet ef database update
builder.Services.AddDbContext<LivrosContext>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
//builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
//builder.Services.AddScoped<ILivroRepository, LivroRepository>();
//builder.Services.AddScoped<IAssinaturaRepository, AssinaturaRepository>();
//builder.Services.AddScoped<ITipoUsuarioRepository, TipoUsuarioRepository>();
var app = builder.Build();

//avisa o .Net que eu tenho Controladores
app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});





app.Run();
