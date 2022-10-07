namespace Financas.Api.Configuration;

public static class ApiConfig
{
    public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
    {
        services.AddControllers();
        
        return services;
    }

    public static IApplicationBuilder UseApiConfiguration(this IApplicationBuilder app)
    {
        app.UseSwaggerConfiguration();
        app.UseHttpsRedirection();
        app.UseAuthentication();
        app.UseAuthorization();

        return app;
    }
}