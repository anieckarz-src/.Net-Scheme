using Microsoft.AspNetCore.Builder;

namespace Scheme.Infrastructure.Exceptions;

public static class Extensions
{
    public static IApplicationBuilder UseMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
        return app;
    }
}