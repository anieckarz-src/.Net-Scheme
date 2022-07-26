namespace Scheme.Infrastructure.Database.Context;

public interface IContext
{
    // DbSets with all the entities
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}