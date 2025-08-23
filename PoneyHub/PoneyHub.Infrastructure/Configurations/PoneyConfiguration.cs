using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PoneyHub.Domain.Entities;

namespace PoneyHub.Infrastructure.Configurations
{
    public class PoneyConfiguration : IEntityTypeConfiguration<Poney>
    {
        public void Configure(EntityTypeBuilder<Poney> builder)
        {
            builder.ToTable(nameof(Poney));

            builder.Property(p => p.Nom).HasMaxLength(100).IsRequired();
        }
    }
}