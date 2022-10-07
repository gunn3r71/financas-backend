using System.Reflection;
using System.Reflection.Metadata;
using Microsoft.OpenApi.Models;

namespace Financas.Api.Configuration;

public static class SwaggerConfig
{
    public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(x =>
        {
            x.SwaggerDoc("Financas.API", new OpenApiInfo()
            {
                Title = "Financas.API",
                Description = "Api para controle de finanças",
                Version = "V1.0.0",
                Contact = new OpenApiContact()
                {
                    Email = "lucas.p.oliveira@outlook.pt",
                    Name = "Lucas Pereira"
                },
                License = new OpenApiLicense()
                {
                    Name = "MIT"
                },
            });
        });

        return services;
    }

    public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }
}