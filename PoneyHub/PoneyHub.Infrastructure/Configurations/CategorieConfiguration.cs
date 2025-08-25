using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PoneyHub.Domain.Entities;

namespace PoneyHub.Infrastructure.Configurations
{
    public class CategorieConfiguration : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.ToTable(nameof(Categorie));

            builder.Property(p => p.Libelle).HasMaxLength(100).IsRequired();

            builder.HasData(new List<Categorie>
            {
                new Categorie { Id = 1, Libelle = "Terrestre" },
                new Categorie { Id = 2, Libelle = "Licorne" },
                new Categorie { Id = 3, Libelle = "Pégase" }
            });
        }
    }
}