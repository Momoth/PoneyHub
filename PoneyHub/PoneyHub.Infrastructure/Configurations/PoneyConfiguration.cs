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

            builder.HasData(new List<Poney>
            {
                new Poney { Id = 1, Nom = "Karim", Description = "Aime quand y'a plein de couleur de partout", CategorieId = 3, Photo = "", Coefficient = 1 },
                new Poney { Id = 2, Nom = "Matthieu", Description = "Aime se poser dans l'herbe, la brouter et prendre son temps", CategorieId = 1, Photo = "", Coefficient = 1 },
                new Poney { Id = 3, Nom = "Valentin", Description = "Préfère rester dans son coin mais prend des coups de folie par moment", CategorieId = 1, Photo = "", Coefficient = 1 },
                new Poney { Id = 4, Nom = "Fabrice", Description = "Adore quand ca danse et que ca se frotte", CategorieId = 2, Photo = "", Coefficient = 25 },
                new Poney { Id = 5, Nom = "Sylvain", Description = "Deteste quand ça parle trop et préfere se focus sur l'action", CategorieId = 1, Photo = "", Coefficient = 1 },
                new Poney { Id = 6, Nom = "Elric", Description = "Vieux poney qui a ses petites habitudes mais très gentil", CategorieId = 1, Photo = "", Coefficient = 1 },
                new Poney { Id = 7, Nom = "Kevin", Description = "Petit poney qui adore l'argent, et est parfait pour aller récolter les impots", CategorieId = 1, Photo = "", Coefficient = 1 },
            });
        }
    }
}