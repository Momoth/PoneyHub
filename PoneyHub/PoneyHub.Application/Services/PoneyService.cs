using Microsoft.EntityFrameworkCore;

using PoneyHub.Application.Context;
using PoneyHub.Application.Models;
using PoneyHub.Domain.Entities;

using System.Xml.Serialization;

namespace PoneyHub.Application.Services
{
    public class PoneyService : IPoneyService
    {
        private readonly IPoneyHubDbContext poneyHubDbContext;

        public PoneyService(IPoneyHubDbContext poneyHubDbContext)
        {
            this.poneyHubDbContext = poneyHubDbContext;
        }

        public async Task DeleteAsync(int id)
        {
            var poney = await poneyHubDbContext.Poneys.SingleAsync(x => x.Id == id);

            poneyHubDbContext.Remove(poney);

            await poneyHubDbContext.SaveChangesAsync();
        }

        public async Task<List<GetPoney>> GetAllAsync(string? order)
        {
            var poneys = poneyHubDbContext.Poneys.Include(p => p.Categorie).Select(p => new GetPoney
            {
                Id = p.Id,
                Coefficient = p.Coefficient,
                Description = p.Description,
                Nom = p.Nom,
                Photo = p.Photo,
                Categorie = p.Categorie != null ? p.Categorie.Libelle : null,
            });

            if (!string.IsNullOrEmpty(order))
            {
                switch (CodeIdentifier.MakePascal(order))
                {
                    case "Id":
                        poneys = poneys.OrderBy(p => p.Id);
                        break;

                    case "Nom":
                        poneys = poneys.OrderBy(p => p.Nom);
                        break;

                    case "Description":
                        poneys = poneys.OrderBy(p => p.Description);
                        break;

                    case "Coefficient":
                        poneys = poneys.OrderBy(p => p.Coefficient);
                        break;

                    case "Categorie":
                        poneys = poneys.OrderBy(p => p.Categorie);
                        break;
                }
            }

            return await poneys.ToListAsync();
        }

        public async Task<PaginatedResults<GetPoney>> GetAllAsync(int skip, int take, string? order)
        {
            var poneys = poneyHubDbContext.Poneys.Include(p => p.Categorie).Select(p => new GetPoney
            {
                Id = p.Id,
                Coefficient = p.Coefficient,
                Description = p.Description,
                Nom = p.Nom,
                Photo = p.Photo,
                Categorie = p.Categorie != null ? p.Categorie.Libelle : string.Empty,
            });

            if (!string.IsNullOrEmpty(order))
            {
                switch (CodeIdentifier.MakePascal(order))
                {
                    case "Id":
                        poneys = poneys.OrderBy(p => p.Id);
                        break;

                    case "Nom":
                        poneys = poneys.OrderBy(p => p.Nom);
                        break;

                    case "Description":
                        poneys = poneys.OrderBy(p => p.Description);
                        break;

                    case "Coefficient":
                        poneys = poneys.OrderBy(p => p.Coefficient);
                        break;

                    case "Categorie":
                        poneys = poneys.OrderBy(p => p.Categorie);
                        break;
                }
            }

            return new PaginatedResults<GetPoney>(
                await poneys.Skip(skip).Take(take).ToListAsync(),
                take,
                await poneys.CountAsync());
        }

        public async Task<GetPoney> GetAsync(int id)
        {
            var poney = await poneyHubDbContext.Poneys.Include(p => p.Categorie).Include(p => p.Prestations).SingleOrDefaultAsync(x => x.Id == id);

            if (poney == null)
            {
                return null;
            }

            return new GetPoney
            {
                Id = poney.Id,
                Coefficient = poney.Coefficient,
                Description = poney.Description,
                Nom = poney.Nom,
                Photo = poney.Photo,
                Categorie = poney.Categorie?.Libelle,
                Prestations = poney.Prestations.Select(p => new GetPrestation
                {
                    Id = p.Id,
                    DateHeureDebut = p.DateHeureDebut,
                    DateHeureFin = p.DateHeureFin,
                    MontantFacture = p.MontantFacture
                }).ToList()
            };
        }

        public async Task<int> InsertAsync(InsertUpdatePoney insertPoney)
        {
            var poney = new Poney
            {
                Nom = insertPoney.Nom,
                Coefficient = insertPoney.Coefficient,
                Description = insertPoney.Description,
                Photo = insertPoney.Photo,
                CategorieId = insertPoney.CategorieId
            };

            await poneyHubDbContext.Poneys.AddAsync(poney);

            await poneyHubDbContext.SaveChangesAsync();

            return poney.Id;
        }

        public async Task UpdateAsync(int id, InsertUpdatePoney updatePoney)
        {
            var poney = await poneyHubDbContext.Poneys.SingleAsync(x => x.Id == id);

            poney.Nom = updatePoney.Nom;
            poney.Description = updatePoney.Description;
            poney.Coefficient = updatePoney.Coefficient;
            poney.Photo = updatePoney.Photo;
            poney.CategorieId = updatePoney.CategorieId;

            await poneyHubDbContext.SaveChangesAsync();
        }
    }
}