using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using PoneyHub.Domain.Entities;

namespace PoneyHub.Application
{
    public interface IPoneyHubDbContext
    {
        DbSet<Poney> Poneys { get; set; }
        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
