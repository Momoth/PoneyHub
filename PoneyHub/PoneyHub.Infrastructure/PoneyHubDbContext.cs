using Microsoft.EntityFrameworkCore;

using PoneyHub.Application.Context;
using PoneyHub.Domain.Entities;

using System.Reflection;

namespace PoneyHub.Infrastructure
{
    public class PoneyHubDbContext : DbContext, IPoneyHubDbContext
    {
        public PoneyHubDbContext(
            DbContextOptions<PoneyHubDbContext> options) : base(options) { }

        public DbSet<Poney> Poneys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}