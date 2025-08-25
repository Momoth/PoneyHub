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

            builder.HasData(new List<Prestation>()
            {
                new Prestation { Id = 1, DateHeureDebut = new DateTime(2025, 08, 25, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 500, PoneyId = 1 } ,
                new Prestation { Id = 2, DateHeureDebut = new DateTime(2025, 08, 26, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 16, 0, 0), MontantFacture = 700, PoneyId = 1 } ,
                new Prestation { Id = 3, DateHeureDebut = new DateTime(2025, 08, 27, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 600, PoneyId = 1 } ,
                new Prestation { Id = 4, DateHeureDebut = new DateTime(2025, 08, 25, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 500, PoneyId = 2 } ,
                new Prestation { Id = 5, DateHeureDebut = new DateTime(2025, 08, 26, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 16, 0, 0), MontantFacture = 700, PoneyId = 2 } ,
                new Prestation { Id = 6, DateHeureDebut = new DateTime(2025, 08, 27, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 700, PoneyId = 3 } ,
                new Prestation { Id = 7, DateHeureDebut = new DateTime(2025, 08, 25, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 400, PoneyId = 3 } ,
                new Prestation { Id = 8, DateHeureDebut = new DateTime(2025, 08, 26, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 16, 0, 0), MontantFacture = 800, PoneyId = 4 } ,
                new Prestation { Id = 9, DateHeureDebut = new DateTime(2025, 08, 27, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 500, PoneyId = 4 } ,
                new Prestation { Id = 10, DateHeureDebut = new DateTime(2025, 08, 25, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 500, PoneyId = 5 } ,
                new Prestation { Id = 11, DateHeureDebut = new DateTime(2025, 08, 26, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 16, 0, 0), MontantFacture = 700, PoneyId = 6 } ,
                new Prestation { Id = 12, DateHeureDebut = new DateTime(2025, 08, 27, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 700, PoneyId = 6 } ,
                new Prestation { Id = 13, DateHeureDebut = new DateTime(2025, 08, 25, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 400, PoneyId = 6 } ,
                new Prestation { Id = 14, DateHeureDebut = new DateTime(2025, 08, 26, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 16, 0, 0), MontantFacture = 800, PoneyId = 7 } ,
                new Prestation { Id = 15, DateHeureDebut = new DateTime(2025, 08, 27, 10, 0, 0), DateHeureFin = new DateTime(2025, 08, 25, 15, 0, 0), MontantFacture = 500, PoneyId = 7 } ,
            });
        }
    }
}