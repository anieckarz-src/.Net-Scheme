using Microsoft.EntityFrameworkCore;

namespace Scheme.Infrastructure.Database.Context;

public class Context : DbContext, IContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    
    //Sets from Interface
    
    //On model creating
}