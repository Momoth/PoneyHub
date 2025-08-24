using Microsoft.EntityFrameworkCore;

using PoneyHub.Application.Context;
using PoneyHub.Application.Models;
using PoneyHub.Domain.Entities;

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

        public async Task<List<GetPoney>> GetAllAsync()
        {
            return await poneyHubDbContext.Poneys.Include(p => p.Categorie).Select(p => new GetPoney
            {
                Id = p.Id,
                Coefficient = p.Coefficient,
                Description = p.Description,
                Nom = p.Nom,
                Photo = p.Photo,
                Categorie = p.Categorie != null ? p.Categorie.Libelle : null,
            }).ToListAsync();
        }

        public async Task<PaginatedResults<GetPoney>> GetAllAsync(int skip, int take)
        {
            var query = poneyHubDbContext.Poneys;

            return new PaginatedResults<GetPoney>(
                await query.Include(p => p.Categorie).Select(p => new GetPoney
                {
                    Id = p.Id,
                    Coefficient = p.Coefficient,
                    Description = p.Description,
                    Nom = p.Nom,
                    Photo = p.Photo,
                    Categorie = p.Categorie != null ? p.Categorie.Libelle : string.Empty,
                }).Skip(skip).Take(take).ToListAsync(),
                take,
                await query.CountAsync());
        }

        public async Task<GetPoney> GetAsync(int id)
        {
            var poney = await poneyHubDbContext.Poneys.Include(p => p.Categorie).SingleOrDefaultAsync(x => x.Id == id);

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
                Categorie = poney.Categorie?.Libelle
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