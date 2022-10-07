using Financas.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


var app = builder.Build();

app.UseApiConfiguration();
app.MapControllers();
app.Run();
