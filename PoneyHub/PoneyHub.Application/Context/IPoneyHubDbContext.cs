using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

using PoneyHub.Domain.Entities;

namespace PoneyHub.Application.Context
{
    public interface IPoneyHubDbContext
    {
        DbSet<Poney> Poneys { get; set; }
        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        EntityEntry Remove(object entity);
    }
}