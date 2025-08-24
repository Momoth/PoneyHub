using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PoneyHub.Domain.Entities;

namespace PoneyHub.Infrastructure.Configurations
{
    public class PrestationConfiguration : IEntityTypeConfiguration<Prestation>
    {
        public void Configure(EntityTypeBuilder<Prestation> builder)
        {
            builder.ToTable(nameof(Prestation));
        }
    }
}