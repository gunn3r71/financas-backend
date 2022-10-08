using Financas.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApiConfiguration();

var app = builder.Build();
app.UseApiConfiguration();
app.MapControllers();
app.Run();