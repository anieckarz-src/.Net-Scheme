using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scheme.Infrastructure.Database;
using Scheme.Infrastructure.Exceptions;
using Scheme.Infrastructure.Services;

namespace Scheme.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddPostgres(configuration);
        services.AddHostedService<AppInitializer>();
        services.AddScoped<ExceptionMiddleware>();
        return services;
    }
    
}